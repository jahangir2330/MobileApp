using System;
using System.Globalization;
using System.IO;
using CLL.Abstract;

namespace CLL.LLClasses.Models
{
    
    public  class _servicerequestprocessstatusinfo : _Common
    {
         private static IResourceProvider resourceProvider_servicerequestprocessstatusinfo = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"LanguagesFiles/_servicerequestprocessstatusinfo.xml"));//DbResourceProvider(); //  
         
         
        public static string servicerequestprocessstatusinfoList
        {
            get
            {
                return resourceProvider_servicerequestprocessstatusinfo.GetResource("servicerequestprocessstatusinfoList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string servicerequestprocessstatusinfoCreate
        {
            get
            {
                return resourceProvider_servicerequestprocessstatusinfo.GetResource("servicerequestprocessstatusinfoCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string servicerequestprocessstatusinfoUpdate
        {
            get
            {
                return resourceProvider_servicerequestprocessstatusinfo.GetResource("servicerequestprocessstatusinfoUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string servicerequestprocessstatusinfoDetails
        {
            get
            {
                return resourceProvider_servicerequestprocessstatusinfo.GetResource("servicerequestprocessstatusinfoDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string serviceid
        {
            get
            {
                return resourceProvider_servicerequestprocessstatusinfo.GetResource("serviceid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string requestdate
        {
            get
            {
                return resourceProvider_servicerequestprocessstatusinfo.GetResource("requestdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string requestdateRequired
        {
            get
            {
                return resourceProvider_servicerequestprocessstatusinfo.GetResource("requestdateRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string applicantcivilid
        {
            get
            {
                return resourceProvider_servicerequestprocessstatusinfo.GetResource("applicantcivilid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string applicantcivilidRequired
        {
            get
            {
                return resourceProvider_servicerequestprocessstatusinfo.GetResource("applicantcivilidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string applicantnote
        {
            get
            {
                return resourceProvider_servicerequestprocessstatusinfo.GetResource("applicantnote", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string servicestatusid
        {
            get
            {
                return resourceProvider_servicerequestprocessstatusinfo.GetResource("servicestatusid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string servicestatusidRequired
        {
            get
            {
                return resourceProvider_servicerequestprocessstatusinfo.GetResource("servicestatusidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string servicestatuschangenote
        {
            get
            {
                return resourceProvider_servicerequestprocessstatusinfo.GetResource("servicestatuschangenote", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string servicestatuschangedby
        {
            get
            {
                return resourceProvider_servicerequestprocessstatusinfo.GetResource("servicestatuschangedby", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string servicestatuschangeddate
        {
            get
            {
                return resourceProvider_servicerequestprocessstatusinfo.GetResource("servicestatuschangeddate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string applicantrequestjson
        {
            get
            {
                return resourceProvider_servicerequestprocessstatusinfo.GetResource("applicantrequestjson", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string notificationrequestjson
        {
            get
            {
                return resourceProvider_servicerequestprocessstatusinfo.GetResource("notificationrequestjson", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string notificationresponsejson
        {
            get
            {
                return resourceProvider_servicerequestprocessstatusinfo.GetResource("notificationresponsejson", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        
      
    }
}
