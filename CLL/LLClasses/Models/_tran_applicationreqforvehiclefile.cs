using System;
using System.Globalization;
using System.IO;
using CLL.Abstract;

namespace CLL.LLClasses.Models
{
    
    public  class _gen_vehiclefile : _Common
    {
         private static IResourceProvider resourceProvider_tran_applicationreqforvehiclefile = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"LanguagesFiles/_tran_applicationreqforvehiclefile.xml"));//DbResourceProvider(); //  
         
         
        public static string vehiclefileList
        {
            get
            {
                return resourceProvider_tran_applicationreqforvehiclefile.GetResource("vehiclefileList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string vehiclefileCreate
        {
            get
            {
                return resourceProvider_tran_applicationreqforvehiclefile.GetResource("vehiclefileCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string vehiclefileUpdate
        {
            get
            {
                return resourceProvider_tran_applicationreqforvehiclefile.GetResource("vehiclefileUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string vehiclefileDetails
        {
            get
            {
                return resourceProvider_tran_applicationreqforvehiclefile.GetResource("vehiclefileDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
        public static string vehiclefileDelete
        {
            get
            {
                return resourceProvider_tran_applicationreqforvehiclefile.GetResource("vehiclefileDelete", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string requestvehicleid
        {
            get
            {
                return resourceProvider_tran_applicationreqforvehiclefile.GetResource("requestvehicleid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string requestvehicleidRequired
        {
            get
            {
                return resourceProvider_tran_applicationreqforvehiclefile.GetResource("requestvehicleidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string vehiclefiletypeid
        {
            get
            {
                return resourceProvider_tran_applicationreqforvehiclefile.GetResource("vehiclefiletypeid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string vehiclefiletypeidRequired
        {
            get
            {
                return resourceProvider_tran_applicationreqforvehiclefile.GetResource("vehiclefiletypeidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string vehiclefilepath
        {
            get
            {
                return resourceProvider_tran_applicationreqforvehiclefile.GetResource("vehiclefilepath", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string isactive
        {
            get
            {
                return resourceProvider_tran_applicationreqforvehiclefile.GetResource("isactive", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string fileformattype
        {
            get
            {
                return resourceProvider_tran_applicationreqforvehiclefile.GetResource("fileformattype", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string fileextension
        {
            get
            {
                return resourceProvider_tran_applicationreqforvehiclefile.GetResource("fileextension", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string actualfilename
        {
            get
            {
                return resourceProvider_tran_applicationreqforvehiclefile.GetResource("actualfilename", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string remarks
        {
            get
            {
                return resourceProvider_tran_applicationreqforvehiclefile.GetResource("remarks", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string tranformactionid
        {
            get
            {
                return resourceProvider_tran_applicationreqforvehiclefile.GetResource("tranformactionid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string updateinfo
        {
            get
            {
                return resourceProvider_tran_applicationreqforvehiclefile.GetResource("updateinfo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        
      
    }
}
