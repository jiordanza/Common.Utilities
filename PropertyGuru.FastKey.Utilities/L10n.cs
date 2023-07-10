using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Resources;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Westwind.Globalization;

namespace PropertyGuru.FastKey.Utilities
{
    public static class L10n
    {

        public static void ClearCache()
        {
            DbResourceConfiguration.ClearResourceCache();
            DbRes.ClearResources();
        }

        public static void SetLocale(int language)
        {
            var lang = (SharedConstant.LANGUAGE)(language);

            if (lang == SharedConstant.LANGUAGE.English)
            {
                //use invariant
                SetLocale("");
            }
            else
            {
                SetLocale(lang.Description());
            }
        }

        public static Dictionary<string, string> GetResourcesForResourceSet(string resourceSetName)
        {
            Dictionary<string, string> keyValuePairs = new Dictionary<string, string>();
            ResourceSet resourceSet = DbRes.GetResourceSet(resourceSetName, "");

            if (resourceSet != null)
            {
                keyValuePairs = resourceSet.Cast<System.Collections.DictionaryEntry>().ToDictionary(r => r.Key.ToString(), r => DbRes.T(r.Key.ToString(), resourceSetName));
            }
            return keyValuePairs;
        }

        public static void SetLocale(string locale)
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo(locale);
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(locale);
        }
        public static void SetLocale(CultureInfo locale)
        {
            Thread.CurrentThread.CurrentCulture = locale;
            Thread.CurrentThread.CurrentUICulture = locale;
        }

        public static string T(string localeId, string resourceSet = null, string lang = "")
        {
            return DbRes.T(localeId, resourceSet, lang);
        }
        public static string TDefault(string resId, string defaultText, string resourceSet = null, string lang = "")
        {
            return DbRes.TDefault(resId, defaultText, resourceSet, lang);
        }


        public static partial class CRM //optional, you can call the parent methods
        {
            public static string T(string resId)
            {
                return DbRes.T(resId, SharedConstant.RESOURCESET_CRM);
            }
            public static string T(string resId, string lang)
            {
                return DbRes.T(resId, SharedConstant.RESOURCESET_CRM, lang);
            }
            public static string TDefault(string resId, string defaultText)
            {
                return DbRes.TDefault(resId, defaultText, SharedConstant.RESOURCESET_CRM);
            }
            public static string TDefault(string resId, string defaultText, string lang)
            {
                return DbRes.TDefault(resId, defaultText, SharedConstant.RESOURCESET_CRM, lang);
            }

            public static string UnexpectedError { get { return T("mesg_UnexpectedError"); } }
        }

        public static partial class ESALES //optional, you can call the parent methods
        {
            public static string T(string resId)
            {
                return DbRes.T(resId, SharedConstant.RESOURCESET_ESALES);
            }
            public static string T(string resId, string lang)
            {
                return DbRes.T(resId, SharedConstant.RESOURCESET_ESALES, lang);
            }
            public static string TDefault(string resId, string defaultText)
            {
                return DbRes.TDefault(resId, defaultText, SharedConstant.RESOURCESET_ESALES);
            }
            public static string TDefault(string resId, string defaultText, string lang)
            {
                return DbRes.TDefault(resId, defaultText, SharedConstant.RESOURCESET_ESALES, lang);
            }

            public static string UnexpectedError { get { return T("mesg_UnexpectedError"); } }
        }

        public static class APPLOCALE
        {
            public static string T(string resId)
            {
                return DbRes.T(resId, SharedConstant.RESOURCESET_APP_LOCALE);
            }
            public static string T(string resId, string lang)
            {
                return DbRes.T(resId, SharedConstant.RESOURCESET_APP_LOCALE, lang);
            }
            public static string TDefault(string resId, string defaultText)
            {
                return DbRes.TDefault(resId, defaultText, SharedConstant.RESOURCESET_APP_LOCALE);
            }
            public static string TDefault(string resId, string defaultText, string lang)
            {
                return DbRes.TDefault(resId, defaultText, SharedConstant.RESOURCESET_APP_LOCALE, lang);
            }
        }


        public static partial class ESALES
        {

            public static string lbl_AddonLimit { get { return T("lbl_AddonLimit"); } }
            public static string lbl_AddonLimitPrefix { get { return T("lbl_AddonLimitPrefix"); } }
            public static string lbl_AdminTeamNotification { get { return T("lbl_AdminTeamNotification"); } }
            public static string lbl_AgentRanking { get { return T("lbl_AgentRanking"); } }
            public static string lbl_AgentRankingTotal { get { return T("lbl_AgentRankingTotal"); } }
            public static string lbl_Area { get { return T("lbl_Area"); } }
            public static string lbl_Ascending { get { return T("lbl_Ascending"); } }
            public static string lbl_AvailableUnits { get { return T("lbl_AvailableUnits"); } }
            public static string lbl_Appointment { get { return T("lbl_Appointment"); } }
            public static string lbl_Bathrooms { get { return T("lbl_Bathrooms"); } }
            public static string lbl_Bedrooms { get { return T("lbl_Bedrooms"); } }
            public static string lbl_BlockPhase { get { return T("lbl_BlockPhase"); } }
            public static string lbl_Block { get { return T("lbl_Block"); } }
            public static string lbl_Booking { get { return T("lbl_Booking"); } }
            public static string lbl_BookingApprove { get { return T("lbl_BookingApprove"); } }
            public static string lbl_BookingCancel { get { return T("lbl_BookingCancel"); } }
            public static string lbl_BookingDocRequiredForRequest { get { return T("lbl_BookingDocRequiredForRequest"); } }
            public static string lbl_BookingDocRequiredForStatus { get { return T("lbl_BookingDocRequiredForStatus"); } }
            public static string lbl_BookingMarkAsCustom { get { return T("lbl_BookingMarkAsCustom"); } }
            public static string lbl_BookingMarkReserve { get { return T("lbl_BookingMarkReserve"); } }
            public static string lbl_BookingMarkSold { get { return T("lbl_BookingMarkSold"); } }
            public static string lbl_BookingMarkSpaSign { get { return T("lbl_BookingMarkSpaSign"); } }
            public static string lbl_BookingMarkSpaStamp { get { return T("lbl_BookingMarkSpaStamp"); } }
            public static string lbl_BookingReject { get { return T("lbl_BookingReject"); } }
            public static string lbl_BookingRequestAsCustom { get { return T("lbl_BookingRequestAsCustom"); } }
            public static string lbl_BookingRequestCancel { get { return T("lbl_BookingRequestCancel"); } }
            public static string lbl_BookingRequestReserve { get { return T("lbl_BookingRequestReserve"); } }
            public static string lbl_BookingRequestSold { get { return T("lbl_BookingRequestSold"); } }
            public static string lbl_BookingRequestSpaSign { get { return T("lbl_BookingRequestSpaSign"); } }
            public static string lbl_BookingRequestSpaStamp { get { return T("lbl_BookingRequestSpaStamp"); } }
            public static string lbl_BookingSave { get { return T("lbl_BookingSave"); } }
            public static string lbl_CancelBooking { get { return T("lbl_CancelBooking"); } }
            public static string lbl_CancelReissueDate { get { return T("lbl_CancelReissueDate"); } }
            public static string lbl_Category { get { return T("lbl_Category"); } }
            public static string lbl_Comments { get { return T("lbl_Comments"); } }
            public static string lbl_CustomAddOnOptionSelection { get { return T("lbl_CustomAddOnOptionSelection"); } }
            public static string lbl_CustomAddOnSelection { get { return T("lbl_CustomAddOnSelection"); } }
            public static string lbl_DashboardTotalLeads { get { return T("lbl_DashboardTotalLeads"); } }
            public static string lbl_DashboardSalesGalleryVisits { get { return T("lbl_DashboardSalesGalleryVisits"); } }
            public static string lbl_DashboardConvertedLeads { get { return T("lbl_DashboardConvertedLeads"); } }
            public static string lbl_Day { get { return T("lbl_Day"); } }
            public static string lbl_Days { get { return T("lbl_Days"); } }
            public static string lbl_Descending { get { return T("lbl_Descending"); } }
            public static string lbl_Direction { get { return T("lbl_Direction"); } }
            public static string lbl_Email { get { return T("lbl_Email"); } }
            public static string lbl_Feature { get { return T("lbl_Feature"); } }
            public static string lbl_FeatureProjects { get { return T("lbl_FeatureProjects"); } }
            public static string lbl_FirstName { get { return T("lbl_FirstName"); } }
            public static string lbl_Floor { get { return T("lbl_Floor"); } }
            public static string lbl_FloorPlan { get { return T("lbl_FloorPlan"); } }
            public static string lbl_FloorPlanName { get { return T("lbl_FloorPlanName"); } }
            public static string lbl_FollowUpAsc { get { return T("lbl_FollowUpAsc"); } }
            public static string lbl_FollowUpDesc { get { return T("lbl_FollowUpDesc"); } }
            public static string lbl_Hr { get { return T("lbl_Hr"); } }
            public static string lbl_Inactive { get { return T("lbl_Inactive"); } }
            public static string lbl_InQueue { get { return T("lbl_InQueue"); } }
            public static string lbl_Last_12Months { get { return T("lbl_Last_12Months"); } }
            public static string lbl_Last_3Months { get { return T("lbl_Last_3Months"); } }
            public static string lbl_Last_7Days { get { return T("lbl_Last_7Days"); } }
            public static string lbl_Last_Day { get { return T("lbl_Last_Day"); } }
            public static string lbl_Last12Month { get { return T("lbl_Last12Month"); } }
            public static string lbl_Last2Week { get { return T("lbl_Last2Week"); } }
            public static string lbl_Last30Day { get { return T("lbl_Last30Day"); } }
            public static string lbl_Last3Month { get { return T("lbl_Last3Month"); } }
            public static string lbl_Last6Month { get { return T("lbl_Last6Month"); } }
            public static string lbl_Last7Day { get { return T("lbl_Last7Day"); } }
            public static string lbl_LastDay { get { return T("lbl_LastDay"); } }
            public static string lbl_LastMonth { get { return T("lbl_LastMonth"); } }
            public static string lbl_LastName { get { return T("lbl_LastName"); } }
            public static string lbl_LastUpdatedAsc { get { return T("lbl_LastUpdatedAsc"); } }
            public static string lbl_LastUpdatedDesc { get { return T("lbl_LastUpdatedDesc"); } }
            public static string lbl_LaunchDate { get { return T("lbl_LaunchDate"); } }
            public static string lbl_Lifetime { get { return T("lbl_Lifetime"); } }
            public static string lbl_Location { get { return T("lbl_Location"); } }
            public static string lbl_MarkCustomSoldTitle { get { return T("lbl_MarkCustomSoldTitle"); } }
            public static string lbl_MarkCustomSPAStampTitle { get { return T("lbl_MarkCustomSPAStampTitle"); } }
            public static string lbl_MarkCustomSPATitle { get { return T("lbl_MarkCustomSPATitle"); } }
            public static string lbl_MarkSoldMsg { get { return T("lbl_MarkSoldMsg"); } }
            public static string lbl_MarkSoldTitle { get { return T("lbl_MarkSoldTitle"); } }
            public static string lbl_MarkSPAStampTitle { get { return T("lbl_MarkSPAStampTitle"); } }
            public static string lbl_MarkSPATitle { get { return T("lbl_MarkSPATitle"); } }
            public static string lbl_Min { get { return T("lbl_Min"); } }
            public static string lbl_Mobile { get { return T("lbl_Mobile"); } }
            public static string lbl_MockSold { get { return T("lbl_MockSold"); } }
            public static string lbl_MTD { get { return T("lbl_MTD"); } }
            public static string lbl_Name { get { return T("lbl_Name"); } }
            public static string lbl_NextRun { get { return T("lbl_NextRun"); } }
            public static string lbl_Others { get { return T("lbl_Others"); } }
            public static string lbl_OTPNumber { get { return T("lbl_OTPNumber"); } }
            public static string lbl_other_people_interest { get { return T("lbl_other_people_interest"); } }
            public static string lbl_PreviousReissue { get { return T("lbl_PreviousReissue"); } }
            public static string lbl_Price { get { return T("lbl_Price"); } }
            public static string lbl_Priority { get { return T("lbl_Priority"); } }

