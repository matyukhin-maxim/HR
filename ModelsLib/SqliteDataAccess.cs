﻿using Dapper;
using HelperLib.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics;
using System.Linq;

namespace HelperLib {
    public class SqliteDataAccess {

        public static string GetConnectionString(string name = "Default") {

            return ConfigurationManager.ConnectionStrings[name]?.ConnectionString;
        }

        public static List<PersonModel> GetAllPersonal() {

            using (IDbConnection cn = new SQLiteConnection(GetConnectionString())) {

                try {

                    const string sql = @"
                                select 
                                    p.id, p.fullname, p.baserate, p.hiredate, 
                                    g.name, p.groupid
                                from personal p
                                inner join groups g on p.groupid = g.id
                                order by p.fullname";

                    return cn.Query<PersonModel>(sql).ToList();
                }
                catch (Exception e) {

                    Debug.WriteLine(e.Message);
                }

                return null;
            }
        }

        public static List<PersonModel> GetDependentPersonal(int BossId) {

            using (IDbConnection cn = new SQLiteConnection(GetConnectionString())) {
                const string sql = @"select 
                                        p.fullname, p.id, p.groupid, p.hiredate, p.baserate 
                                    from relations r
                                    inner join personal p on r.person_id = p.id 
                                    where r.boss_id = @BossId";

                return cn.Query<PersonModel>(sql, new { BossId }).ToList();
            }
        }

        public static List<IGroup> GetAllGroups() {

            var res = new List<IGroup>();

            try {

                using (IDbConnection cn = new SQLiteConnection(GetConnectionString())) {

                    var raw = cn.Query<Employee>("select * from groups");
                    foreach (var x in raw) {

                        // dynamic create class based on class name
                        var type = Type.GetType("HelperLib.Models." + x.Name);
                        if (type != null) {

                            if (Activator.CreateInstance(type) is IGroup group) {

                                group.Id = x.Id;
                                group.Name = x.Name;
                                group.YearCoeff = x.YearCoeff;
                                group.YearCoeffLimit = x.YearCoeffLimit;
                                group.BonusPercent = x.BonusPercent;

                                res.Add(group);
                            }
                        }
                    }
                }
            }
            catch (Exception e) {

                Debug.WriteLine(e.Message);
            }

            return res;
        }

        public static bool SavePerson(PersonModel employee) {

            try {

                using (IDbConnection cn = new SQLiteConnection(GetConnectionString())) {

                    var sql = employee.Id > 0
                        ? @"update personal set 
                            FullName = @FullName, 
                            BaseRate = @BaseRate, 
                            HireDate = @HireDate, 
                            GroupId = @GroupId 
                            where Id = @Id"
                        : @"insert into personal (FullName, BaseRate, HireDate, GroupId)
                            values (@FullName, @BaseRate, @HireDate, @GroupId)";

                    return cn.Execute(sql, employee) > 0;
                }
            }
            catch (Exception e) {

                Debug.WriteLine(e.Message);
            }

            return false;
        }

        public static void DeletePersonal(PersonModel employee) {

            try {

                using (IDbConnection cn = new SQLiteConnection(GetConnectionString())) {

                    cn.Open();
                    var tr = cn.BeginTransaction(IsolationLevel.ReadCommitted);
                    cn.Execute("delete from relations where person_id = @Id or boss_id = @Id", employee, tr);
                    cn.Execute("delete from personal where Id = @Id", employee, tr);

                    tr.Commit();
                    // cascade fk don't remove record from 'relations' table [probably bug]
                }
            }
            catch (Exception e) {

                //Debug.WriteLine(e.Message);
                Debug.WriteLine(e.ToString());
            }
        }
    }
}
