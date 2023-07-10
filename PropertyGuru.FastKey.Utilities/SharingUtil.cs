using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using static PropertyGuru.FastKey.Utilities.SharedConstant;

namespace PropertyGuru.FastKey.Utilities
{
    public class SharingUtil
    {
        public static string FormatPrice(string currencySymbol, string cultureInfo, Guid countryId, decimal price, int decimalPlaces, int maskDigit = 0)
        {
            string priceFormat = "N" + decimalPlaces.ToString();
            CultureInfo culInfo = CultureInfo.InvariantCulture;
            string result;

            //rus: if the cultureInfo on countries (of property) is set then use specified cultureInfo otherwise use invariantculture
            if (!string.IsNullOrEmpty(cultureInfo))
            {
                culInfo = new CultureInfo(cultureInfo);
            }

            ////rus: for Indonesia we display the currency symbol at the back
            //if (countryId.ToString() == "536df1a5-3944-49e9-9d1e-f245a7eefdc7")
            //{
            //    result = price.ToString(priceFormat, culInfo) + " " + currencySymbol;
            //}
            //else
            //{
            //result = currencySymbol + price.ToString(priceFormat, culInfo);
            //}

            result = currencySymbol + price.ToString(priceFormat, culInfo);

            if (maskDigit > 0)
            {
                result = MaskString(result, maskDigit);
            }
            return result;
        }

        private static string MaskString(string result, int maskDigit)
        {
            int index = result.Length - 1;
            StringBuilder sb = new StringBuilder(result);
            while (maskDigit != 0 && index != -1)
            {
                if (Char.IsDigit(sb[index]))
                {
                    sb[index] = 'x';
                    maskDigit = maskDigit - 1;
                }
                index = index - 1;
            }
            result = sb.ToString();
            return result;
        }

        public static string AgentFullName(string firstName, string lastName)
        {
             return (string.IsNullOrEmpty(firstName)) ? lastName : firstName + " " + lastName;
        }

