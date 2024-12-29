using System;
using System.Runtime.Serialization;
using System.Data;
using BDO.Core.Base;
using System.ComponentModel.DataAnnotations;
using BDO.Core.DataAccessObjects.CommonEntities;
using Microsoft.AspNetCore.Identity;

namespace BDO.Core.DataAccessObjects.Models
{
    public partial class tran_applicationreqforvehicleactivitylogEntity
    {

        protected string _statusname;
        protected string _statusnamear;

        protected string _requestername;
        protected string _requesternamear;
        protected long? _companyid;
        protected string _emailaddress;

        protected string _mobileno;
        protected long? _mobilenotypeid;

        protected string _companyname;
        protected string _companynamear;

        protected string _mobilenotypename;
        protected string _mobilenotypenamear;

        [DataMember]
        [MaxLength(150)]
        [Display(Name = "statusname", ResourceType = typeof(CLL.LLClasses.Models._gen_status))]
        public string statusname
        {
            get { return _statusname; }
            set { _statusname = value; this.OnChnaged(); }
        }

        [DataMember]
        [MaxLength(150)]
        [Display(Name = "statusnamear", ResourceType = typeof(CLL.LLClasses.Models._gen_status))]
        public string statusnamear
        {
            get { return _statusnamear; }
            set { _statusnamear = value; this.OnChnaged(); }
        }

