using System;
using System.Globalization;
using System.IO;
using CLL.Abstract;

namespace CLL.LLClasses.Models
{
    
    public  class _gen_vehiclecategory : _Common
    {
         private static IResourceProvider resourceProvider_gen_vehiclecategory = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"LanguagesFiles/_gen_vehiclecategory.xml"));//DbResourceProvider(); //  
         
         
        public static string vehiclecategoryList
        {
            get
            {
                return resourceProvider_gen_vehiclecategory.GetResource("vehiclecategoryList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string vehiclecategoryCreate
        {
            get
            {
                return resourceProvider_gen_vehiclecategory.GetResource("vehiclecategoryCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string vehiclecategoryUpdate
        {
            get
            {
                return resourceProvider_gen_vehiclecategory.GetResource("vehiclecategoryUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string vehiclecategoryDetails
        {
            get
            {
                return resourceProvider_gen_vehiclecategory.GetResource("vehiclecategoryDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
        public static string vehiclecategoryDelete
        {
            get
            {
                return resourceProvider_gen_vehiclecategory.GetResource("vehiclecategoryDelete", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string vehiclecategoryname
        {
            get
            {
                return resourceProvider_gen_vehiclecategory.GetResource("vehiclecategoryname", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string vehiclecategorynameRequired
        {
            get
            {
                return resourceProvider_gen_vehiclecategory.GetResource("vehiclecategorynameRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string vehiclecategorynamear
        {
            get
            {
                return resourceProvider_gen_vehiclecategory.GetResource("vehiclecategorynamear", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string sortpriority
        {
            get
            {
                return resourceProvider_gen_vehiclecategory.GetResource("sortpriority", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string isactive
        {
            get
            {
                return resourceProvider_gen_vehiclecategory.GetResource("isactive", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string remarks
        {
            get
            {
                return resourceProvider_gen_vehiclecategory.GetResource("remarks", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string tranformactionid
        {
            get
            {
                return resourceProvider_gen_vehiclecategory.GetResource("tranformactionid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string updateinfo
        {
            get
            {
                return resourceProvider_gen_vehiclecategory.GetResource("updateinfo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        
      
    }
}