        public static string GetDefaultSelectionLabel(int selection, int region, bool isAgency, Guid agencyId)
        {
            string sia = string.Empty;
            Guid wclOrg = new Guid("c1e5e06b-caff-4979-9913-a12cda39ffe1");
            Guid meridianOrg = new Guid("03893f6b-f435-4aea-96d3-f0a83387b1de");
            Guid oxleyOrg = new Guid("21ecbfb6-4df0-4acb-b8bb-45ee00ebc943");
            Guid midlandscityOrg = new Guid("ee6234b1-d38d-4875-9a90-07764f0e0b91");
            Guid ecoworldOrg = new Guid("32619726-d423-4a56-b774-029f463871ce");
            //custom for wcl
            if (agencyId == wclOrg) //wcl 
            {
                if (selection == 1)
                {
                    sia = "Country of Residence";
                }
                else if (selection == 2)
                {
                    sia = "Nationality";
                }
                else if (selection == 3)
                {
                    sia = "Buyer Status";
                }
                else if (selection == 6)
                {
                    sia = "Parking Lot";
                }
                else if (selection == 7)
                {
                    sia = "Color Scheme";
                }
                else if (selection == 8)
                {
                    sia = "Furniture Package";
                }
                else if (selection == 9)
                {
                    sia = "FIRB/Non-FIRB";
                }
            }
            else if (agencyId == meridianOrg)
            {
                if (selection == 1)
                {
                    sia = "Country of Residence";
                }
                else if (selection == 2)
                {
                    sia = "Nationality";
                }
                else if (selection == 3)
                {
                    sia = "Buyer Status";
                }
                else if (selection == 6)
                {
                    sia = "Payment Schedule";
                }
            }
            else
            {
                if (region == 0)
                {
                    if (selection == 1)
                    {
                        if (agencyId == oxleyOrg)
                        {
                            sia = string.Empty;
                        }
                        else
                        {
                            sia = "Buyer Status";
                        }
                    }
                    else if (selection == 2)
                    {
                        sia = "Citizenship";
                    }
                    else if (selection == 3)
                    {
                        sia = "Residential";
                    }
                    if (!isAgency)
                    {
                        if (selection == 4)
                        {
                            if (agencyId == oxleyOrg)
                            {
                                sia = string.Empty;
                            }
                            else
                            {
                                sia = "District";
                            }
                        }
                    }
                }
                else if (region == 1)
                {
                    if (!isAgency)
                    {
                        if (selection == 1)
                        {
                            sia = "[{\"l\":0,\"v\":\"Profile\"},{\"l\":1,\"v\":\"身份\"}]"; ;// "Profile";
                            if (agencyId == new Guid("aaaae06b-caff-4979-9913-faecda39ffe1")) //mulpha
                            {
                                sia = "Solicitor";
                            }
                            else if (agencyId == new Guid("cdba0342-69f9-4c08-88ec-3078f777ccf2")) //eupe
                            {
                                sia = string.Empty;
                            }
                            else if (agencyId == new Guid("1cac446a-73ac-4a1c-a876-961719eb698e") || agencyId == SharedConstant.AGENCY_MRCBGAPURNA) //exsim
                            {
                                sia = string.Empty;
                            }
                            else if (agencyId == SharedConstant.AGENCY_TTDI)
                            {
                                sia = "Existing NAZA Buyer";
                            }
                            else if (agencyId == SharedConstant.AGENCY_EMKAY)
                            {
                                sia = "Employment Sector";
                            }
                        }
                        if (selection == 2)
                        {
                            if (agencyId == SharedConstant.AGENCY_TTDI)
                            {
                                sia = "[{\"l\":0,\"v\":\"Mode Of Purchase\"},{\"l\":1,\"v\":\"购买方式\"}]";
                            }
                            else if (agencyId == SharedConstant.AGENCY_MRCBGAPURNA)
                            {
                                sia = "Type of ownership";
                            }
                            else if (agencyId == SharedConstant.AGENCY_EMKAY)
                            {
                                sia = "Monthly Income";
                            }
                            else
                            {
                                sia = "[{\"l\":0,\"v\":\"Age\"},{\"l\":1,\"v\":\"年龄\"}]";
                            }

                        }
                        if (selection == 3)
                        {
                            if (agencyId == SharedConstant.AGENCY_BON)
                            {
                                sia = "[{\"l\":0,\"v\":\"Mode Of Purchase\"},{\"l\":1,\"v\":\"购买方式\"}]";
                            }
                            else if (agencyId == SharedConstant.AGENCY_EMKAY)
                            {
                                sia = "Purchase Purpose";
                            }
                            else if (agencyId == SharedConstant.AGENCY_MRCBGAPURNA)
                            {
                                sia = String.Empty;
                            }
                            else
                            {
                                sia = "[{\"l\":0,\"v\":\"Race\"},{\"l\":1,\"v\":\"种族\"}]";
                            }

                        }
                        if (selection == 4)
                        {
                            if (agencyId == SharedConstant.AGENCY_EMKAY)
                            {
                                sia = "Occupation";
                            }
                            else if (agencyId != new Guid("ac05e06b-caff-4979-9913-faecda39ffe1") && agencyId != SharedConstant.AGENCY_MRCBGAPURNA)
                            {
                                sia = "[{\"l\":0,\"v\":\"Region\"},{\"l\":1,\"v\":\"地区\"}]";
                            }
                        }

                        if (agencyId == midlandscityOrg)
                        {
                            if (selection == 6)
                            {
                                sia = "Lawyers";
                            }
                        }
                        if (agencyId == ecoworldOrg)
                        {
                            if (selection == 6)
                            {
                                sia = "Source of Finance";
                            }
                            else if (selection == 7)
                            {
                                sia = "Lot status";
                            }
                        }
                        if (agencyId == SharedConstant.AGENCY_EMKAY)
                        {
                            if (selection == 6)
                            {
                                sia = "Mode of Financing";
                            }
                            else if (selection == 7)
                            {
                                sia = "Attestation Solicitor (SPA)";
                            }
                        }


                        if (agencyId == SharedConstant.AGENCY_CONEFF)
                        {
                            if (selection == 6)
                            {
                                sia = "Solicitor";
                            }
                            else if (selection == 7)
                            {
                                sia = "Source Finance";
                            }
                        }

                        if (agencyId == SharedConstant.AGENCY_KLMETRO)
                        {
                            if (selection == 6)
                            {
                                sia = "[{\"l\":0,\"v\":\"Lease Back\"},{\"l\":1,\"v\":\"回租\"}]";
                            }
                            else if (selection == 7)
                            {

                                sia = sia = "[{\"l\":0,\"v\":\"Mode Of Purchase\"},{\"l\":1,\"v\":\"购买方式\"}]";
                            }
                            else if (selection == 8)
                            {
                                sia = "[{\"l\":0,\"v\":\"Deposit\"},{\"l\":1,\"v\":\"定金\"}]";
                            }
                        }

                        if (agencyId == SharedConstant.AGENCY_SPB)
                        {
                            if (selection == 6)
                            {
                                sia = "PAYMENT OPTIONS";
                            }

                        }

                        if (agencyId == SharedConstant.AGENCY_AIKBEE)
                        {
                            if (selection == 6)
                            {
                                sia = "MODE OF FINANCING";
                            }

                        }

                        if (agencyId == SharedConstant.AGENCY_BON)
                        {
                            if (selection == 6)
                            {
                                sia = "Solicitor";
                            }

                        }

                        if (agencyId == SharedConstant.AGENCY_CITYOFDREAM)
                        {
                            if (selection == 6)
                            {
                                sia = "Purchase Under";
                            }
                            else if (selection == 7)
                            {
                                sia = "Solicitor";
                            }
                            else if (selection == 8)
                            {
                                sia = "Mode of Financing";
                            }
                        }
                    }
                }

            }
            return sia;
        }



    }
}
