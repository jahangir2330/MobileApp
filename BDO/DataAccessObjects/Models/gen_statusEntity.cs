using System;
using System.Runtime.Serialization;
using System.Data;
using BDO.Core.Base;
using System.ComponentModel.DataAnnotations;


namespace BDO.Core.DataAccessObjects.Models
{
    [Serializable]
    [DataContract(Name = "gen_statusEntity", Namespace = "http://www.KAF.com/types")]
    public partial class gen_statusEntity : BaseEntity
    {
        #region Properties
    
        protected long ? _statusid;
        protected string _statusname;
        protected string _statusnamear;
        protected string _imagepath;
        protected string _iconname;
        protected string _cssclass;
        protected int ? _sortpriority;
        protected bool ? _isactive;
        protected string _remarks;
        protected string _updateinfo;
        protected long ? _tranformactionid;

       
        [DataMember]
        public long ? statusid
        {
            get { return _statusid; }
            set { _statusid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(150)]
        [Display(Name = "statusname", ResourceType = typeof(CLL.LLClasses.Models._gen_status))]
        public string statusname
        {
            get { return _statusname; }
            set { _statusname = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(150)]
        [Display(Name = "statusnamear", ResourceType = typeof(CLL.LLClasses.Models._gen_status))]
        public string statusnamear
        {
            get { return _statusnamear; }
            set { _statusnamear = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(150)]
        [Display(Name = "imagepath", ResourceType = typeof(CLL.LLClasses.Models._gen_status))]
        public string imagepath
        {
            get { return _imagepath; }
            set { _imagepath = value; this.OnChnaged(); }
        }
        [DataMember]
        [MaxLength(150)]
        [Display(Name = "iconname", ResourceType = typeof(CLL.LLClasses.Models._gen_status))]
        public string iconname
        {
            get { return _iconname; }
            set { _iconname = value; this.OnChnaged(); }
        }
        [DataMember]
        [MaxLength(150)]
        [Display(Name = "cssclass", ResourceType = typeof(CLL.LLClasses.Models._gen_status))]
        public string cssclass
        {
            get { return _cssclass; }
            set { _cssclass = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "sortpriority", ResourceType = typeof(CLL.LLClasses.Models._gen_status))]
        [Required]
        public int ? sortpriority
        {
            get { return _sortpriority; }
            set { _sortpriority = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "isactive", ResourceType = typeof(CLL.LLClasses.Models._gen_status))]
        public bool ? isactive
        {
            get { return _isactive; }
            set { _isactive = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(550)]
        [Display(Name = "remarks", ResourceType = typeof(CLL.LLClasses.Models._gen_status))]
        public string remarks
        {
            get { return _remarks; }
            set { _remarks = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(550)]
        [Display(Name = "updateinfo", ResourceType = typeof(CLL.LLClasses.Models._gen_status))]
        public string updateinfo
        {
            get { return _updateinfo; }
            set { _updateinfo = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "tranformactionid", ResourceType = typeof(CLL.LLClasses.Models._gen_status))]
        public long ? tranformactionid
        {
            get { return _tranformactionid; }
            set { _tranformactionid = value; this.OnChnaged(); }
        }
        
        
        #endregion
    
        #region Constructor
    
        public gen_statusEntity():base()
        {
        }
        
        public gen_statusEntity(IDataReader reader)
        {
            this.LoadFromReader(reader);
        }
        
         public gen_statusEntity(IDataReader reader, bool IsListViewShow)
        {
            this.LoadFromReader(reader, IsListViewShow);
        }
        
      
        
        protected void LoadFromReader(IDataReader reader)
        {
            if (reader != null && !reader.IsClosed)
            {
                this.BaseSecurityParam = new SecurityCapsule();
                if (!reader.IsDBNull(reader.GetOrdinal("StatusID"))) _statusid = reader.GetInt64(reader.GetOrdinal("StatusID"));
                if (!reader.IsDBNull(reader.GetOrdinal("StatusName"))) _statusname = reader.GetString(reader.GetOrdinal("StatusName"));
                if (!reader.IsDBNull(reader.GetOrdinal("StatusNameAR"))) _statusnamear = reader.GetString(reader.GetOrdinal("StatusNameAR"));
                if (!reader.IsDBNull(reader.GetOrdinal("ImagePath"))) _imagepath = reader.GetString(reader.GetOrdinal("ImagePath"));
                if (!reader.IsDBNull(reader.GetOrdinal("IconName"))) _iconname = reader.GetString(reader.GetOrdinal("IconName"));
                if (!reader.IsDBNull(reader.GetOrdinal("CssClass"))) _cssclass = reader.GetString(reader.GetOrdinal("CssClass"));
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
                if (!reader.IsDBNull(reader.GetOrdinal("StatusID"))) _statusid = reader.GetInt64(reader.GetOrdinal("StatusID"));
                if (!reader.IsDBNull(reader.GetOrdinal("StatusName"))) _statusname = reader.GetString(reader.GetOrdinal("StatusName"));
                if (!reader.IsDBNull(reader.GetOrdinal("StatusNameAR"))) _statusnamear = reader.GetString(reader.GetOrdinal("StatusNameAR"));
                if (!reader.IsDBNull(reader.GetOrdinal("ImagePath"))) _imagepath = reader.GetString(reader.GetOrdinal("ImagePath"));
                if (!reader.IsDBNull(reader.GetOrdinal("IconName"))) _iconname = reader.GetString(reader.GetOrdinal("IconName"));
                if (!reader.IsDBNull(reader.GetOrdinal("CssClass"))) _cssclass = reader.GetString(reader.GetOrdinal("CssClass"));
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
