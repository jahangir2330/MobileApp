using System;
using System.Runtime.Serialization;
using System.Data;
using BDO.Core.Base;
using System.ComponentModel.DataAnnotations;
using BDO.Core.DataAccessObjects.CommonEntities;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace BDO.Core.DataAccessObjects.Models
{
    public partial class tran_applicationreqforvisitorEntity
    {
        #region Image
        [DataMember]
        public string largepersonalpicure { get; set; }
        [DataMember]
        public string thumbspersonalpicure { get; set; }
        [DataMember]
        public string base64personalpicure { get; set; }
        [DataMember]
        public string dimention_base64personalpicure { get; set; }
        [DataMember]
        public int cropwidthpersonalpicure { get; set; } = 461;//132;//3.5
        [DataMember]
        public int cropheightpersonalpicure { get; set; } = 579;//170;//4.5

        [DataMember]
        public string largecivilidimage { get; set; }
        [DataMember]
        public string thumbscivilidimage { get; set; }
        [DataMember]
        public string base64civilidimage { get; set; }
        [DataMember]
        public string dimention_base64civilidimage { get; set; }
        [DataMember]
        public int cropwidthcivilidimage { get; set; } = 329;//8.7
        [DataMember]
        public int cropheightcivilidimage { get; set; } = 208;//5.5



        [DataMember]
        public string largecivilidbacksideimage { get; set; }
        [DataMember]
        public string thumbscivilidbacksideimage { get; set; }
        [DataMember]
        public string base64civilidbacksideimage { get; set; }
        [DataMember]
        public string dimention_base64civilidbacksideimage { get; set; }
        [DataMember]
        public int cropwidthcivilidbacksideimage { get; set; } = 329;//8.7
        [DataMember]
        public int cropheightcivilidbacksideimage { get; set; } = 208;//5.5



        [DataMember]
        public string largevehicleregistrationimage { get; set; }
        [DataMember]
        public string thumbsvehicleregistrationimage { get; set; }
        [DataMember]
        public string base64vehicleregistrationimage { get; set; }
        [DataMember]
        public string dimention_base64vehicleregistrationimage { get; set; }
        [DataMember]
        public int cropwidthvehicleregistrationimage { get; set; } = 600;
        [DataMember]
        public int cropheightvehicleregistrationimage { get; set; } = 600;


        [DataMember]
        public string largevisaimage { get; set; }
        [DataMember]
        public string thumbsvisaimage { get; set; }
        [DataMember]
        public string base64visaimage { get; set; }
        [DataMember]
        public string dimention_base64visaimage { get; set; }
        [DataMember]
        public int cropwidthvisaimage { get; set; } = 621; //A4
        [DataMember]
        public int cropheightvisaimage { get; set; } = 877; //A4
        #endregion

        #region For Additional Readonly Field
        protected long? _entrystatusid;
        protected DateTime? _expirydate;
        protected string _approvedbysignature;

        protected string _remarks;
        protected string _currentstatus;
        protected string _gatenamesstring;
        protected string _gatenamesarabicstring;
        protected bool? _reviewedunderreview;
        protected bool? _reviewedaftermodify;
        protected bool? _reviewedexporting;
        protected bool? _isreviewed;
        protected long? _reviewedbyuserid;
        protected DateTime? _revieweddate;
        protected string _gateidstring;

        protected long? _enteredgateid;
        protected string _enteredgatename;
        protected string _enteredgatenamear;

        [Display(Name = "serial", ResourceType = typeof(CLL.LLClasses._Common))]
        public long serial { get; set; }

        [DataMember]
        [JsonPropertyName("encemployeeid")]
        public string encemployeeid { get; set; }
        [DataMember]
        public string encemployeeidasqueryparam { get; set; }
        [DataMember]
        public string encrequestid { get; set; }


        protected List<tran_applicationreqforempgatemapEntity> _permittedgates;

        [DataMember]
        public List<tran_applicationreqforempgatemapEntity> permittedgates
        {
            get { return _permittedgates; }
            set { _permittedgates = value; this.OnChnaged(); }
        }

        [DataMember]
        [MaxLength(550)]
        //[Display(Name = "entrystatusid", ResourceType = typeof(CLL.LLClasses.Models._tran_applicationreqforemp))]
        public long? entrystatusid
        {
            get { return _entrystatusid; }
            set { _entrystatusid = value; this.OnChnaged(); }
        }

        [DataMember]
        [MaxLength(550)]
        [Display(Name = "gateidstring", ResourceType = typeof(CLL.LLClasses.Models._tran_applicationreqforemp))]
        public string gateidstring
        {
            get { return _gateidstring; }
            set { _gateidstring = value; this.OnChnaged(); }
        }

        [DataMember]
        //[Display(Name = "companyid", ResourceType = typeof(CLL.LLClasses.Models._tran_applicationreqforemp))]
        public string approvedbysignature
        {
            get { return _approvedbysignature; }
            set { _approvedbysignature = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "expirydate", ResourceType = typeof(CLL.LLClasses.Models._tran_applicationreqforemp))]
        [DataType(DataType.Date), DisplayFormat(DataFormatString = @"{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? expirydate
        {
            get { return _expirydate; }
            set { _expirydate = value; this.OnChnaged(); }
        }

        [DataMember]
        [MaxLength(550)]
        [Display(Name = "remarks", ResourceType = typeof(CLL.LLClasses.Models._tran_applicationreqforemp))]
        public string remarks
        {
            get { return _remarks; }
            set { _remarks = value; this.OnChnaged(); }
        }


        [DataMember]
        [MaxLength(550)]
        public string currentstatus
        {
            get { return _currentstatus; }
            set { _currentstatus = value; this.OnChnaged(); }
        }
        [DataMember]
        [MaxLength(1550)]

        [Display(Name = "gatename", ResourceType = typeof(CLL.LLClasses.Models._gen_gate))]
        public string gatenamesstring
        {
            get { return _gatenamesstring; }
            set { _gatenamesstring = value; this.OnChnaged(); }
        }
        [DataMember]
        [MaxLength(1550)]
        [Display(Name = "gatename", ResourceType = typeof(CLL.LLClasses.Models._gen_gate))]
        public string gatenamesarabicstring
        {
            get { return _gatenamesarabicstring; }
            set { _gatenamesarabicstring = value; this.OnChnaged(); }
        }
        [DataMember]
        [Display(Name = "reviewed", ResourceType = typeof(CLL.LLClasses._Common))]
        public bool? reviewedunderreview
        {
            get { return _reviewedunderreview; }
            set { _reviewedunderreview = value; this.OnChnaged(); }
        }
        [DataMember]
        [Display(Name = "reviewed", ResourceType = typeof(CLL.LLClasses._Common))]
        public bool? reviewedaftermodify
        {
            get { return _reviewedaftermodify; }
            set { _reviewedaftermodify = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "reviewed", ResourceType = typeof(CLL.LLClasses._Common))]
        public bool? reviewedexporting
        {
            get { return _reviewedexporting; }
            set { _reviewedexporting = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "reviewed", ResourceType = typeof(CLL.LLClasses._Common))]
        public bool? isreviewed
        {
            get { return _isreviewed; }
            set { _isreviewed = value; this.OnChnaged(); }
        }

        [DataMember]
        [MaxLength(550)]
        //[Display(Name = "remarks", ResourceType = typeof(CLL.LLClasses.Models._tran_applicationreqforemp))]
        public long? reviewedbyuserid
        {
            get { return _reviewedbyuserid; }
            set { _reviewedbyuserid = value; this.OnChnaged(); }
        }


        [DataMember]
        //[Display(Name = "revieweddate", ResourceType = typeof(CLL.LLClasses.Models._tran_applicationreqforemp))]
        [DataType(DataType.Date), DisplayFormat(DataFormatString = @"{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? revieweddate
        {
            get { return _revieweddate; }
            set { _revieweddate = value; this.OnChnaged(); }
        }
        #endregion

        #region Relational Table

        protected string _entrystatusname;
        protected string _entrystatusnamear;

        protected string _licensetypename;
        protected string _licensetypenamear;
        protected string _statusname;
        protected string _statusnamear;
        protected string _statuscssclass;
        protected string _statusiconname;
        protected string _qrcode;
        protected string _downloadurl;

        protected string _nationalityname;
        protected string _nationalitynamear;

        protected string _mobilenotypename;
        protected string _mobilenotypenamear;

        protected string _vehiclecolorname;
        protected string _vehiclecolornamear;

        protected string _approvedbyusername;
        protected string _approvedbyemail;

        [DataMember]
        [Display(Name = "statusname", ResourceType = typeof(CLL.LLClasses.Models._gen_status))]
        public string statusname { get => _statusname; set => _statusname = value; }
        [DataMember]

        [Display(Name = "entrystatusname", ResourceType = typeof(CLL.LLClasses.Models._gen_entrystatus))]
        public string entrystatusname { get => _entrystatusname; set => _entrystatusname = value; }
        [DataMember]
        [Display(Name = "entrystatusnamear", ResourceType = typeof(CLL.LLClasses.Models._gen_entrystatus))]
        public string entrystatusnamear { get => _entrystatusnamear; set => _entrystatusnamear = value; }

        [DataMember]
        [Display(Name = "nationalityname", ResourceType = typeof(CLL.LLClasses.Models._gen_nationality))]
        public string representativenationality { get => _nationalityname; set => _nationalityname = value; }

        [DataMember]
        [Display(Name = "nationalitynamear", ResourceType = typeof(CLL.LLClasses.Models._gen_nationality))]
        public string representativenationalityar { get => _nationalitynamear; set => _nationalitynamear = value; }

        [DataMember]
        [Display(Name = "licensetypename", ResourceType = typeof(CLL.LLClasses.Models._gen_licensetype))]
        public string licensetypename { get => _licensetypename; set => _licensetypename = value; }

        [DataMember]
        [Display(Name = "licensetypenamear", ResourceType = typeof(CLL.LLClasses.Models._gen_licensetype))]
        public string licensetypenamear { get => _licensetypenamear; set => _licensetypenamear = value; }

        [DataMember]
        [Display(Name = "statusnamear", ResourceType = typeof(CLL.LLClasses.Models._gen_status))]
        public string statusnamear { get => _statusnamear; set => _statusnamear = value; }
        [DataMember]
        //[Display(Name = "nationalitynamename", ResourceType = typeof(CLL.LLClasses.Models._gen_status))]
        public string nationalityname { get => _nationalityname; set => _nationalityname = value; }

        [DataMember]
        //[Display(Name = "nationalitynamear", ResourceType = typeof(CLL.LLClasses.Models._gen_status))]
        public string nationalitynamear { get => _nationalitynamear; set => _nationalitynamear = value; }

        [DataMember]
        //[Display(Name = "mobilenotypename", ResourceType = typeof(CLL.LLClasses.Models._gen_status))]
        public string mobilenotypename { get => _mobilenotypename; set => _mobilenotypename = value; }

        [DataMember]
        //[Display(Name = "mobilenotypenamear", ResourceType = typeof(CLL.LLClasses.Models._gen_status))]
        public string mobilenotypenamear { get => _mobilenotypenamear; set => _mobilenotypenamear = value; }
        [DataMember]
        //[Display(Name = "vehiclecolorname", ResourceType = typeof(CLL.LLClasses.Models._gen_status))]
        public string vehiclecolorname { get => _vehiclecolorname; set => _vehiclecolorname = value; }

        [DataMember]
        //[Display(Name = "vehiclecolornamear", ResourceType = typeof(CLL.LLClasses.Models._gen_status))]
        public string vehiclecolornamear { get => _vehiclecolornamear; set => _vehiclecolornamear = value; }

        [DataMember]
        public string approvedbyusername { get => _approvedbyusername; set => _approvedbyusername = value; }

        [DataMember]
        public string approvedbyemail { get => _approvedbyemail; set => _approvedbyemail = value; }

        [DataMember]
        public string qrcode { get => _qrcode; set => _qrcode = value; }
        [DataMember]
        public string downloadurl { get => _downloadurl; set => _downloadurl = value; }

        [DataMember]
        [MaxLength(550)]
        public string statuscssclass
        {
            get { return _statuscssclass; }
            set { _statuscssclass = value; this.OnChnaged(); }
        }

        [DataMember]
        [MaxLength(550)]
        public string statusiconname
        {
            get { return _statusiconname; }
            set { _statusiconname = value; this.OnChnaged(); }
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

        #endregion

        public tran_applicationreqforvisitorEntity(IDataReader reader, bool IsListViewShow, bool withRelationalData)
        {
            this.LoadFromReader(reader, IsListViewShow, withRelationalData);
        }

        protected void LoadFromReader(IDataReader reader, bool IsListViewShow, bool withRelationalData)
        {
            if (reader != null && !reader.IsClosed)
            {
                this.BaseSecurityParam = new SecurityCapsule();

                if (!reader.IsDBNull(reader.GetOrdinal("RowNumber"))) serial = reader.GetInt64(reader.GetOrdinal("RowNumber"));
                if (!reader.IsDBNull(reader.GetOrdinal("RequestVisitorID"))) _requestvisitorid = reader.GetInt64(reader.GetOrdinal("RequestVisitorID"));
                if (!reader.IsDBNull(reader.GetOrdinal("FullName"))) _fullname = reader.GetString(reader.GetOrdinal("FullName"));
                if (!reader.IsDBNull(reader.GetOrdinal("FullNameEn"))) _fullnameen = reader.GetString(reader.GetOrdinal("FullNameEn"));
                if (!reader.IsDBNull(reader.GetOrdinal("NationalityId"))) _nationalityid = reader.GetInt64(reader.GetOrdinal("NationalityId"));
                if (!reader.IsDBNull(reader.GetOrdinal("JobTitle"))) _jobtitle = reader.GetString(reader.GetOrdinal("JobTitle"));
                if (!reader.IsDBNull(reader.GetOrdinal("IdType"))) _idtype = reader.GetInt64(reader.GetOrdinal("IdType"));
                if (!reader.IsDBNull(reader.GetOrdinal("CivilIdNumber"))) _civilidnumber = reader.GetString(reader.GetOrdinal("CivilIdNumber"));
                if (!reader.IsDBNull(reader.GetOrdinal("CivilIdExpiryDate"))) _civilidexpirydate = reader.GetDateTime(reader.GetOrdinal("CivilIdExpiryDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsPersonBlocked"))) _ispersonblocked = reader.GetBoolean(reader.GetOrdinal("IsPersonBlocked"));
                if (!reader.IsDBNull(reader.GetOrdinal("PersonBlockStartDate"))) _personblockstartdate = reader.GetDateTime(reader.GetOrdinal("PersonBlockStartDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("PersonBlockEndDate"))) _personblockenddate = reader.GetDateTime(reader.GetOrdinal("PersonBlockEndDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("PersonBlockedByUserId"))) _personblockedbyuserid = reader.GetInt64(reader.GetOrdinal("PersonBlockedByUserId"));
                if (!reader.IsDBNull(reader.GetOrdinal("PersonExtentionEndDate"))) _personextentionenddate = reader.GetDateTime(reader.GetOrdinal("PersonExtentionEndDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("PersonExtendAt"))) _personextendat = reader.GetDateTime(reader.GetOrdinal("PersonExtendAt"));
                if (!reader.IsDBNull(reader.GetOrdinal("PersonExtendByUserId"))) _personextendbyuserid = reader.GetInt64(reader.GetOrdinal("PersonExtendByUserId"));

                if (!reader.IsDBNull(reader.GetOrdinal("PassportNumber"))) _passportnumber = reader.GetString(reader.GetOrdinal("PassportNumber"));
                if (!reader.IsDBNull(reader.GetOrdinal("HasVehicle"))) _hasvehicle = reader.GetBoolean(reader.GetOrdinal("HasVehicle"));
                if (!reader.IsDBNull(reader.GetOrdinal("CarNumberPlate"))) _carnumberplate = reader.GetString(reader.GetOrdinal("CarNumberPlate"));
                if (!reader.IsDBNull(reader.GetOrdinal("VehicleColorId"))) _vehiclecolorid = reader.GetInt64(reader.GetOrdinal("VehicleColorId"));
                if (!reader.IsDBNull(reader.GetOrdinal("VehicleRegistrationImagePath"))) _vehicleregistrationimagepath = reader.GetString(reader.GetOrdinal("VehicleRegistrationImagePath"));
                if (!reader.IsDBNull(reader.GetOrdinal("PersonalPicurePath"))) _personalpicurepath = reader.GetString(reader.GetOrdinal("PersonalPicurePath"));
                if (!reader.IsDBNull(reader.GetOrdinal("CivilIdImagePath"))) _civilidimagepath = reader.GetString(reader.GetOrdinal("CivilIdImagePath"));
                if (!reader.IsDBNull(reader.GetOrdinal("CivilIdBacksideImagePath"))) _civilidbacksideimagepath = reader.GetString(reader.GetOrdinal("CivilIdBacksideImagePath"));

                if (!reader.IsDBNull(reader.GetOrdinal("LicenseTypeID"))) _licensetypeid = reader.GetInt64(reader.GetOrdinal("LicenseTypeID"));
                if (!reader.IsDBNull(reader.GetOrdinal("EmergencyContactNumber"))) _emergencycontactnumber = reader.GetString(reader.GetOrdinal("EmergencyContactNumber"));
                if (!reader.IsDBNull(reader.GetOrdinal("MobileNoTypeId"))) _mobilenotypeid = reader.GetInt64(reader.GetOrdinal("MobileNoTypeId"));
                if (!reader.IsDBNull(reader.GetOrdinal("StartDate"))) _startdate = reader.GetDateTime(reader.GetOrdinal("StartDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("EndDate"))) _enddate = reader.GetDateTime(reader.GetOrdinal("EndDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("SubmitDate"))) _submitdate = reader.GetDateTime(reader.GetOrdinal("SubmitDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("ApprovedDate"))) _approveddate = reader.GetDateTime(reader.GetOrdinal("ApprovedDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("StatusID"))) _statusid = reader.GetInt64(reader.GetOrdinal("StatusID"));
                if (!reader.IsDBNull(reader.GetOrdinal("CanEnterAfterOffice"))) _canenterafteroffice = reader.GetBoolean(reader.GetOrdinal("CanEnterAfterOffice"));
                if (!reader.IsDBNull(reader.GetOrdinal("TimingNote"))) _timingnote = reader.GetString(reader.GetOrdinal("TimingNote"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsActive"))) _isactive = reader.GetBoolean(reader.GetOrdinal("IsActive"));
                if (!reader.IsDBNull(reader.GetOrdinal("CanEnterAfterOffice"))) _canenterafteroffice = reader.GetBoolean(reader.GetOrdinal("CanEnterAfterOffice"));
                if (!reader.IsDBNull(reader.GetOrdinal("TimingNote"))) _timingnote = reader.GetString(reader.GetOrdinal("TimingNote")); if (!reader.IsDBNull(reader.GetOrdinal("TransID"))) this.BaseSecurityParam.transid = reader.GetString(reader.GetOrdinal("TransID"));
                if (!reader.IsDBNull(reader.GetOrdinal("CreatedByUserName"))) this.BaseSecurityParam.createdbyusername = reader.GetString(reader.GetOrdinal("CreatedByUserName"));
                if (!reader.IsDBNull(reader.GetOrdinal("CreatedDate"))) this.BaseSecurityParam.createddate = reader.GetDateTime(reader.GetOrdinal("CreatedDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("UpdatedByUserName"))) this.BaseSecurityParam.updatedbyusername = reader.GetString(reader.GetOrdinal("UpdatedByUserName"));
                if (!reader.IsDBNull(reader.GetOrdinal("UpdatedDate"))) this.BaseSecurityParam.updateddate = reader.GetDateTime(reader.GetOrdinal("UpdatedDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("IPAddress"))) this.BaseSecurityParam.ipaddress = reader.GetString(reader.GetOrdinal("IPAddress"));
                if (!reader.IsDBNull(reader.GetOrdinal("TS"))) this.BaseSecurityParam.ts = reader.GetInt64(reader.GetOrdinal("ts"));
                if (!reader.IsDBNull(reader.GetOrdinal("GateNamesString"))) _gatenamesstring = reader.GetString(reader.GetOrdinal("GateNamesString"));
                if (!reader.IsDBNull(reader.GetOrdinal("GateNamesArabicString"))) _gatenamesarabicstring = reader.GetString(reader.GetOrdinal("GateNamesArabicString"));

                //Relational Tables Data
                if (!reader.IsDBNull(reader.GetOrdinal("LicenseTypeName"))) _licensetypename = reader.GetString(reader.GetOrdinal("LicenseTypeName"));
                if (!reader.IsDBNull(reader.GetOrdinal("LicenseTypeNameAR"))) _licensetypenamear = reader.GetString(reader.GetOrdinal("LicenseTypeNameAR"));
                if (!reader.IsDBNull(reader.GetOrdinal("StatusName"))) _statusname = reader.GetString(reader.GetOrdinal("StatusName"));
                if (!reader.IsDBNull(reader.GetOrdinal("StatusNameAR"))) _statusnamear = reader.GetString(reader.GetOrdinal("StatusNameAR"));
                if (!reader.IsDBNull(reader.GetOrdinal("StatusCssClass"))) _statuscssclass = reader.GetString(reader.GetOrdinal("StatusCssClass"));
                if (!reader.IsDBNull(reader.GetOrdinal("StatusIconName"))) _statusiconname = reader.GetString(reader.GetOrdinal("StatusIconName"));
                if (!reader.IsDBNull(reader.GetOrdinal("NationalityName"))) _nationalityname = reader.GetString(reader.GetOrdinal("NationalityName"));
                if (!reader.IsDBNull(reader.GetOrdinal("NationalityNameAr"))) _nationalitynamear = reader.GetString(reader.GetOrdinal("NationalityNameAr"));
                if (!reader.IsDBNull(reader.GetOrdinal("MobileNoTypeName"))) _mobilenotypename = reader.GetString(reader.GetOrdinal("MobileNoTypeName"));
                if (!reader.IsDBNull(reader.GetOrdinal("MobileNoTypeNameAR"))) _mobilenotypenamear = reader.GetString(reader.GetOrdinal("MobileNoTypeName"));
                if (!reader.IsDBNull(reader.GetOrdinal("VehicleColorName"))) _vehiclecolorname = reader.GetString(reader.GetOrdinal("VehicleColorName"));
                if (!reader.IsDBNull(reader.GetOrdinal("VehicleColorNameAR"))) _vehiclecolornamear = reader.GetString(reader.GetOrdinal("VehicleColorNameAR"));

                if (!reader.IsDBNull(reader.GetOrdinal("Reason"))) _reason = reader.GetString(reader.GetOrdinal("Reason"));
                if (!reader.IsDBNull(reader.GetOrdinal("ApprovedByUserName"))) _approvedbyusername = reader.GetString(reader.GetOrdinal("ApprovedByUserName"));
                if (!reader.IsDBNull(reader.GetOrdinal("ApprovedByEmail"))) _approvedbyemail = reader.GetString(reader.GetOrdinal("ApprovedByEmail"));

                if (!reader.IsDBNull(reader.GetOrdinal("EntryStatusID"))) _entrystatusid = reader.GetInt64(reader.GetOrdinal("EntryStatusID"));
                if (!reader.IsDBNull(reader.GetOrdinal("EntryStatusName"))) _entrystatusname = reader.GetString(reader.GetOrdinal("EntryStatusName"));
                if (!reader.IsDBNull(reader.GetOrdinal("EntryStatusNameAR"))) _entrystatusnamear = reader.GetString(reader.GetOrdinal("EntryStatusNameAR"));
                if (!reader.IsDBNull(reader.GetOrdinal("EnteredGateId"))) _enteredgateid = reader.GetInt64(reader.GetOrdinal("EnteredGateId"));
                if (!reader.IsDBNull(reader.GetOrdinal("EnteredGateName"))) _enteredgatename = reader.GetString(reader.GetOrdinal("EnteredGateName"));
                if (!reader.IsDBNull(reader.GetOrdinal("EnteredGateNameAr"))) _enteredgatenamear = reader.GetString(reader.GetOrdinal("EnteredGateNameAr"));

                CurrentState = EntityState.Unchanged;
            }
        }
    }


    public class dtrequestvisitor : DtParameters
    {
        protected long? _requestapplicationid;

        public long? requestapplicationid
        {
            get { return _requestapplicationid; }
            set { _requestapplicationid = value; this.OnChnaged(); }
        }

        protected string _civilidnumber;
        protected string _fullname;
        protected string _jobtitle;
        protected string _carnumberplate;
        protected long? _approvedbymasteruserid;
        protected long? _gateid;
        protected long? _licensetypeid;
        protected long? _requesttypeid;
        protected string _emergencycontactnumber;
        protected DateTime? _startdate;
        protected DateTime? _enddate;
        protected string _reason;
        public string fullname
        {
            get { return _fullname; }
            set { _fullname = value; this.OnChnaged(); }
        }
        public string jobtitle
        {
            get { return _jobtitle; }
            set { _jobtitle = value; this.OnChnaged(); }
        }
        public string civilidnumber
        {
            get { return _civilidnumber; }
            set { _civilidnumber = value; this.OnChnaged(); }
        }
        public string carnumberplate
        {
            get { return _carnumberplate; }
            set { _carnumberplate = value; this.OnChnaged(); }
        }
        public long? gateid
        {
            get { return _gateid; }
            set { _gateid = value; this.OnChnaged(); }
        }
        public long? approvedbymasteruserid
        {
            get { return _approvedbymasteruserid; }
            set { _approvedbymasteruserid = value; this.OnChnaged(); }
        }
        public long? licensetypeid
        {
            get { return _licensetypeid; }
            set { _licensetypeid = value; this.OnChnaged(); }
        }
        public long? requesttypeid
        {
            get { return _requesttypeid; }
            set { _requesttypeid = value; this.OnChnaged(); }
        }
        public string emergencycontactnumber
        {
            get { return _emergencycontactnumber; }
            set { _emergencycontactnumber = value; this.OnChnaged(); }
        }
        [DataType(DataType.Date), DisplayFormat(DataFormatString = @"{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? startdate
        {
            get { return _startdate; }
            set { _startdate = value; this.OnChnaged(); }
        }
        [DataType(DataType.Date), DisplayFormat(DataFormatString = @"{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? enddate
        {
            get { return _enddate; }
            set { _enddate = value; this.OnChnaged(); }
        }

        public string reason
        {
            get { return _reason; }
            set { _reason = value; this.OnChnaged(); }
        }

    }

    public partial class vm_VisitorWithInOutVm
    {
        public tran_applicationreqforvisitorEntity visitor { get; set; }
        public tran_applicationreqvisitorinoutEntity inout { get; set; }
    }
}