            public static string lbl_Project { get { return T("lbl_Project"); } }
            public static string lbl_PropertyType { get { return T("lbl_PropertyType"); } }
            public static string lbl_ReadyBy { get { return T("lbl_ReadyBy"); } }
            public static string lbl_RequestPrefix { get { return T("lbl_RequestPrefix"); } }
            public static string lbl_RemovedUnitInterestSucc { get { return T("lbl_RemovedUnitInterestSucc"); } }
            public static string lbl_status_Reserved { get { return T("lbl_status_Reserved"); } }
            public static string lbl_status_Reservation { get { return T("lbl_status_Reservation"); } }
            public static string lbl_status_Sold { get { return T("lbl_status_Sold"); } }
            public static string lbl_status_SpaSign { get { return T("lbl_status_SpaSign"); } }
            public static string lbl_status_SpaStamp { get { return T("lbl_status_SpaStamp"); } }
            public static string lbl_status_Sale { get { return T("lbl_status_Sale"); } }
            public static string lbl_SalesRep { get { return T("lbl_SalesRep"); } }
            public static string lbl_ShowOnlyAvaiUnit { get { return T("lbl_ShowOnlyAvaiUnit"); } }
            public static string lbl_SoldOut { get { return T("lbl_SoldOut"); } }
            public static string lbl_SoldRequest { get { return T("lbl_SoldRequest"); } }
            public static string lbl_SPASignRequest { get { return T("lbl_SPASignRequest"); } }
            public static string lbl_SPAStampRequest { get { return T("lbl_SPAStampRequest"); } }
            public static string lbl_StatusEnquire { get { return T("lbl_StatusEnquire"); } }
            public static string lbl_StatusNotAvailable { get { return T("lbl_StatusNotAvailable"); } }
            public static string lbl_SubmissionDateNewToOld { get { return T("lbl_SubmissionDateNewToOld"); } }
            public static string lbl_SubmissionDateOldToNew { get { return T("lbl_SubmissionDateOldToNew"); } }
            public static string lbl_SubmittedBy { get { return T("lbl_SubmittedBy"); } }
            public static string lbl_suffix_Sqft { get { return T("lbl_suffix_Sqft"); } }
            public static string lbl_suffix_Sqm { get { return T("lbl_suffix_Sqm"); } }
            public static string lbl_This_Month { get { return T("lbl_This_Month"); } }
            public static string lbl_This_Year { get { return T("lbl_This_Year"); } }
            public static string lbl_This_Unit { get { return T("lbl_This_Unit"); } }
            public static string lbl_Today { get { return T("lbl_Today"); } }
            public static string lbl_TransactionDate { get { return T("lbl_TransactionDate"); } }
            public static string lbl_TransDateNewToOld { get { return T("lbl_TransDateNewToOld"); } }
            public static string lbl_TransDateOldToNew { get { return T("lbl_TransDateOldToNew"); } }
            public static string lbl_TypeOfRequest { get { return T("lbl_TypeOfRequest"); } }
            public static string lbl_Unit { get { return T("lbl_Unit"); } }
            public static string lbl_UnitArea { get { return T("lbl_UnitArea"); } }
            public static string lbl_UnitsLeft { get { return T("lbl_UnitsLeft"); } }
            public static string lbl_UnitPriority { get { return T("lbl_UnitPriority"); } }
            public static string lbl_UnitType { get { return T("lbl_UnitType"); } }
            public static string lbl_UnitInterestHeader { get { return T("lbl_UnitInterestHeader"); } }
            public static string lbl_UnitInterestSubText { get { return T("lbl_UnitInterestSubText"); } }

            public static string lbl_YTD { get { return T("lbl_YTD"); } }
            public static string msg_2fa_invalidcode { get { return T("msg_2fa_invalidcode"); } }
            public static string msg_2fa_notconfig { get { return T("msg_2fa_notconfig"); } }

