using System;
using System.Globalization;
using System.IO;
using CLL.Abstract;

namespace CLL.LLClasses.Models
{

    public class _gen_vehiclecolor : _Common
    {
        private static IResourceProvider resourceProvider_gen_vehiclecolor = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"LanguagesFiles/_gen_vehiclecolor.xml"));//DbResourceProvider(); //  


        public static string vehiclecolorList
        {
            get
            {
                return resourceProvider_gen_vehiclecolor.GetResource("vehiclecolorList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string vehiclecolorCreate
        {
            get
            {
                return resourceProvider_gen_vehiclecolor.GetResource("vehiclecolorCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string vehiclecolorUpdate
        {
            get
            {
                return resourceProvider_gen_vehiclecolor.GetResource("vehiclecolorUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string vehiclecolorDetails
        {
            get
            {
                return resourceProvider_gen_vehiclecolor.GetResource("vehiclecolorDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        public static string vehiclecolorDelete
        {
            get
            {
                return resourceProvider_gen_vehiclecolor.GetResource("vehiclecolorDelete", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


        public static string vehiclecolorname
        {
            get
            {
                return resourceProvider_gen_vehiclecolor.GetResource("vehiclecolorname", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string vehiclecolornameRequired
        {
            get
            {
                return resourceProvider_gen_vehiclecolor.GetResource("vehiclecolornameRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string vehiclecolornamear
        {
            get
            {
                return resourceProvider_gen_vehiclecolor.GetResource("vehiclecolornamear", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string sortpriority
        {
            get
            {
                return resourceProvider_gen_vehiclecolor.GetResource("sortpriority", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string isactive
        {
            get
            {
                return resourceProvider_gen_vehiclecolor.GetResource("isactive", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string remarks
        {
            get
            {
                return resourceProvider_gen_vehiclecolor.GetResource("remarks", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string tranformactionid
        {
            get
            {
                return resourceProvider_gen_vehiclecolor.GetResource("tranformactionid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string updateinfo
        {
            get
            {
                return resourceProvider_gen_vehiclecolor.GetResource("updateinfo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


    }
}
