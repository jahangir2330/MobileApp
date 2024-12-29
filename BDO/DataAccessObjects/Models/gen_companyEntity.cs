using System;
using System.Runtime.Serialization;
using System.Data;
using BDO.Core.Base;
using System.ComponentModel.DataAnnotations;


namespace BDO.Core.DataAccessObjects.Models
{
    [Serializable]
    [DataContract(Name = "gen_companyEntity", Namespace = "http://www.KAF.com/types")]
    public partial class gen_companyEntity : BaseEntity
    {
        #region Properties
    
        protected long ? _companyid;
        protected string _companyname;
        protected string _companynamear;
        protected long ? _companytypeid;
        protected string _companymobileno;
        protected string _companyemailaddress;
        protected string _companywebsite;
        protected string _companyaddress;
        protected bool ? _isblockednow;
        protected bool ? _isactive;
        protected string _remarks;
        protected string _updateinfo;
        protected long ? _tranformactionid;
                
        
        [DataMember]
        public long ? companyid
        {
            get { return _companyid; }
            set { _companyid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(150)]
        [RegularExpression(@"^[^\u0627-\u0649]+$", ErrorMessageResourceType = typeof(CLL.LLClasses._Common), ErrorMessageResourceName = "Unicodecharactersarenotallowed")]

        [Display(Name = "companyname", ResourceType = typeof(CLL.LLClasses.Models._gen_company))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._gen_company), ErrorMessageResourceName = "companynameRequired")]
        public string companyname
        {
            get { return _companyname; }
            set { _companyname = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(150)]
        [Display(Name = "companynamear", ResourceType = typeof(CLL.LLClasses.Models._gen_company))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._gen_company), ErrorMessageResourceName = "companynamearRequired")]
        public string companynamear
        {
            get { return _companynamear; }
            set { _companynamear = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "companytypeid", ResourceType = typeof(CLL.LLClasses.Models._gen_company))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._gen_company), ErrorMessageResourceName = "companytypeidRequired")]
        public long ? companytypeid
        {
            get { return _companytypeid; }
            set { _companytypeid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(150)]
        [Display(Name = "companymobileno", ResourceType = typeof(CLL.LLClasses.Models._gen_company))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._gen_company), ErrorMessageResourceName = "companymobilenoRequired")]

        public string companymobileno
        {
            get { return _companymobileno; }
            set { _companymobileno = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(150)]
        [Display(Name = "companyemailaddress", ResourceType = typeof(CLL.LLClasses.Models._gen_company))]
        public string companyemailaddress
        {
            get { return _companyemailaddress; }
            set { _companyemailaddress = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(150)]
        [Display(Name = "companywebsite", ResourceType = typeof(CLL.LLClasses.Models._gen_company))]
        public string companywebsite
        {
            get { return _companywebsite; }
            set { _companywebsite = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(550)]
        [Display(Name = "companyaddress", ResourceType = typeof(CLL.LLClasses.Models._gen_company))]
        public string companyaddress
        {
            get { return _companyaddress; }
            set { _companyaddress = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "isactive", ResourceType = typeof(CLL.LLClasses.Models._gen_company))]
        public bool ? isactive
        {
            get { return _isactive; }
            set { _isactive = value; this.OnChnaged(); }
        }
        [DataMember]
        [Display(Name = "isblockednow", ResourceType = typeof(CLL.LLClasses.Models._gen_company))]
        public bool ? isblockednow
        {
            get { return _isblockednow; }
            set { _isblockednow = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(550)]
        [Display(Name = "remarks", ResourceType = typeof(CLL.LLClasses.Models._gen_company))]
        public string remarks
        {
            get { return _remarks; }
            set { _remarks = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(550)]
        [Display(Name = "updateinfo", ResourceType = typeof(CLL.LLClasses.Models._gen_company))]
        public string updateinfo
        {
            get { return _updateinfo; }
            set { _updateinfo = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "tranformactionid", ResourceType = typeof(CLL.LLClasses.Models._gen_company))]
        public long ? tranformactionid
        {
            get { return _tranformactionid; }
            set { _tranformactionid = value; this.OnChnaged(); }
        }
        
        
        #endregion
    
        #region Constructor
    
        public gen_companyEntity():base()
        {
        }
        
        public gen_companyEntity(IDataReader reader)
        {
            this.LoadFromReader(reader);
        }
        
         public gen_companyEntity(IDataReader reader, bool IsListViewShow)
        {
            this.LoadFromReader(reader, IsListViewShow);
        }
        
      
        
        protected void LoadFromReader(IDataReader reader)
        {
            if (reader != null && !reader.IsClosed)
            {
                this.BaseSecurityParam = new SecurityCapsule();
                if (!reader.IsDBNull(reader.GetOrdinal("CompanyID"))) _companyid = reader.GetInt64(reader.GetOrdinal("CompanyID"));
                if (!reader.IsDBNull(reader.GetOrdinal("CompanyName"))) _companyname = reader.GetString(reader.GetOrdinal("CompanyName"));
                if (!reader.IsDBNull(reader.GetOrdinal("CompanyNameAR"))) _companynamear = reader.GetString(reader.GetOrdinal("CompanyNameAR"));
                if (!reader.IsDBNull(reader.GetOrdinal("CompanyTypeID"))) _companytypeid = reader.GetInt64(reader.GetOrdinal("CompanyTypeID"));
                if (!reader.IsDBNull(reader.GetOrdinal("CompanyMobileNo"))) _companymobileno = reader.GetString(reader.GetOrdinal("CompanyMobileNo"));
                if (!reader.IsDBNull(reader.GetOrdinal("CompanyEmailAddress"))) _companyemailaddress = reader.GetString(reader.GetOrdinal("CompanyEmailAddress"));
                if (!reader.IsDBNull(reader.GetOrdinal("CompanyWebsite"))) _companywebsite = reader.GetString(reader.GetOrdinal("CompanyWebsite"));
                if (!reader.IsDBNull(reader.GetOrdinal("CompanyAddress"))) _companyaddress = reader.GetString(reader.GetOrdinal("CompanyAddress"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsBlockedNow"))) _isblockednow = reader.GetBoolean(reader.GetOrdinal("IsBlockedNow"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsActive"))) _isactive = reader.GetBoolean(reader.GetOrdinal("IsActive"));
                if (!reader.IsDBNull(reader.GetOrdinal("Remarks"))) _remarks = reader.GetString(reader.GetOrdinal("Remarks"));
                if (!reader.IsDBNull(reader.GetOrdinal("TransID"))) this.BaseSecurityParam.transid = reader.GetString(reader.GetOrdinal("TransID"));
                if (!reader.IsDBNull(reader.GetOrdinal("CreatedByUserName"))) this.BaseSecurityParam.createdbyusername = reader.GetString(reader.GetOrdinal("CreatedByUserName"));
                if (!reader.IsDBNull(reader.GetOrdinal("CreatedDate"))) this.BaseSecurityParam.createddate = reader.GetDateTime(reader.GetOrdinal("CreatedDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("UpdatedByUserName"))) this.BaseSecurityParam.updatedbyusername = reader.GetString(reader.GetOrdinal("UpdatedByUserName"));
                if (!reader.IsDBNull(reader.GetOrdinal("UpdatedDate"))) this.BaseSecurityParam.updateddate = reader.GetDateTime(reader.GetOrdinal("UpdatedDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("UpdateInfo"))) _updateinfo = reader.GetString(reader.GetOrdinal("UpdateInfo"));
                if (!reader.IsDBNull(reader.GetOrdinal("IPAddress"))) this.BaseSecurityParam.ipaddress = reader.GetString(reader.GetOrdinal("IPAddress"));
                if (!reader.IsDBNull(reader.GetOrdinal("TranFormActionID"))) _tranformactionid = reader.GetInt64(reader.GetOrdinal("TranFormActionID"));
                if (!reader.IsDBNull(reader.GetOrdinal("TS"))) this.BaseSecurityParam.ts = reader.GetInt64(reader.GetOrdinal("ts"));
                CurrentState = EntityState.Unchanged;
            }
        }


        protected void LoadFromReader(IDataReader reader, bool IsListViewShow)
        {
            if (reader != null && !reader.IsClosed)
            {
                this.BaseSecurityParam = new SecurityCapsule();
                if (!reader.IsDBNull(reader.GetOrdinal("CompanyID"))) _companyid = reader.GetInt64(reader.GetOrdinal("CompanyID"));
                if (!reader.IsDBNull(reader.GetOrdinal("CompanyName"))) _companyname = reader.GetString(reader.GetOrdinal("CompanyName"));
                if (!reader.IsDBNull(reader.GetOrdinal("CompanyNameAR"))) _companynamear = reader.GetString(reader.GetOrdinal("CompanyNameAR"));
                if (!reader.IsDBNull(reader.GetOrdinal("CompanyTypeID"))) _companytypeid = reader.GetInt64(reader.GetOrdinal("CompanyTypeID"));
                if (!reader.IsDBNull(reader.GetOrdinal("CompanyMobileNo"))) _companymobileno = reader.GetString(reader.GetOrdinal("CompanyMobileNo"));
                if (!reader.IsDBNull(reader.GetOrdinal("CompanyEmailAddress"))) _companyemailaddress = reader.GetString(reader.GetOrdinal("CompanyEmailAddress"));
                if (!reader.IsDBNull(reader.GetOrdinal("CompanyWebsite"))) _companywebsite = reader.GetString(reader.GetOrdinal("CompanyWebsite"));
                if (!reader.IsDBNull(reader.GetOrdinal("CompanyAddress"))) _companyaddress = reader.GetString(reader.GetOrdinal("CompanyAddress"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsBlockedNow"))) _isblockednow = reader.GetBoolean(reader.GetOrdinal("IsBlockedNow")); 
                if (!reader.IsDBNull(reader.GetOrdinal("IsActive"))) _isactive = reader.GetBoolean(reader.GetOrdinal("IsActive"));
                if (!reader.IsDBNull(reader.GetOrdinal("Remarks"))) _remarks = reader.GetString(reader.GetOrdinal("Remarks"));
                if (!reader.IsDBNull(reader.GetOrdinal("TransID"))) this.BaseSecurityParam.transid = reader.GetString(reader.GetOrdinal("TransID"));
                if (!reader.IsDBNull(reader.GetOrdinal("CreatedByUserName"))) this.BaseSecurityParam.createdbyusername = reader.GetString(reader.GetOrdinal("CreatedByUserName"));
                if (!reader.IsDBNull(reader.GetOrdinal("CreatedDate"))) this.BaseSecurityParam.createddate = reader.GetDateTime(reader.GetOrdinal("CreatedDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("UpdatedByUserName"))) this.BaseSecurityParam.updatedbyusername = reader.GetString(reader.GetOrdinal("UpdatedByUserName"));
                if (!reader.IsDBNull(reader.GetOrdinal("UpdatedDate"))) this.BaseSecurityParam.updateddate = reader.GetDateTime(reader.GetOrdinal("UpdatedDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("UpdateInfo"))) _updateinfo = reader.GetString(reader.GetOrdinal("UpdateInfo"));
                if (!reader.IsDBNull(reader.GetOrdinal("IPAddress"))) this.BaseSecurityParam.ipaddress = reader.GetString(reader.GetOrdinal("IPAddress"));
                if (!reader.IsDBNull(reader.GetOrdinal("TranFormActionID"))) _tranformactionid = reader.GetInt64(reader.GetOrdinal("TranFormActionID"));
                if (!reader.IsDBNull(reader.GetOrdinal("TS"))) this.BaseSecurityParam.ts = reader.GetInt64(reader.GetOrdinal("ts"));
                CurrentState = EntityState.Unchanged;
            }
        }
        
        #endregion
        
        
            
    }
}
