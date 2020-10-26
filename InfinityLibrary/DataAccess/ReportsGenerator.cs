using InfinityLibrary.Models;
using System;
using System.Collections.Generic;

namespace InfinityLibrary.DataAccess
{
    public class ReportsGenerator
    {
        /// <summary>
        /// Get data for Status Analysis
        /// </summary>
        public List<StatusAnalysis> StatusAnalysis()
        {
            List<StatusAnalysis> statusAnalysis = new List<StatusAnalysis>();
            DefectDataAccess defect = new DefectDataAccess();
            #region Organize data into StatusAnalysis list
            foreach (var d in defect.GetAllDefects())
            {
                if (d.Status == "Open")
                {
                    var value = statusAnalysis.Find(di => di.Status == ("Open"));

                    if (value != null)
                    {
                        value.Count += 1;
                    }
                    else
                    {
                        statusAnalysis.Add(new StatusAnalysis
                        {
                            Count = 1,
                            Status = "Open"
                        });
                    }
                }
                else if (d.Status == "Closed")
                {
                    var value = statusAnalysis.Find(di => di.Status == ("Closed"));

                    if (value != null)
                    {
                        value.Count += 1;
                    }
                    else
                    {
                        statusAnalysis.Add(new StatusAnalysis
                        {
                            Count = 1,
                            Status = "Closed"
                        });
                    }
                }
                else if (d.Status == "Fixed")
                {
                    var value = statusAnalysis.Find(di => di.Status == ("Fixed"));

                    if (value != null)
                    {
                        value.Count += 1;
                    }
                    else
                    {
                        statusAnalysis.Add(new StatusAnalysis
                        {
                            Count = 1,
                            Status = "Fixed"
                        });
                    }
                }
                else if (d.Status == "Assigned")
                {
                    var value = statusAnalysis.Find(di => di.Status == ("Assigned"));

                    if (value != null)
                    {
                        value.Count += 1;
                    }
                    else
                    {
                        statusAnalysis.Add(new StatusAnalysis
                        {
                            Count = 1,
                            Status = "Assigned"
                        });
                    }
                }
                else if (d.Status == "New")
                {
                    var value = statusAnalysis.Find(di => di.Status == ("New"));

                    if (value != null)
                    {
                        value.Count += 1;
                    }
                    else
                    {
                        statusAnalysis.Add(new StatusAnalysis
                        {
                            Count = 1,
                            Status = "New"
                        });
                    }
                }
                else if (d.Status == "Rejected")
                {
                    var value = statusAnalysis.Find(di => di.Status == ("Rejected"));

                    if (value != null)
                    {
                        value.Count += 1;
                    }
                    else
                    {
                        statusAnalysis.Add(new StatusAnalysis
                        {
                            Count = 1,
                            Status = "Rejected"
                        });
                    }
                }
                else if (d.Status == "Duplicate")
                {
                    var value = statusAnalysis.Find(di => di.Status == ("Duplicate"));

                    if (value != null)
                    {
                        value.Count += 1;
                    }
                    else
                    {
                        statusAnalysis.Add(new StatusAnalysis
                        {
                            Count = 1,
                            Status = "Duplicate"
                        });
                    }
                }
                else if (d.Status == "Postponed")
                {
                    var value = statusAnalysis.Find(di => di.Status == ("Postponed"));

                    if (value != null)
                    {
                        value.Count += 1;
                    }
                    else
                    {
                        statusAnalysis.Add(new StatusAnalysis
                        {
                            Count = 1,
                            Status = "Postponed"
                        });
                    }
                }
                else if (d.Status == "Known defect")
                {
                    var value = statusAnalysis.Find(di => di.Status == ("Known defect"));

                    if (value != null)
                    {
                        value.Count += 1;
                    }
                    else
                    {
                        statusAnalysis.Add(new StatusAnalysis
                        {
                            Count = 1,
                            Status = "Known defect"
                        });
                    }
                }
                else if (d.Status == "Ready for Retest")
                {
                    var value = statusAnalysis.Find(di => di.Status == ("Ready for Retest"));

                    if (value != null)
                    {
                        value.Count += 1;
                    }
                    else
                    {
                        statusAnalysis.Add(new StatusAnalysis
                        {
                            Count = 1,
                            Status = "Ready for Retest"
                        });
                    }
                }
                else if (d.Status == "Re-Opened")
                {
                    var value = statusAnalysis.Find(di => di.Status == ("Re-Opened"));

                    if (value != null)
                    {
                        value.Count += 1;
                    }
                    else
                    {
                        statusAnalysis.Add(new StatusAnalysis
                        {
                            Count = 1,
                            Status = "Re-Opened"
                        });
                    }
                }
            }
            #endregion
            return statusAnalysis;
        }

        /// <summary>
        /// Method for calculating the age of the defects
        /// </summary>
        /// <param name="defects"></param>
        public List<int> calculateAge(List<Defect> defects)
        {
            List<int> result = new List<int>();
            for (int i = 0; i < defects.Count; i++)
            {
                if (defects[i].DateClosed != null)
                {
                    result.Add(defects[i].DateClosed.Value.Date.Day - defects[i].DateRaised.Date.Day);
                }
                else
                {
                    result.Add(DateTime.Now.Date.Day - defects[i].DateRaised.Date.Day);
                }
            }
            return result;
        }

        /// <summary>
        /// Generate data for DRR Analysis
        /// </summary>
        /// <returns></returns>
        public List<DRRAnalysis> DrrAnalysis()
        {
            DefectDataAccess defect = new DefectDataAccess();
            var defects = defect.GetAllDefects();
            UserAdminDataAccess user = new UserAdminDataAccess();
            var users = user.GetAllUsers();
            var testers = new List<User>();
            foreach (var u in users) // Getting a list of testers
            {
                if (u.UserType == "Tester")
                {
                    testers.Add(u);
                }
            }

            ProjectDataAccess project = new ProjectDataAccess();
            var projects = project.GetAllProjects();

            var drr = new List<DRRAnalysis>();
            foreach (var t in testers)
            {
                foreach (var p in projects)
                {
                    var results = defects.FindAll(r => r.ProjectName == p.ProjectName && r.RaisedBy == t.Username);
                    var drrValue = 0;
                    foreach (var r in results)
                    {
                        drrValue += r.DRR; // Calculate the DRR for the specific Tester and specific Project
                    }
                    drr.Add(new DRRAnalysis
                    {
                        Tester = t.Username,
                        ProjectName = p.ProjectName,
                        DRR = 100 + drrValue
                    });
                }
            }
            return drr;
        }
    }
}
