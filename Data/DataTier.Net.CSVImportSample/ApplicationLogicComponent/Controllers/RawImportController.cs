

#region using statements

using ApplicationLogicComponent.DataBridge;
using ApplicationLogicComponent.DataOperations;
using ApplicationLogicComponent.Logging;
using ObjectLibrary.BusinessObjects;
using System;
using System.Collections.Generic;

#endregion


namespace ApplicationLogicComponent.Controllers
{

    #region class RawImportController
    /// <summary>
    /// This class controls a(n) 'RawImport' object.
    /// </summary>
    public class RawImportController
    {

        #region Private Variables
        private ErrorHandler errorProcessor;
        private ApplicationController appController;
        #endregion

        #region Constructor
        /// <summary>
        /// Creates a new 'RawImportController' object.
        /// </summary>
        public RawImportController(ErrorHandler errorProcessorArg, ApplicationController appControllerArg)
        {
            // Save Arguments
            this.ErrorProcessor = errorProcessorArg;
            this.AppController = appControllerArg;
        }
        #endregion

        #region Methods

            #region CreateRawImportParameter
            /// <summary>
            /// This method creates the parameter for a 'RawImport' data operation.
            /// </summary>
            /// <param name='rawimport'>The 'RawImport' to use as the first
            /// parameter (parameters[0]).</param>
            /// <returns>A List<PolymorphicObject> collection.</returns>
            private List<PolymorphicObject> CreateRawImportParameter(RawImport rawImport)
            {
                // Initial Value
                List<PolymorphicObject> parameters = new List<PolymorphicObject>();

                // Create PolymorphicObject to hold the parameter
                PolymorphicObject parameter = new PolymorphicObject();

                // Set parameter.ObjectValue
                parameter.ObjectValue = rawImport;

                // Add userParameter to parameters
                parameters.Add(parameter);

                // return value
                return parameters;
            }
            #endregion

            #region Delete(RawImport tempRawImport)
            /// <summary>
            /// Deletes a 'RawImport' from the database
            /// This method calls the DataBridgeManager to execute the delete using the
            /// procedure 'RawImport_Delete'.
            /// </summary>
            /// <param name='rawimport'>The 'RawImport' to delete.</param>
            /// <returns>True if the delete is successful or false if not.</returns>
            public bool Delete(RawImport tempRawImport)
            {
                // locals
                bool deleted = false;

                // Get information for calling 'DataBridgeManager.PerformDataOperation' method.
                string methodName = "DeleteRawImport";
                string objectName = "ApplicationLogicComponent.Controllers";

                try
                {
                    // verify temprawImport exists before attemptintg to delete
                    if(tempRawImport != null)
                    {
                        // Create Delegate For DataOperation
                        ApplicationController.DataOperationMethod deleteRawImportMethod = this.AppController.DataBridge.DataOperations.RawImportMethods.DeleteRawImport;

                        // Create parameters for this method
                        List<PolymorphicObject> parameters = CreateRawImportParameter(tempRawImport);

                        // Perform DataOperation
                        PolymorphicObject returnObject = this.AppController.DataBridge.PerformDataOperation(methodName, objectName, deleteRawImportMethod, parameters);

                        // If return object exists
                        if (returnObject != null)
                        {
                            // Test For True
                            if (returnObject.Boolean.Value == NullableBooleanEnum.True)
                            {
                                // Set Deleted To True
                                deleted = true;
                            }
                        }
                    }
                }
                catch (Exception error)
                {
                    // If ErrorProcessor exists
                    if (this.ErrorProcessor != null)
                    {
                        // Log the current error
                        this.ErrorProcessor.LogError(methodName, objectName, error);
                    }
                }

                // return value
                return deleted;
            }
            #endregion

