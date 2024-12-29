using System;
using System.Globalization;
using System.IO;
using CLL.Abstract;

namespace CLL.LLClasses.Models
{
    
    public  class _oc_familymembersinfo : _Common
    {
         private static IResourceProvider resourceProvider_oc_familymembersinfo = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"LanguagesFiles/_oc_familymembersinfo.xml"));//DbResourceProvider(); //  
         
         
        public static string familymembersinfoList
        {
            get
            {
                return resourceProvider_oc_familymembersinfo.GetResource("familymembersinfoList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string familymembersinfoCreate
        {
            get
            {
                return resourceProvider_oc_familymembersinfo.GetResource("familymembersinfoCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string familymembersinfoUpdate
        {
            get
            {
                return resourceProvider_oc_familymembersinfo.GetResource("familymembersinfoUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string familymembersinfoDetails
        {
            get
            {
                return resourceProvider_oc_familymembersinfo.GetResource("familymembersinfoDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string ocfileid
        {
            get
            {
                return resourceProvider_oc_familymembersinfo.GetResource("ocfileid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string ocfileidRequired
        {
            get
            {
                return resourceProvider_oc_familymembersinfo.GetResource("ocfileidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string familymembercivilid
        {
            get
            {
                return resourceProvider_oc_familymembersinfo.GetResource("familymembercivilid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string familymemberpacijsondata
        {
            get
            {
                return resourceProvider_oc_familymembersinfo.GetResource("familymemberpacijsondata", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string hrfamilyid
        {
            get
            {
                return resourceProvider_oc_familymembersinfo.GetResource("hrfamilyid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string hrfamilyidRequired
        {
            get
            {
                return resourceProvider_oc_familymembersinfo.GetResource("hrfamilyidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string relationshipid
        {
            get
            {
                return resourceProvider_oc_familymembersinfo.GetResource("relationshipid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string relationshipidRequired
        {
            get
            {
                return resourceProvider_oc_familymembersinfo.GetResource("relationshipidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string hasmembership
        {
            get
            {
                return resourceProvider_oc_familymembersinfo.GetResource("hasmembership", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string isactive
        {
            get
            {
                return resourceProvider_oc_familymembersinfo.GetResource("isactive", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string issynced
        {
            get
            {
                return resourceProvider_oc_familymembersinfo.GetResource("issynced", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string lastsyncdate
        {
            get
            {
                return resourceProvider_oc_familymembersinfo.GetResource("lastsyncdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        
      
    }
}
