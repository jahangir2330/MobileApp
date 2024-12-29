using System;
using System.Globalization;
using System.IO;
using CLL.Abstract;

namespace CLL.LLClasses.Models
{
    
    public  class _gen_usergatemap : _Common
    {
         private static IResourceProvider resourceProvider_gen_usergatemap = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"LanguagesFiles/_gen_usergatemap.xml"));//DbResourceProvider(); //  
         
         
        public static string usergatemapList
        {
            get
            {
                return resourceProvider_gen_usergatemap.GetResource("usergatemapList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string usergatemapCreate
        {
            get
            {
                return resourceProvider_gen_usergatemap.GetResource("usergatemapCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string usergatemapUpdate
        {
            get
            {
                return resourceProvider_gen_usergatemap.GetResource("usergatemapUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string usergatemapDetails
        {
            get
            {
                return resourceProvider_gen_usergatemap.GetResource("usergatemapDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
        public static string usergatemapDelete
        {
            get
            {
                return resourceProvider_gen_usergatemap.GetResource("usergatemapDelete", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string masteruserid
        {
            get
            {
                return resourceProvider_gen_usergatemap.GetResource("masteruserid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string masteruseridRequired
        {
            get
            {
                return resourceProvider_gen_usergatemap.GetResource("masteruseridRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string gateid
        {
            get
            {
                return resourceProvider_gen_usergatemap.GetResource("gateid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string gateidRequired
        {
            get
            {
                return resourceProvider_gen_usergatemap.GetResource("gateidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string isactive
        {
            get
            {
                return resourceProvider_gen_usergatemap.GetResource("isactive", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string remarks
        {
            get
            {
                return resourceProvider_gen_usergatemap.GetResource("remarks", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string tranformactionid
        {
            get
            {
                return resourceProvider_gen_usergatemap.GetResource("tranformactionid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string updateinfo
        {
            get
            {
                return resourceProvider_gen_usergatemap.GetResource("updateinfo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        
      
    }
}
