using System;
using System.Runtime.Serialization;
using System.Data;
using BDO.Core.Base;
using System.ComponentModel.DataAnnotations;


namespace BDO.Core.DataAccessObjects.Models
{
    public partial class tran_applicationreqforvisitorgatemapEntity
    {
        #region Relational Table

        protected string _fullname;
        protected string _fullnameen;
        protected string _civilidnumber;
        protected string _emergencycontactnumber;
        protected string _jobtitle;
        protected string _reason;
        protected bool? _hasvehicle;
        protected string _carnumberplate;
        protected DateTime? _startdate;



        protected DateTime? _intime;
        protected string _inbyusername;
        protected string _inbymacaddress;
        protected DateTime? _outtime;
        protected string _outbyusername;
        protected string _outbymacaddress;





        protected long? _entrystatusid;
        protected string _entrystatusname;
        protected string _entrystatusnamear;
        protected string _gatename;
        protected string _gatenamear;
        protected long? _enteredgateid;
        protected string _enteredgatename;
        protected string _enteredgatenamear;


        [DataMember]
        [MaxLength(256)]
        [Display(Name = "fullname", ResourceType = typeof(CLL.LLClasses.Models._tran_applicationreqforvisitor))]
        public string fullname
        {
            get { return _fullname; }
            set { _fullname = value; this.OnChnaged(); }
        }

        [DataMember]
        [MaxLength(256)]
        [Display(Name = "fullnameen", ResourceType = typeof(CLL.LLClasses.Models._tran_applicationreqforvisitor))]
        public string fullnameen
        {
            get { return _fullnameen; }
            set { _fullnameen = value; this.OnChnaged(); }
        }
        [DataMember]
        [MaxLength(50)]
        [Display(Name = "civilidnumber", ResourceType = typeof(CLL.LLClasses.Models._tran_applicationreqforvisitor))]
        public string civilidnumber
        {
            get { return _civilidnumber; }
            set { _civilidnumber = value; this.OnChnaged(); }
        }
        [DataMember]
        [StringLength(8, MinimumLength = 8, ErrorMessageResourceName = "MobileNumberMustBe8Character", ErrorMessageResourceType = typeof(CLL.LLClasses._Common))]
        [Display(Name = "emergencycontactnumber", ResourceType = typeof(CLL.LLClasses.Models._tran_applicationreqforvisitor))]
        public string emergencycontactnumber
        {
            get { return _emergencycontactnumber; }
            set { _emergencycontactnumber = value; this.OnChnaged(); }
        }


        [DataMember]
        [MaxLength(256)]
        [Display(Name = "jobtitle", ResourceType = typeof(CLL.LLClasses.Models._tran_applicationreqforvisitor))]
        public string jobtitle
        {
            get { return _jobtitle; }
            set { _jobtitle = value; this.OnChnaged(); }
        }

        [DataMember]
        [MaxLength(500)]
        [Display(Name = "reason", ResourceType = typeof(CLL.LLClasses.Models._tran_applicationreqforvisitor))]
        public string reason
        {
            get { return _reason; }
            set { _reason = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "hasvehicle", ResourceType = typeof(CLL.LLClasses.Models._tran_applicationreqforvisitor))]
        public bool? hasvehicle
        {
            get { return _hasvehicle; }
            set { _hasvehicle = value; this.OnChnaged(); }
        }

        [DataMember]
        [MaxLength(150)]
        [Display(Name = "carnumberplate", ResourceType = typeof(CLL.LLClasses.Models._tran_applicationreqforvisitor))]
        public string carnumberplate
        {
            get { return _carnumberplate; }
            set { _carnumberplate = value; this.OnChnaged(); }
        }


        [DataMember]
        [Display(Name = "startdate", ResourceType = typeof(CLL.LLClasses.Models._tran_applicationreqforvisitor))]
        [DataType(DataType.Date), DisplayFormat(DataFormatString = @"{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? startdate
        {
            get { return _startdate; }
            set { _startdate = value; this.OnChnaged(); }
        }
        [DataMember]

        [Display(Name = "enteredgateid", ResourceType = typeof(CLL.LLClasses.Models._tran_applicationreqvisitorinout))]
        public long? enteredgateid { get => _enteredgateid; set => _enteredgateid = value; }
        [DataMember]

        [Display(Name = "enteredgatename", ResourceType = typeof(CLL.LLClasses.Models._tran_applicationreqvisitorinout))]
        public string enteredgatename { get => _enteredgatename; set => _enteredgatename = value; }
        [DataMember]

        [Display(Name = "enteredgatenamear", ResourceType = typeof(CLL.LLClasses.Models._tran_applicationreqvisitorinout))]
        public string enteredgatenamear { get => _enteredgatenamear; set => _enteredgatenamear = value; }

        [DataMember]
        [Display(Name = "entrystatusid", ResourceType = typeof(CLL.LLClasses.Models._gen_entrystatus))]
        public long? entrystatusid
        {
            get { return _entrystatusid; }
            set { _entrystatusid = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "entrystatusname", ResourceType = typeof(CLL.LLClasses.Models._gen_entrystatus))]
        public string entrystatusname { get => _entrystatusname; set => _entrystatusname = value; }
        [DataMember]
        [Display(Name = "entrystatusnamear", ResourceType = typeof(CLL.LLClasses.Models._gen_entrystatus))]
        public string entrystatusnamear { get => _entrystatusnamear; set => _entrystatusnamear = value; }

        [DataMember]
        [Display(Name = "gatename", ResourceType = typeof(CLL.LLClasses.Models._gen_gate))]
        public string gatename
        {
            get { return _gatename; }
            set { _gatename = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "gatenamear", ResourceType = typeof(CLL.LLClasses.Models._gen_gate))]
        public string gatenamear
        {
            get { return _gatenamear; }
            set { _gatenamear = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "intime", ResourceType = typeof(CLL.LLClasses.Models._tran_applicationreqvisitorinout))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._tran_applicationreqvisitorinout), ErrorMessageResourceName = "intimeRequired")]
        public DateTime? intime
        {
            get { return _intime; }
            set { _intime = value; this.OnChnaged(); }
        }

