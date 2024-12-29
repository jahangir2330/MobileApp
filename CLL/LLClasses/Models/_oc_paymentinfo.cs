using System;
using System.Globalization;
using System.IO;
using CLL.Abstract;

namespace CLL.LLClasses.Models
{
    
    public  class _oc_paymentinfo : _Common
    {
         private static IResourceProvider resourceProvider_oc_paymentinfo = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"LanguagesFiles/_oc_paymentinfo.xml"));//DbResourceProvider(); //  
         
         
        public static string paymentinfoList
        {
            get
            {
                return resourceProvider_oc_paymentinfo.GetResource("paymentinfoList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string paymentinfoCreate
        {
            get
            {
                return resourceProvider_oc_paymentinfo.GetResource("paymentinfoCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string paymentinfoUpdate
        {
            get
            {
                return resourceProvider_oc_paymentinfo.GetResource("paymentinfoUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string paymentinfoDetails
        {
            get
            {
                return resourceProvider_oc_paymentinfo.GetResource("paymentinfoDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string transactioncode
        {
            get
            {
                return resourceProvider_oc_paymentinfo.GetResource("transactioncode", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string transactioncodeRequired
        {
            get
            {
                return resourceProvider_oc_paymentinfo.GetResource("transactioncodeRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string memberregistrationid
        {
            get
            {
                return resourceProvider_oc_paymentinfo.GetResource("memberregistrationid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string memberregistrationidRequired
        {
            get
            {
                return resourceProvider_oc_paymentinfo.GetResource("memberregistrationidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string ocfileid
        {
            get
            {
                return resourceProvider_oc_paymentinfo.GetResource("ocfileid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string ocfileidRequired
        {
            get
            {
                return resourceProvider_oc_paymentinfo.GetResource("ocfileidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string transactiondate
        {
            get
            {
                return resourceProvider_oc_paymentinfo.GetResource("transactiondate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string transactiondateRequired
        {
            get
            {
                return resourceProvider_oc_paymentinfo.GetResource("transactiondateRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string transactionselectedmonth
        {
            get
            {
                return resourceProvider_oc_paymentinfo.GetResource("transactionselectedmonth", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string transactionselectedyear
        {
            get
            {
                return resourceProvider_oc_paymentinfo.GetResource("transactionselectedyear", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string paymenttransactioncode
        {
            get
            {
                return resourceProvider_oc_paymentinfo.GetResource("paymenttransactioncode", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string paymenttransactioncodeRequired
        {
            get
            {
                return resourceProvider_oc_paymentinfo.GetResource("paymenttransactioncodeRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string paysuccess
        {
            get
            {
                return resourceProvider_oc_paymentinfo.GetResource("paysuccess", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string paydate
        {
            get
            {
                return resourceProvider_oc_paymentinfo.GetResource("paydate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string amount
        {
            get
            {
                return resourceProvider_oc_paymentinfo.GetResource("amount", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string receiptjson
        {
            get
            {
                return resourceProvider_oc_paymentinfo.GetResource("receiptjson", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        
      
    }
}
