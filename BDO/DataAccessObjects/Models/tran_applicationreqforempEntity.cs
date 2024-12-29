using System;
using System.Runtime.Serialization;
using System.Data;
using BDO.Core.Base;
using System.ComponentModel.DataAnnotations;

namespace BDO.Core.DataAccessObjects.Models
{
    [Serializable]
    [DataContract(Name = "tran_applicationreqforempEntity", Namespace = "http://www.KAF.com/types")]
    public partial class tran_applicationreqforempEntity : BaseEntity
    {
        #region Properties

        protected long? _requestapplicationid;
        protected long? _companyid;
        protected long? _requesterid;
        protected long? _representativeid;
        protected long? _licensetypeid;
        protected long? _requesttypeid;
        protected long? _numberofemployees;
        protected long? _numberofvehicle;
        protected int? _numberofdays;
        protected int? _numberofweeks;
        protected string _emergencycontactnumber;
        protected long? _mobilenotypeid;
        protected DateTime? _submitdate;
        protected long? _approvedbymasteruserid;
        protected DateTime? _approveddate;
        protected DateTime? _expirydate;
        protected long? _statusid;
        protected bool? _isreadbyadmin;
        protected string _lastreadbyadminname;
        protected bool? _canenterafteroffice;
        protected string _timingnote;
        protected bool? _isactive;
        protected string _remarks;
        protected string _updateinfo;
        protected long? _tranformactionid;
        protected DateTime? _startdate;
        protected DateTime? _enddate;

        protected decimal? _feeamount;
        protected bool? _isitfree;
        protected decimal? _discountamount;
        protected decimal? _feeamountafterdiscount;
        protected decimal? _applicationrequestfee;
        protected long? _discountedbymasteruserid;
        protected long? _feecalculatedbymasteruserid;
        protected decimal? _payableamount;
        protected string _paymenttrackid;
        protected string _paymenttransactionid;
        protected bool? _ispaidpayment;
        protected DateTime? _paymentrequestdate;