        [DataMember]
        [MaxLength(150)]
        [Display(Name = "inbyusername", ResourceType = typeof(CLL.LLClasses.Models._tran_applicationreqvisitorinout))]
        public string inbyusername
        {
            get { return _inbyusername; }
            set { _inbyusername = value; this.OnChnaged(); }
        }

        [DataMember]
        [MaxLength(50)]
        [Display(Name = "inbymacaddress", ResourceType = typeof(CLL.LLClasses.Models._tran_applicationreqvisitorinout))]
        public string inbymacaddress
        {
            get { return _inbymacaddress; }
            set { _inbymacaddress = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "outtime", ResourceType = typeof(CLL.LLClasses.Models._tran_applicationreqvisitorinout))]
        public DateTime? outtime
        {
            get { return _outtime; }
            set { _outtime = value; this.OnChnaged(); }
        }

        [DataMember]
        [MaxLength(150)]
        [Display(Name = "outbyusername", ResourceType = typeof(CLL.LLClasses.Models._tran_applicationreqvisitorinout))]
        public string outbyusername
        {
            get { return _outbyusername; }
            set { _outbyusername = value; this.OnChnaged(); }
        }

        [DataMember]
        [MaxLength(50)]
        [Display(Name = "outbymacaddress", ResourceType = typeof(CLL.LLClasses.Models._tran_applicationreqvisitorinout))]
        public string outbymacaddress
        {
            get { return _outbymacaddress; }
            set { _outbymacaddress = value; this.OnChnaged(); }
        }

        #endregion Realtional Table 

        #region Constructor

        public tran_applicationreqforvisitorgatemapEntity(IDataReader reader, bool IsListViewShow, bool withRelationalTable)
        {
            this.LoadFromReader(reader, IsListViewShow, withRelationalTable);
        }

