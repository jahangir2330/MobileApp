using System;
using System.Globalization;
using System.IO;
using CLL.Abstract;

namespace CLL.LLClasses.Models
{
    
    public  class _gen_licensetype : _Common
    {
         private static IResourceProvider resourceProvider_gen_licensetype = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"LanguagesFiles/_gen_licensetype.xml"));//DbResourceProvider(); //  
         
         
        public static string licensetypeList
        {
            get
            {
                return resourceProvider_gen_licensetype.GetResource("licensetypeList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string licensetypeCreate
        {
            get
            {
                return resourceProvider_gen_licensetype.GetResource("licensetypeCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string licensetypeUpdate
        {
            get
            {
                return resourceProvider_gen_licensetype.GetResource("licensetypeUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string licensetypeDetails
        {
            get
            {
                return resourceProvider_gen_licensetype.GetResource("licensetypeDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string licensetypename
        {
            get
            {
                return resourceProvider_gen_licensetype.GetResource("licensetypename", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string licensetypenameRequired
        {
            get
            {
                return resourceProvider_gen_licensetype.GetResource("licensetypenameRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string licensetypenamear
        {
            get
            {
                return resourceProvider_gen_licensetype.GetResource("licensetypenamear", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string sortpriority
        {
            get
            {
                return resourceProvider_gen_licensetype.GetResource("sortpriority", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string remarks
        {
            get
            {
                return resourceProvider_gen_licensetype.GetResource("remarks", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string updateinfo
        {
            get
            {
                return resourceProvider_gen_licensetype.GetResource("updateinfo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string tranformactionid
        {
            get
            {
                return resourceProvider_gen_licensetype.GetResource("tranformactionid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        
      
    }
}
