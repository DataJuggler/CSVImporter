

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
                    rawImport.AuthorizedOfficialCredentialText = words[313].Text;
                    rawImport.AuthorizedOfficialFirstName = words[43].Text;
                    rawImport.AuthorizedOfficialLastName = words[42].Text;
                    rawImport.AuthorizedOfficialMiddleName = words[44].Text;
                    rawImport.AuthorizedOfficialNamePrefixText = words[311].Text;
                    rawImport.AuthorizedOfficialNameSuffixText = words[312].Text;
                    rawImport.AuthorizedOfficialTelephoneNumber = words[46].Text;
                    rawImport.AuthorizedOfficialTitleorPosition = words[45].Text;
                    rawImport.EmployerIdentificationNumberEIN = words[3].Text;
                    rawImport.EntityTypeCode = words[1].Text;
                    rawImport.HealthcareProviderPrimaryTaxonomySwitch1 = words[50].Text;
                    rawImport.HealthcareProviderPrimaryTaxonomySwitch10 = words[86].Text;
                    rawImport.HealthcareProviderPrimaryTaxonomySwitch11 = words[90].Text;
                    rawImport.HealthcareProviderPrimaryTaxonomySwitch12 = words[94].Text;
                    rawImport.HealthcareProviderPrimaryTaxonomySwitch13 = words[98].Text;
                    rawImport.HealthcareProviderPrimaryTaxonomySwitch14 = words[102].Text;
                    rawImport.HealthcareProviderPrimaryTaxonomySwitch15 = words[106].Text;
                    rawImport.HealthcareProviderPrimaryTaxonomySwitch2 = words[54].Text;
                    rawImport.HealthcareProviderPrimaryTaxonomySwitch3 = words[58].Text;
                    rawImport.HealthcareProviderPrimaryTaxonomySwitch4 = words[62].Text;
                    rawImport.HealthcareProviderPrimaryTaxonomySwitch5 = words[66].Text;
                    rawImport.HealthcareProviderPrimaryTaxonomySwitch6 = words[70].Text;
                    rawImport.HealthcareProviderPrimaryTaxonomySwitch7 = words[74].Text;
                    rawImport.HealthcareProviderPrimaryTaxonomySwitch8 = words[78].Text;
                    rawImport.HealthcareProviderPrimaryTaxonomySwitch9 = words[82].Text;
                    rawImport.HealthcareProviderTaxonomyCode1 = words[47].Text;
                    rawImport.HealthcareProviderTaxonomyCode10 = words[83].Text;
                    rawImport.HealthcareProviderTaxonomyCode11 = words[87].Text;
                    rawImport.HealthcareProviderTaxonomyCode12 = words[91].Text;
                    rawImport.HealthcareProviderTaxonomyCode13 = words[95].Text;
                    rawImport.HealthcareProviderTaxonomyCode14 = words[99].Text;
                    rawImport.HealthcareProviderTaxonomyCode15 = words[103].Text;
                    rawImport.HealthcareProviderTaxonomyCode2 = words[51].Text;
                    rawImport.HealthcareProviderTaxonomyCode3 = words[55].Text;
                    rawImport.HealthcareProviderTaxonomyCode4 = words[59].Text;
                    rawImport.HealthcareProviderTaxonomyCode5 = words[63].Text;
                    rawImport.HealthcareProviderTaxonomyCode6 = words[67].Text;
                    rawImport.HealthcareProviderTaxonomyCode7 = words[71].Text;
                    rawImport.HealthcareProviderTaxonomyCode8 = words[75].Text;
                    rawImport.HealthcareProviderTaxonomyCode9 = words[79].Text;
                    rawImport.HealthcareProviderTaxonomyGroup1 = words[314].Text;
                    rawImport.HealthcareProviderTaxonomyGroup10 = words[323].Text;
                    rawImport.HealthcareProviderTaxonomyGroup11 = words[324].Text;
                    rawImport.HealthcareProviderTaxonomyGroup12 = words[325].Text;
                    rawImport.HealthcareProviderTaxonomyGroup13 = words[326].Text;
                    rawImport.HealthcareProviderTaxonomyGroup14 = words[327].Text;
                    rawImport.HealthcareProviderTaxonomyGroup15 = words[328].Text;
                    rawImport.HealthcareProviderTaxonomyGroup2 = words[315].Text;
                    rawImport.HealthcareProviderTaxonomyGroup3 = words[316].Text;
                    rawImport.HealthcareProviderTaxonomyGroup4 = words[317].Text;
                    rawImport.HealthcareProviderTaxonomyGroup5 = words[318].Text;
                    rawImport.HealthcareProviderTaxonomyGroup6 = words[319].Text;
                    rawImport.HealthcareProviderTaxonomyGroup7 = words[320].Text;
                    rawImport.HealthcareProviderTaxonomyGroup8 = words[321].Text;
                    rawImport.HealthcareProviderTaxonomyGroup9 = words[322].Text;
                    rawImport.IsOrganizationSubpart = words[308].Text;
                    rawImport.IsSoleProprietor = words[307].Text;
                    rawImport.LastUpdateDate = words[37].Text;
                    rawImport.NPI = words[0].Text;
                    rawImport.NPIDeactivationDate = words[39].Text;
                    rawImport.NPIDeactivationReasonCode = words[38].Text;
                    rawImport.NPIReactivationDate = words[40].Text;
                    rawImport.OtherProviderIdentifier1 = words[107].Text;
                    rawImport.OtherProviderIdentifier10 = words[143].Text;
                    rawImport.OtherProviderIdentifier11 = words[147].Text;
                    rawImport.OtherProviderIdentifier12 = words[151].Text;
                    rawImport.OtherProviderIdentifier13 = words[155].Text;
                    rawImport.OtherProviderIdentifier14 = words[159].Text;
                    rawImport.OtherProviderIdentifier15 = words[163].Text;
                    rawImport.OtherProviderIdentifier16 = words[167].Text;
                    rawImport.OtherProviderIdentifier17 = words[171].Text;
                    rawImport.OtherProviderIdentifier18 = words[175].Text;
                    rawImport.OtherProviderIdentifier19 = words[179].Text;
                    rawImport.OtherProviderIdentifier2 = words[111].Text;
                    rawImport.OtherProviderIdentifier20 = words[183].Text;
                    rawImport.OtherProviderIdentifier21 = words[187].Text;
                    rawImport.OtherProviderIdentifier22 = words[191].Text;
                    rawImport.OtherProviderIdentifier23 = words[195].Text;
                    rawImport.OtherProviderIdentifier24 = words[199].Text;
                    rawImport.OtherProviderIdentifier25 = words[203].Text;
                    rawImport.OtherProviderIdentifier26 = words[207].Text;
                    rawImport.OtherProviderIdentifier27 = words[211].Text;
                    rawImport.OtherProviderIdentifier28 = words[215].Text;
                    rawImport.OtherProviderIdentifier29 = words[219].Text;
                    rawImport.OtherProviderIdentifier3 = words[115].Text;
                    rawImport.OtherProviderIdentifier30 = words[223].Text;
                    rawImport.OtherProviderIdentifier31 = words[227].Text;
                    rawImport.OtherProviderIdentifier32 = words[231].Text;
                    rawImport.OtherProviderIdentifier33 = words[235].Text;
                    rawImport.OtherProviderIdentifier34 = words[239].Text;
                    rawImport.OtherProviderIdentifier35 = words[243].Text;
                    rawImport.OtherProviderIdentifier36 = words[247].Text;
                    rawImport.OtherProviderIdentifier37 = words[251].Text;
                    rawImport.OtherProviderIdentifier38 = words[255].Text;
                    rawImport.OtherProviderIdentifier39 = words[259].Text;
                    rawImport.OtherProviderIdentifier4 = words[119].Text;
                    rawImport.OtherProviderIdentifier40 = words[263].Text;
                    rawImport.OtherProviderIdentifier41 = words[267].Text;
                    rawImport.OtherProviderIdentifier42 = words[271].Text;
                    rawImport.OtherProviderIdentifier43 = words[275].Text;
                    rawImport.OtherProviderIdentifier44 = words[279].Text;
                    rawImport.OtherProviderIdentifier45 = words[283].Text;
                    rawImport.OtherProviderIdentifier46 = words[287].Text;
                    rawImport.OtherProviderIdentifier47 = words[291].Text;
                    rawImport.OtherProviderIdentifier48 = words[295].Text;
                    rawImport.OtherProviderIdentifier49 = words[299].Text;
                    rawImport.OtherProviderIdentifier5 = words[123].Text;
                    rawImport.OtherProviderIdentifier50 = words[303].Text;
                    rawImport.OtherProviderIdentifier6 = words[127].Text;
                    rawImport.OtherProviderIdentifier7 = words[131].Text;
                    rawImport.OtherProviderIdentifier8 = words[135].Text;
                    rawImport.OtherProviderIdentifier9 = words[139].Text;
                    rawImport.OtherProviderIdentifierIssuer1 = words[110].Text;
                    rawImport.OtherProviderIdentifierIssuer10 = words[146].Text;
                    rawImport.OtherProviderIdentifierIssuer11 = words[150].Text;
                    rawImport.OtherProviderIdentifierIssuer12 = words[154].Text;
                    rawImport.OtherProviderIdentifierIssuer13 = words[158].Text;
                    rawImport.OtherProviderIdentifierIssuer14 = words[162].Text;
                    rawImport.OtherProviderIdentifierIssuer15 = words[166].Text;
                    rawImport.OtherProviderIdentifierIssuer16 = words[170].Text;
                    rawImport.OtherProviderIdentifierIssuer17 = words[174].Text;
                    rawImport.OtherProviderIdentifierIssuer18 = words[178].Text;
                    rawImport.OtherProviderIdentifierIssuer19 = words[182].Text;
                    rawImport.OtherProviderIdentifierIssuer2 = words[114].Text;
                    rawImport.OtherProviderIdentifierIssuer20 = words[186].Text;
                    rawImport.OtherProviderIdentifierIssuer21 = words[190].Text;
                    rawImport.OtherProviderIdentifierIssuer22 = words[194].Text;
                    rawImport.OtherProviderIdentifierIssuer23 = words[198].Text;
                    rawImport.OtherProviderIdentifierIssuer24 = words[202].Text;
                    rawImport.OtherProviderIdentifierIssuer25 = words[206].Text;
                    rawImport.OtherProviderIdentifierIssuer26 = words[210].Text;
                    rawImport.OtherProviderIdentifierIssuer27 = words[214].Text;
                    rawImport.OtherProviderIdentifierIssuer28 = words[218].Text;
                    rawImport.OtherProviderIdentifierIssuer29 = words[222].Text;
                    rawImport.OtherProviderIdentifierIssuer3 = words[118].Text;
                    rawImport.OtherProviderIdentifierIssuer30 = words[226].Text;
                    rawImport.OtherProviderIdentifierIssuer31 = words[230].Text;
                    rawImport.OtherProviderIdentifierIssuer32 = words[234].Text;
                    rawImport.OtherProviderIdentifierIssuer33 = words[238].Text;
                    rawImport.OtherProviderIdentifierIssuer34 = words[242].Text;
                    rawImport.OtherProviderIdentifierIssuer35 = words[246].Text;
                    rawImport.OtherProviderIdentifierIssuer36 = words[250].Text;
                    rawImport.OtherProviderIdentifierIssuer37 = words[254].Text;
                    rawImport.OtherProviderIdentifierIssuer38 = words[258].Text;
                    rawImport.OtherProviderIdentifierIssuer39 = words[262].Text;
                    rawImport.OtherProviderIdentifierIssuer4 = words[122].Text;
                    rawImport.OtherProviderIdentifierIssuer40 = words[266].Text;
                    rawImport.OtherProviderIdentifierIssuer41 = words[270].Text;
                    rawImport.OtherProviderIdentifierIssuer42 = words[274].Text;
                    rawImport.OtherProviderIdentifierIssuer43 = words[278].Text;
                    rawImport.OtherProviderIdentifierIssuer44 = words[282].Text;
                    rawImport.OtherProviderIdentifierIssuer45 = words[286].Text;
                    rawImport.OtherProviderIdentifierIssuer46 = words[290].Text;
                    rawImport.OtherProviderIdentifierIssuer47 = words[294].Text;
                    rawImport.OtherProviderIdentifierIssuer48 = words[298].Text;
                    rawImport.OtherProviderIdentifierIssuer49 = words[302].Text;
                    rawImport.OtherProviderIdentifierIssuer5 = words[126].Text;
                    rawImport.OtherProviderIdentifierIssuer50 = words[306].Text;
                    rawImport.OtherProviderIdentifierIssuer6 = words[130].Text;
                    rawImport.OtherProviderIdentifierIssuer7 = words[134].Text;
                    rawImport.OtherProviderIdentifierIssuer8 = words[138].Text;
                    rawImport.OtherProviderIdentifierIssuer9 = words[142].Text;
                    rawImport.OtherProviderIdentifierState1 = words[109].Text;
                    rawImport.OtherProviderIdentifierState10 = words[145].Text;
                    rawImport.OtherProviderIdentifierState11 = words[149].Text;
                    rawImport.OtherProviderIdentifierState12 = words[153].Text;
                    rawImport.OtherProviderIdentifierState13 = words[157].Text;
                    rawImport.OtherProviderIdentifierState14 = words[161].Text;
                    rawImport.OtherProviderIdentifierState15 = words[165].Text;
                    rawImport.OtherProviderIdentifierState16 = words[169].Text;
                    rawImport.OtherProviderIdentifierState17 = words[173].Text;
                    rawImport.OtherProviderIdentifierState18 = words[177].Text;
                    rawImport.OtherProviderIdentifierState19 = words[181].Text;
                    rawImport.OtherProviderIdentifierState2 = words[113].Text;
                    rawImport.OtherProviderIdentifierState20 = words[185].Text;
                    rawImport.OtherProviderIdentifierState21 = words[189].Text;
                    rawImport.OtherProviderIdentifierState22 = words[193].Text;
                    rawImport.OtherProviderIdentifierState23 = words[197].Text;
                    rawImport.OtherProviderIdentifierState24 = words[201].Text;
                    rawImport.OtherProviderIdentifierState25 = words[205].Text;
                    rawImport.OtherProviderIdentifierState26 = words[209].Text;
                    rawImport.OtherProviderIdentifierState27 = words[213].Text;
                    rawImport.OtherProviderIdentifierState28 = words[217].Text;
                    rawImport.OtherProviderIdentifierState29 = words[221].Text;
                    rawImport.OtherProviderIdentifierState3 = words[117].Text;
                    rawImport.OtherProviderIdentifierState30 = words[225].Text;
                    rawImport.OtherProviderIdentifierState31 = words[229].Text;
                    rawImport.OtherProviderIdentifierState32 = words[233].Text;
                    rawImport.OtherProviderIdentifierState33 = words[237].Text;
                    rawImport.OtherProviderIdentifierState34 = words[241].Text;
                    rawImport.OtherProviderIdentifierState35 = words[245].Text;
                    rawImport.OtherProviderIdentifierState36 = words[249].Text;
                    rawImport.OtherProviderIdentifierState37 = words[253].Text;
                    rawImport.OtherProviderIdentifierState38 = words[257].Text;
                    rawImport.OtherProviderIdentifierState39 = words[261].Text;
                    rawImport.OtherProviderIdentifierState4 = words[121].Text;
                    rawImport.OtherProviderIdentifierState40 = words[265].Text;
                    rawImport.OtherProviderIdentifierState41 = words[269].Text;
                    rawImport.OtherProviderIdentifierState42 = words[273].Text;
                    rawImport.OtherProviderIdentifierState43 = words[277].Text;
                    rawImport.OtherProviderIdentifierState44 = words[281].Text;
                    rawImport.OtherProviderIdentifierState45 = words[285].Text;
                    rawImport.OtherProviderIdentifierState46 = words[289].Text;
                    rawImport.OtherProviderIdentifierState47 = words[293].Text;
                    rawImport.OtherProviderIdentifierState48 = words[297].Text;
                    rawImport.OtherProviderIdentifierState49 = words[301].Text;
                    rawImport.OtherProviderIdentifierState5 = words[125].Text;
                    rawImport.OtherProviderIdentifierState50 = words[305].Text;
                    rawImport.OtherProviderIdentifierState6 = words[129].Text;
                    rawImport.OtherProviderIdentifierState7 = words[133].Text;
                    rawImport.OtherProviderIdentifierState8 = words[137].Text;
                    rawImport.OtherProviderIdentifierState9 = words[141].Text;
                    rawImport.OtherProviderIdentifierTypeCode1 = words[108].Text;
                    rawImport.OtherProviderIdentifierTypeCode10 = words[144].Text;
                    rawImport.OtherProviderIdentifierTypeCode11 = words[148].Text;
                    rawImport.OtherProviderIdentifierTypeCode12 = words[152].Text;
                    rawImport.OtherProviderIdentifierTypeCode13 = words[156].Text;
                    rawImport.OtherProviderIdentifierTypeCode14 = words[160].Text;
                    rawImport.OtherProviderIdentifierTypeCode15 = words[164].Text;
                    rawImport.OtherProviderIdentifierTypeCode16 = words[168].Text;
                    rawImport.OtherProviderIdentifierTypeCode17 = words[172].Text;
                    rawImport.OtherProviderIdentifierTypeCode18 = words[176].Text;
                    rawImport.OtherProviderIdentifierTypeCode19 = words[180].Text;
                    rawImport.OtherProviderIdentifierTypeCode2 = words[112].Text;
                    rawImport.OtherProviderIdentifierTypeCode20 = words[184].Text;
                    rawImport.OtherProviderIdentifierTypeCode21 = words[188].Text;
                    rawImport.OtherProviderIdentifierTypeCode22 = words[192].Text;
                    rawImport.OtherProviderIdentifierTypeCode23 = words[196].Text;
                    rawImport.OtherProviderIdentifierTypeCode24 = words[200].Text;
                    rawImport.OtherProviderIdentifierTypeCode25 = words[204].Text;
                    rawImport.OtherProviderIdentifierTypeCode26 = words[208].Text;
                    rawImport.OtherProviderIdentifierTypeCode27 = words[212].Text;
                    rawImport.OtherProviderIdentifierTypeCode28 = words[216].Text;
                    rawImport.OtherProviderIdentifierTypeCode29 = words[220].Text;
                    rawImport.OtherProviderIdentifierTypeCode3 = words[116].Text;
                    rawImport.OtherProviderIdentifierTypeCode30 = words[224].Text;
                    rawImport.OtherProviderIdentifierTypeCode31 = words[228].Text;
                    rawImport.OtherProviderIdentifierTypeCode32 = words[232].Text;
                    rawImport.OtherProviderIdentifierTypeCode33 = words[236].Text;
                    rawImport.OtherProviderIdentifierTypeCode34 = words[240].Text;
                    rawImport.OtherProviderIdentifierTypeCode35 = words[244].Text;
                    rawImport.OtherProviderIdentifierTypeCode36 = words[248].Text;
                    rawImport.OtherProviderIdentifierTypeCode37 = words[252].Text;
                    rawImport.OtherProviderIdentifierTypeCode38 = words[256].Text;
                    rawImport.OtherProviderIdentifierTypeCode39 = words[260].Text;
                    rawImport.OtherProviderIdentifierTypeCode4 = words[120].Text;
                    rawImport.OtherProviderIdentifierTypeCode40 = words[264].Text;
                    rawImport.OtherProviderIdentifierTypeCode41 = words[268].Text;
                    rawImport.OtherProviderIdentifierTypeCode42 = words[272].Text;
                    rawImport.OtherProviderIdentifierTypeCode43 = words[276].Text;
                    rawImport.OtherProviderIdentifierTypeCode44 = words[280].Text;
                    rawImport.OtherProviderIdentifierTypeCode45 = words[284].Text;
                    rawImport.OtherProviderIdentifierTypeCode46 = words[288].Text;
                    rawImport.OtherProviderIdentifierTypeCode47 = words[292].Text;
                    rawImport.OtherProviderIdentifierTypeCode48 = words[296].Text;
                    rawImport.OtherProviderIdentifierTypeCode49 = words[300].Text;
                    rawImport.OtherProviderIdentifierTypeCode5 = words[124].Text;
                    rawImport.OtherProviderIdentifierTypeCode50 = words[304].Text;
                    rawImport.OtherProviderIdentifierTypeCode6 = words[128].Text;
                    rawImport.OtherProviderIdentifierTypeCode7 = words[132].Text;
                    rawImport.OtherProviderIdentifierTypeCode8 = words[136].Text;
                    rawImport.OtherProviderIdentifierTypeCode9 = words[140].Text;
                    rawImport.ParentOrganizationLBN = words[309].Text;
                    rawImport.ParentOrganizationTIN = words[310].Text;
                    rawImport.ProviderBusinessMailingAddressCityName = words[22].Text;
                    rawImport.ProviderBusinessMailingAddressFaxNumber = words[27].Text;
                    rawImport.ProviderBusinessMailingAddressPostalCode = words[24].Text;
                    rawImport.ProviderBusinessMailingAddressStateName = words[23].Text;
                    rawImport.ProviderBusinessMailingAddressTelephoneNumber = words[26].Text;
                    rawImport.ProviderBusinessPracticeLocationAddressCityName = words[30].Text;
                    rawImport.ProviderBusinessPracticeLocationAddressFaxNumber = words[35].Text;
                    rawImport.ProviderBusinessPracticeLocationAddressPostalCode = words[32].Text;
                    rawImport.ProviderBusinessPracticeLocationAddressStateName = words[31].Text;
                    rawImport.ProviderCredentialText = words[10].Text;
                    rawImport.ProviderEnumerationDate = words[36].Text;
                    rawImport.ProviderFirstLineBusinessMailingAddress = words[20].Text;
                    rawImport.ProviderFirstLineBusinessPracticeLocationAddress = words[28].Text;
                    rawImport.ProviderFirstName = words[6].Text;
                    rawImport.ProviderGenderCode = words[41].Text;
                    rawImport.ProviderLastNameLegalName = words[5].Text;
                    rawImport.ProviderLicenseNumber1 = words[48].Text;
                    rawImport.ProviderLicenseNumber10 = words[84].Text;
                    rawImport.ProviderLicenseNumber11 = words[88].Text;
                    rawImport.ProviderLicenseNumber12 = words[92].Text;
                    rawImport.ProviderLicenseNumber13 = words[96].Text;
                    rawImport.ProviderLicenseNumber14 = words[100].Text;
                    rawImport.ProviderLicenseNumber15 = words[104].Text;
                    rawImport.ProviderLicenseNumber2 = words[52].Text;
                    rawImport.ProviderLicenseNumber3 = words[56].Text;
                    rawImport.ProviderLicenseNumber4 = words[60].Text;
                    rawImport.ProviderLicenseNumber5 = words[64].Text;
                    rawImport.ProviderLicenseNumber6 = words[68].Text;
                    rawImport.ProviderLicenseNumber7 = words[72].Text;
                    rawImport.ProviderLicenseNumber8 = words[76].Text;
                    rawImport.ProviderLicenseNumber9 = words[80].Text;
                    rawImport.ProviderLicenseNumberStateCode1 = words[49].Text;
                    rawImport.ProviderLicenseNumberStateCode10 = words[85].Text;
                    rawImport.ProviderLicenseNumberStateCode11 = words[89].Text;
                    rawImport.ProviderLicenseNumberStateCode12 = words[93].Text;
                    rawImport.ProviderLicenseNumberStateCode13 = words[97].Text;
                    rawImport.ProviderLicenseNumberStateCode14 = words[101].Text;
                    rawImport.ProviderLicenseNumberStateCode15 = words[105].Text;
                    rawImport.ProviderLicenseNumberStateCode2 = words[53].Text;
                    rawImport.ProviderLicenseNumberStateCode3 = words[57].Text;
                    rawImport.ProviderLicenseNumberStateCode4 = words[61].Text;
                    rawImport.ProviderLicenseNumberStateCode5 = words[65].Text;
                    rawImport.ProviderLicenseNumberStateCode6 = words[69].Text;
                    rawImport.ProviderLicenseNumberStateCode7 = words[73].Text;
                    rawImport.ProviderLicenseNumberStateCode8 = words[77].Text;
                    rawImport.ProviderLicenseNumberStateCode9 = words[81].Text;
                    rawImport.ProviderMiddleName = words[7].Text;
                    rawImport.ProviderNamePrefixText = words[8].Text;
                    rawImport.ProviderNameSuffixText = words[9].Text;
                    rawImport.ProviderOrganizationNameLegalBusinessName = words[4].Text;
                    rawImport.ProviderOtherCredentialText = words[18].Text;
                    rawImport.ProviderOtherFirstName = words[14].Text;
                    rawImport.ProviderOtherLastName = words[13].Text;
                    rawImport.ProviderOtherLastNameTypeCode = words[19].Text;
                    rawImport.ProviderOtherMiddleName = words[15].Text;
                    rawImport.ProviderOtherNamePrefixText = words[16].Text;
                    rawImport.ProviderOtherNameSuffixText = words[17].Text;
                    rawImport.ProviderOtherOrganizationName = words[11].Text;
                    rawImport.ProviderOtherOrganizationNameTypeCode = words[12].Text;
                    rawImport.ProviderSecondLineBusinessMailingAddress = words[21].Text;
                    rawImport.ProviderSecondLineBusinessPracticeLocationAddress = words[29].Text;
                    rawImport.ReplacementNPI = words[2].Text;
                    rawImport.ProviderBusinessMailingAddressCountryCodeIfoutsideUS = words[25].Text;
                    rawImport.ProviderBusinessPracticeLocationAddressCountryCodeIfoutsideUS = words[33].Text;
                    rawImport.ProviderBusinessPracticeLocationAddressTelephoneNumber = words[34].Text;
                }
            }
            #endregion

        #endregion



    }
    #endregion

}
