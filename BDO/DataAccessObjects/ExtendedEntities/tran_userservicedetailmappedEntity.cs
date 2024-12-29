using System;
using System.Runtime.Serialization;
using System.Data;
using BDO.Core.Base;
using System.ComponentModel.DataAnnotations;


namespace BDO.Core.DataAccessObjects.Models
{
    public partial class tran_userservicedetailmappedEntity
    {
        [DataMember]
        public bool? isExt { get; set; }

        protected long? _masteruserid;

        [DataMember]
        public long? masteruserid
        {
            get { return _masteruserid; }
            set { _masteruserid = value; this.OnChnaged(); }
        }

        protected string _username;

        [DataMember]
        public string username
        {
            get { return _username; }
            set { _username = value; this.OnChnaged(); }
        }
        protected string _rolename;

        [DataMember]
        public string rolename
        {
            get { return _rolename; }
            set { _rolename = value; this.OnChnaged(); }
        }

        protected string _servicename;

        [DataMember]
        public string servicename
        {
            get { return _servicename; }
            set { _servicename = value; this.OnChnaged(); }
        }

        protected string _servicedetails;

        [DataMember]
        public string servicedetails
        {
            get { return _servicedetails; }
            set { _servicedetails = value; this.OnChnaged(); }
        }

        protected string _servicedetailids;

        [DataMember]
        public string servicedetailids
        {
            get { return _servicedetailids; }
            set { _servicedetailids = value; this.OnChnaged(); }
        }

        public tran_userservicedetailmappedEntity(IDataReader reader, bool IsListViewShow, bool isExt)
        {
            this.LoadFromReader_Ext(reader, IsListViewShow, isExt);
        }


        protected void LoadFromReader_Ext(IDataReader reader, bool IsListViewShow, bool isExt)
        {
            if (reader != null && !reader.IsClosed)
            {
                this.BaseSecurityParam = new SecurityCapsule();
                //if (!reader.IsDBNull(reader.GetOrdinal("ServiceDetailUserMappedID"))) _servicedetailusermappedid = reader.GetInt64(reader.GetOrdinal("ServiceDetailUserMappedID"));
                if (!reader.IsDBNull(reader.GetOrdinal("RoleID"))) _roleid = reader.GetInt64(reader.GetOrdinal("RoleID"));
                if (!reader.IsDBNull(reader.GetOrdinal("RoleName"))) _rolename = reader.GetString(reader.GetOrdinal("RoleName"));
                if (!reader.IsDBNull(reader.GetOrdinal("UserID"))) _userid = reader.GetGuid(reader.GetOrdinal("UserID"));
                if (!reader.IsDBNull(reader.GetOrdinal("UserName"))) _username = reader.GetString(reader.GetOrdinal("UserName"));
                if (!reader.IsDBNull(reader.GetOrdinal("ServiceID"))) _serviceid = reader.GetInt64(reader.GetOrdinal("ServiceID"));
                if (!reader.IsDBNull(reader.GetOrdinal("ServiceName"))) _servicename= reader.GetString(reader.GetOrdinal("ServiceName"));
                if (!reader.IsDBNull(reader.GetOrdinal("ServiceDetailIDs"))) _servicedetailids = reader.GetString(reader.GetOrdinal("ServiceDetailIDs"));
                if (!reader.IsDBNull(reader.GetOrdinal("ServiceDetails"))) _servicedetails = reader.GetString(reader.GetOrdinal("ServiceDetails"));
                //if (!reader.IsDBNull(reader.GetOrdinal("IsActive"))) _isactive = reader.GetBoolean(reader.GetOrdinal("IsActive"));
                //if (!reader.IsDBNull(reader.GetOrdinal("TransID"))) this.BaseSecurityParam.transid = reader.GetString(reader.GetOrdinal("TransID"));
                //if (!reader.IsDBNull(reader.GetOrdinal("CreatedByUserName"))) this.BaseSecurityParam.createdbyusername = reader.GetString(reader.GetOrdinal("CreatedByUserName"));
                //if (!reader.IsDBNull(reader.GetOrdinal("CreatedDate"))) this.BaseSecurityParam.createddate = reader.GetDateTime(reader.GetOrdinal("CreatedDate"));
                //if (!reader.IsDBNull(reader.GetOrdinal("UpdatedByUserName"))) this.BaseSecurityParam.updatedbyusername = reader.GetString(reader.GetOrdinal("UpdatedByUserName"));
                //if (!reader.IsDBNull(reader.GetOrdinal("UpdatedDate"))) this.BaseSecurityParam.updateddate = reader.GetDateTime(reader.GetOrdinal("UpdatedDate"));
                //if (!reader.IsDBNull(reader.GetOrdinal("IPAddress"))) this.BaseSecurityParam.ipaddress = reader.GetString(reader.GetOrdinal("IPAddress"));
                //if (!reader.IsDBNull(reader.GetOrdinal("TS"))) this.BaseSecurityParam.ts = reader.GetInt64(reader.GetOrdinal("ts"));
                CurrentState = EntityState.Unchanged;
            }
        }
    }
}
