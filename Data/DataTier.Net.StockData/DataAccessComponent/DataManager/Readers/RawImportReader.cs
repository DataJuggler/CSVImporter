

#region using statements

using ObjectLibrary.BusinessObjects;
using System;
using System.Collections.Generic;
using System.Data;

#endregion


namespace DataAccessComponent.DataManager.Readers
{

    #region class RawImportReader
    /// <summary>
    /// This class loads a single 'RawImport' object or a list of type <RawImport>.
    /// </summary>
    public class RawImportReader
    {

        #region Static Methods

            #region Load(DataRow dataRow)
            /// <summary>
            /// This method loads a 'RawImport' object
            /// from the dataRow passed in.
            /// </summary>
            /// <param name='dataRow'>The 'DataRow' to load from.</param>
            /// <returns>A 'RawImport' DataObject.</returns>
            public static RawImport Load(DataRow dataRow)
            {
                // Initial Value
                RawImport rawImport = new RawImport();

                // Create field Integers
                int closefield = 0;
                int datefield = 1;
                int highfield = 2;
                int idfield = 3;
                int lowfield = 4;
                int openfield = 5;
                int perfield = 6;
                int tickerfield = 7;
                int volfield = 8;

                try
                {
                    // Load Each field
                    rawImport.Close = DataHelper.ParseString(dataRow.ItemArray[closefield]);
                    rawImport.Date = DataHelper.ParseString(dataRow.ItemArray[datefield]);
                    rawImport.High = DataHelper.ParseString(dataRow.ItemArray[highfield]);
                    rawImport.UpdateIdentity(DataHelper.ParseInteger(dataRow.ItemArray[idfield], 0));
                    rawImport.Low = DataHelper.ParseString(dataRow.ItemArray[lowfield]);
                    rawImport.Open = DataHelper.ParseString(dataRow.ItemArray[openfield]);
                    rawImport.Per = DataHelper.ParseString(dataRow.ItemArray[perfield]);
                    rawImport.Ticker = DataHelper.ParseString(dataRow.ItemArray[tickerfield]);
                    rawImport.Vol = DataHelper.ParseString(dataRow.ItemArray[volfield]);
                }
                catch
                {
                }

                // return value
                return rawImport;
            }
            #endregion

            #region LoadCollection(DataTable dataTable)
            /// <summary>
            /// This method loads a collection of 'RawImport' objects.
            /// from the dataTable.Rows object passed in.
            /// </summary>
            /// <param name='dataTable'>The 'DataTable.Rows' to load from.</param>
            /// <returns>A RawImport Collection.</returns>
            public static List<RawImport> LoadCollection(DataTable dataTable)
            {
                // Initial Value
                List<RawImport> rawImports = new List<RawImport>();

                try
                {
                    // Load Each row In DataTable
                    foreach (DataRow row in dataTable.Rows)
                    {
                        // Create 'RawImport' from rows
                        RawImport rawImport = Load(row);

                        // Add this object to collection
                        rawImports.Add(rawImport);
                    }
                }
                catch
                {
                }

                // return value
                return rawImports;
            }
            #endregion

        #endregion

    }
    #endregion

}
