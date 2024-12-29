using System;
using System.Globalization;
using System.IO;
using CLL.Abstract;

namespace CLL.LLClasses.Models
{
    
    public  class _gen_vehiclefiletype : _Common
    {
         private static IResourceProvider resourceProvider_gen_vehiclefiletype = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"LanguagesFiles/_gen_vehiclefiletype.xml"));//DbResourceProvider(); //  
         
         
        public static string vehiclefiletypeList
        {
            get
            {
                return resourceProvider_gen_vehiclefiletype.GetResource("vehiclefiletypeList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string vehiclefiletypeCreate
        {
            get
            {
                return resourceProvider_gen_vehiclefiletype.GetResource("vehiclefiletypeCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string vehiclefiletypeUpdate
        {
            get
            {
                return resourceProvider_gen_vehiclefiletype.GetResource("vehiclefiletypeUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string vehiclefiletypeDetails
        {
            get
            {
                return resourceProvider_gen_vehiclefiletype.GetResource("vehiclefiletypeDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
        public static string vehiclefiletypeDelete
        {
            get
            {
                return resourceProvider_gen_vehiclefiletype.GetResource("vehiclefiletypeDelete", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string vehiclefiletypename
        {
            get
            {
                return resourceProvider_gen_vehiclefiletype.GetResource("vehiclefiletypename", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string vehiclefiletypenamear
        {
            get
            {
                return resourceProvider_gen_vehiclefiletype.GetResource("vehiclefiletypenamear", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string expectedfiletypes
        {
            get
            {
                return resourceProvider_gen_vehiclefiletype.GetResource("expectedfiletypes", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string errormessageforrequired
        {
            get
            {
                return resourceProvider_gen_vehiclefiletype.GetResource("errormessageforrequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string errormessageforrequiredar
        {
            get
            {
                return resourceProvider_gen_vehiclefiletype.GetResource("errormessageforrequiredar", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string sortpriority
        {
            get
            {
                return resourceProvider_gen_vehiclefiletype.GetResource("sortpriority", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string remarks
        {
            get
            {
                return resourceProvider_gen_vehiclefiletype.GetResource("remarks", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string tranformactionid
        {
            get
            {
                return resourceProvider_gen_vehiclefiletype.GetResource("tranformactionid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string updateinfo
        {
            get
            {
                return resourceProvider_gen_vehiclefiletype.GetResource("updateinfo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string isactive
        {
            get
            {
                return resourceProvider_gen_vehiclefiletype.GetResource("isactive", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        
      
    }
}
