using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyGuru.FastKey.Utilities
{
    public class SharedConstant
    {
        #region " AGENCY ID "

        public static readonly Guid AGENCY_NUSASIRI = new Guid("a5a0b78a-6dfb-4ab9-8324-e7c41101afc5");
        public static readonly Guid AGENCY_HAPSENG = new Guid("F89083BE-5C76-497F-8F0D-25F2F280BEED");
        public static readonly Guid AGENCY_MIDLANDSCITY = new Guid("ee6234b1-d38d-4875-9a90-07764f0e0b91");
        public static readonly Guid AGENCY_EMKAY = new Guid("907ebc92-f778-418c-ba87-5399a63b7529");
        public static readonly Guid AGENCY_TAGLOBAL = new Guid("304c7cfe-b322-4f5f-ab94-7b2af1e53d35");
        public static readonly Guid AGENCY_EXSIM = new Guid("1cac446a-73ac-4a1c-a876-961719eb698e");
        public static readonly Guid AGENCY_TTDI = new Guid("eeeba065-6bff-4979-9843-fadc66399f9a");
        public static readonly Guid AGENCY_TTG = new Guid("70bac98c-9e6c-4e1f-bc03-3109545c1a62");
        public static readonly Guid AGENCY_BON = new Guid("02b38477-c6ee-4218-9591-a7c95644035e");
        public static readonly Guid AGENCY_GUOCOLAND = new Guid("caa9e06b-caff-4979-9843-fadc6639ffe1");
        public static readonly Guid AGENCY_MRCBGAPURNA = new Guid("9c6bbc5b-e005-4e44-bf12-9e6bd73cef14");
        public static readonly Guid AGENCY_GUOCOMY = new Guid("02E5E26B-CAFF-4979-9913-FA2CDA39FFE1");
        public static readonly Guid AGENCY_MRCBPREMA = new Guid("326c6114-224d-4197-a058-76f8ec3860b6");
        public static readonly Guid AGENCY_MRCB = new Guid("31c19ac6-91a6-4c75-a425-2f7c25928832");
        public static readonly Guid AGENCY_EUPE_PARC3 = new Guid("daa51284-dec2-4661-af22-8bdf2df37b30");
        public static readonly Guid AGENCY_MULPHA = new Guid("aaaae06b-caff-4979-9913-faecda39ffe1");
        public static readonly Guid AGENCY_EUPE = new Guid("cdba0342-69f9-4c08-88ec-3078f777ccf2");
        public static readonly Guid AGENCY_SCLAND = new Guid("ea402da4-277c-4dd1-8ca3-8b0600646c9b");
        public static readonly Guid AGENCY_MERIDIAN = new Guid("03893f6b-f435-4aea-96d3-f0a83387b1de");
        public static readonly Guid AGENCY_OXLEY = new Guid("21ecbfb6-4df0-4acb-b8bb-45ee00ebc943");
        public static readonly Guid AGENCY_CBLAND = new Guid("91bba604-19f8-4e52-8437-5926e6ae0205");
        public static readonly Guid AGENCY_ECOWORLD = new Guid("32619726-d423-4a56-b774-029f463871ce");
        public static readonly Guid AGENCY_POLLUX = new Guid("5c5ce9a5-c0c4-4c60-a6e2-9197ec208b84");
        public static readonly Guid AGENCY_WCL = new Guid("c1e5e06b-caff-4979-9913-a12cda39ffe1");

        public static readonly Guid AGENCY_CONEFF = new Guid("cce9e06a-6bff-4979-9843-fadc6639ffe1");
        public static readonly Guid AGENCY_UEM = new Guid("f7c995d5-3178-425d-be69-41656fcaafe8");
        public static readonly Guid AGENCY_KLMETRO = new Guid("e9a4342f-9be7-4284-a10b-5610e621b6f7");
        public static readonly Guid AGENCY_SPB = new Guid("b0c6fc09-0785-4623-9ec6-95f2f878ac41");
        public static readonly Guid AGENCY_AIKBEE = new Guid("49eb1557-48a2-40cc-b132-e4a2a75454cc");

        public static readonly Guid AGENCY_SGHOLDING = new Guid("0f3c57c8-4955-4f40-b68e-5ef0bed0cd3d");

        public static readonly Guid AGENCY_MAHSING = new Guid("0cea2833-9d77-4521-b610-e56ee04b8e76");


        public static readonly Guid AGENCY_CITYOFDREAM = new Guid("77D7303C-51DF-4754-A5EC-F8C5478DFBC0");
        public static readonly Guid AGENCY_UOL = new Guid("1A1AE061-CAFF-4979-9913-FAECDA39FFE1");
        public static readonly Guid AGENCY_MEIKARTA = new Guid("1BA68085-50B5-493F-B097-533A6C7FEE37");
        public static readonly Guid AGENCY_TAMAN = new Guid("2fc07bcc-7a35-46c2-92ce-e823943c3bf5");
        public static readonly Guid AGENCY_LENDLEASE = new Guid("EBD0A71D-F075-409F-8310-B93728376830");
        public static readonly Guid AGENCY_METLAND = new Guid("33C558F2-5853-4FC8-8DD2-EA73EDBF0800");
        public static readonly Guid AGENCY_PATRALAND = new Guid("6EA67C27-3A42-4108-831F-D17AD9129724");
        public static readonly Guid AGENCY_MATRIX = new Guid("86314f09-659e-4a04-b464-e7da87363021");
        public static readonly Guid AGENCY_TRINITI = new Guid("511B32A5-C539-4692-814B-742F16E379DF");
        public static readonly Guid AGENCY_WIRALAND = new Guid("9EB3AC3E-D9CB-4751-A111-AA5974201B53");
        public static readonly Guid AGENCY_KBP = new Guid("9115B5BC-CFB4-4BE5-A334-1015311F2D47");

        public static readonly Guid AGENCY_TEB = new Guid("EBE5E16B-EBFF-4979-9913-FAECDA39FFE1");
        public static readonly Guid AGENCY_EPTCHINA = new Guid("81F49BB5-7B7B-4B97-9419-20B7EE190147");//dtz// new Guid("81f49bb5-7b7b-4b97-9419-20b7ee190147");
        public static readonly Guid AGENCY_TEE = new Guid("a3720c0e-a5d9-42c3-a54f-29e7ce412428");
        public static readonly Guid AGENCY_MASTERON = new Guid("bb9a2b8e-e515-4d84-ad14-a428155114e5");
        public static readonly Guid AGENCY_FCL = new Guid("fc10a067-6bff-4979-9843-fadc6639ffe1");
        public static readonly Guid AGENCY_TROPICANA = new Guid("ce1c36ce-2d1d-4bca-a7b9-53b2b7680685");
        public static readonly Guid AGENCY_SUNWAYGROUP = new Guid("6641216b-16a0-4cf1-bb06-fe70afdf7c99");

        public static readonly Guid AGENCY_KLWC = new Guid("F7D7F340-DCAA-4414-9C13-C405A1A6A945");

        
        #endregion

        public const string RESOURCESET_CRM = "CRM";
        public const string RESOURCESET_APP_LOCALE = "APP_LOCALE";
        public const string RESOURCESET_LOGIN_LOCALE = "LOGIN_LOCALE";
        public const string RESOURCESET_ESALES = "ESALES";

        public enum LoginClassification
        {
            InternalUser = 1,
            InternalExternalUser = 2,
            ExternalUser = 3,
            Prospect = 4,
            NetworkInApp = 5
        }

        public enum SharedMode
        {
            INTERNAL_EXTERNAL = 0,
            EXTERNAL_ONLY = 1
        }
        public enum LANGUAGE
        {
            [Description("en-GB")]
            English = 0,
            [Description("zh-CN")]
            Chinese = 1,
            [Description("th-TH")]
            Thai = 2,
            [Description("id-ID")]
            Indonesian = 3,
            [Description("ja-JP")]
            Japanese = 4,
            [Description("vi-VN")]
            Vietname = 5
        }

        public enum StatusStage
        {
            [Description("Un-Qualified")]
            UNQUALIFIED = 1,
            [Description("Qualified")]
            QUALIFIED = 2,
            [Description("Won")]
            WON = 3,
            [Description("Lost")]
            LOST = 4
        }

        public enum UNIT_STATUS
        {
            NONE = -1,
            [Description("Not Available")]
            UNAVAILABLE = 1,
            [Description("Mock Sold")]
            MOCK_SOLD = 100,
            [Description("On Hold")]
            ON_HOLD = 200,
            [Description("Available")]
            AVAILABLE = 441850000,
            [Description("Pre-Reserved")]
            PRE_RESERVED = 441850001,
            [Description("Reserved")]
            RESERVED = 441850002,
            [Description("Sold")]
            SOLD = 441850003,
            [Description("SPA Signed")]
            SPA_SIGNED = 441850010,
            [Description("Spa Stamped")]
            SPA_STAMPED = 441850020
        }


        /// <summary>
        /// From old system to support old integrations
        /// </summary>
        public enum GenericResponseCode
        {
            SUCCESS = 0,
            ERROR = 1,
            UNKNOWN_ERROR = 10,
            INVALID_TOKEN = 11,
            MISSING_ORGNAME = 12,
            INVALID_BOOKING_ID = 13,
            INTERNAL_AUTH_ERROR = 14,
            INVALID_DATE_FORMAT = 15,
            MISSING_DATE = 16,
            ALREADY_CANCELLED = 21,
            INSUFFICIENT_PERMISSIONS = 22,
            INVALID_BOOKINGSTATE = 24,

        }

        public enum AuditLogSource
        {
            App = 0,
            Mgmt_Portal = 1,
            Service = 2,
            BackgroundService = 3,
            IntegrationApi = 4
        }
        public enum AuditLogOp
        {
            Portal_ExportProspects = 1,
            Portal_ExportTransaction = 2,
            Portal_UpdateUnits = 3,
            Portal_UpdateTransactions = 4,
            Portal_BookingUpdate = 5,
            App_UnitStatusChange = 11,
            App_RequestBooking = 12,
            App_CancelBookingReq = 13,
            App_UpdateBooking = 14,
            App_BookingStatusChange = 15,
            App_BookingCancel = 16,
            App_SPA = 17, //// Mark SPA Sign
            App_Deny_Reservation_Request = 18,
            App_CancelBookingReqOutcome = 19,
            App_SPA_STAMP = 20, //// Mark SPA Stamp
            Auto_ReleasePendingApprovalUnit = 21,
            Auto_ReleaseReservedUnit = 22,
            App_SPA_Sign_Request = 23,
            App_SPA_Stamp_Request = 24,
            App_RequestSold = 25,
            App_Deny_Sold_Request = 26,
            App_Deny_SPA_Signed_Request = 27,
            App_Deny_SPA_Stamped_Request = 28,
            App_Deny_Cancelation_Request = 29,
            Auto_Reassign = 30,
            Manual_Reassign = 31,
            Booking_Reissue = 32,
            User_Update = 33,
            User_Update_Email = 34,
            User_Update_Mobile = 35,
            App_Unit_Remarks_Update = 36,

            App_Mark_Reserved = 37,
            App_Mark_Sold = 38,// new
            App_RequestReserve = 39,
            App_Approve_Reserved = 40,
            App_Approve_Sold = 41,
            App_Approve_SPA_SIGN = 42,
            App_Approve_SPA_STAMP = 43,

            Loan_Status_Change = 201,
            Loan_Assign = 202,
            Loan_Buyer_Consent = 203,
            Loan_Deleted = 204,
            Loan_Updated = 205,
            Loan_Created = 206,
            Password_Request = 101,
            Password_Change = 102,
            Portal_ExportUnitInterest = 2101,
            Portal_ImportUnitInterest = 2102,
            Portal_ImportTransaction = 2201,
            Portal_ImportBallots = 2302,
            //Loan_Created = 33,
            //Loan_Updated = 34,
            //Loan_Deleted = 35,

            Auto_TurnCold_Success = 3001,
            Auto_TurnCold_Failure = 3002,

            Integration_Api_Update_MasterData = 4001,
            Integration_Api_Update_Booking = 4002,
            Integration_Api_Booking_Cancel = 4003,
            Integration_Api_Mark_SPA_Sign = 4004,
            Integration_Api_Mark_SPA_Stamp = 4005,
            Integration_Api_Update_Property = 4006,
            Integration_Api_Update_Discount = 4007,

        }

        public enum BOOKING_STATUS
        {
            INVALID = -1,
            UNDEFINED = 0,
            [Description("Cancelled")]
            CANCELLED = 1,
            [Description("Cancelled")]
            IN_PROGRESS = 1,
            [Description("Pre-Reserved")]
            PRE_RESERVED = 2,
            [Description("Reserved")]
            RESERVED = 441850000,
            [Description("Sold")]
            CONTRACT = 441850001,
            [Description("Sold")]
            SOLD = 441850001,
            [Description("SPA Signed")]
            SPA_SIGNED = 441850010,
            [Description("SPA Stamped")]
            SPA_STAMPED = 441850020
        }

        public enum BOOKING_SUB_STATUS
        {
            NONE = 0,
            [Description("Cancelled")]
            PENDING_REQ_CANCEL = 1,
            [Description("Pending Request Reservation")]
            PENDING_REQ_RESERVATION = 2,
            [Description("Pending Request Sold")]
            PENDING_REQ_SOLD = 3,
            [Description("Pending Request SPA Signed")]
            PENDING_REQ_SPA_SIGNED = 4,
            [Description("Pending Request SPA Stamped")]
            PENDING_REQ_SPA_STAMPED = 5
        }

        public enum APP_BOOKING_STATUS
        {
            PreReserved = 0,
            Reservation = 1,
            Sold = 2,
            SPA_Signed = 3,
            SPA_Stamped = 4
        }


        public enum REQ_DOC_STATUS
        {
            NONE = 0,
            CANCELLED = 1,
            PRE_RESERVED = 20, //- (2, 2)
                               //PRE_SOLD = 5 , //- (2, 3)
            RESERVED = 30, //- (441850000, 0)
            REQ_SOLD = 31,//- (441850000, 3) or (2, 3)
            CONTRACT = 40, //- (441850001, 0)
            CONTRACT_REQ_SPA_SIGNED = 41, //- (441850001, 4)
            SPA_SIGNED = 50, //	- (441850010, 0)
            SPA_SIGNED_REQ_STAMP = 51,  // - (441850010, 5)
            SPA_STAMPED = 60 //- (441850020, 0)
        }


        public enum BuyerQueueAuditOperation
        {
            [Description("Check In")]
            CheckIn = 1,
            [Description("Manual Check Out")]
            ManualCheckOut = 2,
            [Description("Force Check Out")]
            ForceCheckOut = 3,
            [Description("Buyer Enter Queue")]
            BuyerEnterQueue = 11,
            [Description("Update Buyer Status")]
            UpdateBuyerStatus = 12,
            [Description("Repeat Enquiry by Lead In Queue")]
            BuyerOtherInquiry = 13,
            [Description("Repeat Enquiry by Lead")]
            BuyerOtherInquiryNotInQueue = 14,
            [Description("Lead Offered")]
            OfferedBuyer = 21,
            [Description("Lead Accepted")]
            AcceptBuyer = 22,
            [Description("Lead Declined")]
            DeclineBuyer = 23,
            [Description("Lead Auto Declined")]
            AutoDeclineBuyer = 24,
            [Description("Check In - CMS")]
            CMS_CheckIn = 25,
            [Description("Check Out - CMS")]
            CMS_CheckOut = 26,
            [Description("Eligible Status Change - CMS")]
            CMS_Update = 27,
            [Description("Lead Queue Status Update - CMS")]
            CMS_UpdateBuyerQueueStatus = 28,
            [Description("Lead Auto Reassign")]
            AutoReassign = 30,
            [Description("Lead Manual Reassign")]
            ManualReassign = 31,
            [Description("Lead Created")]
            BuyerCreated = 33,
            [Description("Lead Queue Status Update")]
            UpdateBuyerQueueStatus = 34,
            [Description("Lead Assigned Default Agent")]
            DefaultSalesRepAssigned = 35,
            [Description("Lead Accepted -  CMS")]
            CMS_AcceptBuyer = 36,
            [Description("Lead Decclined -  CMS")]
            CMS_DeclineBuyer = 37,
            [Description("Lead Assigned To Agent -  CMS")]
            CMS_BuyerAssigned = 38,
            [Description("Lead Assigned To Agent -  CMS")]
            BuyerAssigned = 39,
            [Description("Lead Deleted")]
            BuyerDeleted = 40,
            [Description("Direct Lead Assignment")]
            DirectAssignment = 41,
            //new audits added for new CRM
            [Description("Update Buyer Stage")]
            UpdateBuyerStage = 42,
            [Description("Lead Re-Register")]
            Lead_Reregister = 43,
            [Description("Task Created")]
            TaskCreated = 44,
            [Description("Task Deleted")]
            TaskDeleted = 45,
            [Description("Task Completed")]
            TaskCompleted = 46,
            [Description("Task Marked Incomplete ")]
            TaskInCompleted = 47,
            [Description("Notes Added")]
            NotesTaskAdded = 48,
            [Description("Lead Email Update")]
            LeadEmailUpdate = 49,
            [Description("Lead Mobile Update")]
            LeadMobileUpdate = 50,

            [Description("Lead Pushed Back to Queue")]
            Lead_BackToQueue = 51

        }

        public enum BuyerQueueStatus
        {
            PendingOffer = 1,
            PendingAcceptance = 2,
            Accepted = 3,
            Updated = 4
        }

        public enum BuyerQueueProcessingStatus
        {
            NotProcess = 1,
            ErrorAttempt2 = 2,
            ErrorAttempt3 = 3,
            ErrorAttempt4 = 4,
            ErrorAttempt5 = 5,
            SuccessProcessed = 10,
            FinalError = 20,
        }

        public enum PropertyAgentQueueEligibleStatus
        {
            Eligible = 1,
            NotEligible_PendingAcceptance = 2,
            NotEligible_PendingUpdate = 3
        }


        public enum AddonOptionStatus
        {
            Not_Released = 1,
            Available = 2,
            Asssigned = 3
        }

        public enum AddonType
        {
            Fixed = 1,
            FixedWithOption = 2,
            Inventory = 3
        }

        public enum PushMessageType
        {
            RESERVATION_DONE = 0,
            REQ_RESERVATION_APPROVAL = 1,
            REQ_SOLD_APPROVAL = 102,
            REQ_SPA_SIGNED_APPROVAL = 103,
            REQ_SPA_STAMPED_APPROVAL = 104,
            PUBLIC_MESSAGE = 2,
            SOLD = 3,
            SPA_SIGNED = 302,
            SPA_STAMPED = 303,
            CANCEL = 4,
            INDIVIDUAL = 5,
            CANCEL_APPROVAL = 6,
            CANCEL_SPA_APPROVAL = 7,
            DENY_REQ_RESERVATION = 8,
            DENY_REQ_SOLD = 802,
            DENY_REQ_SPA_SIGNED = 803,
            DENY_REQ_SPA_STAMPED = 804,
            DENY_CANCELLATION = 9,
            DUPLICATE_BUYER_IN_BOOKING = 400,
            BANKER_LOAN_STATUS_UPDATE = 500,
            BANKER_MESSAGE = 501,

            ////// CRM new type
            LEAD_OFFERING = 601, // Individual, This will be directly from code and will be skipped in background processing
            LEAD_ASSIGN_DIRECT = 602, // Individual, This will be directly from code and will be skipped in background processing
            LEAD_OFFERING_TIMEOUT = 603, // Individual, This will be directly from code and will be skipped in background processing
            //LEAD_OFFERING_TIMEOUT_MANAGER = 604, //Manager, This will be directly from code and will be skipped in background processing
            LEAD_REASSIGN = 605, // Individual
            LEAD_CONVERTED = 606, // Individual
            LEAD_CONVERTED_MANAGER = 612, // Manager
            LEAD_DIFF_SOURCE_SAME_PROJ_SAME_AGENT = 607, // Individual
            LEAD_OFFLINE_SOURCE_SAME_PROJ_DIFF_AGENT = 608, // Individual
            LEAD_SAMEDIFF_SOURCE_DIFF_PROJ_SAME_AGENT = 609, // Individual
            LEAD_SAMEDIFF_SOURCE_DIFF_PROJ_DIFF_AGENT_OLD_AGENT = 610, // Individual
            LEAD_OFFLINE_SOURCE_DIFF_PROJ_DIFF_AGENT = 611, // Individual
            LEAD_SAMEDIFF_SOURCE_DIFF_PROJ_DIFF_AGENT_NEW_AGENT = 614, // Individual

            ///// PushMessage type to be sent in Reminder background job:
            REMINDER_OVERDUE_TASK = 701, // Individual message for agent who has lead overdue task
            REMINDER_TODAY_TASK = 702, // Individual message for agent who has lead today task
            REMINDER_OVERDUE_AND_TODAY_TASK_MANAGER = 703, // Individual message for manager whose team has lead today task or overdue task
            REMINDER_LEAD_NO_TASK = 704, // Individual message for agent who has lead with no task
            REMINDER_IDLE_LEAD = 705, // Individual message for agent who has idle lead
            REMINDER_LEAD_NO_TASK_MANAGER = 706, // Individual message for manager whose team has lead with no task
            REMINDER_LEAD_IDLE_LEAD_MANAGER = 707, // Individual message for manager whose team has lead with idle lead
            REMINDER_UNASSIGNLEAD = 708,

            REMINDER_FOR_APPOINTMENT = 709, // Individual message for agent who has upcoming appointment ///// NOT USE YET

            HOLD_QUEUE_ASSIGN = 10,
            HOLD_QUEUE_ASSIGN_FAIL = 11,
            HOLD_QUEUE_LOST = 12
        }

       
    }
}
