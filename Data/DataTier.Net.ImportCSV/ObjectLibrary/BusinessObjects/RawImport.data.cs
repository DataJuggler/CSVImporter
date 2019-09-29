

#region using statements

using System;

#endregion


namespace ObjectLibrary.BusinessObjects
{

    #region class RawImport
    public partial class RawImport
    {

        #region Private Variables
        private string authorizedOfficialCredentialText;
        private string authorizedOfficialFirstName;
        private string authorizedOfficialLastName;
        private string authorizedOfficialMiddleName;
        private string authorizedOfficialNamePrefixText;
        private string authorizedOfficialNameSuffixText;
        private string authorizedOfficialTelephoneNumber;
        private string authorizedOfficialTitleorPosition;
        private string employerIdentificationNumberEIN;
        private string entityTypeCode;
        private string healthcareProviderPrimaryTaxonomySwitch1;
        private string healthcareProviderPrimaryTaxonomySwitch10;
        private string healthcareProviderPrimaryTaxonomySwitch11;
        private string healthcareProviderPrimaryTaxonomySwitch12;
        private string healthcareProviderPrimaryTaxonomySwitch13;
        private string healthcareProviderPrimaryTaxonomySwitch14;
        private string healthcareProviderPrimaryTaxonomySwitch15;
        private string healthcareProviderPrimaryTaxonomySwitch2;
        private string healthcareProviderPrimaryTaxonomySwitch3;
        private string healthcareProviderPrimaryTaxonomySwitch4;
        private string healthcareProviderPrimaryTaxonomySwitch5;
        private string healthcareProviderPrimaryTaxonomySwitch6;
        private string healthcareProviderPrimaryTaxonomySwitch7;
        private string healthcareProviderPrimaryTaxonomySwitch8;
        private string healthcareProviderPrimaryTaxonomySwitch9;
        private string healthcareProviderTaxonomyCode1;
        private string healthcareProviderTaxonomyCode10;
        private string healthcareProviderTaxonomyCode11;
        private string healthcareProviderTaxonomyCode12;
        private string healthcareProviderTaxonomyCode13;
        private string healthcareProviderTaxonomyCode14;
        private string healthcareProviderTaxonomyCode15;
        private string healthcareProviderTaxonomyCode2;
        private string healthcareProviderTaxonomyCode3;
        private string healthcareProviderTaxonomyCode4;
        private string healthcareProviderTaxonomyCode5;
        private string healthcareProviderTaxonomyCode6;
        private string healthcareProviderTaxonomyCode7;
        private string healthcareProviderTaxonomyCode8;
        private string healthcareProviderTaxonomyCode9;
        private string healthcareProviderTaxonomyGroup1;
        private string healthcareProviderTaxonomyGroup10;
        private string healthcareProviderTaxonomyGroup11;
        private string healthcareProviderTaxonomyGroup12;
        private string healthcareProviderTaxonomyGroup13;
        private string healthcareProviderTaxonomyGroup14;
        private string healthcareProviderTaxonomyGroup15;
        private string healthcareProviderTaxonomyGroup2;
        private string healthcareProviderTaxonomyGroup3;
        private string healthcareProviderTaxonomyGroup4;
        private string healthcareProviderTaxonomyGroup5;
        private string healthcareProviderTaxonomyGroup6;
        private string healthcareProviderTaxonomyGroup7;
        private string healthcareProviderTaxonomyGroup8;
        private string healthcareProviderTaxonomyGroup9;
        private int id;
        private string isOrganizationSubpart;
        private string isSoleProprietor;
        private string lastUpdateDate;
        private string nPI;
        private string nPIDeactivationDate;
        private string nPIDeactivationReasonCode;
        private string nPIReactivationDate;
        private string otherProviderIdentifier1;
        private string otherProviderIdentifier10;
        private string otherProviderIdentifier11;
        private string otherProviderIdentifier12;
        private string otherProviderIdentifier13;
        private string otherProviderIdentifier14;
        private string otherProviderIdentifier15;
        private string otherProviderIdentifier16;
        private string otherProviderIdentifier17;
        private string otherProviderIdentifier18;
        private string otherProviderIdentifier19;
        private string otherProviderIdentifier2;
        private string otherProviderIdentifier20;
        private string otherProviderIdentifier21;
        private string otherProviderIdentifier22;
        private string otherProviderIdentifier23;
        private string otherProviderIdentifier24;
        private string otherProviderIdentifier25;
        private string otherProviderIdentifier26;
        private string otherProviderIdentifier27;
        private string otherProviderIdentifier28;
        private string otherProviderIdentifier29;
        private string otherProviderIdentifier3;
        private string otherProviderIdentifier30;
        private string otherProviderIdentifier31;
        private string otherProviderIdentifier32;
        private string otherProviderIdentifier33;
        private string otherProviderIdentifier34;
        private string otherProviderIdentifier35;
        private string otherProviderIdentifier36;
        private string otherProviderIdentifier37;
        private string otherProviderIdentifier38;
        private string otherProviderIdentifier39;
        private string otherProviderIdentifier4;
        private string otherProviderIdentifier40;
        private string otherProviderIdentifier41;
        private string otherProviderIdentifier42;
        private string otherProviderIdentifier43;
        private string otherProviderIdentifier44;
        private string otherProviderIdentifier45;
        private string otherProviderIdentifier46;
        private string otherProviderIdentifier47;
        private string otherProviderIdentifier48;
        private string otherProviderIdentifier49;
        private string otherProviderIdentifier5;
        private string otherProviderIdentifier50;
        private string otherProviderIdentifier6;
        private string otherProviderIdentifier7;
        private string otherProviderIdentifier8;
        private string otherProviderIdentifier9;
        private string otherProviderIdentifierIssuer1;
        private string otherProviderIdentifierIssuer10;
        private string otherProviderIdentifierIssuer11;
        private string otherProviderIdentifierIssuer12;
        private string otherProviderIdentifierIssuer13;
        private string otherProviderIdentifierIssuer14;
        private string otherProviderIdentifierIssuer15;
        private string otherProviderIdentifierIssuer16;
        private string otherProviderIdentifierIssuer17;
        private string otherProviderIdentifierIssuer18;
        private string otherProviderIdentifierIssuer19;
        private string otherProviderIdentifierIssuer2;
        private string otherProviderIdentifierIssuer20;
        private string otherProviderIdentifierIssuer21;
        private string otherProviderIdentifierIssuer22;
        private string otherProviderIdentifierIssuer23;
        private string otherProviderIdentifierIssuer24;
        private string otherProviderIdentifierIssuer25;
        private string otherProviderIdentifierIssuer26;
        private string otherProviderIdentifierIssuer27;
        private string otherProviderIdentifierIssuer28;
        private string otherProviderIdentifierIssuer29;
        private string otherProviderIdentifierIssuer3;
        private string otherProviderIdentifierIssuer30;
        private string otherProviderIdentifierIssuer31;
        private string otherProviderIdentifierIssuer32;
        private string otherProviderIdentifierIssuer33;
        private string otherProviderIdentifierIssuer34;
        private string otherProviderIdentifierIssuer35;
        private string otherProviderIdentifierIssuer36;
        private string otherProviderIdentifierIssuer37;
        private string otherProviderIdentifierIssuer38;
        private string otherProviderIdentifierIssuer39;
        private string otherProviderIdentifierIssuer4;
        private string otherProviderIdentifierIssuer40;
        private string otherProviderIdentifierIssuer41;
        private string otherProviderIdentifierIssuer42;
        private string otherProviderIdentifierIssuer43;
        private string otherProviderIdentifierIssuer44;
        private string otherProviderIdentifierIssuer45;
        private string otherProviderIdentifierIssuer46;
        private string otherProviderIdentifierIssuer47;
        private string otherProviderIdentifierIssuer48;
        private string otherProviderIdentifierIssuer49;
        private string otherProviderIdentifierIssuer5;
        private string otherProviderIdentifierIssuer50;
        private string otherProviderIdentifierIssuer6;
        private string otherProviderIdentifierIssuer7;
        private string otherProviderIdentifierIssuer8;
        private string otherProviderIdentifierIssuer9;
        private string otherProviderIdentifierState1;
        private string otherProviderIdentifierState10;
        private string otherProviderIdentifierState11;
        private string otherProviderIdentifierState12;
        private string otherProviderIdentifierState13;
        private string otherProviderIdentifierState14;
        private string otherProviderIdentifierState15;
        private string otherProviderIdentifierState16;
        private string otherProviderIdentifierState17;
        private string otherProviderIdentifierState18;
        private string otherProviderIdentifierState19;
        private string otherProviderIdentifierState2;
        private string otherProviderIdentifierState20;
        private string otherProviderIdentifierState21;
        private string otherProviderIdentifierState22;
        private string otherProviderIdentifierState23;
        private string otherProviderIdentifierState24;
        private string otherProviderIdentifierState25;
        private string otherProviderIdentifierState26;
        private string otherProviderIdentifierState27;
        private string otherProviderIdentifierState28;
        private string otherProviderIdentifierState29;
        private string otherProviderIdentifierState3;
        private string otherProviderIdentifierState30;
        private string otherProviderIdentifierState31;
        private string otherProviderIdentifierState32;
        private string otherProviderIdentifierState33;
        private string otherProviderIdentifierState34;
        private string otherProviderIdentifierState35;
        private string otherProviderIdentifierState36;
        private string otherProviderIdentifierState37;
        private string otherProviderIdentifierState38;
        private string otherProviderIdentifierState39;
        private string otherProviderIdentifierState4;
        private string otherProviderIdentifierState40;
        private string otherProviderIdentifierState41;
        private string otherProviderIdentifierState42;
        private string otherProviderIdentifierState43;
        private string otherProviderIdentifierState44;
        private string otherProviderIdentifierState45;
        private string otherProviderIdentifierState46;
        private string otherProviderIdentifierState47;
        private string otherProviderIdentifierState48;
        private string otherProviderIdentifierState49;
        private string otherProviderIdentifierState5;
        private string otherProviderIdentifierState50;
        private string otherProviderIdentifierState6;
        private string otherProviderIdentifierState7;
        private string otherProviderIdentifierState8;
        private string otherProviderIdentifierState9;
        private string otherProviderIdentifierTypeCode1;
        private string otherProviderIdentifierTypeCode10;
        private string otherProviderIdentifierTypeCode11;
        private string otherProviderIdentifierTypeCode12;
        private string otherProviderIdentifierTypeCode13;
        private string otherProviderIdentifierTypeCode14;
        private string otherProviderIdentifierTypeCode15;
        private string otherProviderIdentifierTypeCode16;
        private string otherProviderIdentifierTypeCode17;
        private string otherProviderIdentifierTypeCode18;
        private string otherProviderIdentifierTypeCode19;
        private string otherProviderIdentifierTypeCode2;
        private string otherProviderIdentifierTypeCode20;
        private string otherProviderIdentifierTypeCode21;
        private string otherProviderIdentifierTypeCode22;
        private string otherProviderIdentifierTypeCode23;
        private string otherProviderIdentifierTypeCode24;
        private string otherProviderIdentifierTypeCode25;
        private string otherProviderIdentifierTypeCode26;
        private string otherProviderIdentifierTypeCode27;
        private string otherProviderIdentifierTypeCode28;
        private string otherProviderIdentifierTypeCode29;
        private string otherProviderIdentifierTypeCode3;
        private string otherProviderIdentifierTypeCode30;
        private string otherProviderIdentifierTypeCode31;
        private string otherProviderIdentifierTypeCode32;
        private string otherProviderIdentifierTypeCode33;
        private string otherProviderIdentifierTypeCode34;
        private string otherProviderIdentifierTypeCode35;
        private string otherProviderIdentifierTypeCode36;
        private string otherProviderIdentifierTypeCode37;
        private string otherProviderIdentifierTypeCode38;
        private string otherProviderIdentifierTypeCode39;
        private string otherProviderIdentifierTypeCode4;
        private string otherProviderIdentifierTypeCode40;
        private string otherProviderIdentifierTypeCode41;
        private string otherProviderIdentifierTypeCode42;
        private string otherProviderIdentifierTypeCode43;
        private string otherProviderIdentifierTypeCode44;
        private string otherProviderIdentifierTypeCode45;
        private string otherProviderIdentifierTypeCode46;
        private string otherProviderIdentifierTypeCode47;
        private string otherProviderIdentifierTypeCode48;
        private string otherProviderIdentifierTypeCode49;
        private string otherProviderIdentifierTypeCode5;
        private string otherProviderIdentifierTypeCode50;
        private string otherProviderIdentifierTypeCode6;
        private string otherProviderIdentifierTypeCode7;
        private string otherProviderIdentifierTypeCode8;
        private string otherProviderIdentifierTypeCode9;
        private string parentOrganizationLBN;
        private string parentOrganizationTIN;
        private string providerBusinessMailingAddressCityName;
        private string providerBusinessMailingAddressCountryCodeIfoutsideUS;
        private string providerBusinessMailingAddressFaxNumber;
        private string providerBusinessMailingAddressPostalCode;
        private string providerBusinessMailingAddressStateName;
        private string providerBusinessMailingAddressTelephoneNumber;
        private string providerBusinessPracticeLocationAddressCityName;
        private string providerBusinessPracticeLocationAddressCountryCodeIfoutsideUS;
        private string providerBusinessPracticeLocationAddressFaxNumber;
        private string providerBusinessPracticeLocationAddressPostalCode;
        private string providerBusinessPracticeLocationAddressStateName;
        private string providerBusinessPracticeLocationAddressTelephoneNumber;
        private string providerCredentialText;
        private string providerEnumerationDate;
        private string providerFirstLineBusinessMailingAddress;
        private string providerFirstLineBusinessPracticeLocationAddress;
        private string providerFirstName;
        private string providerGenderCode;
        private string providerLastNameLegalName;
        private string providerLicenseNumber1;
        private string providerLicenseNumber10;
        private string providerLicenseNumber11;
        private string providerLicenseNumber12;
        private string providerLicenseNumber13;
        private string providerLicenseNumber14;
        private string providerLicenseNumber15;
        private string providerLicenseNumber2;
        private string providerLicenseNumber3;
        private string providerLicenseNumber4;
        private string providerLicenseNumber5;
        private string providerLicenseNumber6;
        private string providerLicenseNumber7;
        private string providerLicenseNumber8;
        private string providerLicenseNumber9;
        private string providerLicenseNumberStateCode1;
        private string providerLicenseNumberStateCode10;
        private string providerLicenseNumberStateCode11;
        private string providerLicenseNumberStateCode12;
        private string providerLicenseNumberStateCode13;
        private string providerLicenseNumberStateCode14;
        private string providerLicenseNumberStateCode15;
        private string providerLicenseNumberStateCode2;
        private string providerLicenseNumberStateCode3;
        private string providerLicenseNumberStateCode4;
        private string providerLicenseNumberStateCode5;
        private string providerLicenseNumberStateCode6;
        private string providerLicenseNumberStateCode7;
        private string providerLicenseNumberStateCode8;
        private string providerLicenseNumberStateCode9;
        private string providerMiddleName;
        private string providerNamePrefixText;
        private string providerNameSuffixText;
        private string providerOrganizationNameLegalBusinessName;
        private string providerOtherCredentialText;
        private string providerOtherFirstName;
        private string providerOtherLastName;
        private string providerOtherLastNameTypeCode;
        private string providerOtherMiddleName;
        private string providerOtherNamePrefixText;
        private string providerOtherNameSuffixText;
        private string providerOtherOrganizationName;
        private string providerOtherOrganizationNameTypeCode;
        private string providerSecondLineBusinessMailingAddress;
        private string providerSecondLineBusinessPracticeLocationAddress;
        private string replacementNPI;
        #endregion

