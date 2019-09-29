

#region using statements

using DataAccessComponent.StoredProcedureManager.DeleteProcedures;
using DataAccessComponent.StoredProcedureManager.FetchProcedures;
using DataAccessComponent.StoredProcedureManager.InsertProcedures;
using DataAccessComponent.StoredProcedureManager.UpdateProcedures;
using DataJuggler.Net;
using System;

#endregion


namespace DataAccessComponent.StoredProcedureManager.FetchProcedures
{

    #region class FetchAllRawImportsStoredProcedure
    /// <summary>
    /// This class is used to FetchAll 'RawImport' objects.
    /// </summary>
    public class FetchAllRawImportsStoredProcedure : StoredProcedure
    {

        #region Private Variables
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a 'FetchAllRawImportsStoredProcedure' object.
        /// </summary>
        public FetchAllRawImportsStoredProcedure()
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
                this.ProcedureName = "RawImport_FetchAll";

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