        protected void LoadFromReader(IDataReader reader, bool IsListViewShow, bool withRelationalTable)
        {
            if (reader != null && !reader.IsClosed)
            {
                this.BaseSecurityParam = new SecurityCapsule();
                if (!reader.IsDBNull(reader.GetOrdinal("RequestVisitorGateInfoID"))) _requestvisitorgateinfoid = reader.GetInt64(reader.GetOrdinal("RequestVisitorGateInfoID"));
                if (!reader.IsDBNull(reader.GetOrdinal("RequestVisitorID"))) _requestvisitorid = reader.GetInt64(reader.GetOrdinal("RequestVisitorID"));
                if (!reader.IsDBNull(reader.GetOrdinal("GateId"))) _gateid = reader.GetInt64(reader.GetOrdinal("GateId"));
                if (!reader.IsDBNull(reader.GetOrdinal("PermissionDate"))) _permissiondate = reader.GetDateTime(reader.GetOrdinal("PermissionDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("PermittedByMasterUserId"))) _permittedbymasteruserid = reader.GetInt64(reader.GetOrdinal("PermittedByMasterUserId"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsActive"))) _isactive = reader.GetBoolean(reader.GetOrdinal("IsActive"));
                if (!reader.IsDBNull(reader.GetOrdinal("NoteText"))) _notetext = reader.GetString(reader.GetOrdinal("NoteText"));
                if (!reader.IsDBNull(reader.GetOrdinal("TransID"))) this.BaseSecurityParam.transid = reader.GetString(reader.GetOrdinal("TransID"));
                if (!reader.IsDBNull(reader.GetOrdinal("CreatedByUserName"))) this.BaseSecurityParam.createdbyusername = reader.GetString(reader.GetOrdinal("CreatedByUserName"));
                if (!reader.IsDBNull(reader.GetOrdinal("CreatedDate"))) this.BaseSecurityParam.createddate = reader.GetDateTime(reader.GetOrdinal("CreatedDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("UpdatedByUserName"))) this.BaseSecurityParam.updatedbyusername = reader.GetString(reader.GetOrdinal("UpdatedByUserName"));
                if (!reader.IsDBNull(reader.GetOrdinal("UpdatedDate"))) this.BaseSecurityParam.updateddate = reader.GetDateTime(reader.GetOrdinal("UpdatedDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("UpdateInfo"))) _updateinfo = reader.GetString(reader.GetOrdinal("UpdateInfo"));
                if (!reader.IsDBNull(reader.GetOrdinal("TranFormActionID"))) _tranformactionid = reader.GetInt64(reader.GetOrdinal("TranFormActionID"));
                if (!reader.IsDBNull(reader.GetOrdinal("IPAddress"))) this.BaseSecurityParam.ipaddress = reader.GetString(reader.GetOrdinal("IPAddress"));
                if (!reader.IsDBNull(reader.GetOrdinal("TS"))) this.BaseSecurityParam.ts = reader.GetInt64(reader.GetOrdinal("ts"));

                if (!reader.IsDBNull(reader.GetOrdinal("FullName"))) _fullname = reader.GetString(reader.GetOrdinal("FullName"));
                if (!reader.IsDBNull(reader.GetOrdinal("FullNameEn"))) _fullnameen = reader.GetString(reader.GetOrdinal("FullNameEn"));
                if (!reader.IsDBNull(reader.GetOrdinal("CivilIdNumber"))) _civilidnumber = reader.GetString(reader.GetOrdinal("CivilIdNumber"));
                if (!reader.IsDBNull(reader.GetOrdinal("EmergencyContactNumber"))) _emergencycontactnumber = reader.GetString(reader.GetOrdinal("EmergencyContactNumber"));
                if (!reader.IsDBNull(reader.GetOrdinal("JobTitle"))) _jobtitle = reader.GetString(reader.GetOrdinal("JobTitle"));
                if (!reader.IsDBNull(reader.GetOrdinal("Reason"))) _reason = reader.GetString(reader.GetOrdinal("Reason"));
                if (!reader.IsDBNull(reader.GetOrdinal("HasVehicle"))) _hasvehicle = reader.GetBoolean(reader.GetOrdinal("HasVehicle"));
                if (!reader.IsDBNull(reader.GetOrdinal("CarNumberPlate"))) _carnumberplate = reader.GetString(reader.GetOrdinal("CarNumberPlate"));
                if (!reader.IsDBNull(reader.GetOrdinal("StartDate"))) _startdate = reader.GetDateTime(reader.GetOrdinal("StartDate"));

                if (!reader.IsDBNull(reader.GetOrdinal("InTime"))) _intime = reader.GetDateTime(reader.GetOrdinal("InTime"));
                if (!reader.IsDBNull(reader.GetOrdinal("InByUserName"))) _inbyusername = reader.GetString(reader.GetOrdinal("InByUserName"));
                if (!reader.IsDBNull(reader.GetOrdinal("InByMacAddress"))) _inbymacaddress = reader.GetString(reader.GetOrdinal("InByMacAddress"));
                if (!reader.IsDBNull(reader.GetOrdinal("OutTime"))) _outtime = reader.GetDateTime(reader.GetOrdinal("OutTime"));
                if (!reader.IsDBNull(reader.GetOrdinal("OutByUserName"))) _outbyusername = reader.GetString(reader.GetOrdinal("OutByUserName"));
                if (!reader.IsDBNull(reader.GetOrdinal("OutByMacAddress"))) _outbymacaddress = reader.GetString(reader.GetOrdinal("OutByMacAddress"));


                if (!reader.IsDBNull(reader.GetOrdinal("EntryStatusID"))) _entrystatusid = reader.GetInt64(reader.GetOrdinal("EntryStatusID"));
                if (!reader.IsDBNull(reader.GetOrdinal("EntryStatusName"))) _entrystatusname = reader.GetString(reader.GetOrdinal("EntryStatusName"));
                if (!reader.IsDBNull(reader.GetOrdinal("EntryStatusNameAR"))) _entrystatusnamear = reader.GetString(reader.GetOrdinal("EntryStatusNameAR"));
                if (!reader.IsDBNull(reader.GetOrdinal("GateName"))) _gatename = reader.GetString(reader.GetOrdinal("GateName"));
                if (!reader.IsDBNull(reader.GetOrdinal("GateNameAr"))) _gatenamear = reader.GetString(reader.GetOrdinal("GateNameAr"));
                if (!reader.IsDBNull(reader.GetOrdinal("EnteredGateId"))) _enteredgateid = reader.GetInt64(reader.GetOrdinal("EnteredGateId"));
                if (!reader.IsDBNull(reader.GetOrdinal("EnteredGateName"))) _enteredgatename = reader.GetString(reader.GetOrdinal("EnteredGateName"));
                if (!reader.IsDBNull(reader.GetOrdinal("EnteredGateNameAr"))) _enteredgatenamear = reader.GetString(reader.GetOrdinal("EnteredGateNameAr"));



                CurrentState = EntityState.Unchanged;
            }
        }

        #endregion



    }



    public partial class vm_VisitorWithGateMapVm
    {
        public tran_applicationreqforvisitorEntity visitor { get; set; }
        public tran_applicationreqforvisitorgatemapEntity visitormap { get; set; }
    }
}
