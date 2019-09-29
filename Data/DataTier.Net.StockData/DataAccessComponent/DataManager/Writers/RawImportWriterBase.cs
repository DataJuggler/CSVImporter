

#region using statements

using DataAccessComponent.StoredProcedureManager.DeleteProcedures;
using DataAccessComponent.StoredProcedureManager.FetchProcedures;
using DataAccessComponent.StoredProcedureManager.InsertProcedures;
using DataAccessComponent.StoredProcedureManager.UpdateProcedures;
using ObjectLibrary.BusinessObjects;
using System;
using System.Data;
using System.Data.SqlClient;

#endregion


namespace DataAccessComponent.DataManager.Writers
{

    #region class RawImportWriterBase
    /// <summary>
    /// This class is used for converting a 'RawImport' object to
    /// the SqlParameter[] to perform the CRUD methods.
    /// </summary>
    public class RawImportWriterBase
    {

        #region Static Methods

            #region CreatePrimaryKeyParameter(RawImport rawImport)
            /// <summary>
            /// This method creates the sql Parameter[] array
            /// that holds the primary key value.
            /// </summary>
            /// <param name='rawImport'>The 'RawImport' to get the primary key of.</param>
            /// <returns>A SqlParameter[] array which contains the primary key value.
            /// to delete.</returns>
            internal static SqlParameter[] CreatePrimaryKeyParameter(RawImport rawImport)
            {
                // Initial Value
                SqlParameter[] parameters = new SqlParameter[1];

                // verify user exists
                if (rawImport != null)
                {
                    // Create PrimaryKey Parameter
                    SqlParameter @Id = new SqlParameter("@Id", rawImport.Id);

                    // Set parameters[0] to @Id
                    parameters[0] = @Id;
                }

                // return value
                return parameters;
            }
            #endregion

            #region CreateDeleteRawImportStoredProcedure(RawImport rawImport)
            /// <summary>
            /// This method creates an instance of an
            /// 'DeleteRawImport'StoredProcedure' object and
            /// creates the sql parameter[] array needed
            /// to execute the procedure 'RawImport_Delete'.
            /// </summary>
            /// <param name="rawImport">The 'RawImport' to Delete.</param>
            /// <returns>An instance of a 'DeleteRawImportStoredProcedure' object.</returns>
            public static DeleteRawImportStoredProcedure CreateDeleteRawImportStoredProcedure(RawImport rawImport)
            {
                // Initial Value
                DeleteRawImportStoredProcedure deleteRawImportStoredProcedure = new DeleteRawImportStoredProcedure();

                // Now Create Parameters For The DeleteProc
                deleteRawImportStoredProcedure.Parameters = CreatePrimaryKeyParameter(rawImport);

                // return value
                return deleteRawImportStoredProcedure;
            }
            #endregion

            #region CreateFindRawImportStoredProcedure(RawImport rawImport)
            /// <summary>
            /// This method creates an instance of a
            /// 'FindRawImportStoredProcedure' object and
            /// creates the sql parameter[] array needed
            /// to execute the procedure 'RawImport_Find'.
            /// </summary>
            /// <param name="rawImport">The 'RawImport' to use to
            /// get the primary key parameter.</param>
            /// <returns>An instance of an FetchUserStoredProcedure</returns>
            public static FindRawImportStoredProcedure CreateFindRawImportStoredProcedure(RawImport rawImport)
            {
                // Initial Value
                FindRawImportStoredProcedure findRawImportStoredProcedure = null;

                // verify rawImport exists
                if(rawImport != null)
                {
                    // Instanciate findRawImportStoredProcedure
                    findRawImportStoredProcedure = new FindRawImportStoredProcedure();

                    // Now create parameters for this procedure
                    findRawImportStoredProcedure.Parameters = CreatePrimaryKeyParameter(rawImport);
                }

                // return value
                return findRawImportStoredProcedure;
            }
            #endregion

            #region CreateInsertParameters(RawImport rawImport)
            /// <summary>
            /// This method creates the sql Parameters[] needed for
            /// inserting a new rawImport.
            /// </summary>
            /// <param name="rawImport">The 'RawImport' to insert.</param>
            /// <returns></returns>
            internal static SqlParameter[] CreateInsertParameters(RawImport rawImport)
            {
                // Initial Values
                SqlParameter[] parameters = new SqlParameter[8];
                SqlParameter param = null;

                // verify rawImportexists
                if(rawImport != null)
                {
                    // Create [Close] parameter
                    param = new SqlParameter("@Close", rawImport.Close);

                    // set parameters[0]
                    parameters[0] = param;

                    // Create [Date] parameter
                    param = new SqlParameter("@Date", rawImport.Date);

                    // set parameters[1]
                    parameters[1] = param;

                    // Create [High] parameter
                    param = new SqlParameter("@High", rawImport.High);

                    // set parameters[2]
                    parameters[2] = param;

                    // Create [Low] parameter
                    param = new SqlParameter("@Low", rawImport.Low);

                    // set parameters[3]
                    parameters[3] = param;

                    // Create [Open] parameter
                    param = new SqlParameter("@Open", rawImport.Open);

                    // set parameters[4]
                    parameters[4] = param;

                    // Create [Per] parameter
                    param = new SqlParameter("@Per", rawImport.Per);

                    // set parameters[5]
                    parameters[5] = param;

                    // Create [Ticker] parameter
                    param = new SqlParameter("@Ticker", rawImport.Ticker);

                    // set parameters[6]
                    parameters[6] = param;

                    // Create [Vol] parameter
                    param = new SqlParameter("@Vol", rawImport.Vol);

                    // set parameters[7]
                    parameters[7] = param;
                }

                // return value
                return parameters;
            }
            #endregion

