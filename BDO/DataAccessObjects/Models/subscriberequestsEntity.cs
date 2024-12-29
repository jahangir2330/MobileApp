using System;
using System.Runtime.Serialization;
using System.Data;
using BDO.Core.Base;
using System.ComponentModel.DataAnnotations;


namespace BDO.Core.DataAccessObjects.Models
{
    [Serializable]
    [DataContract(Name = "subscriberequestsEntity", Namespace = "http://www.KAF.com/types")]
    public partial class subscriberequestsEntity : BaseEntity
    {
        #region Properties
    
        protected long ? _userrequestid;
        protected DateTime ? _requestdate;
        protected string _requesteduserinfojson;
                
        
        [DataMember]
        public long ? userrequestid
        {
            get { return _userrequestid; }
            set { _userrequestid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "requestdate", ResourceType = typeof(CLL.LLClasses.Models._subscriberequests))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._subscriberequests), ErrorMessageResourceName = "requestdateRequired")]
        public DateTime ? requestdate
        {
            get { return _requestdate; }
            set { _requestdate = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(-1)]
        [Display(Name = "requesteduserinfojson", ResourceType = typeof(CLL.LLClasses.Models._subscriberequests))]
        public string requesteduserinfojson
        {
            get { return _requesteduserinfojson; }
            set { _requesteduserinfojson = value; this.OnChnaged(); }
        }
        
        
        #endregion
    
        #region Constructor
    
        public subscriberequestsEntity():base()
        {
        }
        
        public subscriberequestsEntity(IDataReader reader)
        {
            this.LoadFromReader(reader);
        }
        
         public subscriberequestsEntity(IDataReader reader, bool IsListViewShow)
        {
            this.LoadFromReader(reader, IsListViewShow);
        }
        
      
        
        protected void LoadFromReader(IDataReader reader)
        {
            if (reader != null && !reader.IsClosed)
            {
                this.BaseSecurityParam = new SecurityCapsule();
                if (!reader.IsDBNull(reader.GetOrdinal("UserRequestID"))) _userrequestid = reader.GetInt64(reader.GetOrdinal("UserRequestID"));
                if (!reader.IsDBNull(reader.GetOrdinal("RequestDate"))) _requestdate = reader.GetDateTime(reader.GetOrdinal("RequestDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("RequestedUserInfoJson"))) _requesteduserinfojson = reader.GetString(reader.GetOrdinal("RequestedUserInfoJson"));
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
                if (!reader.IsDBNull(reader.GetOrdinal("UserRequestID"))) _userrequestid = reader.GetInt64(reader.GetOrdinal("UserRequestID"));
                if (!reader.IsDBNull(reader.GetOrdinal("RequestDate"))) _requestdate = reader.GetDateTime(reader.GetOrdinal("RequestDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("RequestedUserInfoJson"))) _requesteduserinfojson = reader.GetString(reader.GetOrdinal("RequestedUserInfoJson"));
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
