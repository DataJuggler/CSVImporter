

#region using statements

using DataAccessComponent.StoredProcedureManager.DeleteProcedures;
using DataAccessComponent.StoredProcedureManager.FetchProcedures;
using DataAccessComponent.StoredProcedureManager.InsertProcedures;
using DataAccessComponent.StoredProcedureManager.UpdateProcedures;
using DataJuggler.Net;
using System;

#endregion


namespace DataAccessComponent.StoredProcedureManager.DeleteProcedures
{

    #region class DeleteRawImportStoredProcedure
    /// <summary>
    /// This class is used to Delete a 'RawImport' object.
    /// </summary>
    public class DeleteRawImportStoredProcedure : StoredProcedure
    {

        #region Private Variables
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a 'DeleteRawImportStoredProcedure' object.
        /// </summary>
        public DeleteRawImportStoredProcedure()
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
                this.ProcedureName = "RawImport_Delete";

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
