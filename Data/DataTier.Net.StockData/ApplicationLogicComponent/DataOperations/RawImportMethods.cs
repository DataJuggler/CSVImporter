

#region using statements

using ApplicationLogicComponent.DataBridge;
using DataAccessComponent.DataManager;
using DataAccessComponent.DataManager.Writers;
using DataAccessComponent.StoredProcedureManager.DeleteProcedures;
using DataAccessComponent.StoredProcedureManager.FetchProcedures;
using DataAccessComponent.StoredProcedureManager.InsertProcedures;
using DataAccessComponent.StoredProcedureManager.UpdateProcedures;
using ObjectLibrary.BusinessObjects;
using System;
using System.Collections.Generic;

#endregion


namespace ApplicationLogicComponent.DataOperations
{

    #region class RawImportMethods
    /// <summary>
    /// This class contains methods for modifying a 'RawImport' object.
    /// </summary>
    public class RawImportMethods
    {

        #region Private Variables
        private DataManager dataManager;
        #endregion

        #region Constructor
        /// <summary>
        /// Creates a new Creates a new 'RawImportMethods' object.
        /// </summary>
        public RawImportMethods(DataManager dataManagerArg)
        {
            // Save Argument
            this.DataManager = dataManagerArg;
        }
        #endregion

        #region Methods

            #region DeleteRawImport(RawImport)
            /// <summary>
            /// This method deletes a 'RawImport' object.
            /// </summary>
            /// <param name='List<PolymorphicObject>'>The 'RawImport' to delete.
            /// <returns>A PolymorphicObject object with a Boolean value.
            internal PolymorphicObject DeleteRawImport(List<PolymorphicObject> parameters, DataConnector dataConnector)
            {
                // Initial Value
                PolymorphicObject returnObject = new PolymorphicObject();

                // If the data connection is connected
                if ((dataConnector != null) && (dataConnector.Connected == true))
                {
                    // Create Delete StoredProcedure
                    DeleteRawImportStoredProcedure deleteRawImportProc = null;

                    // verify the first parameters is a(n) 'RawImport'.
                    if (parameters[0].ObjectValue as RawImport != null)
                    {
                        // Create RawImport
                        RawImport rawImport = (RawImport) parameters[0].ObjectValue;

                        // verify rawImport exists
                        if(rawImport != null)
                        {
                            // Now create deleteRawImportProc from RawImportWriter
                            // The DataWriter converts the 'RawImport'
                            // to the SqlParameter[] array needed to delete a 'RawImport'.
                            deleteRawImportProc = RawImportWriter.CreateDeleteRawImportStoredProcedure(rawImport);
                        }
                    }

                    // Verify deleteRawImportProc exists
                    if(deleteRawImportProc != null)
                    {
                        // Execute Delete Stored Procedure
                        bool deleted = this.DataManager.RawImportManager.DeleteRawImport(deleteRawImportProc, dataConnector);

                        // Create returnObject.Boolean
                        returnObject.Boolean = new NullableBoolean();

                        // If delete was successful
                        if(deleted)
                        {
                            // Set returnObject.Boolean.Value to true
                            returnObject.Boolean.Value = NullableBooleanEnum.True;
                        }
                        else
                        {
                            // Set returnObject.Boolean.Value to false
                            returnObject.Boolean.Value = NullableBooleanEnum.False;
                        }
                    }
                }
                else
                {
                    // Raise Error Data Connection Not Available
                    throw new Exception("The database connection is not available.");
                }

                // return value
                return returnObject;
            }
            #endregion

