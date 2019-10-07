using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics;
using Dapper;
using HelperLib.Models;

namespace HelperLib {
    public class SqliteDataAccess {

        public static string GetConnectionString(string name = "Default") {

            return ConfigurationManager.ConnectionStrings[name]?.ConnectionString;
        }

        public static Dictionary<int, PersonModel> GetAllPersonal() {

            using (IDbConnection cn = new SQLiteConnection(GetConnectionString())) {

                try {

                     return 
                         cn.Query<PersonModel>("select * from personal order by groupid")
                        .ToDictionary(x => x.Id, x => x);

                }
                catch (Exception e) {

                    Debug.WriteLine(e.Message);
                }

                return null;
            }
        }

        public static List<RelationModel> GetRelationship() {

            using (IDbConnection cn = new SQLiteConnection(GetConnectionString())) {
                const string sql = @"select 
                                    person_id person, boss_id boss 
                                    from relations";
                return cn.Query<RelationModel>(sql).ToList();
            }
        }
    }
}
