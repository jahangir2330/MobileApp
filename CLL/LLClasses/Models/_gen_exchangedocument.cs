using System;
using System.Globalization;
using System.IO;
using CLL.Abstract;

namespace CLL.LLClasses.Models
{
    
    public  class _exchangedocument : _Common
    {
         private static IResourceProvider resourceProvider_exchangedocument = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"LanguagesFiles/_gen_exchangedocument.xml"));//DbResourceProvider(); //  
         
         
        public static string exchangedocumentList
        {
            get
            {
                return resourceProvider_exchangedocument.GetResource("exchangedocumentList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string exchangedocumentCreate
        {
            get
            {
                return resourceProvider_exchangedocument.GetResource("exchangedocumentCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string exchangedocumentUpdate
        {
            get
            {
                return resourceProvider_exchangedocument.GetResource("exchangedocumentUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string exchangedocumentDetails
        {
            get
            {
                return resourceProvider_exchangedocument.GetResource("exchangedocumentDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string exchangedocumenttitlear
        {
            get
            {
                return resourceProvider_exchangedocument.GetResource("exchangedocumenttitlear", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string exchangedocumenttitlearRequired
        {
            get
            {
                return resourceProvider_exchangedocument.GetResource("exchangedocumenttitlearRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string exchangedocumenttitleen
        {
            get
            {
                return resourceProvider_exchangedocument.GetResource("exchangedocumenttitleen", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string exchangedocumentdescar
        {
            get
            {
                return resourceProvider_exchangedocument.GetResource("exchangedocumentdescar", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string exchangedocumentdescarRequired
        {
            get
            {
                return resourceProvider_exchangedocument.GetResource("exchangedocumentdescarRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string exchangedocumentdescen
        {
            get
            {
                return resourceProvider_exchangedocument.GetResource("exchangedocumentdescen", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string filepath
        {
            get
            {
                return resourceProvider_exchangedocument.GetResource("filepath", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string filetype
        {
            get
            {
                return resourceProvider_exchangedocument.GetResource("filetype", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string fileextension
        {
            get
            {
                return resourceProvider_exchangedocument.GetResource("fileextension", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string actualfilename
        {
            get
            {
                return resourceProvider_exchangedocument.GetResource("actualfilename", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string filename
        {
            get
            {
                return resourceProvider_exchangedocument.GetResource("filename", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string qrcode
        {
            get
            {
                return resourceProvider_exchangedocument.GetResource("qrcode", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string qrcodeRequired
        {
            get
            {
                return resourceProvider_exchangedocument.GetResource("qrcodeRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        
      
    }
}
