using System;
using System.Runtime.Serialization;
using System.Data;
using BDO.Core.Base;
using System.ComponentModel.DataAnnotations;


namespace BDO.Core.DataAccessObjects.Models
{
    [Serializable]
    [DataContract(Name = "gen_representativeEntity", Namespace = "http://www.KAF.com/types")]
    public partial class gen_representativeEntity : BaseEntity
    {
        #region Properties
    
        protected long ? _representativeid;
        protected string _representativename;
        protected string _representativenamear;
        protected long ? _companyid;
        protected long ? _nationalityid;
        protected string _designations;
        protected string _civilid;
        protected string _mobileno;
        protected long ? _mobilenotypeid;
        protected string _emailaddress;
        protected string _representativeaddress;
        protected bool ? _isactive;
        protected string _remarks;
        protected string _updateinfo;
        protected long ? _tranformactionid;
                
        
        [DataMember]
        public long ? representativeid
        {
            get { return _representativeid; }
            set { _representativeid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(150)]
        [RegularExpression(@"^[^\u0627-\u0649]+$", ErrorMessageResourceType = typeof(CLL.LLClasses._Common), ErrorMessageResourceName = "Unicodecharactersarenotallowed")]

        [Display(Name = "representativename", ResourceType = typeof(CLL.LLClasses.Models._gen_representative))]
        public string representativename
        {
            get { return _representativename; }
            set { _representativename = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(150)]
        [Display(Name = "representativenamear", ResourceType = typeof(CLL.LLClasses.Models._gen_representative))]
        public string representativenamear
        {
            get { return _representativenamear; }
            set { _representativenamear = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "companyid", ResourceType = typeof(CLL.LLClasses.Models._gen_representative))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._gen_representative), ErrorMessageResourceName = "companyidRequired")]
        public long ? companyid
        {
            get { return _companyid; }
            set { _companyid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "nationalityid", ResourceType = typeof(CLL.LLClasses.Models._gen_representative))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._gen_representative), ErrorMessageResourceName = "nationalityidRequired")]
        public long ? nationalityid
        {
            get { return _nationalityid; }
            set { _nationalityid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(150)]
        [Display(Name = "designations", ResourceType = typeof(CLL.LLClasses.Models._gen_representative))]
        public string designations
        {
            get { return _designations; }
            set { _designations = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(50)]
        [Display(Name = "civilid", ResourceType = typeof(CLL.LLClasses.Models._gen_representative))]
		[Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._gen_representative), ErrorMessageResourceName = "civilidRequired")]
		public string civilid
        {
            get { return _civilid; }
            set { _civilid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [StringLength(8, MinimumLength = 8, ErrorMessageResourceName = "MobileNumberMustBe8Character", ErrorMessageResourceType = typeof(CLL.LLClasses._Common))]
        [Display(Name = "mobileno", ResourceType = typeof(CLL.LLClasses.Models._gen_representative))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._gen_representative), ErrorMessageResourceName = "mobilenoRequired")]
        public string mobileno
        {
            get { return _mobileno; }
            set { _mobileno = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "mobilenotypeid", ResourceType = typeof(CLL.LLClasses.Models._gen_representative))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._gen_representative), ErrorMessageResourceName = "mobilenotypeidRequired")]
        public long ? mobilenotypeid
        {
            get { return _mobilenotypeid; }
            set { _mobilenotypeid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(150)]
        [Display(Name = "emailaddress", ResourceType = typeof(CLL.LLClasses.Models._gen_representative))]
        public string emailaddress
        {
            get { return _emailaddress; }
            set { _emailaddress = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(550)]
        [Display(Name = "representativeaddress", ResourceType = typeof(CLL.LLClasses.Models._gen_representative))]
        public string representativeaddress
        {
            get { return _representativeaddress; }
            set { _representativeaddress = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "isactive", ResourceType = typeof(CLL.LLClasses.Models._gen_representative))]
        public bool ? isactive
        {
            get { return _isactive; }
            set { _isactive = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(550)]
        [Display(Name = "remarks", ResourceType = typeof(CLL.LLClasses.Models._gen_representative))]
        public string remarks
        {
            get { return _remarks; }
            set { _remarks = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(550)]
        [Display(Name = "updateinfo", ResourceType = typeof(CLL.LLClasses.Models._gen_representative))]
        public string updateinfo
        {
            get { return _updateinfo; }
            set { _updateinfo = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "tranformactionid", ResourceType = typeof(CLL.LLClasses.Models._gen_representative))]
        public long ? tranformactionid
        {
            get { return _tranformactionid; }
            set { _tranformactionid = value; this.OnChnaged(); }
        }
        
        
        #endregion
    
        #region Constructor
    
        public gen_representativeEntity():base()
        {
        }
        
        public gen_representativeEntity(IDataReader reader)
        {
            this.LoadFromReader(reader);
        }
        
         public gen_representativeEntity(IDataReader reader, bool IsListViewShow)
        {
            this.LoadFromReader(reader, IsListViewShow);
        }
        
      
        
        protected void LoadFromReader(IDataReader reader)
        {
            if (reader != null && !reader.IsClosed)
            {
                this.BaseSecurityParam = new SecurityCapsule();
                if (!reader.IsDBNull(reader.GetOrdinal("RepresentativeID"))) _representativeid = reader.GetInt64(reader.GetOrdinal("RepresentativeID"));
                if (!reader.IsDBNull(reader.GetOrdinal("RepresentativeName"))) _representativename = reader.GetString(reader.GetOrdinal("RepresentativeName"));
                if (!reader.IsDBNull(reader.GetOrdinal("RepresentativeNameAR"))) _representativenamear = reader.GetString(reader.GetOrdinal("RepresentativeNameAR"));
                if (!reader.IsDBNull(reader.GetOrdinal("CompanyID"))) _companyid = reader.GetInt64(reader.GetOrdinal("CompanyID"));
                if (!reader.IsDBNull(reader.GetOrdinal("NationalityID"))) _nationalityid = reader.GetInt64(reader.GetOrdinal("NationalityID"));
                if (!reader.IsDBNull(reader.GetOrdinal("Designations"))) _designations = reader.GetString(reader.GetOrdinal("Designations"));
                if (!reader.IsDBNull(reader.GetOrdinal("CivilId"))) _civilid = reader.GetString(reader.GetOrdinal("CivilId"));
                if (!reader.IsDBNull(reader.GetOrdinal("MobileNo"))) _mobileno = reader.GetString(reader.GetOrdinal("MobileNo"));
                if (!reader.IsDBNull(reader.GetOrdinal("MobileNoTypeID"))) _mobilenotypeid = reader.GetInt64(reader.GetOrdinal("MobileNoTypeID"));
                if (!reader.IsDBNull(reader.GetOrdinal("EmailAddress"))) _emailaddress = reader.GetString(reader.GetOrdinal("EmailAddress"));
                if (!reader.IsDBNull(reader.GetOrdinal("RepresentativeAddress"))) _representativeaddress = reader.GetString(reader.GetOrdinal("RepresentativeAddress"));
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
                if (!reader.IsDBNull(reader.GetOrdinal("RepresentativeID"))) _representativeid = reader.GetInt64(reader.GetOrdinal("RepresentativeID"));
                if (!reader.IsDBNull(reader.GetOrdinal("RepresentativeName"))) _representativename = reader.GetString(reader.GetOrdinal("RepresentativeName"));
                if (!reader.IsDBNull(reader.GetOrdinal("RepresentativeNameAR"))) _representativenamear = reader.GetString(reader.GetOrdinal("RepresentativeNameAR"));
                if (!reader.IsDBNull(reader.GetOrdinal("CompanyID"))) _companyid = reader.GetInt64(reader.GetOrdinal("CompanyID"));
                if (!reader.IsDBNull(reader.GetOrdinal("NationalityID"))) _nationalityid = reader.GetInt64(reader.GetOrdinal("NationalityID"));
                if (!reader.IsDBNull(reader.GetOrdinal("Designations"))) _designations = reader.GetString(reader.GetOrdinal("Designations"));
                if (!reader.IsDBNull(reader.GetOrdinal("CivilId"))) _civilid = reader.GetString(reader.GetOrdinal("CivilId"));
                if (!reader.IsDBNull(reader.GetOrdinal("MobileNo"))) _mobileno = reader.GetString(reader.GetOrdinal("MobileNo"));
                if (!reader.IsDBNull(reader.GetOrdinal("MobileNoTypeID"))) _mobilenotypeid = reader.GetInt64(reader.GetOrdinal("MobileNoTypeID"));
                if (!reader.IsDBNull(reader.GetOrdinal("EmailAddress"))) _emailaddress = reader.GetString(reader.GetOrdinal("EmailAddress"));
                if (!reader.IsDBNull(reader.GetOrdinal("RepresentativeAddress"))) _representativeaddress = reader.GetString(reader.GetOrdinal("RepresentativeAddress"));
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
