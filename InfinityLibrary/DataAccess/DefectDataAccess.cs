using Dapper;
using InfinityLibrary.Helpers;
using InfinityLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace InfinityLibrary.DataAccess
{
    public class DefectDataAccess
    {
        /// <summary>
        /// Get Defects List Function
        /// </summary>
        /// <returns></returns>
        public List<Defect> GetAllDefects()
        {
            List<Defect> defects = new List<Defect>();
            try
            {
                defects = DbConnector.connection.Query<Defect>("dbo.spDefects_GetAll").ToList();
            }
            catch (Exception ex)
            {
                new Exception(ExceptionHandler.dbCorruptedEx.ToString(), ex).Log().Display();
            }
            return defects;
        }

        /// <summary>
        /// Search Defects Function
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public List<Defect> SearchDefects(string input)
        {
            List<Defect> defects = new List<Defect>();
            try
            {
                // Search with LIKE querys
                defects = DbConnector.connection.Query<Defect>("dbo.spDefects_Search @Input", new { Input = $"%{ input }%" }).ToList();
            }
            catch (Exception ex)
            {
                new Exception(ExceptionHandler.dbCorruptedEx.ToString(), ex).Log().Display();
            }
            return defects;
        }

        /// <summary>
        /// Search Defects for Analysis Function
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public List<Defect> SearchDefectsAnalysis(string input)
        {
            List<Defect> defects = new List<Defect>();
            try
            {
                // Search with LIKE querys
                defects = DbConnector.connection.Query<Defect>("dbo.spDefects_SearchAnalysis @Input", new { Input = $"%{ input }%" }).ToList();
            }
            catch (Exception ex)
            {
                new Exception(ExceptionHandler.dbCorruptedEx.ToString(), ex).Log().Display();
            }
            return defects;
        }

        /// <summary>
        /// Search Defects for Tester or Dev Function
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public List<Defect> SearchDefects(string username, string input, string role)
        {
            List<Defect> defects = new List<Defect>();
            try
            {
                // Search with LIKE querys
                if (role == "Tester")
                {
                    defects = DbConnector.connection.Query<Defect>("dbo.spDefects_SearchForTester @Username, @Input", new { Username = username, Input = $"%{ input }%" }).ToList();
                }
                else if (role == "Dev")
                {
                    defects = DbConnector.connection.Query<Defect>("dbo.spDefects_SearchForDev @Username, @Input", new { Username = username, Input = $"%{ input }%" }).ToList();
                }
            }
            catch (Exception ex)
            {
                new Exception(ExceptionHandler.dbCorruptedEx.ToString(), ex).Log().Display();
            }
            return defects;
        }

        /// <summary>
        /// Find Defects by Tester or Dev Function
        /// </summary>
        /// <param name="defectId"></param>
        /// <returns></returns>
        public List<Defect> FindDefects(string username, string role)
        {
            List<Defect> defects = new List<Defect>();
            try
            {
                if (role == "Tester")
                {
                    defects = DbConnector.connection.Query<Defect>("dbo.spDefects_FindDefectByTester @Username", new { Username = username }).ToList();
                }
                else if (role == "Dev")
                {
                    defects = DbConnector.connection.Query<Defect>("dbo.spDefects_FindDefectByDev @Username", new { Username = username }).ToList();
                }
            }
            catch (Exception ex)
            {
                new Exception(ExceptionHandler.dbCorruptedEx.ToString(), ex).Log().Display();
            }
            return defects;
        }

        /// <summary>
        /// Insert Defect Function
        /// </summary>
        /// <param name="projectName"></param>
        /// <param name="moduleName"></param>
        /// <param name="description"></param>
        /// <param name="stepsToRepeat"></param>
        /// <param name="raisedBy"></param>
        /// <param name="priority"></param>
        /// <returns></returns>
        public bool InsertDefect(string projectName, string moduleName, string description, string stepsToRepeat, string raisedBy, string priority)
        {
            try
            {
                List<Defect> defects = new List<Defect>();
                defects.Add(new Defect
                {
                    ProjectName = projectName,
                    ModuleName = moduleName,
                    Description = description,
                    StepsToRepeat = stepsToRepeat,
                    RaisedBy = raisedBy,
                    Status = "New",
                    Priority = priority,
                    DateRaised = DateTime.Now.Date,
                    DRR = 0,
                    DRE = 1
                });
                DbConnector.connection.Execute(@"dbo.spDefects_Insert @ProjectName, @ModuleName, @Description, @StepsToRepeat, @RaisedBy,  
                                               @Status, @Priority, @DateRaised, @DRR, @DRE", defects);
                return true;
            }
            catch (Exception ex)
            {
                new Exception(ExceptionHandler.dbCorruptedEx.ToString(), ex).Log();
                return false;
            }
        }

        /// <summary>
        /// Update Defect Function
        /// </summary>
        /// <param name="defectId"></param>
        /// <param name="projectName"></param>
        /// <param name="moduleName"></param>
        /// <param name="description"></param>
        /// <param name="stepsToRepeat"></param>
        /// <param name="raisedBy"></param>
        /// <param name="assignedTo"></param>
        /// <param name="status"></param>
        /// <param name="priority"></param>
        /// <param name = "dateClosed" ></ param >
        /// <param name = "drr" ></ param >
        /// <param name="dre"></param>
        /// <returns></returns>
        public bool UpdateDefect(int defectId, string projectName, string moduleName, string description, string stepsToRepeat,
            string assignedTo, string status, string priority, DateTime? dateClosed, int drr, int dre)
        {
            try
            {
                List<Defect> defects = new List<Defect>();
                defects.Add(new Defect
                {
                    DefectId = defectId,
                    ProjectName = projectName,
                    ModuleName = moduleName,
                    Description = description,
                    StepsToRepeat = stepsToRepeat,
                    AssignedTo = assignedTo,
                    Status = status,
                    Priority = priority,
                    DateClosed = dateClosed,
                    DRR = drr,
                    DRE = dre
                });
                DbConnector.connection.Execute(@"dbo.spDefects_Update @DefectId, @ProjectName, @ModuleName, @Description, @StepsToRepeat,
                                               @AssignedTo, @Status, @Priority, @DateClosed, @DRR, @DRE", defects);
                return true;
            }
            catch (Exception ex)
            {
                new Exception(ExceptionHandler.dbCorruptedEx.ToString(), ex).Log();
                return false;
            }
        }

        /// <summary>
        /// Delete Defect Function
        /// </summary>
        /// <param name="defectId"></param>
        /// <returns></returns>
        public bool DeleteDefect(int defectId)
        {
            try
            {
                DbConnector.connection.Execute("dbo.spDefects_Delete @DefectId", new { DefectId = defectId });
                return true;
            }
            catch (Exception ex)
            {
                new Exception(ExceptionHandler.dbCorruptedEx.ToString(), ex).Log();
                return false;
            }
        }

        /// <summary>
        /// Find Defect Function
        /// </summary>
        /// <param name="defectId"></param>
        /// <returns></returns>
        public virtual Defect FindDefect(int defectId)
        {
            Defect defect = null;
            try
            {
                defect = DbConnector.connection.Query<Defect>("dbo.spDefects_FindDefect @DefectId", new { DefectId = defectId }).Single();
            }
            catch (Exception ex)
            {
                new Exception(ExceptionHandler.dbCorruptedEx.ToString(), ex).Log().Display();
            }
            return defect;
        }
    }
}