        #region Methods

            #region UpdateIdentity(int id)
            // <summary>
            // This method provides a 'setter'
            // functionality for the Identity field.
            // </summary>
            public void UpdateIdentity(int id)
            {
                // Update The Identity field
                this.id = id;
            }
            #endregion

        #endregion

        #region Properties

            #region string AuthorizedOfficialCredentialText
            public string AuthorizedOfficialCredentialText
            {
                get
                {
                    return authorizedOfficialCredentialText;
                }
                set
                {
                    authorizedOfficialCredentialText = value;
                }
            }
            #endregion

            #region string AuthorizedOfficialFirstName
            public string AuthorizedOfficialFirstName
            {
                get
                {
                    return authorizedOfficialFirstName;
                }
                set
                {
                    authorizedOfficialFirstName = value;
                }
            }
            #endregion

            #region string AuthorizedOfficialLastName
            public string AuthorizedOfficialLastName
            {
                get
                {
                    return authorizedOfficialLastName;
                }
                set
                {
                    authorizedOfficialLastName = value;
                }
            }
            #endregion

            #region string AuthorizedOfficialMiddleName
            public string AuthorizedOfficialMiddleName
            {
                get
                {
                    return authorizedOfficialMiddleName;
                }
                set
                {
                    authorizedOfficialMiddleName = value;
                }
            }
            #endregion

            #region string AuthorizedOfficialNamePrefixText
            public string AuthorizedOfficialNamePrefixText
            {
                get
                {
                    return authorizedOfficialNamePrefixText;
                }
                set
                {
                    authorizedOfficialNamePrefixText = value;
                }
            }
            #endregion

            #region string AuthorizedOfficialNameSuffixText
            public string AuthorizedOfficialNameSuffixText
            {
                get
                {
                    return authorizedOfficialNameSuffixText;
                }
                set
                {
                    authorizedOfficialNameSuffixText = value;
                }
            }
            #endregion

            #region string AuthorizedOfficialTelephoneNumber
            public string AuthorizedOfficialTelephoneNumber
            {
                get
                {
                    return authorizedOfficialTelephoneNumber;
                }
                set
                {
                    authorizedOfficialTelephoneNumber = value;
                }
            }
            #endregion

            #region string AuthorizedOfficialTitleorPosition
            public string AuthorizedOfficialTitleorPosition
            {
                get
                {
                    return authorizedOfficialTitleorPosition;
                }
                set
                {
                    authorizedOfficialTitleorPosition = value;
                }
            }
            #endregion

            #region string EmployerIdentificationNumberEIN
            public string EmployerIdentificationNumberEIN
            {
                get
                {
                    return employerIdentificationNumberEIN;
                }
                set
                {
                    employerIdentificationNumberEIN = value;
                }
            }
            #endregion

            #region string EntityTypeCode
            public string EntityTypeCode
            {
                get
                {
                    return entityTypeCode;
                }
                set
                {
                    entityTypeCode = value;
                }
            }
            #endregion

            #region string HealthcareProviderPrimaryTaxonomySwitch1
            public string HealthcareProviderPrimaryTaxonomySwitch1
            {
                get
                {
                    return healthcareProviderPrimaryTaxonomySwitch1;
                }
                set
                {
                    healthcareProviderPrimaryTaxonomySwitch1 = value;
                }
            }
            #endregion

            #region string HealthcareProviderPrimaryTaxonomySwitch10
            public string HealthcareProviderPrimaryTaxonomySwitch10
            {
                get
                {
                    return healthcareProviderPrimaryTaxonomySwitch10;
                }
                set
                {
                    healthcareProviderPrimaryTaxonomySwitch10 = value;
                }
            }
            #endregion

            #region string HealthcareProviderPrimaryTaxonomySwitch11
            public string HealthcareProviderPrimaryTaxonomySwitch11
            {
                get
                {
                    return healthcareProviderPrimaryTaxonomySwitch11;
                }
                set
                {
                    healthcareProviderPrimaryTaxonomySwitch11 = value;
                }
            }
            #endregion

            #region string HealthcareProviderPrimaryTaxonomySwitch12
            public string HealthcareProviderPrimaryTaxonomySwitch12
            {
                get
                {
                    return healthcareProviderPrimaryTaxonomySwitch12;
                }
                set
                {
                    healthcareProviderPrimaryTaxonomySwitch12 = value;
                }
            }
            #endregion

            #region string HealthcareProviderPrimaryTaxonomySwitch13
            public string HealthcareProviderPrimaryTaxonomySwitch13
            {
                get
                {
                    return healthcareProviderPrimaryTaxonomySwitch13;
                }
                set
                {
                    healthcareProviderPrimaryTaxonomySwitch13 = value;
                }
            }
            #endregion

            #region string HealthcareProviderPrimaryTaxonomySwitch14
            public string HealthcareProviderPrimaryTaxonomySwitch14
            {
                get
                {
                    return healthcareProviderPrimaryTaxonomySwitch14;
                }
                set
                {
                    healthcareProviderPrimaryTaxonomySwitch14 = value;
                }
            }
            #endregion

            #region string HealthcareProviderPrimaryTaxonomySwitch15
            public string HealthcareProviderPrimaryTaxonomySwitch15
            {
                get
                {
                    return healthcareProviderPrimaryTaxonomySwitch15;
                }
                set
                {
                    healthcareProviderPrimaryTaxonomySwitch15 = value;
                }
            }
            #endregion

            #region string HealthcareProviderPrimaryTaxonomySwitch2
            public string HealthcareProviderPrimaryTaxonomySwitch2
            {
                get
                {
                    return healthcareProviderPrimaryTaxonomySwitch2;
                }
                set
                {
                    healthcareProviderPrimaryTaxonomySwitch2 = value;
                }
            }
            #endregion

            #region string HealthcareProviderPrimaryTaxonomySwitch3
            public string HealthcareProviderPrimaryTaxonomySwitch3
            {
                get
                {
                    return healthcareProviderPrimaryTaxonomySwitch3;
                }
                set
                {
                    healthcareProviderPrimaryTaxonomySwitch3 = value;
                }
            }
            #endregion

            #region string HealthcareProviderPrimaryTaxonomySwitch4
            public string HealthcareProviderPrimaryTaxonomySwitch4
            {
                get
                {
                    return healthcareProviderPrimaryTaxonomySwitch4;
                }
                set
                {
                    healthcareProviderPrimaryTaxonomySwitch4 = value;
                }
            }
            #endregion

            #region string HealthcareProviderPrimaryTaxonomySwitch5
            public string HealthcareProviderPrimaryTaxonomySwitch5
            {
                get
                {
                    return healthcareProviderPrimaryTaxonomySwitch5;
                }
                set
                {
                    healthcareProviderPrimaryTaxonomySwitch5 = value;
                }
            }
            #endregion

            #region string HealthcareProviderPrimaryTaxonomySwitch6
            public string HealthcareProviderPrimaryTaxonomySwitch6
            {
                get
                {
                    return healthcareProviderPrimaryTaxonomySwitch6;
                }
                set
                {
                    healthcareProviderPrimaryTaxonomySwitch6 = value;
                }
            }
            #endregion

            #region string HealthcareProviderPrimaryTaxonomySwitch7
            public string HealthcareProviderPrimaryTaxonomySwitch7
            {
                get
                {
                    return healthcareProviderPrimaryTaxonomySwitch7;
                }
                set
                {
                    healthcareProviderPrimaryTaxonomySwitch7 = value;
                }
            }
            #endregion

            #region string HealthcareProviderPrimaryTaxonomySwitch8
            public string HealthcareProviderPrimaryTaxonomySwitch8
            {
                get
                {
                    return healthcareProviderPrimaryTaxonomySwitch8;
                }
                set
                {
                    healthcareProviderPrimaryTaxonomySwitch8 = value;
                }
            }
            #endregion

            #region string HealthcareProviderPrimaryTaxonomySwitch9
            public string HealthcareProviderPrimaryTaxonomySwitch9
            {
                get
                {
                    return healthcareProviderPrimaryTaxonomySwitch9;
                }
                set
                {
                    healthcareProviderPrimaryTaxonomySwitch9 = value;
                }
            }
            #endregion

            #region string HealthcareProviderTaxonomyCode1
            public string HealthcareProviderTaxonomyCode1
            {
                get
                {
                    return healthcareProviderTaxonomyCode1;
                }
                set
                {
                    healthcareProviderTaxonomyCode1 = value;
                }
            }
            #endregion

            #region string HealthcareProviderTaxonomyCode10
            public string HealthcareProviderTaxonomyCode10
            {
                get
                {
                    return healthcareProviderTaxonomyCode10;
                }
                set
                {
                    healthcareProviderTaxonomyCode10 = value;
                }
            }
            #endregion

            #region string HealthcareProviderTaxonomyCode11
            public string HealthcareProviderTaxonomyCode11
            {
                get
                {
                    return healthcareProviderTaxonomyCode11;
                }
                set
                {
                    healthcareProviderTaxonomyCode11 = value;
                }
            }
            #endregion

            #region string HealthcareProviderTaxonomyCode12
            public string HealthcareProviderTaxonomyCode12
            {
                get
                {
                    return healthcareProviderTaxonomyCode12;
                }
                set
                {
                    healthcareProviderTaxonomyCode12 = value;
                }
            }
            #endregion

            #region string HealthcareProviderTaxonomyCode13
            public string HealthcareProviderTaxonomyCode13
            {
                get
                {
                    return healthcareProviderTaxonomyCode13;
                }
                set
                {
                    healthcareProviderTaxonomyCode13 = value;
                }
            }
            #endregion

            #region string HealthcareProviderTaxonomyCode14
            public string HealthcareProviderTaxonomyCode14
            {
                get
                {
                    return healthcareProviderTaxonomyCode14;
                }
                set
                {
                    healthcareProviderTaxonomyCode14 = value;
                }
            }
            #endregion

            #region string HealthcareProviderTaxonomyCode15
            public string HealthcareProviderTaxonomyCode15
            {
                get
                {
                    return healthcareProviderTaxonomyCode15;
                }
                set
                {
                    healthcareProviderTaxonomyCode15 = value;
                }
            }
            #endregion

            #region string HealthcareProviderTaxonomyCode2
            public string HealthcareProviderTaxonomyCode2
            {
                get
                {
                    return healthcareProviderTaxonomyCode2;
                }
                set
                {
                    healthcareProviderTaxonomyCode2 = value;
                }
            }
            #endregion

