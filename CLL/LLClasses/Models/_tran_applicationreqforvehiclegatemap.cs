using System;
using System.Globalization;
using System.IO;
using CLL.Abstract;

namespace CLL.LLClasses.Models
{
    
    public  class _tran_applicationreqforvehiclegatemap : _Common
    {
         private static IResourceProvider resourceProvider_tran_applicationreqforvehiclegatemap = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"LanguagesFiles/_tran_applicationreqforvehiclegatemap.xml"));//DbResourceProvider(); //  
         
         
        public static string requestvehiclegateinfoList
        {
            get
            {
                return resourceProvider_tran_applicationreqforvehiclegatemap.GetResource("requestvehiclegateinfoList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string requestvehiclegateinfoCreate
        {
            get
            {
                return resourceProvider_tran_applicationreqforvehiclegatemap.GetResource("requestvehiclegateinfoCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string requestvehiclegateinfoUpdate
        {
            get
            {
                return resourceProvider_tran_applicationreqforvehiclegatemap.GetResource("requestvehiclegateinfoUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string requestvehiclegateinfoDetails
        {
            get
            {
                return resourceProvider_tran_applicationreqforvehiclegatemap.GetResource("requestvehiclegateinfoDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
        public static string requestvehiclegateinfoDelete
        {
            get
            {
                return resourceProvider_tran_applicationreqforvehiclegatemap.GetResource("requestvehiclegateinfoDelete", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string requestvehicleid
        {
            get
            {
                return resourceProvider_tran_applicationreqforvehiclegatemap.GetResource("requestvehicleid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string requestvehicleidRequired
        {
            get
            {
                return resourceProvider_tran_applicationreqforvehiclegatemap.GetResource("requestvehicleidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string gateid
        {
            get
            {
                return resourceProvider_tran_applicationreqforvehiclegatemap.GetResource("gateid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string gateidRequired
        {
            get
            {
                return resourceProvider_tran_applicationreqforvehiclegatemap.GetResource("gateidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string permissiondate
        {
            get
            {
                return resourceProvider_tran_applicationreqforvehiclegatemap.GetResource("permissiondate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string permissiondateRequired
        {
            get
            {
                return resourceProvider_tran_applicationreqforvehiclegatemap.GetResource("permissiondateRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string permittedbymasteruserid
        {
            get
            {
                return resourceProvider_tran_applicationreqforvehiclegatemap.GetResource("permittedbymasteruserid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string permittedbymasteruseridRequired
        {
            get
            {
                return resourceProvider_tran_applicationreqforvehiclegatemap.GetResource("permittedbymasteruseridRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string isactive
        {
            get
            {
                return resourceProvider_tran_applicationreqforvehiclegatemap.GetResource("isactive", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string notetext
        {
            get
            {
                return resourceProvider_tran_applicationreqforvehiclegatemap.GetResource("notetext", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string tranformactionid
        {
            get
            {
                return resourceProvider_tran_applicationreqforvehiclegatemap.GetResource("tranformactionid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string updateinfo
        {
            get
            {
                return resourceProvider_tran_applicationreqforvehiclegatemap.GetResource("updateinfo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        
      
    }
}