            #region CreateInsertRawImportStoredProcedure(RawImport rawImport)
            /// <summary>
            /// This method creates an instance of an
            /// 'InsertRawImportStoredProcedure' object and
            /// creates the sql parameter[] array needed
            /// to execute the procedure 'RawImport_Insert'.
            /// </summary>
            /// <param name="rawImport"The 'RawImport' object to insert</param>
            /// <returns>An instance of a 'InsertRawImportStoredProcedure' object.</returns>
            public static InsertRawImportStoredProcedure CreateInsertRawImportStoredProcedure(RawImport rawImport)
            {
                // Initial Value
                InsertRawImportStoredProcedure insertRawImportStoredProcedure = null;

                // verify rawImport exists
                if(rawImport != null)
                {
                    // Instanciate insertRawImportStoredProcedure
                    insertRawImportStoredProcedure = new InsertRawImportStoredProcedure();

                    // Now create parameters for this procedure
                    insertRawImportStoredProcedure.Parameters = CreateInsertParameters(rawImport);
                }

                // return value
                return insertRawImportStoredProcedure;
            }
            #endregion

            #region CreateUpdateParameters(RawImport rawImport)
            /// <summary>
            /// This method creates the sql Parameters[] needed for
            /// update an existing rawImport.
            /// </summary>
            /// <param name="rawImport">The 'RawImport' to update.</param>
            /// <returns></returns>
            internal static SqlParameter[] CreateUpdateParameters(RawImport rawImport)
            {
                // Initial Values
                SqlParameter[] parameters = new SqlParameter[9];
                SqlParameter param = null;

                // verify rawImportexists
                if(rawImport != null)
                {
                    // Create parameter for [Close]
                    param = new SqlParameter("@Close", rawImport.Close);

                    // set parameters[0]
                    parameters[0] = param;

                    // Create parameter for [Date]
                    param = new SqlParameter("@Date", rawImport.Date);

                    // set parameters[1]
                    parameters[1] = param;

                    // Create parameter for [High]
                    param = new SqlParameter("@High", rawImport.High);

                    // set parameters[2]
                    parameters[2] = param;

                    // Create parameter for [Low]
                    param = new SqlParameter("@Low", rawImport.Low);

                    // set parameters[3]
                    parameters[3] = param;

                    // Create parameter for [Open]
                    param = new SqlParameter("@Open", rawImport.Open);

                    // set parameters[4]
                    parameters[4] = param;

                    // Create parameter for [Per]
                    param = new SqlParameter("@Per", rawImport.Per);

                    // set parameters[5]
                    parameters[5] = param;

                    // Create parameter for [Ticker]
                    param = new SqlParameter("@Ticker", rawImport.Ticker);

                    // set parameters[6]
                    parameters[6] = param;

                    // Create parameter for [Vol]
                    param = new SqlParameter("@Vol", rawImport.Vol);

                    // set parameters[7]
                    parameters[7] = param;

                    // Create parameter for [Id]
                    param = new SqlParameter("@Id", rawImport.Id);
                    parameters[8] = param;
                }

                // return value
                return parameters;
            }
            #endregion

            #region CreateUpdateRawImportStoredProcedure(RawImport rawImport)
            /// <summary>
            /// This method creates an instance of an
            /// 'UpdateRawImportStoredProcedure' object and
            /// creates the sql parameter[] array needed
            /// to execute the procedure 'RawImport_Update'.
            /// </summary>
            /// <param name="rawImport"The 'RawImport' object to update</param>
            /// <returns>An instance of a 'UpdateRawImportStoredProcedure</returns>
            public static UpdateRawImportStoredProcedure CreateUpdateRawImportStoredProcedure(RawImport rawImport)
            {
                // Initial Value
                UpdateRawImportStoredProcedure updateRawImportStoredProcedure = null;

                // verify rawImport exists
                if(rawImport != null)
                {
                    // Instanciate updateRawImportStoredProcedure
                    updateRawImportStoredProcedure = new UpdateRawImportStoredProcedure();

                    // Now create parameters for this procedure
                    updateRawImportStoredProcedure.Parameters = CreateUpdateParameters(rawImport);
                }

                // return value
                return updateRawImportStoredProcedure;
            }
            #endregion

            #region CreateFetchAllRawImportsStoredProcedure(RawImport rawImport)
            /// <summary>
            /// This method creates an instance of a
            /// 'FetchAllRawImportsStoredProcedure' object and
            /// creates the sql parameter[] array needed
            /// to execute the procedure 'RawImport_FetchAll'.
            /// </summary>
            /// <returns>An instance of a(n) 'FetchAllRawImportsStoredProcedure' object.</returns>
            public static FetchAllRawImportsStoredProcedure CreateFetchAllRawImportsStoredProcedure(RawImport rawImport)
            {
                // Initial value
                FetchAllRawImportsStoredProcedure fetchAllRawImportsStoredProcedure = new FetchAllRawImportsStoredProcedure();

                // return value
                return fetchAllRawImportsStoredProcedure;
            }
            #endregion

        #endregion

    }
    #endregion

}
