using System;
using System.Globalization;
using System.IO;
using CLL.Abstract;

namespace CLL.LLClasses.Models
{
    
    public  class _sahelservicerequestinfo : _Common
    {
         private static IResourceProvider resourceProvider_sahelservicerequestinfo = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"LanguagesFiles/_sahelservicerequestinfo.xml"));//DbResourceProvider(); //  
         
         
        public static string sahelservicerequestinfoList
        {
            get
            {
                return resourceProvider_sahelservicerequestinfo.GetResource("sahelservicerequestinfoList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string sahelservicerequestinfoCreate
        {
            get
            {
                return resourceProvider_sahelservicerequestinfo.GetResource("sahelservicerequestinfoCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string sahelservicerequestinfoUpdate
        {
            get
            {
                return resourceProvider_sahelservicerequestinfo.GetResource("sahelservicerequestinfoUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string sahelservicerequestinfoDetails
        {
            get
            {
                return resourceProvider_sahelservicerequestinfo.GetResource("sahelservicerequestinfoDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string servicename
        {
            get
            {
                return resourceProvider_sahelservicerequestinfo.GetResource("servicename", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string servicenameRequired
        {
            get
            {
                return resourceProvider_sahelservicerequestinfo.GetResource("servicenameRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string serviceurl
        {
            get
            {
                return resourceProvider_sahelservicerequestinfo.GetResource("serviceurl", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string serviceurlRequired
        {
            get
            {
                return resourceProvider_sahelservicerequestinfo.GetResource("serviceurlRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string fromcivilid
        {
            get
            {
                return resourceProvider_sahelservicerequestinfo.GetResource("fromcivilid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string fromcivilidRequired
        {
            get
            {
                return resourceProvider_sahelservicerequestinfo.GetResource("fromcivilidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string requestdate
        {
            get
            {
                return resourceProvider_sahelservicerequestinfo.GetResource("requestdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string requestdateRequired
        {
            get
            {
                return resourceProvider_sahelservicerequestinfo.GetResource("requestdateRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string requestjson
        {
            get
            {
                return resourceProvider_sahelservicerequestinfo.GetResource("requestjson", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string requestjsonRequired
        {
            get
            {
                return resourceProvider_sahelservicerequestinfo.GetResource("requestjsonRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        
      
    }
}
