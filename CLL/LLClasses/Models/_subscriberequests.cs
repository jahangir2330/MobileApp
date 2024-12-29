using System;
using System.Globalization;
using System.IO;
using CLL.Abstract;

namespace CLL.LLClasses.Models
{
    
    public  class _subscriberequests : _Common
    {
         private static IResourceProvider resourceProvider_subscriberequests = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"LanguagesFiles/_subscriberequests.xml"));//DbResourceProvider(); //  
         
         
        public static string subscriberequestsList
        {
            get
            {
                return resourceProvider_subscriberequests.GetResource("subscriberequestsList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string subscriberequestsCreate
        {
            get
            {
                return resourceProvider_subscriberequests.GetResource("subscriberequestsCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string subscriberequestsUpdate
        {
            get
            {
                return resourceProvider_subscriberequests.GetResource("subscriberequestsUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string subscriberequestsDetails
        {
            get
            {
                return resourceProvider_subscriberequests.GetResource("subscriberequestsDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string requestdate
        {
            get
            {
                return resourceProvider_subscriberequests.GetResource("requestdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string requestdateRequired
        {
            get
            {
                return resourceProvider_subscriberequests.GetResource("requestdateRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string requesteduserinfojson
        {
            get
            {
                return resourceProvider_subscriberequests.GetResource("requesteduserinfojson", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        
      
    }
}
