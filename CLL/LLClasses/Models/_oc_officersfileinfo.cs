using System;
using System.Globalization;
using System.IO;
using CLL.Abstract;

namespace CLL.LLClasses.Models
{
    
    public  class _oc_officersfileinfo : _Common
    {
         private static IResourceProvider resourceProvider_oc_officersfileinfo = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"LanguagesFiles/_oc_officersfileinfo.xml"));//DbResourceProvider(); //  
         
         
        public static string officersfileinfoList
        {
            get
            {
                return resourceProvider_oc_officersfileinfo.GetResource("officersfileinfoList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string officersfileinfoCreate
        {
            get
            {
                return resourceProvider_oc_officersfileinfo.GetResource("officersfileinfoCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string officersfileinfoUpdate
        {
            get
            {
                return resourceProvider_oc_officersfileinfo.GetResource("officersfileinfoUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string officersfileinfoDetails
        {
            get
            {
                return resourceProvider_oc_officersfileinfo.GetResource("officersfileinfoDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string occivilid
        {
            get
            {
                return resourceProvider_oc_officersfileinfo.GetResource("occivilid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string occivilidRequired
        {
            get
            {
                return resourceProvider_oc_officersfileinfo.GetResource("occivilidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string ocmilitaryid
        {
            get
            {
                return resourceProvider_oc_officersfileinfo.GetResource("ocmilitaryid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string ocmilitaryidRequired
        {
            get
            {
                return resourceProvider_oc_officersfileinfo.GetResource("ocmilitaryidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string hrbasicid
        {
            get
            {
                return resourceProvider_oc_officersfileinfo.GetResource("hrbasicid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string hrbasicidRequired
        {
            get
            {
                return resourceProvider_oc_officersfileinfo.GetResource("hrbasicidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string ocemailaddress
        {
            get
            {
                return resourceProvider_oc_officersfileinfo.GetResource("ocemailaddress", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string ocemailaddressRequired
        {
            get
            {
                return resourceProvider_oc_officersfileinfo.GetResource("ocemailaddressRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string ocphonenumber
        {
            get
            {
                return resourceProvider_oc_officersfileinfo.GetResource("ocphonenumber", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string ocphonenumberRequired
        {
            get
            {
                return resourceProvider_oc_officersfileinfo.GetResource("ocphonenumberRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string officerpacijsondata
        {
            get
            {
                return resourceProvider_oc_officersfileinfo.GetResource("officerpacijsondata", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string filecreationdate
        {
            get
            {
                return resourceProvider_oc_officersfileinfo.GetResource("filecreationdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string fileisactive
        {
            get
            {
                return resourceProvider_oc_officersfileinfo.GetResource("fileisactive", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string hrdatajsondata
        {
            get
            {
                return resourceProvider_oc_officersfileinfo.GetResource("hrdatajsondata", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string issynced
        {
            get
            {
                return resourceProvider_oc_officersfileinfo.GetResource("issynced", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string lastpacisynceddate
        {
            get
            {
                return resourceProvider_oc_officersfileinfo.GetResource("lastpacisynceddate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string memberisregistered
        {
            get
            {
                return resourceProvider_oc_officersfileinfo.GetResource("memberisregistered", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        
      
    }
}
