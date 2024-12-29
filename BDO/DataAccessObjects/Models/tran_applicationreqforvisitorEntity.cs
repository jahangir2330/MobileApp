using System;
using System.Runtime.Serialization;
using System.Data;
using BDO.Core.Base;
using System.ComponentModel.DataAnnotations;


namespace BDO.Core.DataAccessObjects.Models
{
    [Serializable]
    [DataContract(Name = "tran_applicationreqforvisitorEntity", Namespace = "http://www.KAF.com/types")]
    public partial class tran_applicationreqforvisitorEntity : BaseEntity
    {
        #region Properties

        protected long? _requestvisitorid;
        protected long? _uniqueno;
        protected string _fullname;
        protected string _fullnameen;
        protected long? _nationalityid;
        protected long? _licensetypeid;
        protected string _emergencycontactnumber;
        protected long? _mobilenotypeid;
        protected DateTime? _startdate;
        protected DateTime? _enddate;
        protected int? _numberofdays;
        protected long? _statusid;
        protected bool? _canenterafteroffice;
        protected string _timingnote;
        protected string _jobtitle;
        protected long? _idtype;
        protected string _civilidnumber;
        protected DateTime? _civilidexpirydate;
        protected string _passportnumber;
        protected string _visanumber;
        protected DateTime? _visaexpirydate;
        protected string _visaimagepath;
        protected string _reason;
        protected bool? _hasvehicle;
        protected string _carnumberplate;
        protected long? _vehiclecolorid;
        protected string _vehicleregistrationimagepath;
        protected string _personalpicurepath;
        protected string _civilidimagepath;
        protected string _civilidbacksideimagepath;
        protected bool? _ispersonblocked;
        protected DateTime? _personblockstartdate;
        protected DateTime? _personblockenddate;
        protected long? _personblockedbyuserid;
        protected DateTime? _personextentionenddate;
        protected DateTime? _personextendat;
        protected long? _personextendbyuserid;
        protected bool? _isreadbyadmin;
        protected string _lastreadbyadminname;
        protected DateTime? _submitdate;
        protected long? _approvedbymasteruserid;
        protected DateTime? _approveddate;
        protected bool? _isactive;


        [DataMember]
        public long? requestvisitorid
        {
            get { return _requestvisitorid; }
            set { _requestvisitorid = value; this.OnChnaged(); }
        }


        [DataMember]
        [Display(Name = "uniqueno", ResourceType = typeof(CLL.LLClasses.Models._tran_applicationreqforvisitor))]
        public long? uniqueno
        {
            get { return _uniqueno; }
            set { _uniqueno = value; this.OnChnaged(); }
        }

