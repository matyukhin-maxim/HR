using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using HelperLib;
using HelperLib.Models;

namespace WinAppUI {
    public partial class frmMain : Form {
        private readonly List<PersonModel> personalList = new List<PersonModel>();
        private string prevValue = string.Empty;

        public frmMain() {
            InitializeComponent();
        }

        private void ReloadStaffList(object sender, EventArgs e) {

            var groups = SqliteDataAccess.GetAllGroups();
            cbGroup.DataSource = null;
            cbGroup.DataSource = groups;
            cbGroup.DisplayMember = "Name";
            cbGroup.ValueMember = "Id";

            personalList.Clear();
            var lst = SqliteDataAccess.GetAllPersonal();
            if (lst != null) personalList.AddRange(lst);

            lbStaff.DataSource = null;
            lbStaff.DataSource = personalList;
            lbStaff.DisplayMember = "FullName";

            prevValue = "0";
        }

        private void lbStaff_SelectedIndexChanged(object sender, EventArgs e) {

            if (!(lbStaff.SelectedItem is PersonModel p)) return;

            cbGroup.SelectedValue = p.GroupId;
            tbName.Text = p.FullName;
            tbRate.Text = p.BaseRate.ToString("F2");
            dpHireDate.Value = p.HireDate;

            lbRelations.DataSource = null;
            lbRelations.DataSource = SqliteDataAccess.GetDependentPersonal(p.Id);
            lbRelations.DisplayMember = "FullName";

            dpCalcDate.Value = DateTime.Now;
            tbSalaryPerson.Text = 0.ToString("F2");
        }

        private void tbRate_TextChanged(object sender, EventArgs e) {

            Regex r = new Regex(@"^\d+[\.,]{0,1}\d*$");
            if (r.Match(tbRate.Text).Success) {

                prevValue = tbRate.Text;
            }
            else {
                tbRate.Text = prevValue;
                tbRate.SelectionStart = prevValue.Length;
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e) {

            // if person don't select -> exit
            if (!(lbStaff.SelectedItem is PersonModel p)) return;

            var totalP = 0.0;

            // find person group
            if (cbGroup.SelectedItem is IGroup grp) {

                totalP = grp.CalculateSalary(p, dpCalcDate.Value);
            }

            tbSalaryPerson.Text = totalP.ToString("F2");
        }

        private void dpCalcDate_ValueChanged(object sender, EventArgs e) {
            
            // clear precalculated salary cache
            Routine.SalaryCache.Clear();
        }
    }
}
