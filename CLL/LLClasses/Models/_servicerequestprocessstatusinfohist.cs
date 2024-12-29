using System;
using System.Globalization;
using System.IO;
using CLL.Abstract;

namespace CLL.LLClasses.Models
{
    
    public  class _servicerequestprocessstatusinfohist : _Common
    {
         private static IResourceProvider resourceProvider_servicerequestprocessstatusinfohist = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"LanguagesFiles/_servicerequestprocessstatusinfohist.xml"));//DbResourceProvider(); //  
         
         
        public static string servicerequestprocessstatusinfohistList
        {
            get
            {
                return resourceProvider_servicerequestprocessstatusinfohist.GetResource("servicerequestprocessstatusinfohistList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string servicerequestprocessstatusinfohistCreate
        {
            get
            {
                return resourceProvider_servicerequestprocessstatusinfohist.GetResource("servicerequestprocessstatusinfohistCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string servicerequestprocessstatusinfohistUpdate
        {
            get
            {
                return resourceProvider_servicerequestprocessstatusinfohist.GetResource("servicerequestprocessstatusinfohistUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string servicerequestprocessstatusinfohistDetails
        {
            get
            {
                return resourceProvider_servicerequestprocessstatusinfohist.GetResource("servicerequestprocessstatusinfohistDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string servicerequestid
        {
            get
            {
                return resourceProvider_servicerequestprocessstatusinfohist.GetResource("servicerequestid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string servicerequestidRequired
        {
            get
            {
                return resourceProvider_servicerequestprocessstatusinfohist.GetResource("servicerequestidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string serviceid
        {
            get
            {
                return resourceProvider_servicerequestprocessstatusinfohist.GetResource("serviceid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string requestdate
        {
            get
            {
                return resourceProvider_servicerequestprocessstatusinfohist.GetResource("requestdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string requestdateRequired
        {
            get
            {
                return resourceProvider_servicerequestprocessstatusinfohist.GetResource("requestdateRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string applicantcivilid
        {
            get
            {
                return resourceProvider_servicerequestprocessstatusinfohist.GetResource("applicantcivilid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string applicantcivilidRequired
        {
            get
            {
                return resourceProvider_servicerequestprocessstatusinfohist.GetResource("applicantcivilidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string applicantnote
        {
            get
            {
                return resourceProvider_servicerequestprocessstatusinfohist.GetResource("applicantnote", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string servicestatusid
        {
            get
            {
                return resourceProvider_servicerequestprocessstatusinfohist.GetResource("servicestatusid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string servicestatusidRequired
        {
            get
            {
                return resourceProvider_servicerequestprocessstatusinfohist.GetResource("servicestatusidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string servicestatuschangenote
        {
            get
            {
                return resourceProvider_servicerequestprocessstatusinfohist.GetResource("servicestatuschangenote", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string servicestatuschangedby
        {
            get
            {
                return resourceProvider_servicerequestprocessstatusinfohist.GetResource("servicestatuschangedby", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string servicestatuschangeddate
        {
            get
            {
                return resourceProvider_servicerequestprocessstatusinfohist.GetResource("servicestatuschangeddate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string applicantrequestjson
        {
            get
            {
                return resourceProvider_servicerequestprocessstatusinfohist.GetResource("applicantrequestjson", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string notificationrequestjson
        {
            get
            {
                return resourceProvider_servicerequestprocessstatusinfohist.GetResource("notificationrequestjson", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string notificationresponsejson
        {
            get
            {
                return resourceProvider_servicerequestprocessstatusinfohist.GetResource("notificationresponsejson", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        
      
    }
}