            public static string mesg_AddonError { get { return T("mesg_AddonError"); } }
            public static string mesg_AddonMaxReached { get { return T("mesg_AddonMaxReached"); } }
            public static string mesg_AddonStatusChanged { get { return T("mesg_AddonStatusChanged"); } }
            public static string mesg_AddonUnavailable { get { return T("mesg_AddonUnavailable"); } }
            public static string mesg_AddressRequired { get { return T("mesg_AddressRequired"); } }
            public static string mesg_AddressRequiredMultiLine { get { return T("mesg_AddressRequiredMultiLine"); } }
            public static string mesg_AgentBUNotSet { get { return T("mesg_AgentBUNotSet"); } }
            public static string mesg_AuthenticationFailed { get { return T("mesg_AuthenticationFailed"); } }
            public static string mesg_BankNotAvailable { get { return T("mesg_BankNotAvailable"); } }
            public static string mesg_BallotRequireInBooking { get { return T("mesg_BallotRequireInBooking"); } }
            public static string mesg_BallotNotFound { get { return T("mesg_BallotNotFound"); } }
            public static string mesg_BookedRequestApproved { get { return T("mesg_BookedRequestApproved"); } }
            public static string mesg_BookedSuccessfully { get { return T("mesg_BookedSuccessfully"); } }
            public static string mesg_BookingAlreadyApproved { get { return T("mesg_BookingAlreadyApproved"); } }
            public static string mesg_BookingAlreadyCancelled { get { return T("mesg_BookingAlreadyCancelled"); } }
            public static string mesg_BookingCancelPendingApproval { get { return T("mesg_BookingCancelPendingApproval"); } }
            public static string mesg_BookingCancelReasonRequired { get { return T("mesg_BookingCancelReasonRequired"); } }
            public static string mesg_BookingCancelSuccess { get { return T("mesg_BookingCancelSuccess"); } }
            public static string mesg_BookingNewBuyer { get { return T("mesg_BookingNewBuyer"); } }
            public static string mesg_BookingNotFound { get { return T("mesg_BookingNotFound"); } }
            public static string mesg_BookingStageInvalid { get { return T("mesg_BookingStageInvalid"); } }
            public static string mesg_BookingPaymentEmailNotSent { get { return T("mesg_BookingPaymentEmailNotSent"); } }
            public static string mesg_BookingPaymentNotZero { get { return T("mesg_BookingPaymentNotZero"); } }
            public static string mesg_BookingPaymentRefNotSet { get { return T("mesg_BookingPaymentRefNotSet"); } }
            public static string mesg_BookingPriceMismatchEdit { get { return T("mesg_BookingPriceMismatchEdit"); } }
            public static string mesg_BookingPriceMismatchNoEdit { get { return T("mesg_BookingPriceMismatchNoEdit"); } }
            public static string mesg_BookingReissueCancelled { get { return T("mesg_BookingReissueCancelled"); } }
            public static string mesg_BookingReissueCannotUpdate { get { return T("mesg_BookingReissueCannotUpdate"); } }
            public static string mesg_BookingReissueCreated { get { return T("mesg_BookingReissueCreated"); } }
            public static string mesg_BookingReissueDatesNotLatest { get { return T("mesg_BookingReissueDatesNotLatest"); } }
            public static string mesg_BookingReissueFailed { get { return T("mesg_BookingReissueFailed"); } }
            public static string mesg_BookingReissueHeader { get { return T("mesg_BookingReissueHeader"); } }
            public static string mesg_BookingReissueMaxReached { get { return T("mesg_BookingReissueMaxReached"); } }
            public static string mesg_BookingReissueNotEnabled { get { return T("mesg_BookingReissueNotEnabled"); } }
            public static string mesg_BookingReissueRetrieveError { get { return T("mesg_BookingReissueRetrieveError"); } }
            public static string mesg_BuyerFieldsRequired { get { return T("mesg_BuyerFieldsRequired"); } }
            public static string mesg_BuyerIntroducerRequired { get { return T("mesg_BuyerIntroducerRequired"); } }
            public static string mesg_CancelReasonMaxLength { get { return T("mesg_CancelReasonMaxLength"); } }
            public static string mesg_CannotBeFutureDate { get { return T("mesg_CannotBeFutureDate"); } }
            public static string mesg_CannotUnselectLoan { get { return T("mesg_CannotUnselectLoan"); } }
            public static string mesg_DepositReq { get { return T("mesg_DepositReq"); } }
            public static string mesg_DepositRequired { get { return T("mesg_DepositRequired"); } }
            public static string mesg_DOBRequired { get { return T("mesg_DOBRequired"); } }
            public static string mesg_DocumentsRequired { get { return T("mesg_DocumentsRequired"); } }
            public static string mesg_EmailContentEmpty { get { return T("mesg_EmailContentEmpty"); } }
            public static string mesg_EmailSendNotEnabled { get { return T("mesg_EmailSendNotEnabled"); } }
            public static string mesg_EmailSent { get { return T("mesg_EmailSent"); } }
            public static string mesg_ErrorCreateReport { get { return T("mesg_ErrorCreateReport"); } }
            public static string mesg_ErrorDeleteReport { get { return T("mesg_ErrorDeleteReport"); } }
            public static string mesg_ErrorEmailInvalid { get { return T("mesg_ErrorEmailInvalid"); } }
            public static string mesg_ErrorEmailInvalidFirstBuyer { get { return T("mesg_ErrorEmailInvalidFirstBuyer"); } }
            public static string mesg_ErrorEmailNotFound { get { return T("mesg_ErrorEmailNotFound"); } }
            public static string mesg_ErrorEmailSendInvalid { get { return T("mesg_ErrorEmailSendInvalid"); } }
            public static string mesg_ErrorPropertyIdRequired { get { return T("mesg_ErrorPropertyIdRequired"); } }
            public static string mesg_ErrorRetrievingContact { get { return T("mesg_ErrorRetrievingContact"); } }
            public static string mesg_ErrorRetrievingFiles { get { return T("mesg_ErrorRetrievingFiles"); } }
            public static string mesg_ErrorRetrievingPropertyData { get { return T("mesg_ErrorRetrievingPropertyData"); } }
            public static string mesg_ErrorRetrievingPropertyDates { get { return T("mesg_ErrorRetrievingPropertyDates"); } }
            public static string mesg_ErrorRetrievingPropertyMedia { get { return T("mesg_ErrorRetrievingPropertyMedia"); } }
            public static string mesg_ErrorRetrievingPropFilter { get { return T("mesg_ErrorRetrievingPropFilter"); } }
            public static string mesg_ErrorRetrievingPropUnitFilter { get { return T("mesg_ErrorRetrievingPropUnitFilter"); } }
            public static string mesg_ErrorRetrievingReports { get { return T("mesg_ErrorRetrievingReports"); } }
            public static string mesg_ErrorRetrievingReportTypes { get { return T("mesg_ErrorRetrievingReportTypes"); } }
            public static string mesg_ErrorRetrievingUnitSummary { get { return T("mesg_ErrorRetrievingUnitSummary"); } }
            public static string mesg_ErrorSendEmail { get { return T("mesg_ErrorSendEmail"); } }
            public static string mesg_ErrorSendPaymentEmail { get { return T("mesg_ErrorSendPaymentEmail"); } }
            public static string mesg_ErrorSendReport { get { return T("mesg_ErrorSendReport"); } }
            public static string mesg_FieldRequired { get { return T("mesg_FieldRequired"); } }
            public static string mesg_ForUnitSoldOtherAgency { get { return T("mesg_ForUnitSoldOtherAgency"); } }
            public static string mesg_InsufficientPermissions { get { return T("mesg_InsufficientPermissions"); } }
            public static string mesg_InterestSuccess { get { return T("mesg_InterestSuccess"); } }
            public static string mesg_InvalidRequest { get { return T("mesg_InvalidRequest"); } }
            public static string mesg_Invalid_Siteplan { get { return T("mesg_Invalid_Siteplan"); } }
            public static string mesg_InvalidDiscount { get { return T("mesg_InvalidDiscount"); } }
            public static string mesg_InvalidEmailMobile { get { return T("mesg_InvalidEmailMobile"); } }

            public static string mesg_InvalidEmailMobileBallot { get { return T("mesg_InvalidEmailMobileBallot"); } }


            public static string mesg_InvalidInterestId { get { return T("mesg_InvalidInterestId"); } }
            public static string mesg_LeadAddNoPermission { get { return T("mesg_LeadAddNoPermission"); } }
            public static string mesg_LeadHasUnitInterest { get { return T("mesg_LeadHasUnitInterest"); } }
            public static string mesg_ErrorDefaultAgentNotSet { get { return T("mesg_ErrorDefaultAgentNotSet"); } }

            public static string mesg_ErrorBusinessUnitNotSet { get { return T("mesg_ErrorBusinessUnitNotSet"); } }
            public static string mesg_ErrorDeleteUnitInterest { get { return T("mesg_ErrorDeleteUnitInterest"); } }
            public static string mesg_ErrorGetUnitInterest { get { return T("mesg_ErrorGetUnitInterest"); } }
            public static string mesg_ErrorUpdateUnitInterest { get { return T("mesg_ErrorUpdateUnitInterest"); } }
            public static string mesg_ErrorNoUnitInterestFound { get { return T("mesg_ErrorNoUnitInterestFound"); } }
            public static string mesg_ErrorNoCreateBuyerPermission { get { return T("mesg_ErrorNoCreateBuyerPermission"); } }
            public static string mesg_ErrorNoAssignBuyerPermission { get { return T("mesg_ErrorNoAssignBuyerPermission"); } }
            public static string mesg_ErrorNoCreateInterestPermission { get { return T("mesg_ErrorNoCreateInterestPermission"); } }
            public static string mesg_ErrorMax140Chars { get { return T("mesg_ErrorMax140Chars"); } }

