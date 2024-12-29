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
    public partial class tran_applicationreqforempdetlEntity
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
        public string largecivilidbacksideimage { get; set; }
        [DataMember]
        public string thumbscivilidbacksideimage { get; set; }
        [DataMember]
        public string base64civilidbacksideimage { get; set; }
        [DataMember]
        public string dimention_base64civilidbacksideimage { get; set; }

        [DataMember]
        public int cropwidthcivilidimage { get; set; } = 329; //8.7
        [DataMember]
        public int cropheightcivilidimage { get; set; } = 208; //5.5
        [DataMember]
        public int cropwidthvisaimage { get; set; } = 621; //A4
        [DataMember]
        public int cropheightvisaimage { get; set; } = 877; //A4

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

        #endregion

        #region For Relation
        protected long? _companyid;
        protected long? _requesterid;
        protected long? _representativeid;
        protected long? _licensetypeid;
        protected long? _requesttypeid;
        protected long? _numberofemployees;
        protected string _emergencycontactnumber;
        protected long? _mobilenotypeid;
        protected DateTime? _startdate;
        protected DateTime? _enddate;
        protected DateTime? _submitdate;
        protected DateTime? _approveddate;
        protected DateTime? _expirydate;
        protected long? _statusid;
        protected bool? _isreadbyadmin;
        protected string _lastreadbyadminname;
        protected string _approvedbysignature;
        protected bool? _canenterafteroffice;
        protected string _timingnote;
        protected string _contractdocument;


        protected string _remarks;
        protected string _currentstatus;
        protected string _gatenamesstring;
        protected string _gatenamesarabicstring;
        protected bool? _iscompanyblockednow;
        protected bool? _reviewedunderreview;
        protected bool? _reviewedaftermodify;
        protected bool? _reviewedexporting;
        protected bool? _isreviewed;
        protected long? _reviewedbyuserid;
        protected DateTime? _revieweddate;

        protected List<tran_applicationreqforempgatemapEntity> _permittedgates;

        [DataMember]
        public List<tran_applicationreqforempgatemapEntity> permittedgates
        {
            get { return _permittedgates; }
            set { _permittedgates = value; this.OnChnaged(); }
        }


        [DataMember]
        //[Display(Name = "companyid", ResourceType = typeof(CLL.LLClasses.Models._tran_applicationreqforemp))]
        public string approvedbysignature
        {
            get { return _approvedbysignature; }
            set { _approvedbysignature = value; this.OnChnaged(); }
        }
        [DataMember]
        [Display(Name = "companyid", ResourceType = typeof(CLL.LLClasses.Models._tran_applicationreqforemp))]
        public long? companyid
        {
            get { return _companyid; }
            set { _companyid = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "requesterid", ResourceType = typeof(CLL.LLClasses.Models._tran_applicationreqforemp))]
        public long? requesterid
        {
            get { return _requesterid; }
            set { _requesterid = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "representativeid", ResourceType = typeof(CLL.LLClasses.Models._tran_applicationreqforemp))]
        public long? representativeid
        {
            get { return _representativeid; }
            set { _representativeid = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "licensetypeid", ResourceType = typeof(CLL.LLClasses.Models._tran_applicationreqforemp))]
        public long? licensetypeid
        {
            get { return _licensetypeid; }
            set { _licensetypeid = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "requesttypeid", ResourceType = typeof(CLL.LLClasses.Models._tran_applicationreqforemp))]
        public long? requesttypeid
        {
            get { return _requesttypeid; }
            set { _requesttypeid = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "numberofemployees", ResourceType = typeof(CLL.LLClasses.Models._tran_applicationreqforemp))]
        public long? numberofemployees
        {
            get { return _numberofemployees; }
            set { _numberofemployees = value; this.OnChnaged(); }
        }


        [DataMember]
        [Display(Name = "emergencycontactnumber", ResourceType = typeof(CLL.LLClasses.Models._tran_applicationreqforemp))]
        public string emergencycontactnumber
        {
            get { return _emergencycontactnumber; }
            set { _emergencycontactnumber = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "mobilenotypeid", ResourceType = typeof(CLL.LLClasses.Models._tran_applicationreqforemp))]
        public long? mobilenotypeid
        {
            get { return _mobilenotypeid; }
            set { _mobilenotypeid = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "startdate", ResourceType = typeof(CLL.LLClasses.Models._tran_applicationreqforemp))]
        [DataType(DataType.Date), DisplayFormat(DataFormatString = @"{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? startdate
        {
            get { return _startdate; }
            set { _startdate = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "enddate", ResourceType = typeof(CLL.LLClasses.Models._tran_applicationreqforemp))]
        [DataType(DataType.Date), DisplayFormat(DataFormatString = @"{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? enddate
        {
            get { return _enddate; }
            set { _enddate = value; this.OnChnaged(); }
        }

        
        [DataMember]
        [Display(Name = "submitdate", ResourceType = typeof(CLL.LLClasses.Models._tran_applicationreqforemp))]
        [DataType(DataType.Date), DisplayFormat(DataFormatString = @"{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? submitdate
        {
            get { return _submitdate; }
            set { _submitdate = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "approveddate", ResourceType = typeof(CLL.LLClasses.Models._tran_applicationreqforemp))]
        [DataType(DataType.Date), DisplayFormat(DataFormatString = @"{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? approveddate
        {
            get { return _approveddate; }
            set { _approveddate = value; this.OnChnaged(); }
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
        [Display(Name = "statusid", ResourceType = typeof(CLL.LLClasses.Models._tran_applicationreqforemp))]
        public long? statusid
        {
            get { return _statusid; }
            set { _statusid = value; this.OnChnaged(); }
        }
        [DataMember]
        [Display(Name = "isreadbyadmin", ResourceType = typeof(CLL.LLClasses.Models._tran_applicationreqforemp))]
        public bool? isreadbyadmin
        {
            get { return _isreadbyadmin; }
            set { _isreadbyadmin = value; this.OnChnaged(); }
        }

        [DataMember]
        [MaxLength(550)]
        [Display(Name = "lastreadbyadminname", ResourceType = typeof(CLL.LLClasses.Models._tran_applicationreqforemp))]
        public string lastreadbyadminname
        {
            get { return _lastreadbyadminname; }
            set { _lastreadbyadminname = value; this.OnChnaged(); }
        }
        [DataMember]
        [Display(Name = "canenterafteroffice", ResourceType = typeof(CLL.LLClasses.Models._tran_applicationreqforemp))]
        public bool? canenterafteroffice
        {
            get { return _canenterafteroffice; }
            set { _canenterafteroffice = value; this.OnChnaged(); }
        }
        [DataMember]
        [MaxLength(550)]
        [Display(Name = "timingnote", ResourceType = typeof(CLL.LLClasses.Models._tran_applicationreqforemp))]
        public string timingnote
        {
            get { return _timingnote; }
            set { _timingnote = value; this.OnChnaged(); }
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
        public string gatenamesstring
        {
            get { return _gatenamesstring; }
            set { _gatenamesstring = value; this.OnChnaged(); }
        }
        [DataMember]
        [MaxLength(1550)]
        public string gatenamesarabicstring
        {
            get { return _gatenamesarabicstring; }
            set { _gatenamesarabicstring = value; this.OnChnaged(); }
        }

        [DataMember]
        // [Display(Name = "isreadbyadmin", ResourceType = typeof(CLL.LLClasses.Models._tran_applicationreqforemp))]
        public bool? iscompanyblockednow
        {
            get { return _iscompanyblockednow; }
            set { _iscompanyblockednow = value; this.OnChnaged(); }
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

        [DataMember]
        [MaxLength(550)]
        [Display(Name = "contractdocument", ResourceType = typeof(CLL.LLClasses.Models._tran_applicationreqforemp))]
        public string contractdocument
        {
            get { return _contractdocument; }
            set { _contractdocument = value; this.OnChnaged(); }
        }
        #endregion

        #region Relational Table

        protected string _companyname;
        protected string _companynamear;
        protected string _companymobileno;
        protected string _companyemailaddress;
        protected string _companywebsite;
        protected string _companyaddress;
        protected string _companytypename;
        protected string _companytypenamear;
        protected string _requestername;
        protected string _requesternamear;
        protected string _requesterdesignations;
        protected string _requestercivilid;
        protected string _requestermobileno;
        protected string _requesteremailaddress;
        protected string _mobilenotyperequester;
        protected string _mobilenotyperequesterar;
        protected string _representativename;
        protected string _representativenamear;
        protected string _representativedesignations;
        protected string _representativecivilid;
        protected string _representativemobileno;
        protected string _representativeemailaddress;
        protected string _representativeaddress;
        protected string _mobilenotyperepresentative;
        protected string _mobilenotyperepresentativear;
        protected string _licensetypename;
        protected string _licensetypenamear;
        protected string _requesttypename;
        protected string _requesttypenamear;
        protected string _statusname;
        protected string _statusnamear;
        protected string _statuscssclass;
        protected string _statusiconname;
        protected string _qrcode;

        protected string _nationalityname;
        protected string _nationalitynamear;




        [DataMember]
        [Display(Name = "companyname", ResourceType = typeof(CLL.LLClasses.Models._gen_company))]
        public string companyname { get => _companyname; set => _companyname = value; }


        [DataMember]
        [Display(Name = "companynamear", ResourceType = typeof(CLL.LLClasses.Models._gen_company))]
        public string companynamear { get => _companynamear; set => _companynamear = value; }

        [DataMember]
        [Display(Name = "companymobileno", ResourceType = typeof(CLL.LLClasses.Models._gen_company))]
        public string companymobileno { get => _companymobileno; set => _companymobileno = value; }

        [DataMember]
        [Display(Name = "companyemailaddress", ResourceType = typeof(CLL.LLClasses.Models._gen_company))]
        public string companyemailaddress { get => _companyemailaddress; set => _companyemailaddress = value; }

        [DataMember]
        [Display(Name = "companywebsite", ResourceType = typeof(CLL.LLClasses.Models._gen_company))]
        public string companywebsite { get => _companywebsite; set => _companywebsite = value; }

        [DataMember]
        [Display(Name = "companyaddress", ResourceType = typeof(CLL.LLClasses.Models._gen_company))]
        public string companyaddress { get => _companyaddress; set => _companyaddress = value; }

        [DataMember]
        [Display(Name = "companytypename", ResourceType = typeof(CLL.LLClasses.Models._gen_companytype))]
        public string companytypename { get => _companytypename; set => _companytypename = value; }

        [DataMember]
        [Display(Name = "companytypenamear", ResourceType = typeof(CLL.LLClasses.Models._gen_companytype))]
        public string companytypenamear { get => _companytypenamear; set => _companytypenamear = value; }

        [DataMember]
        [Display(Name = "requestername", ResourceType = typeof(CLL.LLClasses.Models._gen_requester))]
        public string requestername { get => _requestername; set => _requestername = value; }

        [DataMember]
        [Display(Name = "requesternamear", ResourceType = typeof(CLL.LLClasses.Models._gen_requester))]
        public string requesternamear { get => _requesternamear; set => _requesternamear = value; }


        [DataMember]
        [Display(Name = "designations", ResourceType = typeof(CLL.LLClasses.Models._gen_requester))]
        public string requesterdesignations { get => _requesterdesignations; set => _requesterdesignations = value; }

        [DataMember]
        [Display(Name = "civilid", ResourceType = typeof(CLL.LLClasses.Models._gen_requester))]
        public string requestercivilid { get => _requestercivilid; set => _requestercivilid = value; }


        [DataMember]
        [Display(Name = "mobileno", ResourceType = typeof(CLL.LLClasses.Models._gen_requester))]
        public string requestermobileno { get => _requestermobileno; set => _requestermobileno = value; }

        [DataMember]
        [Display(Name = "emailaddress", ResourceType = typeof(CLL.LLClasses.Models._gen_requester))]
        public string requesteremailaddress { get => _requesteremailaddress; set => _requesteremailaddress = value; }

        [DataMember]
        [Display(Name = "mobilenotypename", ResourceType = typeof(CLL.LLClasses.Models._gen_mobilenotype))]
        public string mobilenotyperequester { get => _mobilenotyperequester; set => _mobilenotyperequester = value; }

        [DataMember]
        [Display(Name = "mobilenotypenamear", ResourceType = typeof(CLL.LLClasses.Models._gen_mobilenotype))]
        public string mobilenotyperequesterar { get => _mobilenotyperequesterar; set => _mobilenotyperequesterar = value; }

        [DataMember]
        [Display(Name = "representativename", ResourceType = typeof(CLL.LLClasses.Models._gen_representative))]
        public string representativename { get => _representativename; set => _representativename = value; }

        [DataMember]
        [Display(Name = "representativenamear", ResourceType = typeof(CLL.LLClasses.Models._gen_representative))]
        public string representativenamear { get => _representativenamear; set => _representativenamear = value; }

        [DataMember]
        [Display(Name = "nationalityname", ResourceType = typeof(CLL.LLClasses.Models._gen_nationality))]
        public string representativenationality { get => _nationalityname; set => _nationalityname = value; }

        [DataMember]
        [Display(Name = "nationalitynamear", ResourceType = typeof(CLL.LLClasses.Models._gen_nationality))]
        public string representativenationalityar { get => _nationalitynamear; set => _nationalitynamear = value; }

        [DataMember]
        [Display(Name = "designations", ResourceType = typeof(CLL.LLClasses.Models._gen_representative))]
        public string representativedesignations { get => _representativedesignations; set => _representativedesignations = value; }

        [DataMember]
        [Display(Name = "civilid", ResourceType = typeof(CLL.LLClasses.Models._gen_representative))]
        public string representativecivilid { get => _representativecivilid; set => _representativecivilid = value; }

        [DataMember]
        [Display(Name = "mobileno", ResourceType = typeof(CLL.LLClasses.Models._gen_representative))]
        public string representativemobileno { get => _representativemobileno; set => _representativemobileno = value; }

        [DataMember]
        [Display(Name = "emailaddress", ResourceType = typeof(CLL.LLClasses.Models._gen_representative))]
        public string representativeemailaddress { get => _representativeemailaddress; set => _representativeemailaddress = value; }


        [DataMember]
        [Display(Name = "representativeaddress", ResourceType = typeof(CLL.LLClasses.Models._gen_representative))]
        public string representativeaddress { get => _representativeaddress; set => _representativeaddress = value; }

        [DataMember]
        [Display(Name = "mobilenotypename", ResourceType = typeof(CLL.LLClasses.Models._gen_mobilenotype))]
        public string mobilenotyperepresentative { get => _mobilenotyperepresentative; set => _mobilenotyperepresentative = value; }

        [DataMember]
        [Display(Name = "mobilenotypenamear", ResourceType = typeof(CLL.LLClasses.Models._gen_mobilenotype))]
        public string mobilenotyperepresentativear { get => _mobilenotyperepresentativear; set => _mobilenotyperepresentativear = value; }

        [DataMember]
        [Display(Name = "licensetypename", ResourceType = typeof(CLL.LLClasses.Models._gen_licensetype))]
        public string licensetypename { get => _licensetypename; set => _licensetypename = value; }

        [DataMember]
        [Display(Name = "licensetypenamear", ResourceType = typeof(CLL.LLClasses.Models._gen_licensetype))]
        public string licensetypenamear { get => _licensetypenamear; set => _licensetypenamear = value; }

        [DataMember]
        [Display(Name = "requesttypename", ResourceType = typeof(CLL.LLClasses.Models._gen_requesttype))]
        public string requesttypename { get => _requesttypename; set => _requesttypename = value; }

        [DataMember]
        [Display(Name = "requesttypenamear", ResourceType = typeof(CLL.LLClasses.Models._gen_requesttype))]
        public string requesttypenamear { get => _requesttypenamear; set => _requesttypenamear = value; }

        [DataMember]
        [Display(Name = "statusname", ResourceType = typeof(CLL.LLClasses.Models._gen_status))]
        public string statusname { get => _statusname; set => _statusname = value; }

        [DataMember]
        [Display(Name = "statusnamear", ResourceType = typeof(CLL.LLClasses.Models._gen_status))]
        public string statusnamear { get => _statusnamear; set => _statusnamear = value; }

        [DataMember]
        //[Display(Name = "nationalityname", ResourceType = typeof(CLL.LLClasses.Models._gen_status))]
        public string nationalityname { get => _nationalityname; set => _nationalityname = value; }

        [DataMember]
        //[Display(Name = "nationalitynamear", ResourceType = typeof(CLL.LLClasses.Models._gen_status))]
        public string nationalitynamear { get => _nationalitynamear; set => _nationalitynamear = value; }

        [DataMember]
        //[Display(Name = "statusnamear", ResourceType = typeof(CLL.LLClasses.Models._gen_status))]
        public string qrcode { get => _qrcode; set => _qrcode = value; }

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


        #endregion

        [Display(Name = "serial", ResourceType = typeof(CLL.LLClasses._Common))]
        public long serial { get; set; }

        [DataMember]
        [JsonPropertyName("encemployeeid")]
        public string encemployeeid { get; set; }
        [DataMember]
        public string encemployeeidasqueryparam { get; set; }
        [DataMember]
        public string encrequestid { get; set; }

        public tran_applicationreqforempdetlEntity(IDataReader reader, bool IsListViewShow, bool withRelationalData)
        {
            this.LoadFromReader(reader, IsListViewShow, withRelationalData);
        }

        protected void LoadFromReader(IDataReader reader, bool IsListViewShow, bool withRelationalData)
        {
            if (reader != null && !reader.IsClosed)
            {
                this.BaseSecurityParam = new SecurityCapsule();

                if (!reader.IsDBNull(reader.GetOrdinal("RowNumber"))) serial = reader.GetInt64(reader.GetOrdinal("RowNumber"));
                if (!reader.IsDBNull(reader.GetOrdinal("RequestEmployeeID"))) _requestemployeeid = reader.GetInt64(reader.GetOrdinal("RequestEmployeeID"));
                if (!reader.IsDBNull(reader.GetOrdinal("RequestApplicationID"))) _requestapplicationid = reader.GetInt64(reader.GetOrdinal("RequestApplicationID"));
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

                if (!reader.IsDBNull(reader.GetOrdinal("CompanyID"))) _companyid = reader.GetInt64(reader.GetOrdinal("CompanyID"));
                if (!reader.IsDBNull(reader.GetOrdinal("RequesterID"))) _requesterid = reader.GetInt64(reader.GetOrdinal("RequesterID"));
                if (!reader.IsDBNull(reader.GetOrdinal("RepresentativeID"))) _representativeid = reader.GetInt64(reader.GetOrdinal("RepresentativeID"));
                if (!reader.IsDBNull(reader.GetOrdinal("LicenseTypeID"))) _licensetypeid = reader.GetInt64(reader.GetOrdinal("LicenseTypeID"));
                if (!reader.IsDBNull(reader.GetOrdinal("RequestTypeID"))) _requesttypeid = reader.GetInt64(reader.GetOrdinal("RequestTypeID"));
                if (!reader.IsDBNull(reader.GetOrdinal("NumberOfEmployees"))) _numberofemployees = reader.GetInt64(reader.GetOrdinal("NumberOfEmployees"));
                if (!reader.IsDBNull(reader.GetOrdinal("EmergencyContactNumber"))) _emergencycontactnumber = reader.GetString(reader.GetOrdinal("EmergencyContactNumber"));
                if (!reader.IsDBNull(reader.GetOrdinal("MobileNoTypeId"))) _mobilenotypeid = reader.GetInt64(reader.GetOrdinal("MobileNoTypeId"));
                if (!reader.IsDBNull(reader.GetOrdinal("StartDate"))) _startdate = reader.GetDateTime(reader.GetOrdinal("StartDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("EndDate"))) _enddate = reader.GetDateTime(reader.GetOrdinal("EndDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("SubmitDate"))) _submitdate = reader.GetDateTime(reader.GetOrdinal("SubmitDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("ApprovedDate"))) _approveddate = reader.GetDateTime(reader.GetOrdinal("ApprovedDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("ExpiryDate"))) _expirydate = reader.GetDateTime(reader.GetOrdinal("ExpiryDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("StatusID"))) _statusid = reader.GetInt64(reader.GetOrdinal("StatusID"));
                if (!reader.IsDBNull(reader.GetOrdinal("FeeAmount"))) _feeamount = reader.GetDecimal(reader.GetOrdinal("FeeAmount"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsItFree"))) _isitfree = reader.GetBoolean(reader.GetOrdinal("IsItFree"));
                if (!reader.IsDBNull(reader.GetOrdinal("DiscountAmount"))) _discountamount = reader.GetDecimal(reader.GetOrdinal("DiscountAmount"));
                if (!reader.IsDBNull(reader.GetOrdinal("PayableAmount"))) _payableamount = reader.GetDecimal(reader.GetOrdinal("PayableAmount"));
                if (!reader.IsDBNull(reader.GetOrdinal("DiscountedByMasterUserId"))) _discountedbymasteruserid = reader.GetInt64(reader.GetOrdinal("DiscountedByMasterUserId"));
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
                if (!reader.IsDBNull(reader.GetOrdinal("CompanyName"))) _companyname = reader.GetString(reader.GetOrdinal("CompanyName"));
                if (!reader.IsDBNull(reader.GetOrdinal("CompanyNameAR"))) _companynamear = reader.GetString(reader.GetOrdinal("CompanyNameAR"));
                if (!reader.IsDBNull(reader.GetOrdinal("CompanyMobileNo"))) _companymobileno = reader.GetString(reader.GetOrdinal("CompanyMobileNo"));
                if (!reader.IsDBNull(reader.GetOrdinal("CompanyEmailAddress"))) _companyemailaddress = reader.GetString(reader.GetOrdinal("CompanyEmailAddress"));
                if (!reader.IsDBNull(reader.GetOrdinal("CompanyWebsite"))) _companywebsite = reader.GetString(reader.GetOrdinal("CompanyWebsite"));
                if (!reader.IsDBNull(reader.GetOrdinal("CompanyAddress"))) _companyaddress = reader.GetString(reader.GetOrdinal("CompanyAddress"));
                if (!reader.IsDBNull(reader.GetOrdinal("CompanyTypeName"))) _companytypename = reader.GetString(reader.GetOrdinal("CompanyTypeName"));
                if (!reader.IsDBNull(reader.GetOrdinal("CompanyTypeNameAR"))) _companytypenamear = reader.GetString(reader.GetOrdinal("CompanyTypeNameAR"));
                if (!reader.IsDBNull(reader.GetOrdinal("RequesterName"))) _requestername = reader.GetString(reader.GetOrdinal("RequesterName"));
                if (!reader.IsDBNull(reader.GetOrdinal("RequesterNameAR"))) _requesternamear = reader.GetString(reader.GetOrdinal("RequesterNameAR"));
                if (!reader.IsDBNull(reader.GetOrdinal("RequesterDesignations"))) _requesterdesignations = reader.GetString(reader.GetOrdinal("RequesterDesignations"));
                if (!reader.IsDBNull(reader.GetOrdinal("RequesterCivilId"))) _requestercivilid = reader.GetString(reader.GetOrdinal("RequesterCivilId"));
                if (!reader.IsDBNull(reader.GetOrdinal("RequesterMobileNo"))) _requestermobileno = reader.GetString(reader.GetOrdinal("RequesterMobileNo"));
                if (!reader.IsDBNull(reader.GetOrdinal("RequesterEmailAddress"))) _requesteremailaddress = reader.GetString(reader.GetOrdinal("RequesterEmailAddress"));
                if (!reader.IsDBNull(reader.GetOrdinal("MobileNoTypeRequester"))) _mobilenotyperequester = reader.GetString(reader.GetOrdinal("MobileNoTypeRequester"));
                if (!reader.IsDBNull(reader.GetOrdinal("MobileNoTypeRequesterAR"))) _mobilenotyperequesterar = reader.GetString(reader.GetOrdinal("MobileNoTypeRequesterAR"));
                if (!reader.IsDBNull(reader.GetOrdinal("RepresentativeName"))) _representativename = reader.GetString(reader.GetOrdinal("RepresentativeName"));
                if (!reader.IsDBNull(reader.GetOrdinal("RepresentativeNameAR"))) _representativenamear = reader.GetString(reader.GetOrdinal("RepresentativeNameAR"));
                if (!reader.IsDBNull(reader.GetOrdinal("RepresentativeDesignations"))) _representativedesignations = reader.GetString(reader.GetOrdinal("RepresentativeDesignations"));
                if (!reader.IsDBNull(reader.GetOrdinal("RepresentativeCivilId"))) _representativecivilid = reader.GetString(reader.GetOrdinal("RepresentativeCivilId"));
                if (!reader.IsDBNull(reader.GetOrdinal("RepresentativeMobileNo"))) _representativemobileno = reader.GetString(reader.GetOrdinal("RepresentativeMobileNo"));
                if (!reader.IsDBNull(reader.GetOrdinal("RepresentativeEmailAddress"))) _representativeemailaddress = reader.GetString(reader.GetOrdinal("RepresentativeEmailAddress"));
                if (!reader.IsDBNull(reader.GetOrdinal("RepresentativeAddress"))) _representativeaddress = reader.GetString(reader.GetOrdinal("RepresentativeAddress"));
                if (!reader.IsDBNull(reader.GetOrdinal("MobileNoTypeRepresentative"))) _mobilenotyperepresentative = reader.GetString(reader.GetOrdinal("MobileNoTypeRepresentative"));
                if (!reader.IsDBNull(reader.GetOrdinal("MobileNoTypeRepresentativeAR"))) _mobilenotyperepresentativear = reader.GetString(reader.GetOrdinal("MobileNoTypeRepresentativeAR"));
                if (!reader.IsDBNull(reader.GetOrdinal("LicenseTypeName"))) _licensetypename = reader.GetString(reader.GetOrdinal("LicenseTypeName"));
                if (!reader.IsDBNull(reader.GetOrdinal("LicenseTypeNameAR"))) _licensetypenamear = reader.GetString(reader.GetOrdinal("LicenseTypeNameAR"));
                if (!reader.IsDBNull(reader.GetOrdinal("RequestTypeName"))) _requesttypename = reader.GetString(reader.GetOrdinal("RequestTypeName"));
                if (!reader.IsDBNull(reader.GetOrdinal("RequestTypeNameAR"))) _requesttypenamear = reader.GetString(reader.GetOrdinal("RequestTypeNameAR"));
                if (!reader.IsDBNull(reader.GetOrdinal("StatusName"))) _statusname = reader.GetString(reader.GetOrdinal("StatusName"));
                if (!reader.IsDBNull(reader.GetOrdinal("StatusNameAR"))) _statusnamear = reader.GetString(reader.GetOrdinal("StatusNameAR"));
                if (!reader.IsDBNull(reader.GetOrdinal("StatusCssClass"))) _statuscssclass = reader.GetString(reader.GetOrdinal("StatusCssClass"));
                if (!reader.IsDBNull(reader.GetOrdinal("StatusIconName"))) _statusiconname = reader.GetString(reader.GetOrdinal("StatusIconName"));
                if (!reader.IsDBNull(reader.GetOrdinal("NationalityName"))) _nationalityname = reader.GetString(reader.GetOrdinal("NationalityName"));
                if (!reader.IsDBNull(reader.GetOrdinal("NationalityNameAr"))) _nationalitynamear = reader.GetString(reader.GetOrdinal("NationalityNameAr"));
                if (!reader.IsDBNull(reader.GetOrdinal("approvedbysignature"))) _approvedbysignature = reader.GetString(reader.GetOrdinal("ApprovedBySignature"));
                if (!reader.IsDBNull(reader.GetOrdinal("ContractDocument"))) _contractdocument = reader.GetString(reader.GetOrdinal("ContractDocument"));

                if (!reader.IsDBNull(reader.GetOrdinal("ReviewedUnderReview"))) _reviewedunderreview = reader.GetBoolean(reader.GetOrdinal("ReviewedUnderReview"));
                if (!reader.IsDBNull(reader.GetOrdinal("ReviewedAfterModify"))) _reviewedaftermodify = reader.GetBoolean(reader.GetOrdinal("ReviewedAfterModify"));
                if (!reader.IsDBNull(reader.GetOrdinal("ReviewedExporting"))) _reviewedexporting = reader.GetBoolean(reader.GetOrdinal("ReviewedExporting"));

                CurrentState = EntityState.Unchanged;
            }
        }
    }


    public class dtrequestemployee : DtParameters
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
        protected long? _companyid;
        protected long? _licensetypeid;
        protected long? _requesttypeid;
        protected string _emergencycontactnumber;
        protected DateTime? _startdate;
        protected DateTime? _enddate;
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
        public long? companyid
        {
            get { return _companyid; }
            set { _companyid = value; this.OnChnaged(); }
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


    }

}
