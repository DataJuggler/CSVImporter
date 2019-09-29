

#region using statements

using DataAccessComponent.DataManager.Readers;
using DataAccessComponent.StoredProcedureManager.DeleteProcedures;
using DataAccessComponent.StoredProcedureManager.FetchProcedures;
using DataAccessComponent.StoredProcedureManager.InsertProcedures;
using DataAccessComponent.StoredProcedureManager.UpdateProcedures;
using ObjectLibrary.BusinessObjects;
using System;
using System.Collections.Generic;
using System.Data;

#endregion


namespace DataAccessComponent.DataManager
{

    #region class RawImportManager
    /// <summary>
    /// This class is used to manage a 'RawImport' object.
    /// </summary>
    public class RawImportManager
    {

        #region Private Variables
        private DataManager dataManager;
        private DataHelper dataHelper;
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a 'RawImportManager' object.
        /// </summary>
        public RawImportManager(DataManager dataManagerArg)
        {
            // Set DataManager
            this.DataManager = dataManagerArg;

            // Perform Initialization
            Init();
        }
        #endregion

        #region Methods

            #region DeleteRawImport()
            /// <summary>
            /// This method deletes a 'RawImport' object.
            /// </summary>
            /// <returns>True if successful false if not.</returns>
            /// </summary>
            public bool DeleteRawImport(DeleteRawImportStoredProcedure deleteRawImportProc, DataConnector databaseConnector)
            {
                // Initial Value
                bool deleted = false;

                // Verify database connection is connected
                if ((databaseConnector != null) && (databaseConnector.Connected))
                {
                    // Execute Non Query
                    deleted = this.DataHelper.DeleteRecord(deleteRawImportProc, databaseConnector);
                }

                // return value
                return deleted;
            }
            #endregion

            #region FetchAllRawImports()
            /// <summary>
            /// This method fetches a  'List<RawImport>' object.
            /// This method uses the 'RawImports_FetchAll' procedure.
            /// </summary>
            /// <returns>A 'List<RawImport>'</returns>
            /// </summary>
            public List<RawImport> FetchAllRawImports(FetchAllRawImportsStoredProcedure fetchAllRawImportsProc, DataConnector databaseConnector)
            {
                // Initial Value
                List<RawImport> rawImportCollection = null;

                // Verify database connection is connected
                if ((databaseConnector != null) && (databaseConnector.Connected))
                {
                    // First Get Dataset
                    DataSet allRawImportsDataSet = this.DataHelper.LoadDataSet(fetchAllRawImportsProc, databaseConnector);

                    // Verify DataSet Exists
                    if(allRawImportsDataSet != null)
                    {
                        // Get DataTable From DataSet
                        DataTable table = this.DataHelper.ReturnFirstTable(allRawImportsDataSet);

                        // if table exists
                        if(table != null)
                        {
                            // Load Collection
                            rawImportCollection = RawImportReader.LoadCollection(table);
                        }
                    }
                }

                // return value
                return rawImportCollection;
            }
            #endregion

            #region FindRawImport()
            /// <summary>
            /// This method finds a  'RawImport' object.
            /// This method uses the 'RawImport_Find' procedure.
            /// </summary>
            /// <returns>A 'RawImport' object.</returns>
            /// </summary>
            public RawImport FindRawImport(FindRawImportStoredProcedure findRawImportProc, DataConnector databaseConnector)
            {
                // Initial Value
                RawImport rawImport = null;

                // Verify database connection is connected
                if ((databaseConnector != null) && (databaseConnector.Connected))
                {
                    // First Get Dataset
                    DataSet rawImportDataSet = this.DataHelper.LoadDataSet(findRawImportProc, databaseConnector);

                    // Verify DataSet Exists
                    if(rawImportDataSet != null)
                    {
                        // Get DataTable From DataSet
                        DataRow row = this.DataHelper.ReturnFirstRow(rawImportDataSet);

                        // if row exists
                        if(row != null)
                        {
                            // Load RawImport
                            rawImport = RawImportReader.Load(row);
                        }
                    }
                }

                // return value
                return rawImport;
            }
            #endregion

            #region Init()
            /// <summary>
            /// Perorm Initialization For This Object
            /// </summary>
            private void Init()
            {
                // Create DataHelper object
                this.DataHelper = new DataHelper();
            }
            #endregion

            #region InsertRawImport()
            /// <summary>
            /// This method inserts a 'RawImport' object.
            /// This method uses the 'RawImport_Insert' procedure.
            /// </summary>
            /// <returns>The identity value of the new record.</returns>
            /// </summary>
            public int InsertRawImport(InsertRawImportStoredProcedure insertRawImportProc, DataConnector databaseConnector)
            {
                // Initial Value
                int newIdentity = -1;

                // Verify database connection is connected
                if ((databaseConnector != null) && (databaseConnector.Connected))
                {
                    // Execute Non Query
                    newIdentity = this.DataHelper.InsertRecord(insertRawImportProc, databaseConnector);
                }

                // return value
                return newIdentity;
            }
            #endregion

            #region UpdateRawImport()
            /// <summary>
            /// This method updates a 'RawImport'.
            /// This method uses the 'RawImport_Update' procedure.
            /// </summary>
            /// <returns>True if successful false if not.</returns>
            /// </summary>
            public bool UpdateRawImport(UpdateRawImportStoredProcedure updateRawImportProc, DataConnector databaseConnector)
            {
                // Initial Value
                bool saved = false;

                // Verify database connection is connected
                if ((databaseConnector != null) && (databaseConnector.Connected))
                {
                    // Execute Update.
                    saved = this.DataHelper.UpdateRecord(updateRawImportProc, databaseConnector);
                }

                // return value
                return saved;
            }
            #endregion

        #endregion

        #region Properties

            #region DataHelper
            /// <summary>
            /// This object uses the Microsoft Data
            /// Application Block to execute stored
            /// procedures.
            /// </summary>
            internal DataHelper DataHelper
            {
                get { return dataHelper; }
                set { dataHelper = value; }
            }
            #endregion

            #region DataManager
            /// <summary>
            /// A reference to this objects parent.
            /// </summary>
            internal DataManager DataManager
            {
                get { return dataManager; }
                set { dataManager = value; }
            }
            #endregion

        #endregion

    }
    #endregion

}
