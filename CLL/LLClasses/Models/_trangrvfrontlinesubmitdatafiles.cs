using System;
using System.Globalization;
using System.IO;
using CLL.Abstract;

namespace CLL.LLClasses.Models
{
    
    public  class _trangrvfrontlinesubmitdatafiles : _Common
    {
         private static IResourceProvider resourceProvider_trangrvfrontlinesubmitdatafiles = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"LanguagesFiles/_trangrvfrontlinesubmitdatafiles.xml"));//DbResourceProvider(); //  
         
         
        public static string trangrvfrontlinesubmitdatafilesList
        {
            get
            {
                return resourceProvider_trangrvfrontlinesubmitdatafiles.GetResource("trangrvfrontlinesubmitdatafilesList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string trangrvfrontlinesubmitdatafilesCreate
        {
            get
            {
                return resourceProvider_trangrvfrontlinesubmitdatafiles.GetResource("trangrvfrontlinesubmitdatafilesCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string trangrvfrontlinesubmitdatafilesUpdate
        {
            get
            {
                return resourceProvider_trangrvfrontlinesubmitdatafiles.GetResource("trangrvfrontlinesubmitdatafilesUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string trangrvfrontlinesubmitdatafilesDetails
        {
            get
            {
                return resourceProvider_trangrvfrontlinesubmitdatafiles.GetResource("trangrvfrontlinesubmitdatafilesDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string grvfrontlineid
        {
            get
            {
                return resourceProvider_trangrvfrontlinesubmitdatafiles.GetResource("grvfrontlineid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string grvfrontlineidRequired
        {
            get
            {
                return resourceProvider_trangrvfrontlinesubmitdatafiles.GetResource("grvfrontlineidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string fileurl
        {
            get
            {
                return resourceProvider_trangrvfrontlinesubmitdatafiles.GetResource("fileurl", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string fileurlRequired
        {
            get
            {
                return resourceProvider_trangrvfrontlinesubmitdatafiles.GetResource("fileurlRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string filename
        {
            get
            {
                return resourceProvider_trangrvfrontlinesubmitdatafiles.GetResource("filename", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string filenameRequired
        {
            get
            {
                return resourceProvider_trangrvfrontlinesubmitdatafiles.GetResource("filenameRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string fileextension
        {
            get
            {
                return resourceProvider_trangrvfrontlinesubmitdatafiles.GetResource("fileextension", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string fileextensionRequired
        {
            get
            {
                return resourceProvider_trangrvfrontlinesubmitdatafiles.GetResource("fileextensionRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        
      
    }
}
