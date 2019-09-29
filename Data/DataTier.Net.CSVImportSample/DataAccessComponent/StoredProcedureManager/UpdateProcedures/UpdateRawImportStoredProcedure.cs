

#region using statements

using DataAccessComponent.StoredProcedureManager.DeleteProcedures;
using DataAccessComponent.StoredProcedureManager.FetchProcedures;
using DataAccessComponent.StoredProcedureManager.InsertProcedures;
using DataAccessComponent.StoredProcedureManager.UpdateProcedures;
using DataJuggler.Net;
using System;

#endregion


namespace DataAccessComponent.StoredProcedureManager.UpdateProcedures
{

    #region class UpdateRawImportStoredProcedure
    /// <summary>
    /// This class is used to Update a 'RawImport' object.
    /// </summary>
    public class UpdateRawImportStoredProcedure : StoredProcedure
    {

        #region Private Variables
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a 'UpdateRawImportStoredProcedure' object.
        /// </summary>
        public UpdateRawImportStoredProcedure()
        {
            // Perform Initialization
            Init();
        }
        #endregion

        #region Methods

            #region Init()
            /// <summary>
            /// Set Procedure Properties
            /// </summary>
            private void Init()
            {
                // Set Properties For This Proc

                // Set ProcedureName
                this.ProcedureName = "RawImport_Update";

                // Set tableName
                this.TableName = "RawImport";
            }
            #endregion

        #endregion

        #region Properties

        #endregion

    }
    #endregion

}
