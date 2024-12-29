using System;
using System.Globalization;
using System.IO;
using CLL.Abstract;

namespace CLL.LLClasses.Models
{
    
    public  class _tran_applicationreqforvehicleactivitylog : _Common
    {
         private static IResourceProvider resourceProvider_tran_applicationreqforvehicleactivitylog = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"LanguagesFiles/_tran_applicationreqforvehicleactivitylog.xml"));//DbResourceProvider(); //  
         
         
        public static string requestvehicleactivitylogList
        {
            get
            {
                return resourceProvider_tran_applicationreqforvehicleactivitylog.GetResource("requestvehicleactivitylogList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string requestvehicleactivitylogCreate
        {
            get
            {
                return resourceProvider_tran_applicationreqforvehicleactivitylog.GetResource("requestvehicleactivitylogCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string requestvehicleactivitylogUpdate
        {
            get
            {
                return resourceProvider_tran_applicationreqforvehicleactivitylog.GetResource("requestvehicleactivitylogUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string requestvehicleactivitylogDetails
        {
            get
            {
                return resourceProvider_tran_applicationreqforvehicleactivitylog.GetResource("requestvehicleactivitylogDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
        public static string requestvehicleactivitylogDelete
        {
            get
            {
                return resourceProvider_tran_applicationreqforvehicleactivitylog.GetResource("requestvehicleactivitylogDelete", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string requestvehicleid
        {
            get
            {
                return resourceProvider_tran_applicationreqforvehicleactivitylog.GetResource("requestvehicleid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string statusid
        {
            get
            {
                return resourceProvider_tran_applicationreqforvehicleactivitylog.GetResource("statusid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string activitylogtext
        {
            get
            {
                return resourceProvider_tran_applicationreqforvehicleactivitylog.GetResource("activitylogtext", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string logtime
        {
            get
            {
                return resourceProvider_tran_applicationreqforvehicleactivitylog.GetResource("logtime", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string masteruserid
        {
            get
            {
                return resourceProvider_tran_applicationreqforvehicleactivitylog.GetResource("masteruserid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string tranformactionid
        {
            get
            {
                return resourceProvider_tran_applicationreqforvehicleactivitylog.GetResource("tranformactionid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string updateinfo
        {
            get
            {
                return resourceProvider_tran_applicationreqforvehicleactivitylog.GetResource("updateinfo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        
      
    }
}
