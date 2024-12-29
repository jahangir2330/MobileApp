using System;
using System.Runtime.Serialization;
using System.Data;
using BDO.Core.Base;
using System.ComponentModel.DataAnnotations;


namespace BDO.Core.DataAccessObjects.Models
{
    [Serializable]
    [DataContract(Name = "oc_familymembersinfoEntity", Namespace = "http://www.KAF.com/types")]
    public partial class oc_familymembersinfoEntity : BaseEntity
    {
        #region Properties
    
        protected long ? _ocfamilymemberid;
        protected long ? _ocfileid;
        protected long ? _familymembercivilid;
        protected string _familymemberpacijsondata;
        protected long ? _hrfamilyid;
        protected long ? _relationshipid;
        protected bool ? _hasmembership;
        protected bool ? _isactive;
        protected bool ? _issynced;
        protected DateTime ? _lastsyncdate;
                
        
        [DataMember]
        public long ? ocfamilymemberid
        {
            get { return _ocfamilymemberid; }
            set { _ocfamilymemberid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "ocfileid", ResourceType = typeof(CLL.LLClasses.Models._oc_familymembersinfo))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._oc_familymembersinfo), ErrorMessageResourceName = "ocfileidRequired")]
        public long ? ocfileid
        {
            get { return _ocfileid; }
            set { _ocfileid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "familymembercivilid", ResourceType = typeof(CLL.LLClasses.Models._oc_familymembersinfo))]
        public long ? familymembercivilid
        {
            get { return _familymembercivilid; }
            set { _familymembercivilid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(-1)]
        [Display(Name = "familymemberpacijsondata", ResourceType = typeof(CLL.LLClasses.Models._oc_familymembersinfo))]
        public string familymemberpacijsondata
        {
            get { return _familymemberpacijsondata; }
            set { _familymemberpacijsondata = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "hrfamilyid", ResourceType = typeof(CLL.LLClasses.Models._oc_familymembersinfo))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._oc_familymembersinfo), ErrorMessageResourceName = "hrfamilyidRequired")]
        public long ? hrfamilyid
        {
            get { return _hrfamilyid; }
            set { _hrfamilyid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "relationshipid", ResourceType = typeof(CLL.LLClasses.Models._oc_familymembersinfo))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._oc_familymembersinfo), ErrorMessageResourceName = "relationshipidRequired")]
        public long ? relationshipid
        {
            get { return _relationshipid; }
            set { _relationshipid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "hasmembership", ResourceType = typeof(CLL.LLClasses.Models._oc_familymembersinfo))]
        public bool ? hasmembership
        {
            get { return _hasmembership; }
            set { _hasmembership = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "isactive", ResourceType = typeof(CLL.LLClasses.Models._oc_familymembersinfo))]
        public bool ? isactive
        {
            get { return _isactive; }
            set { _isactive = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "issynced", ResourceType = typeof(CLL.LLClasses.Models._oc_familymembersinfo))]
        public bool ? issynced
        {
            get { return _issynced; }
            set { _issynced = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "lastsyncdate", ResourceType = typeof(CLL.LLClasses.Models._oc_familymembersinfo))]
        public DateTime ? lastsyncdate
        {
            get { return _lastsyncdate; }
            set { _lastsyncdate = value; this.OnChnaged(); }
        }
        
        
        #endregion
    
        #region Constructor
    
        public oc_familymembersinfoEntity():base()
        {
        }
        
        public oc_familymembersinfoEntity(IDataReader reader)
        {
            this.LoadFromReader(reader);
        }
        
         public oc_familymembersinfoEntity(IDataReader reader, bool IsListViewShow)
        {
            this.LoadFromReader(reader, IsListViewShow);
        }
        
      
        
        protected void LoadFromReader(IDataReader reader)
        {
            if (reader != null && !reader.IsClosed)
            {
                this.BaseSecurityParam = new SecurityCapsule();
                if (!reader.IsDBNull(reader.GetOrdinal("OCFamilyMemberID"))) _ocfamilymemberid = reader.GetInt64(reader.GetOrdinal("OCFamilyMemberID"));
                if (!reader.IsDBNull(reader.GetOrdinal("OCFileID"))) _ocfileid = reader.GetInt64(reader.GetOrdinal("OCFileID"));
                if (!reader.IsDBNull(reader.GetOrdinal("FamilyMemberCivilID"))) _familymembercivilid = reader.GetInt64(reader.GetOrdinal("FamilyMemberCivilID"));
                if (!reader.IsDBNull(reader.GetOrdinal("FamilyMemberPaciJsonData"))) _familymemberpacijsondata = reader.GetString(reader.GetOrdinal("FamilyMemberPaciJsonData"));
                if (!reader.IsDBNull(reader.GetOrdinal("HrFamilyID"))) _hrfamilyid = reader.GetInt64(reader.GetOrdinal("HrFamilyID"));
                if (!reader.IsDBNull(reader.GetOrdinal("RelationshipID"))) _relationshipid = reader.GetInt64(reader.GetOrdinal("RelationshipID"));
                if (!reader.IsDBNull(reader.GetOrdinal("HasMemberShip"))) _hasmembership = reader.GetBoolean(reader.GetOrdinal("HasMemberShip"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsActive"))) _isactive = reader.GetBoolean(reader.GetOrdinal("IsActive"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsSynced"))) _issynced = reader.GetBoolean(reader.GetOrdinal("IsSynced"));
                if (!reader.IsDBNull(reader.GetOrdinal("LastSyncDate"))) _lastsyncdate = reader.GetDateTime(reader.GetOrdinal("LastSyncDate"));
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
                if (!reader.IsDBNull(reader.GetOrdinal("OCFamilyMemberID"))) _ocfamilymemberid = reader.GetInt64(reader.GetOrdinal("OCFamilyMemberID"));
                if (!reader.IsDBNull(reader.GetOrdinal("OCFileID"))) _ocfileid = reader.GetInt64(reader.GetOrdinal("OCFileID"));
                if (!reader.IsDBNull(reader.GetOrdinal("FamilyMemberCivilID"))) _familymembercivilid = reader.GetInt64(reader.GetOrdinal("FamilyMemberCivilID"));
                if (!reader.IsDBNull(reader.GetOrdinal("FamilyMemberPaciJsonData"))) _familymemberpacijsondata = reader.GetString(reader.GetOrdinal("FamilyMemberPaciJsonData"));
                if (!reader.IsDBNull(reader.GetOrdinal("HrFamilyID"))) _hrfamilyid = reader.GetInt64(reader.GetOrdinal("HrFamilyID"));
                if (!reader.IsDBNull(reader.GetOrdinal("RelationshipID"))) _relationshipid = reader.GetInt64(reader.GetOrdinal("RelationshipID"));
                if (!reader.IsDBNull(reader.GetOrdinal("HasMemberShip"))) _hasmembership = reader.GetBoolean(reader.GetOrdinal("HasMemberShip"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsActive"))) _isactive = reader.GetBoolean(reader.GetOrdinal("IsActive"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsSynced"))) _issynced = reader.GetBoolean(reader.GetOrdinal("IsSynced"));
                if (!reader.IsDBNull(reader.GetOrdinal("LastSyncDate"))) _lastsyncdate = reader.GetDateTime(reader.GetOrdinal("LastSyncDate"));
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