            public static string mesg_ErrorMaxUnitPerAgent { get { return T("mesg_ErrorMaxUnitPerAgent"); } }
            public static string mesg_ErrorUnitNotAvailable { get { return T("mesg_ErrorUnitNotAvailable"); } }
            public static string mesg_ErrorUnitNotAvailableRefresh { get { return T("mesg_ErrorUnitNotAvailableRefresh"); } }
            public static string mesg_ErrorValidateLeadUnitInterest { get { return T("mesg_ErrorValidateLeadUnitInterest"); } }
            public static string mesg_MaxUnitHoldReached { get { return T("mesg_MaxUnitHoldReached"); } }
            public static string mesg_MediaAttachment_Whatsapp { get { return T("mesg_MediaAttachment_Whatsapp"); } }
            public static string mesg_MissingParameter { get { return T("mesg_MissingParameter"); } }
            public static string mesg_NRICRequired { get { return T("mesg_NRICRequired"); } }
            public static string mesg_NoUnitSelected { get { return T("mesg_NoUnitSelected"); } }
            public static string mesg_OneBankForApproval { get { return T("mesg_OneBankForApproval"); } }
            public static string mesg_OneBankSubmission { get { return T("mesg_OneBankSubmission"); } }
            public static string mesg_OnHold_StartBooking { get { return T("mesg_OnHold_StartBooking"); } }
            public static string mesg_OnlinePaymentInsufficientPermission { get { return T("mesg_OnlinePaymentInsufficientPermission"); } }
            public static string mesg_OnlinePaymentNotEnabled { get { return T("mesg_OnlinePaymentNotEnabled"); } }
            public static string mesg_OnlinePaymentNotSetup { get { return T("mesg_OnlinePaymentNotSetup"); } }
            public static string mesg_PasswordResetSent { get { return T("mesg_PasswordResetSent"); } }
            public static string mesg_PasswordResetSmsSent { get { return T("mesg_PasswordResetSmsSent"); } }
            public static string mesg_PaymentRefNotSet { get { return T("mesg_PaymentRefNotSet"); } }
            public static string mesg_PriceNotInRange { get { return T("mesg_PriceNotInRange"); } }
            public static string mesg_ProcessingError { get { return T("mesg_ProcessingError"); } }
            public static string mesg_RemarksAdded { get { return T("mesg_RemarksAdded"); } }
            public static string mesg_RemarksUpdated { get { return T("mesg_RemarksUpdated"); } }

            public static string mesg_ReceiptRequired { get { return T("mesg_ReceiptRequired"); } }
            public static string mesg_RequestCancelledSuccessfully { get { return T("mesg_RequestCancelledSuccessfully"); } }
            public static string mesg_RequestSoldSuccessfully { get { return T("mesg_RequestSoldSuccessfully"); } }
            public static string mesg_RequestSPASignedSuccessfully { get { return T("mesg_RequestSPASignedSuccessfully"); } }
            public static string mesg_RequestSPAStampedSuccessfully { get { return T("mesg_RequestSPAStampedSuccessfully"); } }
            public static string mesg_ReservationRequestApproved { get { return T("mesg_ReservationRequestApproved"); } }
            public static string mesg_ReservationSuccess { get { return T("mesg_ReservationSuccess"); } }
            public static string mesg_ReserveDateNotFuture { get { return T("mesg_ReserveDateNotFuture"); } }
            public static string mesg_SelectProject { get { return T("mesg_SelectProject"); } }
            public static string mesg_Siteplan_NoFeatured { get { return T("mesg_Siteplan_NoFeatured"); } }
            public static string mesg_SPASignedRequestApproved { get { return T("mesg_SPASignedRequestApproved"); } }
            public static string mesg_SPASignedSuccessfully { get { return T("mesg_SPASignedSuccessfully"); } }
            public static string mesg_SPAStampedRequestApproved { get { return T("mesg_SPAStampedRequestApproved"); } }
            public static string mesg_SPAStampedSuccessfully { get { return T("mesg_SPAStampedSuccessfully"); } }
            public static string mesg_UnitHoldExpiredBody { get { return T("mesg_UnitHoldExpiredBody"); } }
            public static string mesg_UnitHoldExpiredTitle { get { return T("mesg_UnitHoldExpiredTitle"); } }
            public static string mesg_UnitMarkedAsCustom { get { return T("mesg_UnitMarkedAsCustom"); } }
            public static string mesg_UnitNotAvailableForBooking { get { return T("mesg_UnitNotAvailableForBooking"); } }
            public static string mesg_UnitOnHoldBy { get { return T("mesg_UnitOnHoldBy"); } }
            public static string mesg_UnitPriceNotMatching { get { return T("mesg_UnitPriceNotMatching"); } }
            public static string mesg_UnitRequestAsCustom { get { return T("mesg_UnitRequestAsCustom"); } }
            public static string mesg_UnitStateInvalid { get { return T("mesg_UnitStateInvalid"); } }
            public static string mesg_UnitUnavailable { get { return T("mesg_UnitUnavailable"); } }
            public static string mesg_UpdateApp { get { return T("mesg_UpdateApp"); } }
            public static string mesg_UpdateSuccess { get { return T("mesg_UpdateSuccess"); } }
            public static string mesg_ZeroState_Approval { get { return T("mesg_ZeroState_Approval"); } }
            public static string mesg_ZeroState_Approval_Filter { get { return T("mesg_ZeroState_Approval_Filter"); } }
            public static string mesg_ZeroState_BookingCompTransaction { get { return T("mesg_ZeroState_BookingCompTransaction"); } }
            public static string mesg_ZeroState_BookingCompTransaction_Filter { get { return T("mesg_ZeroState_BookingCompTransaction_Filter"); } }
            public static string mesg_ZeroState_BookingOngTransaction { get { return T("mesg_ZeroState_BookingOngTransaction"); } }
            public static string mesg_ZeroState_BookingOngTransaction_Filter { get { return T("mesg_ZeroState_BookingOngTransaction_Filter"); } }
            public static string mesg_ZeroState_BookingTransaction_Filter { get { return T("mesg_ZeroState_BookingTransaction_Filter"); } }
            public static string mesg_ZeroState_OnHold { get { return T("mesg_ZeroState_OnHold"); } }
            public static string mesg_ZeroState_OnHold_Filter { get { return T("mesg_ZeroState_OnHold_Filter"); } }
            public static string mesg_ZeroState_Siteplan { get { return T("mesg_ZeroState_Siteplan"); } }
            public static string mesg_ZeroState_StackPlan { get { return T("mesg_ZeroState_StackPlan"); } }
            public static string mesg_ZeroStateFilter_StackPlan { get { return T("mesg_ZeroStateFilter_StackPlan"); } }
            public static string mesg_ZeroStateFloorPlan { get { return T("mesg_ZeroStateFloorPlan"); } }
            public static string mesg_ZeroStateFloorPlanWithFilter { get { return T("mesg_ZeroStateFloorPlanWithFilter"); } }
            public static string txt_BookingHeader_MarkAs { get { return T("txt_BookingHeader_MarkAs"); } }
            public static string txt_BookingHeader_PendingCancel { get { return T("txt_BookingHeader_PendingCancel"); } }
            public static string txt_BookingHeader_StatusRequest { get { return T("txt_BookingHeader_StatusRequest"); } }
            public static string txt_LAST_12_MONTH { get { return T("txt_LAST_12_MONTH"); } }
            public static string txt_LAST_3_MONTH { get { return T("txt_LAST_3_MONTH"); } }
            public static string txt_LAST_7_DAY { get { return T("txt_LAST_7_DAY"); } }
            public static string txt_LIFETIME { get { return T("txt_LIFETIME"); } }
            public static string txt_OnHold { get { return T("txt_OnHold"); } }
            public static string txt_OnHold_ReleaseTime { get { return T("txt_OnHold_ReleaseTime"); } }
            public static string txt_ReissueNumber { get { return T("txt_ReissueNumber"); } }
            public static string txt_ReissueOriginal { get { return T("txt_ReissueOriginal"); } }
            public static string txt_THIS_MONTH { get { return T("txt_THIS_MONTH"); } }
            public static string txt_THIS_YEAR { get { return T("txt_THIS_YEAR"); } }
            public static string txt_TODAY { get { return T("txt_TODAY"); } }
            public static string lbl_On { get { return T("lbl_On"); } }
            public static string mesg_DocumentUploadFailure { get { return T("mesg_DocumentUploadFailure"); } }
            public static string txt_UploadedBy { get { return T("txt_UploadedBy"); } }

