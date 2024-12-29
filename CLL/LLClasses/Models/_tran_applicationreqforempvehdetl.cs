using System;
using System.Globalization;
using System.IO;
using CLL.Abstract;

namespace CLL.LLClasses.Models
{
    
    public  class _tran_applicationreqforempvehdetl : _Common
    {
         private static IResourceProvider resourceProvider_tran_applicationreqforempvehdetl = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"LanguagesFiles/_tran_applicationreqforempvehdetl.xml"));//DbResourceProvider(); //  
         
         
        public static string applicationreqforempvehdetlList
        {
            get
            {
                return resourceProvider_tran_applicationreqforempvehdetl.GetResource("applicationreqforempvehdetlList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string applicationreqforempvehdetlCreate
        {
            get
            {
                return resourceProvider_tran_applicationreqforempvehdetl.GetResource("applicationreqforempvehdetlCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string applicationreqforempvehdetlUpdate
        {
            get
            {
                return resourceProvider_tran_applicationreqforempvehdetl.GetResource("applicationreqforempvehdetlUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string applicationreqforempvehdetlDetails
        {
            get
            {
                return resourceProvider_tran_applicationreqforempvehdetl.GetResource("applicationreqforempvehdetlDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
        public static string applicationreqforempvehdetlDelete
        {
            get
            {
                return resourceProvider_tran_applicationreqforempvehdetl.GetResource("applicationreqforempvehdetlDelete", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string requestemployeeid
        {
            get
            {
                return resourceProvider_tran_applicationreqforempvehdetl.GetResource("requestemployeeid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string requestemployeeidRequired
        {
            get
            {
                return resourceProvider_tran_applicationreqforempvehdetl.GetResource("requestemployeeidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string carnumberplate
        {
            get
            {
                return resourceProvider_tran_applicationreqforempvehdetl.GetResource("carnumberplate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string vehiclecategoryid
        {
            get
            {
                return resourceProvider_tran_applicationreqforempvehdetl.GetResource("vehiclecategoryid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string vehiclecategoryidRequired
        {
            get
            {
                return resourceProvider_tran_applicationreqforempvehdetl.GetResource("vehiclecategoryidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string vehiclebrandid
        {
            get
            {
                return resourceProvider_tran_applicationreqforempvehdetl.GetResource("vehiclebrandid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string vehiclebrandidRequired
        {
            get
            {
                return resourceProvider_tran_applicationreqforempvehdetl.GetResource("vehiclebrandidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string vehiclemodelid
        {
            get
            {
                return resourceProvider_tran_applicationreqforempvehdetl.GetResource("vehiclemodelid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string vehiclemodelidRequired
        {
            get
            {
                return resourceProvider_tran_applicationreqforempvehdetl.GetResource("vehiclemodelidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string vehiclecolorid
        {
            get
            {
                return resourceProvider_tran_applicationreqforempvehdetl.GetResource("vehiclecolorid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string vehiclecoloridRequired
        {
            get
            {
                return resourceProvider_tran_applicationreqforempvehdetl.GetResource("vehiclecoloridRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string vehicleregistrationnumber
        {
            get
            {
                return resourceProvider_tran_applicationreqforempvehdetl.GetResource("vehicleregistrationnumber", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string vehicleregistrationimagepath
        {
            get
            {
                return resourceProvider_tran_applicationreqforempvehdetl.GetResource("vehicleregistrationimagepath", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string isvehicleblocked
        {
            get
            {
                return resourceProvider_tran_applicationreqforempvehdetl.GetResource("isvehicleblocked", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string vehicleblockstartdate
        {
            get
            {
                return resourceProvider_tran_applicationreqforempvehdetl.GetResource("vehicleblockstartdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string vehicleblockenddate
        {
            get
            {
                return resourceProvider_tran_applicationreqforempvehdetl.GetResource("vehicleblockenddate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string vehicleblockedbyuserid
        {
            get
            {
                return resourceProvider_tran_applicationreqforempvehdetl.GetResource("vehicleblockedbyuserid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string vehicleextentionenddate
        {
            get
            {
                return resourceProvider_tran_applicationreqforempvehdetl.GetResource("vehicleextentionenddate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string vehicleextendat
        {
            get
            {
                return resourceProvider_tran_applicationreqforempvehdetl.GetResource("vehicleextendat", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string vehicleextendbyuserid
        {
            get
            {
                return resourceProvider_tran_applicationreqforempvehdetl.GetResource("vehicleextendbyuserid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string feeamount
        {
            get
            {
                return resourceProvider_tran_applicationreqforempvehdetl.GetResource("feeamount", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string isitfree
        {
            get
            {
                return resourceProvider_tran_applicationreqforempvehdetl.GetResource("isitfree", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string discountamount
        {
            get
            {
                return resourceProvider_tran_applicationreqforempvehdetl.GetResource("discountamount", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string payableamount
        {
            get
            {
                return resourceProvider_tran_applicationreqforempvehdetl.GetResource("payableamount", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string discountedbymasteruserid
        {
            get
            {
                return resourceProvider_tran_applicationreqforempvehdetl.GetResource("discountedbymasteruserid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string isactive
        {
            get
            {
                return resourceProvider_tran_applicationreqforempvehdetl.GetResource("isactive", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        
      
    }
}