        [DataMember]
        public long? requestapplicationid
        {
            get { return _requestapplicationid; }
            set { _requestapplicationid = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "companyid", ResourceType = typeof(CLL.LLClasses.Models._tran_applicationreqforemp))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._tran_applicationreqforemp), ErrorMessageResourceName = "companyidRequired")]
        public long? companyid
        {
            get { return _companyid; }
            set { _companyid = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "requesterid", ResourceType = typeof(CLL.LLClasses.Models._tran_applicationreqforemp))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._tran_applicationreqforemp), ErrorMessageResourceName = "requesteridRequired")]
        public long? requesterid
        {
            get { return _requesterid; }
            set { _requesterid = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "representativeid", ResourceType = typeof(CLL.LLClasses.Models._tran_applicationreqforemp))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._tran_applicationreqforemp), ErrorMessageResourceName = "representativeidRequired")]
        public long? representativeid
        {
            get { return _representativeid; }
            set { _representativeid = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "licensetypeid", ResourceType = typeof(CLL.LLClasses.Models._tran_applicationreqforemp))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._tran_applicationreqforemp), ErrorMessageResourceName = "licensetypeidRequired")]
        public long? licensetypeid
        {
            get { return _licensetypeid; }
            set { _licensetypeid = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "requesttypeid", ResourceType = typeof(CLL.LLClasses.Models._tran_applicationreqforemp))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._tran_applicationreqforemp), ErrorMessageResourceName = "requesttypeidRequired")]
        public long? requesttypeid
        {
            get { return _requesttypeid; }
            set { _requesttypeid = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "numberofemployees", ResourceType = typeof(CLL.LLClasses.Models._tran_applicationreqforemp))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._tran_applicationreqforemp), ErrorMessageResourceName = "numberofemployeesRequired")]
        public long? numberofemployees
        {
            get { return _numberofemployees; }
            set { _numberofemployees = value; this.OnChnaged(); }
        }
        [DataMember]
        [Display(Name = "numberofvehicle", ResourceType = typeof(CLL.LLClasses.Models._tran_applicationreqforvehicle))]
        public long? numberofvehicle
        {
            get { return _numberofvehicle; }
            set { _numberofvehicle = value; this.OnChnaged(); }
        }
        [DataMember]
        [Display(Name = "numberofdays", ResourceType = typeof(CLL.LLClasses._Common))]
        public int? numberofdays
        {
            get { return _numberofdays; }
            set { _numberofdays = value; this.OnChnaged(); }
        }
        [DataMember]
        [Display(Name = "numberofweeks", ResourceType = typeof(CLL.LLClasses._Common))]
        public int? numberofweeks
        {
            get { return _numberofweeks; }
            set { _numberofweeks = value; this.OnChnaged(); }
        }
        [DataMember]
        [StringLength(8, MinimumLength = 8, ErrorMessageResourceName = "MobileNumberMustBe8Character", ErrorMessageResourceType = typeof(CLL.LLClasses._Common))]
        [Display(Name = "emergencycontactnumber", ResourceType = typeof(CLL.LLClasses.Models._tran_applicationreqforemp))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._tran_applicationreqforemp), ErrorMessageResourceName = "emergencycontactnumberRequired")]
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
        [Display(Name = "submitdate", ResourceType = typeof(CLL.LLClasses.Models._tran_applicationreqforemp))]
        [DataType(DataType.Date), DisplayFormat(DataFormatString = @"{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? submitdate
        {
            get { return _submitdate; }
            set { _submitdate = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "approvedbymasteruserid", ResourceType = typeof(CLL.LLClasses.Models._tran_applicationreqforemp))]
        public long? approvedbymasteruserid
        {
            get { return _approvedbymasteruserid; }
            set { _approvedbymasteruserid = value; this.OnChnaged(); }
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
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._tran_applicationreqforemp), ErrorMessageResourceName = "statusidRequired")]
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
        [Display(Name = "isactive", ResourceType = typeof(CLL.LLClasses.Models._tran_applicationreqforemp))]
        public bool? isactive
        {
            get { return _isactive; }
            set { _isactive = value; this.OnChnaged(); }
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
        [Display(Name = "updateinfo", ResourceType = typeof(CLL.LLClasses.Models._tran_applicationreqforemp))]
        public string updateinfo
        {
            get { return _updateinfo; }
            set { _updateinfo = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "tranformactionid", ResourceType = typeof(CLL.LLClasses.Models._tran_applicationreqforemp))]
        public long? tranformactionid
        {
            get { return _tranformactionid; }
            set { _tranformactionid = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "startdate", ResourceType = typeof(CLL.LLClasses.Models._tran_applicationreqforemp))]
        [DataType(DataType.Date), DisplayFormat(DataFormatString = @"{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._tran_applicationreqforemp), ErrorMessageResourceName = "startdateRequired")]
        public DateTime? startdate
        {
            get { return _startdate; }
            set { _startdate = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "enddate", ResourceType = typeof(CLL.LLClasses.Models._tran_applicationreqforemp))]
        [DataType(DataType.Date), DisplayFormat(DataFormatString = @"{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._tran_applicationreqforemp), ErrorMessageResourceName = "enddateRequired")]
        public DateTime? enddate
        {
            get { return _enddate; }
            set { _enddate = value; this.OnChnaged(); }
        }


        [DataMember]
        [Display(Name = "feeamount", ResourceType = typeof(CLL.LLClasses._Common))]
        public decimal? feeamount
        {
            get { return _feeamount; }
            set { _feeamount = value; this.OnChnaged(); }
        }
        [DataMember]
        [Display(Name = "feeamountafterdiscount", ResourceType = typeof(CLL.LLClasses._Common))]
        public decimal? feeamountafterdiscount
        {
            get { return _feeamountafterdiscount; }
            set { _feeamountafterdiscount = value; this.OnChnaged(); }
        }
        [DataMember]
        [Display(Name = "applicationrequestfee", ResourceType = typeof(CLL.LLClasses._Common))]
        public decimal? applicationrequestfee
        {
            get { return _applicationrequestfee; }
            set { _applicationrequestfee = value; this.OnChnaged(); }
        }
        [DataMember]
        [Display(Name = "isitfree", ResourceType = typeof(CLL.LLClasses._Common))]
        public bool? isitfree
        {
            get { return _isitfree; }
            set { _isitfree = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "discountamount", ResourceType = typeof(CLL.LLClasses._Common))]
        public decimal? discountamount
        {
            get { return _discountamount; }
            set { _discountamount = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "payableamount", ResourceType = typeof(CLL.LLClasses._Common))]
        public decimal? payableamount
        {
            get { return _payableamount; }
            set { _payableamount = value; this.OnChnaged(); }
        }
        [DataMember]
        [Display(Name = "discountedbymasteruserid", ResourceType = typeof(CLL.LLClasses._Common))]
        public long? discountedbymasteruserid
        {
            get { return _discountedbymasteruserid; }
            set { _discountedbymasteruserid = value; this.OnChnaged(); }
        }
        [DataMember]
        [Display(Name = "feecalculatedbymasteruserid", ResourceType = typeof(CLL.LLClasses._Common))]
        public long? feecalculatedbymasteruserid
        {
            get { return _feecalculatedbymasteruserid; }
            set { _feecalculatedbymasteruserid = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "paymenttrackid", ResourceType = typeof(CLL.LLClasses._Common))]
        public string paymenttrackid
        {
            get { return _paymenttrackid; }
            set { _paymenttrackid = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "paymenttransactionid", ResourceType = typeof(CLL.LLClasses._Common))]
        public string paymenttransactionid
        {
            get { return _paymenttransactionid; }
            set { _paymenttransactionid = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "ispaidpayment", ResourceType = typeof(CLL.LLClasses._Common))]
        public bool? ispaidpayment
        {
            get { return _ispaidpayment; }
            set { _ispaidpayment = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "paymentrequestdate", ResourceType = typeof(CLL.LLClasses._Common))]
        public DateTime? paymentrequestdate
        {
            get { return _paymentrequestdate; }
            set { _paymentrequestdate = value; this.OnChnaged(); }
        }
        #endregion

        #region Constructor

        public tran_applicationreqforempEntity() : base()
        {
            _contractdocument = new reg_studentfilestorageEntity();
        }

        public tran_applicationreqforempEntity(IDataReader reader)
        {
            this.LoadFromReader(reader);
        }

        public tran_applicationreqforempEntity(IDataReader reader, bool IsListViewShow)
        {
            this.LoadFromReader(reader, IsListViewShow);
        }



        protected void LoadFromReader(IDataReader reader)
        {
            if (reader != null && !reader.IsClosed)
            {
                this.BaseSecurityParam = new SecurityCapsule();
                if (!reader.IsDBNull(reader.GetOrdinal("RequestApplicationID"))) _requestapplicationid = reader.GetInt64(reader.GetOrdinal("RequestApplicationID"));
                if (!reader.IsDBNull(reader.GetOrdinal("CompanyID"))) _companyid = reader.GetInt64(reader.GetOrdinal("CompanyID"));
                if (!reader.IsDBNull(reader.GetOrdinal("RequesterID"))) _requesterid = reader.GetInt64(reader.GetOrdinal("RequesterID"));
                if (!reader.IsDBNull(reader.GetOrdinal("RepresentativeID"))) _representativeid = reader.GetInt64(reader.GetOrdinal("RepresentativeID"));
                if (!reader.IsDBNull(reader.GetOrdinal("LicenseTypeID"))) _licensetypeid = reader.GetInt64(reader.GetOrdinal("LicenseTypeID"));
                if (!reader.IsDBNull(reader.GetOrdinal("RequestTypeID"))) _requesttypeid = reader.GetInt64(reader.GetOrdinal("RequestTypeID"));
                if (!reader.IsDBNull(reader.GetOrdinal("NumberOfEmployees"))) _numberofemployees = reader.GetInt64(reader.GetOrdinal("NumberOfEmployees"));
                if (!reader.IsDBNull(reader.GetOrdinal("NumberOfVehicle"))) _numberofvehicle = reader.GetInt64(reader.GetOrdinal("NumberOfVehicle"));
                if (!reader.IsDBNull(reader.GetOrdinal("NumberOfDays"))) _numberofdays = reader.GetInt32(reader.GetOrdinal("NumberOfDays"));
                if (!reader.IsDBNull(reader.GetOrdinal("NumberOfWeeks"))) _numberofweeks = reader.GetInt32(reader.GetOrdinal("NumberOfWeeks"));
                if (!reader.IsDBNull(reader.GetOrdinal("EmergencyContactNumber"))) _emergencycontactnumber = reader.GetString(reader.GetOrdinal("EmergencyContactNumber"));
                if (!reader.IsDBNull(reader.GetOrdinal("MobileNoTypeId"))) _mobilenotypeid = reader.GetInt64(reader.GetOrdinal("MobileNoTypeId"));
                if (!reader.IsDBNull(reader.GetOrdinal("SubmitDate"))) _submitdate = reader.GetDateTime(reader.GetOrdinal("SubmitDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("ApprovedByMasterUserId"))) _approvedbymasteruserid = reader.GetInt64(reader.GetOrdinal("ApprovedByMasterUserId"));
                if (!reader.IsDBNull(reader.GetOrdinal("ApprovedDate"))) _approveddate = reader.GetDateTime(reader.GetOrdinal("ApprovedDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("ExpiryDate"))) _expirydate = reader.GetDateTime(reader.GetOrdinal("ExpiryDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("StatusID"))) _statusid = reader.GetInt64(reader.GetOrdinal("StatusID"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsReadByAdmin"))) _isreadbyadmin = reader.GetBoolean(reader.GetOrdinal("IsReadByAdmin"));
                if (!reader.IsDBNull(reader.GetOrdinal("LastReadByAdminName"))) _lastreadbyadminname = reader.GetString(reader.GetOrdinal("LastReadByAdminName"));
                if (!reader.IsDBNull(reader.GetOrdinal("StartDate"))) _startdate = reader.GetDateTime(reader.GetOrdinal("StartDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("EndDate"))) _enddate = reader.GetDateTime(reader.GetOrdinal("EndDate"));

                if (!reader.IsDBNull(reader.GetOrdinal("FeeAmount"))) _feeamount = reader.GetDecimal(reader.GetOrdinal("FeeAmount"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsItFree"))) _isitfree = reader.GetBoolean(reader.GetOrdinal("IsItFree"));
                if (!reader.IsDBNull(reader.GetOrdinal("DiscountAmount"))) _discountamount = reader.GetDecimal(reader.GetOrdinal("DiscountAmount"));
                if (!reader.IsDBNull(reader.GetOrdinal("FeeAmountAfterDiscount"))) _feeamountafterdiscount = reader.GetDecimal(reader.GetOrdinal("FeeAmountAfterDiscount"));
                if (!reader.IsDBNull(reader.GetOrdinal("ApplicationRequestFee"))) _applicationrequestfee = reader.GetDecimal(reader.GetOrdinal("ApplicationRequestFee"));
                if (!reader.IsDBNull(reader.GetOrdinal("PayableAmount"))) _payableamount = reader.GetDecimal(reader.GetOrdinal("PayableAmount"));
                if (!reader.IsDBNull(reader.GetOrdinal("DiscountedByMasterUserId"))) _discountedbymasteruserid = reader.GetInt64(reader.GetOrdinal("DiscountedByMasterUserId"));
                if (!reader.IsDBNull(reader.GetOrdinal("PaymentTrackId"))) _paymenttrackid = reader.GetString(reader.GetOrdinal("PaymentTrackId"));
                if (!reader.IsDBNull(reader.GetOrdinal("PaymentTransactionId"))) _paymenttransactionid = reader.GetString(reader.GetOrdinal("PaymentTransactionId"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsPaidPayment"))) _ispaidpayment = reader.GetBoolean(reader.GetOrdinal("IsPaidPayment"));
                if (!reader.IsDBNull(reader.GetOrdinal("PaymentRequestDate"))) _paymentrequestdate = reader.GetDateTime(reader.GetOrdinal("PaymentRequestDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("CanEnterAfterOffice"))) _canenterafteroffice = reader.GetBoolean(reader.GetOrdinal("CanEnterAfterOffice"));
                if (!reader.IsDBNull(reader.GetOrdinal("TimingNote"))) _timingnote = reader.GetString(reader.GetOrdinal("TimingNote")); if (!reader.IsDBNull(reader.GetOrdinal("IsActive"))) _isactive = reader.GetBoolean(reader.GetOrdinal("IsActive"));
                if (!reader.IsDBNull(reader.GetOrdinal("Remarks"))) _remarks = reader.GetString(reader.GetOrdinal("Remarks"));
                if (!reader.IsDBNull(reader.GetOrdinal("TransID"))) this.BaseSecurityParam.transid = reader.GetString(reader.GetOrdinal("TransID"));
                if (!reader.IsDBNull(reader.GetOrdinal("CreatedByUserName"))) this.BaseSecurityParam.createdbyusername = reader.GetString(reader.GetOrdinal("CreatedByUserName"));
                if (!reader.IsDBNull(reader.GetOrdinal("CreatedDate"))) this.BaseSecurityParam.createddate = reader.GetDateTime(reader.GetOrdinal("CreatedDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("UpdatedByUserName"))) this.BaseSecurityParam.updatedbyusername = reader.GetString(reader.GetOrdinal("UpdatedByUserName"));
                if (!reader.IsDBNull(reader.GetOrdinal("UpdatedDate"))) this.BaseSecurityParam.updateddate = reader.GetDateTime(reader.GetOrdinal("UpdatedDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("UpdateInfo"))) _updateinfo = reader.GetString(reader.GetOrdinal("UpdateInfo"));
                if (!reader.IsDBNull(reader.GetOrdinal("IPAddress"))) this.BaseSecurityParam.ipaddress = reader.GetString(reader.GetOrdinal("IPAddress"));
                if (!reader.IsDBNull(reader.GetOrdinal("TranFormActionID"))) _tranformactionid = reader.GetInt64(reader.GetOrdinal("TranFormActionID"));
                if (!reader.IsDBNull(reader.GetOrdinal("TS"))) this.BaseSecurityParam.ts = reader.GetInt64(reader.GetOrdinal("ts"));
                CurrentState = EntityState.Unchanged;
            }
        }


        protected void LoadFromReader(IDataReader reader, bool IsListViewShow)
        {
            if (reader != null && !reader.IsClosed)
            {
                this.BaseSecurityParam = new SecurityCapsule();
                if (!reader.IsDBNull(reader.GetOrdinal("RequestApplicationID"))) _requestapplicationid = reader.GetInt64(reader.GetOrdinal("RequestApplicationID"));
                if (!reader.IsDBNull(reader.GetOrdinal("CompanyID"))) _companyid = reader.GetInt64(reader.GetOrdinal("CompanyID"));
                if (!reader.IsDBNull(reader.GetOrdinal("RequesterID"))) _requesterid = reader.GetInt64(reader.GetOrdinal("RequesterID"));
                if (!reader.IsDBNull(reader.GetOrdinal("RepresentativeID"))) _representativeid = reader.GetInt64(reader.GetOrdinal("RepresentativeID"));
                if (!reader.IsDBNull(reader.GetOrdinal("LicenseTypeID"))) _licensetypeid = reader.GetInt64(reader.GetOrdinal("LicenseTypeID"));
                if (!reader.IsDBNull(reader.GetOrdinal("RequestTypeID"))) _requesttypeid = reader.GetInt64(reader.GetOrdinal("RequestTypeID"));
                if (!reader.IsDBNull(reader.GetOrdinal("NumberOfEmployees"))) _numberofemployees = reader.GetInt64(reader.GetOrdinal("NumberOfEmployees"));
                if (!reader.IsDBNull(reader.GetOrdinal("NumberOfVehicle"))) _numberofvehicle = reader.GetInt64(reader.GetOrdinal("NumberOfVehicle"));
                if (!reader.IsDBNull(reader.GetOrdinal("NumberOfDays"))) _numberofdays = reader.GetInt32(reader.GetOrdinal("NumberOfDays"));
                if (!reader.IsDBNull(reader.GetOrdinal("NumberOfWeeks"))) _numberofweeks = reader.GetInt32(reader.GetOrdinal("NumberOfWeeks"));
                if (!reader.IsDBNull(reader.GetOrdinal("EmergencyContactNumber"))) _emergencycontactnumber = reader.GetString(reader.GetOrdinal("EmergencyContactNumber"));
                if (!reader.IsDBNull(reader.GetOrdinal("MobileNoTypeId"))) _mobilenotypeid = reader.GetInt64(reader.GetOrdinal("MobileNoTypeId"));
                if (!reader.IsDBNull(reader.GetOrdinal("SubmitDate"))) _submitdate = reader.GetDateTime(reader.GetOrdinal("SubmitDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("ApprovedByMasterUserId"))) _approvedbymasteruserid = reader.GetInt64(reader.GetOrdinal("ApprovedByMasterUserId"));
                if (!reader.IsDBNull(reader.GetOrdinal("ApprovedDate"))) _approveddate = reader.GetDateTime(reader.GetOrdinal("ApprovedDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("ExpiryDate"))) _expirydate = reader.GetDateTime(reader.GetOrdinal("ExpiryDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("StatusID"))) _statusid = reader.GetInt64(reader.GetOrdinal("StatusID"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsReadByAdmin"))) _isreadbyadmin = reader.GetBoolean(reader.GetOrdinal("IsReadByAdmin"));
                if (!reader.IsDBNull(reader.GetOrdinal("LastReadByAdminName"))) _lastreadbyadminname = reader.GetString(reader.GetOrdinal("LastReadByAdminName"));
                if (!reader.IsDBNull(reader.GetOrdinal("FeeAmount"))) _feeamount = reader.GetDecimal(reader.GetOrdinal("FeeAmount"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsItFree"))) _isitfree = reader.GetBoolean(reader.GetOrdinal("IsItFree"));
                if (!reader.IsDBNull(reader.GetOrdinal("DiscountAmount"))) _discountamount = reader.GetDecimal(reader.GetOrdinal("DiscountAmount"));
                if (!reader.IsDBNull(reader.GetOrdinal("FeeAmountAfterDiscount"))) _feeamountafterdiscount = reader.GetDecimal(reader.GetOrdinal("FeeAmountAfterDiscount"));
                if (!reader.IsDBNull(reader.GetOrdinal("ApplicationRequestFee"))) _applicationrequestfee = reader.GetDecimal(reader.GetOrdinal("ApplicationRequestFee"));
                if (!reader.IsDBNull(reader.GetOrdinal("PayableAmount"))) _payableamount = reader.GetDecimal(reader.GetOrdinal("PayableAmount"));
                if (!reader.IsDBNull(reader.GetOrdinal("DiscountedByMasterUserId"))) _discountedbymasteruserid = reader.GetInt64(reader.GetOrdinal("DiscountedByMasterUserId"));
                if (!reader.IsDBNull(reader.GetOrdinal("PaymentTrackId"))) _paymenttrackid = reader.GetString(reader.GetOrdinal("PaymentTrackId"));
                if (!reader.IsDBNull(reader.GetOrdinal("PaymentTransactionId"))) _paymenttransactionid = reader.GetString(reader.GetOrdinal("PaymentTransactionId"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsPaidPayment"))) _ispaidpayment = reader.GetBoolean(reader.GetOrdinal("IsPaidPayment"));
                if (!reader.IsDBNull(reader.GetOrdinal("PaymentRequestDate"))) _paymentrequestdate = reader.GetDateTime(reader.GetOrdinal("PaymentRequestDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("CanEnterAfterOffice"))) _canenterafteroffice = reader.GetBoolean(reader.GetOrdinal("CanEnterAfterOffice"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsActive"))) _isactive = reader.GetBoolean(reader.GetOrdinal("IsActive"));
                if (!reader.IsDBNull(reader.GetOrdinal("TimingNote"))) _timingnote = reader.GetString(reader.GetOrdinal("TimingNote")); if (!reader.IsDBNull(reader.GetOrdinal("Remarks"))) _remarks = reader.GetString(reader.GetOrdinal("Remarks"));
                if (!reader.IsDBNull(reader.GetOrdinal("Remarks"))) _remarks = reader.GetString(reader.GetOrdinal("Remarks"));
                if (!reader.IsDBNull(reader.GetOrdinal("TransID"))) this.BaseSecurityParam.transid = reader.GetString(reader.GetOrdinal("TransID"));
                if (!reader.IsDBNull(reader.GetOrdinal("CreatedByUserName"))) this.BaseSecurityParam.createdbyusername = reader.GetString(reader.GetOrdinal("CreatedByUserName"));
                if (!reader.IsDBNull(reader.GetOrdinal("CreatedDate"))) this.BaseSecurityParam.createddate = reader.GetDateTime(reader.GetOrdinal("CreatedDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("UpdatedByUserName"))) this.BaseSecurityParam.updatedbyusername = reader.GetString(reader.GetOrdinal("UpdatedByUserName"));
                if (!reader.IsDBNull(reader.GetOrdinal("UpdatedDate"))) this.BaseSecurityParam.updateddate = reader.GetDateTime(reader.GetOrdinal("UpdatedDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("UpdateInfo"))) _updateinfo = reader.GetString(reader.GetOrdinal("UpdateInfo"));
                if (!reader.IsDBNull(reader.GetOrdinal("IPAddress"))) this.BaseSecurityParam.ipaddress = reader.GetString(reader.GetOrdinal("IPAddress"));
                if (!reader.IsDBNull(reader.GetOrdinal("TranFormActionID"))) _tranformactionid = reader.GetInt64(reader.GetOrdinal("TranFormActionID"));
                if (!reader.IsDBNull(reader.GetOrdinal("TS"))) this.BaseSecurityParam.ts = reader.GetInt64(reader.GetOrdinal("ts"));
                if (!reader.IsDBNull(reader.GetOrdinal("StartDate"))) _startdate = reader.GetDateTime(reader.GetOrdinal("StartDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("EndDate"))) _enddate = reader.GetDateTime(reader.GetOrdinal("EndDate"));

                CurrentState = EntityState.Unchanged;
            }
        }

        #endregion



    }
}





