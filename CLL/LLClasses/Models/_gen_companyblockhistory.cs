using System;
using System.Globalization;
using System.IO;
using CLL.Abstract;

namespace CLL.LLClasses.Models
{
    
    public  class _gen_companyblockhistory : _Common
    {
         private static IResourceProvider resourceProvider_gen_companyblockhistory = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"LanguagesFiles/_gen_companyblockhistory.xml"));//DbResourceProvider(); //  
         
         
        public static string companyblockhistoryList
        {
            get
            {
                return resourceProvider_gen_companyblockhistory.GetResource("companyblockhistoryList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string companyblockhistoryCreate
        {
            get
            {
                return resourceProvider_gen_companyblockhistory.GetResource("companyblockhistoryCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string companyblockhistoryUpdate
        {
            get
            {
                return resourceProvider_gen_companyblockhistory.GetResource("companyblockhistoryUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string companyblockhistoryDetails
        {
            get
            {
                return resourceProvider_gen_companyblockhistory.GetResource("companyblockhistoryDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string companyid
        {
            get
            {
                return resourceProvider_gen_companyblockhistory.GetResource("companyid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string companyidRequired
        {
            get
            {
                return resourceProvider_gen_companyblockhistory.GetResource("companyidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string companyblockhistorysummary
        {
            get
            {
                return resourceProvider_gen_companyblockhistory.GetResource("companyblockhistorysummary", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string companyblockhistorysummaryRequired
        {
            get
            {
                return resourceProvider_gen_companyblockhistory.GetResource("companyblockhistorysummaryRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string companyblockhistorydescription
        {
            get
            {
                return resourceProvider_gen_companyblockhistory.GetResource("companyblockhistorydescription", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string companyblockhistorydescriptionRequired
        {
            get
            {
                return resourceProvider_gen_companyblockhistory.GetResource("companyblockhistorydescriptionRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string filepath
        {
            get
            {
                return resourceProvider_gen_companyblockhistory.GetResource("filepath", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string filepathRequired
        {
            get
            {
                return resourceProvider_gen_companyblockhistory.GetResource("filepathRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string blocktypeid
        {
            get
            {
                return resourceProvider_gen_companyblockhistory.GetResource("blocktypeid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string isactive
        {
            get
            {
                return resourceProvider_gen_companyblockhistory.GetResource("isactive", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string remarks
        {
            get
            {
                return resourceProvider_gen_companyblockhistory.GetResource("remarks", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string updateinfo
        {
            get
            {
                return resourceProvider_gen_companyblockhistory.GetResource("updateinfo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string tranformactionid
        {
            get
            {
                return resourceProvider_gen_companyblockhistory.GetResource("tranformactionid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        
      
    }
}
