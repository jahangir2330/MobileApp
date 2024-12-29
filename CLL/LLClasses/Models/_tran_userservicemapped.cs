using System;
using System.Globalization;
using System.IO;
using CLL.Abstract;

namespace CLL.LLClasses.Models
{
    
    public  class _tran_userservicemapped : _Common
    {
         private static IResourceProvider resourceProvider_tran_userservicemapped = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"LanguagesFiles/_tran_userservicemapped.xml"));//DbResourceProvider(); //  
         
         
        public static string userservicemappedList
        {
            get
            {
                return resourceProvider_tran_userservicemapped.GetResource("userservicemappedList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string userservicemappedCreate
        {
            get
            {
                return resourceProvider_tran_userservicemapped.GetResource("userservicemappedCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string userservicemappedUpdate
        {
            get
            {
                return resourceProvider_tran_userservicemapped.GetResource("userservicemappedUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string userservicemappedDetails
        {
            get
            {
                return resourceProvider_tran_userservicemapped.GetResource("userservicemappedDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string roleid
        {
            get
            {
                return resourceProvider_tran_userservicemapped.GetResource("roleid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string userid
        {
            get
            {
                return resourceProvider_tran_userservicemapped.GetResource("userid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string serviceid
        {
            get
            {
                return resourceProvider_tran_userservicemapped.GetResource("serviceid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string serviceidRequired
        {
            get
            {
                return resourceProvider_tran_userservicemapped.GetResource("serviceidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string isactive
        {
            get
            {
                return resourceProvider_tran_userservicemapped.GetResource("isactive", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        
      
    }
}