            #region FetchAll(RawImport tempRawImport)
            /// <summary>
            /// This method fetches a collection of 'RawImport' objects.
            /// This method used the DataBridgeManager to execute the fetch all using the
            /// procedure 'RawImport_FetchAll'.</summary>
            /// <param name='tempRawImport'>A temporary RawImport for passing values.</param>
            /// <returns>A collection of 'RawImport' objects.</returns>
            public List<RawImport> FetchAll(RawImport tempRawImport)
            {
                // Initial value
                List<RawImport> rawImportList = null;

                // Get information for calling 'DataBridgeManager.PerformDataOperation' method.
                string methodName = "FetchAll";
                string objectName = "ApplicationLogicComponent.Controllers";

                try
                {
                    // Create DataOperation Method
                    ApplicationController.DataOperationMethod fetchAllMethod = this.AppController.DataBridge.DataOperations.RawImportMethods.FetchAll;

                    // Create parameters for this method
                    List<PolymorphicObject> parameters = CreateRawImportParameter(tempRawImport);

                    // Perform DataOperation
                    PolymorphicObject returnObject = this.AppController.DataBridge.PerformDataOperation(methodName, objectName, fetchAllMethod , parameters);

                    // If return object exists
                    if ((returnObject != null) && (returnObject.ObjectValue as List<RawImport> != null))
                    {
                        // Create Collection From ReturnObject.ObjectValue
                        rawImportList = (List<RawImport>) returnObject.ObjectValue;
                    }
                }
                catch (Exception error)
                {
                    // If ErrorProcessor exists
                    if (this.ErrorProcessor != null)
                    {
                        // Log the current error
                        this.ErrorProcessor.LogError(methodName, objectName, error);
                    }
                }

                // return value
                return rawImportList;
            }
            #endregion

            #region Find(RawImport tempRawImport)
            /// <summary>
            /// Finds a 'RawImport' object by the primary key.
            /// This method used the DataBridgeManager to execute the 'Find' using the
            /// procedure 'RawImport_Find'</param>
            /// </summary>
            /// <param name='tempRawImport'>A temporary RawImport for passing values.</param>
            /// <returns>A 'RawImport' object if found else a null 'RawImport'.</returns>
            public RawImport Find(RawImport tempRawImport)
            {
                // Initial values
                RawImport rawImport = null;

                // Get information for calling 'DataBridgeManager.PerformDataOperation' method.
                string methodName = "Find";
                string objectName = "ApplicationLogicComponent.Controllers";

                try
                {
                    // If object exists
                    if(tempRawImport != null)
                    {
                        // Create DataOperation
                        ApplicationController.DataOperationMethod findMethod = this.AppController.DataBridge.DataOperations.RawImportMethods.FindRawImport;

                        // Create parameters for this method
                        List<PolymorphicObject> parameters = CreateRawImportParameter(tempRawImport);

                        // Perform DataOperation
                        PolymorphicObject returnObject = this.AppController.DataBridge.PerformDataOperation(methodName, objectName, findMethod , parameters);

                        // If return object exists
                        if ((returnObject != null) && (returnObject.ObjectValue as RawImport != null))
                        {
                            // Get ReturnObject
                            rawImport = (RawImport) returnObject.ObjectValue;
                        }
                    }
                }
                catch (Exception error)
                {
                    // If ErrorProcessor exists
                    if (this.ErrorProcessor != null)
                    {
                        // Log the current error
                        this.ErrorProcessor.LogError(methodName, objectName, error);
                    }
                }

                // return value
                return rawImport;
            }
            #endregion

