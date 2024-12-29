using System;
using System.Globalization;
using System.IO;
using CLL.Abstract;

namespace CLL.LLClasses.Models
{
    
    public  class _gen_requesttype : _Common
    {
         private static IResourceProvider resourceProvider_gen_requesttype = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"LanguagesFiles/_gen_requesttype.xml"));//DbResourceProvider(); //  
         
         
        public static string requesttypeList
        {
            get
            {
                return resourceProvider_gen_requesttype.GetResource("requesttypeList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string requesttypeCreate
        {
            get
            {
                return resourceProvider_gen_requesttype.GetResource("requesttypeCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string requesttypeUpdate
        {
            get
            {
                return resourceProvider_gen_requesttype.GetResource("requesttypeUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string requesttypeDetails
        {
            get
            {
                return resourceProvider_gen_requesttype.GetResource("requesttypeDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string requesttypename
        {
            get
            {
                return resourceProvider_gen_requesttype.GetResource("requesttypename", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string requesttypenamear
        {
            get
            {
                return resourceProvider_gen_requesttype.GetResource("requesttypenamear", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string sortpriority
        {
            get
            {
                return resourceProvider_gen_requesttype.GetResource("sortpriority", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string remarks
        {
            get
            {
                return resourceProvider_gen_requesttype.GetResource("remarks", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string updateinfo
        {
            get
            {
                return resourceProvider_gen_requesttype.GetResource("updateinfo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string tranformactionid
        {
            get
            {
                return resourceProvider_gen_requesttype.GetResource("tranformactionid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        
      
    }
}