            #region string HealthcareProviderTaxonomyCode3
            public string HealthcareProviderTaxonomyCode3
            {
                get
                {
                    return healthcareProviderTaxonomyCode3;
                }
                set
                {
                    healthcareProviderTaxonomyCode3 = value;
                }
            }
            #endregion

            #region string HealthcareProviderTaxonomyCode4
            public string HealthcareProviderTaxonomyCode4
            {
                get
                {
                    return healthcareProviderTaxonomyCode4;
                }
                set
                {
                    healthcareProviderTaxonomyCode4 = value;
                }
            }
            #endregion

            #region string HealthcareProviderTaxonomyCode5
            public string HealthcareProviderTaxonomyCode5
            {
                get
                {
                    return healthcareProviderTaxonomyCode5;
                }
                set
                {
                    healthcareProviderTaxonomyCode5 = value;
                }
            }
            #endregion

            #region string HealthcareProviderTaxonomyCode6
            public string HealthcareProviderTaxonomyCode6
            {
                get
                {
                    return healthcareProviderTaxonomyCode6;
                }
                set
                {
                    healthcareProviderTaxonomyCode6 = value;
                }
            }
            #endregion

            #region string HealthcareProviderTaxonomyCode7
            public string HealthcareProviderTaxonomyCode7
            {
                get
                {
                    return healthcareProviderTaxonomyCode7;
                }
                set
                {
                    healthcareProviderTaxonomyCode7 = value;
                }
            }
            #endregion

            #region string HealthcareProviderTaxonomyCode8
            public string HealthcareProviderTaxonomyCode8
            {
                get
                {
                    return healthcareProviderTaxonomyCode8;
                }
                set
                {
                    healthcareProviderTaxonomyCode8 = value;
                }
            }
            #endregion

            #region string HealthcareProviderTaxonomyCode9
            public string HealthcareProviderTaxonomyCode9
            {
                get
                {
                    return healthcareProviderTaxonomyCode9;
                }
                set
                {
                    healthcareProviderTaxonomyCode9 = value;
                }
            }
            #endregion

            #region string HealthcareProviderTaxonomyGroup1
            public string HealthcareProviderTaxonomyGroup1
            {
                get
                {
                    return healthcareProviderTaxonomyGroup1;
                }
                set
                {
                    healthcareProviderTaxonomyGroup1 = value;
                }
            }
            #endregion

            #region string HealthcareProviderTaxonomyGroup10
            public string HealthcareProviderTaxonomyGroup10
            {
                get
                {
                    return healthcareProviderTaxonomyGroup10;
                }
                set
                {
                    healthcareProviderTaxonomyGroup10 = value;
                }
            }
            #endregion

            #region string HealthcareProviderTaxonomyGroup11
            public string HealthcareProviderTaxonomyGroup11
            {
                get
                {
                    return healthcareProviderTaxonomyGroup11;
                }
                set
                {
                    healthcareProviderTaxonomyGroup11 = value;
                }
            }
            #endregion

            #region string HealthcareProviderTaxonomyGroup12
            public string HealthcareProviderTaxonomyGroup12
            {
                get
                {
                    return healthcareProviderTaxonomyGroup12;
                }
                set
                {
                    healthcareProviderTaxonomyGroup12 = value;
                }
            }
            #endregion

            #region string HealthcareProviderTaxonomyGroup13
            public string HealthcareProviderTaxonomyGroup13
            {
                get
                {
                    return healthcareProviderTaxonomyGroup13;
                }
                set
                {
                    healthcareProviderTaxonomyGroup13 = value;
                }
            }
            #endregion

            #region string HealthcareProviderTaxonomyGroup14
            public string HealthcareProviderTaxonomyGroup14
            {
                get
                {
                    return healthcareProviderTaxonomyGroup14;
                }
                set
                {
                    healthcareProviderTaxonomyGroup14 = value;
                }
            }
            #endregion

            #region string HealthcareProviderTaxonomyGroup15
            public string HealthcareProviderTaxonomyGroup15
            {
                get
                {
                    return healthcareProviderTaxonomyGroup15;
                }
                set
                {
                    healthcareProviderTaxonomyGroup15 = value;
                }
            }
            #endregion

            #region string HealthcareProviderTaxonomyGroup2
            public string HealthcareProviderTaxonomyGroup2
            {
                get
                {
                    return healthcareProviderTaxonomyGroup2;
                }
                set
                {
                    healthcareProviderTaxonomyGroup2 = value;
                }
            }
            #endregion

            #region string HealthcareProviderTaxonomyGroup3
            public string HealthcareProviderTaxonomyGroup3
            {
                get
                {
                    return healthcareProviderTaxonomyGroup3;
                }
                set
                {
                    healthcareProviderTaxonomyGroup3 = value;
                }
            }
            #endregion

            #region string HealthcareProviderTaxonomyGroup4
            public string HealthcareProviderTaxonomyGroup4
            {
                get
                {
                    return healthcareProviderTaxonomyGroup4;
                }
                set
                {
                    healthcareProviderTaxonomyGroup4 = value;
                }
            }
            #endregion

            #region string HealthcareProviderTaxonomyGroup5
            public string HealthcareProviderTaxonomyGroup5
            {
                get
                {
                    return healthcareProviderTaxonomyGroup5;
                }
                set
                {
                    healthcareProviderTaxonomyGroup5 = value;
                }
            }
            #endregion

            #region string HealthcareProviderTaxonomyGroup6
            public string HealthcareProviderTaxonomyGroup6
            {
                get
                {
                    return healthcareProviderTaxonomyGroup6;
                }
                set
                {
                    healthcareProviderTaxonomyGroup6 = value;
                }
            }
            #endregion

            #region string HealthcareProviderTaxonomyGroup7
            public string HealthcareProviderTaxonomyGroup7
            {
                get
                {
                    return healthcareProviderTaxonomyGroup7;
                }
                set
                {
                    healthcareProviderTaxonomyGroup7 = value;
                }
            }
            #endregion

            #region string HealthcareProviderTaxonomyGroup8
            public string HealthcareProviderTaxonomyGroup8
            {
                get
                {
                    return healthcareProviderTaxonomyGroup8;
                }
                set
                {
                    healthcareProviderTaxonomyGroup8 = value;
                }
            }
            #endregion

            #region string HealthcareProviderTaxonomyGroup9
            public string HealthcareProviderTaxonomyGroup9
            {
                get
                {
                    return healthcareProviderTaxonomyGroup9;
                }
                set
                {
                    healthcareProviderTaxonomyGroup9 = value;
                }
            }
            #endregion

            #region int Id
            public int Id
            {
                get
                {
                    return id;
                }
            }
            #endregion

            #region string IsOrganizationSubpart
            public string IsOrganizationSubpart
            {
                get
                {
                    return isOrganizationSubpart;
                }
                set
                {
                    isOrganizationSubpart = value;
                }
            }
            #endregion

            #region string IsSoleProprietor
            public string IsSoleProprietor
            {
                get
                {
                    return isSoleProprietor;
                }
                set
                {
                    isSoleProprietor = value;
                }
            }
            #endregion

            #region string LastUpdateDate
            public string LastUpdateDate
            {
                get
                {
                    return lastUpdateDate;
                }
                set
                {
                    lastUpdateDate = value;
                }
            }
            #endregion

            #region string NPI
            public string NPI
            {
                get
                {
                    return nPI;
                }
                set
                {
                    nPI = value;
                }
            }
            #endregion

            #region string NPIDeactivationDate
            public string NPIDeactivationDate
            {
                get
                {
                    return nPIDeactivationDate;
                }
                set
                {
                    nPIDeactivationDate = value;
                }
            }
            #endregion

            #region string NPIDeactivationReasonCode
            public string NPIDeactivationReasonCode
            {
                get
                {
                    return nPIDeactivationReasonCode;
                }
                set
                {
                    nPIDeactivationReasonCode = value;
                }
            }
            #endregion

            #region string NPIReactivationDate
            public string NPIReactivationDate
            {
                get
                {
                    return nPIReactivationDate;
                }
                set
                {
                    nPIReactivationDate = value;
                }
            }
            #endregion

            #region string OtherProviderIdentifier1
            public string OtherProviderIdentifier1
            {
                get
                {
                    return otherProviderIdentifier1;
                }
                set
                {
                    otherProviderIdentifier1 = value;
                }
            }
            #endregion

            #region string OtherProviderIdentifier10
            public string OtherProviderIdentifier10
            {
                get
                {
                    return otherProviderIdentifier10;
                }
                set
                {
                    otherProviderIdentifier10 = value;
                }
            }
            #endregion

            #region string OtherProviderIdentifier11
            public string OtherProviderIdentifier11
            {
                get
                {
                    return otherProviderIdentifier11;
                }
                set
                {
                    otherProviderIdentifier11 = value;
                }
            }
            #endregion

            #region string OtherProviderIdentifier12
            public string OtherProviderIdentifier12
            {
                get
                {
                    return otherProviderIdentifier12;
                }
                set
                {
                    otherProviderIdentifier12 = value;
                }
            }
            #endregion

            #region string OtherProviderIdentifier13
            public string OtherProviderIdentifier13
            {
                get
                {
                    return otherProviderIdentifier13;
                }
                set
                {
                    otherProviderIdentifier13 = value;
                }
            }
            #endregion

            #region string OtherProviderIdentifier14
            public string OtherProviderIdentifier14
            {
                get
                {
                    return otherProviderIdentifier14;
                }
                set
                {
                    otherProviderIdentifier14 = value;
                }
            }
            #endregion

            #region string OtherProviderIdentifier15
            public string OtherProviderIdentifier15
            {
                get
                {
                    return otherProviderIdentifier15;
                }
                set
                {
                    otherProviderIdentifier15 = value;
                }
            }
            #endregion

            #region string OtherProviderIdentifier16
            public string OtherProviderIdentifier16
            {
                get
                {
                    return otherProviderIdentifier16;
                }
                set
                {
                    otherProviderIdentifier16 = value;
                }
            }
            #endregion

            #region string OtherProviderIdentifier17
            public string OtherProviderIdentifier17
            {
                get
                {
                    return otherProviderIdentifier17;
                }
                set
                {
                    otherProviderIdentifier17 = value;
                }
            }
            #endregion

            #region string OtherProviderIdentifier18
            public string OtherProviderIdentifier18
            {
                get
                {
                    return otherProviderIdentifier18;
                }
                set
                {
                    otherProviderIdentifier18 = value;
                }
            }
            #endregion

            #region string OtherProviderIdentifier19
            public string OtherProviderIdentifier19
            {
                get
                {
                    return otherProviderIdentifier19;
                }
                set
                {
                    otherProviderIdentifier19 = value;
                }
            }
            #endregion

            #region string OtherProviderIdentifier2
            public string OtherProviderIdentifier2
            {
                get
                {
                    return otherProviderIdentifier2;
                }
                set
                {
                    otherProviderIdentifier2 = value;
                }
            }
            #endregion

            #region string OtherProviderIdentifier20
            public string OtherProviderIdentifier20
            {
                get
                {
                    return otherProviderIdentifier20;
                }
                set
                {
                    otherProviderIdentifier20 = value;
                }
            }
            #endregion

            #region string OtherProviderIdentifier21
            public string OtherProviderIdentifier21
            {
                get
                {
                    return otherProviderIdentifier21;
                }
                set
                {
                    otherProviderIdentifier21 = value;
                }
            }
            #endregion

            #region string OtherProviderIdentifier22
            public string OtherProviderIdentifier22
            {
                get
                {
                    return otherProviderIdentifier22;
                }
                set
                {
                    otherProviderIdentifier22 = value;
                }
            }
            #endregion

            #region string OtherProviderIdentifier23
            public string OtherProviderIdentifier23
            {
                get
                {
                    return otherProviderIdentifier23;
                }
                set
                {
                    otherProviderIdentifier23 = value;
                }
            }
            #endregion

            #region string OtherProviderIdentifier24
            public string OtherProviderIdentifier24
            {
                get
                {
                    return otherProviderIdentifier24;
                }
                set
                {
                    otherProviderIdentifier24 = value;
                }
            }
            #endregion

            #region string OtherProviderIdentifier25
            public string OtherProviderIdentifier25
            {
                get
                {
                    return otherProviderIdentifier25;
                }
                set
                {
                    otherProviderIdentifier25 = value;
                }
            }
            #endregion

            #region string OtherProviderIdentifier26
            public string OtherProviderIdentifier26
            {
                get
                {
                    return otherProviderIdentifier26;
                }
                set
                {
                    otherProviderIdentifier26 = value;
                }
            }
            #endregion

            #region string OtherProviderIdentifier27
            public string OtherProviderIdentifier27
            {
                get
                {
                    return otherProviderIdentifier27;
                }
                set
                {
                    otherProviderIdentifier27 = value;
                }
            }
            #endregion

            #region string OtherProviderIdentifier28
            public string OtherProviderIdentifier28
            {
                get
                {
                    return otherProviderIdentifier28;
                }
                set
                {
                    otherProviderIdentifier28 = value;
                }
            }
            #endregion

