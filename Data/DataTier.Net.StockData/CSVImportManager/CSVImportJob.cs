

#region using statements

using DataGateway;
using System.Collections.Generic;
using DataJuggler.Core.UltimateHelper;
using DataJuggler.Core.UltimateHelper.Objects;
using ObjectLibrary.BusinessObjects;
using CSVImportManager.Delegates;
using System.IO;

#endregion

namespace CSVImportManager
{

    #region class CSVImportJob
    /// <summary>
    /// This class is used to import CSV data to a DataTier.Net datatier
    /// saving the data to SQL Server using all stored procedures
    /// </summary>
    public class CSVImportJob
    {

        #region Methods

            #region ImportDataFromFile(string fileName, string tableName, int expectedCount, ImportProgressCallback callback)
            /// <summary>
            /// This method returns the number of items imported
            /// </summary>
            /// <param name="fileName"></param>
            /// <param name="tableName"></param>
            /// <param name="expectedCount"></param>
            /// <param name="callback">The method to call to update progress</param>
            /// <returns></returns>
            public static int ImportDataFromFile(string fileName, string tableName, int expectedCount, ImportProgressCallback callback)
            {
                // initial value
                int recordsImported = 0;

                // if the fileName exists
                if ((TextHelper.Exists(fileName)) && (File.Exists(fileName)))
                {  
                    // read all text
                    string fileText = File.ReadAllText(fileName);

                    // Call the override
                    recordsImported = CSVImportJob.ImportData(fileText, tableName, expectedCount, callback);
                }

                // return value
                return recordsImported;
            }
            #endregion

            #region ImportData(string fileName, string tableName, int expectedCount, ImportProgressCallback callback)
            /// <summary>
            /// This method returns the number of items imported
            /// </summary>
            /// <param name="text">The contents to be imported.</param>
            /// <param name="tableName">Only used in cases where more than one import takes place.</param>
            /// <param name="expectedCount">Number of expected columns in the csv file</param>
            /// <param name="callback">The method to call to update progress</param>
            /// <returns></returns>
            public static int ImportData(string text, string tableName, int expectedCount, ImportProgressCallback callback)
            {
                // initial value
                int savedCount = 0;

                // locals
                char[] delimiters = { ',' };
                int count = 0;
                int totalCount = 0;
                int refreshRate = 5;
                List<Word> words = null;
                RawImport rawImport = null;

                // if the fileExists
                if (TextHelper.Exists(text))
                {
                    // Create a new instance of a 'Gateway' object.
                    Gateway gateway = new Gateway();

                    // set the textLines
                    List<TextLine> textLines = WordParser.GetTextLines(text.Trim());

                    // If the textLines collection exists and has one or more items
                    if (ListHelper.HasOneOrMoreItems(textLines))
                    {
                        // change the RefreshRate
                        if (textLines.Count > 1000)
                        {
                            // change this to whatever makes since for your app
                            refreshRate = 25;
                        }

                        // set the totalCount
                        totalCount = textLines.Count - 1;

                        // Iterate the collection of TextLine objects
                        foreach (TextLine textLine in textLines)
                        {
                            // Increment the value for count
                            count++;

                            // skip the first row
                            if (count > 1)
                            {
                                // get the list of words
                                words = WordParser.GetWords(textLine.Text, delimiters, true);

                                // if the words collection has exactly the right amount
                                if ((ListHelper.HasOneOrMoreItems(words)) && (words.Count == expectedCount))
                                {
                                    // Create a new instance of a 'RawImport' object.
                                    rawImport = new RawImport();

                                    // Load the RawImport with the words
                                    SetRawImportProperties(ref rawImport, words);

                                    // save the rawImport object
                                    bool saved = gateway.SaveRawImport(ref rawImport);
                                        
                                    // if the value for saved is true
                                    if (saved)
                                    {
                                        // Increment the value for savedCount
                                        savedCount++;

                                        // refresh every x number of records 
                                        if (savedCount % refreshRate == 0)
                                        {
                                            // update the graph (for a large project, you might want to update every 25, 50 or 100 records or so
                                            callback(savedCount, tableName);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }

                // return value
                return savedCount;
            }
            #endregion

            #region SetRawImportProperties(ref RawImport rawImport, List<Word> words, List<RawImportFields> rawImportFields)
            /// <summary>
            /// This method Set Raw Import Properties
            /// </summary>
            public static void SetRawImportProperties(ref RawImport rawImport, List<Word> words)
            {  
                // If the rawImport object exists and both lists exist
                if ((NullHelper.Exists(rawImport)) && (ListHelper.HasOneOrMoreItems(words)))
                {
                    // this is a working sample built for importing the Pfilerr.csv file included in the Data folder.
                    // To create this for your project, after you create your table and build a data-tier
                    // with DataTier.Net, open this query and find your TableId in the DTNTable
                    // for the table you created in Step 1
                    // Then Open the Query SetFieldValues and run it

                    // set each property
                    rawImport.Close = words[6].Text;
                    rawImport.Date = words[2].Text;
                    rawImport.High = words[4].Text;
                    rawImport.Low = words[5].Text;
                    rawImport.Open = words[3].Text;
                    rawImport.Per = words[1].Text;
                    rawImport.Ticker = words[0].Text;
                    rawImport.Vol = words[7].Text;
                }
            }
            #endregion

        #endregion



    }
    #endregion

}
