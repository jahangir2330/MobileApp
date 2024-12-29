using System;
using System.Runtime.Serialization;
using System.Data;
using BDO.Core.Base;
using System.ComponentModel.DataAnnotations;


namespace BDO.Core.DataAccessObjects.Models
{
    [Serializable]
    [DataContract(Name = "gen_exchangedocumentEntity", Namespace = "http://www.KAF.com/types")]
    public partial class gen_exchangedocumentEntity : BaseEntity
    {
        #region Properties
        
        protected long? _exchangedocumentid;
        protected string _exchangedocumenttitlear;
        protected string _exchangedocumenttitleen;
        protected string _exchangedocumentdescar;
        protected string _exchangedocumentdescen;
        protected string _filepath;
        protected string _filetype;
        protected string _fileextension;
        protected string _actualfilename;
        protected string _filename;
        protected string _qrcode;
        protected bool? _isactive;
        protected long? _requestapplicationid;

        [DataMember]
        public long? exchangedocumentid
        {
            get { return _exchangedocumentid; }
            set { _exchangedocumentid = value; this.OnChnaged(); }
        }

        [DataMember]
        [MaxLength(550)]
        [Display(Name = "exchangedocumenttitlear", ResourceType = typeof(CLL.LLClasses.Models._exchangedocument))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._exchangedocument), ErrorMessageResourceName = "exchangedocumenttitlearRequired")]
        public string exchangedocumenttitlear
        {
            get { return _exchangedocumenttitlear; }
            set { _exchangedocumenttitlear = value; this.OnChnaged(); }
        }

        [DataMember]
        [MaxLength(550)]
        [Display(Name = "exchangedocumenttitleen", ResourceType = typeof(CLL.LLClasses.Models._exchangedocument))]
        public string exchangedocumenttitleen
        {
            get { return _exchangedocumenttitleen; }
            set { _exchangedocumenttitleen = value; this.OnChnaged(); }
        }

        [DataMember]
        [MaxLength(1050)]
        [Display(Name = "exchangedocumentdescar", ResourceType = typeof(CLL.LLClasses.Models._exchangedocument))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._exchangedocument), ErrorMessageResourceName = "exchangedocumentdescarRequired")]
        public string exchangedocumentdescar
        {
            get { return _exchangedocumentdescar; }
            set { _exchangedocumentdescar = value; this.OnChnaged(); }
        }

        [DataMember]
        [MaxLength(1050)]
        [Display(Name = "exchangedocumentdescen", ResourceType = typeof(CLL.LLClasses.Models._exchangedocument))]
        public string exchangedocumentdescen
        {
            get { return _exchangedocumentdescen; }
            set { _exchangedocumentdescen = value; this.OnChnaged(); }
        }

        [DataMember]
        [MaxLength(250)]
        [Display(Name = "filepath", ResourceType = typeof(CLL.LLClasses.Models._exchangedocument))]
        public string filepath
        {
            get { return _filepath; }
            set { _filepath = value; this.OnChnaged(); }
        }

        [DataMember]
        [MaxLength(150)]
        [Display(Name = "filetype", ResourceType = typeof(CLL.LLClasses.Models._exchangedocument))]
        public string filetype
        {
            get { return _filetype; }
            set { _filetype = value; this.OnChnaged(); }
        }

        [DataMember]
        [MaxLength(10)]
        [Display(Name = "fileextension", ResourceType = typeof(CLL.LLClasses.Models._exchangedocument))]
        public string fileextension
        {
            get { return _fileextension; }
            set { _fileextension = value; this.OnChnaged(); }
        }

        [DataMember]
        [MaxLength(500)]
        [Display(Name = "actualfilename", ResourceType = typeof(CLL.LLClasses.Models._exchangedocument))]
        public string actualfilename
        {
            get { return _actualfilename; }
            set { _actualfilename = value; this.OnChnaged(); }
        }

        [DataMember]
        [MaxLength(500)]
        [Display(Name = "filename", ResourceType = typeof(CLL.LLClasses.Models._exchangedocument))]
        public string filename
        {
            get { return _filename; }
            set { _filename = value; this.OnChnaged(); }
        }

        [DataMember]
        [MaxLength(350)]
        [Display(Name = "qrcode", ResourceType = typeof(CLL.LLClasses.Models._exchangedocument))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._exchangedocument), ErrorMessageResourceName = "qrcodeRequired")]
        public string qrcode
        {
            get { return _qrcode; }
            set { _qrcode = value; this.OnChnaged(); }
        }

        [DataMember]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._tran_applicationreqforemp), ErrorMessageResourceName = "requestapplicationidRequired")]
        public long? requestapplicationid
        {
            get { return _requestapplicationid; }
            set { _requestapplicationid = value; this.OnChnaged(); }
        }
        [DataMember]
        [Display(Name = "isactive", ResourceType = typeof(CLL.LLClasses.Models._gen_requester))]
        public bool? isactive
        {
            get { return _isactive; }
            set { _isactive = value; this.OnChnaged(); }
        }

        #endregion

        #region Constructor

        public gen_exchangedocumentEntity() : base()
        {
        }

        public gen_exchangedocumentEntity(IDataReader reader)
        {
            this.LoadFromReader(reader);
        }

        public gen_exchangedocumentEntity(IDataReader reader, bool IsListViewShow)
        {
            this.LoadFromReader(reader, IsListViewShow);
        }



        protected void LoadFromReader(IDataReader reader)
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
                CurrentState = EntityState.Unchanged;
            }
        }


        protected void LoadFromReader(IDataReader reader, bool IsListViewShow)
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
                CurrentState = EntityState.Unchanged;
            }
        }

       
        #endregion



    }
}
