using System;
using System.Runtime.Serialization;
using System.Data;
using BDO.Core.Base;
using System.ComponentModel.DataAnnotations;


namespace BDO.Core.DataAccessObjects.Models
{
    [Serializable]
    [DataContract(Name = "gen_entrystatusEntity", Namespace = "http://www.KAF.com/types")]
    public partial class gen_entrystatusEntity : BaseEntity
    {
        #region Properties
    
        protected long ? _entrystatusid;
        protected string _entrystatusname;
        protected string _entrystatusnamear;
        protected string _imagepath;
        protected int ? _sortpriority;
        protected string _iconname;
        protected string _cssclass;
        protected bool ? _isactive;
        protected string _remarks;
        protected string _updateinfo;
        protected long ? _tranformactionid;
                
        
        [DataMember]
        public long ? entrystatusid
        {
            get { return _entrystatusid; }
            set { _entrystatusid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(150)]
        [Display(Name = "entrystatusname", ResourceType = typeof(CLL.LLClasses.Models._gen_entrystatus))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._gen_entrystatus), ErrorMessageResourceName = "entrystatusnameRequired")]
        public string entrystatusname
        {
            get { return _entrystatusname; }
            set { _entrystatusname = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(250)]
        [Display(Name = "entrystatusnamear", ResourceType = typeof(CLL.LLClasses.Models._gen_entrystatus))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._gen_entrystatus), ErrorMessageResourceName = "entrystatusnamearRequired")]
        public string entrystatusnamear
        {
            get { return _entrystatusnamear; }
            set { _entrystatusnamear = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(150)]
        [Display(Name = "imagepath", ResourceType = typeof(CLL.LLClasses.Models._gen_entrystatus))]
        public string imagepath
        {
            get { return _imagepath; }
            set { _imagepath = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "sortpriority", ResourceType = typeof(CLL.LLClasses.Models._gen_entrystatus))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._gen_entrystatus), ErrorMessageResourceName = "sortpriorityRequired")]
        public int ? sortpriority
        {
            get { return _sortpriority; }
            set { _sortpriority = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(150)]
        [Display(Name = "iconname", ResourceType = typeof(CLL.LLClasses.Models._gen_entrystatus))]
        public string iconname
        {
            get { return _iconname; }
            set { _iconname = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(150)]
        [Display(Name = "cssclass", ResourceType = typeof(CLL.LLClasses.Models._gen_entrystatus))]
        public string cssclass
        {
            get { return _cssclass; }
            set { _cssclass = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "isactive", ResourceType = typeof(CLL.LLClasses.Models._gen_entrystatus))]
        public bool ? isactive
        {
            get { return _isactive; }
            set { _isactive = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(550)]
        [Display(Name = "remarks", ResourceType = typeof(CLL.LLClasses.Models._gen_entrystatus))]
        public string remarks
        {
            get { return _remarks; }
            set { _remarks = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(550)]
        [Display(Name = "updateinfo", ResourceType = typeof(CLL.LLClasses.Models._gen_entrystatus))]
        public string updateinfo
        {
            get { return _updateinfo; }
            set { _updateinfo = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "tranformactionid", ResourceType = typeof(CLL.LLClasses.Models._gen_entrystatus))]
        public long ? tranformactionid
        {
            get { return _tranformactionid; }
            set { _tranformactionid = value; this.OnChnaged(); }
        }
        
        
        #endregion
    
        #region Constructor
    
        public gen_entrystatusEntity():base()
        {
        }
        
        public gen_entrystatusEntity(IDataReader reader)
        {
            this.LoadFromReader(reader);
        }
        
         public gen_entrystatusEntity(IDataReader reader, bool IsListViewShow)
        {
            this.LoadFromReader(reader, IsListViewShow);
        }
        
      
        
        protected void LoadFromReader(IDataReader reader)
        {
            if (reader != null && !reader.IsClosed)
            {
                this.BaseSecurityParam = new SecurityCapsule();
                if (!reader.IsDBNull(reader.GetOrdinal("EntryStatusID"))) _entrystatusid = reader.GetInt64(reader.GetOrdinal("EntryStatusID"));
                if (!reader.IsDBNull(reader.GetOrdinal("EntryStatusName"))) _entrystatusname = reader.GetString(reader.GetOrdinal("EntryStatusName"));
                if (!reader.IsDBNull(reader.GetOrdinal("EntryStatusNameAR"))) _entrystatusnamear = reader.GetString(reader.GetOrdinal("EntryStatusNameAR"));
                if (!reader.IsDBNull(reader.GetOrdinal("ImagePath"))) _imagepath = reader.GetString(reader.GetOrdinal("ImagePath"));
                if (!reader.IsDBNull(reader.GetOrdinal("SortPriority"))) _sortpriority = reader.GetInt32(reader.GetOrdinal("SortPriority"));
                if (!reader.IsDBNull(reader.GetOrdinal("IconName"))) _iconname = reader.GetString(reader.GetOrdinal("IconName"));
                if (!reader.IsDBNull(reader.GetOrdinal("CssClass"))) _cssclass = reader.GetString(reader.GetOrdinal("CssClass"));
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
                if (!reader.IsDBNull(reader.GetOrdinal("EntryStatusID"))) _entrystatusid = reader.GetInt64(reader.GetOrdinal("EntryStatusID"));
                if (!reader.IsDBNull(reader.GetOrdinal("EntryStatusName"))) _entrystatusname = reader.GetString(reader.GetOrdinal("EntryStatusName"));
                if (!reader.IsDBNull(reader.GetOrdinal("EntryStatusNameAR"))) _entrystatusnamear = reader.GetString(reader.GetOrdinal("EntryStatusNameAR"));
                if (!reader.IsDBNull(reader.GetOrdinal("ImagePath"))) _imagepath = reader.GetString(reader.GetOrdinal("ImagePath"));
                if (!reader.IsDBNull(reader.GetOrdinal("SortPriority"))) _sortpriority = reader.GetInt32(reader.GetOrdinal("SortPriority"));
                if (!reader.IsDBNull(reader.GetOrdinal("IconName"))) _iconname = reader.GetString(reader.GetOrdinal("IconName"));
                if (!reader.IsDBNull(reader.GetOrdinal("CssClass"))) _cssclass = reader.GetString(reader.GetOrdinal("CssClass"));
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
