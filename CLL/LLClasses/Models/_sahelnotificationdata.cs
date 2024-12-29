using System;
using System.Globalization;
using System.IO;
using CLL.Abstract;

namespace CLL.LLClasses.Models
{
    
    public  class _sahelnotificationdata : _Common
    {
         private static IResourceProvider resourceProvider_sahelnotificationdata = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"LanguagesFiles/_sahelnotificationdata.xml"));//DbResourceProvider(); //  
         
         
        public static string sahelnotificationdataList
        {
            get
            {
                return resourceProvider_sahelnotificationdata.GetResource("sahelnotificationdataList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string sahelnotificationdataCreate
        {
            get
            {
                return resourceProvider_sahelnotificationdata.GetResource("sahelnotificationdataCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string sahelnotificationdataUpdate
        {
            get
            {
                return resourceProvider_sahelnotificationdata.GetResource("sahelnotificationdataUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string sahelnotificationdataDetails
        {
            get
            {
                return resourceProvider_sahelnotificationdata.GetResource("sahelnotificationdataDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string notificationrequestjson
        {
            get
            {
                return resourceProvider_sahelnotificationdata.GetResource("notificationrequestjson", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string notificationrequestjsonRequired
        {
            get
            {
                return resourceProvider_sahelnotificationdata.GetResource("notificationrequestjsonRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string notificationresponsejson
        {
            get
            {
                return resourceProvider_sahelnotificationdata.GetResource("notificationresponsejson", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string notificationresponsejsonRequired
        {
            get
            {
                return resourceProvider_sahelnotificationdata.GetResource("notificationresponsejsonRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string applicantcivilid
        {
            get
            {
                return resourceProvider_sahelnotificationdata.GetResource("applicantcivilid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string issuccess
        {
            get
            {
                return resourceProvider_sahelnotificationdata.GetResource("issuccess", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string sentdatetime
        {
            get
            {
                return resourceProvider_sahelnotificationdata.GetResource("sentdatetime", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string sentdatetimeRequired
        {
            get
            {
                return resourceProvider_sahelnotificationdata.GetResource("sentdatetimeRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string referenceapptag
        {
            get
            {
                return resourceProvider_sahelnotificationdata.GetResource("referenceapptag", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string referenceapptagRequired
        {
            get
            {
                return resourceProvider_sahelnotificationdata.GetResource("referenceapptagRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string referenceid
        {
            get
            {
                return resourceProvider_sahelnotificationdata.GetResource("referenceid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        
      
    }
}
