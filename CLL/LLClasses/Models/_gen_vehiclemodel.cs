using System;
using System.Globalization;
using System.IO;
using CLL.Abstract;

namespace CLL.LLClasses.Models
{
    
    public  class _gen_vehiclemodel : _Common
    {
         private static IResourceProvider resourceProvider_gen_vehiclemodel = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"LanguagesFiles/_gen_vehiclemodel.xml"));//DbResourceProvider(); //  
         
         
        public static string vehiclemodelList
        {
            get
            {
                return resourceProvider_gen_vehiclemodel.GetResource("vehiclemodelList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string vehiclemodelCreate
        {
            get
            {
                return resourceProvider_gen_vehiclemodel.GetResource("vehiclemodelCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string vehiclemodelUpdate
        {
            get
            {
                return resourceProvider_gen_vehiclemodel.GetResource("vehiclemodelUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string vehiclemodelDetails
        {
            get
            {
                return resourceProvider_gen_vehiclemodel.GetResource("vehiclemodelDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
        public static string vehiclemodelDelete
        {
            get
            {
                return resourceProvider_gen_vehiclemodel.GetResource("vehiclemodelDelete", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string vehiclemodelname
        {
            get
            {
                return resourceProvider_gen_vehiclemodel.GetResource("vehiclemodelname", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string vehiclemodelnameRequired
        {
            get
            {
                return resourceProvider_gen_vehiclemodel.GetResource("vehiclemodelnameRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string vehiclemodelnamear
        {
            get
            {
                return resourceProvider_gen_vehiclemodel.GetResource("vehiclemodelnamear", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string sortpriority
        {
            get
            {
                return resourceProvider_gen_vehiclemodel.GetResource("sortpriority", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string isactive
        {
            get
            {
                return resourceProvider_gen_vehiclemodel.GetResource("isactive", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string remarks
        {
            get
            {
                return resourceProvider_gen_vehiclemodel.GetResource("remarks", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string tranformactionid
        {
            get
            {
                return resourceProvider_gen_vehiclemodel.GetResource("tranformactionid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string updateinfo
        {
            get
            {
                return resourceProvider_gen_vehiclemodel.GetResource("updateinfo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        
      
    }
}
