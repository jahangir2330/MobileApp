using System;
using System.Globalization;
using System.IO;
using CLL.Abstract;

namespace CLL.LLClasses.Models
{
    
    public  class _subscriberequestsdetail : _Common
    {
         private static IResourceProvider resourceProvider_subscriberequestsdetail = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"LanguagesFiles/_subscriberequestsdetail.xml"));//DbResourceProvider(); //  
         
         
        public static string subscriberequestsdetailList
        {
            get
            {
                return resourceProvider_subscriberequestsdetail.GetResource("subscriberequestsdetailList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string subscriberequestsdetailCreate
        {
            get
            {
                return resourceProvider_subscriberequestsdetail.GetResource("subscriberequestsdetailCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string subscriberequestsdetailUpdate
        {
            get
            {
                return resourceProvider_subscriberequestsdetail.GetResource("subscriberequestsdetailUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string subscriberequestsdetailDetails
        {
            get
            {
                return resourceProvider_subscriberequestsdetail.GetResource("subscriberequestsdetailDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string userrequestid
        {
            get
            {
                return resourceProvider_subscriberequestsdetail.GetResource("userrequestid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string userrequestidRequired
        {
            get
            {
                return resourceProvider_subscriberequestsdetail.GetResource("userrequestidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string civilid
        {
            get
            {
                return resourceProvider_subscriberequestsdetail.GetResource("civilid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string civilidRequired
        {
            get
            {
                return resourceProvider_subscriberequestsdetail.GetResource("civilidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string jsondata
        {
            get
            {
                return resourceProvider_subscriberequestsdetail.GetResource("jsondata", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        
      
    }
}
