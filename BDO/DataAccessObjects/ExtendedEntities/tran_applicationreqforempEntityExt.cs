using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization;
using System.Data;
using BDO.Core.Base;
using System.ComponentModel.DataAnnotations;
using BDO.Core.DataAccessObjects.CommonEntities;
using KAF.BusinessDataObjects;
using CLL.LLClasses;
using static BDO.Core.Base.BaseEntity;
using System.Numerics;

namespace BDO.Core.DataAccessObjects.Models
{

    public partial class tran_applicationreqforempEntity
    {
        #region Properties
        [Display(Name = "serial", ResourceType = typeof(CLL.LLClasses._Common))]
        public long serial { get; set; }
        #region File Upload Region
        protected reg_studentfilestorageEntity _contractdocument;
        protected string _contractdocumentfilepath;

        protected string _gateidstring;
        [DataMember]
        [MaxLength(550)]
        [Display(Name = "contractdocument", ResourceType = typeof(CLL.LLClasses.Models._tran_applicationreqforemp))]
        public string contractdocumentfilepath
        {
            get { return _contractdocumentfilepath; }
            set { _contractdocumentfilepath = value; this.OnChnaged(); }
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
        [Display(Name = "contractdocument", ResourceType = typeof(CLL.LLClasses.Models._tran_applicationreqforemp))]

        public reg_studentfilestorageEntity contractdocument { get => _contractdocument; set => _contractdocument = value; }

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
        protected string _representativenationality;
        protected string _representativenationalityar;
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
        protected string _encrequestid;




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
        public string representativenationality { get => _representativenationality; set => _representativenationality = value; }

        [DataMember]
        [Display(Name = "nationalitynamear", ResourceType = typeof(CLL.LLClasses.Models._gen_nationality))]
        public string representativenationalityar { get => _representativenationalityar; set => _representativenationalityar = value; }

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
        [MaxLength(550)]
        public string encrequestid
        {
            get { return _encrequestid; }
            set { _encrequestid = value; this.OnChnaged(); }
        }


        #endregion


        #region Region Constuctor
        public tran_applicationreqforempEntity(IDataReader reader, bool IsListViewShow, bool withRelationalData)
        {
            this.LoadFromReader(reader, IsListViewShow, withRelationalData);
        }
        protected void LoadFromReader(IDataReader reader, bool IsListViewShow, bool withRelationalData)
        {
            if (reader != null && !reader.IsClosed)
            {
                this.BaseSecurityParam = new SecurityCapsule();
                if (!reader.IsDBNull(reader.GetOrdinal("RowNumber"))) serial = reader.GetInt64(reader.GetOrdinal("RowNumber"));
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
                if (!reader.IsDBNull(reader.GetOrdinal("StartDate"))) _startdate = reader.GetDateTime(reader.GetOrdinal("StartDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("EndDate"))) _enddate = reader.GetDateTime(reader.GetOrdinal("EndDate"));
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
                if (!reader.IsDBNull(reader.GetOrdinal("TimingNote"))) _timingnote = reader.GetString(reader.GetOrdinal("TimingNote")); if (!reader.IsDBNull(reader.GetOrdinal("Remarks"))) _remarks = reader.GetString(reader.GetOrdinal("Remarks"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsActive"))) _isactive = reader.GetBoolean(reader.GetOrdinal("IsActive"));
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
                if (!reader.IsDBNull(reader.GetOrdinal("RepresentativeNationality"))) _representativenationality = reader.GetString(reader.GetOrdinal("RepresentativeNationality"));
                if (!reader.IsDBNull(reader.GetOrdinal("RepresentativeNationalityAr"))) _representativenationalityar = reader.GetString(reader.GetOrdinal("RepresentativeNationalityAr"));
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

                CurrentState = EntityState.Unchanged;
            }
        }


        #endregion

        #endregion
    }

    [Serializable]
    [DataContract(Name = "checkauthmodel", Namespace = "http://www.KAF.com/types")]

    public partial class DTtran_applicationreqforempEntity : DtParameters
    {

        protected long? _paramid;

        [DataMember]
        public long? paramid { get => _paramid; set => _paramid = value; }
    }


    [Serializable]
    [DataContract(Name = "checkauthmodel", Namespace = "http://www.KAF.com/types")]
    public partial class checkauthmodel : BaseEntity
    {
        protected string _queryparam;

        [DataMember]
        public string queryparam { get => _queryparam; set => _queryparam = value; }

    }

 [Serializable]
    [DataContract(Name = "summaryamountofrequest", Namespace = "http://www.KAF.com/types")]
    public partial class summaryamountofrequest : BaseEntity
    {

        protected long? _requestapplicationid;
        protected DateTime? _startdate;
        protected DateTime? _enddate;
        protected int? _numberofdays;
        protected int? _numberofweeks;
        protected decimal? _feeamount;
        protected decimal? _discountamount;
        protected decimal? _feeamountafterdiscount;
        protected decimal? _applicationrequestfee;
        protected decimal? _payableamount;
        protected decimal? _feeperweek;
        protected bool? _isitfree;
        protected long? _licensetypeid;

        [DataMember]
        public long? requestapplicationid { get => _requestapplicationid; set => _requestapplicationid = value; }
        [DataMember]
        public DateTime? startdate { get => _startdate; set => _startdate = value; }
        [DataMember]
        public DateTime? enddate { get => _enddate; set => _enddate = value; }
        [DataMember]
        public int? numberofdays { get => _numberofdays; set => _numberofdays = value; }
        [DataMember]
        public int? numberofweeks { get => _numberofweeks; set => _numberofweeks = value; }
        [DataMember]
        public decimal? feeamount { get => _feeamount; set => _feeamount = value; }
        [DataMember]
        public decimal? discountamount { get => _discountamount; set => _discountamount = value; }
        [DataMember]
        public decimal? feeamountafterdiscount { get => _feeamountafterdiscount; set => _feeamountafterdiscount = value; }
        [DataMember]
        public decimal? applicationrequestfee { get => _applicationrequestfee; set => _applicationrequestfee = value; }
        [DataMember]
        public decimal? payableamount { get => _payableamount; set => _payableamount = value; }

        [DataMember]
        public decimal? feeperweek { get => _feeperweek; set => _feeperweek = value; }
        [DataMember]
        public bool? isitfree { get => _isitfree; set => _isitfree = value; }
        [DataMember]
        public long? licensetypeid { get => _licensetypeid; set => _licensetypeid = value; }


        #region Constructor
        public summaryamountofrequest() : base()
        {
        }

        public summaryamountofrequest(IDataReader reader)
        {
            this.LoadFromReader(reader);
        }
        protected void LoadFromReader(IDataReader reader)
        {
            if (reader != null && !reader.IsClosed)
            {
                this.BaseSecurityParam = new SecurityCapsule();
                if (!reader.IsDBNull(reader.GetOrdinal("RequestApplicationID"))) _requestapplicationid = reader.GetInt64(reader.GetOrdinal("RequestApplicationID"));
                if (!reader.IsDBNull(reader.GetOrdinal("NumberOfDays"))) _numberofdays = reader.GetInt32(reader.GetOrdinal("NumberOfDays"));
                if (!reader.IsDBNull(reader.GetOrdinal("NumberOfWeeks"))) _numberofweeks = reader.GetInt32(reader.GetOrdinal("NumberOfWeeks"));
                if (!reader.IsDBNull(reader.GetOrdinal("FeeAmount"))) _feeamount = reader.GetDecimal(reader.GetOrdinal("FeeAmount"));
                if (!reader.IsDBNull(reader.GetOrdinal("DiscountAmount"))) _discountamount = reader.GetDecimal(reader.GetOrdinal("DiscountAmount"));
                if (!reader.IsDBNull(reader.GetOrdinal("FeeAmountAfterDiscount"))) _feeamountafterdiscount = reader.GetDecimal(reader.GetOrdinal("FeeAmountAfterDiscount"));
                if (!reader.IsDBNull(reader.GetOrdinal("ApplicationRequestFee"))) _applicationrequestfee = reader.GetDecimal(reader.GetOrdinal("ApplicationRequestFee"));
                if (!reader.IsDBNull(reader.GetOrdinal("PayableAmount"))) _payableamount = reader.GetDecimal(reader.GetOrdinal("PayableAmount"));
                CurrentState = EntityState.Unchanged;
            }
        }

        #endregion
    }
}
