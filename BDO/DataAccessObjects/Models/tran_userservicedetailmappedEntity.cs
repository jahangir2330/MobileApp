﻿using System;
using System.Runtime.Serialization;
using System.Data;
using BDO.Core.Base;
using System.ComponentModel.DataAnnotations;


namespace BDO.Core.DataAccessObjects.Models
{
    [Serializable]
    [DataContract(Name = "tran_userservicedetailmappedEntity", Namespace = "http://www.KAF.com/types")]
    public partial class tran_userservicedetailmappedEntity : BaseEntity
    {
        #region Properties
    
        protected long ? _servicedetailusermappedid;
        protected long ? _roleid;
        protected Guid ? _userid;
        protected long ? _serviceid;
        protected long ? _servicedetailid;
        protected bool ? _isactive;
                
        
        [DataMember]
        public long ? servicedetailusermappedid
        {
            get { return _servicedetailusermappedid; }
            set { _servicedetailusermappedid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "roleid", ResourceType = typeof(CLL.LLClasses.Models._tran_userservicedetailmapped))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._tran_userservicedetailmapped), ErrorMessageResourceName = "roleidRequired")]
        public long ? roleid
        {
            get { return _roleid; }
            set { _roleid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "userid", ResourceType = typeof(CLL.LLClasses.Models._tran_userservicedetailmapped))]
        public Guid ? userid
        {
            get { return _userid; }
            set { _userid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "serviceid", ResourceType = typeof(CLL.LLClasses.Models._tran_userservicedetailmapped))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._tran_userservicedetailmapped), ErrorMessageResourceName = "serviceidRequired")]
        public long ? serviceid
        {
            get { return _serviceid; }
            set { _serviceid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "servicedetailid", ResourceType = typeof(CLL.LLClasses.Models._tran_userservicedetailmapped))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._tran_userservicedetailmapped), ErrorMessageResourceName = "servicedetailidRequired")]
        public long ? servicedetailid
        {
            get { return _servicedetailid; }
            set { _servicedetailid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "isactive", ResourceType = typeof(CLL.LLClasses.Models._tran_userservicedetailmapped))]
        public bool ? isactive
        {
            get { return _isactive; }
            set { _isactive = value; this.OnChnaged(); }
        }
        
        
        #endregion
    
        #region Constructor
    
        public tran_userservicedetailmappedEntity():base()
        {
        }
        
        public tran_userservicedetailmappedEntity(IDataReader reader)
        {
            this.LoadFromReader(reader);
        }
        
         public tran_userservicedetailmappedEntity(IDataReader reader, bool IsListViewShow)
        {
            this.LoadFromReader(reader, IsListViewShow);
        }
        
      
        
        protected void LoadFromReader(IDataReader reader)
        {
            if (reader != null && !reader.IsClosed)
            {
                this.BaseSecurityParam = new SecurityCapsule();
                if (!reader.IsDBNull(reader.GetOrdinal("ServiceDetailUserMappedID"))) _servicedetailusermappedid = reader.GetInt64(reader.GetOrdinal("ServiceDetailUserMappedID"));
                if (!reader.IsDBNull(reader.GetOrdinal("RoleID"))) _roleid = reader.GetInt64(reader.GetOrdinal("RoleID"));
                if (!reader.IsDBNull(reader.GetOrdinal("UserID"))) _userid = reader.GetGuid(reader.GetOrdinal("UserID"));
                if (!reader.IsDBNull(reader.GetOrdinal("ServiceID"))) _serviceid = reader.GetInt64(reader.GetOrdinal("ServiceID"));
                if (!reader.IsDBNull(reader.GetOrdinal("ServiceDetailID"))) _servicedetailid = reader.GetInt64(reader.GetOrdinal("ServiceDetailID"));
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
                if (!reader.IsDBNull(reader.GetOrdinal("ServiceDetailUserMappedID"))) _servicedetailusermappedid = reader.GetInt64(reader.GetOrdinal("ServiceDetailUserMappedID"));
                if (!reader.IsDBNull(reader.GetOrdinal("RoleID"))) _roleid = reader.GetInt64(reader.GetOrdinal("RoleID"));
                if (!reader.IsDBNull(reader.GetOrdinal("UserID"))) _userid = reader.GetGuid(reader.GetOrdinal("UserID"));
                if (!reader.IsDBNull(reader.GetOrdinal("ServiceID"))) _serviceid = reader.GetInt64(reader.GetOrdinal("ServiceID"));
                if (!reader.IsDBNull(reader.GetOrdinal("ServiceDetailID"))) _servicedetailid = reader.GetInt64(reader.GetOrdinal("ServiceDetailID"));
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
        
        #endregion
        
        
            
    }
}