            #region string OtherProviderIdentifier29
            public string OtherProviderIdentifier29
            {
                get
                {
                    return otherProviderIdentifier29;
                }
                set
                {
                    otherProviderIdentifier29 = value;
                }
            }
            #endregion

            #region string OtherProviderIdentifier3
            public string OtherProviderIdentifier3
            {
                get
                {
                    return otherProviderIdentifier3;
                }
                set
                {
                    otherProviderIdentifier3 = value;
                }
            }
            #endregion

            #region string OtherProviderIdentifier30
            public string OtherProviderIdentifier30
            {
                get
                {
                    return otherProviderIdentifier30;
                }
                set
                {
                    otherProviderIdentifier30 = value;
                }
            }
            #endregion

            #region string OtherProviderIdentifier31
            public string OtherProviderIdentifier31
            {
                get
                {
                    return otherProviderIdentifier31;
                }
                set
                {
                    otherProviderIdentifier31 = value;
                }
            }
            #endregion

            #region string OtherProviderIdentifier32
            public string OtherProviderIdentifier32
            {
                get
                {
                    return otherProviderIdentifier32;
                }
                set
                {
                    otherProviderIdentifier32 = value;
                }
            }
            #endregion

            #region string OtherProviderIdentifier33
            public string OtherProviderIdentifier33
            {
                get
                {
                    return otherProviderIdentifier33;
                }
                set
                {
                    otherProviderIdentifier33 = value;
                }
            }
            #endregion

            #region string OtherProviderIdentifier34
            public string OtherProviderIdentifier34
            {
                get
                {
                    return otherProviderIdentifier34;
                }
                set
                {
                    otherProviderIdentifier34 = value;
                }
            }
            #endregion

            #region string OtherProviderIdentifier35
            public string OtherProviderIdentifier35
            {
                get
                {
                    return otherProviderIdentifier35;
                }
                set
                {
                    otherProviderIdentifier35 = value;
                }
            }
            #endregion

            #region string OtherProviderIdentifier36
            public string OtherProviderIdentifier36
            {
                get
                {
                    return otherProviderIdentifier36;
                }
                set
                {
                    otherProviderIdentifier36 = value;
                }
            }
            #endregion

            #region string OtherProviderIdentifier37
            public string OtherProviderIdentifier37
            {
                get
                {
                    return otherProviderIdentifier37;
                }
                set
                {
                    otherProviderIdentifier37 = value;
                }
            }
            #endregion

            #region string OtherProviderIdentifier38
            public string OtherProviderIdentifier38
            {
                get
                {
                    return otherProviderIdentifier38;
                }
                set
                {
                    otherProviderIdentifier38 = value;
                }
            }
            #endregion

            #region string OtherProviderIdentifier39
            public string OtherProviderIdentifier39
            {
                get
                {
                    return otherProviderIdentifier39;
                }
                set
                {
                    otherProviderIdentifier39 = value;
                }
            }
            #endregion

            #region string OtherProviderIdentifier4
            public string OtherProviderIdentifier4
            {
                get
                {
                    return otherProviderIdentifier4;
                }
                set
                {
                    otherProviderIdentifier4 = value;
                }
            }
            #endregion

            #region string OtherProviderIdentifier40
            public string OtherProviderIdentifier40
            {
                get
                {
                    return otherProviderIdentifier40;
                }
                set
                {
                    otherProviderIdentifier40 = value;
                }
            }
            #endregion

            #region string OtherProviderIdentifier41
            public string OtherProviderIdentifier41
            {
                get
                {
                    return otherProviderIdentifier41;
                }
                set
                {
                    otherProviderIdentifier41 = value;
                }
            }
            #endregion

            #region string OtherProviderIdentifier42
            public string OtherProviderIdentifier42
            {
                get
                {
                    return otherProviderIdentifier42;
                }
                set
                {
                    otherProviderIdentifier42 = value;
                }
            }
            #endregion

            #region string OtherProviderIdentifier43
            public string OtherProviderIdentifier43
            {
                get
                {
                    return otherProviderIdentifier43;
                }
                set
                {
                    otherProviderIdentifier43 = value;
                }
            }
            #endregion

            #region string OtherProviderIdentifier44
            public string OtherProviderIdentifier44
            {
                get
                {
                    return otherProviderIdentifier44;
                }
                set
                {
                    otherProviderIdentifier44 = value;
                }
            }
            #endregion

            #region string OtherProviderIdentifier45
            public string OtherProviderIdentifier45
            {
                get
                {
                    return otherProviderIdentifier45;
                }
                set
                {
                    otherProviderIdentifier45 = value;
                }
            }
            #endregion

            #region string OtherProviderIdentifier46
            public string OtherProviderIdentifier46
            {
                get
                {
                    return otherProviderIdentifier46;
                }
                set
                {
                    otherProviderIdentifier46 = value;
                }
            }
            #endregion

            #region string OtherProviderIdentifier47
            public string OtherProviderIdentifier47
            {
                get
                {
                    return otherProviderIdentifier47;
                }
                set
                {
                    otherProviderIdentifier47 = value;
                }
            }
            #endregion

            #region string OtherProviderIdentifier48
            public string OtherProviderIdentifier48
            {
                get
                {
                    return otherProviderIdentifier48;
                }
                set
                {
                    otherProviderIdentifier48 = value;
                }
            }
            #endregion

            #region string OtherProviderIdentifier49
            public string OtherProviderIdentifier49
            {
                get
                {
                    return otherProviderIdentifier49;
                }
                set
                {
                    otherProviderIdentifier49 = value;
                }
            }
            #endregion

            #region string OtherProviderIdentifier5
            public string OtherProviderIdentifier5
            {
                get
                {
                    return otherProviderIdentifier5;
                }
                set
                {
                    otherProviderIdentifier5 = value;
                }
            }
            #endregion

            #region string OtherProviderIdentifier50
            public string OtherProviderIdentifier50
            {
                get
                {
                    return otherProviderIdentifier50;
                }
                set
                {
                    otherProviderIdentifier50 = value;
                }
            }
            #endregion

            #region string OtherProviderIdentifier6
            public string OtherProviderIdentifier6
            {
                get
                {
                    return otherProviderIdentifier6;
                }
                set
                {
                    otherProviderIdentifier6 = value;
                }
            }
            #endregion

            #region string OtherProviderIdentifier7
            public string OtherProviderIdentifier7
            {
                get
                {
                    return otherProviderIdentifier7;
                }
                set
                {
                    otherProviderIdentifier7 = value;
                }
            }
            #endregion

            #region string OtherProviderIdentifier8
            public string OtherProviderIdentifier8
            {
                get
                {
                    return otherProviderIdentifier8;
                }
                set
                {
                    otherProviderIdentifier8 = value;
                }
            }
            #endregion

            #region string OtherProviderIdentifier9
            public string OtherProviderIdentifier9
            {
                get
                {
                    return otherProviderIdentifier9;
                }
                set
                {
                    otherProviderIdentifier9 = value;
                }
            }
            #endregion

            #region string OtherProviderIdentifierIssuer1
            public string OtherProviderIdentifierIssuer1
            {
                get
                {
                    return otherProviderIdentifierIssuer1;
                }
                set
                {
                    otherProviderIdentifierIssuer1 = value;
                }
            }
            #endregion

            #region string OtherProviderIdentifierIssuer10
            public string OtherProviderIdentifierIssuer10
            {
                get
                {
                    return otherProviderIdentifierIssuer10;
                }
                set
                {
                    otherProviderIdentifierIssuer10 = value;
                }
            }
            #endregion

            #region string OtherProviderIdentifierIssuer11
            public string OtherProviderIdentifierIssuer11
            {
                get
                {
                    return otherProviderIdentifierIssuer11;
                }
                set
                {
                    otherProviderIdentifierIssuer11 = value;
                }
            }
            #endregion

            #region string OtherProviderIdentifierIssuer12
            public string OtherProviderIdentifierIssuer12
            {
                get
                {
                    return otherProviderIdentifierIssuer12;
                }
                set
                {
                    otherProviderIdentifierIssuer12 = value;
                }
            }
            #endregion

            #region string OtherProviderIdentifierIssuer13
            public string OtherProviderIdentifierIssuer13
            {
                get
                {
                    return otherProviderIdentifierIssuer13;
                }
                set
                {
                    otherProviderIdentifierIssuer13 = value;
                }
            }
            #endregion

            #region string OtherProviderIdentifierIssuer14
            public string OtherProviderIdentifierIssuer14
            {
                get
                {
                    return otherProviderIdentifierIssuer14;
                }
                set
                {
                    otherProviderIdentifierIssuer14 = value;
                }
            }
            #endregion

            #region string OtherProviderIdentifierIssuer15
            public string OtherProviderIdentifierIssuer15
            {
                get
                {
                    return otherProviderIdentifierIssuer15;
                }
                set
                {
                    otherProviderIdentifierIssuer15 = value;
                }
            }
            #endregion

            #region string OtherProviderIdentifierIssuer16
            public string OtherProviderIdentifierIssuer16
            {
                get
                {
                    return otherProviderIdentifierIssuer16;
                }
                set
                {
                    otherProviderIdentifierIssuer16 = value;
                }
            }
            #endregion

            #region string OtherProviderIdentifierIssuer17
            public string OtherProviderIdentifierIssuer17
            {
                get
                {
                    return otherProviderIdentifierIssuer17;
                }
                set
                {
                    otherProviderIdentifierIssuer17 = value;
                }
            }
            #endregion

            #region string OtherProviderIdentifierIssuer18
            public string OtherProviderIdentifierIssuer18
            {
                get
                {
                    return otherProviderIdentifierIssuer18;
                }
                set
                {
                    otherProviderIdentifierIssuer18 = value;
                }
            }
            #endregion

            #region string OtherProviderIdentifierIssuer19
            public string OtherProviderIdentifierIssuer19
            {
                get
                {
                    return otherProviderIdentifierIssuer19;
                }
                set
                {
                    otherProviderIdentifierIssuer19 = value;
                }
            }
            #endregion

            #region string OtherProviderIdentifierIssuer2
            public string OtherProviderIdentifierIssuer2
            {
                get
                {
                    return otherProviderIdentifierIssuer2;
                }
                set
                {
                    otherProviderIdentifierIssuer2 = value;
                }
            }
            #endregion

            #region string OtherProviderIdentifierIssuer20
            public string OtherProviderIdentifierIssuer20
            {
                get
                {
                    return otherProviderIdentifierIssuer20;
                }
                set
                {
                    otherProviderIdentifierIssuer20 = value;
                }
            }
            #endregion

            #region string OtherProviderIdentifierIssuer21
            public string OtherProviderIdentifierIssuer21
            {
                get
                {
                    return otherProviderIdentifierIssuer21;
                }
                set
                {
                    otherProviderIdentifierIssuer21 = value;
                }
            }
            #endregion

            #region string OtherProviderIdentifierIssuer22
            public string OtherProviderIdentifierIssuer22
            {
                get
                {
                    return otherProviderIdentifierIssuer22;
                }
                set
                {
                    otherProviderIdentifierIssuer22 = value;
                }
            }
            #endregion

            #region string OtherProviderIdentifierIssuer23
            public string OtherProviderIdentifierIssuer23
            {
                get
                {
                    return otherProviderIdentifierIssuer23;
                }
                set
                {
                    otherProviderIdentifierIssuer23 = value;
                }
            }
            #endregion

            #region string OtherProviderIdentifierIssuer24
            public string OtherProviderIdentifierIssuer24
            {
                get
                {
                    return otherProviderIdentifierIssuer24;
                }
                set
                {
                    otherProviderIdentifierIssuer24 = value;
                }
            }
            #endregion

            #region string OtherProviderIdentifierIssuer25
            public string OtherProviderIdentifierIssuer25
            {
                get
                {
                    return otherProviderIdentifierIssuer25;
                }
                set
                {
                    otherProviderIdentifierIssuer25 = value;
                }
            }
            #endregion

            #region string OtherProviderIdentifierIssuer26
            public string OtherProviderIdentifierIssuer26
            {
                get
                {
                    return otherProviderIdentifierIssuer26;
                }
                set
                {
                    otherProviderIdentifierIssuer26 = value;
                }
            }
            #endregion

            #region string OtherProviderIdentifierIssuer27
            public string OtherProviderIdentifierIssuer27
            {
                get
                {
                    return otherProviderIdentifierIssuer27;
                }
                set
                {
                    otherProviderIdentifierIssuer27 = value;
                }
            }
            #endregion

            #region string OtherProviderIdentifierIssuer28
            public string OtherProviderIdentifierIssuer28
            {
                get
                {
                    return otherProviderIdentifierIssuer28;
                }
                set
                {
                    otherProviderIdentifierIssuer28 = value;
                }
            }
            #endregion

            #region string OtherProviderIdentifierIssuer29
            public string OtherProviderIdentifierIssuer29
            {
                get
                {
                    return otherProviderIdentifierIssuer29;
                }
                set
                {
                    otherProviderIdentifierIssuer29 = value;
                }
            }
            #endregion

            #region string OtherProviderIdentifierIssuer3
            public string OtherProviderIdentifierIssuer3
            {
                get
                {
                    return otherProviderIdentifierIssuer3;
                }
                set
                {
                    otherProviderIdentifierIssuer3 = value;
                }
            }
            #endregion

