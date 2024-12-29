using System;
using System.Globalization;
using System.IO;
using CLL.Abstract;

namespace CLL.LLClasses.Models
{

    public class _gen_requestfiletype : _Common
    {
        private static IResourceProvider resourceProvider_gen_requestfiletype = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"LanguagesFiles/_gen_requestfiletype.xml"));//DbResourceProvider(); //  


        public static string requestfiletypeList
        {
            get
            {
                return resourceProvider_gen_requestfiletype.GetResource("requestfiletypeList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string requestfiletypeCreate
        {
            get
            {
                return resourceProvider_gen_requestfiletype.GetResource("requestfiletypeCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string requestfiletypeUpdate
        {
            get
            {
                return resourceProvider_gen_requestfiletype.GetResource("requestfiletypeUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string requestfiletypeDetails
        {
            get
            {
                return resourceProvider_gen_requestfiletype.GetResource("requestfiletypeDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


        public static string requestfiletypename
        {
            get
            {
                return resourceProvider_gen_requestfiletype.GetResource("requestfiletypename", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string requestfiletypenamear
        {
            get
            {
                return resourceProvider_gen_requestfiletype.GetResource("requestfiletypenamear", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string expectedfiletypes
        {
            get
            {
                return resourceProvider_gen_requestfiletype.GetResource("expectedfiletypes", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string errormessageforrequired
        {
            get
            {
                return resourceProvider_gen_requestfiletype.GetResource("errormessageforrequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string errormessageforrequiredar
        {
            get
            {
                return resourceProvider_gen_requestfiletype.GetResource("errormessageforrequiredar", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string sortpriority
        {
            get
            {
                return resourceProvider_gen_requestfiletype.GetResource("sortpriority", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string remarks
        {
            get
            {
                return resourceProvider_gen_requestfiletype.GetResource("remarks", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string updateinfo
        {
            get
            {
                return resourceProvider_gen_requestfiletype.GetResource("updateinfo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string tranformactionid
        {
            get
            {
                return resourceProvider_gen_requestfiletype.GetResource("tranformactionid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
    }
}
