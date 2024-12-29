using System;
using System.Runtime.Serialization;
using System.Data;
using BDO.Core.Base;
using System.ComponentModel.DataAnnotations;


namespace BDO.Core.DataAccessObjects.Models
{
    [Serializable]
    [DataContract(Name = "tran_applicationreqforvehiclegatemapEntity", Namespace = "http://www.KAF.com/types")]
    public partial class tran_applicationreqforvehiclegatemapEntity : BaseEntity
    {
        #region Properties
    
        protected long ? _requestvehiclegateinfoid;
        protected long ? _requestvehicleid;
        protected long ? _gateid;
        protected DateTime ? _permissiondate;
        protected long ? _permittedbymasteruserid;
        protected bool ? _isactive;
        protected string _notetext;
        protected long ? _tranformactionid;
        protected string _updateinfo;
                
        
        [DataMember]
        public long ? requestvehiclegateinfoid
        {
            get { return _requestvehiclegateinfoid; }
            set { _requestvehiclegateinfoid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "requestvehicleid", ResourceType = typeof(CLL.LLClasses.Models._tran_applicationreqforvehiclegatemap))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._tran_applicationreqforvehiclegatemap), ErrorMessageResourceName = "requestvehicleidRequired")]
        public long ? requestvehicleid
        {
            get { return _requestvehicleid; }
            set { _requestvehicleid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "gateid", ResourceType = typeof(CLL.LLClasses.Models._tran_applicationreqforvehiclegatemap))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._tran_applicationreqforvehiclegatemap), ErrorMessageResourceName = "gateidRequired")]
        public long ? gateid
        {
            get { return _gateid; }
            set { _gateid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "permissiondate", ResourceType = typeof(CLL.LLClasses.Models._tran_applicationreqforvehiclegatemap))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._tran_applicationreqforvehiclegatemap), ErrorMessageResourceName = "permissiondateRequired")]
        public DateTime ? permissiondate
        {
            get { return _permissiondate; }
            set { _permissiondate = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "permittedbymasteruserid", ResourceType = typeof(CLL.LLClasses.Models._tran_applicationreqforvehiclegatemap))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._tran_applicationreqforvehiclegatemap), ErrorMessageResourceName = "permittedbymasteruseridRequired")]
        public long ? permittedbymasteruserid
        {
            get { return _permittedbymasteruserid; }
            set { _permittedbymasteruserid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "isactive", ResourceType = typeof(CLL.LLClasses.Models._tran_applicationreqforvehiclegatemap))]
        public bool ? isactive
        {
            get { return _isactive; }
            set { _isactive = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(550)]
        [Display(Name = "notetext", ResourceType = typeof(CLL.LLClasses.Models._tran_applicationreqforvehiclegatemap))]
        public string notetext
        {
            get { return _notetext; }
            set { _notetext = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "tranformactionid", ResourceType = typeof(CLL.LLClasses.Models._tran_applicationreqforvehiclegatemap))]
        public long ? tranformactionid
        {
            get { return _tranformactionid; }
            set { _tranformactionid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(550)]
        [Display(Name = "updateinfo", ResourceType = typeof(CLL.LLClasses.Models._tran_applicationreqforvehiclegatemap))]
        public string updateinfo
        {
            get { return _updateinfo; }
            set { _updateinfo = value; this.OnChnaged(); }
        }
        
        
        #endregion
    
        #region Constructor
    
        public tran_applicationreqforvehiclegatemapEntity():base()
        {
        }
        
        public tran_applicationreqforvehiclegatemapEntity(IDataReader reader)
        {
            this.LoadFromReader(reader);
        }
        
         public tran_applicationreqforvehiclegatemapEntity(IDataReader reader, bool IsListViewShow)
        {
            this.LoadFromReader(reader, IsListViewShow);
        }
        
      
        
        protected void LoadFromReader(IDataReader reader)
        {
            if (reader != null && !reader.IsClosed)
            {
                this.BaseSecurityParam = new SecurityCapsule();
                if (!reader.IsDBNull(reader.GetOrdinal("RequestVehicleGateInfoID"))) _requestvehiclegateinfoid = reader.GetInt64(reader.GetOrdinal("RequestVehicleGateInfoID"));
                if (!reader.IsDBNull(reader.GetOrdinal("RequestVehicleID"))) _requestvehicleid = reader.GetInt64(reader.GetOrdinal("RequestVehicleID"));
                if (!reader.IsDBNull(reader.GetOrdinal("GateId"))) _gateid = reader.GetInt64(reader.GetOrdinal("GateId"));
                if (!reader.IsDBNull(reader.GetOrdinal("PermissionDate"))) _permissiondate = reader.GetDateTime(reader.GetOrdinal("PermissionDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("PermittedByMasterUserId"))) _permittedbymasteruserid = reader.GetInt64(reader.GetOrdinal("PermittedByMasterUserId"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsActive"))) _isactive = reader.GetBoolean(reader.GetOrdinal("IsActive"));
                if (!reader.IsDBNull(reader.GetOrdinal("NoteText"))) _notetext = reader.GetString(reader.GetOrdinal("NoteText"));
                if (!reader.IsDBNull(reader.GetOrdinal("TranFormActionID"))) _tranformactionid = reader.GetInt64(reader.GetOrdinal("TranFormActionID"));
                if (!reader.IsDBNull(reader.GetOrdinal("TransID"))) this.BaseSecurityParam.transid = reader.GetString(reader.GetOrdinal("TransID"));
                if (!reader.IsDBNull(reader.GetOrdinal("CreatedByUserName"))) this.BaseSecurityParam.createdbyusername = reader.GetString(reader.GetOrdinal("CreatedByUserName"));
                if (!reader.IsDBNull(reader.GetOrdinal("CreatedDate"))) this.BaseSecurityParam.createddate = reader.GetDateTime(reader.GetOrdinal("CreatedDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("UpdatedByUserName"))) this.BaseSecurityParam.updatedbyusername = reader.GetString(reader.GetOrdinal("UpdatedByUserName"));
                if (!reader.IsDBNull(reader.GetOrdinal("UpdatedDate"))) this.BaseSecurityParam.updateddate = reader.GetDateTime(reader.GetOrdinal("UpdatedDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("UpdateInfo"))) _updateinfo = reader.GetString(reader.GetOrdinal("UpdateInfo"));
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
                if (!reader.IsDBNull(reader.GetOrdinal("RequestVehicleGateInfoID"))) _requestvehiclegateinfoid = reader.GetInt64(reader.GetOrdinal("RequestVehicleGateInfoID"));
                if (!reader.IsDBNull(reader.GetOrdinal("RequestVehicleID"))) _requestvehicleid = reader.GetInt64(reader.GetOrdinal("RequestVehicleID"));
                if (!reader.IsDBNull(reader.GetOrdinal("GateId"))) _gateid = reader.GetInt64(reader.GetOrdinal("GateId"));
                if (!reader.IsDBNull(reader.GetOrdinal("PermissionDate"))) _permissiondate = reader.GetDateTime(reader.GetOrdinal("PermissionDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("PermittedByMasterUserId"))) _permittedbymasteruserid = reader.GetInt64(reader.GetOrdinal("PermittedByMasterUserId"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsActive"))) _isactive = reader.GetBoolean(reader.GetOrdinal("IsActive"));
                if (!reader.IsDBNull(reader.GetOrdinal("NoteText"))) _notetext = reader.GetString(reader.GetOrdinal("NoteText"));
                if (!reader.IsDBNull(reader.GetOrdinal("TranFormActionID"))) _tranformactionid = reader.GetInt64(reader.GetOrdinal("TranFormActionID"));
                if (!reader.IsDBNull(reader.GetOrdinal("TransID"))) this.BaseSecurityParam.transid = reader.GetString(reader.GetOrdinal("TransID"));
                if (!reader.IsDBNull(reader.GetOrdinal("CreatedByUserName"))) this.BaseSecurityParam.createdbyusername = reader.GetString(reader.GetOrdinal("CreatedByUserName"));
                if (!reader.IsDBNull(reader.GetOrdinal("CreatedDate"))) this.BaseSecurityParam.createddate = reader.GetDateTime(reader.GetOrdinal("CreatedDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("UpdatedByUserName"))) this.BaseSecurityParam.updatedbyusername = reader.GetString(reader.GetOrdinal("UpdatedByUserName"));
                if (!reader.IsDBNull(reader.GetOrdinal("UpdatedDate"))) this.BaseSecurityParam.updateddate = reader.GetDateTime(reader.GetOrdinal("UpdatedDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("UpdateInfo"))) _updateinfo = reader.GetString(reader.GetOrdinal("UpdateInfo"));
                if (!reader.IsDBNull(reader.GetOrdinal("IPAddress"))) this.BaseSecurityParam.ipaddress = reader.GetString(reader.GetOrdinal("IPAddress"));
                if (!reader.IsDBNull(reader.GetOrdinal("TS"))) this.BaseSecurityParam.ts = reader.GetInt64(reader.GetOrdinal("ts"));
                CurrentState = EntityState.Unchanged;
            }
        }
        
        #endregion
        
        
            
    }
}