            #region string OtherProviderIdentifierIssuer30
            public string OtherProviderIdentifierIssuer30
            {
                get
                {
                    return otherProviderIdentifierIssuer30;
                }
                set
                {
                    otherProviderIdentifierIssuer30 = value;
                }
            }
            #endregion

            #region string OtherProviderIdentifierIssuer31
            public string OtherProviderIdentifierIssuer31
            {
                get
                {
                    return otherProviderIdentifierIssuer31;
                }
                set
                {
                    otherProviderIdentifierIssuer31 = value;
                }
            }
            #endregion

            #region string OtherProviderIdentifierIssuer32
            public string OtherProviderIdentifierIssuer32
            {
                get
                {
                    return otherProviderIdentifierIssuer32;
                }
                set
                {
                    otherProviderIdentifierIssuer32 = value;
                }
            }
            #endregion

            #region string OtherProviderIdentifierIssuer33
            public string OtherProviderIdentifierIssuer33
            {
                get
                {
                    return otherProviderIdentifierIssuer33;
                }
                set
                {
                    otherProviderIdentifierIssuer33 = value;
                }
            }
            #endregion

            #region string OtherProviderIdentifierIssuer34
            public string OtherProviderIdentifierIssuer34
            {
                get
                {
                    return otherProviderIdentifierIssuer34;
                }
                set
                {
                    otherProviderIdentifierIssuer34 = value;
                }
            }
            #endregion

            #region string OtherProviderIdentifierIssuer35
            public string OtherProviderIdentifierIssuer35
            {
                get
                {
                    return otherProviderIdentifierIssuer35;
                }
                set
                {
                    otherProviderIdentifierIssuer35 = value;
                }
            }
            #endregion

            #region string OtherProviderIdentifierIssuer36
            public string OtherProviderIdentifierIssuer36
            {
                get
                {
                    return otherProviderIdentifierIssuer36;
                }
                set
                {
                    otherProviderIdentifierIssuer36 = value;
                }
            }
            #endregion

            #region string OtherProviderIdentifierIssuer37
            public string OtherProviderIdentifierIssuer37
            {
                get
                {
                    return otherProviderIdentifierIssuer37;
                }
                set
                {
                    otherProviderIdentifierIssuer37 = value;
                }
            }
            #endregion

            #region string OtherProviderIdentifierIssuer38
            public string OtherProviderIdentifierIssuer38
            {
                get
                {
                    return otherProviderIdentifierIssuer38;
                }
                set
                {
                    otherProviderIdentifierIssuer38 = value;
                }
            }
            #endregion

            #region string OtherProviderIdentifierIssuer39
            public string OtherProviderIdentifierIssuer39
            {
                get
                {
                    return otherProviderIdentifierIssuer39;
                }
                set
                {
                    otherProviderIdentifierIssuer39 = value;
                }
            }
            #endregion

            #region string OtherProviderIdentifierIssuer4
            public string OtherProviderIdentifierIssuer4
            {
                get
                {
                    return otherProviderIdentifierIssuer4;
                }
                set
                {
                    otherProviderIdentifierIssuer4 = value;
                }
            }
            #endregion

            #region string OtherProviderIdentifierIssuer40
            public string OtherProviderIdentifierIssuer40
            {
                get
                {
                    return otherProviderIdentifierIssuer40;
                }
                set
                {
                    otherProviderIdentifierIssuer40 = value;
                }
            }
            #endregion

            #region string OtherProviderIdentifierIssuer41
            public string OtherProviderIdentifierIssuer41
            {
                get
                {
                    return otherProviderIdentifierIssuer41;
                }
                set
                {
                    otherProviderIdentifierIssuer41 = value;
                }
            }
            #endregion

            #region string OtherProviderIdentifierIssuer42
            public string OtherProviderIdentifierIssuer42
            {
                get
                {
                    return otherProviderIdentifierIssuer42;
                }
                set
                {
                    otherProviderIdentifierIssuer42 = value;
                }
            }
            #endregion

            #region string OtherProviderIdentifierIssuer43
            public string OtherProviderIdentifierIssuer43
            {
                get
                {
                    return otherProviderIdentifierIssuer43;
                }
                set
                {
                    otherProviderIdentifierIssuer43 = value;
                }
            }
            #endregion

            #region string OtherProviderIdentifierIssuer44
            public string OtherProviderIdentifierIssuer44
            {
                get
                {
                    return otherProviderIdentifierIssuer44;
                }
                set
                {
                    otherProviderIdentifierIssuer44 = value;
                }
            }
            #endregion

            #region string OtherProviderIdentifierIssuer45
            public string OtherProviderIdentifierIssuer45
            {
                get
                {
                    return otherProviderIdentifierIssuer45;
                }
                set
                {
                    otherProviderIdentifierIssuer45 = value;
                }
            }
            #endregion

            #region string OtherProviderIdentifierIssuer46
            public string OtherProviderIdentifierIssuer46
            {
                get
                {
                    return otherProviderIdentifierIssuer46;
                }
                set
                {
                    otherProviderIdentifierIssuer46 = value;
                }
            }
            #endregion

            #region string OtherProviderIdentifierIssuer47
            public string OtherProviderIdentifierIssuer47
            {
                get
                {
                    return otherProviderIdentifierIssuer47;
                }
                set
                {
                    otherProviderIdentifierIssuer47 = value;
                }
            }
            #endregion

            #region string OtherProviderIdentifierIssuer48
            public string OtherProviderIdentifierIssuer48
            {
                get
                {
                    return otherProviderIdentifierIssuer48;
                }
                set
                {
                    otherProviderIdentifierIssuer48 = value;
                }
            }
            #endregion

            #region string OtherProviderIdentifierIssuer49
            public string OtherProviderIdentifierIssuer49
            {
                get
                {
                    return otherProviderIdentifierIssuer49;
                }
                set
                {
                    otherProviderIdentifierIssuer49 = value;
                }
            }
            #endregion

            #region string OtherProviderIdentifierIssuer5
            public string OtherProviderIdentifierIssuer5
            {
                get
                {
                    return otherProviderIdentifierIssuer5;
                }
                set
                {
                    otherProviderIdentifierIssuer5 = value;
                }
            }
            #endregion

            #region string OtherProviderIdentifierIssuer50
            public string OtherProviderIdentifierIssuer50
            {
                get
                {
                    return otherProviderIdentifierIssuer50;
                }
                set
                {
                    otherProviderIdentifierIssuer50 = value;
                }
            }
            #endregion

            #region string OtherProviderIdentifierIssuer6
            public string OtherProviderIdentifierIssuer6
            {
                get
                {
                    return otherProviderIdentifierIssuer6;
                }
                set
                {
                    otherProviderIdentifierIssuer6 = value;
                }
            }
            #endregion

            #region string OtherProviderIdentifierIssuer7
            public string OtherProviderIdentifierIssuer7
            {
                get
                {
                    return otherProviderIdentifierIssuer7;
                }
                set
                {
                    otherProviderIdentifierIssuer7 = value;
                }
            }
            #endregion

            #region string OtherProviderIdentifierIssuer8
            public string OtherProviderIdentifierIssuer8
            {
                get
                {
                    return otherProviderIdentifierIssuer8;
                }
                set
                {
                    otherProviderIdentifierIssuer8 = value;
                }
            }
            #endregion

            #region string OtherProviderIdentifierIssuer9
            public string OtherProviderIdentifierIssuer9
            {
                get
                {
                    return otherProviderIdentifierIssuer9;
                }
                set
                {
                    otherProviderIdentifierIssuer9 = value;
                }
            }
            #endregion

            #region string OtherProviderIdentifierState1
            public string OtherProviderIdentifierState1
            {
                get
                {
                    return otherProviderIdentifierState1;
                }
                set
                {
                    otherProviderIdentifierState1 = value;
                }
            }
            #endregion

            #region string OtherProviderIdentifierState10
            public string OtherProviderIdentifierState10
            {
                get
                {
                    return otherProviderIdentifierState10;
                }
                set
                {
                    otherProviderIdentifierState10 = value;
                }
            }
            #endregion

            #region string OtherProviderIdentifierState11
            public string OtherProviderIdentifierState11
            {
                get
                {
                    return otherProviderIdentifierState11;
                }
                set
                {
                    otherProviderIdentifierState11 = value;
                }
            }
            #endregion

            #region string OtherProviderIdentifierState12
            public string OtherProviderIdentifierState12
            {
                get
                {
                    return otherProviderIdentifierState12;
                }
                set
                {
                    otherProviderIdentifierState12 = value;
                }
            }
            #endregion

            #region string OtherProviderIdentifierState13
            public string OtherProviderIdentifierState13
            {
                get
                {
                    return otherProviderIdentifierState13;
                }
                set
                {
                    otherProviderIdentifierState13 = value;
                }
            }
            #endregion

            #region string OtherProviderIdentifierState14
            public string OtherProviderIdentifierState14
            {
                get
                {
                    return otherProviderIdentifierState14;
                }
                set
                {
                    otherProviderIdentifierState14 = value;
                }
            }
            #endregion

            #region string OtherProviderIdentifierState15
            public string OtherProviderIdentifierState15
            {
                get
                {
                    return otherProviderIdentifierState15;
                }
                set
                {
                    otherProviderIdentifierState15 = value;
                }
            }
            #endregion

            #region string OtherProviderIdentifierState16
            public string OtherProviderIdentifierState16
            {
                get
                {
                    return otherProviderIdentifierState16;
                }
                set
                {
                    otherProviderIdentifierState16 = value;
                }
            }
            #endregion

            #region string OtherProviderIdentifierState17
            public string OtherProviderIdentifierState17
            {
                get
                {
                    return otherProviderIdentifierState17;
                }
                set
                {
                    otherProviderIdentifierState17 = value;
                }
            }
            #endregion

            #region string OtherProviderIdentifierState18
            public string OtherProviderIdentifierState18
            {
                get
                {
                    return otherProviderIdentifierState18;
                }
                set
                {
                    otherProviderIdentifierState18 = value;
                }
            }
            #endregion

            #region string OtherProviderIdentifierState19
            public string OtherProviderIdentifierState19
            {
                get
                {
                    return otherProviderIdentifierState19;
                }
                set
                {
                    otherProviderIdentifierState19 = value;
                }
            }
            #endregion

            #region string OtherProviderIdentifierState2
            public string OtherProviderIdentifierState2
            {
                get
                {
                    return otherProviderIdentifierState2;
                }
                set
                {
                    otherProviderIdentifierState2 = value;
                }
            }
            #endregion

            #region string OtherProviderIdentifierState20
            public string OtherProviderIdentifierState20
            {
                get
                {
                    return otherProviderIdentifierState20;
                }
                set
                {
                    otherProviderIdentifierState20 = value;
                }
            }
            #endregion

            #region string OtherProviderIdentifierState21
            public string OtherProviderIdentifierState21
            {
                get
                {
                    return otherProviderIdentifierState21;
                }
                set
                {
                    otherProviderIdentifierState21 = value;
                }
            }
            #endregion

            #region string OtherProviderIdentifierState22
            public string OtherProviderIdentifierState22
            {
                get
                {
                    return otherProviderIdentifierState22;
                }
                set
                {
                    otherProviderIdentifierState22 = value;
                }
            }
            #endregion

            #region string OtherProviderIdentifierState23
            public string OtherProviderIdentifierState23
            {
                get
                {
                    return otherProviderIdentifierState23;
                }
                set
                {
                    otherProviderIdentifierState23 = value;
                }
            }
            #endregion

            #region string OtherProviderIdentifierState24
            public string OtherProviderIdentifierState24
            {
                get
                {
                    return otherProviderIdentifierState24;
                }
                set
                {
                    otherProviderIdentifierState24 = value;
                }
            }
            #endregion

            #region string OtherProviderIdentifierState25
            public string OtherProviderIdentifierState25
            {
                get
                {
                    return otherProviderIdentifierState25;
                }
                set
                {
                    otherProviderIdentifierState25 = value;
                }
            }
            #endregion

            #region string OtherProviderIdentifierState26
            public string OtherProviderIdentifierState26
            {
                get
                {
                    return otherProviderIdentifierState26;
                }
                set
                {
                    otherProviderIdentifierState26 = value;
                }
            }
            #endregion

            #region string OtherProviderIdentifierState27
            public string OtherProviderIdentifierState27
            {
                get
                {
                    return otherProviderIdentifierState27;
                }
                set
                {
                    otherProviderIdentifierState27 = value;
                }
            }
            #endregion

            #region string OtherProviderIdentifierState28
            public string OtherProviderIdentifierState28
            {
                get
                {
                    return otherProviderIdentifierState28;
                }
                set
                {
                    otherProviderIdentifierState28 = value;
                }
            }
            #endregion

            #region string OtherProviderIdentifierState29
            public string OtherProviderIdentifierState29
            {
                get
                {
                    return otherProviderIdentifierState29;
                }
                set
                {
                    otherProviderIdentifierState29 = value;
                }
            }
            #endregion

