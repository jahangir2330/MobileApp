using System;
using System.Globalization;
using System.IO;
using CLL.Abstract;

namespace CLL.LLClasses.Models
{
    
    public  class _gen_entrystatus : _Common
    {
         private static IResourceProvider resourceProvider_gen_entrystatus = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"LanguagesFiles/_gen_entrystatus.xml"));//DbResourceProvider(); //  
         
         
        public static string entrystatusList
        {
            get
            {
                return resourceProvider_gen_entrystatus.GetResource("entrystatusList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string entrystatusCreate
        {
            get
            {
                return resourceProvider_gen_entrystatus.GetResource("entrystatusCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string entrystatusUpdate
        {
            get
            {
                return resourceProvider_gen_entrystatus.GetResource("entrystatusUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string entrystatusDetails
        {
            get
            {
                return resourceProvider_gen_entrystatus.GetResource("entrystatusDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
        public static string entrystatusDelete
        {
            get
            {
                return resourceProvider_gen_entrystatus.GetResource("entrystatusDelete", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
         public static string entrystatusid
        {
            get
            {
                return resourceProvider_gen_entrystatus.GetResource("entrystatusid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
     
         public static string entrystatusname
        {
            get
            {
                return resourceProvider_gen_entrystatus.GetResource("entrystatusname", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string entrystatusnameRequired
        {
            get
            {
                return resourceProvider_gen_entrystatus.GetResource("entrystatusnameRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string entrystatusnamear
        {
            get
            {
                return resourceProvider_gen_entrystatus.GetResource("entrystatusnamear", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string entrystatusnamearRequired
        {
            get
            {
                return resourceProvider_gen_entrystatus.GetResource("entrystatusnamearRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string imagepath
        {
            get
            {
                return resourceProvider_gen_entrystatus.GetResource("imagepath", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string sortpriority
        {
            get
            {
                return resourceProvider_gen_entrystatus.GetResource("sortpriority", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string sortpriorityRequired
        {
            get
            {
                return resourceProvider_gen_entrystatus.GetResource("sortpriorityRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string iconname
        {
            get
            {
                return resourceProvider_gen_entrystatus.GetResource("iconname", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string cssclass
        {
            get
            {
                return resourceProvider_gen_entrystatus.GetResource("cssclass", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string isactive
        {
            get
            {
                return resourceProvider_gen_entrystatus.GetResource("isactive", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string remarks
        {
            get
            {
                return resourceProvider_gen_entrystatus.GetResource("remarks", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string updateinfo
        {
            get
            {
                return resourceProvider_gen_entrystatus.GetResource("updateinfo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string tranformactionid
        {
            get
            {
                return resourceProvider_gen_entrystatus.GetResource("tranformactionid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        
      
    }
}