        [DataMember]
        [MaxLength(150)]
        [Display(Name = "mobileno", ResourceType = typeof(CLL.LLClasses.Models._gen_requester))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._gen_requester), ErrorMessageResourceName = "mobilenoRequired")]
        public string mobileno
        {
            get { return _mobileno; }
            set { _mobileno = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "mobilenotypeid", ResourceType = typeof(CLL.LLClasses.Models._gen_requester))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._gen_requester), ErrorMessageResourceName = "mobilenotypeidRequired")]
        public long? mobilenotypeid
        {
            get { return _mobilenotypeid; }
            set { _mobilenotypeid = value; this.OnChnaged(); }
        }

        [DataMember]
        [MaxLength(150)]
        [Display(Name = "emailaddress", ResourceType = typeof(CLL.LLClasses.Models._gen_requester))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._gen_requester), ErrorMessageResourceName = "emailaddressRequired")]
        public string emailaddress
        {
            get { return _emailaddress; }
            set { _emailaddress = value; this.OnChnaged(); }
        }

        [DataMember]
        [MaxLength(150)]
        [Display(Name = "requestername", ResourceType = typeof(CLL.LLClasses.Models._gen_requester))]
        public string requestername
        {
            get { return _requestername; }
            set { _requestername = value; this.OnChnaged(); }
        }

        [DataMember]
        [MaxLength(150)]
        [Display(Name = "requesternamear", ResourceType = typeof(CLL.LLClasses.Models._gen_requester))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._gen_requester), ErrorMessageResourceName = "requesternamearRequired")]
        public string requesternamear
        {
            get { return _requesternamear; }
            set { _requesternamear = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "companyid", ResourceType = typeof(CLL.LLClasses.Models._gen_requester))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._gen_requester), ErrorMessageResourceName = "companyidRequired")]
        public long? companyid
        {
            get { return _companyid; }
            set { _companyid = value; this.OnChnaged(); }
        }
        [DataMember]
        [MaxLength(150)]
        [Display(Name = "companyname", ResourceType = typeof(CLL.LLClasses.Models._gen_company))]
        public string companyname
        {
            get { return _companyname; }
            set { _companyname = value; this.OnChnaged(); }
        }

        [DataMember]
        [MaxLength(150)]
        [Display(Name = "companynamear", ResourceType = typeof(CLL.LLClasses.Models._gen_company))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._gen_company), ErrorMessageResourceName = "companynamearRequired")]
        public string companynamear
        {
            get { return _companynamear; }
            set { _companynamear = value; this.OnChnaged(); }
        }

        [DataMember]
        [MaxLength(150)]
        [Display(Name = "mobilenotypename", ResourceType = typeof(CLL.LLClasses.Models._gen_mobilenotype))]
        public string mobilenotypename
        {
            get { return _mobilenotypename; }
            set { _mobilenotypename = value; this.OnChnaged(); }
        }

        [DataMember]
        [MaxLength(150)]
        [Display(Name = "mobilenotypenamear", ResourceType = typeof(CLL.LLClasses.Models._gen_mobilenotype))]
        public string mobilenotypenamear
        {
            get { return _mobilenotypenamear; }
            set { _mobilenotypenamear = value; this.OnChnaged(); }
        }
        public tran_applicationreqforvehicleactivitylogEntity(IDataReader reader, bool IsListViewShow, bool relationalData)
        {
            this.LoadFromReader(reader, IsListViewShow, relationalData);
        }

        protected void LoadFromReader(IDataReader reader, bool IsListViewShow, bool relationalData)
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
                if (!reader.IsDBNull(reader.GetOrdinal("TransID"))) this.BaseSecurityParam.transid = reader.GetString(reader.GetOrdinal("TransID"));
                if (!reader.IsDBNull(reader.GetOrdinal("CreatedByUserName"))) this.BaseSecurityParam.createdbyusername = reader.GetString(reader.GetOrdinal("CreatedByUserName"));
                if (!reader.IsDBNull(reader.GetOrdinal("CreatedDate"))) this.BaseSecurityParam.createddate = reader.GetDateTime(reader.GetOrdinal("CreatedDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("UpdatedByUserName"))) this.BaseSecurityParam.updatedbyusername = reader.GetString(reader.GetOrdinal("UpdatedByUserName"));
                if (!reader.IsDBNull(reader.GetOrdinal("UpdatedDate"))) this.BaseSecurityParam.updateddate = reader.GetDateTime(reader.GetOrdinal("UpdatedDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("UpdateInfo"))) _updateinfo = reader.GetString(reader.GetOrdinal("UpdateInfo"));
                if (!reader.IsDBNull(reader.GetOrdinal("IPAddress"))) this.BaseSecurityParam.ipaddress = reader.GetString(reader.GetOrdinal("IPAddress"));
                if (!reader.IsDBNull(reader.GetOrdinal("TranFormActionID"))) _tranformactionid = reader.GetInt64(reader.GetOrdinal("TranFormActionID"));
                if (!reader.IsDBNull(reader.GetOrdinal("TS"))) this.BaseSecurityParam.ts = reader.GetInt64(reader.GetOrdinal("ts"));
                
                if (!reader.IsDBNull(reader.GetOrdinal("StatusName"))) _statusname = reader.GetString(reader.GetOrdinal("StatusName"));
                if (!reader.IsDBNull(reader.GetOrdinal("StatusNameAR"))) _statusnamear = reader.GetString(reader.GetOrdinal("StatusNameAR"));
                if (!reader.IsDBNull(reader.GetOrdinal("RequesterName"))) _requestername = reader.GetString(reader.GetOrdinal("RequesterName"));
                if (!reader.IsDBNull(reader.GetOrdinal("RequesterNameAR"))) _requesternamear = reader.GetString(reader.GetOrdinal("RequesterNameAR"));
                if (!reader.IsDBNull(reader.GetOrdinal("CompanyID"))) _companyid = reader.GetInt64(reader.GetOrdinal("CompanyID"));
                if (!reader.IsDBNull(reader.GetOrdinal("EmailAddress"))) _emailaddress = reader.GetString(reader.GetOrdinal("EmailAddress"));
                if (!reader.IsDBNull(reader.GetOrdinal("MobileNo"))) _mobileno = reader.GetString(reader.GetOrdinal("MobileNo"));
                if (!reader.IsDBNull(reader.GetOrdinal("MobileNoTypeID"))) _mobilenotypeid = reader.GetInt64(reader.GetOrdinal("MobileNoTypeID"));
                if (!reader.IsDBNull(reader.GetOrdinal("CompanyName"))) _companyname = reader.GetString(reader.GetOrdinal("CompanyName"));
                if (!reader.IsDBNull(reader.GetOrdinal("CompanyNameAR"))) _companynamear = reader.GetString(reader.GetOrdinal("CompanyNameAR"));
                if (!reader.IsDBNull(reader.GetOrdinal("MobileNoTypeName"))) _mobilenotypename = reader.GetString(reader.GetOrdinal("MobileNoTypeName"));
                if (!reader.IsDBNull(reader.GetOrdinal("MobileNoTypeNameAR"))) _mobilenotypenamear = reader.GetString(reader.GetOrdinal("MobileNoTypeNameAR"));
                CurrentState = EntityState.Unchanged;
            }
        }

    }

    public class dtvehicleactivitylog : DtParameters
    {
        protected long? _requestvehicleid;

        [DataMember]
        public long? requestvehicleid
        {
            get { return _requestvehicleid; }
            set { _requestvehicleid = value; this.OnChnaged(); }
        }
    }
}
