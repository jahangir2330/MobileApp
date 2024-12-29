using System;
using System.Runtime.Serialization;
using System.Data;
using BDO.Core.Base;
using System.ComponentModel.DataAnnotations;


namespace BDO.Core.DataAccessObjects.Models
{
    [Serializable]
    [DataContract(Name = "tran_applicationreqforvehicleactivitylogEntity", Namespace = "http://www.KAF.com/types")]
    public partial class tran_applicationreqforvehicleactivitylogEntity : BaseEntity
    {
        #region Properties
    
        protected long ? _requestvehicleactivitylogid;
        protected long ? _requestvehicleid;
        protected long ? _statusid;
        protected string _activitylogtext;
        protected DateTime ? _logtime;
        protected long ? _masteruserid;
        protected long ? _tranformactionid;
        protected string _updateinfo;
                
        
        [DataMember]
        public long ? requestvehicleactivitylogid
        {
            get { return _requestvehicleactivitylogid; }
            set { _requestvehicleactivitylogid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "requestvehicleid", ResourceType = typeof(CLL.LLClasses.Models._tran_applicationreqforvehicleactivitylog))]
        public long ? requestvehicleid
        {
            get { return _requestvehicleid; }
            set { _requestvehicleid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "statusid", ResourceType = typeof(CLL.LLClasses.Models._tran_applicationreqforvehicleactivitylog))]
        public long ? statusid
        {
            get { return _statusid; }
            set { _statusid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(550)]
        [Display(Name = "activitylogtext", ResourceType = typeof(CLL.LLClasses.Models._tran_applicationreqforvehicleactivitylog))]
        public string activitylogtext
        {
            get { return _activitylogtext; }
            set { _activitylogtext = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "logtime", ResourceType = typeof(CLL.LLClasses.Models._tran_applicationreqforvehicleactivitylog))]
        public DateTime ? logtime
        {
            get { return _logtime; }
            set { _logtime = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "masteruserid", ResourceType = typeof(CLL.LLClasses.Models._tran_applicationreqforvehicleactivitylog))]
        public long ? masteruserid
        {
            get { return _masteruserid; }
            set { _masteruserid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "tranformactionid", ResourceType = typeof(CLL.LLClasses.Models._tran_applicationreqforvehicleactivitylog))]
        public long ? tranformactionid
        {
            get { return _tranformactionid; }
            set { _tranformactionid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(550)]
        [Display(Name = "updateinfo", ResourceType = typeof(CLL.LLClasses.Models._tran_applicationreqforvehicleactivitylog))]
        public string updateinfo
        {
            get { return _updateinfo; }
            set { _updateinfo = value; this.OnChnaged(); }
        }
        
        
        #endregion
    
        #region Constructor
    
        public tran_applicationreqforvehicleactivitylogEntity():base()
        {
        }
        
        public tran_applicationreqforvehicleactivitylogEntity(IDataReader reader)
        {
            this.LoadFromReader(reader);
        }
        
         public tran_applicationreqforvehicleactivitylogEntity(IDataReader reader, bool IsListViewShow)
        {
            this.LoadFromReader(reader, IsListViewShow);
        }
        
      
        
        protected void LoadFromReader(IDataReader reader)
        {
            if (reader != null && !reader.IsClosed)
            {
                this.BaseSecurityParam = new SecurityCapsule();
                if (!reader.IsDBNull(reader.GetOrdinal("RequestVehicleActivityLogID"))) _requestvehicleactivitylogid = reader.GetInt64(reader.GetOrdinal("RequestVehicleActivityLogID"));
                if (!reader.IsDBNull(reader.GetOrdinal("RequestVehicleID"))) _requestvehicleid = reader.GetInt64(reader.GetOrdinal("RequestVehicleID"));
                if (!reader.IsDBNull(reader.GetOrdinal("StatusId"))) _statusid = reader.GetInt64(reader.GetOrdinal("StatusId"));
                if (!reader.IsDBNull(reader.GetOrdinal("ActivityLogText"))) _activitylogtext = reader.GetString(reader.GetOrdinal("ActivityLogText"));
                if (!reader.IsDBNull(reader.GetOrdinal("LogTime"))) _logtime = reader.GetDateTime(reader.GetOrdinal("LogTime"));
                if (!reader.IsDBNull(reader.GetOrdinal("MasterUserId"))) _masteruserid = reader.GetInt64(reader.GetOrdinal("MasterUserId"));
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
                if (!reader.IsDBNull(reader.GetOrdinal("RequestVehicleActivityLogID"))) _requestvehicleactivitylogid = reader.GetInt64(reader.GetOrdinal("RequestVehicleActivityLogID"));
                if (!reader.IsDBNull(reader.GetOrdinal("RequestVehicleID"))) _requestvehicleid = reader.GetInt64(reader.GetOrdinal("RequestVehicleID"));
                if (!reader.IsDBNull(reader.GetOrdinal("StatusId"))) _statusid = reader.GetInt64(reader.GetOrdinal("StatusId"));
                if (!reader.IsDBNull(reader.GetOrdinal("ActivityLogText"))) _activitylogtext = reader.GetString(reader.GetOrdinal("ActivityLogText"));
                if (!reader.IsDBNull(reader.GetOrdinal("LogTime"))) _logtime = reader.GetDateTime(reader.GetOrdinal("LogTime"));
                if (!reader.IsDBNull(reader.GetOrdinal("MasterUserId"))) _masteruserid = reader.GetInt64(reader.GetOrdinal("MasterUserId"));
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
