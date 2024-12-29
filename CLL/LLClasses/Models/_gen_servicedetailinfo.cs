using System;
using System.Globalization;
using System.IO;
using CLL.Abstract;

namespace CLL.LLClasses.Models
{
    
    public  class _gen_servicedetailinfo : _Common
    {
         private static IResourceProvider resourceProvider_gen_servicedetailinfo = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"LanguagesFiles/_gen_servicedetailinfo.xml"));//DbResourceProvider(); //  
         
         
        public static string servicedetailinfoList
        {
            get
            {
                return resourceProvider_gen_servicedetailinfo.GetResource("servicedetailinfoList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string servicedetailinfoCreate
        {
            get
            {
                return resourceProvider_gen_servicedetailinfo.GetResource("servicedetailinfoCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string servicedetailinfoUpdate
        {
            get
            {
                return resourceProvider_gen_servicedetailinfo.GetResource("servicedetailinfoUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string servicedetailinfoDetails
        {
            get
            {
                return resourceProvider_gen_servicedetailinfo.GetResource("servicedetailinfoDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string serviceid
        {
            get
            {
                return resourceProvider_gen_servicedetailinfo.GetResource("serviceid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string serviceidRequired
        {
            get
            {
                return resourceProvider_gen_servicedetailinfo.GetResource("serviceidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string titleen
        {
            get
            {
                return resourceProvider_gen_servicedetailinfo.GetResource("titleen", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string titleenRequired
        {
            get
            {
                return resourceProvider_gen_servicedetailinfo.GetResource("titleenRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string titlear
        {
            get
            {
                return resourceProvider_gen_servicedetailinfo.GetResource("titlear", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string titlearRequired
        {
            get
            {
                return resourceProvider_gen_servicedetailinfo.GetResource("titlearRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string descriptionen
        {
            get
            {
                return resourceProvider_gen_servicedetailinfo.GetResource("descriptionen", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string descriptionar
        {
            get
            {
                return resourceProvider_gen_servicedetailinfo.GetResource("descriptionar", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string serviceurl
        {
            get
            {
                return resourceProvider_gen_servicedetailinfo.GetResource("serviceurl", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string username
        {
            get
            {
                return resourceProvider_gen_servicedetailinfo.GetResource("username", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string password
        {
            get
            {
                return resourceProvider_gen_servicedetailinfo.GetResource("password", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string intcode
        {
            get
            {
                return resourceProvider_gen_servicedetailinfo.GetResource("intcode", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string isoffline
        {
            get
            {
                return resourceProvider_gen_servicedetailinfo.GetResource("isoffline", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string istested
        {
            get
            {
                return resourceProvider_gen_servicedetailinfo.GetResource("istested", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string testdate
        {
            get
            {
                return resourceProvider_gen_servicedetailinfo.GetResource("testdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string testby
        {
            get
            {
                return resourceProvider_gen_servicedetailinfo.GetResource("testby", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string isactive
        {
            get
            {
                return resourceProvider_gen_servicedetailinfo.GetResource("isactive", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        
      
    }
}
