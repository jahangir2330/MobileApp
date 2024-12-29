using System;
using System.Globalization;
using System.IO;
using CLL.Abstract;

namespace CLL.LLClasses.Models
{
    
    public  class _tran_applicationreqforempactivitylog : _Common
    {
         private static IResourceProvider resourceProvider_tran_applicationreqforempactivitylog = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"LanguagesFiles/_tran_applicationreqforempactivitylog.xml"));//DbResourceProvider(); //  
         
         
        public static string requestapplicationactivitylogList
        {
            get
            {
                return resourceProvider_tran_applicationreqforempactivitylog.GetResource("requestapplicationactivitylogList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string requestapplicationactivitylogCreate
        {
            get
            {
                return resourceProvider_tran_applicationreqforempactivitylog.GetResource("requestapplicationactivitylogCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string requestapplicationactivitylogUpdate
        {
            get
            {
                return resourceProvider_tran_applicationreqforempactivitylog.GetResource("requestapplicationactivitylogUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string requestapplicationactivitylogDetails
        {
            get
            {
                return resourceProvider_tran_applicationreqforempactivitylog.GetResource("requestapplicationactivitylogDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string requestapplicationid
        {
            get
            {
                return resourceProvider_tran_applicationreqforempactivitylog.GetResource("requestapplicationid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string statusid
        {
            get
            {
                return resourceProvider_tran_applicationreqforempactivitylog.GetResource("statusid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string activitylogtext
        {
            get
            {
                return resourceProvider_tran_applicationreqforempactivitylog.GetResource("activitylogtext", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string logtime
        {
            get
            {
                return resourceProvider_tran_applicationreqforempactivitylog.GetResource("logtime", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string masteruserid
        {
            get
            {
                return resourceProvider_tran_applicationreqforempactivitylog.GetResource("masteruserid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string updateinfo
        {
            get
            {
                return resourceProvider_tran_applicationreqforempactivitylog.GetResource("updateinfo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string tranformactionid
        {
            get
            {
                return resourceProvider_tran_applicationreqforempactivitylog.GetResource("tranformactionid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        
      
    }
}
