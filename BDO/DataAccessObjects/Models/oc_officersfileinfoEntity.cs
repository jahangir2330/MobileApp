using System;
using System.Runtime.Serialization;
using System.Data;
using BDO.Core.Base;
using System.ComponentModel.DataAnnotations;
using BDO.Core.DataAccessObjects.CommonEntities;

namespace BDO.Core.DataAccessObjects.Models
{
    [Serializable]
    [DataContract(Name = "oc_officersfileinfoEntity", Namespace = "http://www.KAF.com/types")]
    public partial class oc_officersfileinfoEntity : BaseEntity
    {
        #region Properties
    
        protected long ? _ocfileid;
        protected long ? _occivilid;
        protected long ? _ocmilitaryid;
        protected long ? _hrbasicid;
        protected string _ocemailaddress;
        protected string _ocphonenumber;
        protected string _officerpacijsondata;
        protected DateTime ? _filecreationdate;
        protected bool ? _fileisactive;
        protected string _hrdatajsondata;
        protected bool ? _issynced;
        protected DateTime ? _lastpacisynceddate;
        protected bool ? _memberisregistered;
                
        
        [DataMember]
        public long ? ocfileid
        {
            get { return _ocfileid; }
            set { _ocfileid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "occivilid", ResourceType = typeof(CLL.LLClasses.Models._oc_officersfileinfo))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._oc_officersfileinfo), ErrorMessageResourceName = "occivilidRequired")]
        public long ? occivilid
        {
            get { return _occivilid; }
            set { _occivilid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "ocmilitaryid", ResourceType = typeof(CLL.LLClasses.Models._oc_officersfileinfo))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._oc_officersfileinfo), ErrorMessageResourceName = "ocmilitaryidRequired")]
        public long ? ocmilitaryid
        {
            get { return _ocmilitaryid; }
            set { _ocmilitaryid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "hrbasicid", ResourceType = typeof(CLL.LLClasses.Models._oc_officersfileinfo))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._oc_officersfileinfo), ErrorMessageResourceName = "hrbasicidRequired")]
        public long ? hrbasicid
        {
            get { return _hrbasicid; }
            set { _hrbasicid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(150)]
        [Display(Name = "ocemailaddress", ResourceType = typeof(CLL.LLClasses.Models._oc_officersfileinfo))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._oc_officersfileinfo), ErrorMessageResourceName = "ocemailaddressRequired")]
        public string ocemailaddress
        {
            get { return _ocemailaddress; }
            set { _ocemailaddress = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(10)]
        [Display(Name = "ocphonenumber", ResourceType = typeof(CLL.LLClasses.Models._oc_officersfileinfo))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._oc_officersfileinfo), ErrorMessageResourceName = "ocphonenumberRequired")]
        public string ocphonenumber
        {
            get { return _ocphonenumber; }
            set { _ocphonenumber = value; this.OnChnaged(); }
        }
        
        [DataMember]
        //[MaxLength(-1)]
        [Display(Name = "officerpacijsondata", ResourceType = typeof(CLL.LLClasses.Models._oc_officersfileinfo))]
        public string officerpacijsondata
        {
            get { return _officerpacijsondata; }
            set { _officerpacijsondata = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "filecreationdate", ResourceType = typeof(CLL.LLClasses.Models._oc_officersfileinfo))]
        public DateTime ? filecreationdate
        {
            get { return _filecreationdate; }
            set { _filecreationdate = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "fileisactive", ResourceType = typeof(CLL.LLClasses.Models._oc_officersfileinfo))]
        public bool ? fileisactive
        {
            get { return _fileisactive; }
            set { _fileisactive = value; this.OnChnaged(); }
        }
        
        [DataMember]
        //[MaxLength(-1)]
        [Display(Name = "hrdatajsondata", ResourceType = typeof(CLL.LLClasses.Models._oc_officersfileinfo))]
        public string hrdatajsondata
        {
            get { return _hrdatajsondata; }
            set { _hrdatajsondata = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "issynced", ResourceType = typeof(CLL.LLClasses.Models._oc_officersfileinfo))]
        public bool ? issynced
        {
            get { return _issynced; }
            set { _issynced = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "lastpacisynceddate", ResourceType = typeof(CLL.LLClasses.Models._oc_officersfileinfo))]
        public DateTime ? lastpacisynceddate
        {
            get { return _lastpacisynceddate; }
            set { _lastpacisynceddate = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "memberisregistered", ResourceType = typeof(CLL.LLClasses.Models._oc_officersfileinfo))]
        public bool ? memberisregistered
        {
            get { return _memberisregistered; }
            set { _memberisregistered = value; this.OnChnaged(); }
        }
        
        
        #endregion
    
        #region Constructor
    
        public oc_officersfileinfoEntity():base()
        {
        }
        
        public oc_officersfileinfoEntity(IDataReader reader)
        {
            this.LoadFromReader(reader);
        }
        
         public oc_officersfileinfoEntity(IDataReader reader, bool IsListViewShow)
        {
            this.LoadFromReader(reader, IsListViewShow);
        }
        
      
        
        protected void LoadFromReader(IDataReader reader)
        {
            if (reader != null && !reader.IsClosed)
            {
                this.BaseSecurityParam = new SecurityCapsule();
                if (!reader.IsDBNull(reader.GetOrdinal("OCFileID"))) _ocfileid = reader.GetInt64(reader.GetOrdinal("OCFileID"));
                if (!reader.IsDBNull(reader.GetOrdinal("OCCivilID"))) _occivilid = reader.GetInt64(reader.GetOrdinal("OCCivilID"));
                if (!reader.IsDBNull(reader.GetOrdinal("OCMilitaryID"))) _ocmilitaryid = reader.GetInt64(reader.GetOrdinal("OCMilitaryID"));
                if (!reader.IsDBNull(reader.GetOrdinal("HrBasicID"))) _hrbasicid = reader.GetInt64(reader.GetOrdinal("HrBasicID"));
                if (!reader.IsDBNull(reader.GetOrdinal("OCEmailAddress"))) _ocemailaddress = reader.GetString(reader.GetOrdinal("OCEmailAddress"));
                if (!reader.IsDBNull(reader.GetOrdinal("OCPhoneNumber"))) _ocphonenumber = reader.GetString(reader.GetOrdinal("OCPhoneNumber"));
                if (!reader.IsDBNull(reader.GetOrdinal("OfficerPaciJsonData"))) _officerpacijsondata = reader.GetString(reader.GetOrdinal("OfficerPaciJsonData"));
                if (!reader.IsDBNull(reader.GetOrdinal("FileCreationDate"))) _filecreationdate = reader.GetDateTime(reader.GetOrdinal("FileCreationDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("FileIsActive"))) _fileisactive = reader.GetBoolean(reader.GetOrdinal("FileIsActive"));
                if (!reader.IsDBNull(reader.GetOrdinal("HrDataJsonData"))) _hrdatajsondata = reader.GetString(reader.GetOrdinal("HrDataJsonData"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsSynced"))) _issynced = reader.GetBoolean(reader.GetOrdinal("IsSynced"));
                if (!reader.IsDBNull(reader.GetOrdinal("LastPaciSyncedDate"))) _lastpacisynceddate = reader.GetDateTime(reader.GetOrdinal("LastPaciSyncedDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("MemberIsRegistered"))) _memberisregistered = reader.GetBoolean(reader.GetOrdinal("MemberIsRegistered"));
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
                if (!reader.IsDBNull(reader.GetOrdinal("OCFileID"))) _ocfileid = reader.GetInt64(reader.GetOrdinal("OCFileID"));
                if (!reader.IsDBNull(reader.GetOrdinal("OCCivilID"))) _occivilid = reader.GetInt64(reader.GetOrdinal("OCCivilID"));
                if (!reader.IsDBNull(reader.GetOrdinal("OCMilitaryID"))) _ocmilitaryid = reader.GetInt64(reader.GetOrdinal("OCMilitaryID"));
                if (!reader.IsDBNull(reader.GetOrdinal("HrBasicID"))) _hrbasicid = reader.GetInt64(reader.GetOrdinal("HrBasicID"));
                if (!reader.IsDBNull(reader.GetOrdinal("OCEmailAddress"))) _ocemailaddress = reader.GetString(reader.GetOrdinal("OCEmailAddress"));
                if (!reader.IsDBNull(reader.GetOrdinal("OCPhoneNumber"))) _ocphonenumber = reader.GetString(reader.GetOrdinal("OCPhoneNumber"));
                if (!reader.IsDBNull(reader.GetOrdinal("OfficerPaciJsonData"))) _officerpacijsondata = reader.GetString(reader.GetOrdinal("OfficerPaciJsonData"));
                if (!reader.IsDBNull(reader.GetOrdinal("FileCreationDate"))) _filecreationdate = reader.GetDateTime(reader.GetOrdinal("FileCreationDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("FileIsActive"))) _fileisactive = reader.GetBoolean(reader.GetOrdinal("FileIsActive"));
                if (!reader.IsDBNull(reader.GetOrdinal("HrDataJsonData"))) _hrdatajsondata = reader.GetString(reader.GetOrdinal("HrDataJsonData"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsSynced"))) _issynced = reader.GetBoolean(reader.GetOrdinal("IsSynced"));
                if (!reader.IsDBNull(reader.GetOrdinal("LastPaciSyncedDate"))) _lastpacisynceddate = reader.GetDateTime(reader.GetOrdinal("LastPaciSyncedDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("MemberIsRegistered"))) _memberisregistered = reader.GetBoolean(reader.GetOrdinal("MemberIsRegistered"));
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