            #region FetchAll()
            /// <summary>
            /// This method fetches all 'RawImport' objects.
            /// </summary>
            /// <param name='List<PolymorphicObject>'>The 'RawImport' to delete.
            /// <returns>A PolymorphicObject object with all  'RawImports' objects.
            internal PolymorphicObject FetchAll(List<PolymorphicObject> parameters, DataConnector dataConnector)
            {
                // Initial Value
                PolymorphicObject returnObject = new PolymorphicObject();

                // locals
                List<RawImport> rawImportListCollection =  null;

                // Create FetchAll StoredProcedure
                FetchAllRawImportsStoredProcedure fetchAllProc = null;

                // If the data connection is connected
                if ((dataConnector != null) && (dataConnector.Connected == true))
                {
                    // Get RawImportParameter
                    // Declare Parameter
                    RawImport paramRawImport = null;

                    // verify the first parameters is a(n) 'RawImport'.
                    if (parameters[0].ObjectValue as RawImport != null)
                    {
                        // Get RawImportParameter
                        paramRawImport = (RawImport) parameters[0].ObjectValue;
                    }

                    // Now create FetchAllRawImportsProc from RawImportWriter
                    fetchAllProc = RawImportWriter.CreateFetchAllRawImportsStoredProcedure(paramRawImport);
                }

                // Verify fetchAllProc exists
                if(fetchAllProc!= null)
                {
                    // Execute FetchAll Stored Procedure
                    rawImportListCollection = this.DataManager.RawImportManager.FetchAllRawImports(fetchAllProc, dataConnector);

                    // if dataObjectCollection exists
                    if(rawImportListCollection != null)
                    {
                        // set returnObject.ObjectValue
                        returnObject.ObjectValue = rawImportListCollection;
                    }
                }
                else
                {
                    // Raise Error Data Connection Not Available
                    throw new Exception("The database connection is not available.");
                }

                // return value
                return returnObject;
            }
            #endregion

            #region FindRawImport(RawImport)
            /// <summary>
            /// This method finds a 'RawImport' object.
            /// </summary>
            /// <param name='List<PolymorphicObject>'>The 'RawImport' to delete.
            /// <returns>A PolymorphicObject object with a Boolean value.
            internal PolymorphicObject FindRawImport(List<PolymorphicObject> parameters, DataConnector dataConnector)
            {
                // Initial Value
                PolymorphicObject returnObject = new PolymorphicObject();

                // locals
                RawImport rawImport = null;

                // If the data connection is connected
                if ((dataConnector != null) && (dataConnector.Connected == true))
                {
                    // Create Find StoredProcedure
                    FindRawImportStoredProcedure findRawImportProc = null;

                    // verify the first parameters is a 'RawImport'.
                    if (parameters[0].ObjectValue as RawImport != null)
                    {
                        // Get RawImportParameter
                        RawImport paramRawImport = (RawImport) parameters[0].ObjectValue;

                        // verify paramRawImport exists
                        if(paramRawImport != null)
                        {
                            // Now create findRawImportProc from RawImportWriter
                            // The DataWriter converts the 'RawImport'
                            // to the SqlParameter[] array needed to find a 'RawImport'.
                            findRawImportProc = RawImportWriter.CreateFindRawImportStoredProcedure(paramRawImport);
                        }

                        // Verify findRawImportProc exists
                        if(findRawImportProc != null)
                        {
                            // Execute Find Stored Procedure
                            rawImport = this.DataManager.RawImportManager.FindRawImport(findRawImportProc, dataConnector);

                            // if dataObject exists
                            if(rawImport != null)
                            {
                                // set returnObject.ObjectValue
                                returnObject.ObjectValue = rawImport;
                            }
                        }
                    }
                    else
                    {
                        // Raise Error Data Connection Not Available
                        throw new Exception("The database connection is not available.");
                    }
                }

                // return value
                return returnObject;
            }
            #endregion

