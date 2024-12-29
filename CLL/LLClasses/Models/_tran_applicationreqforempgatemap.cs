using System;
using System.Globalization;
using System.IO;
using CLL.Abstract;

namespace CLL.LLClasses.Models
{
    
    public  class _tran_applicationreqforempgatemap : _Common
    {
         private static IResourceProvider resourceProvider_tran_applicationreqforempgatemap = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"LanguagesFiles/_tran_applicationreqforempgatemap.xml"));//DbResourceProvider(); //  
         
         
        public static string requestapplicationgateinfoList
        {
            get
            {
                return resourceProvider_tran_applicationreqforempgatemap.GetResource("requestapplicationgateinfoList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string requestapplicationgateinfoCreate
        {
            get
            {
                return resourceProvider_tran_applicationreqforempgatemap.GetResource("requestapplicationgateinfoCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string requestapplicationgateinfoUpdate
        {
            get
            {
                return resourceProvider_tran_applicationreqforempgatemap.GetResource("requestapplicationgateinfoUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string requestapplicationgateinfoDetails
        {
            get
            {
                return resourceProvider_tran_applicationreqforempgatemap.GetResource("requestapplicationgateinfoDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
        public static string requestapplicationgateinfoDelete
        {
            get
            {
                return resourceProvider_tran_applicationreqforempgatemap.GetResource("requestapplicationgateinfoDelete", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string requestapplicationid
        {
            get
            {
                return resourceProvider_tran_applicationreqforempgatemap.GetResource("requestapplicationid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string requestapplicationidRequired
        {
            get
            {
                return resourceProvider_tran_applicationreqforempgatemap.GetResource("requestapplicationidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string gateid
        {
            get
            {
                return resourceProvider_tran_applicationreqforempgatemap.GetResource("gateid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string gateidRequired
        {
            get
            {
                return resourceProvider_tran_applicationreqforempgatemap.GetResource("gateidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string permissiondate
        {
            get
            {
                return resourceProvider_tran_applicationreqforempgatemap.GetResource("permissiondate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string permissiondateRequired
        {
            get
            {
                return resourceProvider_tran_applicationreqforempgatemap.GetResource("permissiondateRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string permittedbymasteruserid
        {
            get
            {
                return resourceProvider_tran_applicationreqforempgatemap.GetResource("permittedbymasteruserid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string permittedbymasteruseridRequired
        {
            get
            {
                return resourceProvider_tran_applicationreqforempgatemap.GetResource("permittedbymasteruseridRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string isactive
        {
            get
            {
                return resourceProvider_tran_applicationreqforempgatemap.GetResource("isactive", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string notetext
        {
            get
            {
                return resourceProvider_tran_applicationreqforempgatemap.GetResource("notetext", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string updateinfo
        {
            get
            {
                return resourceProvider_tran_applicationreqforempgatemap.GetResource("updateinfo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string tranformactionid
        {
            get
            {
                return resourceProvider_tran_applicationreqforempgatemap.GetResource("tranformactionid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        
      
    }
}
