using System;
using System.Globalization;
using System.IO;
using CLL.Abstract;

namespace CLL.LLClasses.Models
{

    public class _gen_representative : _Common
    {
        private static IResourceProvider resourceProvider_gen_representative = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"LanguagesFiles/_gen_representative.xml"));//DbResourceProvider(); //  


        public static string representativeList
        {
            get
            {
                return resourceProvider_gen_representative.GetResource("representativeList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string representativeCreate
        {
            get
            {
                return resourceProvider_gen_representative.GetResource("representativeCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string representativeUpdate
        {
            get
            {
                return resourceProvider_gen_representative.GetResource("representativeUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string representativeDetails
        {
            get
            {
                return resourceProvider_gen_representative.GetResource("representativeDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


        public static string representativename
        {
            get
            {
                return resourceProvider_gen_representative.GetResource("representativename", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string representativenamear
        {
            get
            {
                return resourceProvider_gen_representative.GetResource("representativenamear", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string companyid
        {
            get
            {
                return resourceProvider_gen_representative.GetResource("companyid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string companyidRequired
        {
            get
            {
                return resourceProvider_gen_representative.GetResource("companyidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string nationalityid
        {
            get
            {
                return resourceProvider_gen_representative.GetResource("nationalityid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string nationalityidRequired
        {
            get
            {
                return resourceProvider_gen_representative.GetResource("nationalityidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string civilidRequired
		{
            get
            {
                return resourceProvider_gen_representative.GetResource("civilidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string designations
        {
            get
            {
                return resourceProvider_gen_representative.GetResource("designations", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string civilid
        {
            get
            {
                return resourceProvider_gen_representative.GetResource("civilid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string mobileno
        {
            get
            {
                return resourceProvider_gen_representative.GetResource("mobileno", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string mobilenoRequired
        {
            get
            {
                return resourceProvider_gen_representative.GetResource("mobilenoRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string mobilenotypeid
        {
            get
            {
                return resourceProvider_gen_representative.GetResource("mobilenotypeid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string mobilenotypeidRequired
        {
            get
            {
                return resourceProvider_gen_representative.GetResource("mobilenotypeidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string emailaddress
        {
            get
            {
                return resourceProvider_gen_representative.GetResource("emailaddress", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string representativeaddress
        {
            get
            {
                return resourceProvider_gen_representative.GetResource("representativeaddress", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string isactive
        {
            get
            {
                return resourceProvider_gen_representative.GetResource("isactive", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string remarks
        {
            get
            {
                return resourceProvider_gen_representative.GetResource("remarks", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string updateinfo
        {
            get
            {
                return resourceProvider_gen_representative.GetResource("updateinfo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string tranformactionid
        {
            get
            {
                return resourceProvider_gen_representative.GetResource("tranformactionid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


    }
}
