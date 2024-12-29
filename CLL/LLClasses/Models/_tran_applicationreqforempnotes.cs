using System;
using System.Globalization;
using System.IO;
using CLL.Abstract;

namespace CLL.LLClasses.Models
{
    
    public  class _tran_applicationreqforempnotes : _Common
    {
         private static IResourceProvider resourceProvider_tran_applicationreqforempnotes = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"LanguagesFiles/_tran_applicationreqforempnotes.xml"));//DbResourceProvider(); //  
         
         
        public static string requestapplicationnoteList
        {
            get
            {
                return resourceProvider_tran_applicationreqforempnotes.GetResource("requestapplicationnoteList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string requestapplicationnoteCreate
        {
            get
            {
                return resourceProvider_tran_applicationreqforempnotes.GetResource("requestapplicationnoteCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string requestapplicationnoteUpdate
        {
            get
            {
                return resourceProvider_tran_applicationreqforempnotes.GetResource("requestapplicationnoteUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string requestapplicationnoteDetails
        {
            get
            {
                return resourceProvider_tran_applicationreqforempnotes.GetResource("requestapplicationnoteDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string requestapplicationid
        {
            get
            {
                return resourceProvider_tran_applicationreqforempnotes.GetResource("requestapplicationid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string statusid
        {
            get
            {
                return resourceProvider_tran_applicationreqforempnotes.GetResource("statusid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string notetext
        {
            get
            {
                return resourceProvider_tran_applicationreqforempnotes.GetResource("notetext", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string submittedtime
        {
            get
            {
                return resourceProvider_tran_applicationreqforempnotes.GetResource("submittedtime", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string masteruserid
        {
            get
            {
                return resourceProvider_tran_applicationreqforempnotes.GetResource("masteruserid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string updateinfo
        {
            get
            {
                return resourceProvider_tran_applicationreqforempnotes.GetResource("updateinfo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string tranformactionid
        {
            get
            {
                return resourceProvider_tran_applicationreqforempnotes.GetResource("tranformactionid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        
      
    }
}
