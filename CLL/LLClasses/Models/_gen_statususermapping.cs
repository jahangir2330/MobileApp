using System;
using System.Globalization;
using System.IO;
using CLL.Abstract;

namespace CLL.LLClasses.Models
{
    
    public  class _gen_statususermapping : _Common
    {
         private static IResourceProvider resourceProvider_gen_statususermapping = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"LanguagesFiles/_gen_statususermapping.xml"));//DbResourceProvider(); //  
         
         
        public static string statususermappingList
        {
            get
            {
                return resourceProvider_gen_statususermapping.GetResource("statususermappingList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string statususermappingCreate
        {
            get
            {
                return resourceProvider_gen_statususermapping.GetResource("statususermappingCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string statususermappingUpdate
        {
            get
            {
                return resourceProvider_gen_statususermapping.GetResource("statususermappingUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string statususermappingDetails
        {
            get
            {
                return resourceProvider_gen_statususermapping.GetResource("statususermappingDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
        public static string statususermappingDelete
        {
            get
            {
                return resourceProvider_gen_statususermapping.GetResource("statususermappingDelete", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string statusid
        {
            get
            {
                return resourceProvider_gen_statususermapping.GetResource("statusid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string statusidRequired
        {
            get
            {
                return resourceProvider_gen_statususermapping.GetResource("statusidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string masteruserid
        {
            get
            {
                return resourceProvider_gen_statususermapping.GetResource("masteruserid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string masteruseridRequired
        {
            get
            {
                return resourceProvider_gen_statususermapping.GetResource("masteruseridRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string isactive
        {
            get
            {
                return resourceProvider_gen_statususermapping.GetResource("isactive", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string remarks
        {
            get
            {
                return resourceProvider_gen_statususermapping.GetResource("remarks", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string updateinfo
        {
            get
            {
                return resourceProvider_gen_statususermapping.GetResource("updateinfo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string tranformactionid
        {
            get
            {
                return resourceProvider_gen_statususermapping.GetResource("tranformactionid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        
      
    }
}
