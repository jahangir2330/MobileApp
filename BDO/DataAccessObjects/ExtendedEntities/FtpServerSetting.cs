using System;
using System.Collections.Generic;
using System.Text;

namespace BDO.Core.DataAccessObjects.ExtendedEntities
{
    public class FtpServerSetting
    {
        public string UploadFtpUrl { get; set; }
        public string ReadFileUrl { get; set; }

        public string FtpUser { get; set; }
        public string FtpUserPassword { get; set; }
        public string DownloadFolderPath { get; set; }
        public double MaximumImageSize { get; set; }
        public double MaximumPdfFileSize { get; set; }
        public double MaximumZipFileSize { get; set; }
        public bool IsSSL { get; set; }
    }
}
