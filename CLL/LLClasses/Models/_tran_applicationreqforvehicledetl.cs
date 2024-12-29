using System;
using System.Globalization;
using System.IO;
using CLL.Abstract;

namespace CLL.LLClasses.Models
{

    public class _tran_applicationreqforvehicledetl : _Common
    {
        private static IResourceProvider resourceProvider_tran_applicationreqforvehicledetl = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"LanguagesFiles/_tran_applicationreqforvehicledetl.xml"));//DbResourceProvider(); //  


        public static string vehicleinfoList
        {
            get
            {
                return resourceProvider_tran_applicationreqforvehicledetl.GetResource("vehicleinfoList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string vehicleinfoCreate
        {
            get
            {
                return resourceProvider_tran_applicationreqforvehicledetl.GetResource("vehicleinfoCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string vehicleinfoUpdate
        {
            get
            {
                return resourceProvider_tran_applicationreqforvehicledetl.GetResource("vehicleinfoUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string vehicleinfoDetails
        {
            get
            {
                return resourceProvider_tran_applicationreqforvehicledetl.GetResource("vehicleinfoDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        public static string vehicleinfoDelete
        {
            get
            {
                return resourceProvider_tran_applicationreqforvehicledetl.GetResource("vehicleinfoDelete", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


        public static string requestvehicleid
        {
            get
            {
                return resourceProvider_tran_applicationreqforvehicledetl.GetResource("requestvehicleid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string requestvehicleidRequired
        {
            get
            {
                return resourceProvider_tran_applicationreqforvehicledetl.GetResource("requestvehicleidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string carnumberplate
        {
            get
            {
                return resourceProvider_tran_applicationreqforvehicledetl.GetResource("carnumberplate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string vehiclecategoryid
        {
            get
            {
                return resourceProvider_tran_applicationreqforvehicledetl.GetResource("vehiclecategoryid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string vehiclecategoryidRequired
        {
            get
            {
                return resourceProvider_tran_applicationreqforvehicledetl.GetResource("vehiclecategoryidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string vehiclebrandid
        {
            get
            {
                return resourceProvider_tran_applicationreqforvehicledetl.GetResource("vehiclebrandid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string vehiclebrandidRequired
        {
            get
            {
                return resourceProvider_tran_applicationreqforvehicledetl.GetResource("vehiclebrandidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string vehiclemodelid
        {
            get
            {
                return resourceProvider_tran_applicationreqforvehicledetl.GetResource("vehiclemodelid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string vehiclemodelidRequired
        {
            get
            {
                return resourceProvider_tran_applicationreqforvehicledetl.GetResource("vehiclemodelidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string vehiclecolorid
        {
            get
            {
                return resourceProvider_tran_applicationreqforvehicledetl.GetResource("vehiclecolorid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string vehiclecoloridRequired
        {
            get
            {
                return resourceProvider_tran_applicationreqforvehicledetl.GetResource("vehiclecoloridRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string vehicleregistrationnumber
        {
            get
            {
                return resourceProvider_tran_applicationreqforvehicledetl.GetResource("vehicleregistrationnumber", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string vehicleregistrationimagepath
        {
            get
            {
                return resourceProvider_tran_applicationreqforvehicledetl.GetResource("vehicleregistrationimagepath", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string isvehicleblocked
        {
            get
            {
                return resourceProvider_tran_applicationreqforvehicledetl.GetResource("isvehicleblocked", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string vehicleblockstartdate
        {
            get
            {
                return resourceProvider_tran_applicationreqforvehicledetl.GetResource("vehicleblockstartdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string vehicleblockenddate
        {
            get
            {
                return resourceProvider_tran_applicationreqforvehicledetl.GetResource("vehicleblockenddate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string vehicleblockedbyuserid
        {
            get
            {
                return resourceProvider_tran_applicationreqforvehicledetl.GetResource("vehicleblockedbyuserid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string vehicleextentionenddate
        {
            get
            {
                return resourceProvider_tran_applicationreqforvehicledetl.GetResource("vehicleextentionenddate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string vehicleextendat
        {
            get
            {
                return resourceProvider_tran_applicationreqforvehicledetl.GetResource("vehicleextendat", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string vehicleextendbyuserid
        {
            get
            {
                return resourceProvider_tran_applicationreqforvehicledetl.GetResource("vehicleextendbyuserid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string isactive
        {
            get
            {
                return resourceProvider_tran_applicationreqforvehicledetl.GetResource("isactive", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


    }
}
