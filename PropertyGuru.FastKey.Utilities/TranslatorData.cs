using Microsoft.Extensions.Localization;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Westwind.Globalization.AspnetCore.Resources;

namespace PropertyGuru.FastKey.Utilities
{
    public class TranslatorData
    {
        public class TranslationItem
        {
            public int l { get; set; }
            public string v { get; set; }
        }


        public static string AddTranslation(string strCurrentValue, int newLanguage, string strNewValue)
        {
            string strResult = string.Empty;
            List<TranslationItem> lstItems = new List<TranslationItem>();
            bool booCreateNew = false;
            bool booAddCurrent = false;

            if (!string.IsNullOrEmpty(strCurrentValue))
            {
                if (strCurrentValue.StartsWith("[") && strCurrentValue.EndsWith("]")) //For json array
                {
                    try
                    {
                        lstItems = (List<TranslationItem>)JsonConvert.DeserializeObject(strCurrentValue, typeof(List<TranslationItem>));
                        if (lstItems != null && lstItems.Count > 0)
                        {
                            var foundItem = lstItems.Where(x => x.l == newLanguage).FirstOrDefault();
                            if (foundItem != null)
                            {
                                if (string.IsNullOrEmpty(strNewValue))
                                {
                                    lstItems.Remove(foundItem);
                                }
                                else
                                {
                                    //if found then update the value
                                    ((TranslationItem)foundItem).v = strNewValue;
                                }
                            }
                            else
                            {
                                booCreateNew = true;
                            }
                        }
                        else
                        {
                            // should not go here; no chances of empty array
                            booCreateNew = true;
                        }
                    }
                    catch (Exception e)
                    {
                        // should not go here
                        //LogEvent.LogEventLogic.LogError(LogEvent.LogCategory.Rest_Service, "Error on parsing translation item.", e);
                        booAddCurrent = true;
                        booCreateNew = true;
                    }
                }
                else
                {
                    // if the current value is not in json format
                    booCreateNew = true;
                    if (newLanguage != (int)SharedConstant.LANGUAGE.English)
                    {
                        booAddCurrent = true;
                    }
                }
            }
            else
            {
                booCreateNew = true;
            }

            if (booAddCurrent)
            {
                // the current value just a text
                TranslationItem currentItem = new TranslationItem();
                currentItem.l = (int)SharedConstant.LANGUAGE.English;
                currentItem.v = strCurrentValue;
                lstItems.Add(currentItem);
            }

            if (booCreateNew)
            {
                // if the new language is not found then add
                TranslationItem newItem = new TranslationItem();
                newItem.l = newLanguage;
                newItem.v = strNewValue;
                if (!string.IsNullOrEmpty(strNewValue))
                {
                    lstItems.Add(newItem);
                }
            }

            if (lstItems != null && lstItems.Count > 0)
            {
                strResult = JsonConvert.SerializeObject(lstItems);
            }

            return strResult;
        }

        public static string GetTranslation(string strValue, int prmLanguage, bool getDefaultIfEmpty = false)
        {
            string strResult = string.Empty;
            string defaultValue = (getDefaultIfEmpty) ? strValue : string.Empty;
            if (!string.IsNullOrEmpty(strValue))
            {
                try
                {
                    // For array
                    if (strValue.StartsWith("[") && strValue.EndsWith("]"))
                    {
                        // Convert json format to list 
                        List<TranslationItem> lstItems = (List<TranslationItem>)JsonConvert.DeserializeObject(strValue, typeof(List<TranslationItem>));
                        if (lstItems != null && lstItems.Count > 0)
                        {
                            // Check if the collection has the required language
                            var foundItem = lstItems.Where(x => x.l == prmLanguage).FirstOrDefault();
                            if (foundItem != null)
                            {
                                strResult = ((TranslationItem)foundItem).v;
                            }
                            else if (getDefaultIfEmpty)
                            {
                                // Check if the collection has the default language
                                var defaultItem = lstItems.Where(x => x.l == (int)SharedConstant.LANGUAGE.English).FirstOrDefault();
                                if (defaultItem != null)
                                {
                                    strResult = ((TranslationItem)defaultItem).v;
                                }
                                else
                                {
                                    // If required language and default language is not found, then return empty string
                                    strResult = string.Empty;
                                }
                            }
                        }
                        else
                        {
                            strResult = defaultValue;
                        }
                    }
                    // For legacy values, without language
                    else
                    {
                        strResult = (prmLanguage == (int)SharedConstant.LANGUAGE.English) ? strValue : defaultValue;
                    }
                }
                catch (Exception ex)
                {
                    strResult = strValue;
                    //LogEvent.LogEventLogic.LogError(LogEvent.LogCategory.Mngmnt_Portal, "During Translation", ex);
                }
            }
            return strResult;
        }

