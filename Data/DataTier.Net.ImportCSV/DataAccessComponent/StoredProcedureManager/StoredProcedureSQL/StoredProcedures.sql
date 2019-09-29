Use [PFilerr]

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: RawImport_Insert
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   9/29/2019
-- Description:    Insert a new RawImport
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('RawImport_Insert'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure RawImport_Insert

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.RawImport_Insert') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure RawImport_Insert >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure RawImport_Insert >>>'

    End

GO

Create PROCEDURE RawImport_Insert

    -- Add the parameters for the stored procedure here
    @AuthorizedOfficialCredentialText nvarchar(128),
    @AuthorizedOfficialFirstName nvarchar(128),
    @AuthorizedOfficialLastName nvarchar(128),
    @AuthorizedOfficialMiddleName nvarchar(128),
    @AuthorizedOfficialNamePrefixText nvarchar(128),
    @AuthorizedOfficialNameSuffixText nvarchar(128),
    @AuthorizedOfficialTelephoneNumber nvarchar(128),
    @AuthorizedOfficialTitleorPosition nvarchar(128),
    @EmployerIdentificationNumberEIN nvarchar(128),
    @EntityTypeCode nvarchar(128),
    @HealthcareProviderPrimaryTaxonomySwitch1 nvarchar(128),
    @HealthcareProviderPrimaryTaxonomySwitch10 nvarchar(128),
    @HealthcareProviderPrimaryTaxonomySwitch11 nvarchar(128),
    @HealthcareProviderPrimaryTaxonomySwitch12 nvarchar(128),
    @HealthcareProviderPrimaryTaxonomySwitch13 nvarchar(128),
    @HealthcareProviderPrimaryTaxonomySwitch14 nvarchar(128),
    @HealthcareProviderPrimaryTaxonomySwitch15 nvarchar(128),
    @HealthcareProviderPrimaryTaxonomySwitch2 nvarchar(128),
    @HealthcareProviderPrimaryTaxonomySwitch3 nvarchar(128),
    @HealthcareProviderPrimaryTaxonomySwitch4 nvarchar(128),
    @HealthcareProviderPrimaryTaxonomySwitch5 nvarchar(128),
    @HealthcareProviderPrimaryTaxonomySwitch6 nvarchar(128),
    @HealthcareProviderPrimaryTaxonomySwitch7 nvarchar(128),
    @HealthcareProviderPrimaryTaxonomySwitch8 nvarchar(128),
    @HealthcareProviderPrimaryTaxonomySwitch9 nvarchar(128),
    @HealthcareProviderTaxonomyCode1 nvarchar(128),
    @HealthcareProviderTaxonomyCode10 nvarchar(128),
    @HealthcareProviderTaxonomyCode11 nvarchar(128),
    @HealthcareProviderTaxonomyCode12 nvarchar(128),
    @HealthcareProviderTaxonomyCode13 nvarchar(128),
    @HealthcareProviderTaxonomyCode14 nvarchar(128),
    @HealthcareProviderTaxonomyCode15 nvarchar(128),
    @HealthcareProviderTaxonomyCode2 nvarchar(128),
    @HealthcareProviderTaxonomyCode3 nvarchar(128),
    @HealthcareProviderTaxonomyCode4 nvarchar(128),
    @HealthcareProviderTaxonomyCode5 nvarchar(128),
    @HealthcareProviderTaxonomyCode6 nvarchar(128),
    @HealthcareProviderTaxonomyCode7 nvarchar(128),
    @HealthcareProviderTaxonomyCode8 nvarchar(128),
    @HealthcareProviderTaxonomyCode9 nvarchar(128),
    @HealthcareProviderTaxonomyGroup1 nvarchar(128),
    @HealthcareProviderTaxonomyGroup10 nvarchar(128),
    @HealthcareProviderTaxonomyGroup11 nvarchar(128),
    @HealthcareProviderTaxonomyGroup12 nvarchar(128),
    @HealthcareProviderTaxonomyGroup13 nvarchar(128),
    @HealthcareProviderTaxonomyGroup14 nvarchar(128),
    @HealthcareProviderTaxonomyGroup15 nvarchar(128),
    @HealthcareProviderTaxonomyGroup2 nvarchar(128),
    @HealthcareProviderTaxonomyGroup3 nvarchar(128),
    @HealthcareProviderTaxonomyGroup4 nvarchar(128),
    @HealthcareProviderTaxonomyGroup5 nvarchar(128),
    @HealthcareProviderTaxonomyGroup6 nvarchar(128),
    @HealthcareProviderTaxonomyGroup7 nvarchar(128),
    @HealthcareProviderTaxonomyGroup8 nvarchar(128),
    @HealthcareProviderTaxonomyGroup9 nvarchar(128),
    @IsOrganizationSubpart nvarchar(128),
    @IsSoleProprietor nvarchar(128),
    @LastUpdateDate nvarchar(128),
    @NPI nvarchar(128),
    @NPIDeactivationDate nvarchar(128),
    @NPIDeactivationReasonCode nvarchar(128),
    @NPIReactivationDate nvarchar(128),
    @OtherProviderIdentifier1 nvarchar(128),
    @OtherProviderIdentifier10 nvarchar(128),
    @OtherProviderIdentifier11 nvarchar(128),
    @OtherProviderIdentifier12 nvarchar(128),
    @OtherProviderIdentifier13 nvarchar(128),
    @OtherProviderIdentifier14 nvarchar(128),
    @OtherProviderIdentifier15 nvarchar(128),
    @OtherProviderIdentifier16 nvarchar(128),
    @OtherProviderIdentifier17 nvarchar(128),
    @OtherProviderIdentifier18 nvarchar(128),
    @OtherProviderIdentifier19 nvarchar(128),
    @OtherProviderIdentifier2 nvarchar(128),
    @OtherProviderIdentifier20 nvarchar(128),
    @OtherProviderIdentifier21 nvarchar(128),
    @OtherProviderIdentifier22 nvarchar(128),
    @OtherProviderIdentifier23 nvarchar(128),
    @OtherProviderIdentifier24 nvarchar(128),
    @OtherProviderIdentifier25 nvarchar(128),
    @OtherProviderIdentifier26 nvarchar(128),
    @OtherProviderIdentifier27 nvarchar(128),
    @OtherProviderIdentifier28 nvarchar(128),
    @OtherProviderIdentifier29 nvarchar(128),
    @OtherProviderIdentifier3 nvarchar(128),
    @OtherProviderIdentifier30 nvarchar(128),
    @OtherProviderIdentifier31 nvarchar(128),
    @OtherProviderIdentifier32 nvarchar(128),
    @OtherProviderIdentifier33 nvarchar(128),
    @OtherProviderIdentifier34 nvarchar(128),
    @OtherProviderIdentifier35 nvarchar(128),
    @OtherProviderIdentifier36 nvarchar(128),
    @OtherProviderIdentifier37 nvarchar(128),
    @OtherProviderIdentifier38 nvarchar(128),
    @OtherProviderIdentifier39 nvarchar(128),
    @OtherProviderIdentifier4 nvarchar(128),
    @OtherProviderIdentifier40 nvarchar(128),
    @OtherProviderIdentifier41 nvarchar(128),
    @OtherProviderIdentifier42 nvarchar(128),
    @OtherProviderIdentifier43 nvarchar(128),
    @OtherProviderIdentifier44 nvarchar(128),
    @OtherProviderIdentifier45 nvarchar(128),
    @OtherProviderIdentifier46 nvarchar(128),
    @OtherProviderIdentifier47 nvarchar(128),
    @OtherProviderIdentifier48 nvarchar(128),
    @OtherProviderIdentifier49 nvarchar(128),
    @OtherProviderIdentifier5 nvarchar(128),
    @OtherProviderIdentifier50 nvarchar(128),
    @OtherProviderIdentifier6 nvarchar(128),
    @OtherProviderIdentifier7 nvarchar(128),
    @OtherProviderIdentifier8 nvarchar(128),
    @OtherProviderIdentifier9 nvarchar(128),
    @OtherProviderIdentifierIssuer1 nvarchar(128),
    @OtherProviderIdentifierIssuer10 nvarchar(128),
    @OtherProviderIdentifierIssuer11 nvarchar(128),
    @OtherProviderIdentifierIssuer12 nvarchar(128),
    @OtherProviderIdentifierIssuer13 nvarchar(128),
    @OtherProviderIdentifierIssuer14 nvarchar(128),
    @OtherProviderIdentifierIssuer15 nvarchar(128),
    @OtherProviderIdentifierIssuer16 nvarchar(128),
    @OtherProviderIdentifierIssuer17 nvarchar(128),
    @OtherProviderIdentifierIssuer18 nvarchar(128),
    @OtherProviderIdentifierIssuer19 nvarchar(128),
    @OtherProviderIdentifierIssuer2 nvarchar(128),
    @OtherProviderIdentifierIssuer20 nvarchar(128),
    @OtherProviderIdentifierIssuer21 nvarchar(128),
    @OtherProviderIdentifierIssuer22 nvarchar(128),
    @OtherProviderIdentifierIssuer23 nvarchar(128),
    @OtherProviderIdentifierIssuer24 nvarchar(128),
    @OtherProviderIdentifierIssuer25 nvarchar(128),
    @OtherProviderIdentifierIssuer26 nvarchar(128),
    @OtherProviderIdentifierIssuer27 nvarchar(128),
    @OtherProviderIdentifierIssuer28 nvarchar(128),
    @OtherProviderIdentifierIssuer29 nvarchar(128),
    @OtherProviderIdentifierIssuer3 nvarchar(128),
    @OtherProviderIdentifierIssuer30 nvarchar(128),
    @OtherProviderIdentifierIssuer31 nvarchar(128),
    @OtherProviderIdentifierIssuer32 nvarchar(128),
    @OtherProviderIdentifierIssuer33 nvarchar(128),
    @OtherProviderIdentifierIssuer34 nvarchar(128),
    @OtherProviderIdentifierIssuer35 nvarchar(128),
    @OtherProviderIdentifierIssuer36 nvarchar(128),
    @OtherProviderIdentifierIssuer37 nvarchar(128),
    @OtherProviderIdentifierIssuer38 nvarchar(128),
    @OtherProviderIdentifierIssuer39 nvarchar(128),
    @OtherProviderIdentifierIssuer4 nvarchar(128),
    @OtherProviderIdentifierIssuer40 nvarchar(128),
    @OtherProviderIdentifierIssuer41 nvarchar(128),
    @OtherProviderIdentifierIssuer42 nvarchar(128),
    @OtherProviderIdentifierIssuer43 nvarchar(128),
    @OtherProviderIdentifierIssuer44 nvarchar(128),
    @OtherProviderIdentifierIssuer45 nvarchar(128),
    @OtherProviderIdentifierIssuer46 nvarchar(128),
    @OtherProviderIdentifierIssuer47 nvarchar(128),
    @OtherProviderIdentifierIssuer48 nvarchar(128),
    @OtherProviderIdentifierIssuer49 nvarchar(128),
    @OtherProviderIdentifierIssuer5 nvarchar(128),
    @OtherProviderIdentifierIssuer50 nvarchar(128),
    @OtherProviderIdentifierIssuer6 nvarchar(128),
    @OtherProviderIdentifierIssuer7 nvarchar(128),
    @OtherProviderIdentifierIssuer8 nvarchar(128),
    @OtherProviderIdentifierIssuer9 nvarchar(128),
    @OtherProviderIdentifierState1 nvarchar(128),
    @OtherProviderIdentifierState10 nvarchar(128),
    @OtherProviderIdentifierState11 nvarchar(128),
    @OtherProviderIdentifierState12 nvarchar(128),
    @OtherProviderIdentifierState13 nvarchar(128),
    @OtherProviderIdentifierState14 nvarchar(128),
    @OtherProviderIdentifierState15 nvarchar(128),
    @OtherProviderIdentifierState16 nvarchar(128),
    @OtherProviderIdentifierState17 nvarchar(128),
    @OtherProviderIdentifierState18 nvarchar(128),
    @OtherProviderIdentifierState19 nvarchar(128),
    @OtherProviderIdentifierState2 nvarchar(128),
    @OtherProviderIdentifierState20 nvarchar(128),
    @OtherProviderIdentifierState21 nvarchar(128),
    @OtherProviderIdentifierState22 nvarchar(128),
    @OtherProviderIdentifierState23 nvarchar(128),
    @OtherProviderIdentifierState24 nvarchar(128),
    @OtherProviderIdentifierState25 nvarchar(128),
    @OtherProviderIdentifierState26 nvarchar(128),
    @OtherProviderIdentifierState27 nvarchar(128),
    @OtherProviderIdentifierState28 nvarchar(128),
    @OtherProviderIdentifierState29 nvarchar(128),
    @OtherProviderIdentifierState3 nvarchar(128),
    @OtherProviderIdentifierState30 nvarchar(128),
    @OtherProviderIdentifierState31 nvarchar(128),
    @OtherProviderIdentifierState32 nvarchar(128),
    @OtherProviderIdentifierState33 nvarchar(128),
    @OtherProviderIdentifierState34 nvarchar(128),
    @OtherProviderIdentifierState35 nvarchar(128),
    @OtherProviderIdentifierState36 nvarchar(128),
    @OtherProviderIdentifierState37 nvarchar(128),
    @OtherProviderIdentifierState38 nvarchar(128),
    @OtherProviderIdentifierState39 nvarchar(128),
    @OtherProviderIdentifierState4 nvarchar(128),
    @OtherProviderIdentifierState40 nvarchar(128),
    @OtherProviderIdentifierState41 nvarchar(128),
    @OtherProviderIdentifierState42 nvarchar(128),
    @OtherProviderIdentifierState43 nvarchar(128),
    @OtherProviderIdentifierState44 nvarchar(128),
    @OtherProviderIdentifierState45 nvarchar(128),
    @OtherProviderIdentifierState46 nvarchar(128),
    @OtherProviderIdentifierState47 nvarchar(128),
    @OtherProviderIdentifierState48 nvarchar(128),
    @OtherProviderIdentifierState49 nvarchar(128),
    @OtherProviderIdentifierState5 nvarchar(128),
    @OtherProviderIdentifierState50 nvarchar(128),
    @OtherProviderIdentifierState6 nvarchar(128),
    @OtherProviderIdentifierState7 nvarchar(128),
    @OtherProviderIdentifierState8 nvarchar(128),
    @OtherProviderIdentifierState9 nvarchar(128),
    @OtherProviderIdentifierTypeCode1 nvarchar(128),
    @OtherProviderIdentifierTypeCode10 nvarchar(128),
    @OtherProviderIdentifierTypeCode11 nvarchar(128),
    @OtherProviderIdentifierTypeCode12 nvarchar(128),
    @OtherProviderIdentifierTypeCode13 nvarchar(128),
    @OtherProviderIdentifierTypeCode14 nvarchar(128),
    @OtherProviderIdentifierTypeCode15 nvarchar(128),
    @OtherProviderIdentifierTypeCode16 nvarchar(128),
    @OtherProviderIdentifierTypeCode17 nvarchar(128),
    @OtherProviderIdentifierTypeCode18 nvarchar(128),
    @OtherProviderIdentifierTypeCode19 nvarchar(128),
    @OtherProviderIdentifierTypeCode2 nvarchar(128),
    @OtherProviderIdentifierTypeCode20 nvarchar(128),
    @OtherProviderIdentifierTypeCode21 nvarchar(128),
    @OtherProviderIdentifierTypeCode22 nvarchar(128),
    @OtherProviderIdentifierTypeCode23 nvarchar(128),
    @OtherProviderIdentifierTypeCode24 nvarchar(128),
    @OtherProviderIdentifierTypeCode25 nvarchar(128),
    @OtherProviderIdentifierTypeCode26 nvarchar(128),
    @OtherProviderIdentifierTypeCode27 nvarchar(128),
    @OtherProviderIdentifierTypeCode28 nvarchar(128),
    @OtherProviderIdentifierTypeCode29 nvarchar(128),
    @OtherProviderIdentifierTypeCode3 nvarchar(128),
    @OtherProviderIdentifierTypeCode30 nvarchar(128),
    @OtherProviderIdentifierTypeCode31 nvarchar(128),
    @OtherProviderIdentifierTypeCode32 nvarchar(128),
    @OtherProviderIdentifierTypeCode33 nvarchar(128),
    @OtherProviderIdentifierTypeCode34 nvarchar(128),
    @OtherProviderIdentifierTypeCode35 nvarchar(128),
    @OtherProviderIdentifierTypeCode36 nvarchar(128),
    @OtherProviderIdentifierTypeCode37 nvarchar(128),
    @OtherProviderIdentifierTypeCode38 nvarchar(128),
    @OtherProviderIdentifierTypeCode39 nvarchar(128),
    @OtherProviderIdentifierTypeCode4 nvarchar(128),
    @OtherProviderIdentifierTypeCode40 nvarchar(128),
    @OtherProviderIdentifierTypeCode41 nvarchar(128),
    @OtherProviderIdentifierTypeCode42 nvarchar(128),
    @OtherProviderIdentifierTypeCode43 nvarchar(128),
    @OtherProviderIdentifierTypeCode44 nvarchar(128),
    @OtherProviderIdentifierTypeCode45 nvarchar(128),
    @OtherProviderIdentifierTypeCode46 nvarchar(128),
    @OtherProviderIdentifierTypeCode47 nvarchar(128),
    @OtherProviderIdentifierTypeCode48 nvarchar(128),
    @OtherProviderIdentifierTypeCode49 nvarchar(128),
    @OtherProviderIdentifierTypeCode5 nvarchar(128),
    @OtherProviderIdentifierTypeCode50 nvarchar(128),
    @OtherProviderIdentifierTypeCode6 nvarchar(128),
    @OtherProviderIdentifierTypeCode7 nvarchar(128),
    @OtherProviderIdentifierTypeCode8 nvarchar(128),
    @OtherProviderIdentifierTypeCode9 nvarchar(128),
    @ParentOrganizationLBN nvarchar(128),
    @ParentOrganizationTIN nvarchar(128),
    @ProviderBusinessMailingAddressCityName nvarchar(128),
    @ProviderBusinessMailingAddressCountryCodeIfoutsideUS nvarchar(128),
    @ProviderBusinessMailingAddressFaxNumber nvarchar(128),
    @ProviderBusinessMailingAddressPostalCode nvarchar(128),
    @ProviderBusinessMailingAddressStateName nvarchar(128),
    @ProviderBusinessMailingAddressTelephoneNumber nvarchar(128),
    @ProviderBusinessPracticeLocationAddressCityName nvarchar(128),
    @ProviderBusinessPracticeLocationAddressCountryCodeIfoutsideUS nvarchar(128),
    @ProviderBusinessPracticeLocationAddressFaxNumber nvarchar(128),
    @ProviderBusinessPracticeLocationAddressPostalCode nvarchar(128),
    @ProviderBusinessPracticeLocationAddressStateName nvarchar(128),
    @ProviderBusinessPracticeLocationAddressTelephoneNumber nvarchar(128),
    @ProviderCredentialText nvarchar(128),
    @ProviderEnumerationDate nvarchar(128),
    @ProviderFirstLineBusinessMailingAddress nvarchar(128),
    @ProviderFirstLineBusinessPracticeLocationAddress nvarchar(128),
    @ProviderFirstName nvarchar(128),
    @ProviderGenderCode nvarchar(128),
    @ProviderLastNameLegalName nvarchar(128),
    @ProviderLicenseNumber1 nvarchar(128),
    @ProviderLicenseNumber10 nvarchar(128),
    @ProviderLicenseNumber11 nvarchar(128),
    @ProviderLicenseNumber12 nvarchar(128),
    @ProviderLicenseNumber13 nvarchar(128),
    @ProviderLicenseNumber14 nvarchar(128),
    @ProviderLicenseNumber15 nvarchar(128),
    @ProviderLicenseNumber2 nvarchar(128),
    @ProviderLicenseNumber3 nvarchar(128),
    @ProviderLicenseNumber4 nvarchar(128),
    @ProviderLicenseNumber5 nvarchar(128),
    @ProviderLicenseNumber6 nvarchar(128),
    @ProviderLicenseNumber7 nvarchar(128),
    @ProviderLicenseNumber8 nvarchar(128),
    @ProviderLicenseNumber9 nvarchar(128),
    @ProviderLicenseNumberStateCode1 nvarchar(128),
    @ProviderLicenseNumberStateCode10 nvarchar(128),
    @ProviderLicenseNumberStateCode11 nvarchar(128),
    @ProviderLicenseNumberStateCode12 nvarchar(128),
    @ProviderLicenseNumberStateCode13 nvarchar(128),
    @ProviderLicenseNumberStateCode14 nvarchar(128),
    @ProviderLicenseNumberStateCode15 nvarchar(128),
    @ProviderLicenseNumberStateCode2 nvarchar(128),
    @ProviderLicenseNumberStateCode3 nvarchar(128),
    @ProviderLicenseNumberStateCode4 nvarchar(128),
    @ProviderLicenseNumberStateCode5 nvarchar(128),
    @ProviderLicenseNumberStateCode6 nvarchar(128),
    @ProviderLicenseNumberStateCode7 nvarchar(128),
    @ProviderLicenseNumberStateCode8 nvarchar(128),
    @ProviderLicenseNumberStateCode9 nvarchar(128),
    @ProviderMiddleName nvarchar(128),
    @ProviderNamePrefixText nvarchar(128),
    @ProviderNameSuffixText nvarchar(128),
    @ProviderOrganizationNameLegalBusinessName nvarchar(128),
    @ProviderOtherCredentialText nvarchar(128),
    @ProviderOtherFirstName nvarchar(128),
    @ProviderOtherLastName nvarchar(128),
    @ProviderOtherLastNameTypeCode nvarchar(128),
    @ProviderOtherMiddleName nvarchar(128),
    @ProviderOtherNamePrefixText nvarchar(128),
    @ProviderOtherNameSuffixText nvarchar(128),
    @ProviderOtherOrganizationName nvarchar(128),
    @ProviderOtherOrganizationNameTypeCode nvarchar(128),
    @ProviderSecondLineBusinessMailingAddress nvarchar(128),
    @ProviderSecondLineBusinessPracticeLocationAddress nvarchar(128),
    @ReplacementNPI nvarchar(128)

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Insert Statement
    Insert Into [RawImport]
    ([AuthorizedOfficialCredentialText],[AuthorizedOfficialFirstName],[AuthorizedOfficialLastName],[AuthorizedOfficialMiddleName],[AuthorizedOfficialNamePrefixText],[AuthorizedOfficialNameSuffixText],[AuthorizedOfficialTelephoneNumber],[AuthorizedOfficialTitleorPosition],[EmployerIdentificationNumberEIN],[EntityTypeCode],[HealthcareProviderPrimaryTaxonomySwitch1],[HealthcareProviderPrimaryTaxonomySwitch10],[HealthcareProviderPrimaryTaxonomySwitch11],[HealthcareProviderPrimaryTaxonomySwitch12],[HealthcareProviderPrimaryTaxonomySwitch13],[HealthcareProviderPrimaryTaxonomySwitch14],[HealthcareProviderPrimaryTaxonomySwitch15],[HealthcareProviderPrimaryTaxonomySwitch2],[HealthcareProviderPrimaryTaxonomySwitch3],[HealthcareProviderPrimaryTaxonomySwitch4],[HealthcareProviderPrimaryTaxonomySwitch5],[HealthcareProviderPrimaryTaxonomySwitch6],[HealthcareProviderPrimaryTaxonomySwitch7],[HealthcareProviderPrimaryTaxonomySwitch8],[HealthcareProviderPrimaryTaxonomySwitch9],[HealthcareProviderTaxonomyCode1],[HealthcareProviderTaxonomyCode10],[HealthcareProviderTaxonomyCode11],[HealthcareProviderTaxonomyCode12],[HealthcareProviderTaxonomyCode13],[HealthcareProviderTaxonomyCode14],[HealthcareProviderTaxonomyCode15],[HealthcareProviderTaxonomyCode2],[HealthcareProviderTaxonomyCode3],[HealthcareProviderTaxonomyCode4],[HealthcareProviderTaxonomyCode5],[HealthcareProviderTaxonomyCode6],[HealthcareProviderTaxonomyCode7],[HealthcareProviderTaxonomyCode8],[HealthcareProviderTaxonomyCode9],[HealthcareProviderTaxonomyGroup1],[HealthcareProviderTaxonomyGroup10],[HealthcareProviderTaxonomyGroup11],[HealthcareProviderTaxonomyGroup12],[HealthcareProviderTaxonomyGroup13],[HealthcareProviderTaxonomyGroup14],[HealthcareProviderTaxonomyGroup15],[HealthcareProviderTaxonomyGroup2],[HealthcareProviderTaxonomyGroup3],[HealthcareProviderTaxonomyGroup4],[HealthcareProviderTaxonomyGroup5],[HealthcareProviderTaxonomyGroup6],[HealthcareProviderTaxonomyGroup7],[HealthcareProviderTaxonomyGroup8],[HealthcareProviderTaxonomyGroup9],[IsOrganizationSubpart],[IsSoleProprietor],[LastUpdateDate],[NPI],[NPIDeactivationDate],[NPIDeactivationReasonCode],[NPIReactivationDate],[OtherProviderIdentifier1],[OtherProviderIdentifier10],[OtherProviderIdentifier11],[OtherProviderIdentifier12],[OtherProviderIdentifier13],[OtherProviderIdentifier14],[OtherProviderIdentifier15],[OtherProviderIdentifier16],[OtherProviderIdentifier17],[OtherProviderIdentifier18],[OtherProviderIdentifier19],[OtherProviderIdentifier2],[OtherProviderIdentifier20],[OtherProviderIdentifier21],[OtherProviderIdentifier22],[OtherProviderIdentifier23],[OtherProviderIdentifier24],[OtherProviderIdentifier25],[OtherProviderIdentifier26],[OtherProviderIdentifier27],[OtherProviderIdentifier28],[OtherProviderIdentifier29],[OtherProviderIdentifier3],[OtherProviderIdentifier30],[OtherProviderIdentifier31],[OtherProviderIdentifier32],[OtherProviderIdentifier33],[OtherProviderIdentifier34],[OtherProviderIdentifier35],[OtherProviderIdentifier36],[OtherProviderIdentifier37],[OtherProviderIdentifier38],[OtherProviderIdentifier39],[OtherProviderIdentifier4],[OtherProviderIdentifier40],[OtherProviderIdentifier41],[OtherProviderIdentifier42],[OtherProviderIdentifier43],[OtherProviderIdentifier44],[OtherProviderIdentifier45],[OtherProviderIdentifier46],[OtherProviderIdentifier47],[OtherProviderIdentifier48],[OtherProviderIdentifier49],[OtherProviderIdentifier5],[OtherProviderIdentifier50],[OtherProviderIdentifier6],[OtherProviderIdentifier7],[OtherProviderIdentifier8],[OtherProviderIdentifier9],[OtherProviderIdentifierIssuer1],[OtherProviderIdentifierIssuer10],[OtherProviderIdentifierIssuer11],[OtherProviderIdentifierIssuer12],[OtherProviderIdentifierIssuer13],[OtherProviderIdentifierIssuer14],[OtherProviderIdentifierIssuer15],[OtherProviderIdentifierIssuer16],[OtherProviderIdentifierIssuer17],[OtherProviderIdentifierIssuer18],[OtherProviderIdentifierIssuer19],[OtherProviderIdentifierIssuer2],[OtherProviderIdentifierIssuer20],[OtherProviderIdentifierIssuer21],[OtherProviderIdentifierIssuer22],[OtherProviderIdentifierIssuer23],[OtherProviderIdentifierIssuer24],[OtherProviderIdentifierIssuer25],[OtherProviderIdentifierIssuer26],[OtherProviderIdentifierIssuer27],[OtherProviderIdentifierIssuer28],[OtherProviderIdentifierIssuer29],[OtherProviderIdentifierIssuer3],[OtherProviderIdentifierIssuer30],[OtherProviderIdentifierIssuer31],[OtherProviderIdentifierIssuer32],[OtherProviderIdentifierIssuer33],[OtherProviderIdentifierIssuer34],[OtherProviderIdentifierIssuer35],[OtherProviderIdentifierIssuer36],[OtherProviderIdentifierIssuer37],[OtherProviderIdentifierIssuer38],[OtherProviderIdentifierIssuer39],[OtherProviderIdentifierIssuer4],[OtherProviderIdentifierIssuer40],[OtherProviderIdentifierIssuer41],[OtherProviderIdentifierIssuer42],[OtherProviderIdentifierIssuer43],[OtherProviderIdentifierIssuer44],[OtherProviderIdentifierIssuer45],[OtherProviderIdentifierIssuer46],[OtherProviderIdentifierIssuer47],[OtherProviderIdentifierIssuer48],[OtherProviderIdentifierIssuer49],[OtherProviderIdentifierIssuer5],[OtherProviderIdentifierIssuer50],[OtherProviderIdentifierIssuer6],[OtherProviderIdentifierIssuer7],[OtherProviderIdentifierIssuer8],[OtherProviderIdentifierIssuer9],[OtherProviderIdentifierState1],[OtherProviderIdentifierState10],[OtherProviderIdentifierState11],[OtherProviderIdentifierState12],[OtherProviderIdentifierState13],[OtherProviderIdentifierState14],[OtherProviderIdentifierState15],[OtherProviderIdentifierState16],[OtherProviderIdentifierState17],[OtherProviderIdentifierState18],[OtherProviderIdentifierState19],[OtherProviderIdentifierState2],[OtherProviderIdentifierState20],[OtherProviderIdentifierState21],[OtherProviderIdentifierState22],[OtherProviderIdentifierState23],[OtherProviderIdentifierState24],[OtherProviderIdentifierState25],[OtherProviderIdentifierState26],[OtherProviderIdentifierState27],[OtherProviderIdentifierState28],[OtherProviderIdentifierState29],[OtherProviderIdentifierState3],[OtherProviderIdentifierState30],[OtherProviderIdentifierState31],[OtherProviderIdentifierState32],[OtherProviderIdentifierState33],[OtherProviderIdentifierState34],[OtherProviderIdentifierState35],[OtherProviderIdentifierState36],[OtherProviderIdentifierState37],[OtherProviderIdentifierState38],[OtherProviderIdentifierState39],[OtherProviderIdentifierState4],[OtherProviderIdentifierState40],[OtherProviderIdentifierState41],[OtherProviderIdentifierState42],[OtherProviderIdentifierState43],[OtherProviderIdentifierState44],[OtherProviderIdentifierState45],[OtherProviderIdentifierState46],[OtherProviderIdentifierState47],[OtherProviderIdentifierState48],[OtherProviderIdentifierState49],[OtherProviderIdentifierState5],[OtherProviderIdentifierState50],[OtherProviderIdentifierState6],[OtherProviderIdentifierState7],[OtherProviderIdentifierState8],[OtherProviderIdentifierState9],[OtherProviderIdentifierTypeCode1],[OtherProviderIdentifierTypeCode10],[OtherProviderIdentifierTypeCode11],[OtherProviderIdentifierTypeCode12],[OtherProviderIdentifierTypeCode13],[OtherProviderIdentifierTypeCode14],[OtherProviderIdentifierTypeCode15],[OtherProviderIdentifierTypeCode16],[OtherProviderIdentifierTypeCode17],[OtherProviderIdentifierTypeCode18],[OtherProviderIdentifierTypeCode19],[OtherProviderIdentifierTypeCode2],[OtherProviderIdentifierTypeCode20],[OtherProviderIdentifierTypeCode21],[OtherProviderIdentifierTypeCode22],[OtherProviderIdentifierTypeCode23],[OtherProviderIdentifierTypeCode24],[OtherProviderIdentifierTypeCode25],[OtherProviderIdentifierTypeCode26],[OtherProviderIdentifierTypeCode27],[OtherProviderIdentifierTypeCode28],[OtherProviderIdentifierTypeCode29],[OtherProviderIdentifierTypeCode3],[OtherProviderIdentifierTypeCode30],[OtherProviderIdentifierTypeCode31],[OtherProviderIdentifierTypeCode32],[OtherProviderIdentifierTypeCode33],[OtherProviderIdentifierTypeCode34],[OtherProviderIdentifierTypeCode35],[OtherProviderIdentifierTypeCode36],[OtherProviderIdentifierTypeCode37],[OtherProviderIdentifierTypeCode38],[OtherProviderIdentifierTypeCode39],[OtherProviderIdentifierTypeCode4],[OtherProviderIdentifierTypeCode40],[OtherProviderIdentifierTypeCode41],[OtherProviderIdentifierTypeCode42],[OtherProviderIdentifierTypeCode43],[OtherProviderIdentifierTypeCode44],[OtherProviderIdentifierTypeCode45],[OtherProviderIdentifierTypeCode46],[OtherProviderIdentifierTypeCode47],[OtherProviderIdentifierTypeCode48],[OtherProviderIdentifierTypeCode49],[OtherProviderIdentifierTypeCode5],[OtherProviderIdentifierTypeCode50],[OtherProviderIdentifierTypeCode6],[OtherProviderIdentifierTypeCode7],[OtherProviderIdentifierTypeCode8],[OtherProviderIdentifierTypeCode9],[ParentOrganizationLBN],[ParentOrganizationTIN],[ProviderBusinessMailingAddressCityName],[ProviderBusinessMailingAddressCountryCodeIfoutsideUS],[ProviderBusinessMailingAddressFaxNumber],[ProviderBusinessMailingAddressPostalCode],[ProviderBusinessMailingAddressStateName],[ProviderBusinessMailingAddressTelephoneNumber],[ProviderBusinessPracticeLocationAddressCityName],[ProviderBusinessPracticeLocationAddressCountryCodeIfoutsideUS],[ProviderBusinessPracticeLocationAddressFaxNumber],[ProviderBusinessPracticeLocationAddressPostalCode],[ProviderBusinessPracticeLocationAddressStateName],[ProviderBusinessPracticeLocationAddressTelephoneNumber],[ProviderCredentialText],[ProviderEnumerationDate],[ProviderFirstLineBusinessMailingAddress],[ProviderFirstLineBusinessPracticeLocationAddress],[ProviderFirstName],[ProviderGenderCode],[ProviderLastNameLegalName],[ProviderLicenseNumber1],[ProviderLicenseNumber10],[ProviderLicenseNumber11],[ProviderLicenseNumber12],[ProviderLicenseNumber13],[ProviderLicenseNumber14],[ProviderLicenseNumber15],[ProviderLicenseNumber2],[ProviderLicenseNumber3],[ProviderLicenseNumber4],[ProviderLicenseNumber5],[ProviderLicenseNumber6],[ProviderLicenseNumber7],[ProviderLicenseNumber8],[ProviderLicenseNumber9],[ProviderLicenseNumberStateCode1],[ProviderLicenseNumberStateCode10],[ProviderLicenseNumberStateCode11],[ProviderLicenseNumberStateCode12],[ProviderLicenseNumberStateCode13],[ProviderLicenseNumberStateCode14],[ProviderLicenseNumberStateCode15],[ProviderLicenseNumberStateCode2],[ProviderLicenseNumberStateCode3],[ProviderLicenseNumberStateCode4],[ProviderLicenseNumberStateCode5],[ProviderLicenseNumberStateCode6],[ProviderLicenseNumberStateCode7],[ProviderLicenseNumberStateCode8],[ProviderLicenseNumberStateCode9],[ProviderMiddleName],[ProviderNamePrefixText],[ProviderNameSuffixText],[ProviderOrganizationNameLegalBusinessName],[ProviderOtherCredentialText],[ProviderOtherFirstName],[ProviderOtherLastName],[ProviderOtherLastNameTypeCode],[ProviderOtherMiddleName],[ProviderOtherNamePrefixText],[ProviderOtherNameSuffixText],[ProviderOtherOrganizationName],[ProviderOtherOrganizationNameTypeCode],[ProviderSecondLineBusinessMailingAddress],[ProviderSecondLineBusinessPracticeLocationAddress],[ReplacementNPI])

    -- Begin Values List
    Values(@AuthorizedOfficialCredentialText, @AuthorizedOfficialFirstName, @AuthorizedOfficialLastName, @AuthorizedOfficialMiddleName, @AuthorizedOfficialNamePrefixText, @AuthorizedOfficialNameSuffixText, @AuthorizedOfficialTelephoneNumber, @AuthorizedOfficialTitleorPosition, @EmployerIdentificationNumberEIN, @EntityTypeCode, @HealthcareProviderPrimaryTaxonomySwitch1, @HealthcareProviderPrimaryTaxonomySwitch10, @HealthcareProviderPrimaryTaxonomySwitch11, @HealthcareProviderPrimaryTaxonomySwitch12, @HealthcareProviderPrimaryTaxonomySwitch13, @HealthcareProviderPrimaryTaxonomySwitch14, @HealthcareProviderPrimaryTaxonomySwitch15, @HealthcareProviderPrimaryTaxonomySwitch2, @HealthcareProviderPrimaryTaxonomySwitch3, @HealthcareProviderPrimaryTaxonomySwitch4, @HealthcareProviderPrimaryTaxonomySwitch5, @HealthcareProviderPrimaryTaxonomySwitch6, @HealthcareProviderPrimaryTaxonomySwitch7, @HealthcareProviderPrimaryTaxonomySwitch8, @HealthcareProviderPrimaryTaxonomySwitch9, @HealthcareProviderTaxonomyCode1, @HealthcareProviderTaxonomyCode10, @HealthcareProviderTaxonomyCode11, @HealthcareProviderTaxonomyCode12, @HealthcareProviderTaxonomyCode13, @HealthcareProviderTaxonomyCode14, @HealthcareProviderTaxonomyCode15, @HealthcareProviderTaxonomyCode2, @HealthcareProviderTaxonomyCode3, @HealthcareProviderTaxonomyCode4, @HealthcareProviderTaxonomyCode5, @HealthcareProviderTaxonomyCode6, @HealthcareProviderTaxonomyCode7, @HealthcareProviderTaxonomyCode8, @HealthcareProviderTaxonomyCode9, @HealthcareProviderTaxonomyGroup1, @HealthcareProviderTaxonomyGroup10, @HealthcareProviderTaxonomyGroup11, @HealthcareProviderTaxonomyGroup12, @HealthcareProviderTaxonomyGroup13, @HealthcareProviderTaxonomyGroup14, @HealthcareProviderTaxonomyGroup15, @HealthcareProviderTaxonomyGroup2, @HealthcareProviderTaxonomyGroup3, @HealthcareProviderTaxonomyGroup4, @HealthcareProviderTaxonomyGroup5, @HealthcareProviderTaxonomyGroup6, @HealthcareProviderTaxonomyGroup7, @HealthcareProviderTaxonomyGroup8, @HealthcareProviderTaxonomyGroup9, @IsOrganizationSubpart, @IsSoleProprietor, @LastUpdateDate, @NPI, @NPIDeactivationDate, @NPIDeactivationReasonCode, @NPIReactivationDate, @OtherProviderIdentifier1, @OtherProviderIdentifier10, @OtherProviderIdentifier11, @OtherProviderIdentifier12, @OtherProviderIdentifier13, @OtherProviderIdentifier14, @OtherProviderIdentifier15, @OtherProviderIdentifier16, @OtherProviderIdentifier17, @OtherProviderIdentifier18, @OtherProviderIdentifier19, @OtherProviderIdentifier2, @OtherProviderIdentifier20, @OtherProviderIdentifier21, @OtherProviderIdentifier22, @OtherProviderIdentifier23, @OtherProviderIdentifier24, @OtherProviderIdentifier25, @OtherProviderIdentifier26, @OtherProviderIdentifier27, @OtherProviderIdentifier28, @OtherProviderIdentifier29, @OtherProviderIdentifier3, @OtherProviderIdentifier30, @OtherProviderIdentifier31, @OtherProviderIdentifier32, @OtherProviderIdentifier33, @OtherProviderIdentifier34, @OtherProviderIdentifier35, @OtherProviderIdentifier36, @OtherProviderIdentifier37, @OtherProviderIdentifier38, @OtherProviderIdentifier39, @OtherProviderIdentifier4, @OtherProviderIdentifier40, @OtherProviderIdentifier41, @OtherProviderIdentifier42, @OtherProviderIdentifier43, @OtherProviderIdentifier44, @OtherProviderIdentifier45, @OtherProviderIdentifier46, @OtherProviderIdentifier47, @OtherProviderIdentifier48, @OtherProviderIdentifier49, @OtherProviderIdentifier5, @OtherProviderIdentifier50, @OtherProviderIdentifier6, @OtherProviderIdentifier7, @OtherProviderIdentifier8, @OtherProviderIdentifier9, @OtherProviderIdentifierIssuer1, @OtherProviderIdentifierIssuer10, @OtherProviderIdentifierIssuer11, @OtherProviderIdentifierIssuer12, @OtherProviderIdentifierIssuer13, @OtherProviderIdentifierIssuer14, @OtherProviderIdentifierIssuer15, @OtherProviderIdentifierIssuer16, @OtherProviderIdentifierIssuer17, @OtherProviderIdentifierIssuer18, @OtherProviderIdentifierIssuer19, @OtherProviderIdentifierIssuer2, @OtherProviderIdentifierIssuer20, @OtherProviderIdentifierIssuer21, @OtherProviderIdentifierIssuer22, @OtherProviderIdentifierIssuer23, @OtherProviderIdentifierIssuer24, @OtherProviderIdentifierIssuer25, @OtherProviderIdentifierIssuer26, @OtherProviderIdentifierIssuer27, @OtherProviderIdentifierIssuer28, @OtherProviderIdentifierIssuer29, @OtherProviderIdentifierIssuer3, @OtherProviderIdentifierIssuer30, @OtherProviderIdentifierIssuer31, @OtherProviderIdentifierIssuer32, @OtherProviderIdentifierIssuer33, @OtherProviderIdentifierIssuer34, @OtherProviderIdentifierIssuer35, @OtherProviderIdentifierIssuer36, @OtherProviderIdentifierIssuer37, @OtherProviderIdentifierIssuer38, @OtherProviderIdentifierIssuer39, @OtherProviderIdentifierIssuer4, @OtherProviderIdentifierIssuer40, @OtherProviderIdentifierIssuer41, @OtherProviderIdentifierIssuer42, @OtherProviderIdentifierIssuer43, @OtherProviderIdentifierIssuer44, @OtherProviderIdentifierIssuer45, @OtherProviderIdentifierIssuer46, @OtherProviderIdentifierIssuer47, @OtherProviderIdentifierIssuer48, @OtherProviderIdentifierIssuer49, @OtherProviderIdentifierIssuer5, @OtherProviderIdentifierIssuer50, @OtherProviderIdentifierIssuer6, @OtherProviderIdentifierIssuer7, @OtherProviderIdentifierIssuer8, @OtherProviderIdentifierIssuer9, @OtherProviderIdentifierState1, @OtherProviderIdentifierState10, @OtherProviderIdentifierState11, @OtherProviderIdentifierState12, @OtherProviderIdentifierState13, @OtherProviderIdentifierState14, @OtherProviderIdentifierState15, @OtherProviderIdentifierState16, @OtherProviderIdentifierState17, @OtherProviderIdentifierState18, @OtherProviderIdentifierState19, @OtherProviderIdentifierState2, @OtherProviderIdentifierState20, @OtherProviderIdentifierState21, @OtherProviderIdentifierState22, @OtherProviderIdentifierState23, @OtherProviderIdentifierState24, @OtherProviderIdentifierState25, @OtherProviderIdentifierState26, @OtherProviderIdentifierState27, @OtherProviderIdentifierState28, @OtherProviderIdentifierState29, @OtherProviderIdentifierState3, @OtherProviderIdentifierState30, @OtherProviderIdentifierState31, @OtherProviderIdentifierState32, @OtherProviderIdentifierState33, @OtherProviderIdentifierState34, @OtherProviderIdentifierState35, @OtherProviderIdentifierState36, @OtherProviderIdentifierState37, @OtherProviderIdentifierState38, @OtherProviderIdentifierState39, @OtherProviderIdentifierState4, @OtherProviderIdentifierState40, @OtherProviderIdentifierState41, @OtherProviderIdentifierState42, @OtherProviderIdentifierState43, @OtherProviderIdentifierState44, @OtherProviderIdentifierState45, @OtherProviderIdentifierState46, @OtherProviderIdentifierState47, @OtherProviderIdentifierState48, @OtherProviderIdentifierState49, @OtherProviderIdentifierState5, @OtherProviderIdentifierState50, @OtherProviderIdentifierState6, @OtherProviderIdentifierState7, @OtherProviderIdentifierState8, @OtherProviderIdentifierState9, @OtherProviderIdentifierTypeCode1, @OtherProviderIdentifierTypeCode10, @OtherProviderIdentifierTypeCode11, @OtherProviderIdentifierTypeCode12, @OtherProviderIdentifierTypeCode13, @OtherProviderIdentifierTypeCode14, @OtherProviderIdentifierTypeCode15, @OtherProviderIdentifierTypeCode16, @OtherProviderIdentifierTypeCode17, @OtherProviderIdentifierTypeCode18, @OtherProviderIdentifierTypeCode19, @OtherProviderIdentifierTypeCode2, @OtherProviderIdentifierTypeCode20, @OtherProviderIdentifierTypeCode21, @OtherProviderIdentifierTypeCode22, @OtherProviderIdentifierTypeCode23, @OtherProviderIdentifierTypeCode24, @OtherProviderIdentifierTypeCode25, @OtherProviderIdentifierTypeCode26, @OtherProviderIdentifierTypeCode27, @OtherProviderIdentifierTypeCode28, @OtherProviderIdentifierTypeCode29, @OtherProviderIdentifierTypeCode3, @OtherProviderIdentifierTypeCode30, @OtherProviderIdentifierTypeCode31, @OtherProviderIdentifierTypeCode32, @OtherProviderIdentifierTypeCode33, @OtherProviderIdentifierTypeCode34, @OtherProviderIdentifierTypeCode35, @OtherProviderIdentifierTypeCode36, @OtherProviderIdentifierTypeCode37, @OtherProviderIdentifierTypeCode38, @OtherProviderIdentifierTypeCode39, @OtherProviderIdentifierTypeCode4, @OtherProviderIdentifierTypeCode40, @OtherProviderIdentifierTypeCode41, @OtherProviderIdentifierTypeCode42, @OtherProviderIdentifierTypeCode43, @OtherProviderIdentifierTypeCode44, @OtherProviderIdentifierTypeCode45, @OtherProviderIdentifierTypeCode46, @OtherProviderIdentifierTypeCode47, @OtherProviderIdentifierTypeCode48, @OtherProviderIdentifierTypeCode49, @OtherProviderIdentifierTypeCode5, @OtherProviderIdentifierTypeCode50, @OtherProviderIdentifierTypeCode6, @OtherProviderIdentifierTypeCode7, @OtherProviderIdentifierTypeCode8, @OtherProviderIdentifierTypeCode9, @ParentOrganizationLBN, @ParentOrganizationTIN, @ProviderBusinessMailingAddressCityName, @ProviderBusinessMailingAddressCountryCodeIfoutsideUS, @ProviderBusinessMailingAddressFaxNumber, @ProviderBusinessMailingAddressPostalCode, @ProviderBusinessMailingAddressStateName, @ProviderBusinessMailingAddressTelephoneNumber, @ProviderBusinessPracticeLocationAddressCityName, @ProviderBusinessPracticeLocationAddressCountryCodeIfoutsideUS, @ProviderBusinessPracticeLocationAddressFaxNumber, @ProviderBusinessPracticeLocationAddressPostalCode, @ProviderBusinessPracticeLocationAddressStateName, @ProviderBusinessPracticeLocationAddressTelephoneNumber, @ProviderCredentialText, @ProviderEnumerationDate, @ProviderFirstLineBusinessMailingAddress, @ProviderFirstLineBusinessPracticeLocationAddress, @ProviderFirstName, @ProviderGenderCode, @ProviderLastNameLegalName, @ProviderLicenseNumber1, @ProviderLicenseNumber10, @ProviderLicenseNumber11, @ProviderLicenseNumber12, @ProviderLicenseNumber13, @ProviderLicenseNumber14, @ProviderLicenseNumber15, @ProviderLicenseNumber2, @ProviderLicenseNumber3, @ProviderLicenseNumber4, @ProviderLicenseNumber5, @ProviderLicenseNumber6, @ProviderLicenseNumber7, @ProviderLicenseNumber8, @ProviderLicenseNumber9, @ProviderLicenseNumberStateCode1, @ProviderLicenseNumberStateCode10, @ProviderLicenseNumberStateCode11, @ProviderLicenseNumberStateCode12, @ProviderLicenseNumberStateCode13, @ProviderLicenseNumberStateCode14, @ProviderLicenseNumberStateCode15, @ProviderLicenseNumberStateCode2, @ProviderLicenseNumberStateCode3, @ProviderLicenseNumberStateCode4, @ProviderLicenseNumberStateCode5, @ProviderLicenseNumberStateCode6, @ProviderLicenseNumberStateCode7, @ProviderLicenseNumberStateCode8, @ProviderLicenseNumberStateCode9, @ProviderMiddleName, @ProviderNamePrefixText, @ProviderNameSuffixText, @ProviderOrganizationNameLegalBusinessName, @ProviderOtherCredentialText, @ProviderOtherFirstName, @ProviderOtherLastName, @ProviderOtherLastNameTypeCode, @ProviderOtherMiddleName, @ProviderOtherNamePrefixText, @ProviderOtherNameSuffixText, @ProviderOtherOrganizationName, @ProviderOtherOrganizationNameTypeCode, @ProviderSecondLineBusinessMailingAddress, @ProviderSecondLineBusinessPracticeLocationAddress, @ReplacementNPI)

    -- Return ID of new record
    SELECT SCOPE_IDENTITY()

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: RawImport_Update
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   9/29/2019
-- Description:    Update an existing RawImport
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('RawImport_Update'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure RawImport_Update

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.RawImport_Update') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure RawImport_Update >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure RawImport_Update >>>'

    End

GO

Create PROCEDURE RawImport_Update

    -- Add the parameters for the stored procedure here
    @AuthorizedOfficialCredentialText nvarchar(128),
    @AuthorizedOfficialFirstName nvarchar(128),
    @AuthorizedOfficialLastName nvarchar(128),
    @AuthorizedOfficialMiddleName nvarchar(128),
    @AuthorizedOfficialNamePrefixText nvarchar(128),
    @AuthorizedOfficialNameSuffixText nvarchar(128),
    @AuthorizedOfficialTelephoneNumber nvarchar(128),
    @AuthorizedOfficialTitleorPosition nvarchar(128),
    @EmployerIdentificationNumberEIN nvarchar(128),
    @EntityTypeCode nvarchar(128),
    @HealthcareProviderPrimaryTaxonomySwitch1 nvarchar(128),
    @HealthcareProviderPrimaryTaxonomySwitch10 nvarchar(128),
    @HealthcareProviderPrimaryTaxonomySwitch11 nvarchar(128),
    @HealthcareProviderPrimaryTaxonomySwitch12 nvarchar(128),
    @HealthcareProviderPrimaryTaxonomySwitch13 nvarchar(128),
    @HealthcareProviderPrimaryTaxonomySwitch14 nvarchar(128),
    @HealthcareProviderPrimaryTaxonomySwitch15 nvarchar(128),
    @HealthcareProviderPrimaryTaxonomySwitch2 nvarchar(128),
    @HealthcareProviderPrimaryTaxonomySwitch3 nvarchar(128),
    @HealthcareProviderPrimaryTaxonomySwitch4 nvarchar(128),
    @HealthcareProviderPrimaryTaxonomySwitch5 nvarchar(128),
    @HealthcareProviderPrimaryTaxonomySwitch6 nvarchar(128),
    @HealthcareProviderPrimaryTaxonomySwitch7 nvarchar(128),
    @HealthcareProviderPrimaryTaxonomySwitch8 nvarchar(128),
    @HealthcareProviderPrimaryTaxonomySwitch9 nvarchar(128),
    @HealthcareProviderTaxonomyCode1 nvarchar(128),
    @HealthcareProviderTaxonomyCode10 nvarchar(128),
    @HealthcareProviderTaxonomyCode11 nvarchar(128),
    @HealthcareProviderTaxonomyCode12 nvarchar(128),
    @HealthcareProviderTaxonomyCode13 nvarchar(128),
    @HealthcareProviderTaxonomyCode14 nvarchar(128),
    @HealthcareProviderTaxonomyCode15 nvarchar(128),
    @HealthcareProviderTaxonomyCode2 nvarchar(128),
    @HealthcareProviderTaxonomyCode3 nvarchar(128),
    @HealthcareProviderTaxonomyCode4 nvarchar(128),
    @HealthcareProviderTaxonomyCode5 nvarchar(128),
    @HealthcareProviderTaxonomyCode6 nvarchar(128),
    @HealthcareProviderTaxonomyCode7 nvarchar(128),
    @HealthcareProviderTaxonomyCode8 nvarchar(128),
    @HealthcareProviderTaxonomyCode9 nvarchar(128),
    @HealthcareProviderTaxonomyGroup1 nvarchar(128),
    @HealthcareProviderTaxonomyGroup10 nvarchar(128),
    @HealthcareProviderTaxonomyGroup11 nvarchar(128),
    @HealthcareProviderTaxonomyGroup12 nvarchar(128),
    @HealthcareProviderTaxonomyGroup13 nvarchar(128),
    @HealthcareProviderTaxonomyGroup14 nvarchar(128),
    @HealthcareProviderTaxonomyGroup15 nvarchar(128),
    @HealthcareProviderTaxonomyGroup2 nvarchar(128),
    @HealthcareProviderTaxonomyGroup3 nvarchar(128),
    @HealthcareProviderTaxonomyGroup4 nvarchar(128),
    @HealthcareProviderTaxonomyGroup5 nvarchar(128),
    @HealthcareProviderTaxonomyGroup6 nvarchar(128),
    @HealthcareProviderTaxonomyGroup7 nvarchar(128),
    @HealthcareProviderTaxonomyGroup8 nvarchar(128),
    @HealthcareProviderTaxonomyGroup9 nvarchar(128),
    @Id int,
    @IsOrganizationSubpart nvarchar(128),
    @IsSoleProprietor nvarchar(128),
    @LastUpdateDate nvarchar(128),
    @NPI nvarchar(128),
    @NPIDeactivationDate nvarchar(128),
    @NPIDeactivationReasonCode nvarchar(128),
    @NPIReactivationDate nvarchar(128),
    @OtherProviderIdentifier1 nvarchar(128),
    @OtherProviderIdentifier10 nvarchar(128),
    @OtherProviderIdentifier11 nvarchar(128),
    @OtherProviderIdentifier12 nvarchar(128),
    @OtherProviderIdentifier13 nvarchar(128),
    @OtherProviderIdentifier14 nvarchar(128),
    @OtherProviderIdentifier15 nvarchar(128),
    @OtherProviderIdentifier16 nvarchar(128),
    @OtherProviderIdentifier17 nvarchar(128),
    @OtherProviderIdentifier18 nvarchar(128),
    @OtherProviderIdentifier19 nvarchar(128),
    @OtherProviderIdentifier2 nvarchar(128),
    @OtherProviderIdentifier20 nvarchar(128),
    @OtherProviderIdentifier21 nvarchar(128),
    @OtherProviderIdentifier22 nvarchar(128),
    @OtherProviderIdentifier23 nvarchar(128),
    @OtherProviderIdentifier24 nvarchar(128),
    @OtherProviderIdentifier25 nvarchar(128),
    @OtherProviderIdentifier26 nvarchar(128),
    @OtherProviderIdentifier27 nvarchar(128),
    @OtherProviderIdentifier28 nvarchar(128),
    @OtherProviderIdentifier29 nvarchar(128),
    @OtherProviderIdentifier3 nvarchar(128),
    @OtherProviderIdentifier30 nvarchar(128),
    @OtherProviderIdentifier31 nvarchar(128),
    @OtherProviderIdentifier32 nvarchar(128),
    @OtherProviderIdentifier33 nvarchar(128),
    @OtherProviderIdentifier34 nvarchar(128),
    @OtherProviderIdentifier35 nvarchar(128),
    @OtherProviderIdentifier36 nvarchar(128),
    @OtherProviderIdentifier37 nvarchar(128),
    @OtherProviderIdentifier38 nvarchar(128),
    @OtherProviderIdentifier39 nvarchar(128),
    @OtherProviderIdentifier4 nvarchar(128),
    @OtherProviderIdentifier40 nvarchar(128),
    @OtherProviderIdentifier41 nvarchar(128),
    @OtherProviderIdentifier42 nvarchar(128),
    @OtherProviderIdentifier43 nvarchar(128),
    @OtherProviderIdentifier44 nvarchar(128),
    @OtherProviderIdentifier45 nvarchar(128),
    @OtherProviderIdentifier46 nvarchar(128),
    @OtherProviderIdentifier47 nvarchar(128),
    @OtherProviderIdentifier48 nvarchar(128),
    @OtherProviderIdentifier49 nvarchar(128),
    @OtherProviderIdentifier5 nvarchar(128),
    @OtherProviderIdentifier50 nvarchar(128),
    @OtherProviderIdentifier6 nvarchar(128),
    @OtherProviderIdentifier7 nvarchar(128),
    @OtherProviderIdentifier8 nvarchar(128),
    @OtherProviderIdentifier9 nvarchar(128),
    @OtherProviderIdentifierIssuer1 nvarchar(128),
    @OtherProviderIdentifierIssuer10 nvarchar(128),
    @OtherProviderIdentifierIssuer11 nvarchar(128),
    @OtherProviderIdentifierIssuer12 nvarchar(128),
    @OtherProviderIdentifierIssuer13 nvarchar(128),
    @OtherProviderIdentifierIssuer14 nvarchar(128),
    @OtherProviderIdentifierIssuer15 nvarchar(128),
    @OtherProviderIdentifierIssuer16 nvarchar(128),
    @OtherProviderIdentifierIssuer17 nvarchar(128),
    @OtherProviderIdentifierIssuer18 nvarchar(128),
    @OtherProviderIdentifierIssuer19 nvarchar(128),
    @OtherProviderIdentifierIssuer2 nvarchar(128),
    @OtherProviderIdentifierIssuer20 nvarchar(128),
    @OtherProviderIdentifierIssuer21 nvarchar(128),
    @OtherProviderIdentifierIssuer22 nvarchar(128),
    @OtherProviderIdentifierIssuer23 nvarchar(128),
    @OtherProviderIdentifierIssuer24 nvarchar(128),
    @OtherProviderIdentifierIssuer25 nvarchar(128),
    @OtherProviderIdentifierIssuer26 nvarchar(128),
    @OtherProviderIdentifierIssuer27 nvarchar(128),
    @OtherProviderIdentifierIssuer28 nvarchar(128),
    @OtherProviderIdentifierIssuer29 nvarchar(128),
    @OtherProviderIdentifierIssuer3 nvarchar(128),
    @OtherProviderIdentifierIssuer30 nvarchar(128),
    @OtherProviderIdentifierIssuer31 nvarchar(128),
    @OtherProviderIdentifierIssuer32 nvarchar(128),
    @OtherProviderIdentifierIssuer33 nvarchar(128),
    @OtherProviderIdentifierIssuer34 nvarchar(128),
    @OtherProviderIdentifierIssuer35 nvarchar(128),
    @OtherProviderIdentifierIssuer36 nvarchar(128),
    @OtherProviderIdentifierIssuer37 nvarchar(128),
    @OtherProviderIdentifierIssuer38 nvarchar(128),
    @OtherProviderIdentifierIssuer39 nvarchar(128),
    @OtherProviderIdentifierIssuer4 nvarchar(128),
    @OtherProviderIdentifierIssuer40 nvarchar(128),
    @OtherProviderIdentifierIssuer41 nvarchar(128),
    @OtherProviderIdentifierIssuer42 nvarchar(128),
    @OtherProviderIdentifierIssuer43 nvarchar(128),
    @OtherProviderIdentifierIssuer44 nvarchar(128),
    @OtherProviderIdentifierIssuer45 nvarchar(128),
    @OtherProviderIdentifierIssuer46 nvarchar(128),
    @OtherProviderIdentifierIssuer47 nvarchar(128),
    @OtherProviderIdentifierIssuer48 nvarchar(128),
    @OtherProviderIdentifierIssuer49 nvarchar(128),
    @OtherProviderIdentifierIssuer5 nvarchar(128),
    @OtherProviderIdentifierIssuer50 nvarchar(128),
    @OtherProviderIdentifierIssuer6 nvarchar(128),
    @OtherProviderIdentifierIssuer7 nvarchar(128),
    @OtherProviderIdentifierIssuer8 nvarchar(128),
    @OtherProviderIdentifierIssuer9 nvarchar(128),
    @OtherProviderIdentifierState1 nvarchar(128),
    @OtherProviderIdentifierState10 nvarchar(128),
    @OtherProviderIdentifierState11 nvarchar(128),
    @OtherProviderIdentifierState12 nvarchar(128),
    @OtherProviderIdentifierState13 nvarchar(128),
    @OtherProviderIdentifierState14 nvarchar(128),
    @OtherProviderIdentifierState15 nvarchar(128),
    @OtherProviderIdentifierState16 nvarchar(128),
    @OtherProviderIdentifierState17 nvarchar(128),
    @OtherProviderIdentifierState18 nvarchar(128),
    @OtherProviderIdentifierState19 nvarchar(128),
    @OtherProviderIdentifierState2 nvarchar(128),
    @OtherProviderIdentifierState20 nvarchar(128),
    @OtherProviderIdentifierState21 nvarchar(128),
    @OtherProviderIdentifierState22 nvarchar(128),
    @OtherProviderIdentifierState23 nvarchar(128),
    @OtherProviderIdentifierState24 nvarchar(128),
    @OtherProviderIdentifierState25 nvarchar(128),
    @OtherProviderIdentifierState26 nvarchar(128),
    @OtherProviderIdentifierState27 nvarchar(128),
    @OtherProviderIdentifierState28 nvarchar(128),
    @OtherProviderIdentifierState29 nvarchar(128),
    @OtherProviderIdentifierState3 nvarchar(128),
    @OtherProviderIdentifierState30 nvarchar(128),
    @OtherProviderIdentifierState31 nvarchar(128),
    @OtherProviderIdentifierState32 nvarchar(128),
    @OtherProviderIdentifierState33 nvarchar(128),
    @OtherProviderIdentifierState34 nvarchar(128),
    @OtherProviderIdentifierState35 nvarchar(128),
    @OtherProviderIdentifierState36 nvarchar(128),
    @OtherProviderIdentifierState37 nvarchar(128),
    @OtherProviderIdentifierState38 nvarchar(128),
    @OtherProviderIdentifierState39 nvarchar(128),
    @OtherProviderIdentifierState4 nvarchar(128),
    @OtherProviderIdentifierState40 nvarchar(128),
    @OtherProviderIdentifierState41 nvarchar(128),
    @OtherProviderIdentifierState42 nvarchar(128),
    @OtherProviderIdentifierState43 nvarchar(128),
    @OtherProviderIdentifierState44 nvarchar(128),
    @OtherProviderIdentifierState45 nvarchar(128),
    @OtherProviderIdentifierState46 nvarchar(128),
    @OtherProviderIdentifierState47 nvarchar(128),
    @OtherProviderIdentifierState48 nvarchar(128),
    @OtherProviderIdentifierState49 nvarchar(128),
    @OtherProviderIdentifierState5 nvarchar(128),
    @OtherProviderIdentifierState50 nvarchar(128),
    @OtherProviderIdentifierState6 nvarchar(128),
    @OtherProviderIdentifierState7 nvarchar(128),
    @OtherProviderIdentifierState8 nvarchar(128),
    @OtherProviderIdentifierState9 nvarchar(128),
    @OtherProviderIdentifierTypeCode1 nvarchar(128),
    @OtherProviderIdentifierTypeCode10 nvarchar(128),
    @OtherProviderIdentifierTypeCode11 nvarchar(128),
    @OtherProviderIdentifierTypeCode12 nvarchar(128),
    @OtherProviderIdentifierTypeCode13 nvarchar(128),
    @OtherProviderIdentifierTypeCode14 nvarchar(128),
    @OtherProviderIdentifierTypeCode15 nvarchar(128),
    @OtherProviderIdentifierTypeCode16 nvarchar(128),
    @OtherProviderIdentifierTypeCode17 nvarchar(128),
    @OtherProviderIdentifierTypeCode18 nvarchar(128),
    @OtherProviderIdentifierTypeCode19 nvarchar(128),
    @OtherProviderIdentifierTypeCode2 nvarchar(128),
    @OtherProviderIdentifierTypeCode20 nvarchar(128),
    @OtherProviderIdentifierTypeCode21 nvarchar(128),
    @OtherProviderIdentifierTypeCode22 nvarchar(128),
    @OtherProviderIdentifierTypeCode23 nvarchar(128),
    @OtherProviderIdentifierTypeCode24 nvarchar(128),
    @OtherProviderIdentifierTypeCode25 nvarchar(128),
    @OtherProviderIdentifierTypeCode26 nvarchar(128),
    @OtherProviderIdentifierTypeCode27 nvarchar(128),
    @OtherProviderIdentifierTypeCode28 nvarchar(128),
    @OtherProviderIdentifierTypeCode29 nvarchar(128),
    @OtherProviderIdentifierTypeCode3 nvarchar(128),
    @OtherProviderIdentifierTypeCode30 nvarchar(128),
    @OtherProviderIdentifierTypeCode31 nvarchar(128),
    @OtherProviderIdentifierTypeCode32 nvarchar(128),
    @OtherProviderIdentifierTypeCode33 nvarchar(128),
    @OtherProviderIdentifierTypeCode34 nvarchar(128),
    @OtherProviderIdentifierTypeCode35 nvarchar(128),
    @OtherProviderIdentifierTypeCode36 nvarchar(128),
    @OtherProviderIdentifierTypeCode37 nvarchar(128),
    @OtherProviderIdentifierTypeCode38 nvarchar(128),
    @OtherProviderIdentifierTypeCode39 nvarchar(128),
    @OtherProviderIdentifierTypeCode4 nvarchar(128),
    @OtherProviderIdentifierTypeCode40 nvarchar(128),
    @OtherProviderIdentifierTypeCode41 nvarchar(128),
    @OtherProviderIdentifierTypeCode42 nvarchar(128),
    @OtherProviderIdentifierTypeCode43 nvarchar(128),
    @OtherProviderIdentifierTypeCode44 nvarchar(128),
    @OtherProviderIdentifierTypeCode45 nvarchar(128),
    @OtherProviderIdentifierTypeCode46 nvarchar(128),
    @OtherProviderIdentifierTypeCode47 nvarchar(128),
    @OtherProviderIdentifierTypeCode48 nvarchar(128),
    @OtherProviderIdentifierTypeCode49 nvarchar(128),
    @OtherProviderIdentifierTypeCode5 nvarchar(128),
    @OtherProviderIdentifierTypeCode50 nvarchar(128),
    @OtherProviderIdentifierTypeCode6 nvarchar(128),
    @OtherProviderIdentifierTypeCode7 nvarchar(128),
    @OtherProviderIdentifierTypeCode8 nvarchar(128),
    @OtherProviderIdentifierTypeCode9 nvarchar(128),
    @ParentOrganizationLBN nvarchar(128),
    @ParentOrganizationTIN nvarchar(128),
    @ProviderBusinessMailingAddressCityName nvarchar(128),
    @ProviderBusinessMailingAddressCountryCodeIfoutsideUS nvarchar(128),
    @ProviderBusinessMailingAddressFaxNumber nvarchar(128),
    @ProviderBusinessMailingAddressPostalCode nvarchar(128),
    @ProviderBusinessMailingAddressStateName nvarchar(128),
    @ProviderBusinessMailingAddressTelephoneNumber nvarchar(128),
    @ProviderBusinessPracticeLocationAddressCityName nvarchar(128),
    @ProviderBusinessPracticeLocationAddressCountryCodeIfoutsideUS nvarchar(128),
    @ProviderBusinessPracticeLocationAddressFaxNumber nvarchar(128),
    @ProviderBusinessPracticeLocationAddressPostalCode nvarchar(128),
    @ProviderBusinessPracticeLocationAddressStateName nvarchar(128),
    @ProviderBusinessPracticeLocationAddressTelephoneNumber nvarchar(128),
    @ProviderCredentialText nvarchar(128),
    @ProviderEnumerationDate nvarchar(128),
    @ProviderFirstLineBusinessMailingAddress nvarchar(128),
    @ProviderFirstLineBusinessPracticeLocationAddress nvarchar(128),
    @ProviderFirstName nvarchar(128),
    @ProviderGenderCode nvarchar(128),
    @ProviderLastNameLegalName nvarchar(128),
    @ProviderLicenseNumber1 nvarchar(128),
    @ProviderLicenseNumber10 nvarchar(128),
    @ProviderLicenseNumber11 nvarchar(128),
    @ProviderLicenseNumber12 nvarchar(128),
    @ProviderLicenseNumber13 nvarchar(128),
    @ProviderLicenseNumber14 nvarchar(128),
    @ProviderLicenseNumber15 nvarchar(128),
    @ProviderLicenseNumber2 nvarchar(128),
    @ProviderLicenseNumber3 nvarchar(128),
    @ProviderLicenseNumber4 nvarchar(128),
    @ProviderLicenseNumber5 nvarchar(128),
    @ProviderLicenseNumber6 nvarchar(128),
    @ProviderLicenseNumber7 nvarchar(128),
    @ProviderLicenseNumber8 nvarchar(128),
    @ProviderLicenseNumber9 nvarchar(128),
    @ProviderLicenseNumberStateCode1 nvarchar(128),
    @ProviderLicenseNumberStateCode10 nvarchar(128),
    @ProviderLicenseNumberStateCode11 nvarchar(128),
    @ProviderLicenseNumberStateCode12 nvarchar(128),
    @ProviderLicenseNumberStateCode13 nvarchar(128),
    @ProviderLicenseNumberStateCode14 nvarchar(128),
    @ProviderLicenseNumberStateCode15 nvarchar(128),
    @ProviderLicenseNumberStateCode2 nvarchar(128),
    @ProviderLicenseNumberStateCode3 nvarchar(128),
    @ProviderLicenseNumberStateCode4 nvarchar(128),
    @ProviderLicenseNumberStateCode5 nvarchar(128),
    @ProviderLicenseNumberStateCode6 nvarchar(128),
    @ProviderLicenseNumberStateCode7 nvarchar(128),
    @ProviderLicenseNumberStateCode8 nvarchar(128),
    @ProviderLicenseNumberStateCode9 nvarchar(128),
    @ProviderMiddleName nvarchar(128),
    @ProviderNamePrefixText nvarchar(128),
    @ProviderNameSuffixText nvarchar(128),
    @ProviderOrganizationNameLegalBusinessName nvarchar(128),
    @ProviderOtherCredentialText nvarchar(128),
    @ProviderOtherFirstName nvarchar(128),
    @ProviderOtherLastName nvarchar(128),
    @ProviderOtherLastNameTypeCode nvarchar(128),
    @ProviderOtherMiddleName nvarchar(128),
    @ProviderOtherNamePrefixText nvarchar(128),
    @ProviderOtherNameSuffixText nvarchar(128),
    @ProviderOtherOrganizationName nvarchar(128),
    @ProviderOtherOrganizationNameTypeCode nvarchar(128),
    @ProviderSecondLineBusinessMailingAddress nvarchar(128),
    @ProviderSecondLineBusinessPracticeLocationAddress nvarchar(128),
    @ReplacementNPI nvarchar(128)

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Update Statement
    Update [RawImport]

    -- Update Each field
    Set [AuthorizedOfficialCredentialText] = @AuthorizedOfficialCredentialText,
    [AuthorizedOfficialFirstName] = @AuthorizedOfficialFirstName,
    [AuthorizedOfficialLastName] = @AuthorizedOfficialLastName,
    [AuthorizedOfficialMiddleName] = @AuthorizedOfficialMiddleName,
    [AuthorizedOfficialNamePrefixText] = @AuthorizedOfficialNamePrefixText,
    [AuthorizedOfficialNameSuffixText] = @AuthorizedOfficialNameSuffixText,
    [AuthorizedOfficialTelephoneNumber] = @AuthorizedOfficialTelephoneNumber,
    [AuthorizedOfficialTitleorPosition] = @AuthorizedOfficialTitleorPosition,
    [EmployerIdentificationNumberEIN] = @EmployerIdentificationNumberEIN,
    [EntityTypeCode] = @EntityTypeCode,
    [HealthcareProviderPrimaryTaxonomySwitch1] = @HealthcareProviderPrimaryTaxonomySwitch1,
    [HealthcareProviderPrimaryTaxonomySwitch10] = @HealthcareProviderPrimaryTaxonomySwitch10,
    [HealthcareProviderPrimaryTaxonomySwitch11] = @HealthcareProviderPrimaryTaxonomySwitch11,
    [HealthcareProviderPrimaryTaxonomySwitch12] = @HealthcareProviderPrimaryTaxonomySwitch12,
    [HealthcareProviderPrimaryTaxonomySwitch13] = @HealthcareProviderPrimaryTaxonomySwitch13,
    [HealthcareProviderPrimaryTaxonomySwitch14] = @HealthcareProviderPrimaryTaxonomySwitch14,
    [HealthcareProviderPrimaryTaxonomySwitch15] = @HealthcareProviderPrimaryTaxonomySwitch15,
    [HealthcareProviderPrimaryTaxonomySwitch2] = @HealthcareProviderPrimaryTaxonomySwitch2,
    [HealthcareProviderPrimaryTaxonomySwitch3] = @HealthcareProviderPrimaryTaxonomySwitch3,
    [HealthcareProviderPrimaryTaxonomySwitch4] = @HealthcareProviderPrimaryTaxonomySwitch4,
    [HealthcareProviderPrimaryTaxonomySwitch5] = @HealthcareProviderPrimaryTaxonomySwitch5,
    [HealthcareProviderPrimaryTaxonomySwitch6] = @HealthcareProviderPrimaryTaxonomySwitch6,
    [HealthcareProviderPrimaryTaxonomySwitch7] = @HealthcareProviderPrimaryTaxonomySwitch7,
    [HealthcareProviderPrimaryTaxonomySwitch8] = @HealthcareProviderPrimaryTaxonomySwitch8,
    [HealthcareProviderPrimaryTaxonomySwitch9] = @HealthcareProviderPrimaryTaxonomySwitch9,
    [HealthcareProviderTaxonomyCode1] = @HealthcareProviderTaxonomyCode1,
    [HealthcareProviderTaxonomyCode10] = @HealthcareProviderTaxonomyCode10,
    [HealthcareProviderTaxonomyCode11] = @HealthcareProviderTaxonomyCode11,
    [HealthcareProviderTaxonomyCode12] = @HealthcareProviderTaxonomyCode12,
    [HealthcareProviderTaxonomyCode13] = @HealthcareProviderTaxonomyCode13,
    [HealthcareProviderTaxonomyCode14] = @HealthcareProviderTaxonomyCode14,
    [HealthcareProviderTaxonomyCode15] = @HealthcareProviderTaxonomyCode15,
    [HealthcareProviderTaxonomyCode2] = @HealthcareProviderTaxonomyCode2,
    [HealthcareProviderTaxonomyCode3] = @HealthcareProviderTaxonomyCode3,
    [HealthcareProviderTaxonomyCode4] = @HealthcareProviderTaxonomyCode4,
    [HealthcareProviderTaxonomyCode5] = @HealthcareProviderTaxonomyCode5,
    [HealthcareProviderTaxonomyCode6] = @HealthcareProviderTaxonomyCode6,
    [HealthcareProviderTaxonomyCode7] = @HealthcareProviderTaxonomyCode7,
    [HealthcareProviderTaxonomyCode8] = @HealthcareProviderTaxonomyCode8,
    [HealthcareProviderTaxonomyCode9] = @HealthcareProviderTaxonomyCode9,
    [HealthcareProviderTaxonomyGroup1] = @HealthcareProviderTaxonomyGroup1,
    [HealthcareProviderTaxonomyGroup10] = @HealthcareProviderTaxonomyGroup10,
    [HealthcareProviderTaxonomyGroup11] = @HealthcareProviderTaxonomyGroup11,
    [HealthcareProviderTaxonomyGroup12] = @HealthcareProviderTaxonomyGroup12,
    [HealthcareProviderTaxonomyGroup13] = @HealthcareProviderTaxonomyGroup13,
    [HealthcareProviderTaxonomyGroup14] = @HealthcareProviderTaxonomyGroup14,
    [HealthcareProviderTaxonomyGroup15] = @HealthcareProviderTaxonomyGroup15,
    [HealthcareProviderTaxonomyGroup2] = @HealthcareProviderTaxonomyGroup2,
    [HealthcareProviderTaxonomyGroup3] = @HealthcareProviderTaxonomyGroup3,
    [HealthcareProviderTaxonomyGroup4] = @HealthcareProviderTaxonomyGroup4,
    [HealthcareProviderTaxonomyGroup5] = @HealthcareProviderTaxonomyGroup5,
    [HealthcareProviderTaxonomyGroup6] = @HealthcareProviderTaxonomyGroup6,
    [HealthcareProviderTaxonomyGroup7] = @HealthcareProviderTaxonomyGroup7,
    [HealthcareProviderTaxonomyGroup8] = @HealthcareProviderTaxonomyGroup8,
    [HealthcareProviderTaxonomyGroup9] = @HealthcareProviderTaxonomyGroup9,
    [IsOrganizationSubpart] = @IsOrganizationSubpart,
    [IsSoleProprietor] = @IsSoleProprietor,
    [LastUpdateDate] = @LastUpdateDate,
    [NPI] = @NPI,
    [NPIDeactivationDate] = @NPIDeactivationDate,
    [NPIDeactivationReasonCode] = @NPIDeactivationReasonCode,
    [NPIReactivationDate] = @NPIReactivationDate,
    [OtherProviderIdentifier1] = @OtherProviderIdentifier1,
    [OtherProviderIdentifier10] = @OtherProviderIdentifier10,
    [OtherProviderIdentifier11] = @OtherProviderIdentifier11,
    [OtherProviderIdentifier12] = @OtherProviderIdentifier12,
    [OtherProviderIdentifier13] = @OtherProviderIdentifier13,
    [OtherProviderIdentifier14] = @OtherProviderIdentifier14,
    [OtherProviderIdentifier15] = @OtherProviderIdentifier15,
    [OtherProviderIdentifier16] = @OtherProviderIdentifier16,
    [OtherProviderIdentifier17] = @OtherProviderIdentifier17,
    [OtherProviderIdentifier18] = @OtherProviderIdentifier18,
    [OtherProviderIdentifier19] = @OtherProviderIdentifier19,
    [OtherProviderIdentifier2] = @OtherProviderIdentifier2,
    [OtherProviderIdentifier20] = @OtherProviderIdentifier20,
    [OtherProviderIdentifier21] = @OtherProviderIdentifier21,
    [OtherProviderIdentifier22] = @OtherProviderIdentifier22,
    [OtherProviderIdentifier23] = @OtherProviderIdentifier23,
    [OtherProviderIdentifier24] = @OtherProviderIdentifier24,
    [OtherProviderIdentifier25] = @OtherProviderIdentifier25,
    [OtherProviderIdentifier26] = @OtherProviderIdentifier26,
    [OtherProviderIdentifier27] = @OtherProviderIdentifier27,
    [OtherProviderIdentifier28] = @OtherProviderIdentifier28,
    [OtherProviderIdentifier29] = @OtherProviderIdentifier29,
    [OtherProviderIdentifier3] = @OtherProviderIdentifier3,
    [OtherProviderIdentifier30] = @OtherProviderIdentifier30,
    [OtherProviderIdentifier31] = @OtherProviderIdentifier31,
    [OtherProviderIdentifier32] = @OtherProviderIdentifier32,
    [OtherProviderIdentifier33] = @OtherProviderIdentifier33,
    [OtherProviderIdentifier34] = @OtherProviderIdentifier34,
    [OtherProviderIdentifier35] = @OtherProviderIdentifier35,
    [OtherProviderIdentifier36] = @OtherProviderIdentifier36,
    [OtherProviderIdentifier37] = @OtherProviderIdentifier37,
    [OtherProviderIdentifier38] = @OtherProviderIdentifier38,
    [OtherProviderIdentifier39] = @OtherProviderIdentifier39,
    [OtherProviderIdentifier4] = @OtherProviderIdentifier4,
    [OtherProviderIdentifier40] = @OtherProviderIdentifier40,
    [OtherProviderIdentifier41] = @OtherProviderIdentifier41,
    [OtherProviderIdentifier42] = @OtherProviderIdentifier42,
    [OtherProviderIdentifier43] = @OtherProviderIdentifier43,
    [OtherProviderIdentifier44] = @OtherProviderIdentifier44,
    [OtherProviderIdentifier45] = @OtherProviderIdentifier45,
    [OtherProviderIdentifier46] = @OtherProviderIdentifier46,
    [OtherProviderIdentifier47] = @OtherProviderIdentifier47,
    [OtherProviderIdentifier48] = @OtherProviderIdentifier48,
    [OtherProviderIdentifier49] = @OtherProviderIdentifier49,
    [OtherProviderIdentifier5] = @OtherProviderIdentifier5,
    [OtherProviderIdentifier50] = @OtherProviderIdentifier50,
    [OtherProviderIdentifier6] = @OtherProviderIdentifier6,
    [OtherProviderIdentifier7] = @OtherProviderIdentifier7,
    [OtherProviderIdentifier8] = @OtherProviderIdentifier8,
    [OtherProviderIdentifier9] = @OtherProviderIdentifier9,
    [OtherProviderIdentifierIssuer1] = @OtherProviderIdentifierIssuer1,
    [OtherProviderIdentifierIssuer10] = @OtherProviderIdentifierIssuer10,
    [OtherProviderIdentifierIssuer11] = @OtherProviderIdentifierIssuer11,
    [OtherProviderIdentifierIssuer12] = @OtherProviderIdentifierIssuer12,
    [OtherProviderIdentifierIssuer13] = @OtherProviderIdentifierIssuer13,
    [OtherProviderIdentifierIssuer14] = @OtherProviderIdentifierIssuer14,
    [OtherProviderIdentifierIssuer15] = @OtherProviderIdentifierIssuer15,
    [OtherProviderIdentifierIssuer16] = @OtherProviderIdentifierIssuer16,
    [OtherProviderIdentifierIssuer17] = @OtherProviderIdentifierIssuer17,
    [OtherProviderIdentifierIssuer18] = @OtherProviderIdentifierIssuer18,
    [OtherProviderIdentifierIssuer19] = @OtherProviderIdentifierIssuer19,
    [OtherProviderIdentifierIssuer2] = @OtherProviderIdentifierIssuer2,
    [OtherProviderIdentifierIssuer20] = @OtherProviderIdentifierIssuer20,
    [OtherProviderIdentifierIssuer21] = @OtherProviderIdentifierIssuer21,
    [OtherProviderIdentifierIssuer22] = @OtherProviderIdentifierIssuer22,
    [OtherProviderIdentifierIssuer23] = @OtherProviderIdentifierIssuer23,
    [OtherProviderIdentifierIssuer24] = @OtherProviderIdentifierIssuer24,
    [OtherProviderIdentifierIssuer25] = @OtherProviderIdentifierIssuer25,
    [OtherProviderIdentifierIssuer26] = @OtherProviderIdentifierIssuer26,
    [OtherProviderIdentifierIssuer27] = @OtherProviderIdentifierIssuer27,
    [OtherProviderIdentifierIssuer28] = @OtherProviderIdentifierIssuer28,
    [OtherProviderIdentifierIssuer29] = @OtherProviderIdentifierIssuer29,
    [OtherProviderIdentifierIssuer3] = @OtherProviderIdentifierIssuer3,
    [OtherProviderIdentifierIssuer30] = @OtherProviderIdentifierIssuer30,
    [OtherProviderIdentifierIssuer31] = @OtherProviderIdentifierIssuer31,
    [OtherProviderIdentifierIssuer32] = @OtherProviderIdentifierIssuer32,
    [OtherProviderIdentifierIssuer33] = @OtherProviderIdentifierIssuer33,
    [OtherProviderIdentifierIssuer34] = @OtherProviderIdentifierIssuer34,
    [OtherProviderIdentifierIssuer35] = @OtherProviderIdentifierIssuer35,
    [OtherProviderIdentifierIssuer36] = @OtherProviderIdentifierIssuer36,
    [OtherProviderIdentifierIssuer37] = @OtherProviderIdentifierIssuer37,
    [OtherProviderIdentifierIssuer38] = @OtherProviderIdentifierIssuer38,
    [OtherProviderIdentifierIssuer39] = @OtherProviderIdentifierIssuer39,
    [OtherProviderIdentifierIssuer4] = @OtherProviderIdentifierIssuer4,
    [OtherProviderIdentifierIssuer40] = @OtherProviderIdentifierIssuer40,
    [OtherProviderIdentifierIssuer41] = @OtherProviderIdentifierIssuer41,
    [OtherProviderIdentifierIssuer42] = @OtherProviderIdentifierIssuer42,
    [OtherProviderIdentifierIssuer43] = @OtherProviderIdentifierIssuer43,
    [OtherProviderIdentifierIssuer44] = @OtherProviderIdentifierIssuer44,
    [OtherProviderIdentifierIssuer45] = @OtherProviderIdentifierIssuer45,
    [OtherProviderIdentifierIssuer46] = @OtherProviderIdentifierIssuer46,
    [OtherProviderIdentifierIssuer47] = @OtherProviderIdentifierIssuer47,
    [OtherProviderIdentifierIssuer48] = @OtherProviderIdentifierIssuer48,
    [OtherProviderIdentifierIssuer49] = @OtherProviderIdentifierIssuer49,
    [OtherProviderIdentifierIssuer5] = @OtherProviderIdentifierIssuer5,
    [OtherProviderIdentifierIssuer50] = @OtherProviderIdentifierIssuer50,
    [OtherProviderIdentifierIssuer6] = @OtherProviderIdentifierIssuer6,
    [OtherProviderIdentifierIssuer7] = @OtherProviderIdentifierIssuer7,
    [OtherProviderIdentifierIssuer8] = @OtherProviderIdentifierIssuer8,
    [OtherProviderIdentifierIssuer9] = @OtherProviderIdentifierIssuer9,
    [OtherProviderIdentifierState1] = @OtherProviderIdentifierState1,
    [OtherProviderIdentifierState10] = @OtherProviderIdentifierState10,
    [OtherProviderIdentifierState11] = @OtherProviderIdentifierState11,
    [OtherProviderIdentifierState12] = @OtherProviderIdentifierState12,
    [OtherProviderIdentifierState13] = @OtherProviderIdentifierState13,
    [OtherProviderIdentifierState14] = @OtherProviderIdentifierState14,
    [OtherProviderIdentifierState15] = @OtherProviderIdentifierState15,
    [OtherProviderIdentifierState16] = @OtherProviderIdentifierState16,
    [OtherProviderIdentifierState17] = @OtherProviderIdentifierState17,
    [OtherProviderIdentifierState18] = @OtherProviderIdentifierState18,
    [OtherProviderIdentifierState19] = @OtherProviderIdentifierState19,
    [OtherProviderIdentifierState2] = @OtherProviderIdentifierState2,
    [OtherProviderIdentifierState20] = @OtherProviderIdentifierState20,
    [OtherProviderIdentifierState21] = @OtherProviderIdentifierState21,
    [OtherProviderIdentifierState22] = @OtherProviderIdentifierState22,
    [OtherProviderIdentifierState23] = @OtherProviderIdentifierState23,
    [OtherProviderIdentifierState24] = @OtherProviderIdentifierState24,
    [OtherProviderIdentifierState25] = @OtherProviderIdentifierState25,
    [OtherProviderIdentifierState26] = @OtherProviderIdentifierState26,
    [OtherProviderIdentifierState27] = @OtherProviderIdentifierState27,
    [OtherProviderIdentifierState28] = @OtherProviderIdentifierState28,
    [OtherProviderIdentifierState29] = @OtherProviderIdentifierState29,
    [OtherProviderIdentifierState3] = @OtherProviderIdentifierState3,
    [OtherProviderIdentifierState30] = @OtherProviderIdentifierState30,
    [OtherProviderIdentifierState31] = @OtherProviderIdentifierState31,
    [OtherProviderIdentifierState32] = @OtherProviderIdentifierState32,
    [OtherProviderIdentifierState33] = @OtherProviderIdentifierState33,
    [OtherProviderIdentifierState34] = @OtherProviderIdentifierState34,
    [OtherProviderIdentifierState35] = @OtherProviderIdentifierState35,
    [OtherProviderIdentifierState36] = @OtherProviderIdentifierState36,
    [OtherProviderIdentifierState37] = @OtherProviderIdentifierState37,
    [OtherProviderIdentifierState38] = @OtherProviderIdentifierState38,
    [OtherProviderIdentifierState39] = @OtherProviderIdentifierState39,
    [OtherProviderIdentifierState4] = @OtherProviderIdentifierState4,
    [OtherProviderIdentifierState40] = @OtherProviderIdentifierState40,
    [OtherProviderIdentifierState41] = @OtherProviderIdentifierState41,
    [OtherProviderIdentifierState42] = @OtherProviderIdentifierState42,
    [OtherProviderIdentifierState43] = @OtherProviderIdentifierState43,
    [OtherProviderIdentifierState44] = @OtherProviderIdentifierState44,
    [OtherProviderIdentifierState45] = @OtherProviderIdentifierState45,
    [OtherProviderIdentifierState46] = @OtherProviderIdentifierState46,
    [OtherProviderIdentifierState47] = @OtherProviderIdentifierState47,
    [OtherProviderIdentifierState48] = @OtherProviderIdentifierState48,
    [OtherProviderIdentifierState49] = @OtherProviderIdentifierState49,
    [OtherProviderIdentifierState5] = @OtherProviderIdentifierState5,
    [OtherProviderIdentifierState50] = @OtherProviderIdentifierState50,
    [OtherProviderIdentifierState6] = @OtherProviderIdentifierState6,
    [OtherProviderIdentifierState7] = @OtherProviderIdentifierState7,
    [OtherProviderIdentifierState8] = @OtherProviderIdentifierState8,
    [OtherProviderIdentifierState9] = @OtherProviderIdentifierState9,
    [OtherProviderIdentifierTypeCode1] = @OtherProviderIdentifierTypeCode1,
    [OtherProviderIdentifierTypeCode10] = @OtherProviderIdentifierTypeCode10,
    [OtherProviderIdentifierTypeCode11] = @OtherProviderIdentifierTypeCode11,
    [OtherProviderIdentifierTypeCode12] = @OtherProviderIdentifierTypeCode12,
    [OtherProviderIdentifierTypeCode13] = @OtherProviderIdentifierTypeCode13,
    [OtherProviderIdentifierTypeCode14] = @OtherProviderIdentifierTypeCode14,
    [OtherProviderIdentifierTypeCode15] = @OtherProviderIdentifierTypeCode15,
    [OtherProviderIdentifierTypeCode16] = @OtherProviderIdentifierTypeCode16,
    [OtherProviderIdentifierTypeCode17] = @OtherProviderIdentifierTypeCode17,
    [OtherProviderIdentifierTypeCode18] = @OtherProviderIdentifierTypeCode18,
    [OtherProviderIdentifierTypeCode19] = @OtherProviderIdentifierTypeCode19,
    [OtherProviderIdentifierTypeCode2] = @OtherProviderIdentifierTypeCode2,
    [OtherProviderIdentifierTypeCode20] = @OtherProviderIdentifierTypeCode20,
    [OtherProviderIdentifierTypeCode21] = @OtherProviderIdentifierTypeCode21,
    [OtherProviderIdentifierTypeCode22] = @OtherProviderIdentifierTypeCode22,
    [OtherProviderIdentifierTypeCode23] = @OtherProviderIdentifierTypeCode23,
    [OtherProviderIdentifierTypeCode24] = @OtherProviderIdentifierTypeCode24,
    [OtherProviderIdentifierTypeCode25] = @OtherProviderIdentifierTypeCode25,
    [OtherProviderIdentifierTypeCode26] = @OtherProviderIdentifierTypeCode26,
    [OtherProviderIdentifierTypeCode27] = @OtherProviderIdentifierTypeCode27,
    [OtherProviderIdentifierTypeCode28] = @OtherProviderIdentifierTypeCode28,
    [OtherProviderIdentifierTypeCode29] = @OtherProviderIdentifierTypeCode29,
    [OtherProviderIdentifierTypeCode3] = @OtherProviderIdentifierTypeCode3,
    [OtherProviderIdentifierTypeCode30] = @OtherProviderIdentifierTypeCode30,
    [OtherProviderIdentifierTypeCode31] = @OtherProviderIdentifierTypeCode31,
    [OtherProviderIdentifierTypeCode32] = @OtherProviderIdentifierTypeCode32,
    [OtherProviderIdentifierTypeCode33] = @OtherProviderIdentifierTypeCode33,
    [OtherProviderIdentifierTypeCode34] = @OtherProviderIdentifierTypeCode34,
    [OtherProviderIdentifierTypeCode35] = @OtherProviderIdentifierTypeCode35,
    [OtherProviderIdentifierTypeCode36] = @OtherProviderIdentifierTypeCode36,
    [OtherProviderIdentifierTypeCode37] = @OtherProviderIdentifierTypeCode37,
    [OtherProviderIdentifierTypeCode38] = @OtherProviderIdentifierTypeCode38,
    [OtherProviderIdentifierTypeCode39] = @OtherProviderIdentifierTypeCode39,
    [OtherProviderIdentifierTypeCode4] = @OtherProviderIdentifierTypeCode4,
    [OtherProviderIdentifierTypeCode40] = @OtherProviderIdentifierTypeCode40,
    [OtherProviderIdentifierTypeCode41] = @OtherProviderIdentifierTypeCode41,
    [OtherProviderIdentifierTypeCode42] = @OtherProviderIdentifierTypeCode42,
    [OtherProviderIdentifierTypeCode43] = @OtherProviderIdentifierTypeCode43,
    [OtherProviderIdentifierTypeCode44] = @OtherProviderIdentifierTypeCode44,
    [OtherProviderIdentifierTypeCode45] = @OtherProviderIdentifierTypeCode45,
    [OtherProviderIdentifierTypeCode46] = @OtherProviderIdentifierTypeCode46,
    [OtherProviderIdentifierTypeCode47] = @OtherProviderIdentifierTypeCode47,
    [OtherProviderIdentifierTypeCode48] = @OtherProviderIdentifierTypeCode48,
    [OtherProviderIdentifierTypeCode49] = @OtherProviderIdentifierTypeCode49,
    [OtherProviderIdentifierTypeCode5] = @OtherProviderIdentifierTypeCode5,
    [OtherProviderIdentifierTypeCode50] = @OtherProviderIdentifierTypeCode50,
    [OtherProviderIdentifierTypeCode6] = @OtherProviderIdentifierTypeCode6,
    [OtherProviderIdentifierTypeCode7] = @OtherProviderIdentifierTypeCode7,
    [OtherProviderIdentifierTypeCode8] = @OtherProviderIdentifierTypeCode8,
    [OtherProviderIdentifierTypeCode9] = @OtherProviderIdentifierTypeCode9,
    [ParentOrganizationLBN] = @ParentOrganizationLBN,
    [ParentOrganizationTIN] = @ParentOrganizationTIN,
    [ProviderBusinessMailingAddressCityName] = @ProviderBusinessMailingAddressCityName,
    [ProviderBusinessMailingAddressCountryCodeIfoutsideUS] = @ProviderBusinessMailingAddressCountryCodeIfoutsideUS,
    [ProviderBusinessMailingAddressFaxNumber] = @ProviderBusinessMailingAddressFaxNumber,
    [ProviderBusinessMailingAddressPostalCode] = @ProviderBusinessMailingAddressPostalCode,
    [ProviderBusinessMailingAddressStateName] = @ProviderBusinessMailingAddressStateName,
    [ProviderBusinessMailingAddressTelephoneNumber] = @ProviderBusinessMailingAddressTelephoneNumber,
    [ProviderBusinessPracticeLocationAddressCityName] = @ProviderBusinessPracticeLocationAddressCityName,
    [ProviderBusinessPracticeLocationAddressCountryCodeIfoutsideUS] = @ProviderBusinessPracticeLocationAddressCountryCodeIfoutsideUS,
    [ProviderBusinessPracticeLocationAddressFaxNumber] = @ProviderBusinessPracticeLocationAddressFaxNumber,
    [ProviderBusinessPracticeLocationAddressPostalCode] = @ProviderBusinessPracticeLocationAddressPostalCode,
    [ProviderBusinessPracticeLocationAddressStateName] = @ProviderBusinessPracticeLocationAddressStateName,
    [ProviderBusinessPracticeLocationAddressTelephoneNumber] = @ProviderBusinessPracticeLocationAddressTelephoneNumber,
    [ProviderCredentialText] = @ProviderCredentialText,
    [ProviderEnumerationDate] = @ProviderEnumerationDate,
    [ProviderFirstLineBusinessMailingAddress] = @ProviderFirstLineBusinessMailingAddress,
    [ProviderFirstLineBusinessPracticeLocationAddress] = @ProviderFirstLineBusinessPracticeLocationAddress,
    [ProviderFirstName] = @ProviderFirstName,
    [ProviderGenderCode] = @ProviderGenderCode,
    [ProviderLastNameLegalName] = @ProviderLastNameLegalName,
    [ProviderLicenseNumber1] = @ProviderLicenseNumber1,
    [ProviderLicenseNumber10] = @ProviderLicenseNumber10,
    [ProviderLicenseNumber11] = @ProviderLicenseNumber11,
    [ProviderLicenseNumber12] = @ProviderLicenseNumber12,
    [ProviderLicenseNumber13] = @ProviderLicenseNumber13,
    [ProviderLicenseNumber14] = @ProviderLicenseNumber14,
    [ProviderLicenseNumber15] = @ProviderLicenseNumber15,
    [ProviderLicenseNumber2] = @ProviderLicenseNumber2,
    [ProviderLicenseNumber3] = @ProviderLicenseNumber3,
    [ProviderLicenseNumber4] = @ProviderLicenseNumber4,
    [ProviderLicenseNumber5] = @ProviderLicenseNumber5,
    [ProviderLicenseNumber6] = @ProviderLicenseNumber6,
    [ProviderLicenseNumber7] = @ProviderLicenseNumber7,
    [ProviderLicenseNumber8] = @ProviderLicenseNumber8,
    [ProviderLicenseNumber9] = @ProviderLicenseNumber9,
    [ProviderLicenseNumberStateCode1] = @ProviderLicenseNumberStateCode1,
    [ProviderLicenseNumberStateCode10] = @ProviderLicenseNumberStateCode10,
    [ProviderLicenseNumberStateCode11] = @ProviderLicenseNumberStateCode11,
    [ProviderLicenseNumberStateCode12] = @ProviderLicenseNumberStateCode12,
    [ProviderLicenseNumberStateCode13] = @ProviderLicenseNumberStateCode13,
    [ProviderLicenseNumberStateCode14] = @ProviderLicenseNumberStateCode14,
    [ProviderLicenseNumberStateCode15] = @ProviderLicenseNumberStateCode15,
    [ProviderLicenseNumberStateCode2] = @ProviderLicenseNumberStateCode2,
    [ProviderLicenseNumberStateCode3] = @ProviderLicenseNumberStateCode3,
    [ProviderLicenseNumberStateCode4] = @ProviderLicenseNumberStateCode4,
    [ProviderLicenseNumberStateCode5] = @ProviderLicenseNumberStateCode5,
    [ProviderLicenseNumberStateCode6] = @ProviderLicenseNumberStateCode6,
    [ProviderLicenseNumberStateCode7] = @ProviderLicenseNumberStateCode7,
    [ProviderLicenseNumberStateCode8] = @ProviderLicenseNumberStateCode8,
    [ProviderLicenseNumberStateCode9] = @ProviderLicenseNumberStateCode9,
    [ProviderMiddleName] = @ProviderMiddleName,
    [ProviderNamePrefixText] = @ProviderNamePrefixText,
    [ProviderNameSuffixText] = @ProviderNameSuffixText,
    [ProviderOrganizationNameLegalBusinessName] = @ProviderOrganizationNameLegalBusinessName,
    [ProviderOtherCredentialText] = @ProviderOtherCredentialText,
    [ProviderOtherFirstName] = @ProviderOtherFirstName,
    [ProviderOtherLastName] = @ProviderOtherLastName,
    [ProviderOtherLastNameTypeCode] = @ProviderOtherLastNameTypeCode,
    [ProviderOtherMiddleName] = @ProviderOtherMiddleName,
    [ProviderOtherNamePrefixText] = @ProviderOtherNamePrefixText,
    [ProviderOtherNameSuffixText] = @ProviderOtherNameSuffixText,
    [ProviderOtherOrganizationName] = @ProviderOtherOrganizationName,
    [ProviderOtherOrganizationNameTypeCode] = @ProviderOtherOrganizationNameTypeCode,
    [ProviderSecondLineBusinessMailingAddress] = @ProviderSecondLineBusinessMailingAddress,
    [ProviderSecondLineBusinessPracticeLocationAddress] = @ProviderSecondLineBusinessPracticeLocationAddress,
    [ReplacementNPI] = @ReplacementNPI

    -- Update Matching Record
    Where [Id] = @Id

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: RawImport_Find
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   9/29/2019
-- Description:    Find an existing RawImport
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('RawImport_Find'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure RawImport_Find

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.RawImport_Find') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure RawImport_Find >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure RawImport_Find >>>'

    End

GO

Create PROCEDURE RawImport_Find

    -- Primary Key Paramater
    @Id int

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Select Statement
    Select [AuthorizedOfficialCredentialText],[AuthorizedOfficialFirstName],[AuthorizedOfficialLastName],[AuthorizedOfficialMiddleName],[AuthorizedOfficialNamePrefixText],[AuthorizedOfficialNameSuffixText],[AuthorizedOfficialTelephoneNumber],[AuthorizedOfficialTitleorPosition],[EmployerIdentificationNumberEIN],[EntityTypeCode],[HealthcareProviderPrimaryTaxonomySwitch1],[HealthcareProviderPrimaryTaxonomySwitch10],[HealthcareProviderPrimaryTaxonomySwitch11],[HealthcareProviderPrimaryTaxonomySwitch12],[HealthcareProviderPrimaryTaxonomySwitch13],[HealthcareProviderPrimaryTaxonomySwitch14],[HealthcareProviderPrimaryTaxonomySwitch15],[HealthcareProviderPrimaryTaxonomySwitch2],[HealthcareProviderPrimaryTaxonomySwitch3],[HealthcareProviderPrimaryTaxonomySwitch4],[HealthcareProviderPrimaryTaxonomySwitch5],[HealthcareProviderPrimaryTaxonomySwitch6],[HealthcareProviderPrimaryTaxonomySwitch7],[HealthcareProviderPrimaryTaxonomySwitch8],[HealthcareProviderPrimaryTaxonomySwitch9],[HealthcareProviderTaxonomyCode1],[HealthcareProviderTaxonomyCode10],[HealthcareProviderTaxonomyCode11],[HealthcareProviderTaxonomyCode12],[HealthcareProviderTaxonomyCode13],[HealthcareProviderTaxonomyCode14],[HealthcareProviderTaxonomyCode15],[HealthcareProviderTaxonomyCode2],[HealthcareProviderTaxonomyCode3],[HealthcareProviderTaxonomyCode4],[HealthcareProviderTaxonomyCode5],[HealthcareProviderTaxonomyCode6],[HealthcareProviderTaxonomyCode7],[HealthcareProviderTaxonomyCode8],[HealthcareProviderTaxonomyCode9],[HealthcareProviderTaxonomyGroup1],[HealthcareProviderTaxonomyGroup10],[HealthcareProviderTaxonomyGroup11],[HealthcareProviderTaxonomyGroup12],[HealthcareProviderTaxonomyGroup13],[HealthcareProviderTaxonomyGroup14],[HealthcareProviderTaxonomyGroup15],[HealthcareProviderTaxonomyGroup2],[HealthcareProviderTaxonomyGroup3],[HealthcareProviderTaxonomyGroup4],[HealthcareProviderTaxonomyGroup5],[HealthcareProviderTaxonomyGroup6],[HealthcareProviderTaxonomyGroup7],[HealthcareProviderTaxonomyGroup8],[HealthcareProviderTaxonomyGroup9],[Id],[IsOrganizationSubpart],[IsSoleProprietor],[LastUpdateDate],[NPI],[NPIDeactivationDate],[NPIDeactivationReasonCode],[NPIReactivationDate],[OtherProviderIdentifier1],[OtherProviderIdentifier10],[OtherProviderIdentifier11],[OtherProviderIdentifier12],[OtherProviderIdentifier13],[OtherProviderIdentifier14],[OtherProviderIdentifier15],[OtherProviderIdentifier16],[OtherProviderIdentifier17],[OtherProviderIdentifier18],[OtherProviderIdentifier19],[OtherProviderIdentifier2],[OtherProviderIdentifier20],[OtherProviderIdentifier21],[OtherProviderIdentifier22],[OtherProviderIdentifier23],[OtherProviderIdentifier24],[OtherProviderIdentifier25],[OtherProviderIdentifier26],[OtherProviderIdentifier27],[OtherProviderIdentifier28],[OtherProviderIdentifier29],[OtherProviderIdentifier3],[OtherProviderIdentifier30],[OtherProviderIdentifier31],[OtherProviderIdentifier32],[OtherProviderIdentifier33],[OtherProviderIdentifier34],[OtherProviderIdentifier35],[OtherProviderIdentifier36],[OtherProviderIdentifier37],[OtherProviderIdentifier38],[OtherProviderIdentifier39],[OtherProviderIdentifier4],[OtherProviderIdentifier40],[OtherProviderIdentifier41],[OtherProviderIdentifier42],[OtherProviderIdentifier43],[OtherProviderIdentifier44],[OtherProviderIdentifier45],[OtherProviderIdentifier46],[OtherProviderIdentifier47],[OtherProviderIdentifier48],[OtherProviderIdentifier49],[OtherProviderIdentifier5],[OtherProviderIdentifier50],[OtherProviderIdentifier6],[OtherProviderIdentifier7],[OtherProviderIdentifier8],[OtherProviderIdentifier9],[OtherProviderIdentifierIssuer1],[OtherProviderIdentifierIssuer10],[OtherProviderIdentifierIssuer11],[OtherProviderIdentifierIssuer12],[OtherProviderIdentifierIssuer13],[OtherProviderIdentifierIssuer14],[OtherProviderIdentifierIssuer15],[OtherProviderIdentifierIssuer16],[OtherProviderIdentifierIssuer17],[OtherProviderIdentifierIssuer18],[OtherProviderIdentifierIssuer19],[OtherProviderIdentifierIssuer2],[OtherProviderIdentifierIssuer20],[OtherProviderIdentifierIssuer21],[OtherProviderIdentifierIssuer22],[OtherProviderIdentifierIssuer23],[OtherProviderIdentifierIssuer24],[OtherProviderIdentifierIssuer25],[OtherProviderIdentifierIssuer26],[OtherProviderIdentifierIssuer27],[OtherProviderIdentifierIssuer28],[OtherProviderIdentifierIssuer29],[OtherProviderIdentifierIssuer3],[OtherProviderIdentifierIssuer30],[OtherProviderIdentifierIssuer31],[OtherProviderIdentifierIssuer32],[OtherProviderIdentifierIssuer33],[OtherProviderIdentifierIssuer34],[OtherProviderIdentifierIssuer35],[OtherProviderIdentifierIssuer36],[OtherProviderIdentifierIssuer37],[OtherProviderIdentifierIssuer38],[OtherProviderIdentifierIssuer39],[OtherProviderIdentifierIssuer4],[OtherProviderIdentifierIssuer40],[OtherProviderIdentifierIssuer41],[OtherProviderIdentifierIssuer42],[OtherProviderIdentifierIssuer43],[OtherProviderIdentifierIssuer44],[OtherProviderIdentifierIssuer45],[OtherProviderIdentifierIssuer46],[OtherProviderIdentifierIssuer47],[OtherProviderIdentifierIssuer48],[OtherProviderIdentifierIssuer49],[OtherProviderIdentifierIssuer5],[OtherProviderIdentifierIssuer50],[OtherProviderIdentifierIssuer6],[OtherProviderIdentifierIssuer7],[OtherProviderIdentifierIssuer8],[OtherProviderIdentifierIssuer9],[OtherProviderIdentifierState1],[OtherProviderIdentifierState10],[OtherProviderIdentifierState11],[OtherProviderIdentifierState12],[OtherProviderIdentifierState13],[OtherProviderIdentifierState14],[OtherProviderIdentifierState15],[OtherProviderIdentifierState16],[OtherProviderIdentifierState17],[OtherProviderIdentifierState18],[OtherProviderIdentifierState19],[OtherProviderIdentifierState2],[OtherProviderIdentifierState20],[OtherProviderIdentifierState21],[OtherProviderIdentifierState22],[OtherProviderIdentifierState23],[OtherProviderIdentifierState24],[OtherProviderIdentifierState25],[OtherProviderIdentifierState26],[OtherProviderIdentifierState27],[OtherProviderIdentifierState28],[OtherProviderIdentifierState29],[OtherProviderIdentifierState3],[OtherProviderIdentifierState30],[OtherProviderIdentifierState31],[OtherProviderIdentifierState32],[OtherProviderIdentifierState33],[OtherProviderIdentifierState34],[OtherProviderIdentifierState35],[OtherProviderIdentifierState36],[OtherProviderIdentifierState37],[OtherProviderIdentifierState38],[OtherProviderIdentifierState39],[OtherProviderIdentifierState4],[OtherProviderIdentifierState40],[OtherProviderIdentifierState41],[OtherProviderIdentifierState42],[OtherProviderIdentifierState43],[OtherProviderIdentifierState44],[OtherProviderIdentifierState45],[OtherProviderIdentifierState46],[OtherProviderIdentifierState47],[OtherProviderIdentifierState48],[OtherProviderIdentifierState49],[OtherProviderIdentifierState5],[OtherProviderIdentifierState50],[OtherProviderIdentifierState6],[OtherProviderIdentifierState7],[OtherProviderIdentifierState8],[OtherProviderIdentifierState9],[OtherProviderIdentifierTypeCode1],[OtherProviderIdentifierTypeCode10],[OtherProviderIdentifierTypeCode11],[OtherProviderIdentifierTypeCode12],[OtherProviderIdentifierTypeCode13],[OtherProviderIdentifierTypeCode14],[OtherProviderIdentifierTypeCode15],[OtherProviderIdentifierTypeCode16],[OtherProviderIdentifierTypeCode17],[OtherProviderIdentifierTypeCode18],[OtherProviderIdentifierTypeCode19],[OtherProviderIdentifierTypeCode2],[OtherProviderIdentifierTypeCode20],[OtherProviderIdentifierTypeCode21],[OtherProviderIdentifierTypeCode22],[OtherProviderIdentifierTypeCode23],[OtherProviderIdentifierTypeCode24],[OtherProviderIdentifierTypeCode25],[OtherProviderIdentifierTypeCode26],[OtherProviderIdentifierTypeCode27],[OtherProviderIdentifierTypeCode28],[OtherProviderIdentifierTypeCode29],[OtherProviderIdentifierTypeCode3],[OtherProviderIdentifierTypeCode30],[OtherProviderIdentifierTypeCode31],[OtherProviderIdentifierTypeCode32],[OtherProviderIdentifierTypeCode33],[OtherProviderIdentifierTypeCode34],[OtherProviderIdentifierTypeCode35],[OtherProviderIdentifierTypeCode36],[OtherProviderIdentifierTypeCode37],[OtherProviderIdentifierTypeCode38],[OtherProviderIdentifierTypeCode39],[OtherProviderIdentifierTypeCode4],[OtherProviderIdentifierTypeCode40],[OtherProviderIdentifierTypeCode41],[OtherProviderIdentifierTypeCode42],[OtherProviderIdentifierTypeCode43],[OtherProviderIdentifierTypeCode44],[OtherProviderIdentifierTypeCode45],[OtherProviderIdentifierTypeCode46],[OtherProviderIdentifierTypeCode47],[OtherProviderIdentifierTypeCode48],[OtherProviderIdentifierTypeCode49],[OtherProviderIdentifierTypeCode5],[OtherProviderIdentifierTypeCode50],[OtherProviderIdentifierTypeCode6],[OtherProviderIdentifierTypeCode7],[OtherProviderIdentifierTypeCode8],[OtherProviderIdentifierTypeCode9],[ParentOrganizationLBN],[ParentOrganizationTIN],[ProviderBusinessMailingAddressCityName],[ProviderBusinessMailingAddressCountryCodeIfoutsideUS],[ProviderBusinessMailingAddressFaxNumber],[ProviderBusinessMailingAddressPostalCode],[ProviderBusinessMailingAddressStateName],[ProviderBusinessMailingAddressTelephoneNumber],[ProviderBusinessPracticeLocationAddressCityName],[ProviderBusinessPracticeLocationAddressCountryCodeIfoutsideUS],[ProviderBusinessPracticeLocationAddressFaxNumber],[ProviderBusinessPracticeLocationAddressPostalCode],[ProviderBusinessPracticeLocationAddressStateName],[ProviderBusinessPracticeLocationAddressTelephoneNumber],[ProviderCredentialText],[ProviderEnumerationDate],[ProviderFirstLineBusinessMailingAddress],[ProviderFirstLineBusinessPracticeLocationAddress],[ProviderFirstName],[ProviderGenderCode],[ProviderLastNameLegalName],[ProviderLicenseNumber1],[ProviderLicenseNumber10],[ProviderLicenseNumber11],[ProviderLicenseNumber12],[ProviderLicenseNumber13],[ProviderLicenseNumber14],[ProviderLicenseNumber15],[ProviderLicenseNumber2],[ProviderLicenseNumber3],[ProviderLicenseNumber4],[ProviderLicenseNumber5],[ProviderLicenseNumber6],[ProviderLicenseNumber7],[ProviderLicenseNumber8],[ProviderLicenseNumber9],[ProviderLicenseNumberStateCode1],[ProviderLicenseNumberStateCode10],[ProviderLicenseNumberStateCode11],[ProviderLicenseNumberStateCode12],[ProviderLicenseNumberStateCode13],[ProviderLicenseNumberStateCode14],[ProviderLicenseNumberStateCode15],[ProviderLicenseNumberStateCode2],[ProviderLicenseNumberStateCode3],[ProviderLicenseNumberStateCode4],[ProviderLicenseNumberStateCode5],[ProviderLicenseNumberStateCode6],[ProviderLicenseNumberStateCode7],[ProviderLicenseNumberStateCode8],[ProviderLicenseNumberStateCode9],[ProviderMiddleName],[ProviderNamePrefixText],[ProviderNameSuffixText],[ProviderOrganizationNameLegalBusinessName],[ProviderOtherCredentialText],[ProviderOtherFirstName],[ProviderOtherLastName],[ProviderOtherLastNameTypeCode],[ProviderOtherMiddleName],[ProviderOtherNamePrefixText],[ProviderOtherNameSuffixText],[ProviderOtherOrganizationName],[ProviderOtherOrganizationNameTypeCode],[ProviderSecondLineBusinessMailingAddress],[ProviderSecondLineBusinessPracticeLocationAddress],[ReplacementNPI]

    -- From tableName
    From [RawImport]

    -- Find Matching Record
    Where [Id] = @Id

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: RawImport_Delete
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   9/29/2019
-- Description:    Delete an existing RawImport
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('RawImport_Delete'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure RawImport_Delete

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.RawImport_Delete') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure RawImport_Delete >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure RawImport_Delete >>>'

    End

GO

Create PROCEDURE RawImport_Delete

    -- Primary Key Paramater
    @Id int

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Delete Statement
    Delete From [RawImport]

    -- Delete Matching Record
    Where [Id] = @Id

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: RawImport_FetchAll
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   9/29/2019
-- Description:    Returns all RawImport objects
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('RawImport_FetchAll'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure RawImport_FetchAll

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.RawImport_FetchAll') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure RawImport_FetchAll >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure RawImport_FetchAll >>>'

    End

GO

Create PROCEDURE RawImport_FetchAll

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Select Statement
    Select [AuthorizedOfficialCredentialText],[AuthorizedOfficialFirstName],[AuthorizedOfficialLastName],[AuthorizedOfficialMiddleName],[AuthorizedOfficialNamePrefixText],[AuthorizedOfficialNameSuffixText],[AuthorizedOfficialTelephoneNumber],[AuthorizedOfficialTitleorPosition],[EmployerIdentificationNumberEIN],[EntityTypeCode],[HealthcareProviderPrimaryTaxonomySwitch1],[HealthcareProviderPrimaryTaxonomySwitch10],[HealthcareProviderPrimaryTaxonomySwitch11],[HealthcareProviderPrimaryTaxonomySwitch12],[HealthcareProviderPrimaryTaxonomySwitch13],[HealthcareProviderPrimaryTaxonomySwitch14],[HealthcareProviderPrimaryTaxonomySwitch15],[HealthcareProviderPrimaryTaxonomySwitch2],[HealthcareProviderPrimaryTaxonomySwitch3],[HealthcareProviderPrimaryTaxonomySwitch4],[HealthcareProviderPrimaryTaxonomySwitch5],[HealthcareProviderPrimaryTaxonomySwitch6],[HealthcareProviderPrimaryTaxonomySwitch7],[HealthcareProviderPrimaryTaxonomySwitch8],[HealthcareProviderPrimaryTaxonomySwitch9],[HealthcareProviderTaxonomyCode1],[HealthcareProviderTaxonomyCode10],[HealthcareProviderTaxonomyCode11],[HealthcareProviderTaxonomyCode12],[HealthcareProviderTaxonomyCode13],[HealthcareProviderTaxonomyCode14],[HealthcareProviderTaxonomyCode15],[HealthcareProviderTaxonomyCode2],[HealthcareProviderTaxonomyCode3],[HealthcareProviderTaxonomyCode4],[HealthcareProviderTaxonomyCode5],[HealthcareProviderTaxonomyCode6],[HealthcareProviderTaxonomyCode7],[HealthcareProviderTaxonomyCode8],[HealthcareProviderTaxonomyCode9],[HealthcareProviderTaxonomyGroup1],[HealthcareProviderTaxonomyGroup10],[HealthcareProviderTaxonomyGroup11],[HealthcareProviderTaxonomyGroup12],[HealthcareProviderTaxonomyGroup13],[HealthcareProviderTaxonomyGroup14],[HealthcareProviderTaxonomyGroup15],[HealthcareProviderTaxonomyGroup2],[HealthcareProviderTaxonomyGroup3],[HealthcareProviderTaxonomyGroup4],[HealthcareProviderTaxonomyGroup5],[HealthcareProviderTaxonomyGroup6],[HealthcareProviderTaxonomyGroup7],[HealthcareProviderTaxonomyGroup8],[HealthcareProviderTaxonomyGroup9],[Id],[IsOrganizationSubpart],[IsSoleProprietor],[LastUpdateDate],[NPI],[NPIDeactivationDate],[NPIDeactivationReasonCode],[NPIReactivationDate],[OtherProviderIdentifier1],[OtherProviderIdentifier10],[OtherProviderIdentifier11],[OtherProviderIdentifier12],[OtherProviderIdentifier13],[OtherProviderIdentifier14],[OtherProviderIdentifier15],[OtherProviderIdentifier16],[OtherProviderIdentifier17],[OtherProviderIdentifier18],[OtherProviderIdentifier19],[OtherProviderIdentifier2],[OtherProviderIdentifier20],[OtherProviderIdentifier21],[OtherProviderIdentifier22],[OtherProviderIdentifier23],[OtherProviderIdentifier24],[OtherProviderIdentifier25],[OtherProviderIdentifier26],[OtherProviderIdentifier27],[OtherProviderIdentifier28],[OtherProviderIdentifier29],[OtherProviderIdentifier3],[OtherProviderIdentifier30],[OtherProviderIdentifier31],[OtherProviderIdentifier32],[OtherProviderIdentifier33],[OtherProviderIdentifier34],[OtherProviderIdentifier35],[OtherProviderIdentifier36],[OtherProviderIdentifier37],[OtherProviderIdentifier38],[OtherProviderIdentifier39],[OtherProviderIdentifier4],[OtherProviderIdentifier40],[OtherProviderIdentifier41],[OtherProviderIdentifier42],[OtherProviderIdentifier43],[OtherProviderIdentifier44],[OtherProviderIdentifier45],[OtherProviderIdentifier46],[OtherProviderIdentifier47],[OtherProviderIdentifier48],[OtherProviderIdentifier49],[OtherProviderIdentifier5],[OtherProviderIdentifier50],[OtherProviderIdentifier6],[OtherProviderIdentifier7],[OtherProviderIdentifier8],[OtherProviderIdentifier9],[OtherProviderIdentifierIssuer1],[OtherProviderIdentifierIssuer10],[OtherProviderIdentifierIssuer11],[OtherProviderIdentifierIssuer12],[OtherProviderIdentifierIssuer13],[OtherProviderIdentifierIssuer14],[OtherProviderIdentifierIssuer15],[OtherProviderIdentifierIssuer16],[OtherProviderIdentifierIssuer17],[OtherProviderIdentifierIssuer18],[OtherProviderIdentifierIssuer19],[OtherProviderIdentifierIssuer2],[OtherProviderIdentifierIssuer20],[OtherProviderIdentifierIssuer21],[OtherProviderIdentifierIssuer22],[OtherProviderIdentifierIssuer23],[OtherProviderIdentifierIssuer24],[OtherProviderIdentifierIssuer25],[OtherProviderIdentifierIssuer26],[OtherProviderIdentifierIssuer27],[OtherProviderIdentifierIssuer28],[OtherProviderIdentifierIssuer29],[OtherProviderIdentifierIssuer3],[OtherProviderIdentifierIssuer30],[OtherProviderIdentifierIssuer31],[OtherProviderIdentifierIssuer32],[OtherProviderIdentifierIssuer33],[OtherProviderIdentifierIssuer34],[OtherProviderIdentifierIssuer35],[OtherProviderIdentifierIssuer36],[OtherProviderIdentifierIssuer37],[OtherProviderIdentifierIssuer38],[OtherProviderIdentifierIssuer39],[OtherProviderIdentifierIssuer4],[OtherProviderIdentifierIssuer40],[OtherProviderIdentifierIssuer41],[OtherProviderIdentifierIssuer42],[OtherProviderIdentifierIssuer43],[OtherProviderIdentifierIssuer44],[OtherProviderIdentifierIssuer45],[OtherProviderIdentifierIssuer46],[OtherProviderIdentifierIssuer47],[OtherProviderIdentifierIssuer48],[OtherProviderIdentifierIssuer49],[OtherProviderIdentifierIssuer5],[OtherProviderIdentifierIssuer50],[OtherProviderIdentifierIssuer6],[OtherProviderIdentifierIssuer7],[OtherProviderIdentifierIssuer8],[OtherProviderIdentifierIssuer9],[OtherProviderIdentifierState1],[OtherProviderIdentifierState10],[OtherProviderIdentifierState11],[OtherProviderIdentifierState12],[OtherProviderIdentifierState13],[OtherProviderIdentifierState14],[OtherProviderIdentifierState15],[OtherProviderIdentifierState16],[OtherProviderIdentifierState17],[OtherProviderIdentifierState18],[OtherProviderIdentifierState19],[OtherProviderIdentifierState2],[OtherProviderIdentifierState20],[OtherProviderIdentifierState21],[OtherProviderIdentifierState22],[OtherProviderIdentifierState23],[OtherProviderIdentifierState24],[OtherProviderIdentifierState25],[OtherProviderIdentifierState26],[OtherProviderIdentifierState27],[OtherProviderIdentifierState28],[OtherProviderIdentifierState29],[OtherProviderIdentifierState3],[OtherProviderIdentifierState30],[OtherProviderIdentifierState31],[OtherProviderIdentifierState32],[OtherProviderIdentifierState33],[OtherProviderIdentifierState34],[OtherProviderIdentifierState35],[OtherProviderIdentifierState36],[OtherProviderIdentifierState37],[OtherProviderIdentifierState38],[OtherProviderIdentifierState39],[OtherProviderIdentifierState4],[OtherProviderIdentifierState40],[OtherProviderIdentifierState41],[OtherProviderIdentifierState42],[OtherProviderIdentifierState43],[OtherProviderIdentifierState44],[OtherProviderIdentifierState45],[OtherProviderIdentifierState46],[OtherProviderIdentifierState47],[OtherProviderIdentifierState48],[OtherProviderIdentifierState49],[OtherProviderIdentifierState5],[OtherProviderIdentifierState50],[OtherProviderIdentifierState6],[OtherProviderIdentifierState7],[OtherProviderIdentifierState8],[OtherProviderIdentifierState9],[OtherProviderIdentifierTypeCode1],[OtherProviderIdentifierTypeCode10],[OtherProviderIdentifierTypeCode11],[OtherProviderIdentifierTypeCode12],[OtherProviderIdentifierTypeCode13],[OtherProviderIdentifierTypeCode14],[OtherProviderIdentifierTypeCode15],[OtherProviderIdentifierTypeCode16],[OtherProviderIdentifierTypeCode17],[OtherProviderIdentifierTypeCode18],[OtherProviderIdentifierTypeCode19],[OtherProviderIdentifierTypeCode2],[OtherProviderIdentifierTypeCode20],[OtherProviderIdentifierTypeCode21],[OtherProviderIdentifierTypeCode22],[OtherProviderIdentifierTypeCode23],[OtherProviderIdentifierTypeCode24],[OtherProviderIdentifierTypeCode25],[OtherProviderIdentifierTypeCode26],[OtherProviderIdentifierTypeCode27],[OtherProviderIdentifierTypeCode28],[OtherProviderIdentifierTypeCode29],[OtherProviderIdentifierTypeCode3],[OtherProviderIdentifierTypeCode30],[OtherProviderIdentifierTypeCode31],[OtherProviderIdentifierTypeCode32],[OtherProviderIdentifierTypeCode33],[OtherProviderIdentifierTypeCode34],[OtherProviderIdentifierTypeCode35],[OtherProviderIdentifierTypeCode36],[OtherProviderIdentifierTypeCode37],[OtherProviderIdentifierTypeCode38],[OtherProviderIdentifierTypeCode39],[OtherProviderIdentifierTypeCode4],[OtherProviderIdentifierTypeCode40],[OtherProviderIdentifierTypeCode41],[OtherProviderIdentifierTypeCode42],[OtherProviderIdentifierTypeCode43],[OtherProviderIdentifierTypeCode44],[OtherProviderIdentifierTypeCode45],[OtherProviderIdentifierTypeCode46],[OtherProviderIdentifierTypeCode47],[OtherProviderIdentifierTypeCode48],[OtherProviderIdentifierTypeCode49],[OtherProviderIdentifierTypeCode5],[OtherProviderIdentifierTypeCode50],[OtherProviderIdentifierTypeCode6],[OtherProviderIdentifierTypeCode7],[OtherProviderIdentifierTypeCode8],[OtherProviderIdentifierTypeCode9],[ParentOrganizationLBN],[ParentOrganizationTIN],[ProviderBusinessMailingAddressCityName],[ProviderBusinessMailingAddressCountryCodeIfoutsideUS],[ProviderBusinessMailingAddressFaxNumber],[ProviderBusinessMailingAddressPostalCode],[ProviderBusinessMailingAddressStateName],[ProviderBusinessMailingAddressTelephoneNumber],[ProviderBusinessPracticeLocationAddressCityName],[ProviderBusinessPracticeLocationAddressCountryCodeIfoutsideUS],[ProviderBusinessPracticeLocationAddressFaxNumber],[ProviderBusinessPracticeLocationAddressPostalCode],[ProviderBusinessPracticeLocationAddressStateName],[ProviderBusinessPracticeLocationAddressTelephoneNumber],[ProviderCredentialText],[ProviderEnumerationDate],[ProviderFirstLineBusinessMailingAddress],[ProviderFirstLineBusinessPracticeLocationAddress],[ProviderFirstName],[ProviderGenderCode],[ProviderLastNameLegalName],[ProviderLicenseNumber1],[ProviderLicenseNumber10],[ProviderLicenseNumber11],[ProviderLicenseNumber12],[ProviderLicenseNumber13],[ProviderLicenseNumber14],[ProviderLicenseNumber15],[ProviderLicenseNumber2],[ProviderLicenseNumber3],[ProviderLicenseNumber4],[ProviderLicenseNumber5],[ProviderLicenseNumber6],[ProviderLicenseNumber7],[ProviderLicenseNumber8],[ProviderLicenseNumber9],[ProviderLicenseNumberStateCode1],[ProviderLicenseNumberStateCode10],[ProviderLicenseNumberStateCode11],[ProviderLicenseNumberStateCode12],[ProviderLicenseNumberStateCode13],[ProviderLicenseNumberStateCode14],[ProviderLicenseNumberStateCode15],[ProviderLicenseNumberStateCode2],[ProviderLicenseNumberStateCode3],[ProviderLicenseNumberStateCode4],[ProviderLicenseNumberStateCode5],[ProviderLicenseNumberStateCode6],[ProviderLicenseNumberStateCode7],[ProviderLicenseNumberStateCode8],[ProviderLicenseNumberStateCode9],[ProviderMiddleName],[ProviderNamePrefixText],[ProviderNameSuffixText],[ProviderOrganizationNameLegalBusinessName],[ProviderOtherCredentialText],[ProviderOtherFirstName],[ProviderOtherLastName],[ProviderOtherLastNameTypeCode],[ProviderOtherMiddleName],[ProviderOtherNamePrefixText],[ProviderOtherNameSuffixText],[ProviderOtherOrganizationName],[ProviderOtherOrganizationNameTypeCode],[ProviderSecondLineBusinessMailingAddress],[ProviderSecondLineBusinessPracticeLocationAddress],[ReplacementNPI]

    -- From tableName
    From [RawImport]

END

-- Thank you for using DataTier.Net.

