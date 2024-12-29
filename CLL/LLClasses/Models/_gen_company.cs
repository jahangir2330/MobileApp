using System;
using System.Globalization;
using System.IO;
using CLL.Abstract;

namespace CLL.LLClasses.Models
{

    public class _gen_company : _Common
    {
        private static IResourceProvider resourceProvider_gen_company = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"LanguagesFiles/_gen_company.xml"));//DbResourceProvider(); //  


        public static string companyList
        {
            get
            {
                return resourceProvider_gen_company.GetResource("companyList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string companyCreate
        {
            get
            {
                return resourceProvider_gen_company.GetResource("companyCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string companyUpdate
        {
            get
            {
                return resourceProvider_gen_company.GetResource("companyUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string companyDetails
        {
            get
            {
                return resourceProvider_gen_company.GetResource("companyDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


        public static string companyname
        {
            get
            {
                return resourceProvider_gen_company.GetResource("companyname", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
       
        public static string companynameRequired
        {
            get
            {
                return resourceProvider_gen_company.GetResource("companynameRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string companymobilenoRequired
        {
            get
            {
                return resourceProvider_gen_company.GetResource("companymobilenoRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string companynamear
        {
            get
            {
                return resourceProvider_gen_company.GetResource("companynamear", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string companynamearRequired
        {
            get
            {
                return resourceProvider_gen_company.GetResource("companynamearRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string companytypeid
        {
            get
            {
                return resourceProvider_gen_company.GetResource("companytypeid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string companytypeidRequired
        {
            get
            {
                return resourceProvider_gen_company.GetResource("companytypeidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string companymobileno
        {
            get
            {
                return resourceProvider_gen_company.GetResource("companymobileno", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string companyemailaddress
        {
            get
            {
                return resourceProvider_gen_company.GetResource("companyemailaddress", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string companywebsite
        {
            get
            {
                return resourceProvider_gen_company.GetResource("companywebsite", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string companyaddress
        {
            get
            {
                return resourceProvider_gen_company.GetResource("companyaddress", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string isblockednow
        {
            get
            {
                return resourceProvider_gen_company.GetResource("isblockednow", CultureInfo.CurrentUICulture.Name) as String;
            }
        }  public static string blockstatusstring
        {
            get
            {
                return resourceProvider_gen_company.GetResource("blockstatusstring", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string isactive
        {
            get
            {
                return resourceProvider_gen_company.GetResource("isactive", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string remarks
        {
            get
            {
                return resourceProvider_gen_company.GetResource("remarks", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string updateinfo
        {
            get
            {
                return resourceProvider_gen_company.GetResource("updateinfo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string tranformactionid
        {
            get
            {
                return resourceProvider_gen_company.GetResource("tranformactionid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


    }
}