            #region string OtherProviderIdentifierState3
            public string OtherProviderIdentifierState3
            {
                get
                {
                    return otherProviderIdentifierState3;
                }
                set
                {
                    otherProviderIdentifierState3 = value;
                }
            }
            #endregion

            #region string OtherProviderIdentifierState30
            public string OtherProviderIdentifierState30
            {
                get
                {
                    return otherProviderIdentifierState30;
                }
                set
                {
                    otherProviderIdentifierState30 = value;
                }
            }
            #endregion

            #region string OtherProviderIdentifierState31
            public string OtherProviderIdentifierState31
            {
                get
                {
                    return otherProviderIdentifierState31;
                }
                set
                {
                    otherProviderIdentifierState31 = value;
                }
            }
            #endregion

            #region string OtherProviderIdentifierState32
            public string OtherProviderIdentifierState32
            {
                get
                {
                    return otherProviderIdentifierState32;
                }
                set
                {
                    otherProviderIdentifierState32 = value;
                }
            }
            #endregion

            #region string OtherProviderIdentifierState33
            public string OtherProviderIdentifierState33
            {
                get
                {
                    return otherProviderIdentifierState33;
                }
                set
                {
                    otherProviderIdentifierState33 = value;
                }
            }
            #endregion

            #region string OtherProviderIdentifierState34
            public string OtherProviderIdentifierState34
            {
                get
                {
                    return otherProviderIdentifierState34;
                }
                set
                {
                    otherProviderIdentifierState34 = value;
                }
            }
            #endregion

            #region string OtherProviderIdentifierState35
            public string OtherProviderIdentifierState35
            {
                get
                {
                    return otherProviderIdentifierState35;
                }
                set
                {
                    otherProviderIdentifierState35 = value;
                }
            }
            #endregion

            #region string OtherProviderIdentifierState36
            public string OtherProviderIdentifierState36
            {
                get
                {
                    return otherProviderIdentifierState36;
                }
                set
                {
                    otherProviderIdentifierState36 = value;
                }
            }
            #endregion

            #region string OtherProviderIdentifierState37
            public string OtherProviderIdentifierState37
            {
                get
                {
                    return otherProviderIdentifierState37;
                }
                set
                {
                    otherProviderIdentifierState37 = value;
                }
            }
            #endregion

            #region string OtherProviderIdentifierState38
            public string OtherProviderIdentifierState38
            {
                get
                {
                    return otherProviderIdentifierState38;
                }
                set
                {
                    otherProviderIdentifierState38 = value;
                }
            }
            #endregion

            #region string OtherProviderIdentifierState39
            public string OtherProviderIdentifierState39
            {
                get
                {
                    return otherProviderIdentifierState39;
                }
                set
                {
                    otherProviderIdentifierState39 = value;
                }
            }
            #endregion

            #region string OtherProviderIdentifierState4
            public string OtherProviderIdentifierState4
            {
                get
                {
                    return otherProviderIdentifierState4;
                }
                set
                {
                    otherProviderIdentifierState4 = value;
                }
            }
            #endregion

            #region string OtherProviderIdentifierState40
            public string OtherProviderIdentifierState40
            {
                get
                {
                    return otherProviderIdentifierState40;
                }
                set
                {
                    otherProviderIdentifierState40 = value;
                }
            }
            #endregion

            #region string OtherProviderIdentifierState41
            public string OtherProviderIdentifierState41
            {
                get
                {
                    return otherProviderIdentifierState41;
                }
                set
                {
                    otherProviderIdentifierState41 = value;
                }
            }
            #endregion

            #region string OtherProviderIdentifierState42
            public string OtherProviderIdentifierState42
            {
                get
                {
                    return otherProviderIdentifierState42;
                }
                set
                {
                    otherProviderIdentifierState42 = value;
                }
            }
            #endregion

            #region string OtherProviderIdentifierState43
            public string OtherProviderIdentifierState43
            {
                get
                {
                    return otherProviderIdentifierState43;
                }
                set
                {
                    otherProviderIdentifierState43 = value;
                }
            }
            #endregion

            #region string OtherProviderIdentifierState44
            public string OtherProviderIdentifierState44
            {
                get
                {
                    return otherProviderIdentifierState44;
                }
                set
                {
                    otherProviderIdentifierState44 = value;
                }
            }
            #endregion

            #region string OtherProviderIdentifierState45
            public string OtherProviderIdentifierState45
            {
                get
                {
                    return otherProviderIdentifierState45;
                }
                set
                {
                    otherProviderIdentifierState45 = value;
                }
            }
            #endregion

            #region string OtherProviderIdentifierState46
            public string OtherProviderIdentifierState46
            {
                get
                {
                    return otherProviderIdentifierState46;
                }
                set
                {
                    otherProviderIdentifierState46 = value;
                }
            }
            #endregion

            #region string OtherProviderIdentifierState47
            public string OtherProviderIdentifierState47
            {
                get
                {
                    return otherProviderIdentifierState47;
                }
                set
                {
                    otherProviderIdentifierState47 = value;
                }
            }
            #endregion

            #region string OtherProviderIdentifierState48
            public string OtherProviderIdentifierState48
            {
                get
                {
                    return otherProviderIdentifierState48;
                }
                set
                {
                    otherProviderIdentifierState48 = value;
                }
            }
            #endregion

            #region string OtherProviderIdentifierState49
            public string OtherProviderIdentifierState49
            {
                get
                {
                    return otherProviderIdentifierState49;
                }
                set
                {
                    otherProviderIdentifierState49 = value;
                }
            }
            #endregion

            #region string OtherProviderIdentifierState5
            public string OtherProviderIdentifierState5
            {
                get
                {
                    return otherProviderIdentifierState5;
                }
                set
                {
                    otherProviderIdentifierState5 = value;
                }
            }
            #endregion

            #region string OtherProviderIdentifierState50
            public string OtherProviderIdentifierState50
            {
                get
                {
                    return otherProviderIdentifierState50;
                }
                set
                {
                    otherProviderIdentifierState50 = value;
                }
            }
            #endregion

            #region string OtherProviderIdentifierState6
            public string OtherProviderIdentifierState6
            {
                get
                {
                    return otherProviderIdentifierState6;
                }
                set
                {
                    otherProviderIdentifierState6 = value;
                }
            }
            #endregion

            #region string OtherProviderIdentifierState7
            public string OtherProviderIdentifierState7
            {
                get
                {
                    return otherProviderIdentifierState7;
                }
                set
                {
                    otherProviderIdentifierState7 = value;
                }
            }
            #endregion

            #region string OtherProviderIdentifierState8
            public string OtherProviderIdentifierState8
            {
                get
                {
                    return otherProviderIdentifierState8;
                }
                set
                {
                    otherProviderIdentifierState8 = value;
                }
            }
            #endregion

            #region string OtherProviderIdentifierState9
            public string OtherProviderIdentifierState9
            {
                get
                {
                    return otherProviderIdentifierState9;
                }
                set
                {
                    otherProviderIdentifierState9 = value;
                }
            }
            #endregion

            #region string OtherProviderIdentifierTypeCode1
            public string OtherProviderIdentifierTypeCode1
            {
                get
                {
                    return otherProviderIdentifierTypeCode1;
                }
                set
                {
                    otherProviderIdentifierTypeCode1 = value;
                }
            }
            #endregion

            #region string OtherProviderIdentifierTypeCode10
            public string OtherProviderIdentifierTypeCode10
            {
                get
                {
                    return otherProviderIdentifierTypeCode10;
                }
                set
                {
                    otherProviderIdentifierTypeCode10 = value;
                }
            }
            #endregion

            #region string OtherProviderIdentifierTypeCode11
            public string OtherProviderIdentifierTypeCode11
            {
                get
                {
                    return otherProviderIdentifierTypeCode11;
                }
                set
                {
                    otherProviderIdentifierTypeCode11 = value;
                }
            }
            #endregion

            #region string OtherProviderIdentifierTypeCode12
            public string OtherProviderIdentifierTypeCode12
            {
                get
                {
                    return otherProviderIdentifierTypeCode12;
                }
                set
                {
                    otherProviderIdentifierTypeCode12 = value;
                }
            }
            #endregion

            #region string OtherProviderIdentifierTypeCode13
            public string OtherProviderIdentifierTypeCode13
            {
                get
                {
                    return otherProviderIdentifierTypeCode13;
                }
                set
                {
                    otherProviderIdentifierTypeCode13 = value;
                }
            }
            #endregion

            #region string OtherProviderIdentifierTypeCode14
            public string OtherProviderIdentifierTypeCode14
            {
                get
                {
                    return otherProviderIdentifierTypeCode14;
                }
                set
                {
                    otherProviderIdentifierTypeCode14 = value;
                }
            }
            #endregion

            #region string OtherProviderIdentifierTypeCode15
            public string OtherProviderIdentifierTypeCode15
            {
                get
                {
                    return otherProviderIdentifierTypeCode15;
                }
                set
                {
                    otherProviderIdentifierTypeCode15 = value;
                }
            }
            #endregion

            #region string OtherProviderIdentifierTypeCode16
            public string OtherProviderIdentifierTypeCode16
            {
                get
                {
                    return otherProviderIdentifierTypeCode16;
                }
                set
                {
                    otherProviderIdentifierTypeCode16 = value;
                }
            }
            #endregion

            #region string OtherProviderIdentifierTypeCode17
            public string OtherProviderIdentifierTypeCode17
            {
                get
                {
                    return otherProviderIdentifierTypeCode17;
                }
                set
                {
                    otherProviderIdentifierTypeCode17 = value;
                }
            }
            #endregion

            #region string OtherProviderIdentifierTypeCode18
            public string OtherProviderIdentifierTypeCode18
            {
                get
                {
                    return otherProviderIdentifierTypeCode18;
                }
                set
                {
                    otherProviderIdentifierTypeCode18 = value;
                }
            }
            #endregion

            #region string OtherProviderIdentifierTypeCode19
            public string OtherProviderIdentifierTypeCode19
            {
                get
                {
                    return otherProviderIdentifierTypeCode19;
                }
                set
                {
                    otherProviderIdentifierTypeCode19 = value;
                }
            }
            #endregion

            #region string OtherProviderIdentifierTypeCode2
            public string OtherProviderIdentifierTypeCode2
            {
                get
                {
                    return otherProviderIdentifierTypeCode2;
                }
                set
                {
                    otherProviderIdentifierTypeCode2 = value;
                }
            }
            #endregion

            #region string OtherProviderIdentifierTypeCode20
            public string OtherProviderIdentifierTypeCode20
            {
                get
                {
                    return otherProviderIdentifierTypeCode20;
                }
                set
                {
                    otherProviderIdentifierTypeCode20 = value;
                }
            }
            #endregion

            #region string OtherProviderIdentifierTypeCode21
            public string OtherProviderIdentifierTypeCode21
            {
                get
                {
                    return otherProviderIdentifierTypeCode21;
                }
                set
                {
                    otherProviderIdentifierTypeCode21 = value;
                }
            }
            #endregion

            #region string OtherProviderIdentifierTypeCode22
            public string OtherProviderIdentifierTypeCode22
            {
                get
                {
                    return otherProviderIdentifierTypeCode22;
                }
                set
                {
                    otherProviderIdentifierTypeCode22 = value;
                }
            }
            #endregion

            #region string OtherProviderIdentifierTypeCode23
            public string OtherProviderIdentifierTypeCode23
            {
                get
                {
                    return otherProviderIdentifierTypeCode23;
                }
                set
                {
                    otherProviderIdentifierTypeCode23 = value;
                }
            }
            #endregion

            #region string OtherProviderIdentifierTypeCode24
            public string OtherProviderIdentifierTypeCode24
            {
                get
                {
                    return otherProviderIdentifierTypeCode24;
                }
                set
                {
                    otherProviderIdentifierTypeCode24 = value;
                }
            }
            #endregion

            #region string OtherProviderIdentifierTypeCode25
            public string OtherProviderIdentifierTypeCode25
            {
                get
                {
                    return otherProviderIdentifierTypeCode25;
                }
                set
                {
                    otherProviderIdentifierTypeCode25 = value;
                }
            }
            #endregion

            #region string OtherProviderIdentifierTypeCode26
            public string OtherProviderIdentifierTypeCode26
            {
                get
                {
                    return otherProviderIdentifierTypeCode26;
                }
                set
                {
                    otherProviderIdentifierTypeCode26 = value;
                }
            }
            #endregion

            #region string OtherProviderIdentifierTypeCode27
            public string OtherProviderIdentifierTypeCode27
            {
                get
                {
                    return otherProviderIdentifierTypeCode27;
                }
                set
                {
                    otherProviderIdentifierTypeCode27 = value;
                }
            }
            #endregion

            #region string OtherProviderIdentifierTypeCode28
            public string OtherProviderIdentifierTypeCode28
            {
                get
                {
                    return otherProviderIdentifierTypeCode28;
                }
                set
                {
                    otherProviderIdentifierTypeCode28 = value;
                }
            }
            #endregion

