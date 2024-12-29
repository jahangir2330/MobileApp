using System;
using System.Runtime.Serialization;
using System.Data;
using BDO.Core.Base;
using System.ComponentModel.DataAnnotations;
using KAF.BusinessDataObjects;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using BDO.Core.DataAccessObjects.CommonEntities;

namespace BDO.Core.DataAccessObjects.Models
{
    public partial class gen_exchangedocumentEntity
    {


        #region Region Image
        protected reg_studentfilestorageEntity _fileuploadList;
        protected string _contractdocumentfilepath;
        protected long? _companyid;
        protected string _companyname;
        protected string _companynamear;

        [DataMember]
        [MaxLength(550)]
        public string contractdocumentfilepath
        {
            get { return _contractdocumentfilepath; }
            set { _contractdocumentfilepath = value; this.OnChnaged(); }
        }

        [DataMember]
        public reg_studentfilestorageEntity fileuploadList { get => _fileuploadList; set => _fileuploadList = value; }


        [DataMember]
        public long? companyid
        {
            get { return _companyid; }
            set { _companyid = value; this.OnChnaged(); }
        }

        [DataMember]
        [MaxLength(550)]
        public string companyname
        {
            get { return _companyname; }
            set { _companyname = value; this.OnChnaged(); }
        }
        [DataMember]
        [MaxLength(550)]
        public string companynamear
        {
            get { return _companynamear; }
            set { _companynamear = value; this.OnChnaged(); }
        }
        #endregion Region Image

        protected string _jsonStrFileUploadData;
        [DataMember]
        public string jsonStrFileUploadData
        {
            get { return _jsonStrFileUploadData; }
            set { _jsonStrFileUploadData = value; }
        }

        private IFormFile formfile1;
        [DataMember] public IFormFile formfile { get => formfile1; set => formfile1 = value; }
        public gen_exchangedocumentEntity(IDataReader reader, bool IsListViewShow, bool relationaldata)
        {
            this.LoadFromReader(reader, IsListViewShow, relationaldata);
        }
        protected void LoadFromReader(IDataReader reader, bool IsListViewShow, bool relationaldata)
        {
            if (reader != null && !reader.IsClosed)
            {
                this.BaseSecurityParam = new SecurityCapsule();
                if (!reader.IsDBNull(reader.GetOrdinal("ExchangeDocumentID"))) _exchangedocumentid = reader.GetInt64(reader.GetOrdinal("ExchangeDocumentID"));
                if (!reader.IsDBNull(reader.GetOrdinal("ExchangeDocumentTitleAR"))) _exchangedocumenttitlear = reader.GetString(reader.GetOrdinal("ExchangeDocumentTitleAR"));
                if (!reader.IsDBNull(reader.GetOrdinal("ExchangeDocumentTitleEN"))) _exchangedocumenttitleen = reader.GetString(reader.GetOrdinal("ExchangeDocumentTitleEN"));
                if (!reader.IsDBNull(reader.GetOrdinal("ExchangeDocumentDescAR"))) _exchangedocumentdescar = reader.GetString(reader.GetOrdinal("ExchangeDocumentDescAR"));
                if (!reader.IsDBNull(reader.GetOrdinal("ExchangeDocumentDescEN"))) _exchangedocumentdescen = reader.GetString(reader.GetOrdinal("ExchangeDocumentDescEN"));
                if (!reader.IsDBNull(reader.GetOrdinal("FilePath"))) _filepath = reader.GetString(reader.GetOrdinal("FilePath"));
                if (!reader.IsDBNull(reader.GetOrdinal("FileType"))) _filetype = reader.GetString(reader.GetOrdinal("FileType"));
                if (!reader.IsDBNull(reader.GetOrdinal("FileExtension"))) _fileextension = reader.GetString(reader.GetOrdinal("FileExtension"));
                if (!reader.IsDBNull(reader.GetOrdinal("ActualFileName"))) _actualfilename = reader.GetString(reader.GetOrdinal("ActualFileName"));
                if (!reader.IsDBNull(reader.GetOrdinal("FileName"))) _filename = reader.GetString(reader.GetOrdinal("FileName"));
                if (!reader.IsDBNull(reader.GetOrdinal("QRCode"))) _qrcode = reader.GetString(reader.GetOrdinal("QRCode"));
                if (!reader.IsDBNull(reader.GetOrdinal("RequestApplicationID"))) _requestapplicationid = reader.GetInt64(reader.GetOrdinal("RequestApplicationID"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsActive"))) _isactive = reader.GetBoolean(reader.GetOrdinal("IsActive"));
                if (!reader.IsDBNull(reader.GetOrdinal("TransID"))) this.BaseSecurityParam.transid = reader.GetString(reader.GetOrdinal("TransID"));
                if (!reader.IsDBNull(reader.GetOrdinal("CreatedByUserName"))) this.BaseSecurityParam.createdbyusername = reader.GetString(reader.GetOrdinal("CreatedByUserName"));
                if (!reader.IsDBNull(reader.GetOrdinal("CreatedDate"))) this.BaseSecurityParam.createddate = reader.GetDateTime(reader.GetOrdinal("CreatedDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("UpdatedByUserName"))) this.BaseSecurityParam.updatedbyusername = reader.GetString(reader.GetOrdinal("UpdatedByUserName"));
                if (!reader.IsDBNull(reader.GetOrdinal("UpdatedDate"))) this.BaseSecurityParam.updateddate = reader.GetDateTime(reader.GetOrdinal("UpdatedDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("IPAddress"))) this.BaseSecurityParam.ipaddress = reader.GetString(reader.GetOrdinal("IPAddress"));
                if (!reader.IsDBNull(reader.GetOrdinal("TS"))) this.BaseSecurityParam.ts = reader.GetInt64(reader.GetOrdinal("ts"));
                if (!reader.IsDBNull(reader.GetOrdinal("CompanyId"))) _companyid = reader.GetInt64(reader.GetOrdinal("CompanyId"));
                if (!reader.IsDBNull(reader.GetOrdinal("CompanyName"))) _companyname = reader.GetString(reader.GetOrdinal("CompanyName"));
                if (!reader.IsDBNull(reader.GetOrdinal("CompanyNameAr"))) _companynamear = reader.GetString(reader.GetOrdinal("CompanyNameAr"));

                CurrentState = EntityState.Unchanged;
            }
        }

    }


    public class dtexchangedocument : DtParameters
    {
        protected long? _requestapplicationid;

        [DataMember]
        public long? requestapplicationid
        {
            get { return _requestapplicationid; }
            set { _requestapplicationid = value; this.OnChnaged(); }
        }
    }
}
