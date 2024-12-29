using System;
using System.Globalization;
using System.IO;
using CLL.Abstract;

namespace CLL.LLClasses.Models
{
    
    public  class _gen_vehiclebrand : _Common
    {
         private static IResourceProvider resourceProvider_gen_vehiclebrand = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"LanguagesFiles/_gen_vehiclebrand.xml"));//DbResourceProvider(); //  
         
         
        public static string vehiclebrandList
        {
            get
            {
                return resourceProvider_gen_vehiclebrand.GetResource("vehiclebrandList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string vehiclebrandCreate
        {
            get
            {
                return resourceProvider_gen_vehiclebrand.GetResource("vehiclebrandCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string vehiclebrandUpdate
        {
            get
            {
                return resourceProvider_gen_vehiclebrand.GetResource("vehiclebrandUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string vehiclebrandDetails
        {
            get
            {
                return resourceProvider_gen_vehiclebrand.GetResource("vehiclebrandDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
        public static string vehiclebrandDelete
        {
            get
            {
                return resourceProvider_gen_vehiclebrand.GetResource("vehiclebrandDelete", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string vehiclebrandname
        {
            get
            {
                return resourceProvider_gen_vehiclebrand.GetResource("vehiclebrandname", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string vehiclebrandnameRequired
        {
            get
            {
                return resourceProvider_gen_vehiclebrand.GetResource("vehiclebrandnameRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string vehiclebrandnamear
        {
            get
            {
                return resourceProvider_gen_vehiclebrand.GetResource("vehiclebrandnamear", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string sortpriority
        {
            get
            {
                return resourceProvider_gen_vehiclebrand.GetResource("sortpriority", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string isactive
        {
            get
            {
                return resourceProvider_gen_vehiclebrand.GetResource("isactive", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string remarks
        {
            get
            {
                return resourceProvider_gen_vehiclebrand.GetResource("remarks", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string tranformactionid
        {
            get
            {
                return resourceProvider_gen_vehiclebrand.GetResource("tranformactionid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string updateinfo
        {
            get
            {
                return resourceProvider_gen_vehiclebrand.GetResource("updateinfo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        
      
    }
}