            public static string mesg_DocumentsRequiredForBallot { get { return T("mesg_DocumentsRequiredForBallot"); } }

            public static string mesg_DocumentsRequiredForLeads { get { return T("mesg_DocumentsRequiredForLeads"); } }
            public static string mesg_BallotUnit_UnitSold { get { return T("mesg_BallotUnit_UnitSold"); } }
            public static string mesg_BallotUnit_UnitNotAvailable { get { return T("mesg_BallotUnit_UnitNotAvailable"); } }
            public static string mesg_BallotUnit_NotBuying { get { return T("mesg_BallotUnit_NotBuying"); } }


        }

        public static partial class CRM
        {
            public static string lbl_Active { get { return T("lbl_Active"); } }
            public static string lbl_AddLead { get { return T("lbl_AddLead"); } }
            public static string lbl_AgencyOrganisation { get { return T("lbl_AgencyOrganisation"); } }
            public static string lbl_AllRemarks { get { return T("lbl_AllRemarks"); } }
            public static string lbl_AssignedTo { get { return T("lbl_AssignedTo"); } }
            public static string lbl_Ascending { get { return T("lbl_Ascending"); } }
            public static string lbl_AverageTime { get { return T("lbl_AverageTime"); } }
            public static string lbl_BackToLogin { get { return T("lbl_BackToLogin"); } }
            public static string lbl_ByDay { get { return T("lbl_ByDay"); } }
            public static string lbl_ByDayVolume { get { return T("lbl_ByDayVolume"); } }
            public static string lbl_ByMonth { get { return T("lbl_ByMonth"); } }
            public static string lbl_ByMonthVolume { get { return T("lbl_ByMonthVolume"); } }
            public static string lbl_ByYear { get { return T("lbl_ByYear"); } }
            public static string lbl_ByYearVolume { get { return T("lbl_ByYearVolume"); } }
            public static string lbl_CEANo { get { return T("lbl_CEANo"); } }
            public static string lbl_ChartUnitCountPercent { get { return T("lbl_ChartUnitCountPercent"); } }
            public static string lbl_Completed { get { return T("lbl_Completed"); } }
            public static string lbl_CompletedLeads { get { return T("lbl_CompletedLeads"); } }
            public static string lbl_Contacted { get { return T("lbl_Contacted"); } }
            public static string lbl_CreateDuplicateLeadConfirmation { get { return T("lbl_CreateDuplicateLeadConfirmation"); } }
            public static string lbl_DaysAgo { get { return T("lbl_DaysAgo"); } }
            public static string lbl_Delete { get { return T("lbl_Delete"); } }
            public static string lbl_Descending { get { return T("lbl_Descending"); } }
            public static string lbl_Duplicate { get { return T("lbl_Duplicate"); } }
            public static string lbl_Edit { get { return T("lbl_Edit"); } }
            public static string lbl_Email { get { return T("lbl_Email"); } }
            public static string lbl_Favourite { get { return T("lbl_Favourite"); } }
            public static string lbl_Filter { get { return T("lbl_Filter"); } }
            public static string lbl_FilterBy { get { return T("lbl_FilterBy"); } }
            public static string lbl_Followup { get { return T("lbl_Followup"); } }
            public static string lbl_ForgotPassword { get { return T("lbl_ForgotPassword"); } }
            public static string lbl_ForgotPasswordHead { get { return T("lbl_ForgotPasswordHead"); } }
            public static string lbl_HourAgo { get { return T("lbl_HourAgo"); } }
            public static string lbl_Inactive { get { return T("lbl_Inactive"); } }
            public static string lbl_invalidtime { get { return T("lbl_invalidtime"); } }
            public static string lbl_IsMandatory { get { return T("lbl_IsMandatory"); } }
            public static string lbl_LastUpdated { get { return T("lbl_LastUpdated"); } }
            public static string lbl_Lead { get { return T("lbl_Lead"); } }
            public static string lbl_Leads { get { return T("lbl_Leads"); } }
            public static string lbl_LeadsConverted { get { return T("lbl_LeadsConverted"); } }
            public static string lbl_LeadSelectDefault { get { return T("lbl_LeadSelectDefault"); } }
            public static string lbl_LeadStatus { get { return T("lbl_LeadStatus"); } }
            public static string lbl_LifeCycleDay { get { return T("lbl_LifeCycleDay"); } }
            public static string lbl_ListView { get { return T("lbl_ListView"); } }
            public static string lbl_Login { get { return T("lbl_Login"); } }
            public static string lbl_Lost { get { return T("lbl_Lost"); } }
            public static string lbl_MinAgo { get { return T("lbl_MinAgo"); } }
            public static string lbl_Mobile { get { return T("lbl_Mobile"); } }
            public static string lbl_More { get { return T("lbl_More"); } }
            public static string lbl_Move { get { return T("lbl_Move"); } }
            public static string lbl_MoveLeadPipeline { get { return T("lbl_MoveLeadPipeline"); } }
            public static string lbl_Name { get { return T("lbl_Name"); } }
            public static string lbl_NewLeads { get { return T("lbl_NewLeads"); } }
            public static string lbl_Nofollowup { get { return T("lbl_Nofollowup"); } }
            public static string lbl_NoRank { get { return T("lbl_NoRank"); } }
            public static string lbl_NoUpcomingTask { get { return T("lbl_NoUpcomingTask"); } }
            public static string lbl_OngoingLeads { get { return T("lbl_OngoingLeads"); } }
            public static string lbl_OrganizationName { get { return T("lbl_OrganizationName"); } }
            public static string lbl_Overdue { get { return T("lbl_Overdue"); } }
            public static string lbl_Password { get { return T("lbl_Password"); } }
            public static string lbl_PipelineStage { get { return T("lbl_PipelineStage"); } }
            public static string lbl_PipelineView { get { return T("lbl_PipelineView"); } }
            public static string lbl_PreviousInterests { get { return T("lbl_PreviousInterests"); } }
            public static string lbl_Progression { get { return T("lbl_Progression"); } }
            public static string lbl_PricePSM { get { return T("lbl_PricePSM"); } }
            public static string lbl_PricePSF { get { return T("lbl_PricePSF"); } }
            public static string lbl_Reassign { get { return T("lbl_Reassign"); } }
            public static string lbl_Reassigned { get { return T("lbl_Reassigned"); } }
            public static string lbl_RegisterHeader { get { return T("lbl_RegisterHeader"); } }
            public static string lbl_Reset { get { return T("lbl_Reset"); } }
            public static string lbl_SalesRankByValue { get { return T("lbl_SalesRankByValue"); } }
            public static string lbl_SalesRep { get { return T("lbl_SalesRep"); } }
            public static string lbl_SalesVolumeByProject { get { return T("lbl_SalesVolumeByProject"); } }
            public static string lbl_Search { get { return T("lbl_Search"); } }
            public static string lbl_SearchName { get { return T("lbl_SearchName"); } }
            public static string lbl_SelectFilter { get { return T("lbl_SelectFilter"); } }
            public static string lbl_SignUp { get { return T("lbl_SignUp"); } }
            public static string lbl_SortBy { get { return T("lbl_SortBy"); } }
            public static string lbl_StartSelling { get { return T("lbl_StartSelling"); } }
            public static string lbl_Status { get { return T("lbl_Status"); } }
            public static string lbl_Submit { get { return T("lbl_Submit"); } }
            public static string lbl_SuggestedTask { get { return T("lbl_SuggestedTask"); } }
            public static string lbl_TapToSelect { get { return T("lbl_TapToSelect"); } }
            public static string lbl_Today { get { return T("lbl_Today"); } }
            public static string lbl_ToDo { get { return T("lbl_ToDo"); } }
            public static string lbl_Tomorrow { get { return T("lbl_Tomorrow"); } }
            public static string lbl_TotalSaleValue { get { return T("lbl_TotalSaleValue"); } }
            public static string lbl_TotalUnitSold { get { return T("lbl_TotalUnitSold"); } }
            public static string lbl_Unassigned { get { return T("lbl_Unassigned"); } }
            public static string lbl_UpdateStatus { get { return T("lbl_UpdateStatus"); } }
            public static string lbl_Yesterday { get { return T("lbl_Yesterday"); } }
            public static string lbl_You { get { return T("lbl_You"); } }
            public static string lbl_ZeroStateDashBoardFunnel { get { return T("lbl_ZeroStateDashBoardFunnel"); } }
            public static string lbl_ZeroStateDashBoardFunnelDetails { get { return T("lbl_ZeroStateDashBoardFunnelDetails"); } }
            public static string lbl_ZeroStateDashBoardFunnelManager { get { return T("lbl_ZeroStateDashBoardFunnelManager"); } }
            public static string lbl_ZeroStateTeamSaleSummary { get { return T("lbl_ZeroStateTeamSaleSummary"); } }
            public static string lbl_ZeroStateTeamSaleSummaryPeriod { get { return T("lbl_ZeroStateTeamSaleSummaryPeriod"); } }
            public static string mesg_AcctNotApproved { get { return T("mesg_AcctNotApproved"); } }
            public static string mesg_ActiveLeadPipelineAgentTitle { get { return T("mesg_ActiveLeadPipelineAgentTitle"); } }
            public static string mesg_ActiveLeadPipelineFailure { get { return T("mesg_ActiveLeadPipelineFailure"); } }
            public static string mesg_ActiveLeadPipelineUnassignedTitle { get { return T("mesg_ActiveLeadPipelineUnassignedTitle"); } }
            public static string mesg_AddLeadFail { get { return T("mesg_AddLeadFail"); } }
            public static string mesg_AddLeadSuccess { get { return T("mesg_AddLeadSuccess"); } }
            public static string mesg_AppointmnetTaskCountExceed { get { return T("mesg_AppointmnetTaskCountExceed"); } }
            public static string mesg_AutoCreateAccountDupEmail { get { return T("mesg_AutoCreateAccountDupEmail"); } }
            public static string mesg_AutoCreateAccountDupMobile { get { return T("mesg_AutoCreateAccountDupMobile"); } }
            public static string mesg_AutoCreateAccountMissingInfo { get { return T("mesg_AutoCreateAccountMissingInfo"); } }
            public static string mesg_AutoCreateAccountSuccess { get { return T("mesg_AutoCreateAccountSuccess"); } }
            public static string mesg_BlockedLeads { get { return T("mesg_BlockedLeads"); } }
            public static string mesg_BookmarkAddFail { get { return T("mesg_BookmarkAddFail"); } }
            public static string mesg_BookmarkAddSuccess { get { return T("mesg_BookmarkAddSuccess"); } }
            public static string mesg_BookmarkRemoveFail { get { return T("mesg_BookmarkRemoveFail"); } }
            public static string mesg_BookmarkRemoveSuccess { get { return T("mesg_BookmarkRemoveSuccess"); } }
            public static string mesg_Completed { get { return T("mesg_Completed"); } }
            public static string mesg_Confirmation_Footer { get { return T("mesg_Confirmation_Footer"); } }
            public static string mesg_ConflictApp_Title { get { return T("mesg_ConflictApp_Title"); } }
            public static string mesg_CreateDuplicateLeadConfirmation { get { return T("mesg_CreateDuplicateLeadConfirmation"); } }
            public static string mesg_DuplicateAppointment { get { return T("mesg_DuplicateAppointment"); } }
            public static string mesg_DuplicateAppointment_SalesRep { get { return T("mesg_DuplicateAppointment_SalesRep"); } }
            public static string mesg_DuplicateLead { get { return T("mesg_DuplicateLead"); } }
            public static string mesg_DuplicateTask { get { return T("mesg_DuplicateTask"); } }
            public static string mesg_DuplicateTask_SalesRep { get { return T("mesg_DuplicateTask_SalesRep"); } }
            public static string mesg_EmailSent { get { return T("mesg_EmailSent"); } }
            public static string mesg_ExistingLead { get { return T("mesg_ExistingLead"); } }
            public static string mesg_ExpiredAccount { get { return T("mesg_ExpiredAccount"); } }
            public static string mesg_IdleLeadsTipMessage { get { return T("mesg_IdleLeadsTipMessage"); } }
            public static string mesg_InactiveAndExpiredAccount { get { return T("mesg_InactiveAndExpiredAccount"); } }
            public static string mesg_IncorrectEmail { get { return T("mesg_IncorrectEmail"); } }
            public static string mesg_IncorrectMobile { get { return T("mesg_IncorrectMobile"); } }
            public static string mesg_IncorrectPassword { get { return T("mesg_IncorrectPassword"); } }
            public static string mesg_IncorrectUsername { get { return T("mesg_IncorrectUsername"); } }
            public static string mesg_LoginFailed { get { return T("mesg_LoginFailed"); } }
            public static string mesg_InvalidTaskType { get { return T("mesg_InvalidTaskType"); } }
            public static string mesg_LeadAccepted { get { return T("mesg_LeadAccepted"); } }
            public static string mesg_LeadAddFail { get { return T("mesg_LeadAddFail"); } }
            public static string mesg_LeadAddSuccess { get { return T("mesg_LeadAddSuccess"); } }
            public static string mesg_LeadDeleteActiveBooking { get { return T("mesg_LeadDeleteActiveBooking"); } }
            public static string mesg_LeadDeleteBody { get { return T("mesg_LeadDeleteBody"); } }
            public static string mesg_LeadDeleteBodyMulti { get { return T("mesg_LeadDeleteBodyMulti"); } }
            public static string mesg_LeadDeleteBodyMulti_Type1 { get { return T("mesg_LeadDeleteBodyMulti_Type1"); } }
            public static string mesg_LeadDeleteFail { get { return T("mesg_LeadDeleteFail"); } }
            public static string mesg_LeadDeleteFooter { get { return T("mesg_LeadDeleteFooter"); } }
            public static string mesg_LeadDeleteInQueue { get { return T("mesg_LeadDeleteInQueue"); } }
            public static string mesg_LeadDeleteNoChanges { get { return T("mesg_LeadDeleteNoChanges"); } }
            public static string mesg_LeadDeleteNoPermission { get { return T("mesg_LeadDeleteNoPermission"); } }
            public static string mesg_LeadDeleteNotFound { get { return T("mesg_LeadDeleteNotFound"); } }
            public static string mesg_LeadDeleteSuccess { get { return T("mesg_LeadDeleteSuccess"); } }
            public static string mesg_LeadDeleteTitle { get { return T("mesg_LeadDeleteTitle"); } }
            public static string mesg_LeadFunnelError { get { return T("mesg_LeadFunnelError"); } }
            public static string mesg_LeadInterest { get { return T("mesg_LeadInterest"); } }
            public static string mesg_LeadReassignBodyMulti { get { return T("mesg_LeadReassignBodyMulti"); } }
            public static string mesg_LeadReassignBodyMulti_Type1 { get { return T("mesg_LeadReassignBodyMulti_Type1"); } }
            public static string mesg_LeadReassignFail { get { return T("mesg_LeadReassignFail"); } }
            public static string mesg_LeadReassignNoPermission { get { return T("mesg_LeadReassignNoPermission"); } }
            public static string mesg_LeadReassignNotAllowed { get { return T("mesg_LeadReassignNotAllowed"); } }
            public static string mesg_LeadRejected { get { return T("mesg_LeadRejected"); } }
            public static string mesg_LeadReregister { get { return T("mesg_LeadReregister"); } }
            public static string mesg_LeadStageUpdateBodyMulti { get { return T("mesg_LeadStageUpdateBodyMulti"); } }
            public static string mesg_LeadStageUpdateBodyMulti_Type1 { get { return T("mesg_LeadStageUpdateBodyMulti_Type1"); } }
            public static string mesg_LeadStageUpdateFail { get { return T("mesg_LeadStageUpdateFail"); } }
            public static string mesg_LeadStageUpdateNoPermission { get { return T("mesg_LeadStageUpdateNoPermission"); } }
            public static string mesg_LeadStageUpdateNotAllowed { get { return T("mesg_LeadStageUpdateNotAllowed"); } }
            public static string mesg_LeadStageUpdateSuccess { get { return T("mesg_LeadStageUpdateSuccess"); } }
            public static string mesg_LeadStatusUpdateBodyMulti { get { return T("mesg_LeadStatusUpdateBodyMulti"); } }
            public static string mesg_LeadStatusUpdateBodyMulti_Type1 { get { return T("mesg_LeadStatusUpdateBodyMulti_Type1"); } }
            public static string mesg_LeadStatusUpdateNoPermission { get { return T("mesg_LeadStatusUpdateNoPermission"); } }
            public static string mesg_LeadStatusUpdateNotAllowed { get { return T("mesg_LeadStatusUpdateNotAllowed"); } }
            public static string mesg_LeadStatusUpdateSuccess { get { return T("mesg_LeadStatusUpdateSuccess"); } }
            public static string mesg_LeadUpdateFail { get { return T("mesg_LeadUpdateFail"); } }
            public static string mesg_LeadUpdateNoPermission { get { return T("mesg_LeadUpdateNoPermission"); } }
            public static string mesg_LeadUpdateSuccess { get { return T("mesg_LeadUpdateSuccess"); } }
            public static string mesg_MulitpleLeadDeleteSuccess { get { return T("mesg_MulitpleLeadDeleteSuccess"); } }
            public static string mesg_MulitpleLeadStageUpdateSuccess { get { return T("mesg_MulitpleLeadStageUpdateSuccess"); } }
            public static string mesg_MulitpleLeadStatusUpdateSuccess { get { return T("mesg_MulitpleLeadStatusUpdateSuccess"); } }
            public static string mesg_MulitpleReassignSuccess { get { return T("mesg_MulitpleReassignSuccess"); } }
            public static string mesg_MultipleOrg { get { return T("mesg_MultipleOrg"); } }
            public static string mesg_MultipleOrgReset { get { return T("mesg_MultipleOrgReset"); } }
            public static string mesg_NewLeadOffered { get { return T("mesg_NewLeadOffered"); } }
            public static string mesg_NewLeadOffered2 { get { return T("mesg_NewLeadOffered2"); } }
            public static string mesg_NewLeads { get { return T("mesg_NewLeads"); } }
            public static string mesg_NewLeadsMessage { get { return T("mesg_NewLeadsMessage"); } }
            public static string mesg_NewlyAssignedLead { get { return T("mesg_NewlyAssignedLead"); } }
            public static string mesg_NewlyAssignedLeadDiffSalesRep { get { return T("mesg_NewlyAssignedLeadDiffSalesRep"); } }
            public static string mesg_NoLeadsReceived { get { return T("mesg_NoLeadsReceived"); } }
            public static string mesg_NoLeadsReceived_Manager { get { return T("mesg_NoLeadsReceived_Manager"); } }
            public static string mesg_NonAppointmnetTaskCountExceed { get { return T("mesg_NonAppointmnetTaskCountExceed"); } }
            public static string mesg_NoPreviousData { get { return T("mesg_NoPreviousData"); } }
            public static string mesg_NoTaskCreated { get { return T("mesg_NoTaskCreated"); } }
            public static string mesg_NoTaskCreated_Manager { get { return T("mesg_NoTaskCreated_Manager"); } }
            public static string mesg_NoTaskCreatedBody { get { return T("mesg_NoTaskCreatedBody"); } }
            public static string mesg_NoTaskCreatedBody_Manager { get { return T("mesg_NoTaskCreatedBody_Manager"); } }
            public static string mesg_NoTaskDetails { get { return T("mesg_NoTaskDetails"); } }
            public static string mesg_NoTaskFilter { get { return T("mesg_NoTaskFilter"); } }
            public static string mesg_NoTaskFilter_Manager { get { return T("mesg_NoTaskFilter_Manager"); } }
            public static string mesg_NoTaskFilterBody { get { return T("mesg_NoTaskFilterBody"); } }
            public static string mesg_NoTaskFilterBody_Manager { get { return T("mesg_NoTaskFilterBody_Manager"); } }
            public static string mesg_NoTaskForDay { get { return T("mesg_NoTaskForDay"); } }
            public static string mesg_NoTaskForDay_Manager { get { return T("mesg_NoTaskForDay_Manager"); } }
            public static string mesg_NoTaskForDayAndFuture { get { return T("mesg_NoTaskForDayAndFuture"); } }
            public static string mesg_NoTaskForDayAndFuture_Manager { get { return T("mesg_NoTaskForDayAndFuture_Manager"); } }
            public static string mesg_NoTaskForDayAndFutureBody { get { return T("mesg_NoTaskForDayAndFutureBody"); } }
            public static string mesg_NoTaskForDayAndFutureBody_Manager { get { return T("mesg_NoTaskForDayAndFutureBody_Manager"); } }
            public static string mesg_NoTaskForDayBody { get { return T("mesg_NoTaskForDayBody"); } }
            public static string mesg_NoTaskForDayBody_Manager { get { return T("mesg_NoTaskForDayBody_Manager"); } }
            public static string mesg_NoTaskLeadsTipMessage { get { return T("mesg_NoTaskLeadsTipMessage"); } }
            public static string mesg_NoTaskTitle { get { return T("mesg_NoTaskTitle"); } }
            public static string mesg_NoTaskWithFilterDetails { get { return T("mesg_NoTaskWithFilterDetails"); } }
            public static string mesg_NoTaskWithFilterTitle { get { return T("mesg_NoTaskWithFilterTitle"); } }
            public static string mesg_ProductivityInfoError { get { return T("mesg_ProductivityInfoError"); } }
            public static string mesg_ReassignSuccess { get { return T("mesg_ReassignSuccess"); } }
            public static string mesg_TagNotFound { get { return T("mesg_TagNotFound"); } }
            public static string mesg_TagRemoveFail { get { return T("mesg_TagRemoveFail"); } }
            public static string mesg_TagRemoveSuccess { get { return T("mesg_TagRemoveSuccess"); } }
            public static string mesg_TaskAddFail { get { return T("mesg_TaskAddFail"); } }
            public static string mesg_TaskAddSuccess { get { return T("mesg_TaskAddSuccess"); } }
            public static string mesg_TaskCountExceed { get { return T("mesg_TaskCountExceed"); } }
            public static string mesg_TaskCountExceedTitle { get { return T("mesg_TaskCountExceedTitle"); } }
            public static string mesg_TaskCreateValidationMsg { get { return T("mesg_TaskCreateValidationMsg"); } }
            public static string mesg_TaskDeleteFail { get { return T("mesg_TaskDeleteFail"); } }
            public static string mesg_TaskDeleteSuccess { get { return T("mesg_TaskDeleteSuccess"); } }
            public static string mesg_TaskDetailsFail { get { return T("mesg_TaskDetailsFail"); } }
            public static string mesg_TaskEditFail { get { return T("mesg_TaskEditFail"); } }
            public static string mesg_TaskEditSuccess { get { return T("mesg_TaskEditSuccess"); } }
            public static string mesg_TaskListFail { get { return T("mesg_TaskListFail"); } }
            public static string mesg_TaskUncompleted { get { return T("mesg_TaskUncompleted"); } }
            public static string mesg_TaskViewValidationMsg { get { return T("mesg_TaskViewValidationMsg"); } }
            public static string mesg_TimeLeftToAccept { get { return T("mesg_TimeLeftToAccept"); } }
            public static string mesg_UnassignedLeadsFail { get { return T("mesg_UnassignedLeadsFail"); } }
            public static string mesg_UnassignedLeadsNoPermission { get { return T("mesg_UnassignedLeadsNoPermission"); } }
            public static string mesg_UnassignedLeadsRestrictions { get { return T("mesg_UnassignedLeadsRestrictions"); } }
            public static string mesg_UnexpectedError { get { return T("mesg_UnexpectedError"); } }
            public static string mesg_UnknownContactAdmin { get { return T("mesg_UnknownContactAdmin"); } }
            public static string mesg_UpdateFailed { get { return T("mesg_UpdateFailed"); } }
            public static string mesg_UpdateSuccess { get { return T("mesg_UpdateSuccess"); } }
            public static string mesg_UpdateSuccessful { get { return T("mesg_UpdateSuccessful"); } }
            public static string mesg_ZeroStateAcceptanceRateOverall { get { return T("mesg_ZeroStateAcceptanceRateOverall"); } }
            public static string mesg_ZeroStateAcceptanceRateOverall_Manager { get { return T("mesg_ZeroStateAcceptanceRateOverall_Manager"); } }
            public static string mesg_ZeroStateAcceptanceRatePeriod_Manager { get { return T("mesg_ZeroStateAcceptanceRatePeriod_Manager"); } }
            public static string mesg_ZeroStateAcceptanceRateTimePeriod { get { return T("mesg_ZeroStateAcceptanceRateTimePeriod"); } }
            public static string mesg_ZeroStateFirstContactTimeOverall { get { return T("mesg_ZeroStateFirstContactTimeOverall"); } }
            public static string mesg_ZeroStateFirstContactTimeOverall_Manager { get { return T("mesg_ZeroStateFirstContactTimeOverall_Manager"); } }
            public static string mesg_ZeroStateFirstContactTimePeriod { get { return T("mesg_ZeroStateFirstContactTimePeriod"); } }
            public static string mesg_ZeroStateFirstContactTimePeriod_Manager { get { return T("mesg_ZeroStateFirstContactTimePeriod_Manager"); } }
            public static string mesg_ZeroStateLeadsSummary { get { return T("mesg_ZeroStateLeadsSummary"); } }
            public static string mesg_ZeroStateLeadsSummaryDetails { get { return T("mesg_ZeroStateLeadsSummaryDetails"); } }
            public static string mesg_ZeroStateLeadsSummaryManager { get { return T("mesg_ZeroStateLeadsSummaryManager"); } }
            public static string mesg_ZeroStateLeadsSummaryOverall { get { return T("mesg_ZeroStateLeadsSummaryOverall"); } }
            public static string mesg_ZeroStateLeadsSummaryOverallManager { get { return T("mesg_ZeroStateLeadsSummaryOverallManager"); } }
            public static string mesg_ZeroStateProductivityDetails { get { return T("mesg_ZeroStateProductivityDetails"); } }
            public static string mesg_ZeroStateProductivityInfo { get { return T("mesg_ZeroStateProductivityInfo"); } }
            public static string mesg_ZeroStateSummarySources { get { return T("mesg_ZeroStateSummarySources"); } }
            public static string mesg_ZeroStateTeamsSummary { get { return T("mesg_ZeroStateTeamsSummary"); } }
            public static string mesg_NoBallotEventRunning { get { return T("mesg_NoBallotEventRunning"); } }
            public static string mesg_DuplicateBallot { get { return T("mesg_DuplicateBallot"); } }
            public static string mesg_DuplicateBallotTitle { get { return T("mesg_DuplicateBallotTitle"); } }
            public static string txt_AddNewLead { get { return T("txt_AddNewLead"); } }
            public static string txt_AssignedToYou { get { return T("txt_AssignedToYou"); } }
            public static string txt_DayOverdue { get { return T("txt_DayOverdue"); } }
            public static string txt_Days { get { return T("txt_Days"); } }
            public static string txt_DaysOverdue { get { return T("txt_DaysOverdue"); } }
            public static string txt_DeleteLead { get { return T("txt_DeleteLead"); } }
            public static string txt_DeleteLeadConfirm { get { return T("txt_DeleteLeadConfirm"); } }
            public static string txt_DeleteLeadMsg { get { return T("txt_DeleteLeadMsg"); } }
            public static string txt_DeleteSelectedLead { get { return T("txt_DeleteSelectedLead"); } }
            public static string txt_DueInDays { get { return T("txt_DueInDays"); } }
            public static string txt_DueInMonths { get { return T("txt_DueInMonths"); } }
            public static string txt_DueToday { get { return T("txt_DueToday"); } }
            public static string txt_DueTomorrow { get { return T("txt_DueTomorrow"); } }
            public static string txt_DuplicateLead { get { return T("txt_DuplicateLead"); } }
            public static string txt_FastFirstContactTimeTip { get { return T("txt_FastFirstContactTimeTip"); } }
            public static string txt_From { get { return T("txt_From"); } }
            public static string txt_FromPrevious12Months { get { return T("txt_FromPrevious12Months"); } }
            public static string txt_FromPrevious3Months { get { return T("txt_FromPrevious3Months"); } }
            public static string txt_FromPrevious7Days { get { return T("txt_FromPrevious7Days"); } }
            public static string txt_FromPreviousMonth { get { return T("txt_FromPreviousMonth"); } }
            public static string txt_FromPreviousYear { get { return T("txt_FromPreviousYear"); } }
            public static string txt_FromYesterday { get { return T("txt_FromYesterday"); } }
            public static string txt_GenericAcceptanceRateTip { get { return T("txt_GenericAcceptanceRateTip"); } }
            public static string txt_GenericFirstContactTimeTip { get { return T("txt_GenericFirstContactTimeTip"); } }
            public static string txt_HighAcceptanceRateTip { get { return T("txt_HighAcceptanceRateTip"); } }
            public static string txt_HourOverdue { get { return T("txt_HourOverdue"); } }
            public static string txt_Hours { get { return T("txt_Hours"); } }
            public static string txt_HoursOverdue { get { return T("txt_HoursOverdue"); } }
            public static string txt_IDLE { get { return T("txt_IDLE"); } }
            public static string txt_InvalidEmail { get { return T("txt_InvalidEmail"); } }
            public static string txt_LastUpdated { get { return T("txt_LastUpdated"); } }
            public static string txt_LastUpdatedRemarkes { get { return T("txt_LastUpdatedRemarkes"); } }
            public static string txt_LeadAssignAutomaticTaskTitle { get { return T("txt_LeadAssignAutomaticTaskTitle"); } }
            public static string txt_LeadReassignAutomaticTaskTitle { get { return T("txt_LeadReassignAutomaticTaskTitle"); } }
            public static string txt_LowAcceptanceRateTip { get { return T("txt_LowAcceptanceRateTip"); } }
            public static string txt_MinuteOverdue { get { return T("txt_MinuteOverdue"); } }
            public static string txt_Minutes { get { return T("txt_Minutes"); } }
            public static string txt_MinutesOverdue { get { return T("txt_MinutesOverdue"); } }
            public static string txt_Moments { get { return T("txt_Moments"); } }
            public static string txt_MonthOverdue { get { return T("txt_MonthOverdue"); } }
            public static string txt_Months { get { return T("txt_Months"); } }
            public static string txt_MonthsOverdue { get { return T("txt_MonthsOverdue"); } }
            public static string txt_MoveLead { get { return T("txt_MoveLead"); } }
            public static string txt_MoveLeadPipeline { get { return T("txt_MoveLeadPipeline"); } }
            public static string txt_Of { get { return T("txt_Of"); } }
            public static string txt_ReassignLead { get { return T("txt_ReassignLead"); } }
            public static string txt_RegisterHeader { get { return T("txt_RegisterHeader"); } }
            public static string txt_Selected { get { return T("txt_Selected"); } }
            public static string txt_SelectMultiple { get { return T("txt_SelectMultiple"); } }
            public static string txt_Showing { get { return T("txt_Showing"); } }
            public static string txt_SlowFirstContactTimeTip { get { return T("txt_SlowFirstContactTimeTip"); } }
            public static string txt_Tasks { get { return T("txt_Tasks"); } }
            public static string txt_To { get { return T("txt_To"); } }
            public static string txt_UpdateStatus { get { return T("txt_UpdateStatus"); } }
            public static string txt_Years { get { return T("txt_Years"); } }
            public static string txt_YearsOverdue { get { return T("txt_YearsOverdue"); } }

