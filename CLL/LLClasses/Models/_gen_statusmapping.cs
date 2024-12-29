using System;
using System.Globalization;
using System.IO;
using CLL.Abstract;

namespace CLL.LLClasses.Models
{
    
    public  class _gen_statusmapping : _Common
    {
         private static IResourceProvider resourceProvider_gen_statusmapping = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"LanguagesFiles/_gen_statusmapping.xml"));//DbResourceProvider(); //  
         
         
        public static string statusmappingList
        {
            get
            {
                return resourceProvider_gen_statusmapping.GetResource("statusmappingList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string statusmappingCreate
        {
            get
            {
                return resourceProvider_gen_statusmapping.GetResource("statusmappingCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string statusmappingUpdate
        {
            get
            {
                return resourceProvider_gen_statusmapping.GetResource("statusmappingUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string statusmappingDetails
        {
            get
            {
                return resourceProvider_gen_statusmapping.GetResource("statusmappingDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
        public static string statusmappingDelete
        {
            get
            {
                return resourceProvider_gen_statusmapping.GetResource("statusmappingDelete", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string parentstatusid
        {
            get
            {
                return resourceProvider_gen_statusmapping.GetResource("parentstatusid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string parentstatusidRequired
        {
            get
            {
                return resourceProvider_gen_statusmapping.GetResource("parentstatusidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string statusid
        {
            get
            {
                return resourceProvider_gen_statusmapping.GetResource("statusid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string statusidRequired
        {
            get
            {
                return resourceProvider_gen_statusmapping.GetResource("statusidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string isactive
        {
            get
            {
                return resourceProvider_gen_statusmapping.GetResource("isactive", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string remarks
        {
            get
            {
                return resourceProvider_gen_statusmapping.GetResource("remarks", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string updateinfo
        {
            get
            {
                return resourceProvider_gen_statusmapping.GetResource("updateinfo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string tranformactionid
        {
            get
            {
                return resourceProvider_gen_statusmapping.GetResource("tranformactionid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        
      
    }
}
