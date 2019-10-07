using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HelperLib;
using HelperLib.Models;

namespace WinAppUI {
    public partial class frmMain : Form {

        Dictionary<int, PersonModel> personalDictionary = new Dictionary<int, PersonModel>();

        public frmMain() {
            InitializeComponent();
        }

        private void LoadPersonal(object sender, EventArgs e) {

            var y = new DateTime(2019, 10, 1);
            var x = DateTime.Now;
            Console.WriteLine(x.AddYears(1).AddDays(-1));

            personalDictionary.Clear();
            personalDictionary = SqliteDataAccess.GetAllPersonal();
            foreach (var pair in personalDictionary) {
                
                // Заполним группу по id
                switch (pair.Value.GroupId) {
                    case 1:
                        pair.Value.Group = new Employee();
                        break;
                    case 2:
                        pair.Value.Group = new Manager();
                        break;
                    case 3:
                        pair.Value.Group = new Salesman();
                        break;
                    default:
                        Debug.WriteLine("Unknown group id found");
                        break;
                }

                pair.Value.CalculateSalary(DateTime.Now);
            }

            // Получим список "связей" между сотрудниками
            var relationship = SqliteDataAccess.GetRelationship();
            foreach (var relationModel in relationship) {

                // Благодаря foreign key можно не боятся что сотрудник не будет найден
                personalDictionary[relationModel.Boss] = personalDictionary[relationModel.Boss];

                try {

                    // Добавляем подчиненного если группа определена
                    var grp = personalDictionary[relationModel.Boss].Group;
                    grp?.AddDependent(personalDictionary[relationModel.Person]);
                }
                catch (Exception ex) {

                    // Ошибка будет при попытке добавить подчиненного к Employee
                    Debug.WriteLine(ex.Message);
                }
            }
        }
    }
}