            #region string OtherProviderIdentifierTypeCode29
            public string OtherProviderIdentifierTypeCode29
            {
                get
                {
                    return otherProviderIdentifierTypeCode29;
                }
                set
                {
                    otherProviderIdentifierTypeCode29 = value;
                }
            }
            #endregion

            #region string OtherProviderIdentifierTypeCode3
            public string OtherProviderIdentifierTypeCode3
            {
                get
                {
                    return otherProviderIdentifierTypeCode3;
                }
                set
                {
                    otherProviderIdentifierTypeCode3 = value;
                }
            }
            #endregion

            #region string OtherProviderIdentifierTypeCode30
            public string OtherProviderIdentifierTypeCode30
            {
                get
                {
                    return otherProviderIdentifierTypeCode30;
                }
                set
                {
                    otherProviderIdentifierTypeCode30 = value;
                }
            }
            #endregion

            #region string OtherProviderIdentifierTypeCode31
            public string OtherProviderIdentifierTypeCode31
            {
                get
                {
                    return otherProviderIdentifierTypeCode31;
                }
                set
                {
                    otherProviderIdentifierTypeCode31 = value;
                }
            }
            #endregion

            #region string OtherProviderIdentifierTypeCode32
            public string OtherProviderIdentifierTypeCode32
            {
                get
                {
                    return otherProviderIdentifierTypeCode32;
                }
                set
                {
                    otherProviderIdentifierTypeCode32 = value;
                }
            }
            #endregion

            #region string OtherProviderIdentifierTypeCode33
            public string OtherProviderIdentifierTypeCode33
            {
                get
                {
                    return otherProviderIdentifierTypeCode33;
                }
                set
                {
                    otherProviderIdentifierTypeCode33 = value;
                }
            }
            #endregion

            #region string OtherProviderIdentifierTypeCode34
            public string OtherProviderIdentifierTypeCode34
            {
                get
                {
                    return otherProviderIdentifierTypeCode34;
                }
                set
                {
                    otherProviderIdentifierTypeCode34 = value;
                }
            }
            #endregion

            #region string OtherProviderIdentifierTypeCode35
            public string OtherProviderIdentifierTypeCode35
            {
                get
                {
                    return otherProviderIdentifierTypeCode35;
                }
                set
                {
                    otherProviderIdentifierTypeCode35 = value;
                }
            }
            #endregion

            #region string OtherProviderIdentifierTypeCode36
            public string OtherProviderIdentifierTypeCode36
            {
                get
                {
                    return otherProviderIdentifierTypeCode36;
                }
                set
                {
                    otherProviderIdentifierTypeCode36 = value;
                }
            }
            #endregion

            #region string OtherProviderIdentifierTypeCode37
            public string OtherProviderIdentifierTypeCode37
            {
                get
                {
                    return otherProviderIdentifierTypeCode37;
                }
                set
                {
                    otherProviderIdentifierTypeCode37 = value;
                }
            }
            #endregion

            #region string OtherProviderIdentifierTypeCode38
            public string OtherProviderIdentifierTypeCode38
            {
                get
                {
                    return otherProviderIdentifierTypeCode38;
                }
                set
                {
                    otherProviderIdentifierTypeCode38 = value;
                }
            }
            #endregion

            #region string OtherProviderIdentifierTypeCode39
            public string OtherProviderIdentifierTypeCode39
            {
                get
                {
                    return otherProviderIdentifierTypeCode39;
                }
                set
                {
                    otherProviderIdentifierTypeCode39 = value;
                }
            }
            #endregion

            #region string OtherProviderIdentifierTypeCode4
            public string OtherProviderIdentifierTypeCode4
            {
                get
                {
                    return otherProviderIdentifierTypeCode4;
                }
                set
                {
                    otherProviderIdentifierTypeCode4 = value;
                }
            }
            #endregion

            #region string OtherProviderIdentifierTypeCode40
            public string OtherProviderIdentifierTypeCode40
            {
                get
                {
                    return otherProviderIdentifierTypeCode40;
                }
                set
                {
                    otherProviderIdentifierTypeCode40 = value;
                }
            }
            #endregion

            #region string OtherProviderIdentifierTypeCode41
            public string OtherProviderIdentifierTypeCode41
            {
                get
                {
                    return otherProviderIdentifierTypeCode41;
                }
                set
                {
                    otherProviderIdentifierTypeCode41 = value;
                }
            }
            #endregion

            #region string OtherProviderIdentifierTypeCode42
            public string OtherProviderIdentifierTypeCode42
            {
                get
                {
                    return otherProviderIdentifierTypeCode42;
                }
                set
                {
                    otherProviderIdentifierTypeCode42 = value;
                }
            }
            #endregion

            #region string OtherProviderIdentifierTypeCode43
            public string OtherProviderIdentifierTypeCode43
            {
                get
                {
                    return otherProviderIdentifierTypeCode43;
                }
                set
                {
                    otherProviderIdentifierTypeCode43 = value;
                }
            }
            #endregion

            #region string OtherProviderIdentifierTypeCode44
            public string OtherProviderIdentifierTypeCode44
            {
                get
                {
                    return otherProviderIdentifierTypeCode44;
                }
                set
                {
                    otherProviderIdentifierTypeCode44 = value;
                }
            }
            #endregion

            #region string OtherProviderIdentifierTypeCode45
            public string OtherProviderIdentifierTypeCode45
            {
                get
                {
                    return otherProviderIdentifierTypeCode45;
                }
                set
                {
                    otherProviderIdentifierTypeCode45 = value;
                }
            }
            #endregion

            #region string OtherProviderIdentifierTypeCode46
            public string OtherProviderIdentifierTypeCode46
            {
                get
                {
                    return otherProviderIdentifierTypeCode46;
                }
                set
                {
                    otherProviderIdentifierTypeCode46 = value;
                }
            }
            #endregion

            #region string OtherProviderIdentifierTypeCode47
            public string OtherProviderIdentifierTypeCode47
            {
                get
                {
                    return otherProviderIdentifierTypeCode47;
                }
                set
                {
                    otherProviderIdentifierTypeCode47 = value;
                }
            }
            #endregion

            #region string OtherProviderIdentifierTypeCode48
            public string OtherProviderIdentifierTypeCode48
            {
                get
                {
                    return otherProviderIdentifierTypeCode48;
                }
                set
                {
                    otherProviderIdentifierTypeCode48 = value;
                }
            }
            #endregion

            #region string OtherProviderIdentifierTypeCode49
            public string OtherProviderIdentifierTypeCode49
            {
                get
                {
                    return otherProviderIdentifierTypeCode49;
                }
                set
                {
                    otherProviderIdentifierTypeCode49 = value;
                }
            }
            #endregion

            #region string OtherProviderIdentifierTypeCode5
            public string OtherProviderIdentifierTypeCode5
            {
                get
                {
                    return otherProviderIdentifierTypeCode5;
                }
                set
                {
                    otherProviderIdentifierTypeCode5 = value;
                }
            }
            #endregion

            #region string OtherProviderIdentifierTypeCode50
            public string OtherProviderIdentifierTypeCode50
            {
                get
                {
                    return otherProviderIdentifierTypeCode50;
                }
                set
                {
                    otherProviderIdentifierTypeCode50 = value;
                }
            }
            #endregion

            #region string OtherProviderIdentifierTypeCode6
            public string OtherProviderIdentifierTypeCode6
            {
                get
                {
                    return otherProviderIdentifierTypeCode6;
                }
                set
                {
                    otherProviderIdentifierTypeCode6 = value;
                }
            }
            #endregion

            #region string OtherProviderIdentifierTypeCode7
            public string OtherProviderIdentifierTypeCode7
            {
                get
                {
                    return otherProviderIdentifierTypeCode7;
                }
                set
                {
                    otherProviderIdentifierTypeCode7 = value;
                }
            }
            #endregion

            #region string OtherProviderIdentifierTypeCode8
            public string OtherProviderIdentifierTypeCode8
            {
                get
                {
                    return otherProviderIdentifierTypeCode8;
                }
                set
                {
                    otherProviderIdentifierTypeCode8 = value;
                }
            }
            #endregion

            #region string OtherProviderIdentifierTypeCode9
            public string OtherProviderIdentifierTypeCode9
            {
                get
                {
                    return otherProviderIdentifierTypeCode9;
                }
                set
                {
                    otherProviderIdentifierTypeCode9 = value;
                }
            }
            #endregion

            #region string ParentOrganizationLBN
            public string ParentOrganizationLBN
            {
                get
                {
                    return parentOrganizationLBN;
                }
                set
                {
                    parentOrganizationLBN = value;
                }
            }
            #endregion

            #region string ParentOrganizationTIN
            public string ParentOrganizationTIN
            {
                get
                {
                    return parentOrganizationTIN;
                }
                set
                {
                    parentOrganizationTIN = value;
                }
            }
            #endregion

            #region string ProviderBusinessMailingAddressCityName
            public string ProviderBusinessMailingAddressCityName
            {
                get
                {
                    return providerBusinessMailingAddressCityName;
                }
                set
                {
                    providerBusinessMailingAddressCityName = value;
                }
            }
            #endregion

            #region string ProviderBusinessMailingAddressCountryCodeIfoutsideUS
            public string ProviderBusinessMailingAddressCountryCodeIfoutsideUS
            {
                get
                {
                    return providerBusinessMailingAddressCountryCodeIfoutsideUS;
                }
                set
                {
                    providerBusinessMailingAddressCountryCodeIfoutsideUS = value;
                }
            }
            #endregion

            #region string ProviderBusinessMailingAddressFaxNumber
            public string ProviderBusinessMailingAddressFaxNumber
            {
                get
                {
                    return providerBusinessMailingAddressFaxNumber;
                }
                set
                {
                    providerBusinessMailingAddressFaxNumber = value;
                }
            }
            #endregion

            #region string ProviderBusinessMailingAddressPostalCode
            public string ProviderBusinessMailingAddressPostalCode
            {
                get
                {
                    return providerBusinessMailingAddressPostalCode;
                }
                set
                {
                    providerBusinessMailingAddressPostalCode = value;
                }
            }
            #endregion

            #region string ProviderBusinessMailingAddressStateName
            public string ProviderBusinessMailingAddressStateName
            {
                get
                {
                    return providerBusinessMailingAddressStateName;
                }
                set
                {
                    providerBusinessMailingAddressStateName = value;
                }
            }
            #endregion

            #region string ProviderBusinessMailingAddressTelephoneNumber
            public string ProviderBusinessMailingAddressTelephoneNumber
            {
                get
                {
                    return providerBusinessMailingAddressTelephoneNumber;
                }
                set
                {
                    providerBusinessMailingAddressTelephoneNumber = value;
                }
            }
            #endregion

            #region string ProviderBusinessPracticeLocationAddressCityName
            public string ProviderBusinessPracticeLocationAddressCityName
            {
                get
                {
                    return providerBusinessPracticeLocationAddressCityName;
                }
                set
                {
                    providerBusinessPracticeLocationAddressCityName = value;
                }
            }
            #endregion

            #region string ProviderBusinessPracticeLocationAddressCountryCodeIfoutsideUS
            public string ProviderBusinessPracticeLocationAddressCountryCodeIfoutsideUS
            {
                get
                {
                    return providerBusinessPracticeLocationAddressCountryCodeIfoutsideUS;
                }
                set
                {
                    providerBusinessPracticeLocationAddressCountryCodeIfoutsideUS = value;
                }
            }
            #endregion

            #region string ProviderBusinessPracticeLocationAddressFaxNumber
            public string ProviderBusinessPracticeLocationAddressFaxNumber
            {
                get
                {
                    return providerBusinessPracticeLocationAddressFaxNumber;
                }
                set
                {
                    providerBusinessPracticeLocationAddressFaxNumber = value;
                }
            }
            #endregion

            #region string ProviderBusinessPracticeLocationAddressPostalCode
            public string ProviderBusinessPracticeLocationAddressPostalCode
            {
                get
                {
                    return providerBusinessPracticeLocationAddressPostalCode;
                }
                set
                {
                    providerBusinessPracticeLocationAddressPostalCode = value;
                }
            }
            #endregion

            #region string ProviderBusinessPracticeLocationAddressStateName
            public string ProviderBusinessPracticeLocationAddressStateName
            {
                get
                {
                    return providerBusinessPracticeLocationAddressStateName;
                }
                set
                {
                    providerBusinessPracticeLocationAddressStateName = value;
                }
            }
            #endregion

            #region string ProviderBusinessPracticeLocationAddressTelephoneNumber
            public string ProviderBusinessPracticeLocationAddressTelephoneNumber
            {
                get
                {
                    return providerBusinessPracticeLocationAddressTelephoneNumber;
                }
                set
                {
                    providerBusinessPracticeLocationAddressTelephoneNumber = value;
                }
            }
            #endregion

            #region string ProviderCredentialText
            public string ProviderCredentialText
            {
                get
                {
                    return providerCredentialText;
                }
                set
                {
                    providerCredentialText = value;
                }
            }
            #endregion

            #region string ProviderEnumerationDate
            public string ProviderEnumerationDate
            {
                get
                {
                    return providerEnumerationDate;
                }
                set
                {
                    providerEnumerationDate = value;
                }
            }
            #endregion

