using System;
using System.Runtime.Serialization;
using System.Data;
using BDO.Core.Base;
using System.ComponentModel.DataAnnotations;


namespace BDO.Core.DataAccessObjects.Models
{
    [Serializable]
    [DataContract(Name = "servicestatusmappedinfoEntity", Namespace = "http://www.KAF.com/types")]
    public partial class servicestatusmappedinfoEntity : BaseEntity
    {
        #region Properties
    
        protected long ? _servicestatusmappedid;
        protected string _servicestatusname;
        protected long ? _serviceid;
        protected long ? _servicestatusid;
        protected bool ? _isactive;
                
        
        [DataMember]
        public long ? servicestatusmappedid
        {
            get { return _servicestatusmappedid; }
            set { _servicestatusmappedid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(150)]
        [Display(Name = "servicestatusname", ResourceType = typeof(CLL.LLClasses.Models._servicestatusmappedinfo))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._servicestatusmappedinfo), ErrorMessageResourceName = "servicestatusnameRequired")]
        public string servicestatusname
        {
            get { return _servicestatusname; }
            set { _servicestatusname = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "serviceid", ResourceType = typeof(CLL.LLClasses.Models._servicestatusmappedinfo))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._servicestatusmappedinfo), ErrorMessageResourceName = "serviceidRequired")]
        public long ? serviceid
        {
            get { return _serviceid; }
            set { _serviceid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "servicestatusid", ResourceType = typeof(CLL.LLClasses.Models._servicestatusmappedinfo))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._servicestatusmappedinfo), ErrorMessageResourceName = "servicestatusidRequired")]
        public long ? servicestatusid
        {
            get { return _servicestatusid; }
            set { _servicestatusid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "isactive", ResourceType = typeof(CLL.LLClasses.Models._servicestatusmappedinfo))]
        public bool ? isactive
        {
            get { return _isactive; }
            set { _isactive = value; this.OnChnaged(); }
        }
        
        
        #endregion
    
        #region Constructor
    
        public servicestatusmappedinfoEntity():base()
        {
        }
        
        public servicestatusmappedinfoEntity(IDataReader reader)
        {
            this.LoadFromReader(reader);
        }
        
         public servicestatusmappedinfoEntity(IDataReader reader, bool IsListViewShow)
        {
            this.LoadFromReader(reader, IsListViewShow);
        }
        public servicestatusmappedinfoEntity(IDataReader reader, bool IsListViewShow, bool IsExt)
        {
            this.LoadFromReader(reader, IsListViewShow, IsExt);
        }



        protected void LoadFromReader(IDataReader reader)
        {
            if (reader != null && !reader.IsClosed)
            {
                this.BaseSecurityParam = new SecurityCapsule();
                if (!reader.IsDBNull(reader.GetOrdinal("ServiceStatusMappedID"))) _servicestatusmappedid = reader.GetInt64(reader.GetOrdinal("ServiceStatusMappedID"));
                if (!reader.IsDBNull(reader.GetOrdinal("ServiceStatusName"))) _servicestatusname = reader.GetString(reader.GetOrdinal("ServiceStatusName"));
                if (!reader.IsDBNull(reader.GetOrdinal("ServiceID"))) _serviceid = reader.GetInt64(reader.GetOrdinal("ServiceID"));
                if (!reader.IsDBNull(reader.GetOrdinal("ServiceStatusID"))) _servicestatusid = reader.GetInt64(reader.GetOrdinal("ServiceStatusID"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsActive"))) _isactive = reader.GetBoolean(reader.GetOrdinal("IsActive"));
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
                if (!reader.IsDBNull(reader.GetOrdinal("ServiceStatusMappedID"))) _servicestatusmappedid = reader.GetInt64(reader.GetOrdinal("ServiceStatusMappedID"));
                if (!reader.IsDBNull(reader.GetOrdinal("ServiceStatusName"))) _servicestatusname = reader.GetString(reader.GetOrdinal("ServiceStatusName"));
                if (!reader.IsDBNull(reader.GetOrdinal("ServiceID"))) _serviceid = reader.GetInt64(reader.GetOrdinal("ServiceID"));
                if (!reader.IsDBNull(reader.GetOrdinal("ServiceStatusID"))) _servicestatusid = reader.GetInt64(reader.GetOrdinal("ServiceStatusID"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsActive"))) _isactive = reader.GetBoolean(reader.GetOrdinal("IsActive"));
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

        protected void LoadFromReader(IDataReader reader, bool IsListViewShow, bool IsExt)
        {
            if (reader != null && !reader.IsClosed)
            {
                this.BaseSecurityParam = new SecurityCapsule();
                if (!reader.IsDBNull(reader.GetOrdinal("ServiceAR"))) _ServiceAR = reader.GetString(reader.GetOrdinal("ServiceAR"));
                if (!reader.IsDBNull(reader.GetOrdinal("ServiceStatusName"))) _servicestatusname = reader.GetString(reader.GetOrdinal("ServiceStatusName"));
                if (!reader.IsDBNull(reader.GetOrdinal("ServiceID"))) _serviceid = reader.GetInt64(reader.GetOrdinal("ServiceID"));
 
                CurrentState = EntityState.Unchanged;
            }
        }

        #endregion



    }
}
