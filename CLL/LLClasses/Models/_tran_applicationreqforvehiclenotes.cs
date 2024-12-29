using System;
using System.Globalization;
using System.IO;
using CLL.Abstract;

namespace CLL.LLClasses.Models
{
    
    public  class _tran_applicationreqforvehiclenotes : _Common
    {
         private static IResourceProvider resourceProvider_tran_applicationreqforvehiclenotes = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"LanguagesFiles/_tran_applicationreqforvehiclenotes.xml"));//DbResourceProvider(); //  
         
         
        public static string requestvehiclenoteList
        {
            get
            {
                return resourceProvider_tran_applicationreqforvehiclenotes.GetResource("requestvehiclenoteList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string requestvehiclenoteCreate
        {
            get
            {
                return resourceProvider_tran_applicationreqforvehiclenotes.GetResource("requestvehiclenoteCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string requestvehiclenoteUpdate
        {
            get
            {
                return resourceProvider_tran_applicationreqforvehiclenotes.GetResource("requestvehiclenoteUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string requestvehiclenoteDetails
        {
            get
            {
                return resourceProvider_tran_applicationreqforvehiclenotes.GetResource("requestvehiclenoteDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
        public static string requestvehiclenoteDelete
        {
            get
            {
                return resourceProvider_tran_applicationreqforvehiclenotes.GetResource("requestvehiclenoteDelete", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string requestvehicleid
        {
            get
            {
                return resourceProvider_tran_applicationreqforvehiclenotes.GetResource("requestvehicleid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string statusid
        {
            get
            {
                return resourceProvider_tran_applicationreqforvehiclenotes.GetResource("statusid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string notetext
        {
            get
            {
                return resourceProvider_tran_applicationreqforvehiclenotes.GetResource("notetext", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string submittedtime
        {
            get
            {
                return resourceProvider_tran_applicationreqforvehiclenotes.GetResource("submittedtime", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string masteruserid
        {
            get
            {
                return resourceProvider_tran_applicationreqforvehiclenotes.GetResource("masteruserid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string tranformactionid
        {
            get
            {
                return resourceProvider_tran_applicationreqforvehiclenotes.GetResource("tranformactionid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string updateinfo
        {
            get
            {
                return resourceProvider_tran_applicationreqforvehiclenotes.GetResource("updateinfo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        
      
    }
}