            #region string ProviderFirstLineBusinessMailingAddress
            public string ProviderFirstLineBusinessMailingAddress
            {
                get
                {
                    return providerFirstLineBusinessMailingAddress;
                }
                set
                {
                    providerFirstLineBusinessMailingAddress = value;
                }
            }
            #endregion

            #region string ProviderFirstLineBusinessPracticeLocationAddress
            public string ProviderFirstLineBusinessPracticeLocationAddress
            {
                get
                {
                    return providerFirstLineBusinessPracticeLocationAddress;
                }
                set
                {
                    providerFirstLineBusinessPracticeLocationAddress = value;
                }
            }
            #endregion

            #region string ProviderFirstName
            public string ProviderFirstName
            {
                get
                {
                    return providerFirstName;
                }
                set
                {
                    providerFirstName = value;
                }
            }
            #endregion

            #region string ProviderGenderCode
            public string ProviderGenderCode
            {
                get
                {
                    return providerGenderCode;
                }
                set
                {
                    providerGenderCode = value;
                }
            }
            #endregion

            #region string ProviderLastNameLegalName
            public string ProviderLastNameLegalName
            {
                get
                {
                    return providerLastNameLegalName;
                }
                set
                {
                    providerLastNameLegalName = value;
                }
            }
            #endregion

            #region string ProviderLicenseNumber1
            public string ProviderLicenseNumber1
            {
                get
                {
                    return providerLicenseNumber1;
                }
                set
                {
                    providerLicenseNumber1 = value;
                }
            }
            #endregion

            #region string ProviderLicenseNumber10
            public string ProviderLicenseNumber10
            {
                get
                {
                    return providerLicenseNumber10;
                }
                set
                {
                    providerLicenseNumber10 = value;
                }
            }
            #endregion

            #region string ProviderLicenseNumber11
            public string ProviderLicenseNumber11
            {
                get
                {
                    return providerLicenseNumber11;
                }
                set
                {
                    providerLicenseNumber11 = value;
                }
            }
            #endregion

            #region string ProviderLicenseNumber12
            public string ProviderLicenseNumber12
            {
                get
                {
                    return providerLicenseNumber12;
                }
                set
                {
                    providerLicenseNumber12 = value;
                }
            }
            #endregion

            #region string ProviderLicenseNumber13
            public string ProviderLicenseNumber13
            {
                get
                {
                    return providerLicenseNumber13;
                }
                set
                {
                    providerLicenseNumber13 = value;
                }
            }
            #endregion

            #region string ProviderLicenseNumber14
            public string ProviderLicenseNumber14
            {
                get
                {
                    return providerLicenseNumber14;
                }
                set
                {
                    providerLicenseNumber14 = value;
                }
            }
            #endregion

            #region string ProviderLicenseNumber15
            public string ProviderLicenseNumber15
            {
                get
                {
                    return providerLicenseNumber15;
                }
                set
                {
                    providerLicenseNumber15 = value;
                }
            }
            #endregion

            #region string ProviderLicenseNumber2
            public string ProviderLicenseNumber2
            {
                get
                {
                    return providerLicenseNumber2;
                }
                set
                {
                    providerLicenseNumber2 = value;
                }
            }
            #endregion

            #region string ProviderLicenseNumber3
            public string ProviderLicenseNumber3
            {
                get
                {
                    return providerLicenseNumber3;
                }
                set
                {
                    providerLicenseNumber3 = value;
                }
            }
            #endregion

            #region string ProviderLicenseNumber4
            public string ProviderLicenseNumber4
            {
                get
                {
                    return providerLicenseNumber4;
                }
                set
                {
                    providerLicenseNumber4 = value;
                }
            }
            #endregion

            #region string ProviderLicenseNumber5
            public string ProviderLicenseNumber5
            {
                get
                {
                    return providerLicenseNumber5;
                }
                set
                {
                    providerLicenseNumber5 = value;
                }
            }
            #endregion

            #region string ProviderLicenseNumber6
            public string ProviderLicenseNumber6
            {
                get
                {
                    return providerLicenseNumber6;
                }
                set
                {
                    providerLicenseNumber6 = value;
                }
            }
            #endregion

            #region string ProviderLicenseNumber7
            public string ProviderLicenseNumber7
            {
                get
                {
                    return providerLicenseNumber7;
                }
                set
                {
                    providerLicenseNumber7 = value;
                }
            }
            #endregion

            #region string ProviderLicenseNumber8
            public string ProviderLicenseNumber8
            {
                get
                {
                    return providerLicenseNumber8;
                }
                set
                {
                    providerLicenseNumber8 = value;
                }
            }
            #endregion

            #region string ProviderLicenseNumber9
            public string ProviderLicenseNumber9
            {
                get
                {
                    return providerLicenseNumber9;
                }
                set
                {
                    providerLicenseNumber9 = value;
                }
            }
            #endregion

            #region string ProviderLicenseNumberStateCode1
            public string ProviderLicenseNumberStateCode1
            {
                get
                {
                    return providerLicenseNumberStateCode1;
                }
                set
                {
                    providerLicenseNumberStateCode1 = value;
                }
            }
            #endregion

            #region string ProviderLicenseNumberStateCode10
            public string ProviderLicenseNumberStateCode10
            {
                get
                {
                    return providerLicenseNumberStateCode10;
                }
                set
                {
                    providerLicenseNumberStateCode10 = value;
                }
            }
            #endregion

            #region string ProviderLicenseNumberStateCode11
            public string ProviderLicenseNumberStateCode11
            {
                get
                {
                    return providerLicenseNumberStateCode11;
                }
                set
                {
                    providerLicenseNumberStateCode11 = value;
                }
            }
            #endregion

            #region string ProviderLicenseNumberStateCode12
            public string ProviderLicenseNumberStateCode12
            {
                get
                {
                    return providerLicenseNumberStateCode12;
                }
                set
                {
                    providerLicenseNumberStateCode12 = value;
                }
            }
            #endregion

            #region string ProviderLicenseNumberStateCode13
            public string ProviderLicenseNumberStateCode13
            {
                get
                {
                    return providerLicenseNumberStateCode13;
                }
                set
                {
                    providerLicenseNumberStateCode13 = value;
                }
            }
            #endregion

            #region string ProviderLicenseNumberStateCode14
            public string ProviderLicenseNumberStateCode14
            {
                get
                {
                    return providerLicenseNumberStateCode14;
                }
                set
                {
                    providerLicenseNumberStateCode14 = value;
                }
            }
            #endregion

            #region string ProviderLicenseNumberStateCode15
            public string ProviderLicenseNumberStateCode15
            {
                get
                {
                    return providerLicenseNumberStateCode15;
                }
                set
                {
                    providerLicenseNumberStateCode15 = value;
                }
            }
            #endregion

            #region string ProviderLicenseNumberStateCode2
            public string ProviderLicenseNumberStateCode2
            {
                get
                {
                    return providerLicenseNumberStateCode2;
                }
                set
                {
                    providerLicenseNumberStateCode2 = value;
                }
            }
            #endregion

            #region string ProviderLicenseNumberStateCode3
            public string ProviderLicenseNumberStateCode3
            {
                get
                {
                    return providerLicenseNumberStateCode3;
                }
                set
                {
                    providerLicenseNumberStateCode3 = value;
                }
            }
            #endregion

            #region string ProviderLicenseNumberStateCode4
            public string ProviderLicenseNumberStateCode4
            {
                get
                {
                    return providerLicenseNumberStateCode4;
                }
                set
                {
                    providerLicenseNumberStateCode4 = value;
                }
            }
            #endregion

            #region string ProviderLicenseNumberStateCode5
            public string ProviderLicenseNumberStateCode5
            {
                get
                {
                    return providerLicenseNumberStateCode5;
                }
                set
                {
                    providerLicenseNumberStateCode5 = value;
                }
            }
            #endregion

            #region string ProviderLicenseNumberStateCode6
            public string ProviderLicenseNumberStateCode6
            {
                get
                {
                    return providerLicenseNumberStateCode6;
                }
                set
                {
                    providerLicenseNumberStateCode6 = value;
                }
            }
            #endregion

            #region string ProviderLicenseNumberStateCode7
            public string ProviderLicenseNumberStateCode7
            {
                get
                {
                    return providerLicenseNumberStateCode7;
                }
                set
                {
                    providerLicenseNumberStateCode7 = value;
                }
            }
            #endregion

            #region string ProviderLicenseNumberStateCode8
            public string ProviderLicenseNumberStateCode8
            {
                get
                {
                    return providerLicenseNumberStateCode8;
                }
                set
                {
                    providerLicenseNumberStateCode8 = value;
                }
            }
            #endregion

            #region string ProviderLicenseNumberStateCode9
            public string ProviderLicenseNumberStateCode9
            {
                get
                {
                    return providerLicenseNumberStateCode9;
                }
                set
                {
                    providerLicenseNumberStateCode9 = value;
                }
            }
            #endregion

            #region string ProviderMiddleName
            public string ProviderMiddleName
            {
                get
                {
                    return providerMiddleName;
                }
                set
                {
                    providerMiddleName = value;
                }
            }
            #endregion

            #region string ProviderNamePrefixText
            public string ProviderNamePrefixText
            {
                get
                {
                    return providerNamePrefixText;
                }
                set
                {
                    providerNamePrefixText = value;
                }
            }
            #endregion

            #region string ProviderNameSuffixText
            public string ProviderNameSuffixText
            {
                get
                {
                    return providerNameSuffixText;
                }
                set
                {
                    providerNameSuffixText = value;
                }
            }
            #endregion

            #region string ProviderOrganizationNameLegalBusinessName
            public string ProviderOrganizationNameLegalBusinessName
            {
                get
                {
                    return providerOrganizationNameLegalBusinessName;
                }
                set
                {
                    providerOrganizationNameLegalBusinessName = value;
                }
            }
            #endregion

            #region string ProviderOtherCredentialText
            public string ProviderOtherCredentialText
            {
                get
                {
                    return providerOtherCredentialText;
                }
                set
                {
                    providerOtherCredentialText = value;
                }
            }
            #endregion

            #region string ProviderOtherFirstName
            public string ProviderOtherFirstName
            {
                get
                {
                    return providerOtherFirstName;
                }
                set
                {
                    providerOtherFirstName = value;
                }
            }
            #endregion

            #region string ProviderOtherLastName
            public string ProviderOtherLastName
            {
                get
                {
                    return providerOtherLastName;
                }
                set
                {
                    providerOtherLastName = value;
                }
            }
            #endregion

            #region string ProviderOtherLastNameTypeCode
            public string ProviderOtherLastNameTypeCode
            {
                get
                {
                    return providerOtherLastNameTypeCode;
                }
                set
                {
                    providerOtherLastNameTypeCode = value;
                }
            }
            #endregion

            #region string ProviderOtherMiddleName
            public string ProviderOtherMiddleName
            {
                get
                {
                    return providerOtherMiddleName;
                }
                set
                {
                    providerOtherMiddleName = value;
                }
            }
            #endregion

            #region string ProviderOtherNamePrefixText
            public string ProviderOtherNamePrefixText
            {
                get
                {
                    return providerOtherNamePrefixText;
                }
                set
                {
                    providerOtherNamePrefixText = value;
                }
            }
            #endregion

            #region string ProviderOtherNameSuffixText
            public string ProviderOtherNameSuffixText
            {
                get
                {
                    return providerOtherNameSuffixText;
                }
                set
                {
                    providerOtherNameSuffixText = value;
                }
            }
            #endregion

            #region string ProviderOtherOrganizationName
            public string ProviderOtherOrganizationName
            {
                get
                {
                    return providerOtherOrganizationName;
                }
                set
                {
                    providerOtherOrganizationName = value;
                }
            }
            #endregion

            #region string ProviderOtherOrganizationNameTypeCode
            public string ProviderOtherOrganizationNameTypeCode
            {
                get
                {
                    return providerOtherOrganizationNameTypeCode;
                }
                set
                {
                    providerOtherOrganizationNameTypeCode = value;
                }
            }
            #endregion

            #region string ProviderSecondLineBusinessMailingAddress
            public string ProviderSecondLineBusinessMailingAddress
            {
                get
                {
                    return providerSecondLineBusinessMailingAddress;
                }
                set
                {
                    providerSecondLineBusinessMailingAddress = value;
                }
            }
            #endregion

            #region string ProviderSecondLineBusinessPracticeLocationAddress
            public string ProviderSecondLineBusinessPracticeLocationAddress
            {
                get
                {
                    return providerSecondLineBusinessPracticeLocationAddress;
                }
                set
                {
                    providerSecondLineBusinessPracticeLocationAddress = value;
                }
            }
            #endregion

            #region string ReplacementNPI
            public string ReplacementNPI
            {
                get
                {
                    return replacementNPI;
                }
                set
                {
                    replacementNPI = value;
                }
            }
            #endregion

            #region bool IsNew
            public bool IsNew
            {
                get
                {
                    // Initial Value
                    bool isNew = (this.Id < 1);

                    // return value
                    return isNew;
                }
            }
            #endregion

        #endregion

    }
    #endregion

}
