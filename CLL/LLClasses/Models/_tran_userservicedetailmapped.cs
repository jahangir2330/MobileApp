using System;
using System.Globalization;
using System.IO;
using CLL.Abstract;

namespace CLL.LLClasses.Models
{
    
    public  class _tran_userservicedetailmapped : _Common
    {
         private static IResourceProvider resourceProvider_tran_userservicedetailmapped = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"LanguagesFiles/_tran_userservicedetailmapped.xml"));//DbResourceProvider(); //  
         
         
        public static string userservicedetailmappedList
        {
            get
            {
                return resourceProvider_tran_userservicedetailmapped.GetResource("userservicedetailmappedList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string userservicedetailmappedCreate
        {
            get
            {
                return resourceProvider_tran_userservicedetailmapped.GetResource("userservicedetailmappedCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string userservicedetailmappedUpdate
        {
            get
            {
                return resourceProvider_tran_userservicedetailmapped.GetResource("userservicedetailmappedUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string userservicedetailmappedDetails
        {
            get
            {
                return resourceProvider_tran_userservicedetailmapped.GetResource("userservicedetailmappedDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string servicedetailusermappedid
        {
            get
            {
                return resourceProvider_tran_userservicedetailmapped.GetResource("servicedetailusermappedid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string servicedetailusermappedidRequired
        {
            get
            {
                return resourceProvider_tran_userservicedetailmapped.GetResource("servicedetailusermappedidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string roleid
        {
            get
            {
                return resourceProvider_tran_userservicedetailmapped.GetResource("roleid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string roleidRequired
        {
            get
            {
                return resourceProvider_tran_userservicedetailmapped.GetResource("roleidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string userid
        {
            get
            {
                return resourceProvider_tran_userservicedetailmapped.GetResource("userid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string serviceid
        {
            get
            {
                return resourceProvider_tran_userservicedetailmapped.GetResource("serviceid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string serviceidRequired
        {
            get
            {
                return resourceProvider_tran_userservicedetailmapped.GetResource("serviceidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string servicedetailid
        {
            get
            {
                return resourceProvider_tran_userservicedetailmapped.GetResource("servicedetailid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string servicedetailidRequired
        {
            get
            {
                return resourceProvider_tran_userservicedetailmapped.GetResource("servicedetailidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string isactive
        {
            get
            {
                return resourceProvider_tran_userservicedetailmapped.GetResource("isactive", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        
      
    }
}
