using Dapper;
using InfinityLibrary.Helpers;
using InfinityLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace InfinityLibrary.DataAccess
{
    public class ProjectDataAccess
    {
        /// <summary>
        /// Get Projects List Function
        /// </summary>
        /// <returns></returns>
        public List<Project> GetAllProjects()
        {
            List<Project> projects = new List<Project>();
            try
            {
                projects = DbConnector.connection.Query<Project>("dbo.spProjects_GetAll").ToList();
            }
            catch (Exception ex)
            {
                new Exception(ExceptionHandler.dbCorruptedEx.ToString(), ex).Log().Display();
            }
            return projects;
        }

        /// <summary>
        /// Search Projects Function
        /// </summary>
        /// <returns></returns>
        public List<Project> SearchProjects(string input)
        {
            List<Project> projects = new List<Project>();
            try
            {
                // Search with LIKE querys
                projects = DbConnector.connection.Query<Project>("dbo.spProjects_Search @Input", new { Input = $"%{ input }%" }).ToList();
            }
            catch (Exception ex)
            {
                new Exception(ExceptionHandler.dbCorruptedEx.ToString(), ex).Log().Display();
            }
            return projects;
        }

        /// <summary>
        /// Insert Project Function
        /// </summary>
        /// <param name="projectName"></param>
        /// <param name="Manager"></param>
        /// <param name="frontEndDev"></param>
        /// <param name="backEndDev"></param>
        /// <param name="tester"></param>
        /// <param name="priority"></param>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <returns></returns>
        public bool InsertProject(string projectName, string manager, string frontEndDev, string backEndDev, string tester, string priority, DateTime startDate, DateTime endDate)
        {
            try
            {
                List<Project> projects = new List<Project>();
                projects.Add(new Project
                {
                    ProjectName = projectName,
                    Manager = manager,
                    FrontEndDev = frontEndDev,
                    BackEndDev = backEndDev,
                    Tester = tester,
                    Priority = priority,
                    StartDate = startDate,
                    EndDate = endDate
                });
                DbConnector.connection.Execute("dbo.spProjects_Insert @ProjectName, @Manager, @FrontEndDev, @BackEndDev, @Tester, @Priority, @StartDate, @EndDate", projects);
                return true;
            }
            catch (Exception ex)
            {
                new Exception(ExceptionHandler.dbCorruptedEx.ToString(), ex).Log();
                return false;
            }
        }

        /// <summary>
        /// Update Project Function
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="projectName"></param>
        /// <param name="manager"></param>
        /// <param name="frontEndDev"></param>
        /// <param name="backEndDev"></param>
        /// <param name="tester"></param>
        /// <param name="priority"></param>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <returns></returns>
        public bool UpdateProject(int projectId, string projectName, string manager, string frontEndDev, string backEndDev, string tester, string priority, DateTime startDate, DateTime endDate)
        {
            try
            {
                List<Project> projects = new List<Project>();
                projects.Add(new Project
                {
                    ProjectId = projectId,
                    ProjectName = projectName,
                    Manager = manager,
                    FrontEndDev = frontEndDev,
                    BackEndDev = backEndDev,
                    Tester = tester,
                    Priority = priority,
                    StartDate = startDate,
                    EndDate = endDate
                });
                DbConnector.connection.Execute("dbo.spProjects_Update @ProjectId, @ProjectName, @Manager, @FrontEndDev, @BackEndDev, @Tester, @Priority, @StartDate, @EndDate", projects);
                return true;
            }
            catch (Exception ex)
            {
                new Exception(ExceptionHandler.dbCorruptedEx.ToString(), ex).Log();
                return false;
            }
        }

        /// <summary>
        /// Delete Project Function
        /// </summary>
        /// <param name="projectId"></param>
        /// <returns></returns>
        public bool DeleteProject(int projectId)
        {
            try
            {
                DbConnector.connection.Execute("dbo.spProjects_Delete @ProjectId", new { ProjectId = projectId });
                return true;
            }
            catch (Exception ex)
            {
                new Exception(ExceptionHandler.dbCorruptedEx.ToString(), ex).Log();
                return false;
            }
        }

        /// <summary>
        /// Find Project Function
        /// </summary>
        /// <param name="projectId"></param>
        /// <returns></returns>
        public Project FindProject(int projectId)
        {
            Project project = null;
            try
            {
                project = DbConnector.connection.Query<Project>("dbo.spProjects_FindProject @ProjectId", new { ProjectId = projectId }).Single();
            }
            catch (Exception ex)
            {
                new Exception(ExceptionHandler.dbCorruptedEx.ToString(), ex).Log().Display();
            }
            return project;
        }

        /// <summary>
        /// Find Project by Project Name Function
        /// </summary>
        /// <param name="projectName"></param>
        /// <returns></returns>
        public int FindProjectByProjectName(string projectName)
        {
            Project project = null;
            try
            {
                project = DbConnector.connection.Query<Project>("dbo.spProjects_FindProjectByProjectName @ProjectName", new { ProjectName = projectName }).Single();
            }
            catch (Exception ex)
            {
                new Exception(ExceptionHandler.dbCorruptedEx.ToString(), ex).Log().Display();
            }
            return project.ProjectId;
        }

        /// <summary>
        /// Check if Project Name already exists in the database
        /// </summary>
        /// <param name="projectName"></param>
        /// <returns></returns>
        public bool IsProjectNameExist(string projectName)
        {
            try
            {
                DbConnector.connection.Query<User>("dbo.spProjects_IsProjectNameExists @ProjectName", new { ProjectName = projectName }).Single();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
