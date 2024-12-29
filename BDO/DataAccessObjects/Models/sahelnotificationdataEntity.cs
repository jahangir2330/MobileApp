using System;
using System.Runtime.Serialization;
using System.Data;
using BDO.Core.Base;
using System.ComponentModel.DataAnnotations;


namespace BDO.Core.DataAccessObjects.Models
{
    [Serializable]
    [DataContract(Name = "sahelnotificationdataEntity", Namespace = "http://www.KAF.com/types")]
    public partial class sahelnotificationdataEntity : BaseEntity
    {
        #region Properties
    
        protected long ? _sahelnotificationid;
        protected string _notificationrequestjson;
        protected string _notificationresponsejson;
        protected long ? _applicantcivilid;
        protected bool ? _issuccess;
        protected DateTime ? _sentdatetime;
        protected string _referenceapptag;
        protected string _referenceid;
                
        
        [DataMember]
        public long ? sahelnotificationid
        {
            get { return _sahelnotificationid; }
            set { _sahelnotificationid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(-1)]
        [Display(Name = "notificationrequestjson", ResourceType = typeof(CLL.LLClasses.Models._sahelnotificationdata))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._sahelnotificationdata), ErrorMessageResourceName = "notificationrequestjsonRequired")]
        public string notificationrequestjson
        {
            get { return _notificationrequestjson; }
            set { _notificationrequestjson = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(-1)]
        [Display(Name = "notificationresponsejson", ResourceType = typeof(CLL.LLClasses.Models._sahelnotificationdata))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._sahelnotificationdata), ErrorMessageResourceName = "notificationresponsejsonRequired")]
        public string notificationresponsejson
        {
            get { return _notificationresponsejson; }
            set { _notificationresponsejson = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "applicantcivilid", ResourceType = typeof(CLL.LLClasses.Models._sahelnotificationdata))]
        public long ? applicantcivilid
        {
            get { return _applicantcivilid; }
            set { _applicantcivilid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "issuccess", ResourceType = typeof(CLL.LLClasses.Models._sahelnotificationdata))]
        public bool ? issuccess
        {
            get { return _issuccess; }
            set { _issuccess = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "sentdatetime", ResourceType = typeof(CLL.LLClasses.Models._sahelnotificationdata))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._sahelnotificationdata), ErrorMessageResourceName = "sentdatetimeRequired")]
        public DateTime ? sentdatetime
        {
            get { return _sentdatetime; }
            set { _sentdatetime = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(50)]
        [Display(Name = "referenceapptag", ResourceType = typeof(CLL.LLClasses.Models._sahelnotificationdata))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._sahelnotificationdata), ErrorMessageResourceName = "referenceapptagRequired")]
        public string referenceapptag
        {
            get { return _referenceapptag; }
            set { _referenceapptag = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(150)]
        [Display(Name = "referenceid", ResourceType = typeof(CLL.LLClasses.Models._sahelnotificationdata))]
        public string referenceid
        {
            get { return _referenceid; }
            set { _referenceid = value; this.OnChnaged(); }
        }
        
        
        #endregion
    
        #region Constructor
    
        public sahelnotificationdataEntity():base()
        {
        }
        
        public sahelnotificationdataEntity(IDataReader reader)
        {
            this.LoadFromReader(reader);
        }
        
         public sahelnotificationdataEntity(IDataReader reader, bool IsListViewShow)
        {
            this.LoadFromReader(reader, IsListViewShow);
        }
        
      
        
        protected void LoadFromReader(IDataReader reader)
        {
            if (reader != null && !reader.IsClosed)
            {
                this.BaseSecurityParam = new SecurityCapsule();
                if (!reader.IsDBNull(reader.GetOrdinal("SahelNotificationID"))) _sahelnotificationid = reader.GetInt64(reader.GetOrdinal("SahelNotificationID"));
                if (!reader.IsDBNull(reader.GetOrdinal("NotificationRequestJSon"))) _notificationrequestjson = reader.GetString(reader.GetOrdinal("NotificationRequestJSon"));
                if (!reader.IsDBNull(reader.GetOrdinal("NotificationResponseJSon"))) _notificationresponsejson = reader.GetString(reader.GetOrdinal("NotificationResponseJSon"));
                if (!reader.IsDBNull(reader.GetOrdinal("ApplicantCivilID"))) _applicantcivilid = reader.GetInt64(reader.GetOrdinal("ApplicantCivilID"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsSuccess"))) _issuccess = reader.GetBoolean(reader.GetOrdinal("IsSuccess"));
                if (!reader.IsDBNull(reader.GetOrdinal("SentDatetime"))) _sentdatetime = reader.GetDateTime(reader.GetOrdinal("SentDatetime"));
                if (!reader.IsDBNull(reader.GetOrdinal("ReferenceAppTAG"))) _referenceapptag = reader.GetString(reader.GetOrdinal("ReferenceAppTAG"));
                if (!reader.IsDBNull(reader.GetOrdinal("ReferenceID"))) _referenceid = reader.GetString(reader.GetOrdinal("ReferenceID"));
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
                if (!reader.IsDBNull(reader.GetOrdinal("SahelNotificationID"))) _sahelnotificationid = reader.GetInt64(reader.GetOrdinal("SahelNotificationID"));
                if (!reader.IsDBNull(reader.GetOrdinal("NotificationRequestJSon"))) _notificationrequestjson = reader.GetString(reader.GetOrdinal("NotificationRequestJSon"));
                if (!reader.IsDBNull(reader.GetOrdinal("NotificationResponseJSon"))) _notificationresponsejson = reader.GetString(reader.GetOrdinal("NotificationResponseJSon"));
                if (!reader.IsDBNull(reader.GetOrdinal("ApplicantCivilID"))) _applicantcivilid = reader.GetInt64(reader.GetOrdinal("ApplicantCivilID"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsSuccess"))) _issuccess = reader.GetBoolean(reader.GetOrdinal("IsSuccess"));
                if (!reader.IsDBNull(reader.GetOrdinal("SentDatetime"))) _sentdatetime = reader.GetDateTime(reader.GetOrdinal("SentDatetime"));
                if (!reader.IsDBNull(reader.GetOrdinal("ReferenceAppTAG"))) _referenceapptag = reader.GetString(reader.GetOrdinal("ReferenceAppTAG"));
                if (!reader.IsDBNull(reader.GetOrdinal("ReferenceID"))) _referenceid = reader.GetString(reader.GetOrdinal("ReferenceID"));
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
