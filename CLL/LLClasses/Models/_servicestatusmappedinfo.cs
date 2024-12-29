using System;
using System.Globalization;
using System.IO;
using CLL.Abstract;

namespace CLL.LLClasses.Models
{
    
    public  class _servicestatusmappedinfo : _Common
    {
         private static IResourceProvider resourceProvider_servicestatusmappedinfo = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"LanguagesFiles/_servicestatusmappedinfo.xml"));//DbResourceProvider(); //  
         
         
        public static string servicestatusmappedinfoList
        {
            get
            {
                return resourceProvider_servicestatusmappedinfo.GetResource("servicestatusmappedinfoList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string servicestatusmappedinfoCreate
        {
            get
            {
                return resourceProvider_servicestatusmappedinfo.GetResource("servicestatusmappedinfoCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string servicestatusmappedinfoUpdate
        {
            get
            {
                return resourceProvider_servicestatusmappedinfo.GetResource("servicestatusmappedinfoUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string servicestatusmappedinfoDetails
        {
            get
            {
                return resourceProvider_servicestatusmappedinfo.GetResource("servicestatusmappedinfoDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string servicestatusname
        {
            get
            {
                return resourceProvider_servicestatusmappedinfo.GetResource("servicestatusname", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string servicestatusnameRequired
        {
            get
            {
                return resourceProvider_servicestatusmappedinfo.GetResource("servicestatusnameRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string serviceid
        {
            get
            {
                return resourceProvider_servicestatusmappedinfo.GetResource("serviceid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string serviceidRequired
        {
            get
            {
                return resourceProvider_servicestatusmappedinfo.GetResource("serviceidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string servicestatusid
        {
            get
            {
                return resourceProvider_servicestatusmappedinfo.GetResource("servicestatusid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string servicestatusidRequired
        {
            get
            {
                return resourceProvider_servicestatusmappedinfo.GetResource("servicestatusidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string isactive
        {
            get
            {
                return resourceProvider_servicestatusmappedinfo.GetResource("isactive", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        
      
    }
}