        public static string getTranslation(string strValue, int prmLanguage)
        {
            string strResult = string.Empty;
            if (!string.IsNullOrEmpty(strValue))
            {
                try
                {
                    if (strValue.StartsWith("[") && strValue.EndsWith("]")) //For array
                    {
                        //convert json format to list of collection
                        List<TranslationItem> lstItems = (List<TranslationItem>)JsonConvert.DeserializeObject(strValue, typeof(List<TranslationItem>));
                        if (lstItems != null && lstItems.Count > 0)
                        {
                            //check if the collection has the required language
                            var foundItem = lstItems.Where(x => x.l == prmLanguage).FirstOrDefault();
                            if (foundItem != null)
                            {
                                strResult = ((TranslationItem)foundItem).v;
                            }
                            else
                            {
                                //check if the collection has the default language
                                var defaultItem = lstItems.Where(x => x.l == (int)SharedConstant.LANGUAGE.English).FirstOrDefault();
                                if (defaultItem != null)
                                {
                                    strResult = ((TranslationItem)defaultItem).v;
                                }
                                else
                                {
                                    //if required language and default language is not found then return empty
                                    strResult = string.Empty;
                                }
                            }
                        }
                        else
                        {
                            strResult = strValue;
                        }
                    }
                    else
                    {
                        strResult = strValue;
                    }
                }
                catch (Exception exp)
                {
                    strResult = strValue;
                }
            }
            return strResult;
        }

        private static bool NeedEscape(string src, int i)
        {
            char c = src[i];
            return c < 32 || c == '"' || c == '\\'
                // Broken lead surrogate
                || (c >= '\uD800' && c <= '\uDBFF' &&
                    (i == src.Length - 1 || src[i + 1] < '\uDC00' || src[i + 1] > '\uDFFF'))
                // Broken tail surrogate
                || (c >= '\uDC00' && c <= '\uDFFF' &&
                    (i == 0 || src[i - 1] < '\uD800' || src[i - 1] > '\uDBFF'))
                // To produce valid JavaScript
                || c == '\u2028' || c == '\u2029'
                // Escape "</" for <script> tags
                || (c == '/' && i > 0 && src[i - 1] == '<');
        }

        private static string EscapeString(string src)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();

            int start = 0;
            for (int i = 0; i < src.Length; i++)
                if (NeedEscape(src, i))
                {
                    sb.Append(src, start, i - start);
                    switch (src[i])
                    {
                        case '\b': sb.Append("\\b"); break;
                        case '\f': sb.Append("\\f"); break;
                        case '\n': sb.Append("\\n"); break;
                        case '\r': sb.Append("\\r"); break;
                        case '\t': sb.Append("\\t"); break;
                        case '\"': sb.Append("\\\""); break;
                        case '\\': sb.Append("\\\\"); break;
                        case '/': sb.Append("\\/"); break;
                        default:
                            sb.Append("\\u");
                            sb.Append(((int)src[i]).ToString("x04"));
                            break;
                    }
                    start = i + 1;
                }
            sb.Append(src, start, src.Length - start);
            return sb.ToString();
        }

        public class SelectionValue
        {
            public int l { get; set; }

            public string v { get; set; }
        }


        public static string UpdateNewText(string currentText, string newValue, int languageIndex)
        {
            if (!string.IsNullOrEmpty(currentText) && (currentText.StartsWith("[") && currentText.EndsWith("]")))
            {
                var optionTexts = JsonConvert.DeserializeObject<List<SelectionValue>>(currentText);

                var selLanguageOption = optionTexts.Find(a => a.l == languageIndex);
                if (selLanguageOption != null)
                {
                    selLanguageOption.v = newValue;
                }
                else
                {
                    selLanguageOption = new SelectionValue() { l = languageIndex, v = newValue };
                    optionTexts.Add(selLanguageOption);
                }
                currentText = JsonConvert.SerializeObject(optionTexts);
            }
            else
            {
                var selLanguageOption = new List<SelectionValue>() { new SelectionValue() { l = languageIndex, v = newValue } };
                currentText = JsonConvert.SerializeObject(selLanguageOption);
            }
            return currentText;
        }
    }
}
