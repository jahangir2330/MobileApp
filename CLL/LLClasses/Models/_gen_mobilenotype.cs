using System;
using System.Globalization;
using System.IO;
using CLL.Abstract;

namespace CLL.LLClasses.Models
{
    
    public  class _gen_mobilenotype : _Common
    {
         private static IResourceProvider resourceProvider_gen_mobilenotype = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"LanguagesFiles/_gen_mobilenotype.xml"));//DbResourceProvider(); //  
         
         
        public static string mobilenotypeList
        {
            get
            {
                return resourceProvider_gen_mobilenotype.GetResource("mobilenotypeList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string mobilenotypeCreate
        {
            get
            {
                return resourceProvider_gen_mobilenotype.GetResource("mobilenotypeCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string mobilenotypeUpdate
        {
            get
            {
                return resourceProvider_gen_mobilenotype.GetResource("mobilenotypeUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string mobilenotypeDetails
        {
            get
            {
                return resourceProvider_gen_mobilenotype.GetResource("mobilenotypeDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string mobilenotypename
        {
            get
            {
                return resourceProvider_gen_mobilenotype.GetResource("mobilenotypename", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string mobilenotypenamear
        {
            get
            {
                return resourceProvider_gen_mobilenotype.GetResource("mobilenotypenamear", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string logopath
        {
            get
            {
                return resourceProvider_gen_mobilenotype.GetResource("logopath", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string sortpriority
        {
            get
            {
                return resourceProvider_gen_mobilenotype.GetResource("sortpriority", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string isactive
        {
            get
            {
                return resourceProvider_gen_mobilenotype.GetResource("isactive", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string remarks
        {
            get
            {
                return resourceProvider_gen_mobilenotype.GetResource("remarks", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string updateinfo
        {
            get
            {
                return resourceProvider_gen_mobilenotype.GetResource("updateinfo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string tranformactionid
        {
            get
            {
                return resourceProvider_gen_mobilenotype.GetResource("tranformactionid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        
      
    }
}