        [DataMember]
        [MaxLength(256)]
        [Display(Name = "fullname", ResourceType = typeof(CLL.LLClasses.Models._tran_applicationreqforvisitor))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._tran_applicationreqforvisitor), ErrorMessageResourceName = "fullnameRequired")]
        public string fullname
        {
            get { return _fullname; }
            set { _fullname = value; this.OnChnaged(); }
        }

        [DataMember]
        [MaxLength(256)]
        [Display(Name = "fullnameen", ResourceType = typeof(CLL.LLClasses.Models._tran_applicationreqforvisitor))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._tran_applicationreqforvisitor), ErrorMessageResourceName = "fullnameenRequired")]
        public string fullnameen
        {
            get { return _fullnameen; }
            set { _fullnameen = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "nationalityid", ResourceType = typeof(CLL.LLClasses.Models._tran_applicationreqforvisitor))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._tran_applicationreqforvisitor), ErrorMessageResourceName = "nationalityidRequired")]
        public long? nationalityid
        {
            get { return _nationalityid; }
            set { _nationalityid = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "licensetypeid", ResourceType = typeof(CLL.LLClasses.Models._tran_applicationreqforvisitor))]
        //[Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._tran_applicationreqforvisitor), ErrorMessageResourceName = "licensetypeidRequired")]
        public long? licensetypeid
        {
            get { return _licensetypeid; }
            set { _licensetypeid = value; this.OnChnaged(); }
        }
        [DataMember]
        [StringLength(8, MinimumLength = 8, ErrorMessageResourceName = "MobileNumberMustBe8Character", ErrorMessageResourceType = typeof(CLL.LLClasses._Common))]
        [Display(Name = "emergencycontactnumber", ResourceType = typeof(CLL.LLClasses.Models._tran_applicationreqforvisitor))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._tran_applicationreqforvisitor), ErrorMessageResourceName = "emergencycontactnumberRequired")]
        public string emergencycontactnumber
        {
            get { return _emergencycontactnumber; }
            set { _emergencycontactnumber = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "mobilenotypeid", ResourceType = typeof(CLL.LLClasses.Models._tran_applicationreqforvisitor))]
        public long? mobilenotypeid
        {
            get { return _mobilenotypeid; }
            set { _mobilenotypeid = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "startdate", ResourceType = typeof(CLL.LLClasses.Models._tran_applicationreqforvisitor))]
        [DataType(DataType.Date), DisplayFormat(DataFormatString = @"{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._tran_applicationreqforvisitor), ErrorMessageResourceName = "startdateRequired")]
        public DateTime? startdate
        {
            get { return _startdate; }
            set { _startdate = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "enddate", ResourceType = typeof(CLL.LLClasses.Models._tran_applicationreqforvisitor))]
        [DataType(DataType.Date), DisplayFormat(DataFormatString = @"{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        //[Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._tran_applicationreqforvisitor), ErrorMessageResourceName = "enddateRequired")]
        public DateTime? enddate
        {
            get { return _enddate; }
            set { _enddate = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "numberofdays", ResourceType = typeof(CLL.LLClasses.Models._tran_applicationreqforvisitor))]
        public int? numberofdays
        {
            get { return _numberofdays; }
            set { _numberofdays = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "statusid", ResourceType = typeof(CLL.LLClasses.Models._tran_applicationreqforvisitor))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._tran_applicationreqforvisitor), ErrorMessageResourceName = "statusidRequired")]
        public long? statusid
        {
            get { return _statusid; }
            set { _statusid = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "canenterafteroffice", ResourceType = typeof(CLL.LLClasses.Models._tran_applicationreqforvisitor))]
        public bool? canenterafteroffice
        {
            get { return _canenterafteroffice; }
            set { _canenterafteroffice = value; this.OnChnaged(); }
        }

        [DataMember]
        [MaxLength(550)]
        [Display(Name = "timingnote", ResourceType = typeof(CLL.LLClasses.Models._tran_applicationreqforvisitor))]
        public string timingnote
        {
            get { return _timingnote; }
            set { _timingnote = value; this.OnChnaged(); }
        }

        [DataMember]
        [MaxLength(256)]
        [Display(Name = "jobtitle", ResourceType = typeof(CLL.LLClasses.Models._tran_applicationreqforvisitor))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._tran_applicationreqforvisitor), ErrorMessageResourceName = "jobtitleRequired")]
        public string jobtitle
        {
            get { return _jobtitle; }
            set { _jobtitle = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "idtype", ResourceType = typeof(CLL.LLClasses.Models._tran_applicationreqforvisitor))]
        public long? idtype
        {
            get { return _idtype; }
            set { _idtype = value; this.OnChnaged(); }
        }

        [DataMember]
        [MaxLength(50)]
        [Display(Name = "civilidnumber", ResourceType = typeof(CLL.LLClasses.Models._tran_applicationreqforvisitor))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._tran_applicationreqforvisitor), ErrorMessageResourceName = "civilidnumberRequired")]
        public string civilidnumber
        {
            get { return _civilidnumber; }
            set { _civilidnumber = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "civilidexpirydate", ResourceType = typeof(CLL.LLClasses.Models._tran_applicationreqforvisitor))]
        public DateTime? civilidexpirydate
        {
            get { return _civilidexpirydate; }
            set { _civilidexpirydate = value; this.OnChnaged(); }
        }

        [DataMember]
        [MaxLength(50)]
        [Display(Name = "passportnumber", ResourceType = typeof(CLL.LLClasses.Models._tran_applicationreqforvisitor))]
        public string passportnumber
        {
            get { return _passportnumber; }
            set { _passportnumber = value; this.OnChnaged(); }
        }

        [DataMember]
        [MaxLength(50)]
        [Display(Name = "visanumber", ResourceType = typeof(CLL.LLClasses.Models._tran_applicationreqforvisitor))]
        //[Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._tran_applicationreqforvisitor), ErrorMessageResourceName = "visanumberRequired")]
        public string visanumber
        {
            get { return _visanumber; }
            set { _visanumber = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "visaexpirydate", ResourceType = typeof(CLL.LLClasses.Models._tran_applicationreqforvisitor))]
        public DateTime? visaexpirydate
        {
            get { return _visaexpirydate; }
            set { _visaexpirydate = value; this.OnChnaged(); }
        }

        [DataMember]
        [MaxLength(250)]
        [Display(Name = "visaimagepath", ResourceType = typeof(CLL.LLClasses.Models._tran_applicationreqforvisitor))]
        public string visaimagepath
        {
            get { return _visaimagepath; }
            set { _visaimagepath = value; this.OnChnaged(); }
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
        [Display(Name = "vehiclecolorid", ResourceType = typeof(CLL.LLClasses.Models._tran_applicationreqforvisitor))]
        public long? vehiclecolorid
        {
            get { return _vehiclecolorid; }
            set { _vehiclecolorid = value; this.OnChnaged(); }
        }

        [DataMember]
        [MaxLength(500)]
        [Display(Name = "vehicleregistrationimagepath", ResourceType = typeof(CLL.LLClasses.Models._tran_applicationreqforvisitor))]
        public string vehicleregistrationimagepath
        {
            get { return _vehicleregistrationimagepath; }
            set { _vehicleregistrationimagepath = value; this.OnChnaged(); }
        }

        [DataMember]
        [MaxLength(250)]
        [Display(Name = "personalpicurepath", ResourceType = typeof(CLL.LLClasses.Models._tran_applicationreqforvisitor))]
        public string personalpicurepath
        {
            get { return _personalpicurepath; }
            set { _personalpicurepath = value; this.OnChnaged(); }
        }

        [DataMember]
        [MaxLength(250)]
        [Display(Name = "civilidimagepath", ResourceType = typeof(CLL.LLClasses.Models._tran_applicationreqforvisitor))]
        public string civilidimagepath
        {
            get { return _civilidimagepath; }
            set { _civilidimagepath = value; this.OnChnaged(); }
        }

        [DataMember]
        [MaxLength(250)]
        [Display(Name = "civilidbacksideimagepath", ResourceType = typeof(CLL.LLClasses.Models._tran_applicationreqforvisitor))]
        public string civilidbacksideimagepath
        {
            get { return _civilidbacksideimagepath; }
            set { _civilidbacksideimagepath = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "ispersonblocked", ResourceType = typeof(CLL.LLClasses.Models._tran_applicationreqforvisitor))]
        public bool? ispersonblocked
        {
            get { return _ispersonblocked; }
            set { _ispersonblocked = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "personblockstartdate", ResourceType = typeof(CLL.LLClasses.Models._tran_applicationreqforvisitor))]
        public DateTime? personblockstartdate
        {
            get { return _personblockstartdate; }
            set { _personblockstartdate = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "personblockenddate", ResourceType = typeof(CLL.LLClasses.Models._tran_applicationreqforvisitor))]
        public DateTime? personblockenddate
        {
            get { return _personblockenddate; }
            set { _personblockenddate = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "personblockedbyuserid", ResourceType = typeof(CLL.LLClasses.Models._tran_applicationreqforvisitor))]
        public long? personblockedbyuserid
        {
            get { return _personblockedbyuserid; }
            set { _personblockedbyuserid = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "personextentionenddate", ResourceType = typeof(CLL.LLClasses.Models._tran_applicationreqforvisitor))]
        public DateTime? personextentionenddate
        {
            get { return _personextentionenddate; }
            set { _personextentionenddate = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "personextendat", ResourceType = typeof(CLL.LLClasses.Models._tran_applicationreqforvisitor))]
        public DateTime? personextendat
        {
            get { return _personextendat; }
            set { _personextendat = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "personextendbyuserid", ResourceType = typeof(CLL.LLClasses.Models._tran_applicationreqforvisitor))]
        public long? personextendbyuserid
        {
            get { return _personextendbyuserid; }
            set { _personextendbyuserid = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "isreadbyadmin", ResourceType = typeof(CLL.LLClasses.Models._tran_applicationreqforvisitor))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._tran_applicationreqforvisitor), ErrorMessageResourceName = "isreadbyadminRequired")]
        public bool? isreadbyadmin
        {
            get { return _isreadbyadmin; }
            set { _isreadbyadmin = value; this.OnChnaged(); }
        }

        [DataMember]
        [MaxLength(150)]
        [Display(Name = "lastreadbyadminname", ResourceType = typeof(CLL.LLClasses.Models._tran_applicationreqforvisitor))]
        public string lastreadbyadminname
        {
            get { return _lastreadbyadminname; }
            set { _lastreadbyadminname = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "submitdate", ResourceType = typeof(CLL.LLClasses.Models._tran_applicationreqforvisitor))]
        public DateTime? submitdate
        {
            get { return _submitdate; }
            set { _submitdate = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "approvedbymasteruserid", ResourceType = typeof(CLL.LLClasses.Models._tran_applicationreqforvisitor))]
        public long? approvedbymasteruserid
        {
            get { return _approvedbymasteruserid; }
            set { _approvedbymasteruserid = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "approveddate", ResourceType = typeof(CLL.LLClasses.Models._tran_applicationreqforvisitor))]
        public DateTime? approveddate
        {
            get { return _approveddate; }
            set { _approveddate = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "isactive", ResourceType = typeof(CLL.LLClasses.Models._tran_applicationreqforvisitor))]
        public bool? isactive
        {
            get { return _isactive; }
            set { _isactive = value; this.OnChnaged(); }
        }


        #endregion

        #region Constructor

        public tran_applicationreqforvisitorEntity() : base()
        {
        }

        public tran_applicationreqforvisitorEntity(IDataReader reader)
        {
            this.LoadFromReader(reader);
        }

        public tran_applicationreqforvisitorEntity(IDataReader reader, bool IsListViewShow)
        {
            this.LoadFromReader(reader, IsListViewShow);
        }



        protected void LoadFromReader(IDataReader reader)
        {
            if (reader != null && !reader.IsClosed)
            {
                this.BaseSecurityParam = new SecurityCapsule();
                if (!reader.IsDBNull(reader.GetOrdinal("RequestVisitorID"))) _requestvisitorid = reader.GetInt64(reader.GetOrdinal("RequestVisitorID"));
                if (!reader.IsDBNull(reader.GetOrdinal("FullName"))) _fullname = reader.GetString(reader.GetOrdinal("FullName"));
                if (!reader.IsDBNull(reader.GetOrdinal("FullNameEn"))) _fullnameen = reader.GetString(reader.GetOrdinal("FullNameEn"));
                if (!reader.IsDBNull(reader.GetOrdinal("NationalityId"))) _nationalityid = reader.GetInt64(reader.GetOrdinal("NationalityId"));
                if (!reader.IsDBNull(reader.GetOrdinal("LicenseTypeID"))) _licensetypeid = reader.GetInt64(reader.GetOrdinal("LicenseTypeID"));
                if (!reader.IsDBNull(reader.GetOrdinal("EmergencyContactNumber"))) _emergencycontactnumber = reader.GetString(reader.GetOrdinal("EmergencyContactNumber"));
                if (!reader.IsDBNull(reader.GetOrdinal("MobileNoTypeId"))) _mobilenotypeid = reader.GetInt64(reader.GetOrdinal("MobileNoTypeId"));
                if (!reader.IsDBNull(reader.GetOrdinal("StartDate"))) _startdate = reader.GetDateTime(reader.GetOrdinal("StartDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("EndDate"))) _enddate = reader.GetDateTime(reader.GetOrdinal("EndDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("NumberOfDays"))) _numberofdays = reader.GetInt32(reader.GetOrdinal("NumberOfDays"));
                if (!reader.IsDBNull(reader.GetOrdinal("StatusID"))) _statusid = reader.GetInt64(reader.GetOrdinal("StatusID"));
                if (!reader.IsDBNull(reader.GetOrdinal("CanEnterAfterOffice"))) _canenterafteroffice = reader.GetBoolean(reader.GetOrdinal("CanEnterAfterOffice"));
                if (!reader.IsDBNull(reader.GetOrdinal("TimingNote"))) _timingnote = reader.GetString(reader.GetOrdinal("TimingNote"));
                if (!reader.IsDBNull(reader.GetOrdinal("JobTitle"))) _jobtitle = reader.GetString(reader.GetOrdinal("JobTitle"));
                if (!reader.IsDBNull(reader.GetOrdinal("IdType"))) _idtype = reader.GetInt64(reader.GetOrdinal("IdType"));
                if (!reader.IsDBNull(reader.GetOrdinal("CivilIdNumber"))) _civilidnumber = reader.GetString(reader.GetOrdinal("CivilIdNumber"));
                if (!reader.IsDBNull(reader.GetOrdinal("CivilIdExpiryDate"))) _civilidexpirydate = reader.GetDateTime(reader.GetOrdinal("CivilIdExpiryDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("PassportNumber"))) _passportnumber = reader.GetString(reader.GetOrdinal("PassportNumber"));
                if (!reader.IsDBNull(reader.GetOrdinal("VisaNumber"))) _visanumber = reader.GetString(reader.GetOrdinal("VisaNumber"));
                if (!reader.IsDBNull(reader.GetOrdinal("VisaExpiryDate"))) _visaexpirydate = reader.GetDateTime(reader.GetOrdinal("VisaExpiryDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("VisaImagePath"))) _visaimagepath = reader.GetString(reader.GetOrdinal("VisaImagePath"));
                if (!reader.IsDBNull(reader.GetOrdinal("Reason"))) _reason = reader.GetString(reader.GetOrdinal("Reason"));
                if (!reader.IsDBNull(reader.GetOrdinal("HasVehicle"))) _hasvehicle = reader.GetBoolean(reader.GetOrdinal("HasVehicle"));
                if (!reader.IsDBNull(reader.GetOrdinal("CarNumberPlate"))) _carnumberplate = reader.GetString(reader.GetOrdinal("CarNumberPlate"));
                if (!reader.IsDBNull(reader.GetOrdinal("VehicleColorId"))) _vehiclecolorid = reader.GetInt64(reader.GetOrdinal("VehicleColorId"));
                if (!reader.IsDBNull(reader.GetOrdinal("VehicleRegistrationImagePath"))) _vehicleregistrationimagepath = reader.GetString(reader.GetOrdinal("VehicleRegistrationImagePath"));
                if (!reader.IsDBNull(reader.GetOrdinal("PersonalPicurePath"))) _personalpicurepath = reader.GetString(reader.GetOrdinal("PersonalPicurePath"));
                if (!reader.IsDBNull(reader.GetOrdinal("CivilIdImagePath"))) _civilidimagepath = reader.GetString(reader.GetOrdinal("CivilIdImagePath"));
                if (!reader.IsDBNull(reader.GetOrdinal("CivilIdBacksideImagePath"))) _civilidbacksideimagepath = reader.GetString(reader.GetOrdinal("CivilIdBacksideImagePath"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsPersonBlocked"))) _ispersonblocked = reader.GetBoolean(reader.GetOrdinal("IsPersonBlocked"));
                if (!reader.IsDBNull(reader.GetOrdinal("PersonBlockStartDate"))) _personblockstartdate = reader.GetDateTime(reader.GetOrdinal("PersonBlockStartDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("PersonBlockEndDate"))) _personblockenddate = reader.GetDateTime(reader.GetOrdinal("PersonBlockEndDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("PersonBlockedByUserId"))) _personblockedbyuserid = reader.GetInt64(reader.GetOrdinal("PersonBlockedByUserId"));
                if (!reader.IsDBNull(reader.GetOrdinal("PersonExtentionEndDate"))) _personextentionenddate = reader.GetDateTime(reader.GetOrdinal("PersonExtentionEndDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("PersonExtendAt"))) _personextendat = reader.GetDateTime(reader.GetOrdinal("PersonExtendAt"));
                if (!reader.IsDBNull(reader.GetOrdinal("PersonExtendByUserId"))) _personextendbyuserid = reader.GetInt64(reader.GetOrdinal("PersonExtendByUserId"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsReadByAdmin"))) _isreadbyadmin = reader.GetBoolean(reader.GetOrdinal("IsReadByAdmin"));
                if (!reader.IsDBNull(reader.GetOrdinal("LastReadByAdminName"))) _lastreadbyadminname = reader.GetString(reader.GetOrdinal("LastReadByAdminName"));
                if (!reader.IsDBNull(reader.GetOrdinal("SubmitDate"))) _submitdate = reader.GetDateTime(reader.GetOrdinal("SubmitDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("ApprovedByMasterUserId"))) _approvedbymasteruserid = reader.GetInt64(reader.GetOrdinal("ApprovedByMasterUserId"));
                if (!reader.IsDBNull(reader.GetOrdinal("ApprovedDate"))) _approveddate = reader.GetDateTime(reader.GetOrdinal("ApprovedDate"));
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
                if (!reader.IsDBNull(reader.GetOrdinal("RequestVisitorID"))) _requestvisitorid = reader.GetInt64(reader.GetOrdinal("RequestVisitorID"));
                if (!reader.IsDBNull(reader.GetOrdinal("FullName"))) _fullname = reader.GetString(reader.GetOrdinal("FullName"));
                if (!reader.IsDBNull(reader.GetOrdinal("FullNameEn"))) _fullnameen = reader.GetString(reader.GetOrdinal("FullNameEn"));
                if (!reader.IsDBNull(reader.GetOrdinal("NationalityId"))) _nationalityid = reader.GetInt64(reader.GetOrdinal("NationalityId"));
                if (!reader.IsDBNull(reader.GetOrdinal("LicenseTypeID"))) _licensetypeid = reader.GetInt64(reader.GetOrdinal("LicenseTypeID"));
                if (!reader.IsDBNull(reader.GetOrdinal("EmergencyContactNumber"))) _emergencycontactnumber = reader.GetString(reader.GetOrdinal("EmergencyContactNumber"));
                if (!reader.IsDBNull(reader.GetOrdinal("MobileNoTypeId"))) _mobilenotypeid = reader.GetInt64(reader.GetOrdinal("MobileNoTypeId"));
                if (!reader.IsDBNull(reader.GetOrdinal("StartDate"))) _startdate = reader.GetDateTime(reader.GetOrdinal("StartDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("EndDate"))) _enddate = reader.GetDateTime(reader.GetOrdinal("EndDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("NumberOfDays"))) _numberofdays = reader.GetInt32(reader.GetOrdinal("NumberOfDays"));
                if (!reader.IsDBNull(reader.GetOrdinal("StatusID"))) _statusid = reader.GetInt64(reader.GetOrdinal("StatusID"));
                if (!reader.IsDBNull(reader.GetOrdinal("CanEnterAfterOffice"))) _canenterafteroffice = reader.GetBoolean(reader.GetOrdinal("CanEnterAfterOffice"));
                if (!reader.IsDBNull(reader.GetOrdinal("TimingNote"))) _timingnote = reader.GetString(reader.GetOrdinal("TimingNote"));
                if (!reader.IsDBNull(reader.GetOrdinal("JobTitle"))) _jobtitle = reader.GetString(reader.GetOrdinal("JobTitle"));
                if (!reader.IsDBNull(reader.GetOrdinal("IdType"))) _idtype = reader.GetInt64(reader.GetOrdinal("IdType"));
                if (!reader.IsDBNull(reader.GetOrdinal("CivilIdNumber"))) _civilidnumber = reader.GetString(reader.GetOrdinal("CivilIdNumber"));
                if (!reader.IsDBNull(reader.GetOrdinal("CivilIdExpiryDate"))) _civilidexpirydate = reader.GetDateTime(reader.GetOrdinal("CivilIdExpiryDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("PassportNumber"))) _passportnumber = reader.GetString(reader.GetOrdinal("PassportNumber"));
                if (!reader.IsDBNull(reader.GetOrdinal("VisaNumber"))) _visanumber = reader.GetString(reader.GetOrdinal("VisaNumber"));
                if (!reader.IsDBNull(reader.GetOrdinal("VisaExpiryDate"))) _visaexpirydate = reader.GetDateTime(reader.GetOrdinal("VisaExpiryDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("VisaImagePath"))) _visaimagepath = reader.GetString(reader.GetOrdinal("VisaImagePath"));
                if (!reader.IsDBNull(reader.GetOrdinal("Reason"))) _reason = reader.GetString(reader.GetOrdinal("Reason"));
                if (!reader.IsDBNull(reader.GetOrdinal("HasVehicle"))) _hasvehicle = reader.GetBoolean(reader.GetOrdinal("HasVehicle"));
                if (!reader.IsDBNull(reader.GetOrdinal("CarNumberPlate"))) _carnumberplate = reader.GetString(reader.GetOrdinal("CarNumberPlate"));
                if (!reader.IsDBNull(reader.GetOrdinal("VehicleColorId"))) _vehiclecolorid = reader.GetInt64(reader.GetOrdinal("VehicleColorId"));
                if (!reader.IsDBNull(reader.GetOrdinal("VehicleRegistrationImagePath"))) _vehicleregistrationimagepath = reader.GetString(reader.GetOrdinal("VehicleRegistrationImagePath"));
                if (!reader.IsDBNull(reader.GetOrdinal("PersonalPicurePath"))) _personalpicurepath = reader.GetString(reader.GetOrdinal("PersonalPicurePath"));
                if (!reader.IsDBNull(reader.GetOrdinal("CivilIdImagePath"))) _civilidimagepath = reader.GetString(reader.GetOrdinal("CivilIdImagePath"));
                if (!reader.IsDBNull(reader.GetOrdinal("CivilIdBacksideImagePath"))) _civilidbacksideimagepath = reader.GetString(reader.GetOrdinal("CivilIdBacksideImagePath"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsPersonBlocked"))) _ispersonblocked = reader.GetBoolean(reader.GetOrdinal("IsPersonBlocked"));
                if (!reader.IsDBNull(reader.GetOrdinal("PersonBlockStartDate"))) _personblockstartdate = reader.GetDateTime(reader.GetOrdinal("PersonBlockStartDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("PersonBlockEndDate"))) _personblockenddate = reader.GetDateTime(reader.GetOrdinal("PersonBlockEndDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("PersonBlockedByUserId"))) _personblockedbyuserid = reader.GetInt64(reader.GetOrdinal("PersonBlockedByUserId"));
                if (!reader.IsDBNull(reader.GetOrdinal("PersonExtentionEndDate"))) _personextentionenddate = reader.GetDateTime(reader.GetOrdinal("PersonExtentionEndDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("PersonExtendAt"))) _personextendat = reader.GetDateTime(reader.GetOrdinal("PersonExtendAt"));
                if (!reader.IsDBNull(reader.GetOrdinal("PersonExtendByUserId"))) _personextendbyuserid = reader.GetInt64(reader.GetOrdinal("PersonExtendByUserId"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsReadByAdmin"))) _isreadbyadmin = reader.GetBoolean(reader.GetOrdinal("IsReadByAdmin"));
                if (!reader.IsDBNull(reader.GetOrdinal("LastReadByAdminName"))) _lastreadbyadminname = reader.GetString(reader.GetOrdinal("LastReadByAdminName"));
                if (!reader.IsDBNull(reader.GetOrdinal("SubmitDate"))) _submitdate = reader.GetDateTime(reader.GetOrdinal("SubmitDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("ApprovedByMasterUserId"))) _approvedbymasteruserid = reader.GetInt64(reader.GetOrdinal("ApprovedByMasterUserId"));
                if (!reader.IsDBNull(reader.GetOrdinal("ApprovedDate"))) _approveddate = reader.GetDateTime(reader.GetOrdinal("ApprovedDate"));
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
