using System;
using System.Globalization;
using System.IO;
using CLL.Abstract;

namespace CLL.LLClasses.Models
{
    
    public  class _tran_applicationreqforempfile : _Common
    {
         private static IResourceProvider resourceProvider_tran_applicationreqforempfile = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"LanguagesFiles/_tran_applicationreqforempfile.xml"));//DbResourceProvider(); //  
         
         
        public static string requestfileList
        {
            get
            {
                return resourceProvider_tran_applicationreqforempfile.GetResource("requestfileList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string requestfileCreate
        {
            get
            {
                return resourceProvider_tran_applicationreqforempfile.GetResource("requestfileCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string requestfileUpdate
        {
            get
            {
                return resourceProvider_tran_applicationreqforempfile.GetResource("requestfileUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string requestfileDetails
        {
            get
            {
                return resourceProvider_tran_applicationreqforempfile.GetResource("requestfileDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string requestapplicationid
        {
            get
            {
                return resourceProvider_tran_applicationreqforempfile.GetResource("requestapplicationid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string requestapplicationidRequired
        {
            get
            {
                return resourceProvider_tran_applicationreqforempfile.GetResource("requestapplicationidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string requestfiletypeid
        {
            get
            {
                return resourceProvider_tran_applicationreqforempfile.GetResource("requestfiletypeid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string requestfiletypeidRequired
        {
            get
            {
                return resourceProvider_tran_applicationreqforempfile.GetResource("requestfiletypeidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string requestfilepath
        {
            get
            {
                return resourceProvider_tran_applicationreqforempfile.GetResource("requestfilepath", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string isactive
        {
            get
            {
                return resourceProvider_tran_applicationreqforempfile.GetResource("isactive", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string fileformattype
        {
            get
            {
                return resourceProvider_tran_applicationreqforempfile.GetResource("fileformattype", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string fileextension
        {
            get
            {
                return resourceProvider_tran_applicationreqforempfile.GetResource("fileextension", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string actualfilename
        {
            get
            {
                return resourceProvider_tran_applicationreqforempfile.GetResource("actualfilename", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string remarks
        {
            get
            {
                return resourceProvider_tran_applicationreqforempfile.GetResource("remarks", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string updateinfo
        {
            get
            {
                return resourceProvider_tran_applicationreqforempfile.GetResource("updateinfo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string tranformactionid
        {
            get
            {
                return resourceProvider_tran_applicationreqforempfile.GetResource("tranformactionid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        
      
    }
}
