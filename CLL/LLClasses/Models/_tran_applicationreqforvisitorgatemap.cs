using System;
using System.Globalization;
using System.IO;
using CLL.Abstract;

namespace CLL.LLClasses.Models
{

    public class _tran_applicationreqforvisitorgatemap : _Common
    {
        private static IResourceProvider resourceProvider_tran_applicationreqforvisitorgatemap = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"LanguagesFiles/_tran_applicationreqforvisitorgatemap.xml"));//DbResourceProvider(); //  


        public static string applicationreqforvisitorgatemapList
        {
            get
            {
                return resourceProvider_tran_applicationreqforvisitorgatemap.GetResource("applicationreqforvisitorgatemapList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string applicationreqforvisitorgatemapCreate
        {
            get
            {
                return resourceProvider_tran_applicationreqforvisitorgatemap.GetResource("applicationreqforvisitorgatemapCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string applicationreqforvisitorgatemapUpdate
        {
            get
            {
                return resourceProvider_tran_applicationreqforvisitorgatemap.GetResource("applicationreqforvisitorgatemapUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string applicationreqforvisitorgatemapDetails
        {
            get
            {
                return resourceProvider_tran_applicationreqforvisitorgatemap.GetResource("applicationreqforvisitorgatemapDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        public static string applicationreqforvisitorgatemapDelete
        {
            get
            {
                return resourceProvider_tran_applicationreqforvisitorgatemap.GetResource("applicationreqforvisitorgatemapDelete", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


        public static string requestvisitorid
        {
            get
            {
                return resourceProvider_tran_applicationreqforvisitorgatemap.GetResource("requestvisitorid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string requestvisitoridRequired
        {
            get
            {
                return resourceProvider_tran_applicationreqforvisitorgatemap.GetResource("requestvisitoridRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string gateid
        {
            get
            {
                return resourceProvider_tran_applicationreqforvisitorgatemap.GetResource("gateid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string gateidRequired
        {
            get
            {
                return resourceProvider_tran_applicationreqforvisitorgatemap.GetResource("gateidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string permissiondate
        {
            get
            {
                return resourceProvider_tran_applicationreqforvisitorgatemap.GetResource("permissiondate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string permissiondateRequired
        {
            get
            {
                return resourceProvider_tran_applicationreqforvisitorgatemap.GetResource("permissiondateRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string permittedbymasteruserid
        {
            get
            {
                return resourceProvider_tran_applicationreqforvisitorgatemap.GetResource("permittedbymasteruserid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string permittedbymasteruseridRequired
        {
            get
            {
                return resourceProvider_tran_applicationreqforvisitorgatemap.GetResource("permittedbymasteruseridRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string isactive
        {
            get
            {
                return resourceProvider_tran_applicationreqforvisitorgatemap.GetResource("isactive", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string notetext
        {
            get
            {
                return resourceProvider_tran_applicationreqforvisitorgatemap.GetResource("notetext", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string updateinfo
        {
            get
            {
                return resourceProvider_tran_applicationreqforvisitorgatemap.GetResource("updateinfo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string tranformactionid
        {
            get
            {
                return resourceProvider_tran_applicationreqforvisitorgatemap.GetResource("tranformactionid", CultureInfo.CurrentUICulture.Name) as String;
            }
        } 
        


    }
}
