using System;
using System.Runtime.Serialization;
using System.Data;
using BDO.Core.Base;
using System.ComponentModel.DataAnnotations;


namespace BDO.Core.DataAccessObjects.Models
{
    [Serializable]
    [DataContract(Name = "trangrvfrontlinesubmitdataEntity", Namespace = "http://www.KAF.com/types")]
    public partial class trangrvfrontlinesubmitdataEntity : BaseEntity
    {
        #region Properties
    
        protected long ? _grvfrontlineid;
        protected string _qrcode;
        protected string _documentnumber;
        protected DateTime ? _doccreationdate;
        protected string _subject;
        protected string _fullname;
        protected string _mobilenumber;
        protected string _hitfrom;
        protected long ? _civilid;
        protected long ? _militaryid;
        protected long ? _rankid;
        protected string _rankname;
        protected long ? _positionid;
        protected string _positionname;
        protected long ? _unitid;
        protected string _unitname;
        protected long ? _subunitid;
        protected string _subunitname;
        protected string _pdfurl;
        protected string _comment;
        protected bool ? _isreviewed;
        protected DateTime ? _revieweddate;
        protected string _reviewednote;
        protected string _email;
        protected long ? _hrbasicid;
                
        
        [DataMember]
        public long ? grvfrontlineid
        {
            get { return _grvfrontlineid; }
            set { _grvfrontlineid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(150)]
        [Display(Name = "qrcode", ResourceType = typeof(CLL.LLClasses.Models._trangrvfrontlinesubmitdata))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._trangrvfrontlinesubmitdata), ErrorMessageResourceName = "qrcodeRequired")]
        public string qrcode
        {
            get { return _qrcode; }
            set { _qrcode = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(50)]
        [Display(Name = "documentnumber", ResourceType = typeof(CLL.LLClasses.Models._trangrvfrontlinesubmitdata))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._trangrvfrontlinesubmitdata), ErrorMessageResourceName = "documentnumberRequired")]
        public string documentnumber
        {
            get { return _documentnumber; }
            set { _documentnumber = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "doccreationdate", ResourceType = typeof(CLL.LLClasses.Models._trangrvfrontlinesubmitdata))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._trangrvfrontlinesubmitdata), ErrorMessageResourceName = "doccreationdateRequired")]
        public DateTime ? doccreationdate
        {
            get { return _doccreationdate; }
            set { _doccreationdate = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(150)]
        [Display(Name = "subject", ResourceType = typeof(CLL.LLClasses.Models._trangrvfrontlinesubmitdata))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._trangrvfrontlinesubmitdata), ErrorMessageResourceName = "subjectRequired")]
        public string subject
        {
            get { return _subject; }
            set { _subject = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(150)]
        [Display(Name = "fullname", ResourceType = typeof(CLL.LLClasses.Models._trangrvfrontlinesubmitdata))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._trangrvfrontlinesubmitdata), ErrorMessageResourceName = "fullnameRequired")]
        public string fullname
        {
            get { return _fullname; }
            set { _fullname = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(50)]
        [Display(Name = "mobilenumber", ResourceType = typeof(CLL.LLClasses.Models._trangrvfrontlinesubmitdata))]
        public string mobilenumber
        {
            get { return _mobilenumber; }
            set { _mobilenumber = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(50)]
        [Display(Name = "hitfrom", ResourceType = typeof(CLL.LLClasses.Models._trangrvfrontlinesubmitdata))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._trangrvfrontlinesubmitdata), ErrorMessageResourceName = "hitfromRequired")]
        public string hitfrom
        {
            get { return _hitfrom; }
            set { _hitfrom = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "civilid", ResourceType = typeof(CLL.LLClasses.Models._trangrvfrontlinesubmitdata))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._trangrvfrontlinesubmitdata), ErrorMessageResourceName = "civilidRequired")]
        public long ? civilid
        {
            get { return _civilid; }
            set { _civilid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "militaryid", ResourceType = typeof(CLL.LLClasses.Models._trangrvfrontlinesubmitdata))]
        public long ? militaryid
        {
            get { return _militaryid; }
            set { _militaryid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "rankid", ResourceType = typeof(CLL.LLClasses.Models._trangrvfrontlinesubmitdata))]
        public long ? rankid
        {
            get { return _rankid; }
            set { _rankid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(150)]
        [Display(Name = "rankname", ResourceType = typeof(CLL.LLClasses.Models._trangrvfrontlinesubmitdata))]
        public string rankname
        {
            get { return _rankname; }
            set { _rankname = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "positionid", ResourceType = typeof(CLL.LLClasses.Models._trangrvfrontlinesubmitdata))]
        public long ? positionid
        {
            get { return _positionid; }
            set { _positionid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(150)]
        [Display(Name = "positionname", ResourceType = typeof(CLL.LLClasses.Models._trangrvfrontlinesubmitdata))]
        public string positionname
        {
            get { return _positionname; }
            set { _positionname = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "unitid", ResourceType = typeof(CLL.LLClasses.Models._trangrvfrontlinesubmitdata))]
        public long ? unitid
        {
            get { return _unitid; }
            set { _unitid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(150)]
        [Display(Name = "unitname", ResourceType = typeof(CLL.LLClasses.Models._trangrvfrontlinesubmitdata))]
        public string unitname
        {
            get { return _unitname; }
            set { _unitname = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "subunitid", ResourceType = typeof(CLL.LLClasses.Models._trangrvfrontlinesubmitdata))]
        public long ? subunitid
        {
            get { return _subunitid; }
            set { _subunitid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(150)]
        [Display(Name = "subunitname", ResourceType = typeof(CLL.LLClasses.Models._trangrvfrontlinesubmitdata))]
        public string subunitname
        {
            get { return _subunitname; }
            set { _subunitname = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(350)]
        [Display(Name = "pdfurl", ResourceType = typeof(CLL.LLClasses.Models._trangrvfrontlinesubmitdata))]
        public string pdfurl
        {
            get { return _pdfurl; }
            set { _pdfurl = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(-1)]
        [Display(Name = "comment", ResourceType = typeof(CLL.LLClasses.Models._trangrvfrontlinesubmitdata))]
        public string comment
        {
            get { return _comment; }
            set { _comment = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "isreviewed", ResourceType = typeof(CLL.LLClasses.Models._trangrvfrontlinesubmitdata))]
        public bool ? isreviewed
        {
            get { return _isreviewed; }
            set { _isreviewed = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "revieweddate", ResourceType = typeof(CLL.LLClasses.Models._trangrvfrontlinesubmitdata))]
        public DateTime ? revieweddate
        {
            get { return _revieweddate; }
            set { _revieweddate = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(550)]
        [Display(Name = "reviewednote", ResourceType = typeof(CLL.LLClasses.Models._trangrvfrontlinesubmitdata))]
        public string reviewednote
        {
            get { return _reviewednote; }
            set { _reviewednote = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(150)]
        [Display(Name = "email", ResourceType = typeof(CLL.LLClasses.Models._trangrvfrontlinesubmitdata))]
        public string email
        {
            get { return _email; }
            set { _email = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "hrbasicid", ResourceType = typeof(CLL.LLClasses.Models._trangrvfrontlinesubmitdata))]
        public long ? hrbasicid
        {
            get { return _hrbasicid; }
            set { _hrbasicid = value; this.OnChnaged(); }
        }
        
        
        #endregion
    
        #region Constructor
    
        public trangrvfrontlinesubmitdataEntity():base()
        {
        }
        
        public trangrvfrontlinesubmitdataEntity(IDataReader reader)
        {
            this.LoadFromReader(reader);
        }
        
         public trangrvfrontlinesubmitdataEntity(IDataReader reader, bool IsListViewShow)
        {
            this.LoadFromReader(reader, IsListViewShow);
        }
        
      
        
        protected void LoadFromReader(IDataReader reader)
        {
            if (reader != null && !reader.IsClosed)
            {
                this.BaseSecurityParam = new SecurityCapsule();
                if (!reader.IsDBNull(reader.GetOrdinal("GrvFrontLineID"))) _grvfrontlineid = reader.GetInt64(reader.GetOrdinal("GrvFrontLineID"));
                if (!reader.IsDBNull(reader.GetOrdinal("QRCode"))) _qrcode = reader.GetString(reader.GetOrdinal("QRCode"));
                if (!reader.IsDBNull(reader.GetOrdinal("DocumentNumber"))) _documentnumber = reader.GetString(reader.GetOrdinal("DocumentNumber"));
                if (!reader.IsDBNull(reader.GetOrdinal("DocCreationDate"))) _doccreationdate = reader.GetDateTime(reader.GetOrdinal("DocCreationDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("Subject"))) _subject = reader.GetString(reader.GetOrdinal("Subject"));
                if (!reader.IsDBNull(reader.GetOrdinal("FullName"))) _fullname = reader.GetString(reader.GetOrdinal("FullName"));
                if (!reader.IsDBNull(reader.GetOrdinal("MobileNumber"))) _mobilenumber = reader.GetString(reader.GetOrdinal("MobileNumber"));
                if (!reader.IsDBNull(reader.GetOrdinal("HitFrom"))) _hitfrom = reader.GetString(reader.GetOrdinal("HitFrom"));
                if (!reader.IsDBNull(reader.GetOrdinal("CivilID"))) _civilid = reader.GetInt64(reader.GetOrdinal("CivilID"));
                if (!reader.IsDBNull(reader.GetOrdinal("MilitaryID"))) _militaryid = reader.GetInt64(reader.GetOrdinal("MilitaryID"));
                if (!reader.IsDBNull(reader.GetOrdinal("RankID"))) _rankid = reader.GetInt64(reader.GetOrdinal("RankID"));
                if (!reader.IsDBNull(reader.GetOrdinal("RankName"))) _rankname = reader.GetString(reader.GetOrdinal("RankName"));
                if (!reader.IsDBNull(reader.GetOrdinal("PositionID"))) _positionid = reader.GetInt64(reader.GetOrdinal("PositionID"));
                if (!reader.IsDBNull(reader.GetOrdinal("PositionName"))) _positionname = reader.GetString(reader.GetOrdinal("PositionName"));
                if (!reader.IsDBNull(reader.GetOrdinal("UnitID"))) _unitid = reader.GetInt64(reader.GetOrdinal("UnitID"));
                if (!reader.IsDBNull(reader.GetOrdinal("UnitName"))) _unitname = reader.GetString(reader.GetOrdinal("UnitName"));
                if (!reader.IsDBNull(reader.GetOrdinal("SubUnitID"))) _subunitid = reader.GetInt64(reader.GetOrdinal("SubUnitID"));
                if (!reader.IsDBNull(reader.GetOrdinal("SubUnitName"))) _subunitname = reader.GetString(reader.GetOrdinal("SubUnitName"));
                if (!reader.IsDBNull(reader.GetOrdinal("PDFURL"))) _pdfurl = reader.GetString(reader.GetOrdinal("PDFURL"));
                if (!reader.IsDBNull(reader.GetOrdinal("Comment"))) _comment = reader.GetString(reader.GetOrdinal("Comment"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsReviewed"))) _isreviewed = reader.GetBoolean(reader.GetOrdinal("IsReviewed"));
                if (!reader.IsDBNull(reader.GetOrdinal("ReviewedDate"))) _revieweddate = reader.GetDateTime(reader.GetOrdinal("ReviewedDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("ReviewedNote"))) _reviewednote = reader.GetString(reader.GetOrdinal("ReviewedNote"));
                if (!reader.IsDBNull(reader.GetOrdinal("TransID"))) this.BaseSecurityParam.transid = reader.GetString(reader.GetOrdinal("TransID"));
                if (!reader.IsDBNull(reader.GetOrdinal("CreatedByUserName"))) this.BaseSecurityParam.createdbyusername = reader.GetString(reader.GetOrdinal("CreatedByUserName"));
                if (!reader.IsDBNull(reader.GetOrdinal("CreatedDate"))) this.BaseSecurityParam.createddate = reader.GetDateTime(reader.GetOrdinal("CreatedDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("UpdatedByUserName"))) this.BaseSecurityParam.updatedbyusername = reader.GetString(reader.GetOrdinal("UpdatedByUserName"));
                if (!reader.IsDBNull(reader.GetOrdinal("UpdatedDate"))) this.BaseSecurityParam.updateddate = reader.GetDateTime(reader.GetOrdinal("UpdatedDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("IPAddress"))) this.BaseSecurityParam.ipaddress = reader.GetString(reader.GetOrdinal("IPAddress"));
                if (!reader.IsDBNull(reader.GetOrdinal("TS"))) this.BaseSecurityParam.ts = reader.GetInt64(reader.GetOrdinal("ts"));
                if (!reader.IsDBNull(reader.GetOrdinal("Email"))) _email = reader.GetString(reader.GetOrdinal("Email"));
                if (!reader.IsDBNull(reader.GetOrdinal("HRBasicID"))) _hrbasicid = reader.GetInt64(reader.GetOrdinal("HRBasicID"));
                CurrentState = EntityState.Unchanged;
            }
        }


        protected void LoadFromReader(IDataReader reader, bool IsListViewShow)
        {
            if (reader != null && !reader.IsClosed)
            {
                this.BaseSecurityParam = new SecurityCapsule();
                if (!reader.IsDBNull(reader.GetOrdinal("GrvFrontLineID"))) _grvfrontlineid = reader.GetInt64(reader.GetOrdinal("GrvFrontLineID"));
                if (!reader.IsDBNull(reader.GetOrdinal("QRCode"))) _qrcode = reader.GetString(reader.GetOrdinal("QRCode"));
                if (!reader.IsDBNull(reader.GetOrdinal("DocumentNumber"))) _documentnumber = reader.GetString(reader.GetOrdinal("DocumentNumber"));
                if (!reader.IsDBNull(reader.GetOrdinal("DocCreationDate"))) _doccreationdate = reader.GetDateTime(reader.GetOrdinal("DocCreationDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("Subject"))) _subject = reader.GetString(reader.GetOrdinal("Subject"));
                if (!reader.IsDBNull(reader.GetOrdinal("FullName"))) _fullname = reader.GetString(reader.GetOrdinal("FullName"));
                if (!reader.IsDBNull(reader.GetOrdinal("MobileNumber"))) _mobilenumber = reader.GetString(reader.GetOrdinal("MobileNumber"));
                if (!reader.IsDBNull(reader.GetOrdinal("HitFrom"))) _hitfrom = reader.GetString(reader.GetOrdinal("HitFrom"));
                if (!reader.IsDBNull(reader.GetOrdinal("CivilID"))) _civilid = reader.GetInt64(reader.GetOrdinal("CivilID"));
                if (!reader.IsDBNull(reader.GetOrdinal("MilitaryID"))) _militaryid = reader.GetInt64(reader.GetOrdinal("MilitaryID"));
                if (!reader.IsDBNull(reader.GetOrdinal("RankID"))) _rankid = reader.GetInt64(reader.GetOrdinal("RankID"));
                if (!reader.IsDBNull(reader.GetOrdinal("RankName"))) _rankname = reader.GetString(reader.GetOrdinal("RankName"));
                if (!reader.IsDBNull(reader.GetOrdinal("PositionID"))) _positionid = reader.GetInt64(reader.GetOrdinal("PositionID"));
                if (!reader.IsDBNull(reader.GetOrdinal("PositionName"))) _positionname = reader.GetString(reader.GetOrdinal("PositionName"));
                if (!reader.IsDBNull(reader.GetOrdinal("UnitID"))) _unitid = reader.GetInt64(reader.GetOrdinal("UnitID"));
                if (!reader.IsDBNull(reader.GetOrdinal("UnitName"))) _unitname = reader.GetString(reader.GetOrdinal("UnitName"));
                if (!reader.IsDBNull(reader.GetOrdinal("SubUnitID"))) _subunitid = reader.GetInt64(reader.GetOrdinal("SubUnitID"));
                if (!reader.IsDBNull(reader.GetOrdinal("SubUnitName"))) _subunitname = reader.GetString(reader.GetOrdinal("SubUnitName"));
                if (!reader.IsDBNull(reader.GetOrdinal("PDFURL"))) _pdfurl = reader.GetString(reader.GetOrdinal("PDFURL"));
                if (!reader.IsDBNull(reader.GetOrdinal("Comment"))) _comment = reader.GetString(reader.GetOrdinal("Comment"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsReviewed"))) _isreviewed = reader.GetBoolean(reader.GetOrdinal("IsReviewed"));
                if (!reader.IsDBNull(reader.GetOrdinal("ReviewedDate"))) _revieweddate = reader.GetDateTime(reader.GetOrdinal("ReviewedDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("ReviewedNote"))) _reviewednote = reader.GetString(reader.GetOrdinal("ReviewedNote"));
                if (!reader.IsDBNull(reader.GetOrdinal("TransID"))) this.BaseSecurityParam.transid = reader.GetString(reader.GetOrdinal("TransID"));
                if (!reader.IsDBNull(reader.GetOrdinal("CreatedByUserName"))) this.BaseSecurityParam.createdbyusername = reader.GetString(reader.GetOrdinal("CreatedByUserName"));
                if (!reader.IsDBNull(reader.GetOrdinal("CreatedDate"))) this.BaseSecurityParam.createddate = reader.GetDateTime(reader.GetOrdinal("CreatedDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("UpdatedByUserName"))) this.BaseSecurityParam.updatedbyusername = reader.GetString(reader.GetOrdinal("UpdatedByUserName"));
                if (!reader.IsDBNull(reader.GetOrdinal("UpdatedDate"))) this.BaseSecurityParam.updateddate = reader.GetDateTime(reader.GetOrdinal("UpdatedDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("IPAddress"))) this.BaseSecurityParam.ipaddress = reader.GetString(reader.GetOrdinal("IPAddress"));
                if (!reader.IsDBNull(reader.GetOrdinal("TS"))) this.BaseSecurityParam.ts = reader.GetInt64(reader.GetOrdinal("ts"));
                if (!reader.IsDBNull(reader.GetOrdinal("Email"))) _email = reader.GetString(reader.GetOrdinal("Email"));
                if (!reader.IsDBNull(reader.GetOrdinal("HRBasicID"))) _hrbasicid = reader.GetInt64(reader.GetOrdinal("HRBasicID"));
                CurrentState = EntityState.Unchanged;
            }
        }
        
        #endregion
        
        
            
    }
}
