using System;
using System.Runtime.Serialization;
using System.Data;
using BDO.Core.Base;
using System.ComponentModel.DataAnnotations;


namespace BDO.Core.DataAccessObjects.Models
{
    [Serializable]
    [DataContract(Name = "tran_applicationreqforvisitorgatemapEntity", Namespace = "http://www.KAF.com/types")]
    public partial class tran_applicationreqforvisitorgatemapEntity : BaseEntity
    {
        #region Properties
    
        protected long ? _requestvisitorgateinfoid;
        protected long ? _requestvisitorid;
        protected long ? _gateid;
        protected DateTime ? _permissiondate;
        protected long ? _permittedbymasteruserid;
        protected bool ? _isactive;
        protected string _notetext;
        protected string _updateinfo;
        protected long ? _tranformactionid;
                
        
        [DataMember]
        public long ? requestvisitorgateinfoid
        {
            get { return _requestvisitorgateinfoid; }
            set { _requestvisitorgateinfoid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "requestvisitorid", ResourceType = typeof(CLL.LLClasses.Models._tran_applicationreqforvisitorgatemap))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._tran_applicationreqforvisitorgatemap), ErrorMessageResourceName = "requestvisitoridRequired")]
        public long ? requestvisitorid
        {
            get { return _requestvisitorid; }
            set { _requestvisitorid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "gateid", ResourceType = typeof(CLL.LLClasses.Models._tran_applicationreqforvisitorgatemap))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._tran_applicationreqforvisitorgatemap), ErrorMessageResourceName = "gateidRequired")]
        public long ? gateid
        {
            get { return _gateid; }
            set { _gateid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "permissiondate", ResourceType = typeof(CLL.LLClasses.Models._tran_applicationreqforvisitorgatemap))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._tran_applicationreqforvisitorgatemap), ErrorMessageResourceName = "permissiondateRequired")]
        public DateTime ? permissiondate
        {
            get { return _permissiondate; }
            set { _permissiondate = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "permittedbymasteruserid", ResourceType = typeof(CLL.LLClasses.Models._tran_applicationreqforvisitorgatemap))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._tran_applicationreqforvisitorgatemap), ErrorMessageResourceName = "permittedbymasteruseridRequired")]
        public long ? permittedbymasteruserid
        {
            get { return _permittedbymasteruserid; }
            set { _permittedbymasteruserid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "isactive", ResourceType = typeof(CLL.LLClasses.Models._tran_applicationreqforvisitorgatemap))]
        public bool ? isactive
        {
            get { return _isactive; }
            set { _isactive = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(550)]
        [Display(Name = "notetext", ResourceType = typeof(CLL.LLClasses.Models._tran_applicationreqforvisitorgatemap))]
        public string notetext
        {
            get { return _notetext; }
            set { _notetext = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(550)]
        [Display(Name = "updateinfo", ResourceType = typeof(CLL.LLClasses.Models._tran_applicationreqforvisitorgatemap))]
        public string updateinfo
        {
            get { return _updateinfo; }
            set { _updateinfo = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "tranformactionid", ResourceType = typeof(CLL.LLClasses.Models._tran_applicationreqforvisitorgatemap))]
        public long ? tranformactionid
        {
            get { return _tranformactionid; }
            set { _tranformactionid = value; this.OnChnaged(); }
        }
        
        
        #endregion
    
        #region Constructor
    
        public tran_applicationreqforvisitorgatemapEntity():base()
        {
        }
        
        public tran_applicationreqforvisitorgatemapEntity(IDataReader reader)
        {
            this.LoadFromReader(reader);
        }
        
         public tran_applicationreqforvisitorgatemapEntity(IDataReader reader, bool IsListViewShow)
        {
            this.LoadFromReader(reader, IsListViewShow);
        }
        
      
        
        protected void LoadFromReader(IDataReader reader)
        {
            if (reader != null && !reader.IsClosed)
            {
                this.BaseSecurityParam = new SecurityCapsule();
                if (!reader.IsDBNull(reader.GetOrdinal("RequestVisitorGateInfoID"))) _requestvisitorgateinfoid = reader.GetInt64(reader.GetOrdinal("RequestVisitorGateInfoID"));
                if (!reader.IsDBNull(reader.GetOrdinal("RequestVisitorID"))) _requestvisitorid = reader.GetInt64(reader.GetOrdinal("RequestVisitorID"));
                if (!reader.IsDBNull(reader.GetOrdinal("GateId"))) _gateid = reader.GetInt64(reader.GetOrdinal("GateId"));
                if (!reader.IsDBNull(reader.GetOrdinal("PermissionDate"))) _permissiondate = reader.GetDateTime(reader.GetOrdinal("PermissionDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("PermittedByMasterUserId"))) _permittedbymasteruserid = reader.GetInt64(reader.GetOrdinal("PermittedByMasterUserId"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsActive"))) _isactive = reader.GetBoolean(reader.GetOrdinal("IsActive"));
                if (!reader.IsDBNull(reader.GetOrdinal("NoteText"))) _notetext = reader.GetString(reader.GetOrdinal("NoteText"));
                if (!reader.IsDBNull(reader.GetOrdinal("TransID"))) this.BaseSecurityParam.transid = reader.GetString(reader.GetOrdinal("TransID"));
                if (!reader.IsDBNull(reader.GetOrdinal("CreatedByUserName"))) this.BaseSecurityParam.createdbyusername = reader.GetString(reader.GetOrdinal("CreatedByUserName"));
                if (!reader.IsDBNull(reader.GetOrdinal("CreatedDate"))) this.BaseSecurityParam.createddate = reader.GetDateTime(reader.GetOrdinal("CreatedDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("UpdatedByUserName"))) this.BaseSecurityParam.updatedbyusername = reader.GetString(reader.GetOrdinal("UpdatedByUserName"));
                if (!reader.IsDBNull(reader.GetOrdinal("UpdatedDate"))) this.BaseSecurityParam.updateddate = reader.GetDateTime(reader.GetOrdinal("UpdatedDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("UpdateInfo"))) _updateinfo = reader.GetString(reader.GetOrdinal("UpdateInfo"));
                if (!reader.IsDBNull(reader.GetOrdinal("TranFormActionID"))) _tranformactionid = reader.GetInt64(reader.GetOrdinal("TranFormActionID"));
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
                if (!reader.IsDBNull(reader.GetOrdinal("RequestVisitorGateInfoID"))) _requestvisitorgateinfoid = reader.GetInt64(reader.GetOrdinal("RequestVisitorGateInfoID"));
                if (!reader.IsDBNull(reader.GetOrdinal("RequestVisitorID"))) _requestvisitorid = reader.GetInt64(reader.GetOrdinal("RequestVisitorID"));
                if (!reader.IsDBNull(reader.GetOrdinal("GateId"))) _gateid = reader.GetInt64(reader.GetOrdinal("GateId"));
                if (!reader.IsDBNull(reader.GetOrdinal("PermissionDate"))) _permissiondate = reader.GetDateTime(reader.GetOrdinal("PermissionDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("PermittedByMasterUserId"))) _permittedbymasteruserid = reader.GetInt64(reader.GetOrdinal("PermittedByMasterUserId"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsActive"))) _isactive = reader.GetBoolean(reader.GetOrdinal("IsActive"));
                if (!reader.IsDBNull(reader.GetOrdinal("NoteText"))) _notetext = reader.GetString(reader.GetOrdinal("NoteText"));
                if (!reader.IsDBNull(reader.GetOrdinal("TransID"))) this.BaseSecurityParam.transid = reader.GetString(reader.GetOrdinal("TransID"));
                if (!reader.IsDBNull(reader.GetOrdinal("CreatedByUserName"))) this.BaseSecurityParam.createdbyusername = reader.GetString(reader.GetOrdinal("CreatedByUserName"));
                if (!reader.IsDBNull(reader.GetOrdinal("CreatedDate"))) this.BaseSecurityParam.createddate = reader.GetDateTime(reader.GetOrdinal("CreatedDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("UpdatedByUserName"))) this.BaseSecurityParam.updatedbyusername = reader.GetString(reader.GetOrdinal("UpdatedByUserName"));
                if (!reader.IsDBNull(reader.GetOrdinal("UpdatedDate"))) this.BaseSecurityParam.updateddate = reader.GetDateTime(reader.GetOrdinal("UpdatedDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("UpdateInfo"))) _updateinfo = reader.GetString(reader.GetOrdinal("UpdateInfo"));
                if (!reader.IsDBNull(reader.GetOrdinal("TranFormActionID"))) _tranformactionid = reader.GetInt64(reader.GetOrdinal("TranFormActionID"));
                if (!reader.IsDBNull(reader.GetOrdinal("IPAddress"))) this.BaseSecurityParam.ipaddress = reader.GetString(reader.GetOrdinal("IPAddress"));
                if (!reader.IsDBNull(reader.GetOrdinal("TS"))) this.BaseSecurityParam.ts = reader.GetInt64(reader.GetOrdinal("ts"));
                CurrentState = EntityState.Unchanged;
            }
        }
        
        #endregion
        
        
            
    }
}
