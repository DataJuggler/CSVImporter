

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
                int authorizedOfficialCredentialTextfield = 0;
                int authorizedOfficialFirstNamefield = 1;
                int authorizedOfficialLastNamefield = 2;
                int authorizedOfficialMiddleNamefield = 3;
                int authorizedOfficialNamePrefixTextfield = 4;
                int authorizedOfficialNameSuffixTextfield = 5;
                int authorizedOfficialTelephoneNumberfield = 6;
                int authorizedOfficialTitleorPositionfield = 7;
                int employerIdentificationNumberEINfield = 8;
                int entityTypeCodefield = 9;
                int healthcareProviderPrimaryTaxonomySwitch1field = 10;
                int healthcareProviderPrimaryTaxonomySwitch10field = 11;
                int healthcareProviderPrimaryTaxonomySwitch11field = 12;
                int healthcareProviderPrimaryTaxonomySwitch12field = 13;
                int healthcareProviderPrimaryTaxonomySwitch13field = 14;
                int healthcareProviderPrimaryTaxonomySwitch14field = 15;
                int healthcareProviderPrimaryTaxonomySwitch15field = 16;
                int healthcareProviderPrimaryTaxonomySwitch2field = 17;
                int healthcareProviderPrimaryTaxonomySwitch3field = 18;
                int healthcareProviderPrimaryTaxonomySwitch4field = 19;
                int healthcareProviderPrimaryTaxonomySwitch5field = 20;
                int healthcareProviderPrimaryTaxonomySwitch6field = 21;
                int healthcareProviderPrimaryTaxonomySwitch7field = 22;
                int healthcareProviderPrimaryTaxonomySwitch8field = 23;
                int healthcareProviderPrimaryTaxonomySwitch9field = 24;
                int healthcareProviderTaxonomyCode1field = 25;
                int healthcareProviderTaxonomyCode10field = 26;
                int healthcareProviderTaxonomyCode11field = 27;
                int healthcareProviderTaxonomyCode12field = 28;
                int healthcareProviderTaxonomyCode13field = 29;
                int healthcareProviderTaxonomyCode14field = 30;
                int healthcareProviderTaxonomyCode15field = 31;
                int healthcareProviderTaxonomyCode2field = 32;
                int healthcareProviderTaxonomyCode3field = 33;
                int healthcareProviderTaxonomyCode4field = 34;
                int healthcareProviderTaxonomyCode5field = 35;
                int healthcareProviderTaxonomyCode6field = 36;
                int healthcareProviderTaxonomyCode7field = 37;
                int healthcareProviderTaxonomyCode8field = 38;
                int healthcareProviderTaxonomyCode9field = 39;
                int healthcareProviderTaxonomyGroup1field = 40;
                int healthcareProviderTaxonomyGroup10field = 41;
                int healthcareProviderTaxonomyGroup11field = 42;
                int healthcareProviderTaxonomyGroup12field = 43;
                int healthcareProviderTaxonomyGroup13field = 44;
                int healthcareProviderTaxonomyGroup14field = 45;
                int healthcareProviderTaxonomyGroup15field = 46;
                int healthcareProviderTaxonomyGroup2field = 47;
                int healthcareProviderTaxonomyGroup3field = 48;
                int healthcareProviderTaxonomyGroup4field = 49;
                int healthcareProviderTaxonomyGroup5field = 50;
                int healthcareProviderTaxonomyGroup6field = 51;
                int healthcareProviderTaxonomyGroup7field = 52;
                int healthcareProviderTaxonomyGroup8field = 53;
                int healthcareProviderTaxonomyGroup9field = 54;
                int idfield = 55;
                int isOrganizationSubpartfield = 56;
                int isSoleProprietorfield = 57;
                int lastUpdateDatefield = 58;
                int nPIfield = 59;
                int nPIDeactivationDatefield = 60;
                int nPIDeactivationReasonCodefield = 61;
                int nPIReactivationDatefield = 62;
                int otherProviderIdentifier1field = 63;
                int otherProviderIdentifier10field = 64;
                int otherProviderIdentifier11field = 65;
                int otherProviderIdentifier12field = 66;
                int otherProviderIdentifier13field = 67;
                int otherProviderIdentifier14field = 68;
                int otherProviderIdentifier15field = 69;
                int otherProviderIdentifier16field = 70;
                int otherProviderIdentifier17field = 71;
                int otherProviderIdentifier18field = 72;
                int otherProviderIdentifier19field = 73;
                int otherProviderIdentifier2field = 74;
                int otherProviderIdentifier20field = 75;
                int otherProviderIdentifier21field = 76;
                int otherProviderIdentifier22field = 77;
                int otherProviderIdentifier23field = 78;
                int otherProviderIdentifier24field = 79;
                int otherProviderIdentifier25field = 80;
                int otherProviderIdentifier26field = 81;
                int otherProviderIdentifier27field = 82;
                int otherProviderIdentifier28field = 83;
                int otherProviderIdentifier29field = 84;
                int otherProviderIdentifier3field = 85;
                int otherProviderIdentifier30field = 86;
                int otherProviderIdentifier31field = 87;
                int otherProviderIdentifier32field = 88;
                int otherProviderIdentifier33field = 89;
                int otherProviderIdentifier34field = 90;
                int otherProviderIdentifier35field = 91;
                int otherProviderIdentifier36field = 92;
                int otherProviderIdentifier37field = 93;
                int otherProviderIdentifier38field = 94;
                int otherProviderIdentifier39field = 95;
                int otherProviderIdentifier4field = 96;
                int otherProviderIdentifier40field = 97;
                int otherProviderIdentifier41field = 98;
                int otherProviderIdentifier42field = 99;
                int otherProviderIdentifier43field = 100;
                int otherProviderIdentifier44field = 101;
                int otherProviderIdentifier45field = 102;
                int otherProviderIdentifier46field = 103;
                int otherProviderIdentifier47field = 104;
                int otherProviderIdentifier48field = 105;
                int otherProviderIdentifier49field = 106;
                int otherProviderIdentifier5field = 107;
                int otherProviderIdentifier50field = 108;
                int otherProviderIdentifier6field = 109;
                int otherProviderIdentifier7field = 110;
                int otherProviderIdentifier8field = 111;
                int otherProviderIdentifier9field = 112;
                int otherProviderIdentifierIssuer1field = 113;
                int otherProviderIdentifierIssuer10field = 114;
                int otherProviderIdentifierIssuer11field = 115;
                int otherProviderIdentifierIssuer12field = 116;
                int otherProviderIdentifierIssuer13field = 117;
                int otherProviderIdentifierIssuer14field = 118;
                int otherProviderIdentifierIssuer15field = 119;
                int otherProviderIdentifierIssuer16field = 120;
                int otherProviderIdentifierIssuer17field = 121;
                int otherProviderIdentifierIssuer18field = 122;
                int otherProviderIdentifierIssuer19field = 123;
                int otherProviderIdentifierIssuer2field = 124;
                int otherProviderIdentifierIssuer20field = 125;
                int otherProviderIdentifierIssuer21field = 126;
                int otherProviderIdentifierIssuer22field = 127;
                int otherProviderIdentifierIssuer23field = 128;
                int otherProviderIdentifierIssuer24field = 129;
                int otherProviderIdentifierIssuer25field = 130;
                int otherProviderIdentifierIssuer26field = 131;
                int otherProviderIdentifierIssuer27field = 132;
                int otherProviderIdentifierIssuer28field = 133;
                int otherProviderIdentifierIssuer29field = 134;
                int otherProviderIdentifierIssuer3field = 135;
                int otherProviderIdentifierIssuer30field = 136;
                int otherProviderIdentifierIssuer31field = 137;
                int otherProviderIdentifierIssuer32field = 138;
                int otherProviderIdentifierIssuer33field = 139;
                int otherProviderIdentifierIssuer34field = 140;
                int otherProviderIdentifierIssuer35field = 141;
                int otherProviderIdentifierIssuer36field = 142;
                int otherProviderIdentifierIssuer37field = 143;
                int otherProviderIdentifierIssuer38field = 144;
                int otherProviderIdentifierIssuer39field = 145;
                int otherProviderIdentifierIssuer4field = 146;
                int otherProviderIdentifierIssuer40field = 147;
                int otherProviderIdentifierIssuer41field = 148;
                int otherProviderIdentifierIssuer42field = 149;
                int otherProviderIdentifierIssuer43field = 150;
                int otherProviderIdentifierIssuer44field = 151;
                int otherProviderIdentifierIssuer45field = 152;
                int otherProviderIdentifierIssuer46field = 153;
                int otherProviderIdentifierIssuer47field = 154;
                int otherProviderIdentifierIssuer48field = 155;
                int otherProviderIdentifierIssuer49field = 156;
                int otherProviderIdentifierIssuer5field = 157;
                int otherProviderIdentifierIssuer50field = 158;
                int otherProviderIdentifierIssuer6field = 159;
                int otherProviderIdentifierIssuer7field = 160;
                int otherProviderIdentifierIssuer8field = 161;
                int otherProviderIdentifierIssuer9field = 162;
                int otherProviderIdentifierState1field = 163;
                int otherProviderIdentifierState10field = 164;
                int otherProviderIdentifierState11field = 165;
                int otherProviderIdentifierState12field = 166;
                int otherProviderIdentifierState13field = 167;
                int otherProviderIdentifierState14field = 168;
                int otherProviderIdentifierState15field = 169;
                int otherProviderIdentifierState16field = 170;
                int otherProviderIdentifierState17field = 171;
                int otherProviderIdentifierState18field = 172;
                int otherProviderIdentifierState19field = 173;
                int otherProviderIdentifierState2field = 174;
                int otherProviderIdentifierState20field = 175;
                int otherProviderIdentifierState21field = 176;
                int otherProviderIdentifierState22field = 177;
                int otherProviderIdentifierState23field = 178;
                int otherProviderIdentifierState24field = 179;
                int otherProviderIdentifierState25field = 180;
                int otherProviderIdentifierState26field = 181;
                int otherProviderIdentifierState27field = 182;
                int otherProviderIdentifierState28field = 183;
                int otherProviderIdentifierState29field = 184;
                int otherProviderIdentifierState3field = 185;
                int otherProviderIdentifierState30field = 186;
                int otherProviderIdentifierState31field = 187;
                int otherProviderIdentifierState32field = 188;
                int otherProviderIdentifierState33field = 189;
                int otherProviderIdentifierState34field = 190;
                int otherProviderIdentifierState35field = 191;
                int otherProviderIdentifierState36field = 192;
                int otherProviderIdentifierState37field = 193;
                int otherProviderIdentifierState38field = 194;
                int otherProviderIdentifierState39field = 195;
                int otherProviderIdentifierState4field = 196;
                int otherProviderIdentifierState40field = 197;
                int otherProviderIdentifierState41field = 198;
                int otherProviderIdentifierState42field = 199;
                int otherProviderIdentifierState43field = 200;
                int otherProviderIdentifierState44field = 201;
                int otherProviderIdentifierState45field = 202;
                int otherProviderIdentifierState46field = 203;
                int otherProviderIdentifierState47field = 204;
                int otherProviderIdentifierState48field = 205;
                int otherProviderIdentifierState49field = 206;
                int otherProviderIdentifierState5field = 207;
                int otherProviderIdentifierState50field = 208;
                int otherProviderIdentifierState6field = 209;
                int otherProviderIdentifierState7field = 210;
                int otherProviderIdentifierState8field = 211;
                int otherProviderIdentifierState9field = 212;
                int otherProviderIdentifierTypeCode1field = 213;
                int otherProviderIdentifierTypeCode10field = 214;
                int otherProviderIdentifierTypeCode11field = 215;
                int otherProviderIdentifierTypeCode12field = 216;
                int otherProviderIdentifierTypeCode13field = 217;
                int otherProviderIdentifierTypeCode14field = 218;
                int otherProviderIdentifierTypeCode15field = 219;
                int otherProviderIdentifierTypeCode16field = 220;
                int otherProviderIdentifierTypeCode17field = 221;
                int otherProviderIdentifierTypeCode18field = 222;
                int otherProviderIdentifierTypeCode19field = 223;
                int otherProviderIdentifierTypeCode2field = 224;
                int otherProviderIdentifierTypeCode20field = 225;
                int otherProviderIdentifierTypeCode21field = 226;
                int otherProviderIdentifierTypeCode22field = 227;
                int otherProviderIdentifierTypeCode23field = 228;
                int otherProviderIdentifierTypeCode24field = 229;
                int otherProviderIdentifierTypeCode25field = 230;
                int otherProviderIdentifierTypeCode26field = 231;
                int otherProviderIdentifierTypeCode27field = 232;
                int otherProviderIdentifierTypeCode28field = 233;
                int otherProviderIdentifierTypeCode29field = 234;
                int otherProviderIdentifierTypeCode3field = 235;
                int otherProviderIdentifierTypeCode30field = 236;
                int otherProviderIdentifierTypeCode31field = 237;
                int otherProviderIdentifierTypeCode32field = 238;
                int otherProviderIdentifierTypeCode33field = 239;
                int otherProviderIdentifierTypeCode34field = 240;
                int otherProviderIdentifierTypeCode35field = 241;
                int otherProviderIdentifierTypeCode36field = 242;
                int otherProviderIdentifierTypeCode37field = 243;
                int otherProviderIdentifierTypeCode38field = 244;
                int otherProviderIdentifierTypeCode39field = 245;
                int otherProviderIdentifierTypeCode4field = 246;
                int otherProviderIdentifierTypeCode40field = 247;
                int otherProviderIdentifierTypeCode41field = 248;
                int otherProviderIdentifierTypeCode42field = 249;
                int otherProviderIdentifierTypeCode43field = 250;
                int otherProviderIdentifierTypeCode44field = 251;
                int otherProviderIdentifierTypeCode45field = 252;
                int otherProviderIdentifierTypeCode46field = 253;
                int otherProviderIdentifierTypeCode47field = 254;
                int otherProviderIdentifierTypeCode48field = 255;
                int otherProviderIdentifierTypeCode49field = 256;
                int otherProviderIdentifierTypeCode5field = 257;
                int otherProviderIdentifierTypeCode50field = 258;
                int otherProviderIdentifierTypeCode6field = 259;
                int otherProviderIdentifierTypeCode7field = 260;
                int otherProviderIdentifierTypeCode8field = 261;
                int otherProviderIdentifierTypeCode9field = 262;
                int parentOrganizationLBNfield = 263;
                int parentOrganizationTINfield = 264;
                int providerBusinessMailingAddressCityNamefield = 265;
                int providerBusinessMailingAddressCountryCodeIfoutsideUSfield = 266;
                int providerBusinessMailingAddressFaxNumberfield = 267;
                int providerBusinessMailingAddressPostalCodefield = 268;
                int providerBusinessMailingAddressStateNamefield = 269;
                int providerBusinessMailingAddressTelephoneNumberfield = 270;
                int providerBusinessPracticeLocationAddressCityNamefield = 271;
                int providerBusinessPracticeLocationAddressCountryCodeIfoutsideUSfield = 272;
                int providerBusinessPracticeLocationAddressFaxNumberfield = 273;
                int providerBusinessPracticeLocationAddressPostalCodefield = 274;
                int providerBusinessPracticeLocationAddressStateNamefield = 275;
                int providerBusinessPracticeLocationAddressTelephoneNumberfield = 276;
                int providerCredentialTextfield = 277;
                int providerEnumerationDatefield = 278;
                int providerFirstLineBusinessMailingAddressfield = 279;
                int providerFirstLineBusinessPracticeLocationAddressfield = 280;
                int providerFirstNamefield = 281;
                int providerGenderCodefield = 282;
                int providerLastNameLegalNamefield = 283;
                int providerLicenseNumber1field = 284;
                int providerLicenseNumber10field = 285;
                int providerLicenseNumber11field = 286;
                int providerLicenseNumber12field = 287;
                int providerLicenseNumber13field = 288;
                int providerLicenseNumber14field = 289;
                int providerLicenseNumber15field = 290;
                int providerLicenseNumber2field = 291;
                int providerLicenseNumber3field = 292;
                int providerLicenseNumber4field = 293;
                int providerLicenseNumber5field = 294;
                int providerLicenseNumber6field = 295;
                int providerLicenseNumber7field = 296;
                int providerLicenseNumber8field = 297;
                int providerLicenseNumber9field = 298;
                int providerLicenseNumberStateCode1field = 299;
                int providerLicenseNumberStateCode10field = 300;
                int providerLicenseNumberStateCode11field = 301;
                int providerLicenseNumberStateCode12field = 302;
                int providerLicenseNumberStateCode13field = 303;
                int providerLicenseNumberStateCode14field = 304;
                int providerLicenseNumberStateCode15field = 305;
                int providerLicenseNumberStateCode2field = 306;
                int providerLicenseNumberStateCode3field = 307;
                int providerLicenseNumberStateCode4field = 308;
                int providerLicenseNumberStateCode5field = 309;
                int providerLicenseNumberStateCode6field = 310;
                int providerLicenseNumberStateCode7field = 311;
                int providerLicenseNumberStateCode8field = 312;
                int providerLicenseNumberStateCode9field = 313;
                int providerMiddleNamefield = 314;
                int providerNamePrefixTextfield = 315;
                int providerNameSuffixTextfield = 316;
                int providerOrganizationNameLegalBusinessNamefield = 317;
                int providerOtherCredentialTextfield = 318;
                int providerOtherFirstNamefield = 319;
                int providerOtherLastNamefield = 320;
                int providerOtherLastNameTypeCodefield = 321;
                int providerOtherMiddleNamefield = 322;
                int providerOtherNamePrefixTextfield = 323;
                int providerOtherNameSuffixTextfield = 324;
                int providerOtherOrganizationNamefield = 325;
                int providerOtherOrganizationNameTypeCodefield = 326;
                int providerSecondLineBusinessMailingAddressfield = 327;
                int providerSecondLineBusinessPracticeLocationAddressfield = 328;
                int replacementNPIfield = 329;

                try
                {
                    // Load Each field
                    rawImport.AuthorizedOfficialCredentialText = DataHelper.ParseString(dataRow.ItemArray[authorizedOfficialCredentialTextfield]);
                    rawImport.AuthorizedOfficialFirstName = DataHelper.ParseString(dataRow.ItemArray[authorizedOfficialFirstNamefield]);
                    rawImport.AuthorizedOfficialLastName = DataHelper.ParseString(dataRow.ItemArray[authorizedOfficialLastNamefield]);
                    rawImport.AuthorizedOfficialMiddleName = DataHelper.ParseString(dataRow.ItemArray[authorizedOfficialMiddleNamefield]);
                    rawImport.AuthorizedOfficialNamePrefixText = DataHelper.ParseString(dataRow.ItemArray[authorizedOfficialNamePrefixTextfield]);
                    rawImport.AuthorizedOfficialNameSuffixText = DataHelper.ParseString(dataRow.ItemArray[authorizedOfficialNameSuffixTextfield]);
                    rawImport.AuthorizedOfficialTelephoneNumber = DataHelper.ParseString(dataRow.ItemArray[authorizedOfficialTelephoneNumberfield]);
                    rawImport.AuthorizedOfficialTitleorPosition = DataHelper.ParseString(dataRow.ItemArray[authorizedOfficialTitleorPositionfield]);
                    rawImport.EmployerIdentificationNumberEIN = DataHelper.ParseString(dataRow.ItemArray[employerIdentificationNumberEINfield]);
                    rawImport.EntityTypeCode = DataHelper.ParseString(dataRow.ItemArray[entityTypeCodefield]);
                    rawImport.HealthcareProviderPrimaryTaxonomySwitch1 = DataHelper.ParseString(dataRow.ItemArray[healthcareProviderPrimaryTaxonomySwitch1field]);
                    rawImport.HealthcareProviderPrimaryTaxonomySwitch10 = DataHelper.ParseString(dataRow.ItemArray[healthcareProviderPrimaryTaxonomySwitch10field]);
                    rawImport.HealthcareProviderPrimaryTaxonomySwitch11 = DataHelper.ParseString(dataRow.ItemArray[healthcareProviderPrimaryTaxonomySwitch11field]);
                    rawImport.HealthcareProviderPrimaryTaxonomySwitch12 = DataHelper.ParseString(dataRow.ItemArray[healthcareProviderPrimaryTaxonomySwitch12field]);
                    rawImport.HealthcareProviderPrimaryTaxonomySwitch13 = DataHelper.ParseString(dataRow.ItemArray[healthcareProviderPrimaryTaxonomySwitch13field]);
                    rawImport.HealthcareProviderPrimaryTaxonomySwitch14 = DataHelper.ParseString(dataRow.ItemArray[healthcareProviderPrimaryTaxonomySwitch14field]);
                    rawImport.HealthcareProviderPrimaryTaxonomySwitch15 = DataHelper.ParseString(dataRow.ItemArray[healthcareProviderPrimaryTaxonomySwitch15field]);
                    rawImport.HealthcareProviderPrimaryTaxonomySwitch2 = DataHelper.ParseString(dataRow.ItemArray[healthcareProviderPrimaryTaxonomySwitch2field]);
                    rawImport.HealthcareProviderPrimaryTaxonomySwitch3 = DataHelper.ParseString(dataRow.ItemArray[healthcareProviderPrimaryTaxonomySwitch3field]);
                    rawImport.HealthcareProviderPrimaryTaxonomySwitch4 = DataHelper.ParseString(dataRow.ItemArray[healthcareProviderPrimaryTaxonomySwitch4field]);
                    rawImport.HealthcareProviderPrimaryTaxonomySwitch5 = DataHelper.ParseString(dataRow.ItemArray[healthcareProviderPrimaryTaxonomySwitch5field]);
                    rawImport.HealthcareProviderPrimaryTaxonomySwitch6 = DataHelper.ParseString(dataRow.ItemArray[healthcareProviderPrimaryTaxonomySwitch6field]);
                    rawImport.HealthcareProviderPrimaryTaxonomySwitch7 = DataHelper.ParseString(dataRow.ItemArray[healthcareProviderPrimaryTaxonomySwitch7field]);
                    rawImport.HealthcareProviderPrimaryTaxonomySwitch8 = DataHelper.ParseString(dataRow.ItemArray[healthcareProviderPrimaryTaxonomySwitch8field]);
                    rawImport.HealthcareProviderPrimaryTaxonomySwitch9 = DataHelper.ParseString(dataRow.ItemArray[healthcareProviderPrimaryTaxonomySwitch9field]);
                    rawImport.HealthcareProviderTaxonomyCode1 = DataHelper.ParseString(dataRow.ItemArray[healthcareProviderTaxonomyCode1field]);
                    rawImport.HealthcareProviderTaxonomyCode10 = DataHelper.ParseString(dataRow.ItemArray[healthcareProviderTaxonomyCode10field]);
                    rawImport.HealthcareProviderTaxonomyCode11 = DataHelper.ParseString(dataRow.ItemArray[healthcareProviderTaxonomyCode11field]);
                    rawImport.HealthcareProviderTaxonomyCode12 = DataHelper.ParseString(dataRow.ItemArray[healthcareProviderTaxonomyCode12field]);
                    rawImport.HealthcareProviderTaxonomyCode13 = DataHelper.ParseString(dataRow.ItemArray[healthcareProviderTaxonomyCode13field]);
                    rawImport.HealthcareProviderTaxonomyCode14 = DataHelper.ParseString(dataRow.ItemArray[healthcareProviderTaxonomyCode14field]);
                    rawImport.HealthcareProviderTaxonomyCode15 = DataHelper.ParseString(dataRow.ItemArray[healthcareProviderTaxonomyCode15field]);
                    rawImport.HealthcareProviderTaxonomyCode2 = DataHelper.ParseString(dataRow.ItemArray[healthcareProviderTaxonomyCode2field]);
                    rawImport.HealthcareProviderTaxonomyCode3 = DataHelper.ParseString(dataRow.ItemArray[healthcareProviderTaxonomyCode3field]);
                    rawImport.HealthcareProviderTaxonomyCode4 = DataHelper.ParseString(dataRow.ItemArray[healthcareProviderTaxonomyCode4field]);
                    rawImport.HealthcareProviderTaxonomyCode5 = DataHelper.ParseString(dataRow.ItemArray[healthcareProviderTaxonomyCode5field]);
                    rawImport.HealthcareProviderTaxonomyCode6 = DataHelper.ParseString(dataRow.ItemArray[healthcareProviderTaxonomyCode6field]);
                    rawImport.HealthcareProviderTaxonomyCode7 = DataHelper.ParseString(dataRow.ItemArray[healthcareProviderTaxonomyCode7field]);
                    rawImport.HealthcareProviderTaxonomyCode8 = DataHelper.ParseString(dataRow.ItemArray[healthcareProviderTaxonomyCode8field]);
                    rawImport.HealthcareProviderTaxonomyCode9 = DataHelper.ParseString(dataRow.ItemArray[healthcareProviderTaxonomyCode9field]);
                    rawImport.HealthcareProviderTaxonomyGroup1 = DataHelper.ParseString(dataRow.ItemArray[healthcareProviderTaxonomyGroup1field]);
                    rawImport.HealthcareProviderTaxonomyGroup10 = DataHelper.ParseString(dataRow.ItemArray[healthcareProviderTaxonomyGroup10field]);
                    rawImport.HealthcareProviderTaxonomyGroup11 = DataHelper.ParseString(dataRow.ItemArray[healthcareProviderTaxonomyGroup11field]);
                    rawImport.HealthcareProviderTaxonomyGroup12 = DataHelper.ParseString(dataRow.ItemArray[healthcareProviderTaxonomyGroup12field]);
                    rawImport.HealthcareProviderTaxonomyGroup13 = DataHelper.ParseString(dataRow.ItemArray[healthcareProviderTaxonomyGroup13field]);
                    rawImport.HealthcareProviderTaxonomyGroup14 = DataHelper.ParseString(dataRow.ItemArray[healthcareProviderTaxonomyGroup14field]);
                    rawImport.HealthcareProviderTaxonomyGroup15 = DataHelper.ParseString(dataRow.ItemArray[healthcareProviderTaxonomyGroup15field]);
                    rawImport.HealthcareProviderTaxonomyGroup2 = DataHelper.ParseString(dataRow.ItemArray[healthcareProviderTaxonomyGroup2field]);
                    rawImport.HealthcareProviderTaxonomyGroup3 = DataHelper.ParseString(dataRow.ItemArray[healthcareProviderTaxonomyGroup3field]);
                    rawImport.HealthcareProviderTaxonomyGroup4 = DataHelper.ParseString(dataRow.ItemArray[healthcareProviderTaxonomyGroup4field]);
                    rawImport.HealthcareProviderTaxonomyGroup5 = DataHelper.ParseString(dataRow.ItemArray[healthcareProviderTaxonomyGroup5field]);
                    rawImport.HealthcareProviderTaxonomyGroup6 = DataHelper.ParseString(dataRow.ItemArray[healthcareProviderTaxonomyGroup6field]);
                    rawImport.HealthcareProviderTaxonomyGroup7 = DataHelper.ParseString(dataRow.ItemArray[healthcareProviderTaxonomyGroup7field]);
                    rawImport.HealthcareProviderTaxonomyGroup8 = DataHelper.ParseString(dataRow.ItemArray[healthcareProviderTaxonomyGroup8field]);
                    rawImport.HealthcareProviderTaxonomyGroup9 = DataHelper.ParseString(dataRow.ItemArray[healthcareProviderTaxonomyGroup9field]);
                    rawImport.UpdateIdentity(DataHelper.ParseInteger(dataRow.ItemArray[idfield], 0));
                    rawImport.IsOrganizationSubpart = DataHelper.ParseString(dataRow.ItemArray[isOrganizationSubpartfield]);
                    rawImport.IsSoleProprietor = DataHelper.ParseString(dataRow.ItemArray[isSoleProprietorfield]);
                    rawImport.LastUpdateDate = DataHelper.ParseString(dataRow.ItemArray[lastUpdateDatefield]);
                    rawImport.NPI = DataHelper.ParseString(dataRow.ItemArray[nPIfield]);
                    rawImport.NPIDeactivationDate = DataHelper.ParseString(dataRow.ItemArray[nPIDeactivationDatefield]);
                    rawImport.NPIDeactivationReasonCode = DataHelper.ParseString(dataRow.ItemArray[nPIDeactivationReasonCodefield]);
                    rawImport.NPIReactivationDate = DataHelper.ParseString(dataRow.ItemArray[nPIReactivationDatefield]);
                    rawImport.OtherProviderIdentifier1 = DataHelper.ParseString(dataRow.ItemArray[otherProviderIdentifier1field]);
                    rawImport.OtherProviderIdentifier10 = DataHelper.ParseString(dataRow.ItemArray[otherProviderIdentifier10field]);
                    rawImport.OtherProviderIdentifier11 = DataHelper.ParseString(dataRow.ItemArray[otherProviderIdentifier11field]);
                    rawImport.OtherProviderIdentifier12 = DataHelper.ParseString(dataRow.ItemArray[otherProviderIdentifier12field]);
                    rawImport.OtherProviderIdentifier13 = DataHelper.ParseString(dataRow.ItemArray[otherProviderIdentifier13field]);
                    rawImport.OtherProviderIdentifier14 = DataHelper.ParseString(dataRow.ItemArray[otherProviderIdentifier14field]);
                    rawImport.OtherProviderIdentifier15 = DataHelper.ParseString(dataRow.ItemArray[otherProviderIdentifier15field]);
                    rawImport.OtherProviderIdentifier16 = DataHelper.ParseString(dataRow.ItemArray[otherProviderIdentifier16field]);
                    rawImport.OtherProviderIdentifier17 = DataHelper.ParseString(dataRow.ItemArray[otherProviderIdentifier17field]);
                    rawImport.OtherProviderIdentifier18 = DataHelper.ParseString(dataRow.ItemArray[otherProviderIdentifier18field]);
                    rawImport.OtherProviderIdentifier19 = DataHelper.ParseString(dataRow.ItemArray[otherProviderIdentifier19field]);
                    rawImport.OtherProviderIdentifier2 = DataHelper.ParseString(dataRow.ItemArray[otherProviderIdentifier2field]);
                    rawImport.OtherProviderIdentifier20 = DataHelper.ParseString(dataRow.ItemArray[otherProviderIdentifier20field]);
                    rawImport.OtherProviderIdentifier21 = DataHelper.ParseString(dataRow.ItemArray[otherProviderIdentifier21field]);
                    rawImport.OtherProviderIdentifier22 = DataHelper.ParseString(dataRow.ItemArray[otherProviderIdentifier22field]);
                    rawImport.OtherProviderIdentifier23 = DataHelper.ParseString(dataRow.ItemArray[otherProviderIdentifier23field]);
                    rawImport.OtherProviderIdentifier24 = DataHelper.ParseString(dataRow.ItemArray[otherProviderIdentifier24field]);
                    rawImport.OtherProviderIdentifier25 = DataHelper.ParseString(dataRow.ItemArray[otherProviderIdentifier25field]);
                    rawImport.OtherProviderIdentifier26 = DataHelper.ParseString(dataRow.ItemArray[otherProviderIdentifier26field]);
                    rawImport.OtherProviderIdentifier27 = DataHelper.ParseString(dataRow.ItemArray[otherProviderIdentifier27field]);
                    rawImport.OtherProviderIdentifier28 = DataHelper.ParseString(dataRow.ItemArray[otherProviderIdentifier28field]);
                    rawImport.OtherProviderIdentifier29 = DataHelper.ParseString(dataRow.ItemArray[otherProviderIdentifier29field]);
                    rawImport.OtherProviderIdentifier3 = DataHelper.ParseString(dataRow.ItemArray[otherProviderIdentifier3field]);
                    rawImport.OtherProviderIdentifier30 = DataHelper.ParseString(dataRow.ItemArray[otherProviderIdentifier30field]);
                    rawImport.OtherProviderIdentifier31 = DataHelper.ParseString(dataRow.ItemArray[otherProviderIdentifier31field]);
                    rawImport.OtherProviderIdentifier32 = DataHelper.ParseString(dataRow.ItemArray[otherProviderIdentifier32field]);
                    rawImport.OtherProviderIdentifier33 = DataHelper.ParseString(dataRow.ItemArray[otherProviderIdentifier33field]);
                    rawImport.OtherProviderIdentifier34 = DataHelper.ParseString(dataRow.ItemArray[otherProviderIdentifier34field]);
                    rawImport.OtherProviderIdentifier35 = DataHelper.ParseString(dataRow.ItemArray[otherProviderIdentifier35field]);
                    rawImport.OtherProviderIdentifier36 = DataHelper.ParseString(dataRow.ItemArray[otherProviderIdentifier36field]);
                    rawImport.OtherProviderIdentifier37 = DataHelper.ParseString(dataRow.ItemArray[otherProviderIdentifier37field]);
                    rawImport.OtherProviderIdentifier38 = DataHelper.ParseString(dataRow.ItemArray[otherProviderIdentifier38field]);
                    rawImport.OtherProviderIdentifier39 = DataHelper.ParseString(dataRow.ItemArray[otherProviderIdentifier39field]);
                    rawImport.OtherProviderIdentifier4 = DataHelper.ParseString(dataRow.ItemArray[otherProviderIdentifier4field]);
                    rawImport.OtherProviderIdentifier40 = DataHelper.ParseString(dataRow.ItemArray[otherProviderIdentifier40field]);
                    rawImport.OtherProviderIdentifier41 = DataHelper.ParseString(dataRow.ItemArray[otherProviderIdentifier41field]);
                    rawImport.OtherProviderIdentifier42 = DataHelper.ParseString(dataRow.ItemArray[otherProviderIdentifier42field]);
                    rawImport.OtherProviderIdentifier43 = DataHelper.ParseString(dataRow.ItemArray[otherProviderIdentifier43field]);
                    rawImport.OtherProviderIdentifier44 = DataHelper.ParseString(dataRow.ItemArray[otherProviderIdentifier44field]);
                    rawImport.OtherProviderIdentifier45 = DataHelper.ParseString(dataRow.ItemArray[otherProviderIdentifier45field]);
                    rawImport.OtherProviderIdentifier46 = DataHelper.ParseString(dataRow.ItemArray[otherProviderIdentifier46field]);
                    rawImport.OtherProviderIdentifier47 = DataHelper.ParseString(dataRow.ItemArray[otherProviderIdentifier47field]);
                    rawImport.OtherProviderIdentifier48 = DataHelper.ParseString(dataRow.ItemArray[otherProviderIdentifier48field]);
                    rawImport.OtherProviderIdentifier49 = DataHelper.ParseString(dataRow.ItemArray[otherProviderIdentifier49field]);
                    rawImport.OtherProviderIdentifier5 = DataHelper.ParseString(dataRow.ItemArray[otherProviderIdentifier5field]);
                    rawImport.OtherProviderIdentifier50 = DataHelper.ParseString(dataRow.ItemArray[otherProviderIdentifier50field]);
                    rawImport.OtherProviderIdentifier6 = DataHelper.ParseString(dataRow.ItemArray[otherProviderIdentifier6field]);
                    rawImport.OtherProviderIdentifier7 = DataHelper.ParseString(dataRow.ItemArray[otherProviderIdentifier7field]);
                    rawImport.OtherProviderIdentifier8 = DataHelper.ParseString(dataRow.ItemArray[otherProviderIdentifier8field]);
                    rawImport.OtherProviderIdentifier9 = DataHelper.ParseString(dataRow.ItemArray[otherProviderIdentifier9field]);
                    rawImport.OtherProviderIdentifierIssuer1 = DataHelper.ParseString(dataRow.ItemArray[otherProviderIdentifierIssuer1field]);
                    rawImport.OtherProviderIdentifierIssuer10 = DataHelper.ParseString(dataRow.ItemArray[otherProviderIdentifierIssuer10field]);
                    rawImport.OtherProviderIdentifierIssuer11 = DataHelper.ParseString(dataRow.ItemArray[otherProviderIdentifierIssuer11field]);
                    rawImport.OtherProviderIdentifierIssuer12 = DataHelper.ParseString(dataRow.ItemArray[otherProviderIdentifierIssuer12field]);
                    rawImport.OtherProviderIdentifierIssuer13 = DataHelper.ParseString(dataRow.ItemArray[otherProviderIdentifierIssuer13field]);
                    rawImport.OtherProviderIdentifierIssuer14 = DataHelper.ParseString(dataRow.ItemArray[otherProviderIdentifierIssuer14field]);
                    rawImport.OtherProviderIdentifierIssuer15 = DataHelper.ParseString(dataRow.ItemArray[otherProviderIdentifierIssuer15field]);
                    rawImport.OtherProviderIdentifierIssuer16 = DataHelper.ParseString(dataRow.ItemArray[otherProviderIdentifierIssuer16field]);
                    rawImport.OtherProviderIdentifierIssuer17 = DataHelper.ParseString(dataRow.ItemArray[otherProviderIdentifierIssuer17field]);
                    rawImport.OtherProviderIdentifierIssuer18 = DataHelper.ParseString(dataRow.ItemArray[otherProviderIdentifierIssuer18field]);
                    rawImport.OtherProviderIdentifierIssuer19 = DataHelper.ParseString(dataRow.ItemArray[otherProviderIdentifierIssuer19field]);
                    rawImport.OtherProviderIdentifierIssuer2 = DataHelper.ParseString(dataRow.ItemArray[otherProviderIdentifierIssuer2field]);
                    rawImport.OtherProviderIdentifierIssuer20 = DataHelper.ParseString(dataRow.ItemArray[otherProviderIdentifierIssuer20field]);
                    rawImport.OtherProviderIdentifierIssuer21 = DataHelper.ParseString(dataRow.ItemArray[otherProviderIdentifierIssuer21field]);
                    rawImport.OtherProviderIdentifierIssuer22 = DataHelper.ParseString(dataRow.ItemArray[otherProviderIdentifierIssuer22field]);
                    rawImport.OtherProviderIdentifierIssuer23 = DataHelper.ParseString(dataRow.ItemArray[otherProviderIdentifierIssuer23field]);
                    rawImport.OtherProviderIdentifierIssuer24 = DataHelper.ParseString(dataRow.ItemArray[otherProviderIdentifierIssuer24field]);
                    rawImport.OtherProviderIdentifierIssuer25 = DataHelper.ParseString(dataRow.ItemArray[otherProviderIdentifierIssuer25field]);
                    rawImport.OtherProviderIdentifierIssuer26 = DataHelper.ParseString(dataRow.ItemArray[otherProviderIdentifierIssuer26field]);
                    rawImport.OtherProviderIdentifierIssuer27 = DataHelper.ParseString(dataRow.ItemArray[otherProviderIdentifierIssuer27field]);
                    rawImport.OtherProviderIdentifierIssuer28 = DataHelper.ParseString(dataRow.ItemArray[otherProviderIdentifierIssuer28field]);
                    rawImport.OtherProviderIdentifierIssuer29 = DataHelper.ParseString(dataRow.ItemArray[otherProviderIdentifierIssuer29field]);
                    rawImport.OtherProviderIdentifierIssuer3 = DataHelper.ParseString(dataRow.ItemArray[otherProviderIdentifierIssuer3field]);
                    rawImport.OtherProviderIdentifierIssuer30 = DataHelper.ParseString(dataRow.ItemArray[otherProviderIdentifierIssuer30field]);
                    rawImport.OtherProviderIdentifierIssuer31 = DataHelper.ParseString(dataRow.ItemArray[otherProviderIdentifierIssuer31field]);
                    rawImport.OtherProviderIdentifierIssuer32 = DataHelper.ParseString(dataRow.ItemArray[otherProviderIdentifierIssuer32field]);
                    rawImport.OtherProviderIdentifierIssuer33 = DataHelper.ParseString(dataRow.ItemArray[otherProviderIdentifierIssuer33field]);
                    rawImport.OtherProviderIdentifierIssuer34 = DataHelper.ParseString(dataRow.ItemArray[otherProviderIdentifierIssuer34field]);
                    rawImport.OtherProviderIdentifierIssuer35 = DataHelper.ParseString(dataRow.ItemArray[otherProviderIdentifierIssuer35field]);
                    rawImport.OtherProviderIdentifierIssuer36 = DataHelper.ParseString(dataRow.ItemArray[otherProviderIdentifierIssuer36field]);
                    rawImport.OtherProviderIdentifierIssuer37 = DataHelper.ParseString(dataRow.ItemArray[otherProviderIdentifierIssuer37field]);
                    rawImport.OtherProviderIdentifierIssuer38 = DataHelper.ParseString(dataRow.ItemArray[otherProviderIdentifierIssuer38field]);
                    rawImport.OtherProviderIdentifierIssuer39 = DataHelper.ParseString(dataRow.ItemArray[otherProviderIdentifierIssuer39field]);
                    rawImport.OtherProviderIdentifierIssuer4 = DataHelper.ParseString(dataRow.ItemArray[otherProviderIdentifierIssuer4field]);
                    rawImport.OtherProviderIdentifierIssuer40 = DataHelper.ParseString(dataRow.ItemArray[otherProviderIdentifierIssuer40field]);
                    rawImport.OtherProviderIdentifierIssuer41 = DataHelper.ParseString(dataRow.ItemArray[otherProviderIdentifierIssuer41field]);
                    rawImport.OtherProviderIdentifierIssuer42 = DataHelper.ParseString(dataRow.ItemArray[otherProviderIdentifierIssuer42field]);
                    rawImport.OtherProviderIdentifierIssuer43 = DataHelper.ParseString(dataRow.ItemArray[otherProviderIdentifierIssuer43field]);
                    rawImport.OtherProviderIdentifierIssuer44 = DataHelper.ParseString(dataRow.ItemArray[otherProviderIdentifierIssuer44field]);
                    rawImport.OtherProviderIdentifierIssuer45 = DataHelper.ParseString(dataRow.ItemArray[otherProviderIdentifierIssuer45field]);
                    rawImport.OtherProviderIdentifierIssuer46 = DataHelper.ParseString(dataRow.ItemArray[otherProviderIdentifierIssuer46field]);
                    rawImport.OtherProviderIdentifierIssuer47 = DataHelper.ParseString(dataRow.ItemArray[otherProviderIdentifierIssuer47field]);
                    rawImport.OtherProviderIdentifierIssuer48 = DataHelper.ParseString(dataRow.ItemArray[otherProviderIdentifierIssuer48field]);
                    rawImport.OtherProviderIdentifierIssuer49 = DataHelper.ParseString(dataRow.ItemArray[otherProviderIdentifierIssuer49field]);
                    rawImport.OtherProviderIdentifierIssuer5 = DataHelper.ParseString(dataRow.ItemArray[otherProviderIdentifierIssuer5field]);
                    rawImport.OtherProviderIdentifierIssuer50 = DataHelper.ParseString(dataRow.ItemArray[otherProviderIdentifierIssuer50field]);
                    rawImport.OtherProviderIdentifierIssuer6 = DataHelper.ParseString(dataRow.ItemArray[otherProviderIdentifierIssuer6field]);
                    rawImport.OtherProviderIdentifierIssuer7 = DataHelper.ParseString(dataRow.ItemArray[otherProviderIdentifierIssuer7field]);
                    rawImport.OtherProviderIdentifierIssuer8 = DataHelper.ParseString(dataRow.ItemArray[otherProviderIdentifierIssuer8field]);
                    rawImport.OtherProviderIdentifierIssuer9 = DataHelper.ParseString(dataRow.ItemArray[otherProviderIdentifierIssuer9field]);
                    rawImport.OtherProviderIdentifierState1 = DataHelper.ParseString(dataRow.ItemArray[otherProviderIdentifierState1field]);
                    rawImport.OtherProviderIdentifierState10 = DataHelper.ParseString(dataRow.ItemArray[otherProviderIdentifierState10field]);
                    rawImport.OtherProviderIdentifierState11 = DataHelper.ParseString(dataRow.ItemArray[otherProviderIdentifierState11field]);
                    rawImport.OtherProviderIdentifierState12 = DataHelper.ParseString(dataRow.ItemArray[otherProviderIdentifierState12field]);
                    rawImport.OtherProviderIdentifierState13 = DataHelper.ParseString(dataRow.ItemArray[otherProviderIdentifierState13field]);
                    rawImport.OtherProviderIdentifierState14 = DataHelper.ParseString(dataRow.ItemArray[otherProviderIdentifierState14field]);
                    rawImport.OtherProviderIdentifierState15 = DataHelper.ParseString(dataRow.ItemArray[otherProviderIdentifierState15field]);
                    rawImport.OtherProviderIdentifierState16 = DataHelper.ParseString(dataRow.ItemArray[otherProviderIdentifierState16field]);
                    rawImport.OtherProviderIdentifierState17 = DataHelper.ParseString(dataRow.ItemArray[otherProviderIdentifierState17field]);
                    rawImport.OtherProviderIdentifierState18 = DataHelper.ParseString(dataRow.ItemArray[otherProviderIdentifierState18field]);
                    rawImport.OtherProviderIdentifierState19 = DataHelper.ParseString(dataRow.ItemArray[otherProviderIdentifierState19field]);
                    rawImport.OtherProviderIdentifierState2 = DataHelper.ParseString(dataRow.ItemArray[otherProviderIdentifierState2field]);
                    rawImport.OtherProviderIdentifierState20 = DataHelper.ParseString(dataRow.ItemArray[otherProviderIdentifierState20field]);
                    rawImport.OtherProviderIdentifierState21 = DataHelper.ParseString(dataRow.ItemArray[otherProviderIdentifierState21field]);
                    rawImport.OtherProviderIdentifierState22 = DataHelper.ParseString(dataRow.ItemArray[otherProviderIdentifierState22field]);
                    rawImport.OtherProviderIdentifierState23 = DataHelper.ParseString(dataRow.ItemArray[otherProviderIdentifierState23field]);
                    rawImport.OtherProviderIdentifierState24 = DataHelper.ParseString(dataRow.ItemArray[otherProviderIdentifierState24field]);
                    rawImport.OtherProviderIdentifierState25 = DataHelper.ParseString(dataRow.ItemArray[otherProviderIdentifierState25field]);
                    rawImport.OtherProviderIdentifierState26 = DataHelper.ParseString(dataRow.ItemArray[otherProviderIdentifierState26field]);
                    rawImport.OtherProviderIdentifierState27 = DataHelper.ParseString(dataRow.ItemArray[otherProviderIdentifierState27field]);
                    rawImport.OtherProviderIdentifierState28 = DataHelper.ParseString(dataRow.ItemArray[otherProviderIdentifierState28field]);
                    rawImport.OtherProviderIdentifierState29 = DataHelper.ParseString(dataRow.ItemArray[otherProviderIdentifierState29field]);
                    rawImport.OtherProviderIdentifierState3 = DataHelper.ParseString(dataRow.ItemArray[otherProviderIdentifierState3field]);
                    rawImport.OtherProviderIdentifierState30 = DataHelper.ParseString(dataRow.ItemArray[otherProviderIdentifierState30field]);
                    rawImport.OtherProviderIdentifierState31 = DataHelper.ParseString(dataRow.ItemArray[otherProviderIdentifierState31field]);
                    rawImport.OtherProviderIdentifierState32 = DataHelper.ParseString(dataRow.ItemArray[otherProviderIdentifierState32field]);
                    rawImport.OtherProviderIdentifierState33 = DataHelper.ParseString(dataRow.ItemArray[otherProviderIdentifierState33field]);
                    rawImport.OtherProviderIdentifierState34 = DataHelper.ParseString(dataRow.ItemArray[otherProviderIdentifierState34field]);
                    rawImport.OtherProviderIdentifierState35 = DataHelper.ParseString(dataRow.ItemArray[otherProviderIdentifierState35field]);
                    rawImport.OtherProviderIdentifierState36 = DataHelper.ParseString(dataRow.ItemArray[otherProviderIdentifierState36field]);
                    rawImport.OtherProviderIdentifierState37 = DataHelper.ParseString(dataRow.ItemArray[otherProviderIdentifierState37field]);
                    rawImport.OtherProviderIdentifierState38 = DataHelper.ParseString(dataRow.ItemArray[otherProviderIdentifierState38field]);
                    rawImport.OtherProviderIdentifierState39 = DataHelper.ParseString(dataRow.ItemArray[otherProviderIdentifierState39field]);
                    rawImport.OtherProviderIdentifierState4 = DataHelper.ParseString(dataRow.ItemArray[otherProviderIdentifierState4field]);
                    rawImport.OtherProviderIdentifierState40 = DataHelper.ParseString(dataRow.ItemArray[otherProviderIdentifierState40field]);
                    rawImport.OtherProviderIdentifierState41 = DataHelper.ParseString(dataRow.ItemArray[otherProviderIdentifierState41field]);
                    rawImport.OtherProviderIdentifierState42 = DataHelper.ParseString(dataRow.ItemArray[otherProviderIdentifierState42field]);
                    rawImport.OtherProviderIdentifierState43 = DataHelper.ParseString(dataRow.ItemArray[otherProviderIdentifierState43field]);
                    rawImport.OtherProviderIdentifierState44 = DataHelper.ParseString(dataRow.ItemArray[otherProviderIdentifierState44field]);
                    rawImport.OtherProviderIdentifierState45 = DataHelper.ParseString(dataRow.ItemArray[otherProviderIdentifierState45field]);
                    rawImport.OtherProviderIdentifierState46 = DataHelper.ParseString(dataRow.ItemArray[otherProviderIdentifierState46field]);
                    rawImport.OtherProviderIdentifierState47 = DataHelper.ParseString(dataRow.ItemArray[otherProviderIdentifierState47field]);
                    rawImport.OtherProviderIdentifierState48 = DataHelper.ParseString(dataRow.ItemArray[otherProviderIdentifierState48field]);
                    rawImport.OtherProviderIdentifierState49 = DataHelper.ParseString(dataRow.ItemArray[otherProviderIdentifierState49field]);
                    rawImport.OtherProviderIdentifierState5 = DataHelper.ParseString(dataRow.ItemArray[otherProviderIdentifierState5field]);
                    rawImport.OtherProviderIdentifierState50 = DataHelper.ParseString(dataRow.ItemArray[otherProviderIdentifierState50field]);
                    rawImport.OtherProviderIdentifierState6 = DataHelper.ParseString(dataRow.ItemArray[otherProviderIdentifierState6field]);
                    rawImport.OtherProviderIdentifierState7 = DataHelper.ParseString(dataRow.ItemArray[otherProviderIdentifierState7field]);
                    rawImport.OtherProviderIdentifierState8 = DataHelper.ParseString(dataRow.ItemArray[otherProviderIdentifierState8field]);
                    rawImport.OtherProviderIdentifierState9 = DataHelper.ParseString(dataRow.ItemArray[otherProviderIdentifierState9field]);
                    rawImport.OtherProviderIdentifierTypeCode1 = DataHelper.ParseString(dataRow.ItemArray[otherProviderIdentifierTypeCode1field]);
                    rawImport.OtherProviderIdentifierTypeCode10 = DataHelper.ParseString(dataRow.ItemArray[otherProviderIdentifierTypeCode10field]);
                    rawImport.OtherProviderIdentifierTypeCode11 = DataHelper.ParseString(dataRow.ItemArray[otherProviderIdentifierTypeCode11field]);
                    rawImport.OtherProviderIdentifierTypeCode12 = DataHelper.ParseString(dataRow.ItemArray[otherProviderIdentifierTypeCode12field]);
                    rawImport.OtherProviderIdentifierTypeCode13 = DataHelper.ParseString(dataRow.ItemArray[otherProviderIdentifierTypeCode13field]);
                    rawImport.OtherProviderIdentifierTypeCode14 = DataHelper.ParseString(dataRow.ItemArray[otherProviderIdentifierTypeCode14field]);
                    rawImport.OtherProviderIdentifierTypeCode15 = DataHelper.ParseString(dataRow.ItemArray[otherProviderIdentifierTypeCode15field]);
                    rawImport.OtherProviderIdentifierTypeCode16 = DataHelper.ParseString(dataRow.ItemArray[otherProviderIdentifierTypeCode16field]);
                    rawImport.OtherProviderIdentifierTypeCode17 = DataHelper.ParseString(dataRow.ItemArray[otherProviderIdentifierTypeCode17field]);
                    rawImport.OtherProviderIdentifierTypeCode18 = DataHelper.ParseString(dataRow.ItemArray[otherProviderIdentifierTypeCode18field]);
                    rawImport.OtherProviderIdentifierTypeCode19 = DataHelper.ParseString(dataRow.ItemArray[otherProviderIdentifierTypeCode19field]);
                    rawImport.OtherProviderIdentifierTypeCode2 = DataHelper.ParseString(dataRow.ItemArray[otherProviderIdentifierTypeCode2field]);
                    rawImport.OtherProviderIdentifierTypeCode20 = DataHelper.ParseString(dataRow.ItemArray[otherProviderIdentifierTypeCode20field]);
                    rawImport.OtherProviderIdentifierTypeCode21 = DataHelper.ParseString(dataRow.ItemArray[otherProviderIdentifierTypeCode21field]);
                    rawImport.OtherProviderIdentifierTypeCode22 = DataHelper.ParseString(dataRow.ItemArray[otherProviderIdentifierTypeCode22field]);
                    rawImport.OtherProviderIdentifierTypeCode23 = DataHelper.ParseString(dataRow.ItemArray[otherProviderIdentifierTypeCode23field]);
                    rawImport.OtherProviderIdentifierTypeCode24 = DataHelper.ParseString(dataRow.ItemArray[otherProviderIdentifierTypeCode24field]);
                    rawImport.OtherProviderIdentifierTypeCode25 = DataHelper.ParseString(dataRow.ItemArray[otherProviderIdentifierTypeCode25field]);
                    rawImport.OtherProviderIdentifierTypeCode26 = DataHelper.ParseString(dataRow.ItemArray[otherProviderIdentifierTypeCode26field]);
                    rawImport.OtherProviderIdentifierTypeCode27 = DataHelper.ParseString(dataRow.ItemArray[otherProviderIdentifierTypeCode27field]);
                    rawImport.OtherProviderIdentifierTypeCode28 = DataHelper.ParseString(dataRow.ItemArray[otherProviderIdentifierTypeCode28field]);
                    rawImport.OtherProviderIdentifierTypeCode29 = DataHelper.ParseString(dataRow.ItemArray[otherProviderIdentifierTypeCode29field]);
                    rawImport.OtherProviderIdentifierTypeCode3 = DataHelper.ParseString(dataRow.ItemArray[otherProviderIdentifierTypeCode3field]);
                    rawImport.OtherProviderIdentifierTypeCode30 = DataHelper.ParseString(dataRow.ItemArray[otherProviderIdentifierTypeCode30field]);
                    rawImport.OtherProviderIdentifierTypeCode31 = DataHelper.ParseString(dataRow.ItemArray[otherProviderIdentifierTypeCode31field]);
                    rawImport.OtherProviderIdentifierTypeCode32 = DataHelper.ParseString(dataRow.ItemArray[otherProviderIdentifierTypeCode32field]);
                    rawImport.OtherProviderIdentifierTypeCode33 = DataHelper.ParseString(dataRow.ItemArray[otherProviderIdentifierTypeCode33field]);
                    rawImport.OtherProviderIdentifierTypeCode34 = DataHelper.ParseString(dataRow.ItemArray[otherProviderIdentifierTypeCode34field]);
                    rawImport.OtherProviderIdentifierTypeCode35 = DataHelper.ParseString(dataRow.ItemArray[otherProviderIdentifierTypeCode35field]);
                    rawImport.OtherProviderIdentifierTypeCode36 = DataHelper.ParseString(dataRow.ItemArray[otherProviderIdentifierTypeCode36field]);
                    rawImport.OtherProviderIdentifierTypeCode37 = DataHelper.ParseString(dataRow.ItemArray[otherProviderIdentifierTypeCode37field]);
                    rawImport.OtherProviderIdentifierTypeCode38 = DataHelper.ParseString(dataRow.ItemArray[otherProviderIdentifierTypeCode38field]);
                    rawImport.OtherProviderIdentifierTypeCode39 = DataHelper.ParseString(dataRow.ItemArray[otherProviderIdentifierTypeCode39field]);
                    rawImport.OtherProviderIdentifierTypeCode4 = DataHelper.ParseString(dataRow.ItemArray[otherProviderIdentifierTypeCode4field]);
                    rawImport.OtherProviderIdentifierTypeCode40 = DataHelper.ParseString(dataRow.ItemArray[otherProviderIdentifierTypeCode40field]);
                    rawImport.OtherProviderIdentifierTypeCode41 = DataHelper.ParseString(dataRow.ItemArray[otherProviderIdentifierTypeCode41field]);
                    rawImport.OtherProviderIdentifierTypeCode42 = DataHelper.ParseString(dataRow.ItemArray[otherProviderIdentifierTypeCode42field]);
                    rawImport.OtherProviderIdentifierTypeCode43 = DataHelper.ParseString(dataRow.ItemArray[otherProviderIdentifierTypeCode43field]);
                    rawImport.OtherProviderIdentifierTypeCode44 = DataHelper.ParseString(dataRow.ItemArray[otherProviderIdentifierTypeCode44field]);
                    rawImport.OtherProviderIdentifierTypeCode45 = DataHelper.ParseString(dataRow.ItemArray[otherProviderIdentifierTypeCode45field]);
                    rawImport.OtherProviderIdentifierTypeCode46 = DataHelper.ParseString(dataRow.ItemArray[otherProviderIdentifierTypeCode46field]);
                    rawImport.OtherProviderIdentifierTypeCode47 = DataHelper.ParseString(dataRow.ItemArray[otherProviderIdentifierTypeCode47field]);
                    rawImport.OtherProviderIdentifierTypeCode48 = DataHelper.ParseString(dataRow.ItemArray[otherProviderIdentifierTypeCode48field]);
                    rawImport.OtherProviderIdentifierTypeCode49 = DataHelper.ParseString(dataRow.ItemArray[otherProviderIdentifierTypeCode49field]);
                    rawImport.OtherProviderIdentifierTypeCode5 = DataHelper.ParseString(dataRow.ItemArray[otherProviderIdentifierTypeCode5field]);
                    rawImport.OtherProviderIdentifierTypeCode50 = DataHelper.ParseString(dataRow.ItemArray[otherProviderIdentifierTypeCode50field]);
                    rawImport.OtherProviderIdentifierTypeCode6 = DataHelper.ParseString(dataRow.ItemArray[otherProviderIdentifierTypeCode6field]);
                    rawImport.OtherProviderIdentifierTypeCode7 = DataHelper.ParseString(dataRow.ItemArray[otherProviderIdentifierTypeCode7field]);
                    rawImport.OtherProviderIdentifierTypeCode8 = DataHelper.ParseString(dataRow.ItemArray[otherProviderIdentifierTypeCode8field]);
                    rawImport.OtherProviderIdentifierTypeCode9 = DataHelper.ParseString(dataRow.ItemArray[otherProviderIdentifierTypeCode9field]);
                    rawImport.ParentOrganizationLBN = DataHelper.ParseString(dataRow.ItemArray[parentOrganizationLBNfield]);
                    rawImport.ParentOrganizationTIN = DataHelper.ParseString(dataRow.ItemArray[parentOrganizationTINfield]);
                    rawImport.ProviderBusinessMailingAddressCityName = DataHelper.ParseString(dataRow.ItemArray[providerBusinessMailingAddressCityNamefield]);
                    rawImport.ProviderBusinessMailingAddressCountryCodeIfoutsideUS = DataHelper.ParseString(dataRow.ItemArray[providerBusinessMailingAddressCountryCodeIfoutsideUSfield]);
                    rawImport.ProviderBusinessMailingAddressFaxNumber = DataHelper.ParseString(dataRow.ItemArray[providerBusinessMailingAddressFaxNumberfield]);
                    rawImport.ProviderBusinessMailingAddressPostalCode = DataHelper.ParseString(dataRow.ItemArray[providerBusinessMailingAddressPostalCodefield]);
                    rawImport.ProviderBusinessMailingAddressStateName = DataHelper.ParseString(dataRow.ItemArray[providerBusinessMailingAddressStateNamefield]);
                    rawImport.ProviderBusinessMailingAddressTelephoneNumber = DataHelper.ParseString(dataRow.ItemArray[providerBusinessMailingAddressTelephoneNumberfield]);
                    rawImport.ProviderBusinessPracticeLocationAddressCityName = DataHelper.ParseString(dataRow.ItemArray[providerBusinessPracticeLocationAddressCityNamefield]);
                    rawImport.ProviderBusinessPracticeLocationAddressCountryCodeIfoutsideUS = DataHelper.ParseString(dataRow.ItemArray[providerBusinessPracticeLocationAddressCountryCodeIfoutsideUSfield]);
                    rawImport.ProviderBusinessPracticeLocationAddressFaxNumber = DataHelper.ParseString(dataRow.ItemArray[providerBusinessPracticeLocationAddressFaxNumberfield]);
                    rawImport.ProviderBusinessPracticeLocationAddressPostalCode = DataHelper.ParseString(dataRow.ItemArray[providerBusinessPracticeLocationAddressPostalCodefield]);
                    rawImport.ProviderBusinessPracticeLocationAddressStateName = DataHelper.ParseString(dataRow.ItemArray[providerBusinessPracticeLocationAddressStateNamefield]);
                    rawImport.ProviderBusinessPracticeLocationAddressTelephoneNumber = DataHelper.ParseString(dataRow.ItemArray[providerBusinessPracticeLocationAddressTelephoneNumberfield]);
                    rawImport.ProviderCredentialText = DataHelper.ParseString(dataRow.ItemArray[providerCredentialTextfield]);
                    rawImport.ProviderEnumerationDate = DataHelper.ParseString(dataRow.ItemArray[providerEnumerationDatefield]);
                    rawImport.ProviderFirstLineBusinessMailingAddress = DataHelper.ParseString(dataRow.ItemArray[providerFirstLineBusinessMailingAddressfield]);
                    rawImport.ProviderFirstLineBusinessPracticeLocationAddress = DataHelper.ParseString(dataRow.ItemArray[providerFirstLineBusinessPracticeLocationAddressfield]);
                    rawImport.ProviderFirstName = DataHelper.ParseString(dataRow.ItemArray[providerFirstNamefield]);
                    rawImport.ProviderGenderCode = DataHelper.ParseString(dataRow.ItemArray[providerGenderCodefield]);
                    rawImport.ProviderLastNameLegalName = DataHelper.ParseString(dataRow.ItemArray[providerLastNameLegalNamefield]);
                    rawImport.ProviderLicenseNumber1 = DataHelper.ParseString(dataRow.ItemArray[providerLicenseNumber1field]);
                    rawImport.ProviderLicenseNumber10 = DataHelper.ParseString(dataRow.ItemArray[providerLicenseNumber10field]);
                    rawImport.ProviderLicenseNumber11 = DataHelper.ParseString(dataRow.ItemArray[providerLicenseNumber11field]);
                    rawImport.ProviderLicenseNumber12 = DataHelper.ParseString(dataRow.ItemArray[providerLicenseNumber12field]);
                    rawImport.ProviderLicenseNumber13 = DataHelper.ParseString(dataRow.ItemArray[providerLicenseNumber13field]);
                    rawImport.ProviderLicenseNumber14 = DataHelper.ParseString(dataRow.ItemArray[providerLicenseNumber14field]);
                    rawImport.ProviderLicenseNumber15 = DataHelper.ParseString(dataRow.ItemArray[providerLicenseNumber15field]);
                    rawImport.ProviderLicenseNumber2 = DataHelper.ParseString(dataRow.ItemArray[providerLicenseNumber2field]);
                    rawImport.ProviderLicenseNumber3 = DataHelper.ParseString(dataRow.ItemArray[providerLicenseNumber3field]);
                    rawImport.ProviderLicenseNumber4 = DataHelper.ParseString(dataRow.ItemArray[providerLicenseNumber4field]);
                    rawImport.ProviderLicenseNumber5 = DataHelper.ParseString(dataRow.ItemArray[providerLicenseNumber5field]);
                    rawImport.ProviderLicenseNumber6 = DataHelper.ParseString(dataRow.ItemArray[providerLicenseNumber6field]);
                    rawImport.ProviderLicenseNumber7 = DataHelper.ParseString(dataRow.ItemArray[providerLicenseNumber7field]);
                    rawImport.ProviderLicenseNumber8 = DataHelper.ParseString(dataRow.ItemArray[providerLicenseNumber8field]);
                    rawImport.ProviderLicenseNumber9 = DataHelper.ParseString(dataRow.ItemArray[providerLicenseNumber9field]);
                    rawImport.ProviderLicenseNumberStateCode1 = DataHelper.ParseString(dataRow.ItemArray[providerLicenseNumberStateCode1field]);
                    rawImport.ProviderLicenseNumberStateCode10 = DataHelper.ParseString(dataRow.ItemArray[providerLicenseNumberStateCode10field]);
                    rawImport.ProviderLicenseNumberStateCode11 = DataHelper.ParseString(dataRow.ItemArray[providerLicenseNumberStateCode11field]);
                    rawImport.ProviderLicenseNumberStateCode12 = DataHelper.ParseString(dataRow.ItemArray[providerLicenseNumberStateCode12field]);
                    rawImport.ProviderLicenseNumberStateCode13 = DataHelper.ParseString(dataRow.ItemArray[providerLicenseNumberStateCode13field]);
                    rawImport.ProviderLicenseNumberStateCode14 = DataHelper.ParseString(dataRow.ItemArray[providerLicenseNumberStateCode14field]);
                    rawImport.ProviderLicenseNumberStateCode15 = DataHelper.ParseString(dataRow.ItemArray[providerLicenseNumberStateCode15field]);
                    rawImport.ProviderLicenseNumberStateCode2 = DataHelper.ParseString(dataRow.ItemArray[providerLicenseNumberStateCode2field]);
                    rawImport.ProviderLicenseNumberStateCode3 = DataHelper.ParseString(dataRow.ItemArray[providerLicenseNumberStateCode3field]);
                    rawImport.ProviderLicenseNumberStateCode4 = DataHelper.ParseString(dataRow.ItemArray[providerLicenseNumberStateCode4field]);
                    rawImport.ProviderLicenseNumberStateCode5 = DataHelper.ParseString(dataRow.ItemArray[providerLicenseNumberStateCode5field]);
                    rawImport.ProviderLicenseNumberStateCode6 = DataHelper.ParseString(dataRow.ItemArray[providerLicenseNumberStateCode6field]);
                    rawImport.ProviderLicenseNumberStateCode7 = DataHelper.ParseString(dataRow.ItemArray[providerLicenseNumberStateCode7field]);
                    rawImport.ProviderLicenseNumberStateCode8 = DataHelper.ParseString(dataRow.ItemArray[providerLicenseNumberStateCode8field]);
                    rawImport.ProviderLicenseNumberStateCode9 = DataHelper.ParseString(dataRow.ItemArray[providerLicenseNumberStateCode9field]);
                    rawImport.ProviderMiddleName = DataHelper.ParseString(dataRow.ItemArray[providerMiddleNamefield]);
                    rawImport.ProviderNamePrefixText = DataHelper.ParseString(dataRow.ItemArray[providerNamePrefixTextfield]);
                    rawImport.ProviderNameSuffixText = DataHelper.ParseString(dataRow.ItemArray[providerNameSuffixTextfield]);
                    rawImport.ProviderOrganizationNameLegalBusinessName = DataHelper.ParseString(dataRow.ItemArray[providerOrganizationNameLegalBusinessNamefield]);
                    rawImport.ProviderOtherCredentialText = DataHelper.ParseString(dataRow.ItemArray[providerOtherCredentialTextfield]);
                    rawImport.ProviderOtherFirstName = DataHelper.ParseString(dataRow.ItemArray[providerOtherFirstNamefield]);
                    rawImport.ProviderOtherLastName = DataHelper.ParseString(dataRow.ItemArray[providerOtherLastNamefield]);
                    rawImport.ProviderOtherLastNameTypeCode = DataHelper.ParseString(dataRow.ItemArray[providerOtherLastNameTypeCodefield]);
                    rawImport.ProviderOtherMiddleName = DataHelper.ParseString(dataRow.ItemArray[providerOtherMiddleNamefield]);
                    rawImport.ProviderOtherNamePrefixText = DataHelper.ParseString(dataRow.ItemArray[providerOtherNamePrefixTextfield]);
                    rawImport.ProviderOtherNameSuffixText = DataHelper.ParseString(dataRow.ItemArray[providerOtherNameSuffixTextfield]);
                    rawImport.ProviderOtherOrganizationName = DataHelper.ParseString(dataRow.ItemArray[providerOtherOrganizationNamefield]);
                    rawImport.ProviderOtherOrganizationNameTypeCode = DataHelper.ParseString(dataRow.ItemArray[providerOtherOrganizationNameTypeCodefield]);
                    rawImport.ProviderSecondLineBusinessMailingAddress = DataHelper.ParseString(dataRow.ItemArray[providerSecondLineBusinessMailingAddressfield]);
                    rawImport.ProviderSecondLineBusinessPracticeLocationAddress = DataHelper.ParseString(dataRow.ItemArray[providerSecondLineBusinessPracticeLocationAddressfield]);
                    rawImport.ReplacementNPI = DataHelper.ParseString(dataRow.ItemArray[replacementNPIfield]);
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
