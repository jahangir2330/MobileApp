using System;
using System.Globalization;
using System.IO;
using CLL.Abstract;

namespace CLL.LLClasses.Models
{
    
    public  class _trangrvfrontlinesubmitdata : _Common
    {
         private static IResourceProvider resourceProvider_trangrvfrontlinesubmitdata = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"LanguagesFiles/_trangrvfrontlinesubmitdata.xml"));//DbResourceProvider(); //  
         
         
        public static string trangrvfrontlinesubmitdataList
        {
            get
            {
                return resourceProvider_trangrvfrontlinesubmitdata.GetResource("trangrvfrontlinesubmitdataList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string trangrvfrontlinesubmitdataCreate
        {
            get
            {
                return resourceProvider_trangrvfrontlinesubmitdata.GetResource("trangrvfrontlinesubmitdataCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string trangrvfrontlinesubmitdataUpdate
        {
            get
            {
                return resourceProvider_trangrvfrontlinesubmitdata.GetResource("trangrvfrontlinesubmitdataUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string trangrvfrontlinesubmitdataDetails
        {
            get
            {
                return resourceProvider_trangrvfrontlinesubmitdata.GetResource("trangrvfrontlinesubmitdataDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string qrcode
        {
            get
            {
                return resourceProvider_trangrvfrontlinesubmitdata.GetResource("qrcode", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string qrcodeRequired
        {
            get
            {
                return resourceProvider_trangrvfrontlinesubmitdata.GetResource("qrcodeRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string documentnumber
        {
            get
            {
                return resourceProvider_trangrvfrontlinesubmitdata.GetResource("documentnumber", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string documentnumberRequired
        {
            get
            {
                return resourceProvider_trangrvfrontlinesubmitdata.GetResource("documentnumberRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string doccreationdate
        {
            get
            {
                return resourceProvider_trangrvfrontlinesubmitdata.GetResource("doccreationdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string doccreationdateRequired
        {
            get
            {
                return resourceProvider_trangrvfrontlinesubmitdata.GetResource("doccreationdateRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string subject
        {
            get
            {
                return resourceProvider_trangrvfrontlinesubmitdata.GetResource("subject", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string subjectRequired
        {
            get
            {
                return resourceProvider_trangrvfrontlinesubmitdata.GetResource("subjectRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string fullname
        {
            get
            {
                return resourceProvider_trangrvfrontlinesubmitdata.GetResource("fullname", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string fullnameRequired
        {
            get
            {
                return resourceProvider_trangrvfrontlinesubmitdata.GetResource("fullnameRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string mobilenumber
        {
            get
            {
                return resourceProvider_trangrvfrontlinesubmitdata.GetResource("mobilenumber", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string hitfrom
        {
            get
            {
                return resourceProvider_trangrvfrontlinesubmitdata.GetResource("hitfrom", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string hitfromRequired
        {
            get
            {
                return resourceProvider_trangrvfrontlinesubmitdata.GetResource("hitfromRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string civilid
        {
            get
            {
                return resourceProvider_trangrvfrontlinesubmitdata.GetResource("civilid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string civilidRequired
        {
            get
            {
                return resourceProvider_trangrvfrontlinesubmitdata.GetResource("civilidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string militaryid
        {
            get
            {
                return resourceProvider_trangrvfrontlinesubmitdata.GetResource("militaryid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string rankid
        {
            get
            {
                return resourceProvider_trangrvfrontlinesubmitdata.GetResource("rankid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string rankname
        {
            get
            {
                return resourceProvider_trangrvfrontlinesubmitdata.GetResource("rankname", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string positionid
        {
            get
            {
                return resourceProvider_trangrvfrontlinesubmitdata.GetResource("positionid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string positionname
        {
            get
            {
                return resourceProvider_trangrvfrontlinesubmitdata.GetResource("positionname", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string unitid
        {
            get
            {
                return resourceProvider_trangrvfrontlinesubmitdata.GetResource("unitid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string unitname
        {
            get
            {
                return resourceProvider_trangrvfrontlinesubmitdata.GetResource("unitname", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string subunitid
        {
            get
            {
                return resourceProvider_trangrvfrontlinesubmitdata.GetResource("subunitid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string subunitname
        {
            get
            {
                return resourceProvider_trangrvfrontlinesubmitdata.GetResource("subunitname", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string pdfurl
        {
            get
            {
                return resourceProvider_trangrvfrontlinesubmitdata.GetResource("pdfurl", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string comment
        {
            get
            {
                return resourceProvider_trangrvfrontlinesubmitdata.GetResource("comment", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string isreviewed
        {
            get
            {
                return resourceProvider_trangrvfrontlinesubmitdata.GetResource("isreviewed", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string revieweddate
        {
            get
            {
                return resourceProvider_trangrvfrontlinesubmitdata.GetResource("revieweddate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string reviewednote
        {
            get
            {
                return resourceProvider_trangrvfrontlinesubmitdata.GetResource("reviewednote", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string email
        {
            get
            {
                return resourceProvider_trangrvfrontlinesubmitdata.GetResource("email", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string hrbasicid
        {
            get
            {
                return resourceProvider_trangrvfrontlinesubmitdata.GetResource("hrbasicid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        
      
    }
}
