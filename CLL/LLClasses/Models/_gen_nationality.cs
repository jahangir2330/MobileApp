using System;
using System.Globalization;
using System.IO;
using CLL.Abstract;

namespace CLL.LLClasses.Models
{
    
    public  class _gen_nationality : _Common
    {
         private static IResourceProvider resourceProvider_gen_nationality = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"LanguagesFiles/_gen_nationality.xml"));//DbResourceProvider(); //  
         
         
        public static string nationalityList
        {
            get
            {
                return resourceProvider_gen_nationality.GetResource("nationalityList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string nationalityCreate
        {
            get
            {
                return resourceProvider_gen_nationality.GetResource("nationalityCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string nationalityUpdate
        {
            get
            {
                return resourceProvider_gen_nationality.GetResource("nationalityUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string nationalityDetails
        {
            get
            {
                return resourceProvider_gen_nationality.GetResource("nationalityDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string nationalityname
        {
            get
            {
                return resourceProvider_gen_nationality.GetResource("nationalityname", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string nationalitynamear
        {
            get
            {
                return resourceProvider_gen_nationality.GetResource("nationalitynamear", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string flagimagepath
        {
            get
            {
                return resourceProvider_gen_nationality.GetResource("flagimagepath", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string sortpriority
        {
            get
            {
                return resourceProvider_gen_nationality.GetResource("sortpriority", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string isactive
        {
            get
            {
                return resourceProvider_gen_nationality.GetResource("isactive", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string remarks
        {
            get
            {
                return resourceProvider_gen_nationality.GetResource("remarks", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string updateinfo
        {
            get
            {
                return resourceProvider_gen_nationality.GetResource("updateinfo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string tranformactionid
        {
            get
            {
                return resourceProvider_gen_nationality.GetResource("tranformactionid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        
      
    }
}
