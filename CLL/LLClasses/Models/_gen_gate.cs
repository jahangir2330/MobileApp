using System;
using System.Globalization;
using System.IO;
using CLL.Abstract;

namespace CLL.LLClasses.Models
{

    public class _gen_gate : _Common
    {
        private static IResourceProvider resourceProvider_gen_gate = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"LanguagesFiles/_gen_gate.xml"));//DbResourceProvider(); //  


        public static string gateList
        {
            get
            {
                return resourceProvider_gen_gate.GetResource("gateList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string gateCreate
        {
            get
            {
                return resourceProvider_gen_gate.GetResource("gateCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string gateUpdate
        {
            get
            {
                return resourceProvider_gen_gate.GetResource("gateUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string gateDetails
        {
            get
            {
                return resourceProvider_gen_gate.GetResource("gateDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        public static string gateDelete
        {
            get
            {
                return resourceProvider_gen_gate.GetResource("gateDelete", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


        public static string gatename
        {
            get
            {
                return resourceProvider_gen_gate.GetResource("gatename", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string gatenameRequired
        {
            get
            {
                return resourceProvider_gen_gate.GetResource("gatenameRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string gatenamear
        {
            get
            {
                return resourceProvider_gen_gate.GetResource("gatenamear", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string gatenamearRequired
        {
            get
            {
                return resourceProvider_gen_gate.GetResource("gatenamearRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string gateshortname
        {
            get
            {
                return resourceProvider_gen_gate.GetResource("gateshortname", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string gateshortnamear
        {
            get
            {
                return resourceProvider_gen_gate.GetResource("gateshortnamear", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string gatenumber
        {
            get
            {
                return resourceProvider_gen_gate.GetResource("gatenumber", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string cantonmentname
        {
            get
            {
                return resourceProvider_gen_gate.GetResource("cantonmentname", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string cantonmentnamear
        {
            get
            {
                return resourceProvider_gen_gate.GetResource("cantonmentnamear", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string gateinchargename
        {
            get
            {
                return resourceProvider_gen_gate.GetResource("gateinchargename", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string sortpriority
        {
            get
            {
                return resourceProvider_gen_gate.GetResource("sortpriority", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string isactive
        {
            get
            {
                return resourceProvider_gen_gate.GetResource("isactive", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string remarks
        {
            get
            {
                return resourceProvider_gen_gate.GetResource("remarks", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string updateinfo
        {
            get
            {
                return resourceProvider_gen_gate.GetResource("updateinfo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string tranformactionid
        {
            get
            {
                return resourceProvider_gen_gate.GetResource("tranformactionid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string Unicodecharactersarenotallowed
        {
            get
            {
                return resourceProvider_gen_gate.GetResource("Unicodecharactersarenotallowed", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


    }
}
