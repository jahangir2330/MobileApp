using System;
using System.Runtime.Serialization;
using System.Data;
using BDO.Core.Base;
using System.ComponentModel.DataAnnotations;


namespace BDO.Core.DataAccessObjects.Models
{
    [Serializable]
    [DataContract(Name = "gen_mobilenotypeEntity", Namespace = "http://www.KAF.com/types")]
    public partial class gen_mobilenotypeEntity : BaseEntity
    {
        #region Properties
    
        protected long ? _mobilenotypeid;
        protected string _mobilenotypename;
        protected string _mobilenotypenamear;
        protected string _logopath;
        protected int ? _sortpriority;
        protected bool ? _isactive;
        protected string _remarks;
        protected string _updateinfo;
        protected long ? _tranformactionid;
                
        
        [DataMember]
        public long ? mobilenotypeid
        {
            get { return _mobilenotypeid; }
            set { _mobilenotypeid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(150)]
        [Display(Name = "mobilenotypename", ResourceType = typeof(CLL.LLClasses.Models._gen_mobilenotype))]
        public string mobilenotypename
        {
            get { return _mobilenotypename; }
            set { _mobilenotypename = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(150)]
        [Display(Name = "mobilenotypenamear", ResourceType = typeof(CLL.LLClasses.Models._gen_mobilenotype))]
        public string mobilenotypenamear
        {
            get { return _mobilenotypenamear; }
            set { _mobilenotypenamear = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(150)]
        [Display(Name = "logopath", ResourceType = typeof(CLL.LLClasses.Models._gen_mobilenotype))]
        public string logopath
        {
            get { return _logopath; }
            set { _logopath = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "sortpriority", ResourceType = typeof(CLL.LLClasses.Models._gen_mobilenotype))]
        public int ? sortpriority
        {
            get { return _sortpriority; }
            set { _sortpriority = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "isactive", ResourceType = typeof(CLL.LLClasses.Models._gen_mobilenotype))]
        public bool ? isactive
        {
            get { return _isactive; }
            set { _isactive = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(550)]
        [Display(Name = "remarks", ResourceType = typeof(CLL.LLClasses.Models._gen_mobilenotype))]
        public string remarks
        {
            get { return _remarks; }
            set { _remarks = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(550)]
        [Display(Name = "updateinfo", ResourceType = typeof(CLL.LLClasses.Models._gen_mobilenotype))]
        public string updateinfo
        {
            get { return _updateinfo; }
            set { _updateinfo = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "tranformactionid", ResourceType = typeof(CLL.LLClasses.Models._gen_mobilenotype))]
        public long ? tranformactionid
        {
            get { return _tranformactionid; }
            set { _tranformactionid = value; this.OnChnaged(); }
        }
        
        
        #endregion
    
        #region Constructor
    
        public gen_mobilenotypeEntity():base()
        {
        }
        
        public gen_mobilenotypeEntity(IDataReader reader)
        {
            this.LoadFromReader(reader);
        }
        
         public gen_mobilenotypeEntity(IDataReader reader, bool IsListViewShow)
        {
            this.LoadFromReader(reader, IsListViewShow);
        }
        
      
        
        protected void LoadFromReader(IDataReader reader)
        {
            if (reader != null && !reader.IsClosed)
            {
                this.BaseSecurityParam = new SecurityCapsule();
                if (!reader.IsDBNull(reader.GetOrdinal("MobileNoTypeID"))) _mobilenotypeid = reader.GetInt64(reader.GetOrdinal("MobileNoTypeID"));
                if (!reader.IsDBNull(reader.GetOrdinal("MobileNoTypeName"))) _mobilenotypename = reader.GetString(reader.GetOrdinal("MobileNoTypeName"));
                if (!reader.IsDBNull(reader.GetOrdinal("MobileNoTypeNameAR"))) _mobilenotypenamear = reader.GetString(reader.GetOrdinal("MobileNoTypeNameAR"));
                if (!reader.IsDBNull(reader.GetOrdinal("LogoPath"))) _logopath = reader.GetString(reader.GetOrdinal("LogoPath"));
                if (!reader.IsDBNull(reader.GetOrdinal("SortPriority"))) _sortpriority = reader.GetInt32(reader.GetOrdinal("SortPriority"));
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
                if (!reader.IsDBNull(reader.GetOrdinal("MobileNoTypeID"))) _mobilenotypeid = reader.GetInt64(reader.GetOrdinal("MobileNoTypeID"));
                if (!reader.IsDBNull(reader.GetOrdinal("MobileNoTypeName"))) _mobilenotypename = reader.GetString(reader.GetOrdinal("MobileNoTypeName"));
                if (!reader.IsDBNull(reader.GetOrdinal("MobileNoTypeNameAR"))) _mobilenotypenamear = reader.GetString(reader.GetOrdinal("MobileNoTypeNameAR"));
                if (!reader.IsDBNull(reader.GetOrdinal("LogoPath"))) _logopath = reader.GetString(reader.GetOrdinal("LogoPath"));
                if (!reader.IsDBNull(reader.GetOrdinal("SortPriority"))) _sortpriority = reader.GetInt32(reader.GetOrdinal("SortPriority"));
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
