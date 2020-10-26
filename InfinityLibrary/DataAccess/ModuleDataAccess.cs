using Dapper;
using InfinityLibrary.Helpers;
using InfinityLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace InfinityLibrary.DataAccess
{
    public class ModuleDataAccess
    {
        /// <summary>
        /// Get Modules List Function
        /// </summary>
        /// <returns></returns>
        public List<Module> GetAllModules(int projectId)
        {
            List<Module> modules = new List<Module>();
            try
            {
                modules = DbConnector.connection.Query<Module>("dbo.spModules_GetAll @ProjectId", new { ProjectId = projectId }).ToList();
            }
            catch (Exception ex)
            {
                new Exception(ExceptionHandler.dbCorruptedEx.ToString(), ex).Log().Display();
            }
            return modules;
        }

        /// <summary>
        /// Search Modules Function
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public List<Module> SearchModules(string input)
        {
            List<Module> modules = new List<Module>();
            try
            {
                // Search with LIKE querys
                modules = DbConnector.connection.Query<Module>("dbo.spModules_Search @Input", new { Input = $"%{ input }%" }).ToList();
            }
            catch (Exception ex)
            {
                new Exception(ExceptionHandler.dbCorruptedEx.ToString(), ex).Log().Display();
            }
            return modules;
        }

        /// <summary>
        /// Insert Module Function
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="moduleName"></param>
        /// <param name="moduleFunction"></param>
        /// <param name="addedBy"></param>
        /// <returns></returns>
        public bool InsertModule(int projectId, string moduleName, string moduleFunction, string addedBy)
        {
            try
            {
                List<Module> modules = new List<Module>();
                modules.Add(new Module
                {
                    ProjectId = projectId,
                    ModuleName = moduleName,
                    ModuleFunction = moduleFunction,
                    AddedBy = addedBy
                });
                DbConnector.connection.Execute("dbo.spModules_Insert @ProjectId, @ModuleName, @ModuleFunction, @AddedBy", modules);
                return true;
            }
            catch (Exception ex)
            {
                new Exception(ExceptionHandler.dbCorruptedEx.ToString(), ex).Log();
                return false;
            }
        }

        /// <summary>
        /// Update Module Function
        /// </summary>
        /// <param name="moduleId"></param>
        /// <param name="moduleName"></param>
        /// <param name="moduleFunction"></param>
        /// <param name="addedBy"></param>
        /// <returns></returns>
        public bool UpdateModule(int moduleId, string moduleName, string moduleFunction, string addedBy)
        {
            try
            {
                List<Module> modules = new List<Module>();
                modules.Add(new Module
                {
                    ModuleId = moduleId,
                    ModuleName = moduleName,
                    ModuleFunction = moduleFunction,
                    AddedBy = addedBy
                });
                DbConnector.connection.Execute("dbo.spModules_Update @ModuleId, @ModuleName, @ModuleFunction, @AddedBy", modules);
                return true;
            }
            catch (Exception ex)
            {
                new Exception(ExceptionHandler.dbCorruptedEx.ToString(), ex).Log();
                return false;
            }
        }

        /// <summary>
        /// Delete Module Function
        /// </summary>
        /// <param name="moduleId"></param>
        /// <returns></returns>
        public bool DeleteModule(int moduleId)
        {
            try
            {
                DbConnector.connection.Execute("dbo.spModules_Delete @ModuleId", new { ModuleId = moduleId });
                return true;
            }
            catch (Exception ex)
            {
                new Exception(ExceptionHandler.dbCorruptedEx.ToString(), ex).Log();
                return false;
            }
        }

        /// <summary>
        /// Find Module Function
        /// </summary>
        /// <param name="moduleId"></param>
        /// <returns></returns>
        public Module FindModule(int moduleId)
        {
            Module module = null;
            try
            {
                module = DbConnector.connection.Query<Module>("dbo.spModules_FindModule @ModuleId", new { ModuleId = moduleId }).Single();
            }
            catch (Exception ex)
            {
                new Exception(ExceptionHandler.dbCorruptedEx.ToString(), ex).Log().Display();
            }
            return module;
        }

        /// <summary>
        /// Find Module by Project Function
        /// </summary>
        /// <param name="projectId"></param>
        /// <returns></returns>
        public List<Module> FindModuleByProject(int projectId)
        {
            List<Module> modules = new List<Module>();
            try
            {
                modules = DbConnector.connection.Query<Module>("dbo.spModules_FindModuleByProjectId @ProjectId", new { ProjectId = projectId }).ToList();
            }
            catch (Exception ex)
            {
                new Exception(ExceptionHandler.dbCorruptedEx.ToString(), ex).Log().Display();
            }
            return modules;
        }
    }
}
