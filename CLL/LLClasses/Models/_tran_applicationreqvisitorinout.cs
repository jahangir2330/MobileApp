using System;
using System.Globalization;
using System.IO;
using CLL.Abstract;

namespace CLL.LLClasses.Models
{
    
    public  class _tran_applicationreqvisitorinout : _Common
    {
         private static IResourceProvider resourceProvider_tran_applicationreqvisitorinout = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"LanguagesFiles/_tran_applicationreqvisitorinout.xml"));//DbResourceProvider(); //  
         
         
        public static string applicationreqvisitorinoutList
        {
            get
            {
                return resourceProvider_tran_applicationreqvisitorinout.GetResource("applicationreqvisitorinoutList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string applicationreqvisitorinoutCreate
        {
            get
            {
                return resourceProvider_tran_applicationreqvisitorinout.GetResource("applicationreqvisitorinoutCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string applicationreqvisitorinoutUpdate
        {
            get
            {
                return resourceProvider_tran_applicationreqvisitorinout.GetResource("applicationreqvisitorinoutUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string applicationreqvisitorinoutDetails
        {
            get
            {
                return resourceProvider_tran_applicationreqvisitorinout.GetResource("applicationreqvisitorinoutDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
        public static string applicationreqvisitorinoutDelete
        {
            get
            {
                return resourceProvider_tran_applicationreqvisitorinout.GetResource("applicationreqvisitorinoutDelete", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string requestvisitorgateinfoid
        {
            get
            {
                return resourceProvider_tran_applicationreqvisitorinout.GetResource("requestvisitorgateinfoid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string intime
        {
            get
            {
                return resourceProvider_tran_applicationreqvisitorinout.GetResource("intime", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string intimeRequired
        {
            get
            {
                return resourceProvider_tran_applicationreqvisitorinout.GetResource("intimeRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string inbyusername
        {
            get
            {
                return resourceProvider_tran_applicationreqvisitorinout.GetResource("inbyusername", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string inbymacaddress
        {
            get
            {
                return resourceProvider_tran_applicationreqvisitorinout.GetResource("inbymacaddress", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string outtime
        {
            get
            {
                return resourceProvider_tran_applicationreqvisitorinout.GetResource("outtime", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string outbyusername
        {
            get
            {
                return resourceProvider_tran_applicationreqvisitorinout.GetResource("outbyusername", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string outbymacaddress
        {
            get
            {
                return resourceProvider_tran_applicationreqvisitorinout.GetResource("outbymacaddress", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string duration
        {
            get
            {
                return resourceProvider_tran_applicationreqvisitorinout.GetResource("duration", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string notetext
        {
            get
            {
                return resourceProvider_tran_applicationreqvisitorinout.GetResource("notetext", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string updateinfo
        {
            get
            {
                return resourceProvider_tran_applicationreqvisitorinout.GetResource("updateinfo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string tranformactionid
        {
            get
            {
                return resourceProvider_tran_applicationreqvisitorinout.GetResource("tranformactionid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        public static string enteredgateid
        {
            get
            {
                return resourceProvider_tran_applicationreqvisitorinout.GetResource("enteredgateid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        public static string enteredgatename
        {
            get
            {
                return resourceProvider_tran_applicationreqvisitorinout.GetResource("enteredgatename", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string enteredgatenamear
        {
            get
            {
                return resourceProvider_tran_applicationreqvisitorinout.GetResource("enteredgatenamear", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


    }
}
