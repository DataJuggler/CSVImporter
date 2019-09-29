
#region using statements

using ApplicationLogicComponent.Controllers;
using ApplicationLogicComponent.DataOperations;
using DataAccessComponent.DataManager;
using ObjectLibrary.BusinessObjects;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

#endregion

namespace DataGateway
{

    #region class Gateway
    /// <summary>
    /// This class is used to manage DataOperations
    /// between the client and the DataAccessComponent.
    /// Do not change the method name or the parameters for the
    /// code generated methods or they will be recreated the next 
    /// time you code generate with DataTier.Net. If you need additional
    /// parameters passed to a method either create an override or
    /// add or set properties to the temp object that is passed in.
    /// </summary>
    public class Gateway
    {

        #region Private Variables
        private ApplicationController appController;
        private string connectionName;
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a Gateway object.
        /// </summary>
        /// <param name="connectionName">Optional. If supplied DataTier.Net will read an environment variable
        /// by the name to determine the ConnectionString to use.</param>
        /// If not supplied, the ConnectionString must still be read from an app.config or web.config.
        /// At some point in the future, the ConnectionString in an app.config or web.config will no longer be supported.
        /// This will probably be when Dot Net 5 comes out, which I think is towards the end of the year in 2020.
        public Gateway(string connectionName = "")
        {
            // store the ConnectionName
            this.ConnectionName = connectionName;

            // Perform Initializations for this object
            Init();
        }
        #endregion

        #region Methods

            #region DeleteRawImport(int id, RawImport tempRawImport = null)
            /// <summary>
            /// This method is used to delete RawImport objects.
            /// </summary>
            /// <param name="id">Delete the RawImport with this id</param>
            /// <param name="tempRawImport">Pass in a tempRawImport to perform a custom delete.</param>
            public bool DeleteRawImport(int id, RawImport tempRawImport = null)
            {
                // initial value
                bool deleted = false;
        
                // if the AppController exists
                if (this.HasAppController)
                {
                    // if the tempRawImport does not exist
                    if (tempRawImport == null)
                    {
                        // create a temp RawImport
                        tempRawImport = new RawImport();
                    }
        
                    // if the id is set
                    if (id > 0)
                    {
                        // set the primary key
                        tempRawImport.UpdateIdentity(id);
                    }
        
                    // perform the delete
                    deleted = this.AppController.ControllerManager.RawImportController.Delete(tempRawImport);
                }
        
                // return value
                return deleted;
            }
            #endregion
        
        #region ExecuteNonQuery(string procedureName, SqlParameter[] sqlParameters)
        /// <summary>
        /// This method Executes a Non Query StoredProcedure
        /// </summary>
        public PolymorphicObject ExecuteNonQuery(string procedureName, SqlParameter[] sqlParameters)
        {
            // initial value
            PolymorphicObject returnValue = new PolymorphicObject();

            // locals
            List<PolymorphicObject> parameters = new List<PolymorphicObject>();

            // create the parameters
            PolymorphicObject procedureNameParameter = new PolymorphicObject();
            PolymorphicObject sqlParametersParameter = new PolymorphicObject();

            // if the procedureName exists
            if (!String.IsNullOrEmpty(procedureName))
            {
                // Create an instance of the SystemMethods object
                SystemMethods systemMethods = new SystemMethods();

                // setup procedureNameParameter
                procedureNameParameter.Name = "ProcedureName";
                procedureNameParameter.Text = procedureName;

                // setup sqlParametersParameter
                sqlParametersParameter.Name = "SqlParameters";
                sqlParametersParameter.ObjectValue = sqlParameters;

                // Add these parameters to the parameters
                parameters.Add(procedureNameParameter);
                parameters.Add(sqlParametersParameter);

                // get the dataConnector
                DataAccessComponent.DataManager.DataConnector dataConnector = GetDataConnector();

                // Execute the query
                returnValue = systemMethods.ExecuteNonQuery(parameters, dataConnector);
            }

            // return value
            return returnValue;
        }
        #endregion

            #region FindRawImport(int id, RawImport tempRawImport = null)
            /// <summary>
            /// This method is used to find 'RawImport' objects.
            /// </summary>
            /// <param name="id">Find the RawImport with this id</param>
            /// <param name="tempRawImport">Pass in a tempRawImport to perform a custom find.</param>
            public RawImport FindRawImport(int id, RawImport tempRawImport = null)
            {
                // initial value
                RawImport rawImport = null;

                // if the AppController exists
                if (this.HasAppController)
                {
                    // if the tempRawImport does not exist
                    if (tempRawImport == null)
                    {
                        // create a temp RawImport
                        tempRawImport = new RawImport();
                    }

                    // if the id is set
                    if (id > 0)
                    {
                        // set the primary key
                        tempRawImport.UpdateIdentity(id);
                    }

                    // perform the find
                    rawImport = this.AppController.ControllerManager.RawImportController.Find(tempRawImport);
                }

                // return value
                return rawImport;
            }
            #endregion

