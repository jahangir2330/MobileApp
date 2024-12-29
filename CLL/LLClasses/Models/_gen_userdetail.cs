using System;
using System.Globalization;
using System.IO;
using CLL.Abstract;

namespace CLL.LLClasses.Models
{
    
    public  class _gen_userdetail : _Common
    {
         private static IResourceProvider resourceProvider_gen_userdetail = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"LanguagesFiles/_gen_userdetail.xml"));//DbResourceProvider(); //  
         
         
        public static string userdetailList
        {
            get
            {
                return resourceProvider_gen_userdetail.GetResource("userdetailList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string userdetailCreate
        {
            get
            {
                return resourceProvider_gen_userdetail.GetResource("userdetailCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string userdetailUpdate
        {
            get
            {
                return resourceProvider_gen_userdetail.GetResource("userdetailUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string userdetailDetails
        {
            get
            {
                return resourceProvider_gen_userdetail.GetResource("userdetailDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string masteruserid
        {
            get
            {
                return resourceProvider_gen_userdetail.GetResource("masteruserid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string masteruseridRequired
        {
            get
            {
                return resourceProvider_gen_userdetail.GetResource("masteruseridRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string fullname
        {
            get
            {
                return resourceProvider_gen_userdetail.GetResource("fullname", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string fullnamear
        {
            get
            {
                return resourceProvider_gen_userdetail.GetResource("fullnamear", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string appointment
        {
            get
            {
                return resourceProvider_gen_userdetail.GetResource("appointment", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string officename
        {
            get
            {
                return resourceProvider_gen_userdetail.GetResource("officename", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string signatureimagepath
        {
            get
            {
                return resourceProvider_gen_userdetail.GetResource("signatureimagepath", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string isactive
        {
            get
            {
                return resourceProvider_gen_userdetail.GetResource("isactive", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string remarks
        {
            get
            {
                return resourceProvider_gen_userdetail.GetResource("remarks", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string updateinfo
        {
            get
            {
                return resourceProvider_gen_userdetail.GetResource("updateinfo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string tranformactionid
        {
            get
            {
                return resourceProvider_gen_userdetail.GetResource("tranformactionid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        
      
    }
}
