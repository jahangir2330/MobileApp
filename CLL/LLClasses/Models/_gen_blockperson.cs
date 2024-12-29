using System;
using System.Globalization;
using System.IO;
using CLL.Abstract;

namespace CLL.LLClasses.Models
{
    
    public  class _gen_blockperson : _Common
    {
         private static IResourceProvider resourceProvider_gen_blockperson = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"LanguagesFiles/_gen_blockperson.xml"));//DbResourceProvider(); //  
         
         
        public static string blockpersonList
        {
            get
            {
                return resourceProvider_gen_blockperson.GetResource("blockpersonList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string blockpersonCreate
        {
            get
            {
                return resourceProvider_gen_blockperson.GetResource("blockpersonCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string blockpersonUpdate
        {
            get
            {
                return resourceProvider_gen_blockperson.GetResource("blockpersonUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string blockpersonDetails
        {
            get
            {
                return resourceProvider_gen_blockperson.GetResource("blockpersonDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
        public static string blockpersonDelete
        {
            get
            {
                return resourceProvider_gen_blockperson.GetResource("blockpersonDelete", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string blockpersonname
        {
            get
            {
                return resourceProvider_gen_blockperson.GetResource("blockpersonname", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string blockpersonnameRequired
        {
            get
            {
                return resourceProvider_gen_blockperson.GetResource("blockpersonnameRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string blockpersonnamear
        {
            get
            {
                return resourceProvider_gen_blockperson.GetResource("blockpersonnamear", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string blockpersonnamearRequired
        {
            get
            {
                return resourceProvider_gen_blockperson.GetResource("blockpersonnamearRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string civilidnumber
        {
            get
            {
                return resourceProvider_gen_blockperson.GetResource("civilidnumber", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string civilidnumberRequired
        {
            get
            {
                return resourceProvider_gen_blockperson.GetResource("civilidnumberRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string passportnumber
        {
            get
            {
                return resourceProvider_gen_blockperson.GetResource("passportnumber", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string blockdescription
        {
            get
            {
                return resourceProvider_gen_blockperson.GetResource("blockdescription", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string isblocked
        {
            get
            {
                return resourceProvider_gen_blockperson.GetResource("isblocked", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string blockstartdate
        {
            get
            {
                return resourceProvider_gen_blockperson.GetResource("blockstartdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string blockenddate
        {
            get
            {
                return resourceProvider_gen_blockperson.GetResource("blockenddate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string blockedbyuserid
        {
            get
            {
                return resourceProvider_gen_blockperson.GetResource("blockedbyuserid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string isactive
        {
            get
            {
                return resourceProvider_gen_blockperson.GetResource("isactive", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string updateinfo
        {
            get
            {
                return resourceProvider_gen_blockperson.GetResource("updateinfo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string tranformactionid
        {
            get
            {
                return resourceProvider_gen_blockperson.GetResource("tranformactionid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        
      
    }
}