        #region FindRawImportFieldsByFieldName(string fieldName)
        /// <summary>
        /// This method is used to find 'RawImportFields' objects for the FieldName given.
        /// </summary>
        public RawImportFields FindRawImportFieldsByFieldName(string fieldName)
        {
            // initial value
            RawImportFields rawImportFields = null;
            
            // Create a temp RawImportFields object
            RawImportFields tempRawImportFields = new RawImportFields();
            
            // Set the value for FindByFieldName to true
            tempRawImportFields.FindByFieldName = true;
            
            // Set the value for FieldName
            tempRawImportFields.FieldName = fieldName;
            
            // Perform the find
            rawImportFields = FindRawImportFields(0, tempRawImportFields);
            
            // return value
            return rawImportFields;
        }
        #endregion
        
        #region GetDataConnector()
        /// <summary>
        /// This method (safely) returns the Data Connector from the
        /// AppController.DataBridget.DataManager.DataConnector
        /// </summary>
        private DataConnector GetDataConnector()
        {
            // initial value
            DataConnector dataConnector = null;

            // if the AppController exists
            if (this.AppController != null)
            {
                // return the DataConnector from the AppController
                dataConnector = this.AppController.GetDataConnector();
            }

            // return value
            return dataConnector;
        }
        #endregion

        #region GetLastException()
        /// <summary>
        /// This method returns the last Exception from the AppController if one exists.
        /// Always test for null before refeferencing the Exception returned as it will be null 
        /// if no errors were encountered.
        /// </summary>
        /// <returns></returns>
        public Exception GetLastException()
        {
            // initial value
            Exception exception = null;

            // If the AppController object exists
            if (this.HasAppController)
            {
                // return the Exception from the AppController
                exception = this.AppController.Exception;

                // Set to null after the exception is retrieved so it does not return again
                this.AppController.Exception = null;
            }

            // return value
            return exception;
        }
        #endregion

        #region Init()
        /// <summary>
        /// Perform Initializations for this object.
        /// </summary>
        private void Init()
        {
            // Create Application Controller
            this.AppController = new ApplicationController(ConnectionName);
        }
        #endregion

            #region LoadRawImports(RawImport tempRawImport = null)
            /// <summary>
            /// This method loads a collection of 'RawImport' objects.
            /// </summary>
            public List<RawImport> LoadRawImports(RawImport tempRawImport = null)
            {
                // initial value
                List<RawImport> rawImports = null;

                // if the AppController exists
                if (this.HasAppController)
                {
                    // perform the load
                    rawImports = this.AppController.ControllerManager.RawImportController.FetchAll(tempRawImport);
                }

                // return value
                return rawImports;
            }
            #endregion

            #region SaveRawImport(ref RawImport rawImport)
            /// <summary>
            /// This method is used to save 'RawImport' objects.
            /// </summary>
            /// <param name="rawImport">The RawImport to save.</param>
            public bool SaveRawImport(ref RawImport rawImport)
            {
                // initial value
                bool saved = false;

                // if the AppController exists
                if (this.HasAppController)
                {
                    // perform the save
                    saved = this.AppController.ControllerManager.RawImportController.Save(ref rawImport);
                }

                // return value
                return saved;
            }
            #endregion

        #endregion

        #region Properties

        #region AppController
        /// <summary>
        /// This property gets or sets the value for 'AppController'.
        /// </summary>
        public ApplicationController AppController
        {
            get { return appController; }
            set { appController = value; }
        }
        #endregion

        #region ConnectionName
        /// <summary>
        /// This property gets or sets the value for 'ConnectionName'.
        /// </summary>
        public string ConnectionName
        {
            get { return connectionName; }
            set { connectionName = value; }
        }
        #endregion

        #region HasAppController
        /// <summary>
        /// This property returns true if this object has an 'AppController'.
        /// </summary>
        public bool HasAppController
        {
            get
            {
                // initial value
                bool hasAppController = (this.AppController != null);

                // return value
                return hasAppController;
            }
        }
        #endregion

        #region HasConnectionName
        /// <summary>
        /// This property returns true if the 'ConnectionName' exists.
        /// </summary>
        public bool HasConnectionName
        {
            get
            {
                // initial value
                bool hasConnectionName = (!String.IsNullOrEmpty(this.ConnectionName));

                // return value
                return hasConnectionName;
            }
        }
        #endregion

        #endregion

    }
    #endregion

}


