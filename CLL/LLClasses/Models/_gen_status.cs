using System;
using System.Globalization;
using System.IO;
using CLL.Abstract;

namespace CLL.LLClasses.Models
{

    public class _gen_status : _Common
    {
        private static IResourceProvider resourceProvider_gen_status = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"LanguagesFiles/_gen_status.xml"));//DbResourceProvider(); //  


        public static string statusList
        {
            get
            {
                return resourceProvider_gen_status.GetResource("statusList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string statusCreate
        {
            get
            {
                return resourceProvider_gen_status.GetResource("statusCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string statusUpdate
        {
            get
            {
                return resourceProvider_gen_status.GetResource("statusUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string statusDetails
        {
            get
            {
                return resourceProvider_gen_status.GetResource("statusDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


        public static string statusname
        {
            get
            {
                return resourceProvider_gen_status.GetResource("statusname", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string statusnamear
        {
            get
            {
                return resourceProvider_gen_status.GetResource("statusnamear", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string imagepath
        {
            get
            {
                return resourceProvider_gen_status.GetResource("imagepath", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string iconname
        {
            get
            {
                return resourceProvider_gen_status.GetResource("iconname", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string cssclass
        {
            get
            {
                return resourceProvider_gen_status.GetResource("cssclass", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string sortpriority
        {
            get
            {
                return resourceProvider_gen_status.GetResource("sortpriority", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string isactive
        {
            get
            {
                return resourceProvider_gen_status.GetResource("isactive", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string remarks
        {
            get
            {
                return resourceProvider_gen_status.GetResource("remarks", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string updateinfo
        {
            get
            {
                return resourceProvider_gen_status.GetResource("updateinfo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string tranformactionid
        {
            get
            {
                return resourceProvider_gen_status.GetResource("tranformactionid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


    }
}
