using System;
using System.Runtime.Serialization;
using System.Data;
using BDO.Core.Base;
using System.ComponentModel.DataAnnotations;


namespace BDO.Core.DataAccessObjects.Models
{
    [Serializable]
    [DataContract(Name = "transervicerequestsalaryEntity", Namespace = "http://www.KAF.com/types")]
    public partial class transervicerequestsalaryEntity : BaseEntity
    {
        #region Properties
    
        protected long ? _requestserialid;
        protected long ? _serviceid;
        protected string _servicemethod;
        protected string _servicecontroller;
        protected string _requestercivilid;
        protected string _requestermilitaryid;
        protected DateTime ? _requestdatetime;
        protected string _securitytoken;
        protected bool ? _consumed;
        protected DateTime ? _consumeddatetime;
        protected string _ademail;
        protected string _militaryobject;
        protected int? _codetrycounter;


        [DataMember]
        public long ? requestserialid
        {
            get { return _requestserialid; }
            set { _requestserialid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "serviceid", ResourceType = typeof(CLL.LLClasses.Models._transervicerequestsalary))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._transervicerequestsalary), ErrorMessageResourceName = "serviceidRequired")]
        public long ? serviceid
        {
            get { return _serviceid; }
            set { _serviceid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(250)]
        [Display(Name = "servicemethod", ResourceType = typeof(CLL.LLClasses.Models._transervicerequestsalary))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._transervicerequestsalary), ErrorMessageResourceName = "servicemethodRequired")]
        public string servicemethod
        {
            get { return _servicemethod; }
            set { _servicemethod = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(250)]
        [Display(Name = "servicecontroller", ResourceType = typeof(CLL.LLClasses.Models._transervicerequestsalary))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._transervicerequestsalary), ErrorMessageResourceName = "servicecontrollerRequired")]
        public string servicecontroller
        {
            get { return _servicecontroller; }
            set { _servicecontroller = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(50)]
        [Display(Name = "requestercivilid", ResourceType = typeof(CLL.LLClasses.Models._transervicerequestsalary))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._transervicerequestsalary), ErrorMessageResourceName = "requestercivilidRequired")]
        public string requestercivilid
        {
            get { return _requestercivilid; }
            set { _requestercivilid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(50)]
        [Display(Name = "requestermilitaryid", ResourceType = typeof(CLL.LLClasses.Models._transervicerequestsalary))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._transervicerequestsalary), ErrorMessageResourceName = "requestermilitaryidRequired")]
        public string requestermilitaryid
        {
            get { return _requestermilitaryid; }
            set { _requestermilitaryid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "requestdatetime", ResourceType = typeof(CLL.LLClasses.Models._transervicerequestsalary))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._transervicerequestsalary), ErrorMessageResourceName = "requestdatetimeRequired")]
        public DateTime ? requestdatetime
        {
            get { return _requestdatetime; }
            set { _requestdatetime = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(50)]
        [Display(Name = "securitytoken", ResourceType = typeof(CLL.LLClasses.Models._transervicerequestsalary))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._transervicerequestsalary), ErrorMessageResourceName = "securitytokenRequired")]
        public string securitytoken
        {
            get { return _securitytoken; }
            set { _securitytoken = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "consumed", ResourceType = typeof(CLL.LLClasses.Models._transervicerequestsalary))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._transervicerequestsalary), ErrorMessageResourceName = "consumedRequired")]
        public bool ? consumed
        {
            get { return _consumed; }
            set { _consumed = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "consumeddatetime", ResourceType = typeof(CLL.LLClasses.Models._transervicerequestsalary))]
        public DateTime ? consumeddatetime
        {
            get { return _consumeddatetime; }
            set { _consumeddatetime = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(250)]
        [Display(Name = "ademail", ResourceType = typeof(CLL.LLClasses.Models._transervicerequestsalary))]
        public string ademail
        {
            get { return _ademail; }
            set { _ademail = value; this.OnChnaged(); }
        }

        [DataMember]
        //[Display(Name = "militaryobject", ResourceType = typeof(CLL.LLClasses.Models._transervicerequestsalary))]
        public string militaryobject
        {
            get { return _militaryobject; }
            set { _militaryobject = value; this.OnChnaged(); }
        }


        [DataMember]
        public int? codetrycounter
        {
            get { return _codetrycounter; }
            set { _codetrycounter = value; this.OnChnaged(); }
        }
        #endregion

        #region Constructor

        public transervicerequestsalaryEntity():base()
        {
        }
        
        public transervicerequestsalaryEntity(IDataReader reader)
        {
            this.LoadFromReader(reader);
        }
        
         public transervicerequestsalaryEntity(IDataReader reader, bool IsListViewShow)
        {
            this.LoadFromReader(reader, IsListViewShow);
        }
        
      
        
        protected void LoadFromReader(IDataReader reader)
        {
            if (reader != null && !reader.IsClosed)
            {
                this.BaseSecurityParam = new SecurityCapsule();
                if (!reader.IsDBNull(reader.GetOrdinal("RequestSerialID"))) _requestserialid = reader.GetInt64(reader.GetOrdinal("RequestSerialID"));
                if (!reader.IsDBNull(reader.GetOrdinal("ServiceID"))) _serviceid = reader.GetInt64(reader.GetOrdinal("ServiceID"));
                if (!reader.IsDBNull(reader.GetOrdinal("ServiceMethod"))) _servicemethod = reader.GetString(reader.GetOrdinal("ServiceMethod"));
                if (!reader.IsDBNull(reader.GetOrdinal("ServiceController"))) _servicecontroller = reader.GetString(reader.GetOrdinal("ServiceController"));
                if (!reader.IsDBNull(reader.GetOrdinal("RequesterCivilID"))) _requestercivilid = reader.GetString(reader.GetOrdinal("RequesterCivilID"));
                if (!reader.IsDBNull(reader.GetOrdinal("RequesterMilitaryID"))) _requestermilitaryid = reader.GetString(reader.GetOrdinal("RequesterMilitaryID"));
                if (!reader.IsDBNull(reader.GetOrdinal("RequestDateTime"))) _requestdatetime = reader.GetDateTime(reader.GetOrdinal("RequestDateTime"));
                if (!reader.IsDBNull(reader.GetOrdinal("SecurityToken"))) _securitytoken = reader.GetString(reader.GetOrdinal("SecurityToken"));
                if (!reader.IsDBNull(reader.GetOrdinal("Consumed"))) _consumed = reader.GetBoolean(reader.GetOrdinal("Consumed"));
                if (!reader.IsDBNull(reader.GetOrdinal("ConsumedDateTime"))) _consumeddatetime = reader.GetDateTime(reader.GetOrdinal("ConsumedDateTime"));
                if (!reader.IsDBNull(reader.GetOrdinal("ADEmail"))) _ademail = reader.GetString(reader.GetOrdinal("ADEmail"));
                if (!reader.IsDBNull(reader.GetOrdinal("MilitaryObject"))) _militaryobject = reader.GetString(reader.GetOrdinal("MilitaryObject"));
                if (!reader.IsDBNull(reader.GetOrdinal("CodeTryCounter"))) _codetrycounter = reader.GetInt32(reader.GetOrdinal("CodeTryCounter"));
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
                if (!reader.IsDBNull(reader.GetOrdinal("RequestSerialID"))) _requestserialid = reader.GetInt64(reader.GetOrdinal("RequestSerialID"));
                if (!reader.IsDBNull(reader.GetOrdinal("ServiceID"))) _serviceid = reader.GetInt64(reader.GetOrdinal("ServiceID"));
                if (!reader.IsDBNull(reader.GetOrdinal("ServiceMethod"))) _servicemethod = reader.GetString(reader.GetOrdinal("ServiceMethod"));
                if (!reader.IsDBNull(reader.GetOrdinal("ServiceController"))) _servicecontroller = reader.GetString(reader.GetOrdinal("ServiceController"));
                if (!reader.IsDBNull(reader.GetOrdinal("RequesterCivilID"))) _requestercivilid = reader.GetString(reader.GetOrdinal("RequesterCivilID"));
                if (!reader.IsDBNull(reader.GetOrdinal("RequesterMilitaryID"))) _requestermilitaryid = reader.GetString(reader.GetOrdinal("RequesterMilitaryID"));
                if (!reader.IsDBNull(reader.GetOrdinal("RequestDateTime"))) _requestdatetime = reader.GetDateTime(reader.GetOrdinal("RequestDateTime"));
                if (!reader.IsDBNull(reader.GetOrdinal("SecurityToken"))) _securitytoken = reader.GetString(reader.GetOrdinal("SecurityToken"));
                if (!reader.IsDBNull(reader.GetOrdinal("Consumed"))) _consumed = reader.GetBoolean(reader.GetOrdinal("Consumed"));
                if (!reader.IsDBNull(reader.GetOrdinal("ConsumedDateTime"))) _consumeddatetime = reader.GetDateTime(reader.GetOrdinal("ConsumedDateTime"));
                if (!reader.IsDBNull(reader.GetOrdinal("ADEmail"))) _ademail = reader.GetString(reader.GetOrdinal("ADEmail"));
                if (!reader.IsDBNull(reader.GetOrdinal("MilitaryObject"))) _militaryobject = reader.GetString(reader.GetOrdinal("MilitaryObject"));
                if (!reader.IsDBNull(reader.GetOrdinal("CodeTryCounter"))) _codetrycounter = reader.GetInt32(reader.GetOrdinal("CodeTryCounter"));
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
