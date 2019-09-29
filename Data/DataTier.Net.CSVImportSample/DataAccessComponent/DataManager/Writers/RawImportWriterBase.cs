

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
                SqlParameter[] parameters = new SqlParameter[329];
                SqlParameter param = null;

                // verify rawImportexists
                if(rawImport != null)
                {
                    // Create [AuthorizedOfficialCredentialText] parameter
                    param = new SqlParameter("@AuthorizedOfficialCredentialText", rawImport.AuthorizedOfficialCredentialText);

                    // set parameters[0]
                    parameters[0] = param;

                    // Create [AuthorizedOfficialFirstName] parameter
                    param = new SqlParameter("@AuthorizedOfficialFirstName", rawImport.AuthorizedOfficialFirstName);

                    // set parameters[1]
                    parameters[1] = param;

                    // Create [AuthorizedOfficialLastName] parameter
                    param = new SqlParameter("@AuthorizedOfficialLastName", rawImport.AuthorizedOfficialLastName);

                    // set parameters[2]
                    parameters[2] = param;

                    // Create [AuthorizedOfficialMiddleName] parameter
                    param = new SqlParameter("@AuthorizedOfficialMiddleName", rawImport.AuthorizedOfficialMiddleName);

                    // set parameters[3]
                    parameters[3] = param;

                    // Create [AuthorizedOfficialNamePrefixText] parameter
                    param = new SqlParameter("@AuthorizedOfficialNamePrefixText", rawImport.AuthorizedOfficialNamePrefixText);

                    // set parameters[4]
                    parameters[4] = param;

                    // Create [AuthorizedOfficialNameSuffixText] parameter
                    param = new SqlParameter("@AuthorizedOfficialNameSuffixText", rawImport.AuthorizedOfficialNameSuffixText);

                    // set parameters[5]
                    parameters[5] = param;

                    // Create [AuthorizedOfficialTelephoneNumber] parameter
                    param = new SqlParameter("@AuthorizedOfficialTelephoneNumber", rawImport.AuthorizedOfficialTelephoneNumber);

                    // set parameters[6]
                    parameters[6] = param;

                    // Create [AuthorizedOfficialTitleorPosition] parameter
                    param = new SqlParameter("@AuthorizedOfficialTitleorPosition", rawImport.AuthorizedOfficialTitleorPosition);

                    // set parameters[7]
                    parameters[7] = param;

                    // Create [EmployerIdentificationNumberEIN] parameter
                    param = new SqlParameter("@EmployerIdentificationNumberEIN", rawImport.EmployerIdentificationNumberEIN);

                    // set parameters[8]
                    parameters[8] = param;

                    // Create [EntityTypeCode] parameter
                    param = new SqlParameter("@EntityTypeCode", rawImport.EntityTypeCode);

                    // set parameters[9]
                    parameters[9] = param;

                    // Create [HealthcareProviderPrimaryTaxonomySwitch1] parameter
                    param = new SqlParameter("@HealthcareProviderPrimaryTaxonomySwitch1", rawImport.HealthcareProviderPrimaryTaxonomySwitch1);

                    // set parameters[10]
                    parameters[10] = param;

                    // Create [HealthcareProviderPrimaryTaxonomySwitch10] parameter
                    param = new SqlParameter("@HealthcareProviderPrimaryTaxonomySwitch10", rawImport.HealthcareProviderPrimaryTaxonomySwitch10);

                    // set parameters[11]
                    parameters[11] = param;

                    // Create [HealthcareProviderPrimaryTaxonomySwitch11] parameter
                    param = new SqlParameter("@HealthcareProviderPrimaryTaxonomySwitch11", rawImport.HealthcareProviderPrimaryTaxonomySwitch11);

                    // set parameters[12]
                    parameters[12] = param;

                    // Create [HealthcareProviderPrimaryTaxonomySwitch12] parameter
                    param = new SqlParameter("@HealthcareProviderPrimaryTaxonomySwitch12", rawImport.HealthcareProviderPrimaryTaxonomySwitch12);

                    // set parameters[13]
                    parameters[13] = param;

                    // Create [HealthcareProviderPrimaryTaxonomySwitch13] parameter
                    param = new SqlParameter("@HealthcareProviderPrimaryTaxonomySwitch13", rawImport.HealthcareProviderPrimaryTaxonomySwitch13);

                    // set parameters[14]
                    parameters[14] = param;

                    // Create [HealthcareProviderPrimaryTaxonomySwitch14] parameter
                    param = new SqlParameter("@HealthcareProviderPrimaryTaxonomySwitch14", rawImport.HealthcareProviderPrimaryTaxonomySwitch14);

                    // set parameters[15]
                    parameters[15] = param;

                    // Create [HealthcareProviderPrimaryTaxonomySwitch15] parameter
                    param = new SqlParameter("@HealthcareProviderPrimaryTaxonomySwitch15", rawImport.HealthcareProviderPrimaryTaxonomySwitch15);

                    // set parameters[16]
                    parameters[16] = param;

                    // Create [HealthcareProviderPrimaryTaxonomySwitch2] parameter
                    param = new SqlParameter("@HealthcareProviderPrimaryTaxonomySwitch2", rawImport.HealthcareProviderPrimaryTaxonomySwitch2);

                    // set parameters[17]
                    parameters[17] = param;

                    // Create [HealthcareProviderPrimaryTaxonomySwitch3] parameter
                    param = new SqlParameter("@HealthcareProviderPrimaryTaxonomySwitch3", rawImport.HealthcareProviderPrimaryTaxonomySwitch3);

                    // set parameters[18]
                    parameters[18] = param;

                    // Create [HealthcareProviderPrimaryTaxonomySwitch4] parameter
                    param = new SqlParameter("@HealthcareProviderPrimaryTaxonomySwitch4", rawImport.HealthcareProviderPrimaryTaxonomySwitch4);

                    // set parameters[19]
                    parameters[19] = param;

                    // Create [HealthcareProviderPrimaryTaxonomySwitch5] parameter
                    param = new SqlParameter("@HealthcareProviderPrimaryTaxonomySwitch5", rawImport.HealthcareProviderPrimaryTaxonomySwitch5);

                    // set parameters[20]
                    parameters[20] = param;

                    // Create [HealthcareProviderPrimaryTaxonomySwitch6] parameter
                    param = new SqlParameter("@HealthcareProviderPrimaryTaxonomySwitch6", rawImport.HealthcareProviderPrimaryTaxonomySwitch6);

                    // set parameters[21]
                    parameters[21] = param;

                    // Create [HealthcareProviderPrimaryTaxonomySwitch7] parameter
                    param = new SqlParameter("@HealthcareProviderPrimaryTaxonomySwitch7", rawImport.HealthcareProviderPrimaryTaxonomySwitch7);

                    // set parameters[22]
                    parameters[22] = param;

                    // Create [HealthcareProviderPrimaryTaxonomySwitch8] parameter
                    param = new SqlParameter("@HealthcareProviderPrimaryTaxonomySwitch8", rawImport.HealthcareProviderPrimaryTaxonomySwitch8);

                    // set parameters[23]
                    parameters[23] = param;

                    // Create [HealthcareProviderPrimaryTaxonomySwitch9] parameter
                    param = new SqlParameter("@HealthcareProviderPrimaryTaxonomySwitch9", rawImport.HealthcareProviderPrimaryTaxonomySwitch9);

                    // set parameters[24]
                    parameters[24] = param;

                    // Create [HealthcareProviderTaxonomyCode1] parameter
                    param = new SqlParameter("@HealthcareProviderTaxonomyCode1", rawImport.HealthcareProviderTaxonomyCode1);

                    // set parameters[25]
                    parameters[25] = param;

                    // Create [HealthcareProviderTaxonomyCode10] parameter
                    param = new SqlParameter("@HealthcareProviderTaxonomyCode10", rawImport.HealthcareProviderTaxonomyCode10);

                    // set parameters[26]
                    parameters[26] = param;

                    // Create [HealthcareProviderTaxonomyCode11] parameter
                    param = new SqlParameter("@HealthcareProviderTaxonomyCode11", rawImport.HealthcareProviderTaxonomyCode11);

                    // set parameters[27]
                    parameters[27] = param;

                    // Create [HealthcareProviderTaxonomyCode12] parameter
                    param = new SqlParameter("@HealthcareProviderTaxonomyCode12", rawImport.HealthcareProviderTaxonomyCode12);

                    // set parameters[28]
                    parameters[28] = param;

                    // Create [HealthcareProviderTaxonomyCode13] parameter
                    param = new SqlParameter("@HealthcareProviderTaxonomyCode13", rawImport.HealthcareProviderTaxonomyCode13);

                    // set parameters[29]
                    parameters[29] = param;

                    // Create [HealthcareProviderTaxonomyCode14] parameter
                    param = new SqlParameter("@HealthcareProviderTaxonomyCode14", rawImport.HealthcareProviderTaxonomyCode14);

                    // set parameters[30]
                    parameters[30] = param;

                    // Create [HealthcareProviderTaxonomyCode15] parameter
                    param = new SqlParameter("@HealthcareProviderTaxonomyCode15", rawImport.HealthcareProviderTaxonomyCode15);

                    // set parameters[31]
                    parameters[31] = param;

                    // Create [HealthcareProviderTaxonomyCode2] parameter
                    param = new SqlParameter("@HealthcareProviderTaxonomyCode2", rawImport.HealthcareProviderTaxonomyCode2);

                    // set parameters[32]
                    parameters[32] = param;

                    // Create [HealthcareProviderTaxonomyCode3] parameter
                    param = new SqlParameter("@HealthcareProviderTaxonomyCode3", rawImport.HealthcareProviderTaxonomyCode3);

                    // set parameters[33]
                    parameters[33] = param;

                    // Create [HealthcareProviderTaxonomyCode4] parameter
                    param = new SqlParameter("@HealthcareProviderTaxonomyCode4", rawImport.HealthcareProviderTaxonomyCode4);

                    // set parameters[34]
                    parameters[34] = param;

                    // Create [HealthcareProviderTaxonomyCode5] parameter
                    param = new SqlParameter("@HealthcareProviderTaxonomyCode5", rawImport.HealthcareProviderTaxonomyCode5);

                    // set parameters[35]
                    parameters[35] = param;

                    // Create [HealthcareProviderTaxonomyCode6] parameter
                    param = new SqlParameter("@HealthcareProviderTaxonomyCode6", rawImport.HealthcareProviderTaxonomyCode6);

                    // set parameters[36]
                    parameters[36] = param;

                    // Create [HealthcareProviderTaxonomyCode7] parameter
                    param = new SqlParameter("@HealthcareProviderTaxonomyCode7", rawImport.HealthcareProviderTaxonomyCode7);

                    // set parameters[37]
                    parameters[37] = param;

                    // Create [HealthcareProviderTaxonomyCode8] parameter
                    param = new SqlParameter("@HealthcareProviderTaxonomyCode8", rawImport.HealthcareProviderTaxonomyCode8);

                    // set parameters[38]
                    parameters[38] = param;

                    // Create [HealthcareProviderTaxonomyCode9] parameter
                    param = new SqlParameter("@HealthcareProviderTaxonomyCode9", rawImport.HealthcareProviderTaxonomyCode9);

                    // set parameters[39]
                    parameters[39] = param;

                    // Create [HealthcareProviderTaxonomyGroup1] parameter
                    param = new SqlParameter("@HealthcareProviderTaxonomyGroup1", rawImport.HealthcareProviderTaxonomyGroup1);

                    // set parameters[40]
                    parameters[40] = param;

                    // Create [HealthcareProviderTaxonomyGroup10] parameter
                    param = new SqlParameter("@HealthcareProviderTaxonomyGroup10", rawImport.HealthcareProviderTaxonomyGroup10);

                    // set parameters[41]
                    parameters[41] = param;

                    // Create [HealthcareProviderTaxonomyGroup11] parameter
                    param = new SqlParameter("@HealthcareProviderTaxonomyGroup11", rawImport.HealthcareProviderTaxonomyGroup11);

                    // set parameters[42]
                    parameters[42] = param;

                    // Create [HealthcareProviderTaxonomyGroup12] parameter
                    param = new SqlParameter("@HealthcareProviderTaxonomyGroup12", rawImport.HealthcareProviderTaxonomyGroup12);

                    // set parameters[43]
                    parameters[43] = param;

                    // Create [HealthcareProviderTaxonomyGroup13] parameter
                    param = new SqlParameter("@HealthcareProviderTaxonomyGroup13", rawImport.HealthcareProviderTaxonomyGroup13);

                    // set parameters[44]
                    parameters[44] = param;

                    // Create [HealthcareProviderTaxonomyGroup14] parameter
                    param = new SqlParameter("@HealthcareProviderTaxonomyGroup14", rawImport.HealthcareProviderTaxonomyGroup14);

                    // set parameters[45]
                    parameters[45] = param;

                    // Create [HealthcareProviderTaxonomyGroup15] parameter
                    param = new SqlParameter("@HealthcareProviderTaxonomyGroup15", rawImport.HealthcareProviderTaxonomyGroup15);

                    // set parameters[46]
                    parameters[46] = param;

                    // Create [HealthcareProviderTaxonomyGroup2] parameter
                    param = new SqlParameter("@HealthcareProviderTaxonomyGroup2", rawImport.HealthcareProviderTaxonomyGroup2);

                    // set parameters[47]
                    parameters[47] = param;

                    // Create [HealthcareProviderTaxonomyGroup3] parameter
                    param = new SqlParameter("@HealthcareProviderTaxonomyGroup3", rawImport.HealthcareProviderTaxonomyGroup3);

                    // set parameters[48]
                    parameters[48] = param;

                    // Create [HealthcareProviderTaxonomyGroup4] parameter
                    param = new SqlParameter("@HealthcareProviderTaxonomyGroup4", rawImport.HealthcareProviderTaxonomyGroup4);

                    // set parameters[49]
                    parameters[49] = param;

                    // Create [HealthcareProviderTaxonomyGroup5] parameter
                    param = new SqlParameter("@HealthcareProviderTaxonomyGroup5", rawImport.HealthcareProviderTaxonomyGroup5);

                    // set parameters[50]
                    parameters[50] = param;

                    // Create [HealthcareProviderTaxonomyGroup6] parameter
                    param = new SqlParameter("@HealthcareProviderTaxonomyGroup6", rawImport.HealthcareProviderTaxonomyGroup6);

                    // set parameters[51]
                    parameters[51] = param;

                    // Create [HealthcareProviderTaxonomyGroup7] parameter
                    param = new SqlParameter("@HealthcareProviderTaxonomyGroup7", rawImport.HealthcareProviderTaxonomyGroup7);

                    // set parameters[52]
                    parameters[52] = param;

                    // Create [HealthcareProviderTaxonomyGroup8] parameter
                    param = new SqlParameter("@HealthcareProviderTaxonomyGroup8", rawImport.HealthcareProviderTaxonomyGroup8);

                    // set parameters[53]
                    parameters[53] = param;

                    // Create [HealthcareProviderTaxonomyGroup9] parameter
                    param = new SqlParameter("@HealthcareProviderTaxonomyGroup9", rawImport.HealthcareProviderTaxonomyGroup9);

                    // set parameters[54]
                    parameters[54] = param;

                    // Create [IsOrganizationSubpart] parameter
                    param = new SqlParameter("@IsOrganizationSubpart", rawImport.IsOrganizationSubpart);

                    // set parameters[55]
                    parameters[55] = param;

                    // Create [IsSoleProprietor] parameter
                    param = new SqlParameter("@IsSoleProprietor", rawImport.IsSoleProprietor);

                    // set parameters[56]
                    parameters[56] = param;

                    // Create [LastUpdateDate] parameter
                    param = new SqlParameter("@LastUpdateDate", rawImport.LastUpdateDate);

                    // set parameters[57]
                    parameters[57] = param;

                    // Create [NPI] parameter
                    param = new SqlParameter("@NPI", rawImport.NPI);

                    // set parameters[58]
                    parameters[58] = param;

                    // Create [NPIDeactivationDate] parameter
                    param = new SqlParameter("@NPIDeactivationDate", rawImport.NPIDeactivationDate);

                    // set parameters[59]
                    parameters[59] = param;

                    // Create [NPIDeactivationReasonCode] parameter
                    param = new SqlParameter("@NPIDeactivationReasonCode", rawImport.NPIDeactivationReasonCode);

                    // set parameters[60]
                    parameters[60] = param;

                    // Create [NPIReactivationDate] parameter
                    param = new SqlParameter("@NPIReactivationDate", rawImport.NPIReactivationDate);

                    // set parameters[61]
                    parameters[61] = param;

                    // Create [OtherProviderIdentifier1] parameter
                    param = new SqlParameter("@OtherProviderIdentifier1", rawImport.OtherProviderIdentifier1);

                    // set parameters[62]
                    parameters[62] = param;

                    // Create [OtherProviderIdentifier10] parameter
                    param = new SqlParameter("@OtherProviderIdentifier10", rawImport.OtherProviderIdentifier10);

                    // set parameters[63]
                    parameters[63] = param;

                    // Create [OtherProviderIdentifier11] parameter
                    param = new SqlParameter("@OtherProviderIdentifier11", rawImport.OtherProviderIdentifier11);

                    // set parameters[64]
                    parameters[64] = param;

                    // Create [OtherProviderIdentifier12] parameter
                    param = new SqlParameter("@OtherProviderIdentifier12", rawImport.OtherProviderIdentifier12);

                    // set parameters[65]
                    parameters[65] = param;

                    // Create [OtherProviderIdentifier13] parameter
                    param = new SqlParameter("@OtherProviderIdentifier13", rawImport.OtherProviderIdentifier13);

                    // set parameters[66]
                    parameters[66] = param;

                    // Create [OtherProviderIdentifier14] parameter
                    param = new SqlParameter("@OtherProviderIdentifier14", rawImport.OtherProviderIdentifier14);

                    // set parameters[67]
                    parameters[67] = param;

                    // Create [OtherProviderIdentifier15] parameter
                    param = new SqlParameter("@OtherProviderIdentifier15", rawImport.OtherProviderIdentifier15);

                    // set parameters[68]
                    parameters[68] = param;

                    // Create [OtherProviderIdentifier16] parameter
                    param = new SqlParameter("@OtherProviderIdentifier16", rawImport.OtherProviderIdentifier16);

                    // set parameters[69]
                    parameters[69] = param;

                    // Create [OtherProviderIdentifier17] parameter
                    param = new SqlParameter("@OtherProviderIdentifier17", rawImport.OtherProviderIdentifier17);

                    // set parameters[70]
                    parameters[70] = param;

                    // Create [OtherProviderIdentifier18] parameter
                    param = new SqlParameter("@OtherProviderIdentifier18", rawImport.OtherProviderIdentifier18);

                    // set parameters[71]
                    parameters[71] = param;

                    // Create [OtherProviderIdentifier19] parameter
                    param = new SqlParameter("@OtherProviderIdentifier19", rawImport.OtherProviderIdentifier19);

                    // set parameters[72]
                    parameters[72] = param;

                    // Create [OtherProviderIdentifier2] parameter
                    param = new SqlParameter("@OtherProviderIdentifier2", rawImport.OtherProviderIdentifier2);

                    // set parameters[73]
                    parameters[73] = param;

                    // Create [OtherProviderIdentifier20] parameter
                    param = new SqlParameter("@OtherProviderIdentifier20", rawImport.OtherProviderIdentifier20);

                    // set parameters[74]
                    parameters[74] = param;

                    // Create [OtherProviderIdentifier21] parameter
                    param = new SqlParameter("@OtherProviderIdentifier21", rawImport.OtherProviderIdentifier21);

                    // set parameters[75]
                    parameters[75] = param;

                    // Create [OtherProviderIdentifier22] parameter
                    param = new SqlParameter("@OtherProviderIdentifier22", rawImport.OtherProviderIdentifier22);

                    // set parameters[76]
                    parameters[76] = param;

                    // Create [OtherProviderIdentifier23] parameter
                    param = new SqlParameter("@OtherProviderIdentifier23", rawImport.OtherProviderIdentifier23);

                    // set parameters[77]
                    parameters[77] = param;

                    // Create [OtherProviderIdentifier24] parameter
                    param = new SqlParameter("@OtherProviderIdentifier24", rawImport.OtherProviderIdentifier24);

                    // set parameters[78]
                    parameters[78] = param;

                    // Create [OtherProviderIdentifier25] parameter
                    param = new SqlParameter("@OtherProviderIdentifier25", rawImport.OtherProviderIdentifier25);

                    // set parameters[79]
                    parameters[79] = param;

                    // Create [OtherProviderIdentifier26] parameter
                    param = new SqlParameter("@OtherProviderIdentifier26", rawImport.OtherProviderIdentifier26);

                    // set parameters[80]
                    parameters[80] = param;

                    // Create [OtherProviderIdentifier27] parameter
                    param = new SqlParameter("@OtherProviderIdentifier27", rawImport.OtherProviderIdentifier27);

                    // set parameters[81]
                    parameters[81] = param;

                    // Create [OtherProviderIdentifier28] parameter
                    param = new SqlParameter("@OtherProviderIdentifier28", rawImport.OtherProviderIdentifier28);

                    // set parameters[82]
                    parameters[82] = param;

                    // Create [OtherProviderIdentifier29] parameter
                    param = new SqlParameter("@OtherProviderIdentifier29", rawImport.OtherProviderIdentifier29);

                    // set parameters[83]
                    parameters[83] = param;

                    // Create [OtherProviderIdentifier3] parameter
                    param = new SqlParameter("@OtherProviderIdentifier3", rawImport.OtherProviderIdentifier3);

                    // set parameters[84]
                    parameters[84] = param;

                    // Create [OtherProviderIdentifier30] parameter
                    param = new SqlParameter("@OtherProviderIdentifier30", rawImport.OtherProviderIdentifier30);

                    // set parameters[85]
                    parameters[85] = param;

                    // Create [OtherProviderIdentifier31] parameter
                    param = new SqlParameter("@OtherProviderIdentifier31", rawImport.OtherProviderIdentifier31);

                    // set parameters[86]
                    parameters[86] = param;

                    // Create [OtherProviderIdentifier32] parameter
                    param = new SqlParameter("@OtherProviderIdentifier32", rawImport.OtherProviderIdentifier32);

                    // set parameters[87]
                    parameters[87] = param;

                    // Create [OtherProviderIdentifier33] parameter
                    param = new SqlParameter("@OtherProviderIdentifier33", rawImport.OtherProviderIdentifier33);

                    // set parameters[88]
                    parameters[88] = param;

                    // Create [OtherProviderIdentifier34] parameter
                    param = new SqlParameter("@OtherProviderIdentifier34", rawImport.OtherProviderIdentifier34);

                    // set parameters[89]
                    parameters[89] = param;

                    // Create [OtherProviderIdentifier35] parameter
                    param = new SqlParameter("@OtherProviderIdentifier35", rawImport.OtherProviderIdentifier35);

                    // set parameters[90]
                    parameters[90] = param;

                    // Create [OtherProviderIdentifier36] parameter
                    param = new SqlParameter("@OtherProviderIdentifier36", rawImport.OtherProviderIdentifier36);

                    // set parameters[91]
                    parameters[91] = param;

                    // Create [OtherProviderIdentifier37] parameter
                    param = new SqlParameter("@OtherProviderIdentifier37", rawImport.OtherProviderIdentifier37);

                    // set parameters[92]
                    parameters[92] = param;

                    // Create [OtherProviderIdentifier38] parameter
                    param = new SqlParameter("@OtherProviderIdentifier38", rawImport.OtherProviderIdentifier38);

                    // set parameters[93]
                    parameters[93] = param;

                    // Create [OtherProviderIdentifier39] parameter
                    param = new SqlParameter("@OtherProviderIdentifier39", rawImport.OtherProviderIdentifier39);

                    // set parameters[94]
                    parameters[94] = param;

                    // Create [OtherProviderIdentifier4] parameter
                    param = new SqlParameter("@OtherProviderIdentifier4", rawImport.OtherProviderIdentifier4);

                    // set parameters[95]
                    parameters[95] = param;

                    // Create [OtherProviderIdentifier40] parameter
                    param = new SqlParameter("@OtherProviderIdentifier40", rawImport.OtherProviderIdentifier40);

                    // set parameters[96]
                    parameters[96] = param;

                    // Create [OtherProviderIdentifier41] parameter
                    param = new SqlParameter("@OtherProviderIdentifier41", rawImport.OtherProviderIdentifier41);

                    // set parameters[97]
                    parameters[97] = param;

                    // Create [OtherProviderIdentifier42] parameter
                    param = new SqlParameter("@OtherProviderIdentifier42", rawImport.OtherProviderIdentifier42);

                    // set parameters[98]
                    parameters[98] = param;

                    // Create [OtherProviderIdentifier43] parameter
                    param = new SqlParameter("@OtherProviderIdentifier43", rawImport.OtherProviderIdentifier43);

                    // set parameters[99]
                    parameters[99] = param;

                    // Create [OtherProviderIdentifier44] parameter
                    param = new SqlParameter("@OtherProviderIdentifier44", rawImport.OtherProviderIdentifier44);

                    // set parameters[100]
                    parameters[100] = param;

                    // Create [OtherProviderIdentifier45] parameter
                    param = new SqlParameter("@OtherProviderIdentifier45", rawImport.OtherProviderIdentifier45);

                    // set parameters[101]
                    parameters[101] = param;

                    // Create [OtherProviderIdentifier46] parameter
                    param = new SqlParameter("@OtherProviderIdentifier46", rawImport.OtherProviderIdentifier46);

                    // set parameters[102]
                    parameters[102] = param;

                    // Create [OtherProviderIdentifier47] parameter
                    param = new SqlParameter("@OtherProviderIdentifier47", rawImport.OtherProviderIdentifier47);

                    // set parameters[103]
                    parameters[103] = param;

                    // Create [OtherProviderIdentifier48] parameter
                    param = new SqlParameter("@OtherProviderIdentifier48", rawImport.OtherProviderIdentifier48);

                    // set parameters[104]
                    parameters[104] = param;

                    // Create [OtherProviderIdentifier49] parameter
                    param = new SqlParameter("@OtherProviderIdentifier49", rawImport.OtherProviderIdentifier49);

                    // set parameters[105]
                    parameters[105] = param;

                    // Create [OtherProviderIdentifier5] parameter
                    param = new SqlParameter("@OtherProviderIdentifier5", rawImport.OtherProviderIdentifier5);

                    // set parameters[106]
                    parameters[106] = param;

                    // Create [OtherProviderIdentifier50] parameter
                    param = new SqlParameter("@OtherProviderIdentifier50", rawImport.OtherProviderIdentifier50);

                    // set parameters[107]
                    parameters[107] = param;

                    // Create [OtherProviderIdentifier6] parameter
                    param = new SqlParameter("@OtherProviderIdentifier6", rawImport.OtherProviderIdentifier6);

                    // set parameters[108]
                    parameters[108] = param;

                    // Create [OtherProviderIdentifier7] parameter
                    param = new SqlParameter("@OtherProviderIdentifier7", rawImport.OtherProviderIdentifier7);

                    // set parameters[109]
                    parameters[109] = param;

                    // Create [OtherProviderIdentifier8] parameter
                    param = new SqlParameter("@OtherProviderIdentifier8", rawImport.OtherProviderIdentifier8);

                    // set parameters[110]
                    parameters[110] = param;

                    // Create [OtherProviderIdentifier9] parameter
                    param = new SqlParameter("@OtherProviderIdentifier9", rawImport.OtherProviderIdentifier9);

                    // set parameters[111]
                    parameters[111] = param;

                    // Create [OtherProviderIdentifierIssuer1] parameter
                    param = new SqlParameter("@OtherProviderIdentifierIssuer1", rawImport.OtherProviderIdentifierIssuer1);

                    // set parameters[112]
                    parameters[112] = param;

                    // Create [OtherProviderIdentifierIssuer10] parameter
                    param = new SqlParameter("@OtherProviderIdentifierIssuer10", rawImport.OtherProviderIdentifierIssuer10);

                    // set parameters[113]
                    parameters[113] = param;

                    // Create [OtherProviderIdentifierIssuer11] parameter
                    param = new SqlParameter("@OtherProviderIdentifierIssuer11", rawImport.OtherProviderIdentifierIssuer11);

                    // set parameters[114]
                    parameters[114] = param;

                    // Create [OtherProviderIdentifierIssuer12] parameter
                    param = new SqlParameter("@OtherProviderIdentifierIssuer12", rawImport.OtherProviderIdentifierIssuer12);

                    // set parameters[115]
                    parameters[115] = param;

                    // Create [OtherProviderIdentifierIssuer13] parameter
                    param = new SqlParameter("@OtherProviderIdentifierIssuer13", rawImport.OtherProviderIdentifierIssuer13);

                    // set parameters[116]
                    parameters[116] = param;

                    // Create [OtherProviderIdentifierIssuer14] parameter
                    param = new SqlParameter("@OtherProviderIdentifierIssuer14", rawImport.OtherProviderIdentifierIssuer14);

                    // set parameters[117]
                    parameters[117] = param;

                    // Create [OtherProviderIdentifierIssuer15] parameter
                    param = new SqlParameter("@OtherProviderIdentifierIssuer15", rawImport.OtherProviderIdentifierIssuer15);

                    // set parameters[118]
                    parameters[118] = param;

                    // Create [OtherProviderIdentifierIssuer16] parameter
                    param = new SqlParameter("@OtherProviderIdentifierIssuer16", rawImport.OtherProviderIdentifierIssuer16);

                    // set parameters[119]
                    parameters[119] = param;

                    // Create [OtherProviderIdentifierIssuer17] parameter
                    param = new SqlParameter("@OtherProviderIdentifierIssuer17", rawImport.OtherProviderIdentifierIssuer17);

                    // set parameters[120]
                    parameters[120] = param;

                    // Create [OtherProviderIdentifierIssuer18] parameter
                    param = new SqlParameter("@OtherProviderIdentifierIssuer18", rawImport.OtherProviderIdentifierIssuer18);

                    // set parameters[121]
                    parameters[121] = param;

                    // Create [OtherProviderIdentifierIssuer19] parameter
                    param = new SqlParameter("@OtherProviderIdentifierIssuer19", rawImport.OtherProviderIdentifierIssuer19);

                    // set parameters[122]
                    parameters[122] = param;

                    // Create [OtherProviderIdentifierIssuer2] parameter
                    param = new SqlParameter("@OtherProviderIdentifierIssuer2", rawImport.OtherProviderIdentifierIssuer2);

                    // set parameters[123]
                    parameters[123] = param;

                    // Create [OtherProviderIdentifierIssuer20] parameter
                    param = new SqlParameter("@OtherProviderIdentifierIssuer20", rawImport.OtherProviderIdentifierIssuer20);

                    // set parameters[124]
                    parameters[124] = param;

                    // Create [OtherProviderIdentifierIssuer21] parameter
                    param = new SqlParameter("@OtherProviderIdentifierIssuer21", rawImport.OtherProviderIdentifierIssuer21);

                    // set parameters[125]
                    parameters[125] = param;

                    // Create [OtherProviderIdentifierIssuer22] parameter
                    param = new SqlParameter("@OtherProviderIdentifierIssuer22", rawImport.OtherProviderIdentifierIssuer22);

                    // set parameters[126]
                    parameters[126] = param;

                    // Create [OtherProviderIdentifierIssuer23] parameter
                    param = new SqlParameter("@OtherProviderIdentifierIssuer23", rawImport.OtherProviderIdentifierIssuer23);

                    // set parameters[127]
                    parameters[127] = param;

                    // Create [OtherProviderIdentifierIssuer24] parameter
                    param = new SqlParameter("@OtherProviderIdentifierIssuer24", rawImport.OtherProviderIdentifierIssuer24);

                    // set parameters[128]
                    parameters[128] = param;

                    // Create [OtherProviderIdentifierIssuer25] parameter
                    param = new SqlParameter("@OtherProviderIdentifierIssuer25", rawImport.OtherProviderIdentifierIssuer25);

                    // set parameters[129]
                    parameters[129] = param;

                    // Create [OtherProviderIdentifierIssuer26] parameter
                    param = new SqlParameter("@OtherProviderIdentifierIssuer26", rawImport.OtherProviderIdentifierIssuer26);

                    // set parameters[130]
                    parameters[130] = param;

                    // Create [OtherProviderIdentifierIssuer27] parameter
                    param = new SqlParameter("@OtherProviderIdentifierIssuer27", rawImport.OtherProviderIdentifierIssuer27);

                    // set parameters[131]
                    parameters[131] = param;

                    // Create [OtherProviderIdentifierIssuer28] parameter
                    param = new SqlParameter("@OtherProviderIdentifierIssuer28", rawImport.OtherProviderIdentifierIssuer28);

                    // set parameters[132]
                    parameters[132] = param;

                    // Create [OtherProviderIdentifierIssuer29] parameter
                    param = new SqlParameter("@OtherProviderIdentifierIssuer29", rawImport.OtherProviderIdentifierIssuer29);

                    // set parameters[133]
                    parameters[133] = param;

                    // Create [OtherProviderIdentifierIssuer3] parameter
                    param = new SqlParameter("@OtherProviderIdentifierIssuer3", rawImport.OtherProviderIdentifierIssuer3);

                    // set parameters[134]
                    parameters[134] = param;

                    // Create [OtherProviderIdentifierIssuer30] parameter
                    param = new SqlParameter("@OtherProviderIdentifierIssuer30", rawImport.OtherProviderIdentifierIssuer30);

                    // set parameters[135]
                    parameters[135] = param;

                    // Create [OtherProviderIdentifierIssuer31] parameter
                    param = new SqlParameter("@OtherProviderIdentifierIssuer31", rawImport.OtherProviderIdentifierIssuer31);

                    // set parameters[136]
                    parameters[136] = param;

                    // Create [OtherProviderIdentifierIssuer32] parameter
                    param = new SqlParameter("@OtherProviderIdentifierIssuer32", rawImport.OtherProviderIdentifierIssuer32);

                    // set parameters[137]
                    parameters[137] = param;

                    // Create [OtherProviderIdentifierIssuer33] parameter
                    param = new SqlParameter("@OtherProviderIdentifierIssuer33", rawImport.OtherProviderIdentifierIssuer33);

                    // set parameters[138]
                    parameters[138] = param;

                    // Create [OtherProviderIdentifierIssuer34] parameter
                    param = new SqlParameter("@OtherProviderIdentifierIssuer34", rawImport.OtherProviderIdentifierIssuer34);

                    // set parameters[139]
                    parameters[139] = param;

                    // Create [OtherProviderIdentifierIssuer35] parameter
                    param = new SqlParameter("@OtherProviderIdentifierIssuer35", rawImport.OtherProviderIdentifierIssuer35);

                    // set parameters[140]
                    parameters[140] = param;

                    // Create [OtherProviderIdentifierIssuer36] parameter
                    param = new SqlParameter("@OtherProviderIdentifierIssuer36", rawImport.OtherProviderIdentifierIssuer36);

                    // set parameters[141]
                    parameters[141] = param;

                    // Create [OtherProviderIdentifierIssuer37] parameter
                    param = new SqlParameter("@OtherProviderIdentifierIssuer37", rawImport.OtherProviderIdentifierIssuer37);

                    // set parameters[142]
                    parameters[142] = param;

                    // Create [OtherProviderIdentifierIssuer38] parameter
                    param = new SqlParameter("@OtherProviderIdentifierIssuer38", rawImport.OtherProviderIdentifierIssuer38);

                    // set parameters[143]
                    parameters[143] = param;

                    // Create [OtherProviderIdentifierIssuer39] parameter
                    param = new SqlParameter("@OtherProviderIdentifierIssuer39", rawImport.OtherProviderIdentifierIssuer39);

                    // set parameters[144]
                    parameters[144] = param;

                    // Create [OtherProviderIdentifierIssuer4] parameter
                    param = new SqlParameter("@OtherProviderIdentifierIssuer4", rawImport.OtherProviderIdentifierIssuer4);

                    // set parameters[145]
                    parameters[145] = param;

                    // Create [OtherProviderIdentifierIssuer40] parameter
                    param = new SqlParameter("@OtherProviderIdentifierIssuer40", rawImport.OtherProviderIdentifierIssuer40);

                    // set parameters[146]
                    parameters[146] = param;

                    // Create [OtherProviderIdentifierIssuer41] parameter
                    param = new SqlParameter("@OtherProviderIdentifierIssuer41", rawImport.OtherProviderIdentifierIssuer41);

                    // set parameters[147]
                    parameters[147] = param;

                    // Create [OtherProviderIdentifierIssuer42] parameter
                    param = new SqlParameter("@OtherProviderIdentifierIssuer42", rawImport.OtherProviderIdentifierIssuer42);

                    // set parameters[148]
                    parameters[148] = param;

                    // Create [OtherProviderIdentifierIssuer43] parameter
                    param = new SqlParameter("@OtherProviderIdentifierIssuer43", rawImport.OtherProviderIdentifierIssuer43);

                    // set parameters[149]
                    parameters[149] = param;

                    // Create [OtherProviderIdentifierIssuer44] parameter
                    param = new SqlParameter("@OtherProviderIdentifierIssuer44", rawImport.OtherProviderIdentifierIssuer44);

                    // set parameters[150]
                    parameters[150] = param;

                    // Create [OtherProviderIdentifierIssuer45] parameter
                    param = new SqlParameter("@OtherProviderIdentifierIssuer45", rawImport.OtherProviderIdentifierIssuer45);

                    // set parameters[151]
                    parameters[151] = param;

                    // Create [OtherProviderIdentifierIssuer46] parameter
                    param = new SqlParameter("@OtherProviderIdentifierIssuer46", rawImport.OtherProviderIdentifierIssuer46);

                    // set parameters[152]
                    parameters[152] = param;

                    // Create [OtherProviderIdentifierIssuer47] parameter
                    param = new SqlParameter("@OtherProviderIdentifierIssuer47", rawImport.OtherProviderIdentifierIssuer47);

                    // set parameters[153]
                    parameters[153] = param;

                    // Create [OtherProviderIdentifierIssuer48] parameter
                    param = new SqlParameter("@OtherProviderIdentifierIssuer48", rawImport.OtherProviderIdentifierIssuer48);

                    // set parameters[154]
                    parameters[154] = param;

                    // Create [OtherProviderIdentifierIssuer49] parameter
                    param = new SqlParameter("@OtherProviderIdentifierIssuer49", rawImport.OtherProviderIdentifierIssuer49);

                    // set parameters[155]
                    parameters[155] = param;

                    // Create [OtherProviderIdentifierIssuer5] parameter
                    param = new SqlParameter("@OtherProviderIdentifierIssuer5", rawImport.OtherProviderIdentifierIssuer5);

                    // set parameters[156]
                    parameters[156] = param;

                    // Create [OtherProviderIdentifierIssuer50] parameter
                    param = new SqlParameter("@OtherProviderIdentifierIssuer50", rawImport.OtherProviderIdentifierIssuer50);

                    // set parameters[157]
                    parameters[157] = param;

                    // Create [OtherProviderIdentifierIssuer6] parameter
                    param = new SqlParameter("@OtherProviderIdentifierIssuer6", rawImport.OtherProviderIdentifierIssuer6);

                    // set parameters[158]
                    parameters[158] = param;

                    // Create [OtherProviderIdentifierIssuer7] parameter
                    param = new SqlParameter("@OtherProviderIdentifierIssuer7", rawImport.OtherProviderIdentifierIssuer7);

                    // set parameters[159]
                    parameters[159] = param;

                    // Create [OtherProviderIdentifierIssuer8] parameter
                    param = new SqlParameter("@OtherProviderIdentifierIssuer8", rawImport.OtherProviderIdentifierIssuer8);

                    // set parameters[160]
                    parameters[160] = param;

                    // Create [OtherProviderIdentifierIssuer9] parameter
                    param = new SqlParameter("@OtherProviderIdentifierIssuer9", rawImport.OtherProviderIdentifierIssuer9);

                    // set parameters[161]
                    parameters[161] = param;

                    // Create [OtherProviderIdentifierState1] parameter
                    param = new SqlParameter("@OtherProviderIdentifierState1", rawImport.OtherProviderIdentifierState1);

                    // set parameters[162]
                    parameters[162] = param;

                    // Create [OtherProviderIdentifierState10] parameter
                    param = new SqlParameter("@OtherProviderIdentifierState10", rawImport.OtherProviderIdentifierState10);

                    // set parameters[163]
                    parameters[163] = param;

                    // Create [OtherProviderIdentifierState11] parameter
                    param = new SqlParameter("@OtherProviderIdentifierState11", rawImport.OtherProviderIdentifierState11);

                    // set parameters[164]
                    parameters[164] = param;

                    // Create [OtherProviderIdentifierState12] parameter
                    param = new SqlParameter("@OtherProviderIdentifierState12", rawImport.OtherProviderIdentifierState12);

                    // set parameters[165]
                    parameters[165] = param;

                    // Create [OtherProviderIdentifierState13] parameter
                    param = new SqlParameter("@OtherProviderIdentifierState13", rawImport.OtherProviderIdentifierState13);

                    // set parameters[166]
                    parameters[166] = param;

                    // Create [OtherProviderIdentifierState14] parameter
                    param = new SqlParameter("@OtherProviderIdentifierState14", rawImport.OtherProviderIdentifierState14);

                    // set parameters[167]
                    parameters[167] = param;

                    // Create [OtherProviderIdentifierState15] parameter
                    param = new SqlParameter("@OtherProviderIdentifierState15", rawImport.OtherProviderIdentifierState15);

                    // set parameters[168]
                    parameters[168] = param;

                    // Create [OtherProviderIdentifierState16] parameter
                    param = new SqlParameter("@OtherProviderIdentifierState16", rawImport.OtherProviderIdentifierState16);

                    // set parameters[169]
                    parameters[169] = param;

                    // Create [OtherProviderIdentifierState17] parameter
                    param = new SqlParameter("@OtherProviderIdentifierState17", rawImport.OtherProviderIdentifierState17);

                    // set parameters[170]
                    parameters[170] = param;

                    // Create [OtherProviderIdentifierState18] parameter
                    param = new SqlParameter("@OtherProviderIdentifierState18", rawImport.OtherProviderIdentifierState18);

                    // set parameters[171]
                    parameters[171] = param;

                    // Create [OtherProviderIdentifierState19] parameter
                    param = new SqlParameter("@OtherProviderIdentifierState19", rawImport.OtherProviderIdentifierState19);

                    // set parameters[172]
                    parameters[172] = param;

                    // Create [OtherProviderIdentifierState2] parameter
                    param = new SqlParameter("@OtherProviderIdentifierState2", rawImport.OtherProviderIdentifierState2);

                    // set parameters[173]
                    parameters[173] = param;

                    // Create [OtherProviderIdentifierState20] parameter
                    param = new SqlParameter("@OtherProviderIdentifierState20", rawImport.OtherProviderIdentifierState20);

                    // set parameters[174]
                    parameters[174] = param;

                    // Create [OtherProviderIdentifierState21] parameter
                    param = new SqlParameter("@OtherProviderIdentifierState21", rawImport.OtherProviderIdentifierState21);

                    // set parameters[175]
                    parameters[175] = param;

                    // Create [OtherProviderIdentifierState22] parameter
                    param = new SqlParameter("@OtherProviderIdentifierState22", rawImport.OtherProviderIdentifierState22);

                    // set parameters[176]
                    parameters[176] = param;

                    // Create [OtherProviderIdentifierState23] parameter
                    param = new SqlParameter("@OtherProviderIdentifierState23", rawImport.OtherProviderIdentifierState23);

                    // set parameters[177]
                    parameters[177] = param;

                    // Create [OtherProviderIdentifierState24] parameter
                    param = new SqlParameter("@OtherProviderIdentifierState24", rawImport.OtherProviderIdentifierState24);

                    // set parameters[178]
                    parameters[178] = param;

                    // Create [OtherProviderIdentifierState25] parameter
                    param = new SqlParameter("@OtherProviderIdentifierState25", rawImport.OtherProviderIdentifierState25);

                    // set parameters[179]
                    parameters[179] = param;

                    // Create [OtherProviderIdentifierState26] parameter
                    param = new SqlParameter("@OtherProviderIdentifierState26", rawImport.OtherProviderIdentifierState26);

                    // set parameters[180]
                    parameters[180] = param;

                    // Create [OtherProviderIdentifierState27] parameter
                    param = new SqlParameter("@OtherProviderIdentifierState27", rawImport.OtherProviderIdentifierState27);

                    // set parameters[181]
                    parameters[181] = param;

                    // Create [OtherProviderIdentifierState28] parameter
                    param = new SqlParameter("@OtherProviderIdentifierState28", rawImport.OtherProviderIdentifierState28);

                    // set parameters[182]
                    parameters[182] = param;

                    // Create [OtherProviderIdentifierState29] parameter
                    param = new SqlParameter("@OtherProviderIdentifierState29", rawImport.OtherProviderIdentifierState29);

                    // set parameters[183]
                    parameters[183] = param;

                    // Create [OtherProviderIdentifierState3] parameter
                    param = new SqlParameter("@OtherProviderIdentifierState3", rawImport.OtherProviderIdentifierState3);

                    // set parameters[184]
                    parameters[184] = param;

                    // Create [OtherProviderIdentifierState30] parameter
                    param = new SqlParameter("@OtherProviderIdentifierState30", rawImport.OtherProviderIdentifierState30);

                    // set parameters[185]
                    parameters[185] = param;

                    // Create [OtherProviderIdentifierState31] parameter
                    param = new SqlParameter("@OtherProviderIdentifierState31", rawImport.OtherProviderIdentifierState31);

                    // set parameters[186]
                    parameters[186] = param;

                    // Create [OtherProviderIdentifierState32] parameter
                    param = new SqlParameter("@OtherProviderIdentifierState32", rawImport.OtherProviderIdentifierState32);

                    // set parameters[187]
                    parameters[187] = param;

                    // Create [OtherProviderIdentifierState33] parameter
                    param = new SqlParameter("@OtherProviderIdentifierState33", rawImport.OtherProviderIdentifierState33);

                    // set parameters[188]
                    parameters[188] = param;

                    // Create [OtherProviderIdentifierState34] parameter
                    param = new SqlParameter("@OtherProviderIdentifierState34", rawImport.OtherProviderIdentifierState34);

                    // set parameters[189]
                    parameters[189] = param;

                    // Create [OtherProviderIdentifierState35] parameter
                    param = new SqlParameter("@OtherProviderIdentifierState35", rawImport.OtherProviderIdentifierState35);

                    // set parameters[190]
                    parameters[190] = param;

                    // Create [OtherProviderIdentifierState36] parameter
                    param = new SqlParameter("@OtherProviderIdentifierState36", rawImport.OtherProviderIdentifierState36);

                    // set parameters[191]
                    parameters[191] = param;

                    // Create [OtherProviderIdentifierState37] parameter
                    param = new SqlParameter("@OtherProviderIdentifierState37", rawImport.OtherProviderIdentifierState37);

                    // set parameters[192]
                    parameters[192] = param;

                    // Create [OtherProviderIdentifierState38] parameter
                    param = new SqlParameter("@OtherProviderIdentifierState38", rawImport.OtherProviderIdentifierState38);

                    // set parameters[193]
                    parameters[193] = param;

                    // Create [OtherProviderIdentifierState39] parameter
                    param = new SqlParameter("@OtherProviderIdentifierState39", rawImport.OtherProviderIdentifierState39);

                    // set parameters[194]
                    parameters[194] = param;

                    // Create [OtherProviderIdentifierState4] parameter
                    param = new SqlParameter("@OtherProviderIdentifierState4", rawImport.OtherProviderIdentifierState4);

                    // set parameters[195]
                    parameters[195] = param;

                    // Create [OtherProviderIdentifierState40] parameter
                    param = new SqlParameter("@OtherProviderIdentifierState40", rawImport.OtherProviderIdentifierState40);

                    // set parameters[196]
                    parameters[196] = param;

                    // Create [OtherProviderIdentifierState41] parameter
                    param = new SqlParameter("@OtherProviderIdentifierState41", rawImport.OtherProviderIdentifierState41);

                    // set parameters[197]
                    parameters[197] = param;

                    // Create [OtherProviderIdentifierState42] parameter
                    param = new SqlParameter("@OtherProviderIdentifierState42", rawImport.OtherProviderIdentifierState42);

                    // set parameters[198]
                    parameters[198] = param;

                    // Create [OtherProviderIdentifierState43] parameter
                    param = new SqlParameter("@OtherProviderIdentifierState43", rawImport.OtherProviderIdentifierState43);

                    // set parameters[199]
                    parameters[199] = param;

                    // Create [OtherProviderIdentifierState44] parameter
                    param = new SqlParameter("@OtherProviderIdentifierState44", rawImport.OtherProviderIdentifierState44);

                    // set parameters[200]
                    parameters[200] = param;

                    // Create [OtherProviderIdentifierState45] parameter
                    param = new SqlParameter("@OtherProviderIdentifierState45", rawImport.OtherProviderIdentifierState45);

                    // set parameters[201]
                    parameters[201] = param;

                    // Create [OtherProviderIdentifierState46] parameter
                    param = new SqlParameter("@OtherProviderIdentifierState46", rawImport.OtherProviderIdentifierState46);

                    // set parameters[202]
                    parameters[202] = param;

                    // Create [OtherProviderIdentifierState47] parameter
                    param = new SqlParameter("@OtherProviderIdentifierState47", rawImport.OtherProviderIdentifierState47);

                    // set parameters[203]
                    parameters[203] = param;

                    // Create [OtherProviderIdentifierState48] parameter
                    param = new SqlParameter("@OtherProviderIdentifierState48", rawImport.OtherProviderIdentifierState48);

                    // set parameters[204]
                    parameters[204] = param;

                    // Create [OtherProviderIdentifierState49] parameter
                    param = new SqlParameter("@OtherProviderIdentifierState49", rawImport.OtherProviderIdentifierState49);

                    // set parameters[205]
                    parameters[205] = param;

                    // Create [OtherProviderIdentifierState5] parameter
                    param = new SqlParameter("@OtherProviderIdentifierState5", rawImport.OtherProviderIdentifierState5);

                    // set parameters[206]
                    parameters[206] = param;

                    // Create [OtherProviderIdentifierState50] parameter
                    param = new SqlParameter("@OtherProviderIdentifierState50", rawImport.OtherProviderIdentifierState50);

                    // set parameters[207]
                    parameters[207] = param;

                    // Create [OtherProviderIdentifierState6] parameter
                    param = new SqlParameter("@OtherProviderIdentifierState6", rawImport.OtherProviderIdentifierState6);

                    // set parameters[208]
                    parameters[208] = param;

                    // Create [OtherProviderIdentifierState7] parameter
                    param = new SqlParameter("@OtherProviderIdentifierState7", rawImport.OtherProviderIdentifierState7);

                    // set parameters[209]
                    parameters[209] = param;

                    // Create [OtherProviderIdentifierState8] parameter
                    param = new SqlParameter("@OtherProviderIdentifierState8", rawImport.OtherProviderIdentifierState8);

                    // set parameters[210]
                    parameters[210] = param;

                    // Create [OtherProviderIdentifierState9] parameter
                    param = new SqlParameter("@OtherProviderIdentifierState9", rawImport.OtherProviderIdentifierState9);

                    // set parameters[211]
                    parameters[211] = param;

                    // Create [OtherProviderIdentifierTypeCode1] parameter
                    param = new SqlParameter("@OtherProviderIdentifierTypeCode1", rawImport.OtherProviderIdentifierTypeCode1);

                    // set parameters[212]
                    parameters[212] = param;

                    // Create [OtherProviderIdentifierTypeCode10] parameter
                    param = new SqlParameter("@OtherProviderIdentifierTypeCode10", rawImport.OtherProviderIdentifierTypeCode10);

                    // set parameters[213]
                    parameters[213] = param;

                    // Create [OtherProviderIdentifierTypeCode11] parameter
                    param = new SqlParameter("@OtherProviderIdentifierTypeCode11", rawImport.OtherProviderIdentifierTypeCode11);

                    // set parameters[214]
                    parameters[214] = param;

                    // Create [OtherProviderIdentifierTypeCode12] parameter
                    param = new SqlParameter("@OtherProviderIdentifierTypeCode12", rawImport.OtherProviderIdentifierTypeCode12);

                    // set parameters[215]
                    parameters[215] = param;

                    // Create [OtherProviderIdentifierTypeCode13] parameter
                    param = new SqlParameter("@OtherProviderIdentifierTypeCode13", rawImport.OtherProviderIdentifierTypeCode13);

                    // set parameters[216]
                    parameters[216] = param;

                    // Create [OtherProviderIdentifierTypeCode14] parameter
                    param = new SqlParameter("@OtherProviderIdentifierTypeCode14", rawImport.OtherProviderIdentifierTypeCode14);

                    // set parameters[217]
                    parameters[217] = param;

                    // Create [OtherProviderIdentifierTypeCode15] parameter
                    param = new SqlParameter("@OtherProviderIdentifierTypeCode15", rawImport.OtherProviderIdentifierTypeCode15);

                    // set parameters[218]
                    parameters[218] = param;

                    // Create [OtherProviderIdentifierTypeCode16] parameter
                    param = new SqlParameter("@OtherProviderIdentifierTypeCode16", rawImport.OtherProviderIdentifierTypeCode16);

                    // set parameters[219]
                    parameters[219] = param;

                    // Create [OtherProviderIdentifierTypeCode17] parameter
                    param = new SqlParameter("@OtherProviderIdentifierTypeCode17", rawImport.OtherProviderIdentifierTypeCode17);

                    // set parameters[220]
                    parameters[220] = param;

                    // Create [OtherProviderIdentifierTypeCode18] parameter
                    param = new SqlParameter("@OtherProviderIdentifierTypeCode18", rawImport.OtherProviderIdentifierTypeCode18);

                    // set parameters[221]
                    parameters[221] = param;

                    // Create [OtherProviderIdentifierTypeCode19] parameter
                    param = new SqlParameter("@OtherProviderIdentifierTypeCode19", rawImport.OtherProviderIdentifierTypeCode19);

                    // set parameters[222]
                    parameters[222] = param;

                    // Create [OtherProviderIdentifierTypeCode2] parameter
                    param = new SqlParameter("@OtherProviderIdentifierTypeCode2", rawImport.OtherProviderIdentifierTypeCode2);

                    // set parameters[223]
                    parameters[223] = param;

                    // Create [OtherProviderIdentifierTypeCode20] parameter
                    param = new SqlParameter("@OtherProviderIdentifierTypeCode20", rawImport.OtherProviderIdentifierTypeCode20);

                    // set parameters[224]
                    parameters[224] = param;

                    // Create [OtherProviderIdentifierTypeCode21] parameter
                    param = new SqlParameter("@OtherProviderIdentifierTypeCode21", rawImport.OtherProviderIdentifierTypeCode21);

                    // set parameters[225]
                    parameters[225] = param;

                    // Create [OtherProviderIdentifierTypeCode22] parameter
                    param = new SqlParameter("@OtherProviderIdentifierTypeCode22", rawImport.OtherProviderIdentifierTypeCode22);

                    // set parameters[226]
                    parameters[226] = param;

                    // Create [OtherProviderIdentifierTypeCode23] parameter
                    param = new SqlParameter("@OtherProviderIdentifierTypeCode23", rawImport.OtherProviderIdentifierTypeCode23);

                    // set parameters[227]
                    parameters[227] = param;

                    // Create [OtherProviderIdentifierTypeCode24] parameter
                    param = new SqlParameter("@OtherProviderIdentifierTypeCode24", rawImport.OtherProviderIdentifierTypeCode24);

                    // set parameters[228]
                    parameters[228] = param;

                    // Create [OtherProviderIdentifierTypeCode25] parameter
                    param = new SqlParameter("@OtherProviderIdentifierTypeCode25", rawImport.OtherProviderIdentifierTypeCode25);

                    // set parameters[229]
                    parameters[229] = param;

                    // Create [OtherProviderIdentifierTypeCode26] parameter
                    param = new SqlParameter("@OtherProviderIdentifierTypeCode26", rawImport.OtherProviderIdentifierTypeCode26);

                    // set parameters[230]
                    parameters[230] = param;

                    // Create [OtherProviderIdentifierTypeCode27] parameter
                    param = new SqlParameter("@OtherProviderIdentifierTypeCode27", rawImport.OtherProviderIdentifierTypeCode27);

                    // set parameters[231]
                    parameters[231] = param;

                    // Create [OtherProviderIdentifierTypeCode28] parameter
                    param = new SqlParameter("@OtherProviderIdentifierTypeCode28", rawImport.OtherProviderIdentifierTypeCode28);

                    // set parameters[232]
                    parameters[232] = param;

                    // Create [OtherProviderIdentifierTypeCode29] parameter
                    param = new SqlParameter("@OtherProviderIdentifierTypeCode29", rawImport.OtherProviderIdentifierTypeCode29);

                    // set parameters[233]
                    parameters[233] = param;

                    // Create [OtherProviderIdentifierTypeCode3] parameter
                    param = new SqlParameter("@OtherProviderIdentifierTypeCode3", rawImport.OtherProviderIdentifierTypeCode3);

                    // set parameters[234]
                    parameters[234] = param;

                    // Create [OtherProviderIdentifierTypeCode30] parameter
                    param = new SqlParameter("@OtherProviderIdentifierTypeCode30", rawImport.OtherProviderIdentifierTypeCode30);

                    // set parameters[235]
                    parameters[235] = param;

                    // Create [OtherProviderIdentifierTypeCode31] parameter
                    param = new SqlParameter("@OtherProviderIdentifierTypeCode31", rawImport.OtherProviderIdentifierTypeCode31);

                    // set parameters[236]
                    parameters[236] = param;

                    // Create [OtherProviderIdentifierTypeCode32] parameter
                    param = new SqlParameter("@OtherProviderIdentifierTypeCode32", rawImport.OtherProviderIdentifierTypeCode32);

                    // set parameters[237]
                    parameters[237] = param;

                    // Create [OtherProviderIdentifierTypeCode33] parameter
                    param = new SqlParameter("@OtherProviderIdentifierTypeCode33", rawImport.OtherProviderIdentifierTypeCode33);

                    // set parameters[238]
                    parameters[238] = param;

                    // Create [OtherProviderIdentifierTypeCode34] parameter
                    param = new SqlParameter("@OtherProviderIdentifierTypeCode34", rawImport.OtherProviderIdentifierTypeCode34);

                    // set parameters[239]
                    parameters[239] = param;

                    // Create [OtherProviderIdentifierTypeCode35] parameter
                    param = new SqlParameter("@OtherProviderIdentifierTypeCode35", rawImport.OtherProviderIdentifierTypeCode35);

                    // set parameters[240]
                    parameters[240] = param;

                    // Create [OtherProviderIdentifierTypeCode36] parameter
                    param = new SqlParameter("@OtherProviderIdentifierTypeCode36", rawImport.OtherProviderIdentifierTypeCode36);

                    // set parameters[241]
                    parameters[241] = param;

                    // Create [OtherProviderIdentifierTypeCode37] parameter
                    param = new SqlParameter("@OtherProviderIdentifierTypeCode37", rawImport.OtherProviderIdentifierTypeCode37);

                    // set parameters[242]
                    parameters[242] = param;

                    // Create [OtherProviderIdentifierTypeCode38] parameter
                    param = new SqlParameter("@OtherProviderIdentifierTypeCode38", rawImport.OtherProviderIdentifierTypeCode38);

                    // set parameters[243]
                    parameters[243] = param;

                    // Create [OtherProviderIdentifierTypeCode39] parameter
                    param = new SqlParameter("@OtherProviderIdentifierTypeCode39", rawImport.OtherProviderIdentifierTypeCode39);

                    // set parameters[244]
                    parameters[244] = param;

                    // Create [OtherProviderIdentifierTypeCode4] parameter
                    param = new SqlParameter("@OtherProviderIdentifierTypeCode4", rawImport.OtherProviderIdentifierTypeCode4);

                    // set parameters[245]
                    parameters[245] = param;

                    // Create [OtherProviderIdentifierTypeCode40] parameter
                    param = new SqlParameter("@OtherProviderIdentifierTypeCode40", rawImport.OtherProviderIdentifierTypeCode40);

                    // set parameters[246]
                    parameters[246] = param;

                    // Create [OtherProviderIdentifierTypeCode41] parameter
                    param = new SqlParameter("@OtherProviderIdentifierTypeCode41", rawImport.OtherProviderIdentifierTypeCode41);

                    // set parameters[247]
                    parameters[247] = param;

                    // Create [OtherProviderIdentifierTypeCode42] parameter
                    param = new SqlParameter("@OtherProviderIdentifierTypeCode42", rawImport.OtherProviderIdentifierTypeCode42);

                    // set parameters[248]
                    parameters[248] = param;

                    // Create [OtherProviderIdentifierTypeCode43] parameter
                    param = new SqlParameter("@OtherProviderIdentifierTypeCode43", rawImport.OtherProviderIdentifierTypeCode43);

                    // set parameters[249]
                    parameters[249] = param;

                    // Create [OtherProviderIdentifierTypeCode44] parameter
                    param = new SqlParameter("@OtherProviderIdentifierTypeCode44", rawImport.OtherProviderIdentifierTypeCode44);

                    // set parameters[250]
                    parameters[250] = param;

                    // Create [OtherProviderIdentifierTypeCode45] parameter
                    param = new SqlParameter("@OtherProviderIdentifierTypeCode45", rawImport.OtherProviderIdentifierTypeCode45);

                    // set parameters[251]
                    parameters[251] = param;

                    // Create [OtherProviderIdentifierTypeCode46] parameter
                    param = new SqlParameter("@OtherProviderIdentifierTypeCode46", rawImport.OtherProviderIdentifierTypeCode46);

                    // set parameters[252]
                    parameters[252] = param;

                    // Create [OtherProviderIdentifierTypeCode47] parameter
                    param = new SqlParameter("@OtherProviderIdentifierTypeCode47", rawImport.OtherProviderIdentifierTypeCode47);

                    // set parameters[253]
                    parameters[253] = param;

                    // Create [OtherProviderIdentifierTypeCode48] parameter
                    param = new SqlParameter("@OtherProviderIdentifierTypeCode48", rawImport.OtherProviderIdentifierTypeCode48);

                    // set parameters[254]
                    parameters[254] = param;

                    // Create [OtherProviderIdentifierTypeCode49] parameter
                    param = new SqlParameter("@OtherProviderIdentifierTypeCode49", rawImport.OtherProviderIdentifierTypeCode49);

                    // set parameters[255]
                    parameters[255] = param;

                    // Create [OtherProviderIdentifierTypeCode5] parameter
                    param = new SqlParameter("@OtherProviderIdentifierTypeCode5", rawImport.OtherProviderIdentifierTypeCode5);

                    // set parameters[256]
                    parameters[256] = param;

                    // Create [OtherProviderIdentifierTypeCode50] parameter
                    param = new SqlParameter("@OtherProviderIdentifierTypeCode50", rawImport.OtherProviderIdentifierTypeCode50);

                    // set parameters[257]
                    parameters[257] = param;

                    // Create [OtherProviderIdentifierTypeCode6] parameter
                    param = new SqlParameter("@OtherProviderIdentifierTypeCode6", rawImport.OtherProviderIdentifierTypeCode6);

                    // set parameters[258]
                    parameters[258] = param;

                    // Create [OtherProviderIdentifierTypeCode7] parameter
                    param = new SqlParameter("@OtherProviderIdentifierTypeCode7", rawImport.OtherProviderIdentifierTypeCode7);

                    // set parameters[259]
                    parameters[259] = param;

                    // Create [OtherProviderIdentifierTypeCode8] parameter
                    param = new SqlParameter("@OtherProviderIdentifierTypeCode8", rawImport.OtherProviderIdentifierTypeCode8);

                    // set parameters[260]
                    parameters[260] = param;

                    // Create [OtherProviderIdentifierTypeCode9] parameter
                    param = new SqlParameter("@OtherProviderIdentifierTypeCode9", rawImport.OtherProviderIdentifierTypeCode9);

                    // set parameters[261]
                    parameters[261] = param;

                    // Create [ParentOrganizationLBN] parameter
                    param = new SqlParameter("@ParentOrganizationLBN", rawImport.ParentOrganizationLBN);

                    // set parameters[262]
                    parameters[262] = param;

                    // Create [ParentOrganizationTIN] parameter
                    param = new SqlParameter("@ParentOrganizationTIN", rawImport.ParentOrganizationTIN);

                    // set parameters[263]
                    parameters[263] = param;

                    // Create [ProviderBusinessMailingAddressCityName] parameter
                    param = new SqlParameter("@ProviderBusinessMailingAddressCityName", rawImport.ProviderBusinessMailingAddressCityName);

                    // set parameters[264]
                    parameters[264] = param;

                    // Create [ProviderBusinessMailingAddressCountryCodeIfoutsideUS] parameter
                    param = new SqlParameter("@ProviderBusinessMailingAddressCountryCodeIfoutsideUS", rawImport.ProviderBusinessMailingAddressCountryCodeIfoutsideUS);

                    // set parameters[265]
                    parameters[265] = param;

                    // Create [ProviderBusinessMailingAddressFaxNumber] parameter
                    param = new SqlParameter("@ProviderBusinessMailingAddressFaxNumber", rawImport.ProviderBusinessMailingAddressFaxNumber);

                    // set parameters[266]
                    parameters[266] = param;

                    // Create [ProviderBusinessMailingAddressPostalCode] parameter
                    param = new SqlParameter("@ProviderBusinessMailingAddressPostalCode", rawImport.ProviderBusinessMailingAddressPostalCode);

                    // set parameters[267]
                    parameters[267] = param;

                    // Create [ProviderBusinessMailingAddressStateName] parameter
                    param = new SqlParameter("@ProviderBusinessMailingAddressStateName", rawImport.ProviderBusinessMailingAddressStateName);

                    // set parameters[268]
                    parameters[268] = param;

                    // Create [ProviderBusinessMailingAddressTelephoneNumber] parameter
                    param = new SqlParameter("@ProviderBusinessMailingAddressTelephoneNumber", rawImport.ProviderBusinessMailingAddressTelephoneNumber);

                    // set parameters[269]
                    parameters[269] = param;

                    // Create [ProviderBusinessPracticeLocationAddressCityName] parameter
                    param = new SqlParameter("@ProviderBusinessPracticeLocationAddressCityName", rawImport.ProviderBusinessPracticeLocationAddressCityName);

                    // set parameters[270]
                    parameters[270] = param;

                    // Create [ProviderBusinessPracticeLocationAddressCountryCodeIfoutsideUS] parameter
                    param = new SqlParameter("@ProviderBusinessPracticeLocationAddressCountryCodeIfoutsideUS", rawImport.ProviderBusinessPracticeLocationAddressCountryCodeIfoutsideUS);

                    // set parameters[271]
                    parameters[271] = param;

                    // Create [ProviderBusinessPracticeLocationAddressFaxNumber] parameter
                    param = new SqlParameter("@ProviderBusinessPracticeLocationAddressFaxNumber", rawImport.ProviderBusinessPracticeLocationAddressFaxNumber);

                    // set parameters[272]
                    parameters[272] = param;

                    // Create [ProviderBusinessPracticeLocationAddressPostalCode] parameter
                    param = new SqlParameter("@ProviderBusinessPracticeLocationAddressPostalCode", rawImport.ProviderBusinessPracticeLocationAddressPostalCode);

                    // set parameters[273]
                    parameters[273] = param;

                    // Create [ProviderBusinessPracticeLocationAddressStateName] parameter
                    param = new SqlParameter("@ProviderBusinessPracticeLocationAddressStateName", rawImport.ProviderBusinessPracticeLocationAddressStateName);

                    // set parameters[274]
                    parameters[274] = param;

                    // Create [ProviderBusinessPracticeLocationAddressTelephoneNumber] parameter
                    param = new SqlParameter("@ProviderBusinessPracticeLocationAddressTelephoneNumber", rawImport.ProviderBusinessPracticeLocationAddressTelephoneNumber);

                    // set parameters[275]
                    parameters[275] = param;

                    // Create [ProviderCredentialText] parameter
                    param = new SqlParameter("@ProviderCredentialText", rawImport.ProviderCredentialText);

                    // set parameters[276]
                    parameters[276] = param;

                    // Create [ProviderEnumerationDate] parameter
                    param = new SqlParameter("@ProviderEnumerationDate", rawImport.ProviderEnumerationDate);

                    // set parameters[277]
                    parameters[277] = param;

                    // Create [ProviderFirstLineBusinessMailingAddress] parameter
                    param = new SqlParameter("@ProviderFirstLineBusinessMailingAddress", rawImport.ProviderFirstLineBusinessMailingAddress);

                    // set parameters[278]
                    parameters[278] = param;

                    // Create [ProviderFirstLineBusinessPracticeLocationAddress] parameter
                    param = new SqlParameter("@ProviderFirstLineBusinessPracticeLocationAddress", rawImport.ProviderFirstLineBusinessPracticeLocationAddress);

                    // set parameters[279]
                    parameters[279] = param;

                    // Create [ProviderFirstName] parameter
                    param = new SqlParameter("@ProviderFirstName", rawImport.ProviderFirstName);

                    // set parameters[280]
                    parameters[280] = param;

                    // Create [ProviderGenderCode] parameter
                    param = new SqlParameter("@ProviderGenderCode", rawImport.ProviderGenderCode);

                    // set parameters[281]
                    parameters[281] = param;

                    // Create [ProviderLastNameLegalName] parameter
                    param = new SqlParameter("@ProviderLastNameLegalName", rawImport.ProviderLastNameLegalName);

                    // set parameters[282]
                    parameters[282] = param;

                    // Create [ProviderLicenseNumber1] parameter
                    param = new SqlParameter("@ProviderLicenseNumber1", rawImport.ProviderLicenseNumber1);

                    // set parameters[283]
                    parameters[283] = param;

                    // Create [ProviderLicenseNumber10] parameter
                    param = new SqlParameter("@ProviderLicenseNumber10", rawImport.ProviderLicenseNumber10);

                    // set parameters[284]
                    parameters[284] = param;

                    // Create [ProviderLicenseNumber11] parameter
                    param = new SqlParameter("@ProviderLicenseNumber11", rawImport.ProviderLicenseNumber11);

                    // set parameters[285]
                    parameters[285] = param;

                    // Create [ProviderLicenseNumber12] parameter
                    param = new SqlParameter("@ProviderLicenseNumber12", rawImport.ProviderLicenseNumber12);

                    // set parameters[286]
                    parameters[286] = param;

                    // Create [ProviderLicenseNumber13] parameter
                    param = new SqlParameter("@ProviderLicenseNumber13", rawImport.ProviderLicenseNumber13);

                    // set parameters[287]
                    parameters[287] = param;

                    // Create [ProviderLicenseNumber14] parameter
                    param = new SqlParameter("@ProviderLicenseNumber14", rawImport.ProviderLicenseNumber14);

                    // set parameters[288]
                    parameters[288] = param;

                    // Create [ProviderLicenseNumber15] parameter
                    param = new SqlParameter("@ProviderLicenseNumber15", rawImport.ProviderLicenseNumber15);

                    // set parameters[289]
                    parameters[289] = param;

                    // Create [ProviderLicenseNumber2] parameter
                    param = new SqlParameter("@ProviderLicenseNumber2", rawImport.ProviderLicenseNumber2);

                    // set parameters[290]
                    parameters[290] = param;

                    // Create [ProviderLicenseNumber3] parameter
                    param = new SqlParameter("@ProviderLicenseNumber3", rawImport.ProviderLicenseNumber3);

                    // set parameters[291]
                    parameters[291] = param;

                    // Create [ProviderLicenseNumber4] parameter
                    param = new SqlParameter("@ProviderLicenseNumber4", rawImport.ProviderLicenseNumber4);

                    // set parameters[292]
                    parameters[292] = param;

                    // Create [ProviderLicenseNumber5] parameter
                    param = new SqlParameter("@ProviderLicenseNumber5", rawImport.ProviderLicenseNumber5);

                    // set parameters[293]
                    parameters[293] = param;

                    // Create [ProviderLicenseNumber6] parameter
                    param = new SqlParameter("@ProviderLicenseNumber6", rawImport.ProviderLicenseNumber6);

                    // set parameters[294]
                    parameters[294] = param;

                    // Create [ProviderLicenseNumber7] parameter
                    param = new SqlParameter("@ProviderLicenseNumber7", rawImport.ProviderLicenseNumber7);

                    // set parameters[295]
                    parameters[295] = param;

                    // Create [ProviderLicenseNumber8] parameter
                    param = new SqlParameter("@ProviderLicenseNumber8", rawImport.ProviderLicenseNumber8);

                    // set parameters[296]
                    parameters[296] = param;

                    // Create [ProviderLicenseNumber9] parameter
                    param = new SqlParameter("@ProviderLicenseNumber9", rawImport.ProviderLicenseNumber9);

                    // set parameters[297]
                    parameters[297] = param;

                    // Create [ProviderLicenseNumberStateCode1] parameter
                    param = new SqlParameter("@ProviderLicenseNumberStateCode1", rawImport.ProviderLicenseNumberStateCode1);

                    // set parameters[298]
                    parameters[298] = param;

                    // Create [ProviderLicenseNumberStateCode10] parameter
                    param = new SqlParameter("@ProviderLicenseNumberStateCode10", rawImport.ProviderLicenseNumberStateCode10);

                    // set parameters[299]
                    parameters[299] = param;

                    // Create [ProviderLicenseNumberStateCode11] parameter
                    param = new SqlParameter("@ProviderLicenseNumberStateCode11", rawImport.ProviderLicenseNumberStateCode11);

                    // set parameters[300]
                    parameters[300] = param;

                    // Create [ProviderLicenseNumberStateCode12] parameter
                    param = new SqlParameter("@ProviderLicenseNumberStateCode12", rawImport.ProviderLicenseNumberStateCode12);

                    // set parameters[301]
                    parameters[301] = param;

                    // Create [ProviderLicenseNumberStateCode13] parameter
                    param = new SqlParameter("@ProviderLicenseNumberStateCode13", rawImport.ProviderLicenseNumberStateCode13);

                    // set parameters[302]
                    parameters[302] = param;

                    // Create [ProviderLicenseNumberStateCode14] parameter
                    param = new SqlParameter("@ProviderLicenseNumberStateCode14", rawImport.ProviderLicenseNumberStateCode14);

                    // set parameters[303]
                    parameters[303] = param;

                    // Create [ProviderLicenseNumberStateCode15] parameter
                    param = new SqlParameter("@ProviderLicenseNumberStateCode15", rawImport.ProviderLicenseNumberStateCode15);

                    // set parameters[304]
                    parameters[304] = param;

                    // Create [ProviderLicenseNumberStateCode2] parameter
                    param = new SqlParameter("@ProviderLicenseNumberStateCode2", rawImport.ProviderLicenseNumberStateCode2);

                    // set parameters[305]
                    parameters[305] = param;

                    // Create [ProviderLicenseNumberStateCode3] parameter
                    param = new SqlParameter("@ProviderLicenseNumberStateCode3", rawImport.ProviderLicenseNumberStateCode3);

                    // set parameters[306]
                    parameters[306] = param;

                    // Create [ProviderLicenseNumberStateCode4] parameter
                    param = new SqlParameter("@ProviderLicenseNumberStateCode4", rawImport.ProviderLicenseNumberStateCode4);

                    // set parameters[307]
                    parameters[307] = param;

                    // Create [ProviderLicenseNumberStateCode5] parameter
                    param = new SqlParameter("@ProviderLicenseNumberStateCode5", rawImport.ProviderLicenseNumberStateCode5);

                    // set parameters[308]
                    parameters[308] = param;

                    // Create [ProviderLicenseNumberStateCode6] parameter
                    param = new SqlParameter("@ProviderLicenseNumberStateCode6", rawImport.ProviderLicenseNumberStateCode6);

                    // set parameters[309]
                    parameters[309] = param;

                    // Create [ProviderLicenseNumberStateCode7] parameter
                    param = new SqlParameter("@ProviderLicenseNumberStateCode7", rawImport.ProviderLicenseNumberStateCode7);

                    // set parameters[310]
                    parameters[310] = param;

                    // Create [ProviderLicenseNumberStateCode8] parameter
                    param = new SqlParameter("@ProviderLicenseNumberStateCode8", rawImport.ProviderLicenseNumberStateCode8);

                    // set parameters[311]
                    parameters[311] = param;

                    // Create [ProviderLicenseNumberStateCode9] parameter
                    param = new SqlParameter("@ProviderLicenseNumberStateCode9", rawImport.ProviderLicenseNumberStateCode9);

                    // set parameters[312]
                    parameters[312] = param;

                    // Create [ProviderMiddleName] parameter
                    param = new SqlParameter("@ProviderMiddleName", rawImport.ProviderMiddleName);

                    // set parameters[313]
                    parameters[313] = param;

                    // Create [ProviderNamePrefixText] parameter
                    param = new SqlParameter("@ProviderNamePrefixText", rawImport.ProviderNamePrefixText);

                    // set parameters[314]
                    parameters[314] = param;

                    // Create [ProviderNameSuffixText] parameter
                    param = new SqlParameter("@ProviderNameSuffixText", rawImport.ProviderNameSuffixText);

                    // set parameters[315]
                    parameters[315] = param;

                    // Create [ProviderOrganizationNameLegalBusinessName] parameter
                    param = new SqlParameter("@ProviderOrganizationNameLegalBusinessName", rawImport.ProviderOrganizationNameLegalBusinessName);

                    // set parameters[316]
                    parameters[316] = param;

                    // Create [ProviderOtherCredentialText] parameter
                    param = new SqlParameter("@ProviderOtherCredentialText", rawImport.ProviderOtherCredentialText);

                    // set parameters[317]
                    parameters[317] = param;

                    // Create [ProviderOtherFirstName] parameter
                    param = new SqlParameter("@ProviderOtherFirstName", rawImport.ProviderOtherFirstName);

                    // set parameters[318]
                    parameters[318] = param;

                    // Create [ProviderOtherLastName] parameter
                    param = new SqlParameter("@ProviderOtherLastName", rawImport.ProviderOtherLastName);

                    // set parameters[319]
                    parameters[319] = param;

                    // Create [ProviderOtherLastNameTypeCode] parameter
                    param = new SqlParameter("@ProviderOtherLastNameTypeCode", rawImport.ProviderOtherLastNameTypeCode);

                    // set parameters[320]
                    parameters[320] = param;

                    // Create [ProviderOtherMiddleName] parameter
                    param = new SqlParameter("@ProviderOtherMiddleName", rawImport.ProviderOtherMiddleName);

                    // set parameters[321]
                    parameters[321] = param;

                    // Create [ProviderOtherNamePrefixText] parameter
                    param = new SqlParameter("@ProviderOtherNamePrefixText", rawImport.ProviderOtherNamePrefixText);

                    // set parameters[322]
                    parameters[322] = param;

                    // Create [ProviderOtherNameSuffixText] parameter
                    param = new SqlParameter("@ProviderOtherNameSuffixText", rawImport.ProviderOtherNameSuffixText);

                    // set parameters[323]
                    parameters[323] = param;

                    // Create [ProviderOtherOrganizationName] parameter
                    param = new SqlParameter("@ProviderOtherOrganizationName", rawImport.ProviderOtherOrganizationName);

                    // set parameters[324]
                    parameters[324] = param;

                    // Create [ProviderOtherOrganizationNameTypeCode] parameter
                    param = new SqlParameter("@ProviderOtherOrganizationNameTypeCode", rawImport.ProviderOtherOrganizationNameTypeCode);

                    // set parameters[325]
                    parameters[325] = param;

                    // Create [ProviderSecondLineBusinessMailingAddress] parameter
                    param = new SqlParameter("@ProviderSecondLineBusinessMailingAddress", rawImport.ProviderSecondLineBusinessMailingAddress);

                    // set parameters[326]
                    parameters[326] = param;

                    // Create [ProviderSecondLineBusinessPracticeLocationAddress] parameter
                    param = new SqlParameter("@ProviderSecondLineBusinessPracticeLocationAddress", rawImport.ProviderSecondLineBusinessPracticeLocationAddress);

                    // set parameters[327]
                    parameters[327] = param;

                    // Create [ReplacementNPI] parameter
                    param = new SqlParameter("@ReplacementNPI", rawImport.ReplacementNPI);

                    // set parameters[328]
                    parameters[328] = param;
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
                SqlParameter[] parameters = new SqlParameter[330];
                SqlParameter param = null;

                // verify rawImportexists
                if(rawImport != null)
                {
                    // Create parameter for [AuthorizedOfficialCredentialText]
                    param = new SqlParameter("@AuthorizedOfficialCredentialText", rawImport.AuthorizedOfficialCredentialText);

                    // set parameters[0]
                    parameters[0] = param;

                    // Create parameter for [AuthorizedOfficialFirstName]
                    param = new SqlParameter("@AuthorizedOfficialFirstName", rawImport.AuthorizedOfficialFirstName);

                    // set parameters[1]
                    parameters[1] = param;

                    // Create parameter for [AuthorizedOfficialLastName]
                    param = new SqlParameter("@AuthorizedOfficialLastName", rawImport.AuthorizedOfficialLastName);

                    // set parameters[2]
                    parameters[2] = param;

                    // Create parameter for [AuthorizedOfficialMiddleName]
                    param = new SqlParameter("@AuthorizedOfficialMiddleName", rawImport.AuthorizedOfficialMiddleName);

                    // set parameters[3]
                    parameters[3] = param;

                    // Create parameter for [AuthorizedOfficialNamePrefixText]
                    param = new SqlParameter("@AuthorizedOfficialNamePrefixText", rawImport.AuthorizedOfficialNamePrefixText);

                    // set parameters[4]
                    parameters[4] = param;

                    // Create parameter for [AuthorizedOfficialNameSuffixText]
                    param = new SqlParameter("@AuthorizedOfficialNameSuffixText", rawImport.AuthorizedOfficialNameSuffixText);

                    // set parameters[5]
                    parameters[5] = param;

                    // Create parameter for [AuthorizedOfficialTelephoneNumber]
                    param = new SqlParameter("@AuthorizedOfficialTelephoneNumber", rawImport.AuthorizedOfficialTelephoneNumber);

                    // set parameters[6]
                    parameters[6] = param;

                    // Create parameter for [AuthorizedOfficialTitleorPosition]
                    param = new SqlParameter("@AuthorizedOfficialTitleorPosition", rawImport.AuthorizedOfficialTitleorPosition);

                    // set parameters[7]
                    parameters[7] = param;

                    // Create parameter for [EmployerIdentificationNumberEIN]
                    param = new SqlParameter("@EmployerIdentificationNumberEIN", rawImport.EmployerIdentificationNumberEIN);

                    // set parameters[8]
                    parameters[8] = param;

                    // Create parameter for [EntityTypeCode]
                    param = new SqlParameter("@EntityTypeCode", rawImport.EntityTypeCode);

                    // set parameters[9]
                    parameters[9] = param;

                    // Create parameter for [HealthcareProviderPrimaryTaxonomySwitch1]
                    param = new SqlParameter("@HealthcareProviderPrimaryTaxonomySwitch1", rawImport.HealthcareProviderPrimaryTaxonomySwitch1);

                    // set parameters[10]
                    parameters[10] = param;

                    // Create parameter for [HealthcareProviderPrimaryTaxonomySwitch10]
                    param = new SqlParameter("@HealthcareProviderPrimaryTaxonomySwitch10", rawImport.HealthcareProviderPrimaryTaxonomySwitch10);

                    // set parameters[11]
                    parameters[11] = param;

                    // Create parameter for [HealthcareProviderPrimaryTaxonomySwitch11]
                    param = new SqlParameter("@HealthcareProviderPrimaryTaxonomySwitch11", rawImport.HealthcareProviderPrimaryTaxonomySwitch11);

                    // set parameters[12]
                    parameters[12] = param;

                    // Create parameter for [HealthcareProviderPrimaryTaxonomySwitch12]
                    param = new SqlParameter("@HealthcareProviderPrimaryTaxonomySwitch12", rawImport.HealthcareProviderPrimaryTaxonomySwitch12);

                    // set parameters[13]
                    parameters[13] = param;

                    // Create parameter for [HealthcareProviderPrimaryTaxonomySwitch13]
                    param = new SqlParameter("@HealthcareProviderPrimaryTaxonomySwitch13", rawImport.HealthcareProviderPrimaryTaxonomySwitch13);

                    // set parameters[14]
                    parameters[14] = param;

                    // Create parameter for [HealthcareProviderPrimaryTaxonomySwitch14]
                    param = new SqlParameter("@HealthcareProviderPrimaryTaxonomySwitch14", rawImport.HealthcareProviderPrimaryTaxonomySwitch14);

                    // set parameters[15]
                    parameters[15] = param;

                    // Create parameter for [HealthcareProviderPrimaryTaxonomySwitch15]
                    param = new SqlParameter("@HealthcareProviderPrimaryTaxonomySwitch15", rawImport.HealthcareProviderPrimaryTaxonomySwitch15);

                    // set parameters[16]
                    parameters[16] = param;

                    // Create parameter for [HealthcareProviderPrimaryTaxonomySwitch2]
                    param = new SqlParameter("@HealthcareProviderPrimaryTaxonomySwitch2", rawImport.HealthcareProviderPrimaryTaxonomySwitch2);

                    // set parameters[17]
                    parameters[17] = param;

                    // Create parameter for [HealthcareProviderPrimaryTaxonomySwitch3]
                    param = new SqlParameter("@HealthcareProviderPrimaryTaxonomySwitch3", rawImport.HealthcareProviderPrimaryTaxonomySwitch3);

                    // set parameters[18]
                    parameters[18] = param;

                    // Create parameter for [HealthcareProviderPrimaryTaxonomySwitch4]
                    param = new SqlParameter("@HealthcareProviderPrimaryTaxonomySwitch4", rawImport.HealthcareProviderPrimaryTaxonomySwitch4);

                    // set parameters[19]
                    parameters[19] = param;

                    // Create parameter for [HealthcareProviderPrimaryTaxonomySwitch5]
                    param = new SqlParameter("@HealthcareProviderPrimaryTaxonomySwitch5", rawImport.HealthcareProviderPrimaryTaxonomySwitch5);

                    // set parameters[20]
                    parameters[20] = param;

                    // Create parameter for [HealthcareProviderPrimaryTaxonomySwitch6]
                    param = new SqlParameter("@HealthcareProviderPrimaryTaxonomySwitch6", rawImport.HealthcareProviderPrimaryTaxonomySwitch6);

                    // set parameters[21]
                    parameters[21] = param;

                    // Create parameter for [HealthcareProviderPrimaryTaxonomySwitch7]
                    param = new SqlParameter("@HealthcareProviderPrimaryTaxonomySwitch7", rawImport.HealthcareProviderPrimaryTaxonomySwitch7);

                    // set parameters[22]
                    parameters[22] = param;

                    // Create parameter for [HealthcareProviderPrimaryTaxonomySwitch8]
                    param = new SqlParameter("@HealthcareProviderPrimaryTaxonomySwitch8", rawImport.HealthcareProviderPrimaryTaxonomySwitch8);

                    // set parameters[23]
                    parameters[23] = param;

                    // Create parameter for [HealthcareProviderPrimaryTaxonomySwitch9]
                    param = new SqlParameter("@HealthcareProviderPrimaryTaxonomySwitch9", rawImport.HealthcareProviderPrimaryTaxonomySwitch9);

                    // set parameters[24]
                    parameters[24] = param;

                    // Create parameter for [HealthcareProviderTaxonomyCode1]
                    param = new SqlParameter("@HealthcareProviderTaxonomyCode1", rawImport.HealthcareProviderTaxonomyCode1);

                    // set parameters[25]
                    parameters[25] = param;

                    // Create parameter for [HealthcareProviderTaxonomyCode10]
                    param = new SqlParameter("@HealthcareProviderTaxonomyCode10", rawImport.HealthcareProviderTaxonomyCode10);

                    // set parameters[26]
                    parameters[26] = param;

                    // Create parameter for [HealthcareProviderTaxonomyCode11]
                    param = new SqlParameter("@HealthcareProviderTaxonomyCode11", rawImport.HealthcareProviderTaxonomyCode11);

                    // set parameters[27]
                    parameters[27] = param;

                    // Create parameter for [HealthcareProviderTaxonomyCode12]
                    param = new SqlParameter("@HealthcareProviderTaxonomyCode12", rawImport.HealthcareProviderTaxonomyCode12);

                    // set parameters[28]
                    parameters[28] = param;

                    // Create parameter for [HealthcareProviderTaxonomyCode13]
                    param = new SqlParameter("@HealthcareProviderTaxonomyCode13", rawImport.HealthcareProviderTaxonomyCode13);

                    // set parameters[29]
                    parameters[29] = param;

                    // Create parameter for [HealthcareProviderTaxonomyCode14]
                    param = new SqlParameter("@HealthcareProviderTaxonomyCode14", rawImport.HealthcareProviderTaxonomyCode14);

                    // set parameters[30]
                    parameters[30] = param;

                    // Create parameter for [HealthcareProviderTaxonomyCode15]
                    param = new SqlParameter("@HealthcareProviderTaxonomyCode15", rawImport.HealthcareProviderTaxonomyCode15);

                    // set parameters[31]
                    parameters[31] = param;

                    // Create parameter for [HealthcareProviderTaxonomyCode2]
                    param = new SqlParameter("@HealthcareProviderTaxonomyCode2", rawImport.HealthcareProviderTaxonomyCode2);

                    // set parameters[32]
                    parameters[32] = param;

                    // Create parameter for [HealthcareProviderTaxonomyCode3]
                    param = new SqlParameter("@HealthcareProviderTaxonomyCode3", rawImport.HealthcareProviderTaxonomyCode3);

                    // set parameters[33]
                    parameters[33] = param;

                    // Create parameter for [HealthcareProviderTaxonomyCode4]
                    param = new SqlParameter("@HealthcareProviderTaxonomyCode4", rawImport.HealthcareProviderTaxonomyCode4);

                    // set parameters[34]
                    parameters[34] = param;

                    // Create parameter for [HealthcareProviderTaxonomyCode5]
                    param = new SqlParameter("@HealthcareProviderTaxonomyCode5", rawImport.HealthcareProviderTaxonomyCode5);

                    // set parameters[35]
                    parameters[35] = param;

                    // Create parameter for [HealthcareProviderTaxonomyCode6]
                    param = new SqlParameter("@HealthcareProviderTaxonomyCode6", rawImport.HealthcareProviderTaxonomyCode6);

                    // set parameters[36]
                    parameters[36] = param;

                    // Create parameter for [HealthcareProviderTaxonomyCode7]
                    param = new SqlParameter("@HealthcareProviderTaxonomyCode7", rawImport.HealthcareProviderTaxonomyCode7);

                    // set parameters[37]
                    parameters[37] = param;

                    // Create parameter for [HealthcareProviderTaxonomyCode8]
                    param = new SqlParameter("@HealthcareProviderTaxonomyCode8", rawImport.HealthcareProviderTaxonomyCode8);

                    // set parameters[38]
                    parameters[38] = param;

                    // Create parameter for [HealthcareProviderTaxonomyCode9]
                    param = new SqlParameter("@HealthcareProviderTaxonomyCode9", rawImport.HealthcareProviderTaxonomyCode9);

                    // set parameters[39]
                    parameters[39] = param;

                    // Create parameter for [HealthcareProviderTaxonomyGroup1]
                    param = new SqlParameter("@HealthcareProviderTaxonomyGroup1", rawImport.HealthcareProviderTaxonomyGroup1);

                    // set parameters[40]
                    parameters[40] = param;

                    // Create parameter for [HealthcareProviderTaxonomyGroup10]
                    param = new SqlParameter("@HealthcareProviderTaxonomyGroup10", rawImport.HealthcareProviderTaxonomyGroup10);

                    // set parameters[41]
                    parameters[41] = param;

                    // Create parameter for [HealthcareProviderTaxonomyGroup11]
                    param = new SqlParameter("@HealthcareProviderTaxonomyGroup11", rawImport.HealthcareProviderTaxonomyGroup11);

                    // set parameters[42]
                    parameters[42] = param;

                    // Create parameter for [HealthcareProviderTaxonomyGroup12]
                    param = new SqlParameter("@HealthcareProviderTaxonomyGroup12", rawImport.HealthcareProviderTaxonomyGroup12);

                    // set parameters[43]
                    parameters[43] = param;

                    // Create parameter for [HealthcareProviderTaxonomyGroup13]
                    param = new SqlParameter("@HealthcareProviderTaxonomyGroup13", rawImport.HealthcareProviderTaxonomyGroup13);

                    // set parameters[44]
                    parameters[44] = param;

                    // Create parameter for [HealthcareProviderTaxonomyGroup14]
                    param = new SqlParameter("@HealthcareProviderTaxonomyGroup14", rawImport.HealthcareProviderTaxonomyGroup14);

                    // set parameters[45]
                    parameters[45] = param;

                    // Create parameter for [HealthcareProviderTaxonomyGroup15]
                    param = new SqlParameter("@HealthcareProviderTaxonomyGroup15", rawImport.HealthcareProviderTaxonomyGroup15);

                    // set parameters[46]
                    parameters[46] = param;

                    // Create parameter for [HealthcareProviderTaxonomyGroup2]
                    param = new SqlParameter("@HealthcareProviderTaxonomyGroup2", rawImport.HealthcareProviderTaxonomyGroup2);

                    // set parameters[47]
                    parameters[47] = param;

                    // Create parameter for [HealthcareProviderTaxonomyGroup3]
                    param = new SqlParameter("@HealthcareProviderTaxonomyGroup3", rawImport.HealthcareProviderTaxonomyGroup3);

                    // set parameters[48]
                    parameters[48] = param;

                    // Create parameter for [HealthcareProviderTaxonomyGroup4]
                    param = new SqlParameter("@HealthcareProviderTaxonomyGroup4", rawImport.HealthcareProviderTaxonomyGroup4);

                    // set parameters[49]
                    parameters[49] = param;

                    // Create parameter for [HealthcareProviderTaxonomyGroup5]
                    param = new SqlParameter("@HealthcareProviderTaxonomyGroup5", rawImport.HealthcareProviderTaxonomyGroup5);

                    // set parameters[50]
                    parameters[50] = param;

                    // Create parameter for [HealthcareProviderTaxonomyGroup6]
                    param = new SqlParameter("@HealthcareProviderTaxonomyGroup6", rawImport.HealthcareProviderTaxonomyGroup6);

                    // set parameters[51]
                    parameters[51] = param;

                    // Create parameter for [HealthcareProviderTaxonomyGroup7]
                    param = new SqlParameter("@HealthcareProviderTaxonomyGroup7", rawImport.HealthcareProviderTaxonomyGroup7);

                    // set parameters[52]
                    parameters[52] = param;

                    // Create parameter for [HealthcareProviderTaxonomyGroup8]
                    param = new SqlParameter("@HealthcareProviderTaxonomyGroup8", rawImport.HealthcareProviderTaxonomyGroup8);

                    // set parameters[53]
                    parameters[53] = param;

                    // Create parameter for [HealthcareProviderTaxonomyGroup9]
                    param = new SqlParameter("@HealthcareProviderTaxonomyGroup9", rawImport.HealthcareProviderTaxonomyGroup9);

                    // set parameters[54]
                    parameters[54] = param;

                    // Create parameter for [IsOrganizationSubpart]
                    param = new SqlParameter("@IsOrganizationSubpart", rawImport.IsOrganizationSubpart);

                    // set parameters[55]
                    parameters[55] = param;

                    // Create parameter for [IsSoleProprietor]
                    param = new SqlParameter("@IsSoleProprietor", rawImport.IsSoleProprietor);

                    // set parameters[56]
                    parameters[56] = param;

                    // Create parameter for [LastUpdateDate]
                    param = new SqlParameter("@LastUpdateDate", rawImport.LastUpdateDate);

                    // set parameters[57]
                    parameters[57] = param;

                    // Create parameter for [NPI]
                    param = new SqlParameter("@NPI", rawImport.NPI);

                    // set parameters[58]
                    parameters[58] = param;

                    // Create parameter for [NPIDeactivationDate]
                    param = new SqlParameter("@NPIDeactivationDate", rawImport.NPIDeactivationDate);

                    // set parameters[59]
                    parameters[59] = param;

                    // Create parameter for [NPIDeactivationReasonCode]
                    param = new SqlParameter("@NPIDeactivationReasonCode", rawImport.NPIDeactivationReasonCode);

                    // set parameters[60]
                    parameters[60] = param;

                    // Create parameter for [NPIReactivationDate]
                    param = new SqlParameter("@NPIReactivationDate", rawImport.NPIReactivationDate);

                    // set parameters[61]
                    parameters[61] = param;

                    // Create parameter for [OtherProviderIdentifier1]
                    param = new SqlParameter("@OtherProviderIdentifier1", rawImport.OtherProviderIdentifier1);

                    // set parameters[62]
                    parameters[62] = param;

                    // Create parameter for [OtherProviderIdentifier10]
                    param = new SqlParameter("@OtherProviderIdentifier10", rawImport.OtherProviderIdentifier10);

                    // set parameters[63]
                    parameters[63] = param;

                    // Create parameter for [OtherProviderIdentifier11]
                    param = new SqlParameter("@OtherProviderIdentifier11", rawImport.OtherProviderIdentifier11);

                    // set parameters[64]
                    parameters[64] = param;

                    // Create parameter for [OtherProviderIdentifier12]
                    param = new SqlParameter("@OtherProviderIdentifier12", rawImport.OtherProviderIdentifier12);

                    // set parameters[65]
                    parameters[65] = param;

                    // Create parameter for [OtherProviderIdentifier13]
                    param = new SqlParameter("@OtherProviderIdentifier13", rawImport.OtherProviderIdentifier13);

                    // set parameters[66]
                    parameters[66] = param;

                    // Create parameter for [OtherProviderIdentifier14]
                    param = new SqlParameter("@OtherProviderIdentifier14", rawImport.OtherProviderIdentifier14);

                    // set parameters[67]
                    parameters[67] = param;

                    // Create parameter for [OtherProviderIdentifier15]
                    param = new SqlParameter("@OtherProviderIdentifier15", rawImport.OtherProviderIdentifier15);

                    // set parameters[68]
                    parameters[68] = param;

                    // Create parameter for [OtherProviderIdentifier16]
                    param = new SqlParameter("@OtherProviderIdentifier16", rawImport.OtherProviderIdentifier16);

                    // set parameters[69]
                    parameters[69] = param;

                    // Create parameter for [OtherProviderIdentifier17]
                    param = new SqlParameter("@OtherProviderIdentifier17", rawImport.OtherProviderIdentifier17);

                    // set parameters[70]
                    parameters[70] = param;

                    // Create parameter for [OtherProviderIdentifier18]
                    param = new SqlParameter("@OtherProviderIdentifier18", rawImport.OtherProviderIdentifier18);

                    // set parameters[71]
                    parameters[71] = param;

                    // Create parameter for [OtherProviderIdentifier19]
                    param = new SqlParameter("@OtherProviderIdentifier19", rawImport.OtherProviderIdentifier19);

                    // set parameters[72]
                    parameters[72] = param;

                    // Create parameter for [OtherProviderIdentifier2]
                    param = new SqlParameter("@OtherProviderIdentifier2", rawImport.OtherProviderIdentifier2);

                    // set parameters[73]
                    parameters[73] = param;

                    // Create parameter for [OtherProviderIdentifier20]
                    param = new SqlParameter("@OtherProviderIdentifier20", rawImport.OtherProviderIdentifier20);

                    // set parameters[74]
                    parameters[74] = param;

                    // Create parameter for [OtherProviderIdentifier21]
                    param = new SqlParameter("@OtherProviderIdentifier21", rawImport.OtherProviderIdentifier21);

                    // set parameters[75]
                    parameters[75] = param;

                    // Create parameter for [OtherProviderIdentifier22]
                    param = new SqlParameter("@OtherProviderIdentifier22", rawImport.OtherProviderIdentifier22);

                    // set parameters[76]
                    parameters[76] = param;

                    // Create parameter for [OtherProviderIdentifier23]
                    param = new SqlParameter("@OtherProviderIdentifier23", rawImport.OtherProviderIdentifier23);

                    // set parameters[77]
                    parameters[77] = param;

                    // Create parameter for [OtherProviderIdentifier24]
                    param = new SqlParameter("@OtherProviderIdentifier24", rawImport.OtherProviderIdentifier24);

                    // set parameters[78]
                    parameters[78] = param;

                    // Create parameter for [OtherProviderIdentifier25]
                    param = new SqlParameter("@OtherProviderIdentifier25", rawImport.OtherProviderIdentifier25);

                    // set parameters[79]
                    parameters[79] = param;

                    // Create parameter for [OtherProviderIdentifier26]
                    param = new SqlParameter("@OtherProviderIdentifier26", rawImport.OtherProviderIdentifier26);

                    // set parameters[80]
                    parameters[80] = param;

                    // Create parameter for [OtherProviderIdentifier27]
                    param = new SqlParameter("@OtherProviderIdentifier27", rawImport.OtherProviderIdentifier27);

                    // set parameters[81]
                    parameters[81] = param;

                    // Create parameter for [OtherProviderIdentifier28]
                    param = new SqlParameter("@OtherProviderIdentifier28", rawImport.OtherProviderIdentifier28);

                    // set parameters[82]
                    parameters[82] = param;

                    // Create parameter for [OtherProviderIdentifier29]
                    param = new SqlParameter("@OtherProviderIdentifier29", rawImport.OtherProviderIdentifier29);

                    // set parameters[83]
                    parameters[83] = param;

                    // Create parameter for [OtherProviderIdentifier3]
                    param = new SqlParameter("@OtherProviderIdentifier3", rawImport.OtherProviderIdentifier3);

                    // set parameters[84]
                    parameters[84] = param;

                    // Create parameter for [OtherProviderIdentifier30]
                    param = new SqlParameter("@OtherProviderIdentifier30", rawImport.OtherProviderIdentifier30);

                    // set parameters[85]
                    parameters[85] = param;

                    // Create parameter for [OtherProviderIdentifier31]
                    param = new SqlParameter("@OtherProviderIdentifier31", rawImport.OtherProviderIdentifier31);

                    // set parameters[86]
                    parameters[86] = param;

                    // Create parameter for [OtherProviderIdentifier32]
                    param = new SqlParameter("@OtherProviderIdentifier32", rawImport.OtherProviderIdentifier32);

                    // set parameters[87]
                    parameters[87] = param;

                    // Create parameter for [OtherProviderIdentifier33]
                    param = new SqlParameter("@OtherProviderIdentifier33", rawImport.OtherProviderIdentifier33);

                    // set parameters[88]
                    parameters[88] = param;

                    // Create parameter for [OtherProviderIdentifier34]
                    param = new SqlParameter("@OtherProviderIdentifier34", rawImport.OtherProviderIdentifier34);

                    // set parameters[89]
                    parameters[89] = param;

                    // Create parameter for [OtherProviderIdentifier35]
                    param = new SqlParameter("@OtherProviderIdentifier35", rawImport.OtherProviderIdentifier35);

                    // set parameters[90]
                    parameters[90] = param;

                    // Create parameter for [OtherProviderIdentifier36]
                    param = new SqlParameter("@OtherProviderIdentifier36", rawImport.OtherProviderIdentifier36);

                    // set parameters[91]
                    parameters[91] = param;

                    // Create parameter for [OtherProviderIdentifier37]
                    param = new SqlParameter("@OtherProviderIdentifier37", rawImport.OtherProviderIdentifier37);

                    // set parameters[92]
                    parameters[92] = param;

                    // Create parameter for [OtherProviderIdentifier38]
                    param = new SqlParameter("@OtherProviderIdentifier38", rawImport.OtherProviderIdentifier38);

                    // set parameters[93]
                    parameters[93] = param;

                    // Create parameter for [OtherProviderIdentifier39]
                    param = new SqlParameter("@OtherProviderIdentifier39", rawImport.OtherProviderIdentifier39);

                    // set parameters[94]
                    parameters[94] = param;

                    // Create parameter for [OtherProviderIdentifier4]
                    param = new SqlParameter("@OtherProviderIdentifier4", rawImport.OtherProviderIdentifier4);

                    // set parameters[95]
                    parameters[95] = param;

                    // Create parameter for [OtherProviderIdentifier40]
                    param = new SqlParameter("@OtherProviderIdentifier40", rawImport.OtherProviderIdentifier40);

                    // set parameters[96]
                    parameters[96] = param;

                    // Create parameter for [OtherProviderIdentifier41]
                    param = new SqlParameter("@OtherProviderIdentifier41", rawImport.OtherProviderIdentifier41);

                    // set parameters[97]
                    parameters[97] = param;

                    // Create parameter for [OtherProviderIdentifier42]
                    param = new SqlParameter("@OtherProviderIdentifier42", rawImport.OtherProviderIdentifier42);

                    // set parameters[98]
                    parameters[98] = param;

                    // Create parameter for [OtherProviderIdentifier43]
                    param = new SqlParameter("@OtherProviderIdentifier43", rawImport.OtherProviderIdentifier43);

                    // set parameters[99]
                    parameters[99] = param;

                    // Create parameter for [OtherProviderIdentifier44]
                    param = new SqlParameter("@OtherProviderIdentifier44", rawImport.OtherProviderIdentifier44);

                    // set parameters[100]
                    parameters[100] = param;

                    // Create parameter for [OtherProviderIdentifier45]
                    param = new SqlParameter("@OtherProviderIdentifier45", rawImport.OtherProviderIdentifier45);

                    // set parameters[101]
                    parameters[101] = param;

                    // Create parameter for [OtherProviderIdentifier46]
                    param = new SqlParameter("@OtherProviderIdentifier46", rawImport.OtherProviderIdentifier46);

                    // set parameters[102]
                    parameters[102] = param;

                    // Create parameter for [OtherProviderIdentifier47]
                    param = new SqlParameter("@OtherProviderIdentifier47", rawImport.OtherProviderIdentifier47);

                    // set parameters[103]
                    parameters[103] = param;

                    // Create parameter for [OtherProviderIdentifier48]
                    param = new SqlParameter("@OtherProviderIdentifier48", rawImport.OtherProviderIdentifier48);

                    // set parameters[104]
                    parameters[104] = param;

                    // Create parameter for [OtherProviderIdentifier49]
                    param = new SqlParameter("@OtherProviderIdentifier49", rawImport.OtherProviderIdentifier49);

                    // set parameters[105]
                    parameters[105] = param;

                    // Create parameter for [OtherProviderIdentifier5]
                    param = new SqlParameter("@OtherProviderIdentifier5", rawImport.OtherProviderIdentifier5);

                    // set parameters[106]
                    parameters[106] = param;

                    // Create parameter for [OtherProviderIdentifier50]
                    param = new SqlParameter("@OtherProviderIdentifier50", rawImport.OtherProviderIdentifier50);

                    // set parameters[107]
                    parameters[107] = param;

                    // Create parameter for [OtherProviderIdentifier6]
                    param = new SqlParameter("@OtherProviderIdentifier6", rawImport.OtherProviderIdentifier6);

                    // set parameters[108]
                    parameters[108] = param;

                    // Create parameter for [OtherProviderIdentifier7]
                    param = new SqlParameter("@OtherProviderIdentifier7", rawImport.OtherProviderIdentifier7);

                    // set parameters[109]
                    parameters[109] = param;

                    // Create parameter for [OtherProviderIdentifier8]
                    param = new SqlParameter("@OtherProviderIdentifier8", rawImport.OtherProviderIdentifier8);

                    // set parameters[110]
                    parameters[110] = param;

                    // Create parameter for [OtherProviderIdentifier9]
                    param = new SqlParameter("@OtherProviderIdentifier9", rawImport.OtherProviderIdentifier9);

                    // set parameters[111]
                    parameters[111] = param;

                    // Create parameter for [OtherProviderIdentifierIssuer1]
                    param = new SqlParameter("@OtherProviderIdentifierIssuer1", rawImport.OtherProviderIdentifierIssuer1);

                    // set parameters[112]
                    parameters[112] = param;

                    // Create parameter for [OtherProviderIdentifierIssuer10]
                    param = new SqlParameter("@OtherProviderIdentifierIssuer10", rawImport.OtherProviderIdentifierIssuer10);

                    // set parameters[113]
                    parameters[113] = param;

                    // Create parameter for [OtherProviderIdentifierIssuer11]
                    param = new SqlParameter("@OtherProviderIdentifierIssuer11", rawImport.OtherProviderIdentifierIssuer11);

                    // set parameters[114]
                    parameters[114] = param;

                    // Create parameter for [OtherProviderIdentifierIssuer12]
                    param = new SqlParameter("@OtherProviderIdentifierIssuer12", rawImport.OtherProviderIdentifierIssuer12);

                    // set parameters[115]
                    parameters[115] = param;

                    // Create parameter for [OtherProviderIdentifierIssuer13]
                    param = new SqlParameter("@OtherProviderIdentifierIssuer13", rawImport.OtherProviderIdentifierIssuer13);

                    // set parameters[116]
                    parameters[116] = param;

                    // Create parameter for [OtherProviderIdentifierIssuer14]
                    param = new SqlParameter("@OtherProviderIdentifierIssuer14", rawImport.OtherProviderIdentifierIssuer14);

                    // set parameters[117]
                    parameters[117] = param;

                    // Create parameter for [OtherProviderIdentifierIssuer15]
                    param = new SqlParameter("@OtherProviderIdentifierIssuer15", rawImport.OtherProviderIdentifierIssuer15);

                    // set parameters[118]
                    parameters[118] = param;

                    // Create parameter for [OtherProviderIdentifierIssuer16]
                    param = new SqlParameter("@OtherProviderIdentifierIssuer16", rawImport.OtherProviderIdentifierIssuer16);

                    // set parameters[119]
                    parameters[119] = param;

                    // Create parameter for [OtherProviderIdentifierIssuer17]
                    param = new SqlParameter("@OtherProviderIdentifierIssuer17", rawImport.OtherProviderIdentifierIssuer17);

                    // set parameters[120]
                    parameters[120] = param;

                    // Create parameter for [OtherProviderIdentifierIssuer18]
                    param = new SqlParameter("@OtherProviderIdentifierIssuer18", rawImport.OtherProviderIdentifierIssuer18);

                    // set parameters[121]
                    parameters[121] = param;

                    // Create parameter for [OtherProviderIdentifierIssuer19]
                    param = new SqlParameter("@OtherProviderIdentifierIssuer19", rawImport.OtherProviderIdentifierIssuer19);

                    // set parameters[122]
                    parameters[122] = param;

                    // Create parameter for [OtherProviderIdentifierIssuer2]
                    param = new SqlParameter("@OtherProviderIdentifierIssuer2", rawImport.OtherProviderIdentifierIssuer2);

                    // set parameters[123]
                    parameters[123] = param;

                    // Create parameter for [OtherProviderIdentifierIssuer20]
                    param = new SqlParameter("@OtherProviderIdentifierIssuer20", rawImport.OtherProviderIdentifierIssuer20);

                    // set parameters[124]
                    parameters[124] = param;

                    // Create parameter for [OtherProviderIdentifierIssuer21]
                    param = new SqlParameter("@OtherProviderIdentifierIssuer21", rawImport.OtherProviderIdentifierIssuer21);

                    // set parameters[125]
                    parameters[125] = param;

                    // Create parameter for [OtherProviderIdentifierIssuer22]
                    param = new SqlParameter("@OtherProviderIdentifierIssuer22", rawImport.OtherProviderIdentifierIssuer22);

                    // set parameters[126]
                    parameters[126] = param;

                    // Create parameter for [OtherProviderIdentifierIssuer23]
                    param = new SqlParameter("@OtherProviderIdentifierIssuer23", rawImport.OtherProviderIdentifierIssuer23);

                    // set parameters[127]
                    parameters[127] = param;

                    // Create parameter for [OtherProviderIdentifierIssuer24]
                    param = new SqlParameter("@OtherProviderIdentifierIssuer24", rawImport.OtherProviderIdentifierIssuer24);

                    // set parameters[128]
                    parameters[128] = param;

                    // Create parameter for [OtherProviderIdentifierIssuer25]
                    param = new SqlParameter("@OtherProviderIdentifierIssuer25", rawImport.OtherProviderIdentifierIssuer25);

                    // set parameters[129]
                    parameters[129] = param;

                    // Create parameter for [OtherProviderIdentifierIssuer26]
                    param = new SqlParameter("@OtherProviderIdentifierIssuer26", rawImport.OtherProviderIdentifierIssuer26);

                    // set parameters[130]
                    parameters[130] = param;

                    // Create parameter for [OtherProviderIdentifierIssuer27]
                    param = new SqlParameter("@OtherProviderIdentifierIssuer27", rawImport.OtherProviderIdentifierIssuer27);

                    // set parameters[131]
                    parameters[131] = param;

                    // Create parameter for [OtherProviderIdentifierIssuer28]
                    param = new SqlParameter("@OtherProviderIdentifierIssuer28", rawImport.OtherProviderIdentifierIssuer28);

                    // set parameters[132]
                    parameters[132] = param;

                    // Create parameter for [OtherProviderIdentifierIssuer29]
                    param = new SqlParameter("@OtherProviderIdentifierIssuer29", rawImport.OtherProviderIdentifierIssuer29);

                    // set parameters[133]
                    parameters[133] = param;

                    // Create parameter for [OtherProviderIdentifierIssuer3]
                    param = new SqlParameter("@OtherProviderIdentifierIssuer3", rawImport.OtherProviderIdentifierIssuer3);

                    // set parameters[134]
                    parameters[134] = param;

                    // Create parameter for [OtherProviderIdentifierIssuer30]
                    param = new SqlParameter("@OtherProviderIdentifierIssuer30", rawImport.OtherProviderIdentifierIssuer30);

                    // set parameters[135]
                    parameters[135] = param;

                    // Create parameter for [OtherProviderIdentifierIssuer31]
                    param = new SqlParameter("@OtherProviderIdentifierIssuer31", rawImport.OtherProviderIdentifierIssuer31);

                    // set parameters[136]
                    parameters[136] = param;

                    // Create parameter for [OtherProviderIdentifierIssuer32]
                    param = new SqlParameter("@OtherProviderIdentifierIssuer32", rawImport.OtherProviderIdentifierIssuer32);

                    // set parameters[137]
                    parameters[137] = param;

                    // Create parameter for [OtherProviderIdentifierIssuer33]
                    param = new SqlParameter("@OtherProviderIdentifierIssuer33", rawImport.OtherProviderIdentifierIssuer33);

                    // set parameters[138]
                    parameters[138] = param;

                    // Create parameter for [OtherProviderIdentifierIssuer34]
                    param = new SqlParameter("@OtherProviderIdentifierIssuer34", rawImport.OtherProviderIdentifierIssuer34);

                    // set parameters[139]
                    parameters[139] = param;

                    // Create parameter for [OtherProviderIdentifierIssuer35]
                    param = new SqlParameter("@OtherProviderIdentifierIssuer35", rawImport.OtherProviderIdentifierIssuer35);

                    // set parameters[140]
                    parameters[140] = param;

                    // Create parameter for [OtherProviderIdentifierIssuer36]
                    param = new SqlParameter("@OtherProviderIdentifierIssuer36", rawImport.OtherProviderIdentifierIssuer36);

                    // set parameters[141]
                    parameters[141] = param;

                    // Create parameter for [OtherProviderIdentifierIssuer37]
                    param = new SqlParameter("@OtherProviderIdentifierIssuer37", rawImport.OtherProviderIdentifierIssuer37);

                    // set parameters[142]
                    parameters[142] = param;

                    // Create parameter for [OtherProviderIdentifierIssuer38]
                    param = new SqlParameter("@OtherProviderIdentifierIssuer38", rawImport.OtherProviderIdentifierIssuer38);

                    // set parameters[143]
                    parameters[143] = param;

                    // Create parameter for [OtherProviderIdentifierIssuer39]
                    param = new SqlParameter("@OtherProviderIdentifierIssuer39", rawImport.OtherProviderIdentifierIssuer39);

                    // set parameters[144]
                    parameters[144] = param;

                    // Create parameter for [OtherProviderIdentifierIssuer4]
                    param = new SqlParameter("@OtherProviderIdentifierIssuer4", rawImport.OtherProviderIdentifierIssuer4);

                    // set parameters[145]
                    parameters[145] = param;

                    // Create parameter for [OtherProviderIdentifierIssuer40]
                    param = new SqlParameter("@OtherProviderIdentifierIssuer40", rawImport.OtherProviderIdentifierIssuer40);

                    // set parameters[146]
                    parameters[146] = param;

                    // Create parameter for [OtherProviderIdentifierIssuer41]
                    param = new SqlParameter("@OtherProviderIdentifierIssuer41", rawImport.OtherProviderIdentifierIssuer41);

                    // set parameters[147]
                    parameters[147] = param;

                    // Create parameter for [OtherProviderIdentifierIssuer42]
                    param = new SqlParameter("@OtherProviderIdentifierIssuer42", rawImport.OtherProviderIdentifierIssuer42);

                    // set parameters[148]
                    parameters[148] = param;

                    // Create parameter for [OtherProviderIdentifierIssuer43]
                    param = new SqlParameter("@OtherProviderIdentifierIssuer43", rawImport.OtherProviderIdentifierIssuer43);

                    // set parameters[149]
                    parameters[149] = param;

                    // Create parameter for [OtherProviderIdentifierIssuer44]
                    param = new SqlParameter("@OtherProviderIdentifierIssuer44", rawImport.OtherProviderIdentifierIssuer44);

                    // set parameters[150]
                    parameters[150] = param;

                    // Create parameter for [OtherProviderIdentifierIssuer45]
                    param = new SqlParameter("@OtherProviderIdentifierIssuer45", rawImport.OtherProviderIdentifierIssuer45);

                    // set parameters[151]
                    parameters[151] = param;

                    // Create parameter for [OtherProviderIdentifierIssuer46]
                    param = new SqlParameter("@OtherProviderIdentifierIssuer46", rawImport.OtherProviderIdentifierIssuer46);

                    // set parameters[152]
                    parameters[152] = param;

                    // Create parameter for [OtherProviderIdentifierIssuer47]
                    param = new SqlParameter("@OtherProviderIdentifierIssuer47", rawImport.OtherProviderIdentifierIssuer47);

                    // set parameters[153]
                    parameters[153] = param;

                    // Create parameter for [OtherProviderIdentifierIssuer48]
                    param = new SqlParameter("@OtherProviderIdentifierIssuer48", rawImport.OtherProviderIdentifierIssuer48);

                    // set parameters[154]
                    parameters[154] = param;

                    // Create parameter for [OtherProviderIdentifierIssuer49]
                    param = new SqlParameter("@OtherProviderIdentifierIssuer49", rawImport.OtherProviderIdentifierIssuer49);

                    // set parameters[155]
                    parameters[155] = param;

                    // Create parameter for [OtherProviderIdentifierIssuer5]
                    param = new SqlParameter("@OtherProviderIdentifierIssuer5", rawImport.OtherProviderIdentifierIssuer5);

                    // set parameters[156]
                    parameters[156] = param;

                    // Create parameter for [OtherProviderIdentifierIssuer50]
                    param = new SqlParameter("@OtherProviderIdentifierIssuer50", rawImport.OtherProviderIdentifierIssuer50);

                    // set parameters[157]
                    parameters[157] = param;

                    // Create parameter for [OtherProviderIdentifierIssuer6]
                    param = new SqlParameter("@OtherProviderIdentifierIssuer6", rawImport.OtherProviderIdentifierIssuer6);

                    // set parameters[158]
                    parameters[158] = param;

                    // Create parameter for [OtherProviderIdentifierIssuer7]
                    param = new SqlParameter("@OtherProviderIdentifierIssuer7", rawImport.OtherProviderIdentifierIssuer7);

                    // set parameters[159]
                    parameters[159] = param;

                    // Create parameter for [OtherProviderIdentifierIssuer8]
                    param = new SqlParameter("@OtherProviderIdentifierIssuer8", rawImport.OtherProviderIdentifierIssuer8);

                    // set parameters[160]
                    parameters[160] = param;

                    // Create parameter for [OtherProviderIdentifierIssuer9]
                    param = new SqlParameter("@OtherProviderIdentifierIssuer9", rawImport.OtherProviderIdentifierIssuer9);

                    // set parameters[161]
                    parameters[161] = param;

                    // Create parameter for [OtherProviderIdentifierState1]
                    param = new SqlParameter("@OtherProviderIdentifierState1", rawImport.OtherProviderIdentifierState1);

                    // set parameters[162]
                    parameters[162] = param;

                    // Create parameter for [OtherProviderIdentifierState10]
                    param = new SqlParameter("@OtherProviderIdentifierState10", rawImport.OtherProviderIdentifierState10);

                    // set parameters[163]
                    parameters[163] = param;

                    // Create parameter for [OtherProviderIdentifierState11]
                    param = new SqlParameter("@OtherProviderIdentifierState11", rawImport.OtherProviderIdentifierState11);

                    // set parameters[164]
                    parameters[164] = param;

                    // Create parameter for [OtherProviderIdentifierState12]
                    param = new SqlParameter("@OtherProviderIdentifierState12", rawImport.OtherProviderIdentifierState12);

                    // set parameters[165]
                    parameters[165] = param;

                    // Create parameter for [OtherProviderIdentifierState13]
                    param = new SqlParameter("@OtherProviderIdentifierState13", rawImport.OtherProviderIdentifierState13);

                    // set parameters[166]
                    parameters[166] = param;

                    // Create parameter for [OtherProviderIdentifierState14]
                    param = new SqlParameter("@OtherProviderIdentifierState14", rawImport.OtherProviderIdentifierState14);

                    // set parameters[167]
                    parameters[167] = param;

                    // Create parameter for [OtherProviderIdentifierState15]
                    param = new SqlParameter("@OtherProviderIdentifierState15", rawImport.OtherProviderIdentifierState15);

                    // set parameters[168]
                    parameters[168] = param;

                    // Create parameter for [OtherProviderIdentifierState16]
                    param = new SqlParameter("@OtherProviderIdentifierState16", rawImport.OtherProviderIdentifierState16);

                    // set parameters[169]
                    parameters[169] = param;

                    // Create parameter for [OtherProviderIdentifierState17]
                    param = new SqlParameter("@OtherProviderIdentifierState17", rawImport.OtherProviderIdentifierState17);

                    // set parameters[170]
                    parameters[170] = param;

                    // Create parameter for [OtherProviderIdentifierState18]
                    param = new SqlParameter("@OtherProviderIdentifierState18", rawImport.OtherProviderIdentifierState18);

                    // set parameters[171]
                    parameters[171] = param;

                    // Create parameter for [OtherProviderIdentifierState19]
                    param = new SqlParameter("@OtherProviderIdentifierState19", rawImport.OtherProviderIdentifierState19);

                    // set parameters[172]
                    parameters[172] = param;

                    // Create parameter for [OtherProviderIdentifierState2]
                    param = new SqlParameter("@OtherProviderIdentifierState2", rawImport.OtherProviderIdentifierState2);

                    // set parameters[173]
                    parameters[173] = param;

                    // Create parameter for [OtherProviderIdentifierState20]
                    param = new SqlParameter("@OtherProviderIdentifierState20", rawImport.OtherProviderIdentifierState20);

                    // set parameters[174]
                    parameters[174] = param;

                    // Create parameter for [OtherProviderIdentifierState21]
                    param = new SqlParameter("@OtherProviderIdentifierState21", rawImport.OtherProviderIdentifierState21);

                    // set parameters[175]
                    parameters[175] = param;

                    // Create parameter for [OtherProviderIdentifierState22]
                    param = new SqlParameter("@OtherProviderIdentifierState22", rawImport.OtherProviderIdentifierState22);

                    // set parameters[176]
                    parameters[176] = param;

                    // Create parameter for [OtherProviderIdentifierState23]
                    param = new SqlParameter("@OtherProviderIdentifierState23", rawImport.OtherProviderIdentifierState23);

                    // set parameters[177]
                    parameters[177] = param;

                    // Create parameter for [OtherProviderIdentifierState24]
                    param = new SqlParameter("@OtherProviderIdentifierState24", rawImport.OtherProviderIdentifierState24);

                    // set parameters[178]
                    parameters[178] = param;

                    // Create parameter for [OtherProviderIdentifierState25]
                    param = new SqlParameter("@OtherProviderIdentifierState25", rawImport.OtherProviderIdentifierState25);

                    // set parameters[179]
                    parameters[179] = param;

                    // Create parameter for [OtherProviderIdentifierState26]
                    param = new SqlParameter("@OtherProviderIdentifierState26", rawImport.OtherProviderIdentifierState26);

                    // set parameters[180]
                    parameters[180] = param;

                    // Create parameter for [OtherProviderIdentifierState27]
                    param = new SqlParameter("@OtherProviderIdentifierState27", rawImport.OtherProviderIdentifierState27);

                    // set parameters[181]
                    parameters[181] = param;

                    // Create parameter for [OtherProviderIdentifierState28]
                    param = new SqlParameter("@OtherProviderIdentifierState28", rawImport.OtherProviderIdentifierState28);

                    // set parameters[182]
                    parameters[182] = param;

                    // Create parameter for [OtherProviderIdentifierState29]
                    param = new SqlParameter("@OtherProviderIdentifierState29", rawImport.OtherProviderIdentifierState29);

                    // set parameters[183]
                    parameters[183] = param;

                    // Create parameter for [OtherProviderIdentifierState3]
                    param = new SqlParameter("@OtherProviderIdentifierState3", rawImport.OtherProviderIdentifierState3);

                    // set parameters[184]
                    parameters[184] = param;

                    // Create parameter for [OtherProviderIdentifierState30]
                    param = new SqlParameter("@OtherProviderIdentifierState30", rawImport.OtherProviderIdentifierState30);

                    // set parameters[185]
                    parameters[185] = param;

                    // Create parameter for [OtherProviderIdentifierState31]
                    param = new SqlParameter("@OtherProviderIdentifierState31", rawImport.OtherProviderIdentifierState31);

                    // set parameters[186]
                    parameters[186] = param;

                    // Create parameter for [OtherProviderIdentifierState32]
                    param = new SqlParameter("@OtherProviderIdentifierState32", rawImport.OtherProviderIdentifierState32);

                    // set parameters[187]
                    parameters[187] = param;

                    // Create parameter for [OtherProviderIdentifierState33]
                    param = new SqlParameter("@OtherProviderIdentifierState33", rawImport.OtherProviderIdentifierState33);

                    // set parameters[188]
                    parameters[188] = param;

                    // Create parameter for [OtherProviderIdentifierState34]
                    param = new SqlParameter("@OtherProviderIdentifierState34", rawImport.OtherProviderIdentifierState34);

                    // set parameters[189]
                    parameters[189] = param;

                    // Create parameter for [OtherProviderIdentifierState35]
                    param = new SqlParameter("@OtherProviderIdentifierState35", rawImport.OtherProviderIdentifierState35);

                    // set parameters[190]
                    parameters[190] = param;

                    // Create parameter for [OtherProviderIdentifierState36]
                    param = new SqlParameter("@OtherProviderIdentifierState36", rawImport.OtherProviderIdentifierState36);

                    // set parameters[191]
                    parameters[191] = param;

                    // Create parameter for [OtherProviderIdentifierState37]
                    param = new SqlParameter("@OtherProviderIdentifierState37", rawImport.OtherProviderIdentifierState37);

                    // set parameters[192]
                    parameters[192] = param;

                    // Create parameter for [OtherProviderIdentifierState38]
                    param = new SqlParameter("@OtherProviderIdentifierState38", rawImport.OtherProviderIdentifierState38);

                    // set parameters[193]
                    parameters[193] = param;

                    // Create parameter for [OtherProviderIdentifierState39]
                    param = new SqlParameter("@OtherProviderIdentifierState39", rawImport.OtherProviderIdentifierState39);

                    // set parameters[194]
                    parameters[194] = param;

                    // Create parameter for [OtherProviderIdentifierState4]
                    param = new SqlParameter("@OtherProviderIdentifierState4", rawImport.OtherProviderIdentifierState4);

                    // set parameters[195]
                    parameters[195] = param;

                    // Create parameter for [OtherProviderIdentifierState40]
                    param = new SqlParameter("@OtherProviderIdentifierState40", rawImport.OtherProviderIdentifierState40);

                    // set parameters[196]
                    parameters[196] = param;

                    // Create parameter for [OtherProviderIdentifierState41]
                    param = new SqlParameter("@OtherProviderIdentifierState41", rawImport.OtherProviderIdentifierState41);

                    // set parameters[197]
                    parameters[197] = param;

                    // Create parameter for [OtherProviderIdentifierState42]
                    param = new SqlParameter("@OtherProviderIdentifierState42", rawImport.OtherProviderIdentifierState42);

                    // set parameters[198]
                    parameters[198] = param;

                    // Create parameter for [OtherProviderIdentifierState43]
                    param = new SqlParameter("@OtherProviderIdentifierState43", rawImport.OtherProviderIdentifierState43);

                    // set parameters[199]
                    parameters[199] = param;

                    // Create parameter for [OtherProviderIdentifierState44]
                    param = new SqlParameter("@OtherProviderIdentifierState44", rawImport.OtherProviderIdentifierState44);

                    // set parameters[200]
                    parameters[200] = param;

                    // Create parameter for [OtherProviderIdentifierState45]
                    param = new SqlParameter("@OtherProviderIdentifierState45", rawImport.OtherProviderIdentifierState45);

                    // set parameters[201]
                    parameters[201] = param;

                    // Create parameter for [OtherProviderIdentifierState46]
                    param = new SqlParameter("@OtherProviderIdentifierState46", rawImport.OtherProviderIdentifierState46);

                    // set parameters[202]
                    parameters[202] = param;

                    // Create parameter for [OtherProviderIdentifierState47]
                    param = new SqlParameter("@OtherProviderIdentifierState47", rawImport.OtherProviderIdentifierState47);

                    // set parameters[203]
                    parameters[203] = param;

                    // Create parameter for [OtherProviderIdentifierState48]
                    param = new SqlParameter("@OtherProviderIdentifierState48", rawImport.OtherProviderIdentifierState48);

                    // set parameters[204]
                    parameters[204] = param;

                    // Create parameter for [OtherProviderIdentifierState49]
                    param = new SqlParameter("@OtherProviderIdentifierState49", rawImport.OtherProviderIdentifierState49);

                    // set parameters[205]
                    parameters[205] = param;

                    // Create parameter for [OtherProviderIdentifierState5]
                    param = new SqlParameter("@OtherProviderIdentifierState5", rawImport.OtherProviderIdentifierState5);

                    // set parameters[206]
                    parameters[206] = param;

                    // Create parameter for [OtherProviderIdentifierState50]
                    param = new SqlParameter("@OtherProviderIdentifierState50", rawImport.OtherProviderIdentifierState50);

                    // set parameters[207]
                    parameters[207] = param;

                    // Create parameter for [OtherProviderIdentifierState6]
                    param = new SqlParameter("@OtherProviderIdentifierState6", rawImport.OtherProviderIdentifierState6);

                    // set parameters[208]
                    parameters[208] = param;

                    // Create parameter for [OtherProviderIdentifierState7]
                    param = new SqlParameter("@OtherProviderIdentifierState7", rawImport.OtherProviderIdentifierState7);

                    // set parameters[209]
                    parameters[209] = param;

                    // Create parameter for [OtherProviderIdentifierState8]
                    param = new SqlParameter("@OtherProviderIdentifierState8", rawImport.OtherProviderIdentifierState8);

                    // set parameters[210]
                    parameters[210] = param;

                    // Create parameter for [OtherProviderIdentifierState9]
                    param = new SqlParameter("@OtherProviderIdentifierState9", rawImport.OtherProviderIdentifierState9);

                    // set parameters[211]
                    parameters[211] = param;

                    // Create parameter for [OtherProviderIdentifierTypeCode1]
                    param = new SqlParameter("@OtherProviderIdentifierTypeCode1", rawImport.OtherProviderIdentifierTypeCode1);

                    // set parameters[212]
                    parameters[212] = param;

                    // Create parameter for [OtherProviderIdentifierTypeCode10]
                    param = new SqlParameter("@OtherProviderIdentifierTypeCode10", rawImport.OtherProviderIdentifierTypeCode10);

                    // set parameters[213]
                    parameters[213] = param;

                    // Create parameter for [OtherProviderIdentifierTypeCode11]
                    param = new SqlParameter("@OtherProviderIdentifierTypeCode11", rawImport.OtherProviderIdentifierTypeCode11);

                    // set parameters[214]
                    parameters[214] = param;

                    // Create parameter for [OtherProviderIdentifierTypeCode12]
                    param = new SqlParameter("@OtherProviderIdentifierTypeCode12", rawImport.OtherProviderIdentifierTypeCode12);

                    // set parameters[215]
                    parameters[215] = param;

                    // Create parameter for [OtherProviderIdentifierTypeCode13]
                    param = new SqlParameter("@OtherProviderIdentifierTypeCode13", rawImport.OtherProviderIdentifierTypeCode13);

                    // set parameters[216]
                    parameters[216] = param;

                    // Create parameter for [OtherProviderIdentifierTypeCode14]
                    param = new SqlParameter("@OtherProviderIdentifierTypeCode14", rawImport.OtherProviderIdentifierTypeCode14);

                    // set parameters[217]
                    parameters[217] = param;

                    // Create parameter for [OtherProviderIdentifierTypeCode15]
                    param = new SqlParameter("@OtherProviderIdentifierTypeCode15", rawImport.OtherProviderIdentifierTypeCode15);

                    // set parameters[218]
                    parameters[218] = param;

                    // Create parameter for [OtherProviderIdentifierTypeCode16]
                    param = new SqlParameter("@OtherProviderIdentifierTypeCode16", rawImport.OtherProviderIdentifierTypeCode16);

                    // set parameters[219]
                    parameters[219] = param;

                    // Create parameter for [OtherProviderIdentifierTypeCode17]
                    param = new SqlParameter("@OtherProviderIdentifierTypeCode17", rawImport.OtherProviderIdentifierTypeCode17);

                    // set parameters[220]
                    parameters[220] = param;

                    // Create parameter for [OtherProviderIdentifierTypeCode18]
                    param = new SqlParameter("@OtherProviderIdentifierTypeCode18", rawImport.OtherProviderIdentifierTypeCode18);

                    // set parameters[221]
                    parameters[221] = param;

                    // Create parameter for [OtherProviderIdentifierTypeCode19]
                    param = new SqlParameter("@OtherProviderIdentifierTypeCode19", rawImport.OtherProviderIdentifierTypeCode19);

                    // set parameters[222]
                    parameters[222] = param;

                    // Create parameter for [OtherProviderIdentifierTypeCode2]
                    param = new SqlParameter("@OtherProviderIdentifierTypeCode2", rawImport.OtherProviderIdentifierTypeCode2);

                    // set parameters[223]
                    parameters[223] = param;

                    // Create parameter for [OtherProviderIdentifierTypeCode20]
                    param = new SqlParameter("@OtherProviderIdentifierTypeCode20", rawImport.OtherProviderIdentifierTypeCode20);

                    // set parameters[224]
                    parameters[224] = param;

                    // Create parameter for [OtherProviderIdentifierTypeCode21]
                    param = new SqlParameter("@OtherProviderIdentifierTypeCode21", rawImport.OtherProviderIdentifierTypeCode21);

                    // set parameters[225]
                    parameters[225] = param;

                    // Create parameter for [OtherProviderIdentifierTypeCode22]
                    param = new SqlParameter("@OtherProviderIdentifierTypeCode22", rawImport.OtherProviderIdentifierTypeCode22);

                    // set parameters[226]
                    parameters[226] = param;

                    // Create parameter for [OtherProviderIdentifierTypeCode23]
                    param = new SqlParameter("@OtherProviderIdentifierTypeCode23", rawImport.OtherProviderIdentifierTypeCode23);

                    // set parameters[227]
                    parameters[227] = param;

                    // Create parameter for [OtherProviderIdentifierTypeCode24]
                    param = new SqlParameter("@OtherProviderIdentifierTypeCode24", rawImport.OtherProviderIdentifierTypeCode24);

                    // set parameters[228]
                    parameters[228] = param;

                    // Create parameter for [OtherProviderIdentifierTypeCode25]
                    param = new SqlParameter("@OtherProviderIdentifierTypeCode25", rawImport.OtherProviderIdentifierTypeCode25);

                    // set parameters[229]
                    parameters[229] = param;

                    // Create parameter for [OtherProviderIdentifierTypeCode26]
                    param = new SqlParameter("@OtherProviderIdentifierTypeCode26", rawImport.OtherProviderIdentifierTypeCode26);

                    // set parameters[230]
                    parameters[230] = param;

                    // Create parameter for [OtherProviderIdentifierTypeCode27]
                    param = new SqlParameter("@OtherProviderIdentifierTypeCode27", rawImport.OtherProviderIdentifierTypeCode27);

                    // set parameters[231]
                    parameters[231] = param;

                    // Create parameter for [OtherProviderIdentifierTypeCode28]
                    param = new SqlParameter("@OtherProviderIdentifierTypeCode28", rawImport.OtherProviderIdentifierTypeCode28);

                    // set parameters[232]
                    parameters[232] = param;

                    // Create parameter for [OtherProviderIdentifierTypeCode29]
                    param = new SqlParameter("@OtherProviderIdentifierTypeCode29", rawImport.OtherProviderIdentifierTypeCode29);

                    // set parameters[233]
                    parameters[233] = param;

                    // Create parameter for [OtherProviderIdentifierTypeCode3]
                    param = new SqlParameter("@OtherProviderIdentifierTypeCode3", rawImport.OtherProviderIdentifierTypeCode3);

                    // set parameters[234]
                    parameters[234] = param;

                    // Create parameter for [OtherProviderIdentifierTypeCode30]
                    param = new SqlParameter("@OtherProviderIdentifierTypeCode30", rawImport.OtherProviderIdentifierTypeCode30);

                    // set parameters[235]
                    parameters[235] = param;

                    // Create parameter for [OtherProviderIdentifierTypeCode31]
                    param = new SqlParameter("@OtherProviderIdentifierTypeCode31", rawImport.OtherProviderIdentifierTypeCode31);

                    // set parameters[236]
                    parameters[236] = param;

                    // Create parameter for [OtherProviderIdentifierTypeCode32]
                    param = new SqlParameter("@OtherProviderIdentifierTypeCode32", rawImport.OtherProviderIdentifierTypeCode32);

                    // set parameters[237]
                    parameters[237] = param;

                    // Create parameter for [OtherProviderIdentifierTypeCode33]
                    param = new SqlParameter("@OtherProviderIdentifierTypeCode33", rawImport.OtherProviderIdentifierTypeCode33);

                    // set parameters[238]
                    parameters[238] = param;

                    // Create parameter for [OtherProviderIdentifierTypeCode34]
                    param = new SqlParameter("@OtherProviderIdentifierTypeCode34", rawImport.OtherProviderIdentifierTypeCode34);

                    // set parameters[239]
                    parameters[239] = param;

                    // Create parameter for [OtherProviderIdentifierTypeCode35]
                    param = new SqlParameter("@OtherProviderIdentifierTypeCode35", rawImport.OtherProviderIdentifierTypeCode35);

                    // set parameters[240]
                    parameters[240] = param;

                    // Create parameter for [OtherProviderIdentifierTypeCode36]
                    param = new SqlParameter("@OtherProviderIdentifierTypeCode36", rawImport.OtherProviderIdentifierTypeCode36);

                    // set parameters[241]
                    parameters[241] = param;

                    // Create parameter for [OtherProviderIdentifierTypeCode37]
                    param = new SqlParameter("@OtherProviderIdentifierTypeCode37", rawImport.OtherProviderIdentifierTypeCode37);

                    // set parameters[242]
                    parameters[242] = param;

                    // Create parameter for [OtherProviderIdentifierTypeCode38]
                    param = new SqlParameter("@OtherProviderIdentifierTypeCode38", rawImport.OtherProviderIdentifierTypeCode38);

                    // set parameters[243]
                    parameters[243] = param;

                    // Create parameter for [OtherProviderIdentifierTypeCode39]
                    param = new SqlParameter("@OtherProviderIdentifierTypeCode39", rawImport.OtherProviderIdentifierTypeCode39);

                    // set parameters[244]
                    parameters[244] = param;

                    // Create parameter for [OtherProviderIdentifierTypeCode4]
                    param = new SqlParameter("@OtherProviderIdentifierTypeCode4", rawImport.OtherProviderIdentifierTypeCode4);

                    // set parameters[245]
                    parameters[245] = param;

                    // Create parameter for [OtherProviderIdentifierTypeCode40]
                    param = new SqlParameter("@OtherProviderIdentifierTypeCode40", rawImport.OtherProviderIdentifierTypeCode40);

                    // set parameters[246]
                    parameters[246] = param;

                    // Create parameter for [OtherProviderIdentifierTypeCode41]
                    param = new SqlParameter("@OtherProviderIdentifierTypeCode41", rawImport.OtherProviderIdentifierTypeCode41);

                    // set parameters[247]
                    parameters[247] = param;

                    // Create parameter for [OtherProviderIdentifierTypeCode42]
                    param = new SqlParameter("@OtherProviderIdentifierTypeCode42", rawImport.OtherProviderIdentifierTypeCode42);

                    // set parameters[248]
                    parameters[248] = param;

                    // Create parameter for [OtherProviderIdentifierTypeCode43]
                    param = new SqlParameter("@OtherProviderIdentifierTypeCode43", rawImport.OtherProviderIdentifierTypeCode43);

                    // set parameters[249]
                    parameters[249] = param;

                    // Create parameter for [OtherProviderIdentifierTypeCode44]
                    param = new SqlParameter("@OtherProviderIdentifierTypeCode44", rawImport.OtherProviderIdentifierTypeCode44);

                    // set parameters[250]
                    parameters[250] = param;

                    // Create parameter for [OtherProviderIdentifierTypeCode45]
                    param = new SqlParameter("@OtherProviderIdentifierTypeCode45", rawImport.OtherProviderIdentifierTypeCode45);

                    // set parameters[251]
                    parameters[251] = param;

                    // Create parameter for [OtherProviderIdentifierTypeCode46]
                    param = new SqlParameter("@OtherProviderIdentifierTypeCode46", rawImport.OtherProviderIdentifierTypeCode46);

                    // set parameters[252]
                    parameters[252] = param;

                    // Create parameter for [OtherProviderIdentifierTypeCode47]
                    param = new SqlParameter("@OtherProviderIdentifierTypeCode47", rawImport.OtherProviderIdentifierTypeCode47);

                    // set parameters[253]
                    parameters[253] = param;

                    // Create parameter for [OtherProviderIdentifierTypeCode48]
                    param = new SqlParameter("@OtherProviderIdentifierTypeCode48", rawImport.OtherProviderIdentifierTypeCode48);

                    // set parameters[254]
                    parameters[254] = param;

                    // Create parameter for [OtherProviderIdentifierTypeCode49]
                    param = new SqlParameter("@OtherProviderIdentifierTypeCode49", rawImport.OtherProviderIdentifierTypeCode49);

                    // set parameters[255]
                    parameters[255] = param;

                    // Create parameter for [OtherProviderIdentifierTypeCode5]
                    param = new SqlParameter("@OtherProviderIdentifierTypeCode5", rawImport.OtherProviderIdentifierTypeCode5);

                    // set parameters[256]
                    parameters[256] = param;

                    // Create parameter for [OtherProviderIdentifierTypeCode50]
                    param = new SqlParameter("@OtherProviderIdentifierTypeCode50", rawImport.OtherProviderIdentifierTypeCode50);

                    // set parameters[257]
                    parameters[257] = param;

                    // Create parameter for [OtherProviderIdentifierTypeCode6]
                    param = new SqlParameter("@OtherProviderIdentifierTypeCode6", rawImport.OtherProviderIdentifierTypeCode6);

                    // set parameters[258]
                    parameters[258] = param;

                    // Create parameter for [OtherProviderIdentifierTypeCode7]
                    param = new SqlParameter("@OtherProviderIdentifierTypeCode7", rawImport.OtherProviderIdentifierTypeCode7);

                    // set parameters[259]
                    parameters[259] = param;

                    // Create parameter for [OtherProviderIdentifierTypeCode8]
                    param = new SqlParameter("@OtherProviderIdentifierTypeCode8", rawImport.OtherProviderIdentifierTypeCode8);

                    // set parameters[260]
                    parameters[260] = param;

                    // Create parameter for [OtherProviderIdentifierTypeCode9]
                    param = new SqlParameter("@OtherProviderIdentifierTypeCode9", rawImport.OtherProviderIdentifierTypeCode9);

                    // set parameters[261]
                    parameters[261] = param;

                    // Create parameter for [ParentOrganizationLBN]
                    param = new SqlParameter("@ParentOrganizationLBN", rawImport.ParentOrganizationLBN);

                    // set parameters[262]
                    parameters[262] = param;

                    // Create parameter for [ParentOrganizationTIN]
                    param = new SqlParameter("@ParentOrganizationTIN", rawImport.ParentOrganizationTIN);

                    // set parameters[263]
                    parameters[263] = param;

                    // Create parameter for [ProviderBusinessMailingAddressCityName]
                    param = new SqlParameter("@ProviderBusinessMailingAddressCityName", rawImport.ProviderBusinessMailingAddressCityName);

                    // set parameters[264]
                    parameters[264] = param;

                    // Create parameter for [ProviderBusinessMailingAddressCountryCodeIfoutsideUS]
                    param = new SqlParameter("@ProviderBusinessMailingAddressCountryCodeIfoutsideUS", rawImport.ProviderBusinessMailingAddressCountryCodeIfoutsideUS);

                    // set parameters[265]
                    parameters[265] = param;

                    // Create parameter for [ProviderBusinessMailingAddressFaxNumber]
                    param = new SqlParameter("@ProviderBusinessMailingAddressFaxNumber", rawImport.ProviderBusinessMailingAddressFaxNumber);

                    // set parameters[266]
                    parameters[266] = param;

                    // Create parameter for [ProviderBusinessMailingAddressPostalCode]
                    param = new SqlParameter("@ProviderBusinessMailingAddressPostalCode", rawImport.ProviderBusinessMailingAddressPostalCode);

                    // set parameters[267]
                    parameters[267] = param;

                    // Create parameter for [ProviderBusinessMailingAddressStateName]
                    param = new SqlParameter("@ProviderBusinessMailingAddressStateName", rawImport.ProviderBusinessMailingAddressStateName);

                    // set parameters[268]
                    parameters[268] = param;

                    // Create parameter for [ProviderBusinessMailingAddressTelephoneNumber]
                    param = new SqlParameter("@ProviderBusinessMailingAddressTelephoneNumber", rawImport.ProviderBusinessMailingAddressTelephoneNumber);

                    // set parameters[269]
                    parameters[269] = param;

                    // Create parameter for [ProviderBusinessPracticeLocationAddressCityName]
                    param = new SqlParameter("@ProviderBusinessPracticeLocationAddressCityName", rawImport.ProviderBusinessPracticeLocationAddressCityName);

                    // set parameters[270]
                    parameters[270] = param;

                    // Create parameter for [ProviderBusinessPracticeLocationAddressCountryCodeIfoutsideUS]
                    param = new SqlParameter("@ProviderBusinessPracticeLocationAddressCountryCodeIfoutsideUS", rawImport.ProviderBusinessPracticeLocationAddressCountryCodeIfoutsideUS);

                    // set parameters[271]
                    parameters[271] = param;

                    // Create parameter for [ProviderBusinessPracticeLocationAddressFaxNumber]
                    param = new SqlParameter("@ProviderBusinessPracticeLocationAddressFaxNumber", rawImport.ProviderBusinessPracticeLocationAddressFaxNumber);

                    // set parameters[272]
                    parameters[272] = param;

                    // Create parameter for [ProviderBusinessPracticeLocationAddressPostalCode]
                    param = new SqlParameter("@ProviderBusinessPracticeLocationAddressPostalCode", rawImport.ProviderBusinessPracticeLocationAddressPostalCode);

                    // set parameters[273]
                    parameters[273] = param;

                    // Create parameter for [ProviderBusinessPracticeLocationAddressStateName]
                    param = new SqlParameter("@ProviderBusinessPracticeLocationAddressStateName", rawImport.ProviderBusinessPracticeLocationAddressStateName);

                    // set parameters[274]
                    parameters[274] = param;

                    // Create parameter for [ProviderBusinessPracticeLocationAddressTelephoneNumber]
                    param = new SqlParameter("@ProviderBusinessPracticeLocationAddressTelephoneNumber", rawImport.ProviderBusinessPracticeLocationAddressTelephoneNumber);

                    // set parameters[275]
                    parameters[275] = param;

                    // Create parameter for [ProviderCredentialText]
                    param = new SqlParameter("@ProviderCredentialText", rawImport.ProviderCredentialText);

                    // set parameters[276]
                    parameters[276] = param;

                    // Create parameter for [ProviderEnumerationDate]
                    param = new SqlParameter("@ProviderEnumerationDate", rawImport.ProviderEnumerationDate);

                    // set parameters[277]
                    parameters[277] = param;

                    // Create parameter for [ProviderFirstLineBusinessMailingAddress]
                    param = new SqlParameter("@ProviderFirstLineBusinessMailingAddress", rawImport.ProviderFirstLineBusinessMailingAddress);

                    // set parameters[278]
                    parameters[278] = param;

                    // Create parameter for [ProviderFirstLineBusinessPracticeLocationAddress]
                    param = new SqlParameter("@ProviderFirstLineBusinessPracticeLocationAddress", rawImport.ProviderFirstLineBusinessPracticeLocationAddress);

                    // set parameters[279]
                    parameters[279] = param;

                    // Create parameter for [ProviderFirstName]
                    param = new SqlParameter("@ProviderFirstName", rawImport.ProviderFirstName);

                    // set parameters[280]
                    parameters[280] = param;

                    // Create parameter for [ProviderGenderCode]
                    param = new SqlParameter("@ProviderGenderCode", rawImport.ProviderGenderCode);

                    // set parameters[281]
                    parameters[281] = param;

                    // Create parameter for [ProviderLastNameLegalName]
                    param = new SqlParameter("@ProviderLastNameLegalName", rawImport.ProviderLastNameLegalName);

                    // set parameters[282]
                    parameters[282] = param;

                    // Create parameter for [ProviderLicenseNumber1]
                    param = new SqlParameter("@ProviderLicenseNumber1", rawImport.ProviderLicenseNumber1);

                    // set parameters[283]
                    parameters[283] = param;

                    // Create parameter for [ProviderLicenseNumber10]
                    param = new SqlParameter("@ProviderLicenseNumber10", rawImport.ProviderLicenseNumber10);

                    // set parameters[284]
                    parameters[284] = param;

                    // Create parameter for [ProviderLicenseNumber11]
                    param = new SqlParameter("@ProviderLicenseNumber11", rawImport.ProviderLicenseNumber11);

                    // set parameters[285]
                    parameters[285] = param;

                    // Create parameter for [ProviderLicenseNumber12]
                    param = new SqlParameter("@ProviderLicenseNumber12", rawImport.ProviderLicenseNumber12);

                    // set parameters[286]
                    parameters[286] = param;

                    // Create parameter for [ProviderLicenseNumber13]
                    param = new SqlParameter("@ProviderLicenseNumber13", rawImport.ProviderLicenseNumber13);

                    // set parameters[287]
                    parameters[287] = param;

                    // Create parameter for [ProviderLicenseNumber14]
                    param = new SqlParameter("@ProviderLicenseNumber14", rawImport.ProviderLicenseNumber14);

                    // set parameters[288]
                    parameters[288] = param;

                    // Create parameter for [ProviderLicenseNumber15]
                    param = new SqlParameter("@ProviderLicenseNumber15", rawImport.ProviderLicenseNumber15);

                    // set parameters[289]
                    parameters[289] = param;

                    // Create parameter for [ProviderLicenseNumber2]
                    param = new SqlParameter("@ProviderLicenseNumber2", rawImport.ProviderLicenseNumber2);

                    // set parameters[290]
                    parameters[290] = param;

                    // Create parameter for [ProviderLicenseNumber3]
                    param = new SqlParameter("@ProviderLicenseNumber3", rawImport.ProviderLicenseNumber3);

                    // set parameters[291]
                    parameters[291] = param;

                    // Create parameter for [ProviderLicenseNumber4]
                    param = new SqlParameter("@ProviderLicenseNumber4", rawImport.ProviderLicenseNumber4);

                    // set parameters[292]
                    parameters[292] = param;

                    // Create parameter for [ProviderLicenseNumber5]
                    param = new SqlParameter("@ProviderLicenseNumber5", rawImport.ProviderLicenseNumber5);

                    // set parameters[293]
                    parameters[293] = param;

                    // Create parameter for [ProviderLicenseNumber6]
                    param = new SqlParameter("@ProviderLicenseNumber6", rawImport.ProviderLicenseNumber6);

                    // set parameters[294]
                    parameters[294] = param;

                    // Create parameter for [ProviderLicenseNumber7]
                    param = new SqlParameter("@ProviderLicenseNumber7", rawImport.ProviderLicenseNumber7);

                    // set parameters[295]
                    parameters[295] = param;

                    // Create parameter for [ProviderLicenseNumber8]
                    param = new SqlParameter("@ProviderLicenseNumber8", rawImport.ProviderLicenseNumber8);

                    // set parameters[296]
                    parameters[296] = param;

                    // Create parameter for [ProviderLicenseNumber9]
                    param = new SqlParameter("@ProviderLicenseNumber9", rawImport.ProviderLicenseNumber9);

                    // set parameters[297]
                    parameters[297] = param;

                    // Create parameter for [ProviderLicenseNumberStateCode1]
                    param = new SqlParameter("@ProviderLicenseNumberStateCode1", rawImport.ProviderLicenseNumberStateCode1);

                    // set parameters[298]
                    parameters[298] = param;

                    // Create parameter for [ProviderLicenseNumberStateCode10]
                    param = new SqlParameter("@ProviderLicenseNumberStateCode10", rawImport.ProviderLicenseNumberStateCode10);

                    // set parameters[299]
                    parameters[299] = param;

                    // Create parameter for [ProviderLicenseNumberStateCode11]
                    param = new SqlParameter("@ProviderLicenseNumberStateCode11", rawImport.ProviderLicenseNumberStateCode11);

                    // set parameters[300]
                    parameters[300] = param;

                    // Create parameter for [ProviderLicenseNumberStateCode12]
                    param = new SqlParameter("@ProviderLicenseNumberStateCode12", rawImport.ProviderLicenseNumberStateCode12);

                    // set parameters[301]
                    parameters[301] = param;

                    // Create parameter for [ProviderLicenseNumberStateCode13]
                    param = new SqlParameter("@ProviderLicenseNumberStateCode13", rawImport.ProviderLicenseNumberStateCode13);

                    // set parameters[302]
                    parameters[302] = param;

                    // Create parameter for [ProviderLicenseNumberStateCode14]
                    param = new SqlParameter("@ProviderLicenseNumberStateCode14", rawImport.ProviderLicenseNumberStateCode14);

                    // set parameters[303]
                    parameters[303] = param;

                    // Create parameter for [ProviderLicenseNumberStateCode15]
                    param = new SqlParameter("@ProviderLicenseNumberStateCode15", rawImport.ProviderLicenseNumberStateCode15);

                    // set parameters[304]
                    parameters[304] = param;

                    // Create parameter for [ProviderLicenseNumberStateCode2]
                    param = new SqlParameter("@ProviderLicenseNumberStateCode2", rawImport.ProviderLicenseNumberStateCode2);

                    // set parameters[305]
                    parameters[305] = param;

                    // Create parameter for [ProviderLicenseNumberStateCode3]
                    param = new SqlParameter("@ProviderLicenseNumberStateCode3", rawImport.ProviderLicenseNumberStateCode3);

                    // set parameters[306]
                    parameters[306] = param;

                    // Create parameter for [ProviderLicenseNumberStateCode4]
                    param = new SqlParameter("@ProviderLicenseNumberStateCode4", rawImport.ProviderLicenseNumberStateCode4);

                    // set parameters[307]
                    parameters[307] = param;

                    // Create parameter for [ProviderLicenseNumberStateCode5]
                    param = new SqlParameter("@ProviderLicenseNumberStateCode5", rawImport.ProviderLicenseNumberStateCode5);

                    // set parameters[308]
                    parameters[308] = param;

                    // Create parameter for [ProviderLicenseNumberStateCode6]
                    param = new SqlParameter("@ProviderLicenseNumberStateCode6", rawImport.ProviderLicenseNumberStateCode6);

                    // set parameters[309]
                    parameters[309] = param;

                    // Create parameter for [ProviderLicenseNumberStateCode7]
                    param = new SqlParameter("@ProviderLicenseNumberStateCode7", rawImport.ProviderLicenseNumberStateCode7);

                    // set parameters[310]
                    parameters[310] = param;

                    // Create parameter for [ProviderLicenseNumberStateCode8]
                    param = new SqlParameter("@ProviderLicenseNumberStateCode8", rawImport.ProviderLicenseNumberStateCode8);

                    // set parameters[311]
                    parameters[311] = param;

                    // Create parameter for [ProviderLicenseNumberStateCode9]
                    param = new SqlParameter("@ProviderLicenseNumberStateCode9", rawImport.ProviderLicenseNumberStateCode9);

                    // set parameters[312]
                    parameters[312] = param;

                    // Create parameter for [ProviderMiddleName]
                    param = new SqlParameter("@ProviderMiddleName", rawImport.ProviderMiddleName);

                    // set parameters[313]
                    parameters[313] = param;

                    // Create parameter for [ProviderNamePrefixText]
                    param = new SqlParameter("@ProviderNamePrefixText", rawImport.ProviderNamePrefixText);

                    // set parameters[314]
                    parameters[314] = param;

                    // Create parameter for [ProviderNameSuffixText]
                    param = new SqlParameter("@ProviderNameSuffixText", rawImport.ProviderNameSuffixText);

                    // set parameters[315]
                    parameters[315] = param;

                    // Create parameter for [ProviderOrganizationNameLegalBusinessName]
                    param = new SqlParameter("@ProviderOrganizationNameLegalBusinessName", rawImport.ProviderOrganizationNameLegalBusinessName);

                    // set parameters[316]
                    parameters[316] = param;

                    // Create parameter for [ProviderOtherCredentialText]
                    param = new SqlParameter("@ProviderOtherCredentialText", rawImport.ProviderOtherCredentialText);

                    // set parameters[317]
                    parameters[317] = param;

                    // Create parameter for [ProviderOtherFirstName]
                    param = new SqlParameter("@ProviderOtherFirstName", rawImport.ProviderOtherFirstName);

                    // set parameters[318]
                    parameters[318] = param;

                    // Create parameter for [ProviderOtherLastName]
                    param = new SqlParameter("@ProviderOtherLastName", rawImport.ProviderOtherLastName);

                    // set parameters[319]
                    parameters[319] = param;

                    // Create parameter for [ProviderOtherLastNameTypeCode]
                    param = new SqlParameter("@ProviderOtherLastNameTypeCode", rawImport.ProviderOtherLastNameTypeCode);

                    // set parameters[320]
                    parameters[320] = param;

                    // Create parameter for [ProviderOtherMiddleName]
                    param = new SqlParameter("@ProviderOtherMiddleName", rawImport.ProviderOtherMiddleName);

                    // set parameters[321]
                    parameters[321] = param;

                    // Create parameter for [ProviderOtherNamePrefixText]
                    param = new SqlParameter("@ProviderOtherNamePrefixText", rawImport.ProviderOtherNamePrefixText);

                    // set parameters[322]
                    parameters[322] = param;

                    // Create parameter for [ProviderOtherNameSuffixText]
                    param = new SqlParameter("@ProviderOtherNameSuffixText", rawImport.ProviderOtherNameSuffixText);

                    // set parameters[323]
                    parameters[323] = param;

                    // Create parameter for [ProviderOtherOrganizationName]
                    param = new SqlParameter("@ProviderOtherOrganizationName", rawImport.ProviderOtherOrganizationName);

                    // set parameters[324]
                    parameters[324] = param;

                    // Create parameter for [ProviderOtherOrganizationNameTypeCode]
                    param = new SqlParameter("@ProviderOtherOrganizationNameTypeCode", rawImport.ProviderOtherOrganizationNameTypeCode);

                    // set parameters[325]
                    parameters[325] = param;

                    // Create parameter for [ProviderSecondLineBusinessMailingAddress]
                    param = new SqlParameter("@ProviderSecondLineBusinessMailingAddress", rawImport.ProviderSecondLineBusinessMailingAddress);

                    // set parameters[326]
                    parameters[326] = param;

                    // Create parameter for [ProviderSecondLineBusinessPracticeLocationAddress]
                    param = new SqlParameter("@ProviderSecondLineBusinessPracticeLocationAddress", rawImport.ProviderSecondLineBusinessPracticeLocationAddress);

                    // set parameters[327]
                    parameters[327] = param;

                    // Create parameter for [ReplacementNPI]
                    param = new SqlParameter("@ReplacementNPI", rawImport.ReplacementNPI);

                    // set parameters[328]
                    parameters[328] = param;

                    // Create parameter for [Id]
                    param = new SqlParameter("@Id", rawImport.Id);
                    parameters[329] = param;
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