            public static string mesg_BuyerNotFound { get { return T("mesg_BuyerNotFound"); } }
            public static string mesg_QueueOfferExpired { get { return T("mesg_QueueOfferExpired"); } }
            public static string mesg_NotElligibleToAccept { get { return T("mesg_NotElligibleToAccept"); } }

            public static string mesg_BuyerQueueNotFound { get { return T("mesg_BuyerQueueNotFound"); } }

            public static string mesg_Password_Expiring { get { return T("mesg_Password_Expiring"); } }
        }

        public static string RegexToken(string value)
        {
            return string.Format("@{{{0}}}", value);
        }

        public static bool TryGetRegexTokenValue(string input, out string value)
        {
            if (!string.IsNullOrWhiteSpace(input))
            {
                var m = Regex.Match(input, @"@\{(.+?)\}");

                if (m.Success)
                {
                    //get second group
                    value = m.Groups[1].Value;
                    return true;
                }
            }

            value = null;
            return false;

        }

        public static string GetAgencyCustomMessage(string orgName, string resourceSet, string token)
        {
            // Update for BTN
            string btnResourceSetValue = "";
            if (orgName.ToLower() == "btn")
            {
                // Try to add BTN_ label to resourceSet:
                string btnToken = "BTN_" + token;

                if (resourceSet.ToLower() == "crm")
                {
                    // Get CRM
                    btnResourceSetValue = CRM.T(btnToken);
                }
                else
                {
                    //Get esales
                    btnResourceSetValue = ESALES.T(btnToken);
                }
            }

            if (string.IsNullOrEmpty(btnResourceSetValue))
            {
                if (resourceSet.ToLower() == "crm")
                {
                    // Get CRM
                    return CRM.T(token);
                }
                else
                {
                    //Get esales
                    return ESALES.T(token);
                }
            }
            else
            {
                return btnResourceSetValue;
            }

        }


        public static class LEGACY
        {
            public static string T(string resId)
            {
                return DbRes.T(resId, "LEGACY");
            }
            public static string T(string resId, string lang)
            {
                return DbRes.T(resId, "LEGACY", lang);
            }
            public static string TDefault(string resId, string defaultText)
            {
                return DbRes.TDefault(resId, defaultText, "LEGACY");
            }
            public static string TDefault(string resId, string defaultText, string lang)
            {
                return DbRes.TDefault(resId, defaultText, "LEGACY", lang);
            }
        }
    }
}