            #region Insert(RawImport rawImport)
            /// <summary>
            /// Insert a 'RawImport' object into the database.
            /// This method uses the DataBridgeManager to execute the 'Insert' using the
            /// procedure 'RawImport_Insert'.</param>
            /// </summary>
            /// <param name='rawImport'>The 'RawImport' object to insert.</param>
            /// <returns>The id (int) of the new  'RawImport' object that was inserted.</returns>
            public int Insert(RawImport rawImport)
            {
                // Initial values
                int newIdentity = -1;

                // Get information for calling 'DataBridgeManager.PerformDataOperation' method.
                string methodName = "Insert";
                string objectName = "ApplicationLogicComponent.Controllers";

                try
                {
                    // If RawImportexists
                    if(rawImport != null)
                    {
                        ApplicationController.DataOperationMethod insertMethod = this.AppController.DataBridge.DataOperations.RawImportMethods.InsertRawImport;

                        // Create parameters for this method
                        List<PolymorphicObject> parameters = CreateRawImportParameter(rawImport);

                        // Perform DataOperation
                        PolymorphicObject returnObject = this.AppController.DataBridge.PerformDataOperation(methodName, objectName, insertMethod , parameters);

                        // If return object exists
                        if (returnObject != null)
                        {
                            // Set return value
                            newIdentity = returnObject.IntegerValue;
                        }
                    }
                }
                catch (Exception error)
                {
                    // If ErrorProcessor exists
                    if (this.ErrorProcessor != null)
                    {
                        // Log the current error
                        this.ErrorProcessor.LogError(methodName, objectName, error);
                    }
                }

                // return value
                return newIdentity;
            }
            #endregion

            #region Save(ref RawImport rawImport)
            /// <summary>
            /// Saves a 'RawImport' object into the database.
            /// This method calls the 'Insert' or 'Update' method.
            /// </summary>
            /// <param name='rawImport'>The 'RawImport' object to save.</param>
            /// <returns>True if successful or false if not.</returns>
            public bool Save(ref RawImport rawImport)
            {
                // Initial value
                bool saved = false;

                // If the rawImport exists.
                if(rawImport != null)
                {
                    // Is this a new RawImport
                    if(rawImport.IsNew)
                    {
                        // Insert new RawImport
                        int newIdentity = this.Insert(rawImport);

                        // if insert was successful
                        if(newIdentity > 0)
                        {
                            // Update Identity
                            rawImport.UpdateIdentity(newIdentity);

                            // Set return value
                            saved = true;
                        }
                    }
                    else
                    {
                        // Update RawImport
                        saved = this.Update(rawImport);
                    }
                }

                // return value
                return saved;
            }
            #endregion

            #region Update(RawImport rawImport)
            /// <summary>
            /// This method Updates a 'RawImport' object in the database.
            /// This method used the DataBridgeManager to execute the 'Update' using the
            /// procedure 'RawImport_Update'.</param>
            /// </summary>
            /// <param name='rawImport'>The 'RawImport' object to update.</param>
            /// <returns>True if successful else false if not.</returns>
            public bool Update(RawImport rawImport)
            {
                // Initial value
                bool saved = false;

                // Get information for calling 'DataBridgeManager.PerformDataOperation' method.
                string methodName = "Update";
                string objectName = "ApplicationLogicComponent.Controllers";

                try
                {
                    if(rawImport != null)
                    {
                        // Create Delegate
                        ApplicationController.DataOperationMethod updateMethod = this.AppController.DataBridge.DataOperations.RawImportMethods.UpdateRawImport;

                        // Create parameters for this method
                        List<PolymorphicObject> parameters = CreateRawImportParameter(rawImport);
                        // Perform DataOperation
                        PolymorphicObject returnObject = this.AppController.DataBridge.PerformDataOperation(methodName, objectName, updateMethod , parameters);

                        // If return object exists
                        if ((returnObject != null) && (returnObject.Boolean != null) && (returnObject.Boolean.Value == NullableBooleanEnum.True))
                        {
                            // Set saved to true
                            saved = true;
                        }
                    }
                }
                catch (Exception error)
                {
                    // If ErrorProcessor exists
                    if (this.ErrorProcessor != null)
                    {
                        // Log the current error
                        this.ErrorProcessor.LogError(methodName, objectName, error);
                    }
                }

                // return value
                return saved;
            }
            #endregion

        #endregion

        #region Properties

            #region AppController
            public ApplicationController AppController
            {
                get { return appController; }
                set { appController = value; }
            }
            #endregion

            #region ErrorProcessor
            public ErrorHandler ErrorProcessor
            {
                get { return errorProcessor; }
                set { errorProcessor = value; }
            }
            #endregion

        #endregion

    }
    #endregion

}
