using System;
using System.Runtime.Serialization;
using System.Data;
using BDO.Core.Base;
using System.ComponentModel.DataAnnotations;


namespace BDO.Core.DataAccessObjects.Models
{
    [Serializable]
    [DataContract(Name = "servicerequestprocessstatusinfoEntity", Namespace = "http://www.KAF.com/types")]
    public partial class servicerequestprocessstatusinfoEntity : BaseEntity
    {
        #region Properties
    
        protected long ? _servicerequestid;
        protected long ? _serviceid;
        protected DateTime ? _requestdate;
        protected long ? _applicantcivilid;
        protected string _applicantnote;
        protected long ? _servicestatusid;
        protected string _servicestatuschangenote;
        protected string _servicestatuschangedby;
        protected DateTime ? _servicestatuschangeddate;
        protected string _applicantrequestjson;
        protected string _notificationrequestjson;
        protected string _notificationresponsejson;
                
        
        [DataMember]
        public long ? servicerequestid
        {
            get { return _servicerequestid; }
            set { _servicerequestid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "serviceid", ResourceType = typeof(CLL.LLClasses.Models._servicerequestprocessstatusinfo))]
        public long ? serviceid
        {
            get { return _serviceid; }
            set { _serviceid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "requestdate", ResourceType = typeof(CLL.LLClasses.Models._servicerequestprocessstatusinfo))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._servicerequestprocessstatusinfo), ErrorMessageResourceName = "requestdateRequired")]
        public DateTime ? requestdate
        {
            get { return _requestdate; }
            set { _requestdate = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "applicantcivilid", ResourceType = typeof(CLL.LLClasses.Models._servicerequestprocessstatusinfo))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._servicerequestprocessstatusinfo), ErrorMessageResourceName = "applicantcivilidRequired")]
        public long ? applicantcivilid
        {
            get { return _applicantcivilid; }
            set { _applicantcivilid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "applicantnote", ResourceType = typeof(CLL.LLClasses.Models._servicerequestprocessstatusinfo))]
        public string applicantnote
        {
            get { return _applicantnote; }
            set { _applicantnote = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "servicestatusid", ResourceType = typeof(CLL.LLClasses.Models._servicerequestprocessstatusinfo))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._servicerequestprocessstatusinfo), ErrorMessageResourceName = "servicestatusidRequired")]
        public long ? servicestatusid
        {
            get { return _servicestatusid; }
            set { _servicestatusid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "servicestatuschangenote", ResourceType = typeof(CLL.LLClasses.Models._servicerequestprocessstatusinfo))]
        public string servicestatuschangenote
        {
            get { return _servicestatuschangenote; }
            set { _servicestatuschangenote = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(256)]
        [Display(Name = "servicestatuschangedby", ResourceType = typeof(CLL.LLClasses.Models._servicerequestprocessstatusinfo))]
        public string servicestatuschangedby
        {
            get { return _servicestatuschangedby; }
            set { _servicestatuschangedby = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "servicestatuschangeddate", ResourceType = typeof(CLL.LLClasses.Models._servicerequestprocessstatusinfo))]
        public DateTime ? servicestatuschangeddate
        {
            get { return _servicestatuschangeddate; }
            set { _servicestatuschangeddate = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "applicantrequestjson", ResourceType = typeof(CLL.LLClasses.Models._servicerequestprocessstatusinfo))]
        public string applicantrequestjson
        {
            get { return _applicantrequestjson; }
            set { _applicantrequestjson = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "notificationrequestjson", ResourceType = typeof(CLL.LLClasses.Models._servicerequestprocessstatusinfo))]
        public string notificationrequestjson
        {
            get { return _notificationrequestjson; }
            set { _notificationrequestjson = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "notificationresponsejson", ResourceType = typeof(CLL.LLClasses.Models._servicerequestprocessstatusinfo))]
        public string notificationresponsejson
        {
            get { return _notificationresponsejson; }
            set { _notificationresponsejson = value; this.OnChnaged(); }
        }
        
        
        #endregion
    
        #region Constructor
    
        public servicerequestprocessstatusinfoEntity():base()
        {
        }
        
        public servicerequestprocessstatusinfoEntity(IDataReader reader)
        {
            this.LoadFromReader(reader);
        }
        
         public servicerequestprocessstatusinfoEntity(IDataReader reader, bool IsListViewShow)
        {
            this.LoadFromReader(reader, IsListViewShow);
        }



        public void LoadFromReader(IDataReader reader)
        {
            if (reader != null && !reader.IsClosed)
            {
                this.BaseSecurityParam = new SecurityCapsule();
                if (!reader.IsDBNull(reader.GetOrdinal("ServiceRequestID"))) _servicerequestid = reader.GetInt64(reader.GetOrdinal("ServiceRequestID"));
                if (!reader.IsDBNull(reader.GetOrdinal("ServiceID"))) _serviceid = reader.GetInt64(reader.GetOrdinal("ServiceID"));
                if (!reader.IsDBNull(reader.GetOrdinal("RequestDate"))) _requestdate = reader.GetDateTime(reader.GetOrdinal("RequestDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("ApplicantCivilID"))) _applicantcivilid = reader.GetInt64(reader.GetOrdinal("ApplicantCivilID"));
                if (!reader.IsDBNull(reader.GetOrdinal("ApplicantNote"))) _applicantnote = reader.GetString(reader.GetOrdinal("ApplicantNote"));
                if (!reader.IsDBNull(reader.GetOrdinal("ServiceStatusID"))) _servicestatusid = reader.GetInt64(reader.GetOrdinal("ServiceStatusID"));
                if (!reader.IsDBNull(reader.GetOrdinal("ServiceStatusChangeNote"))) _servicestatuschangenote = reader.GetString(reader.GetOrdinal("ServiceStatusChangeNote"));
                if (!reader.IsDBNull(reader.GetOrdinal("ServiceStatusChangedBy"))) _servicestatuschangedby = reader.GetString(reader.GetOrdinal("ServiceStatusChangedBy"));
                if (!reader.IsDBNull(reader.GetOrdinal("ServiceStatusChangedDate"))) _servicestatuschangeddate = reader.GetDateTime(reader.GetOrdinal("ServiceStatusChangedDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("ApplicantRequestJson"))) _applicantrequestjson = reader.GetString(reader.GetOrdinal("ApplicantRequestJson"));
                if (!reader.IsDBNull(reader.GetOrdinal("NotificationRequestJson"))) _notificationrequestjson = reader.GetString(reader.GetOrdinal("NotificationRequestJson"));
                if (!reader.IsDBNull(reader.GetOrdinal("NotificationResponseJson"))) _notificationresponsejson = reader.GetString(reader.GetOrdinal("NotificationResponseJson"));
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
                if (!reader.IsDBNull(reader.GetOrdinal("ServiceRequestID"))) _servicerequestid = reader.GetInt64(reader.GetOrdinal("ServiceRequestID"));
                if (!reader.IsDBNull(reader.GetOrdinal("ServiceID"))) _serviceid = reader.GetInt64(reader.GetOrdinal("ServiceID"));
                if (!reader.IsDBNull(reader.GetOrdinal("RequestDate"))) _requestdate = reader.GetDateTime(reader.GetOrdinal("RequestDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("ApplicantCivilID"))) _applicantcivilid = reader.GetInt64(reader.GetOrdinal("ApplicantCivilID"));
                if (!reader.IsDBNull(reader.GetOrdinal("ApplicantNote"))) _applicantnote = reader.GetString(reader.GetOrdinal("ApplicantNote"));
                if (!reader.IsDBNull(reader.GetOrdinal("ServiceStatusID"))) _servicestatusid = reader.GetInt64(reader.GetOrdinal("ServiceStatusID"));
                if (!reader.IsDBNull(reader.GetOrdinal("ServiceStatusChangeNote"))) _servicestatuschangenote = reader.GetString(reader.GetOrdinal("ServiceStatusChangeNote"));
                if (!reader.IsDBNull(reader.GetOrdinal("ServiceStatusChangedBy"))) _servicestatuschangedby = reader.GetString(reader.GetOrdinal("ServiceStatusChangedBy"));
                if (!reader.IsDBNull(reader.GetOrdinal("ServiceStatusChangedDate"))) _servicestatuschangeddate = reader.GetDateTime(reader.GetOrdinal("ServiceStatusChangedDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("ApplicantRequestJson"))) _applicantrequestjson = reader.GetString(reader.GetOrdinal("ApplicantRequestJson"));
                if (!reader.IsDBNull(reader.GetOrdinal("NotificationRequestJson"))) _notificationrequestjson = reader.GetString(reader.GetOrdinal("NotificationRequestJson"));
                if (!reader.IsDBNull(reader.GetOrdinal("NotificationResponseJson"))) _notificationresponsejson = reader.GetString(reader.GetOrdinal("NotificationResponseJson"));
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


        public servicerequestprocessstatusinfoEntity(IDataReader reader, bool IsListViewShow, int i)
        {
            this.LoadFromReader(reader, IsListViewShow, i);
        }



        protected void LoadFromReader(IDataReader reader, bool IsListViewShow, int i)
        {
            if (reader != null && !reader.IsClosed)
            {
                this.BaseSecurityParam = new SecurityCapsule();
                if (!reader.IsDBNull(reader.GetOrdinal("MilitaryNo"))) _servicerequestid = reader.GetInt64(reader.GetOrdinal("MilitaryNo"));
                if (!reader.IsDBNull(reader.GetOrdinal("CivilID"))) _applicantcivilid = reader.GetInt64(reader.GetOrdinal("CivilID"));
                if (!reader.IsDBNull(reader.GetOrdinal("FullName"))) _applicantnote = reader.GetString(reader.GetOrdinal("FullName"));
                if (!reader.IsDBNull(reader.GetOrdinal("RankName"))) _servicestatuschangenote = reader.GetString(reader.GetOrdinal("RankName"));
                CurrentState = EntityState.Unchanged;
            }
        }

        #endregion



    }
}
