using System;
using System.Globalization;
using System.IO;
using CLL.Abstract;

namespace CLL.LLClasses.Models
{
    
    public  class _oc_registrationinfo : _Common
    {
         private static IResourceProvider resourceProvider_oc_registrationinfo = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"LanguagesFiles/_oc_registrationinfo.xml"));//DbResourceProvider(); //  
         
         
        public static string registrationinfoList
        {
            get
            {
                return resourceProvider_oc_registrationinfo.GetResource("registrationinfoList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string registrationinfoCreate
        {
            get
            {
                return resourceProvider_oc_registrationinfo.GetResource("registrationinfoCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string registrationinfoUpdate
        {
            get
            {
                return resourceProvider_oc_registrationinfo.GetResource("registrationinfoUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string registrationinfoDetails
        {
            get
            {
                return resourceProvider_oc_registrationinfo.GetResource("registrationinfoDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string membershipcode
        {
            get
            {
                return resourceProvider_oc_registrationinfo.GetResource("membershipcode", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string membershipcodeRequired
        {
            get
            {
                return resourceProvider_oc_registrationinfo.GetResource("membershipcodeRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string ocfileid
        {
            get
            {
                return resourceProvider_oc_registrationinfo.GetResource("ocfileid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string ocfileidRequired
        {
            get
            {
                return resourceProvider_oc_registrationinfo.GetResource("ocfileidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string ocfamilymemberid
        {
            get
            {
                return resourceProvider_oc_registrationinfo.GetResource("ocfamilymemberid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string isfamilymember
        {
            get
            {
                return resourceProvider_oc_registrationinfo.GetResource("isfamilymember", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string isfamilymemberRequired
        {
            get
            {
                return resourceProvider_oc_registrationinfo.GetResource("isfamilymemberRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string registrationdate
        {
            get
            {
                return resourceProvider_oc_registrationinfo.GetResource("registrationdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string registrationdateRequired
        {
            get
            {
                return resourceProvider_oc_registrationinfo.GetResource("registrationdateRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string isactive
        {
            get
            {
                return resourceProvider_oc_registrationinfo.GetResource("isactive", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string isreviewed
        {
            get
            {
                return resourceProvider_oc_registrationinfo.GetResource("isreviewed", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string reviewdate
        {
            get
            {
                return resourceProvider_oc_registrationinfo.GetResource("reviewdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string reviewednote
        {
            get
            {
                return resourceProvider_oc_registrationinfo.GetResource("reviewednote", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string reviewedby
        {
            get
            {
                return resourceProvider_oc_registrationinfo.GetResource("reviewedby", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string isblocked
        {
            get
            {
                return resourceProvider_oc_registrationinfo.GetResource("isblocked", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string blockeddate
        {
            get
            {
                return resourceProvider_oc_registrationinfo.GetResource("blockeddate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string blockednote
        {
            get
            {
                return resourceProvider_oc_registrationinfo.GetResource("blockednote", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        
      
    }
}
