using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyGuru.FastKey.Utilities
{
    public static class MessageHelper
    {
        public static string STATUS_MESSAGE_SEPARATOR => "-";

        public static class Generic
        {
            public static string Pass => "pass";
            public static string Fail => "fail";
        }

        public static class Constant
        {
            public static string Success => "0";
            public static string Fail => "1";
            public static string ZeroState => "2";
            public static string UpdateApp => "3";

            public static string LoginError => "10";
            public static string MultipleAuth => "11";
            public static string NumberofDeviceExceeded => "12";
            public static string UsernameNotFound => "13";
            public static string AllowAutoSignUp => "14";
            public static string Initialize2FA => "20";
            public static string Require2FA => "21";


            public static string DuplicateBuyerFound => "100";
            public static string DeleteLeadConfirmation => "101";
            public static string DuplicateTaskFound => "102";
            public static string TaskThreshholdExceeded => "103";
            public static string ReassignLeadConfirmation => "104";
            public static string LeadUpdateConfirmation => "105";

            public static string DuplicateBuyerAssignSunway => "1001";

            public static string IntegrationError => "110";
            public static string IntegrationInvalidToken => "111";

            public static string LeadInvalidStatus = "120";

            public static string InsufficientPermission => "200";
            public static string PriceMismatchConfirmation => "201";
            public static string PriceMismatchError => "202";
            public static string NotAvailableForBooking => "203";

            public static string MaxLimitReach => "300";
            public static string InterestCreationFailed => "301";

            [Obsolete("Use MutipleAuth", true)]
            public static string MultipleAuthenticationFail => "multipleAuth";
            [Obsolete("Use LoginError", true)]
            public static string AuthFail => "authfail";
            [Obsolete("Use LoginError", true)]
            public static string Expired => "expired";
            [Obsolete("Use LoginError", true)]
            public static string NotApproved => "notApproved";
            [Obsolete("Use NumberofDeviceExceeded", true)]
            public static string NumDevicesExceeded => "numdevicesexceeded";
        }


    }
}