            #region InsertRawImport (RawImport)
            /// <summary>
            /// This method inserts a 'RawImport' object.
            /// </summary>
            /// <param name='List<PolymorphicObject>'>The 'RawImport' to insert.
            /// <returns>A PolymorphicObject object with a Boolean value.
            internal PolymorphicObject InsertRawImport(List<PolymorphicObject> parameters, DataConnector dataConnector)
            {
                // Initial Value
                PolymorphicObject returnObject = new PolymorphicObject();

                // locals
                RawImport rawImport = null;

                // If the data connection is connected
                if ((dataConnector != null) && (dataConnector.Connected == true))
                {
                    // Create Insert StoredProcedure
                    InsertRawImportStoredProcedure insertRawImportProc = null;

                    // verify the first parameters is a(n) 'RawImport'.
                    if (parameters[0].ObjectValue as RawImport != null)
                    {
                        // Create RawImport Parameter
                        rawImport = (RawImport) parameters[0].ObjectValue;

                        // verify rawImport exists
                        if(rawImport != null)
                        {
                            // Now create insertRawImportProc from RawImportWriter
                            // The DataWriter converts the 'RawImport'
                            // to the SqlParameter[] array needed to insert a 'RawImport'.
                            insertRawImportProc = RawImportWriter.CreateInsertRawImportStoredProcedure(rawImport);
                        }

                        // Verify insertRawImportProc exists
                        if(insertRawImportProc != null)
                        {
                            // Execute Insert Stored Procedure
                            returnObject.IntegerValue = this.DataManager.RawImportManager.InsertRawImport(insertRawImportProc, dataConnector);
                        }

                    }
                    else
                    {
                        // Raise Error Data Connection Not Available
                        throw new Exception("The database connection is not available.");
                    }
                }

                // return value
                return returnObject;
            }
            #endregion

            #region UpdateRawImport (RawImport)
            /// <summary>
            /// This method updates a 'RawImport' object.
            /// </summary>
            /// <param name='List<PolymorphicObject>'>The 'RawImport' to update.
            /// <returns>A PolymorphicObject object with a value.
            internal PolymorphicObject UpdateRawImport(List<PolymorphicObject> parameters, DataConnector dataConnector)
            {
                // Initial Value
                PolymorphicObject returnObject = new PolymorphicObject();

                // locals
                RawImport rawImport = null;

                // If the data connection is connected
                if ((dataConnector != null) && (dataConnector.Connected == true))
                {
                    // Create Update StoredProcedure
                    UpdateRawImportStoredProcedure updateRawImportProc = null;

                    // verify the first parameters is a(n) 'RawImport'.
                    if (parameters[0].ObjectValue as RawImport != null)
                    {
                        // Create RawImport Parameter
                        rawImport = (RawImport) parameters[0].ObjectValue;

                        // verify rawImport exists
                        if(rawImport != null)
                        {
                            // Now create updateRawImportProc from RawImportWriter
                            // The DataWriter converts the 'RawImport'
                            // to the SqlParameter[] array needed to update a 'RawImport'.
                            updateRawImportProc = RawImportWriter.CreateUpdateRawImportStoredProcedure(rawImport);
                        }

                        // Verify updateRawImportProc exists
                        if(updateRawImportProc != null)
                        {
                            // Execute Update Stored Procedure
                            bool saved = this.DataManager.RawImportManager.UpdateRawImport(updateRawImportProc, dataConnector);

                            // Create returnObject.Boolean
                            returnObject.Boolean = new NullableBoolean();

                            // If save was successful
                            if(saved)
                            {
                                // Set returnObject.Boolean.Value to true
                                returnObject.Boolean.Value = NullableBooleanEnum.True;
                            }
                            else
                            {
                                // Set returnObject.Boolean.Value to false
                                returnObject.Boolean.Value = NullableBooleanEnum.False;
                            }
                        }
                        else
                        {
                            // Raise Error Data Connection Not Available
                            throw new Exception("The database connection is not available.");
                        }
                    }
                }

                // return value
                return returnObject;
            }
            #endregion

        #endregion

        #region Properties

            #region DataManager 
            public DataManager DataManager 
            {
                get { return dataManager; }
                set { dataManager = value; }
            }
            #endregion

        #endregion

    }
    #endregion

}
