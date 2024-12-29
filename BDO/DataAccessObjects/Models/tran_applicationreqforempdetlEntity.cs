using System;
using System.Runtime.Serialization;
using System.Data;
using BDO.Core.Base;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace BDO.Core.DataAccessObjects.Models
{
    [Serializable]
    [DataContract(Name = "tran_applicationreqforempdetlEntity", Namespace = "http://www.KAF.com/types")]
    public partial class tran_applicationreqforempdetlEntity : BaseEntity
    {
        #region Properties

        protected long? _requestemployeeid;
        protected long? _requestapplicationid;
        protected string _fullname;
        protected string _fullnameen;
        protected long? _nationalityid;
        protected string _jobtitle;
        protected long? _idtype;
        protected string _civilidnumber;
        protected DateTime? _civilidexpirydate;
        protected string _passportnumber;
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
        protected bool? _isactive;

        protected decimal? _feeamount;
        protected bool? _isitfree;
        protected decimal? _discountamount;
        protected long? _discountedbymasteruserid;
        protected decimal? _payableamount;
       

        [DataMember]
        public long? requestemployeeid
        {
            get { return _requestemployeeid; }
            set { _requestemployeeid = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "requestapplicationid", ResourceType = typeof(CLL.LLClasses.Models._tran_applicationreqforempdetl))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._tran_applicationreqforempdetl), ErrorMessageResourceName = "requestapplicationidRequired")]
        public long? requestapplicationid
        {
            get { return _requestapplicationid; }
            set { _requestapplicationid = value; this.OnChnaged(); }
        }

        [DataMember]
        [MaxLength(256)]
        [Display(Name = "fullname", ResourceType = typeof(CLL.LLClasses.Models._tran_applicationreqforempdetl))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._tran_applicationreqforempdetl), ErrorMessageResourceName = "fullnameRequired")]
        public string fullname
        {
            get { return _fullname; }
            set { _fullname = value; this.OnChnaged(); }
        }

        [DataMember]
        [MaxLength(256)]
        [RegularExpression(@"^[^\u0627-\u0649]+$", ErrorMessageResourceType = typeof(CLL.LLClasses._Common), ErrorMessageResourceName = "Unicodecharactersarenotallowed")]
        [Display(Name = "fullnameen", ResourceType = typeof(CLL.LLClasses.Models._tran_applicationreqforempdetl))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._tran_applicationreqforempdetl), ErrorMessageResourceName = "fullnameenRequired")]
        public string fullnameen
        {
            get { return _fullnameen; }
            set { _fullnameen = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "nationalityid", ResourceType = typeof(CLL.LLClasses.Models._tran_applicationreqforempdetl))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._tran_applicationreqforempdetl), ErrorMessageResourceName = "nationalityidRequired")]
        public long? nationalityid
        {
            get { return _nationalityid; }
            set { _nationalityid = value; this.OnChnaged(); }
        }

        [DataMember]
        [MaxLength(256)]
        [Display(Name = "jobtitle", ResourceType = typeof(CLL.LLClasses.Models._tran_applicationreqforempdetl))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._tran_applicationreqforempdetl), ErrorMessageResourceName = "jobtitleRequired")]
        public string jobtitle
        {
            get { return _jobtitle; }
            set { _jobtitle = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "idtype", ResourceType = typeof(CLL.LLClasses.Models._tran_applicationreqforempdetl))]
        public long? idtype
        {
            get { return _idtype; }
            set { _idtype = value; this.OnChnaged(); }
        }

        [DataMember]
        [MaxLength(50)]
        [Display(Name = "civilidnumber", ResourceType = typeof(CLL.LLClasses.Models._tran_applicationreqforempdetl))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._tran_applicationreqforempdetl), ErrorMessageResourceName = "civilidnumberRequired")]
        public string civilidnumber
        {
            get { return _civilidnumber; }
            set { _civilidnumber = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "civilidexpirydate", ResourceType = typeof(CLL.LLClasses.Models._tran_applicationreqforempdetl))]
        public DateTime? civilidexpirydate
        {
            get { return _civilidexpirydate; }
            set { _civilidexpirydate = value; this.OnChnaged(); }
        }

        [DataMember]
        [MaxLength(50)]
        [Display(Name = "passportnumber", ResourceType = typeof(CLL.LLClasses.Models._tran_applicationreqforempdetl))]
        public string passportnumber
        {
            get { return _passportnumber; }
            set { _passportnumber = value; this.OnChnaged(); }
        }
        [DataMember]
        [Display(Name = "hasvehicle", ResourceType = typeof(CLL.LLClasses.Models._tran_applicationreqforempdetl))]
        public bool? hasvehicle
        {
            get { return _hasvehicle; }
            set { _hasvehicle = value; this.OnChnaged(); }
        }

        [DataMember]
        [MaxLength(150)]
        [Display(Name = "carnumberplate", ResourceType = typeof(CLL.LLClasses.Models._tran_applicationreqforempdetl))]
        //[Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._tran_applicationreqforempdetl), ErrorMessageResourceName = "carnumberplateRequired")]
        public string carnumberplate
        {
            get { return _carnumberplate; }
            set { _carnumberplate = value; this.OnChnaged(); }
        }


        [DataMember]
        [Display(Name = "vehiclecolorid", ResourceType = typeof(CLL.LLClasses.Models._tran_applicationreqforempdetl))]
        public long? vehiclecolorid
        {
            get { return _vehiclecolorid; }
            set { _vehiclecolorid = value; this.OnChnaged(); }
        }

        [DataMember]
        [MaxLength(250)]
        [Display(Name = "vehicleregistrationimagepath", ResourceType = typeof(CLL.LLClasses.Models._tran_applicationreqforvehicledetl))]
        public string vehicleregistrationimagepath
        {
            get { return _vehicleregistrationimagepath; }
            set { _vehicleregistrationimagepath = value; this.OnChnaged(); }
        }


        [DataMember]
        [MaxLength(250)]
        [Display(Name = "personalpicurepath", ResourceType = typeof(CLL.LLClasses.Models._tran_applicationreqforempdetl))]
        public string personalpicurepath
        {
            get { return _personalpicurepath; }
            set { _personalpicurepath = value; this.OnChnaged(); }
        }

        [DataMember]
        [MaxLength(250)]
        [Display(Name = "civilidimagepath", ResourceType = typeof(CLL.LLClasses.Models._tran_applicationreqforempdetl))]
        public string civilidimagepath
        {
            get { return _civilidimagepath; }
            set { _civilidimagepath = value; this.OnChnaged(); }
        }

        [DataMember]
        [MaxLength(250)]
        [Display(Name = "civilidbacksideimagepath", ResourceType = typeof(CLL.LLClasses.Models._tran_applicationreqforempdetl))]
        public string civilidbacksideimagepath
        {
            get { return _civilidbacksideimagepath; }
            set { _civilidbacksideimagepath = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "ispersonblocked", ResourceType = typeof(CLL.LLClasses.Models._tran_applicationreqforempdetl))]
        public bool? ispersonblocked
        {
            get { return _ispersonblocked; }
            set { _ispersonblocked = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "personblockstartdate", ResourceType = typeof(CLL.LLClasses.Models._tran_applicationreqforempdetl))]
        [DataType(DataType.Date), DisplayFormat(DataFormatString = @"{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? personblockstartdate
        {
            get { return _personblockstartdate; }
            set { _personblockstartdate = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "personblockenddate", ResourceType = typeof(CLL.LLClasses.Models._tran_applicationreqforempdetl))]
        [DataType(DataType.Date), DisplayFormat(DataFormatString = @"{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? personblockenddate
        {
            get { return _personblockenddate; }
            set { _personblockenddate = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "personblockedbyuserid", ResourceType = typeof(CLL.LLClasses.Models._tran_applicationreqforempdetl))]
        public long? personblockedbyuserid
        {
            get { return _personblockedbyuserid; }
            set { _personblockedbyuserid = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "personextentionenddate", ResourceType = typeof(CLL.LLClasses.Models._tran_applicationreqforempdetl))]
        [DataType(DataType.Date), DisplayFormat(DataFormatString = @"{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? personextentionenddate
        {
            get { return _personextentionenddate; }
            set { _personextentionenddate = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "personextendat", ResourceType = typeof(CLL.LLClasses.Models._tran_applicationreqforempdetl))]
        [DataType(DataType.Date), DisplayFormat(DataFormatString = @"{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? personextendat
        {
            get { return _personextendat; }
            set { _personextendat = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "personextendbyuserid", ResourceType = typeof(CLL.LLClasses.Models._tran_applicationreqforempdetl))]
        public long? personextendbyuserid
        {
            get { return _personextendbyuserid; }
            set { _personextendbyuserid = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "isactive", ResourceType = typeof(CLL.LLClasses.Models._tran_applicationreqforempdetl))]
        public bool? isactive
        {
            get { return _isactive; }
            set { _isactive = value; this.OnChnaged(); }
        }


        [DataMember]
        [Display(Name = "feeamount", ResourceType = typeof(CLL.LLClasses._Common))]
        public decimal? feeamount
        {
            get { return _feeamount; }
            set { _feeamount = value; this.OnChnaged(); }
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

        #endregion

        #region Constructor

        public tran_applicationreqforempdetlEntity() : base()
        {
            permittedgates = new List<tran_applicationreqforempgatemapEntity>();
        }

        public tran_applicationreqforempdetlEntity(IDataReader reader)
        {
            this.LoadFromReader(reader);
        }

        public tran_applicationreqforempdetlEntity(IDataReader reader, bool IsListViewShow)
        {
            this.LoadFromReader(reader, IsListViewShow);
        }



        protected void LoadFromReader(IDataReader reader)
        {
            if (reader != null && !reader.IsClosed)
            {
                this.BaseSecurityParam = new SecurityCapsule();
                if (!reader.IsDBNull(reader.GetOrdinal("RequestEmployeeID"))) _requestemployeeid = reader.GetInt64(reader.GetOrdinal("RequestEmployeeID"));
                if (!reader.IsDBNull(reader.GetOrdinal("RequestApplicationID"))) _requestapplicationid = reader.GetInt64(reader.GetOrdinal("RequestApplicationID"));
                if (!reader.IsDBNull(reader.GetOrdinal("FullName"))) _fullname = reader.GetString(reader.GetOrdinal("FullName"));
                if (!reader.IsDBNull(reader.GetOrdinal("FullNameEn"))) _fullnameen = reader.GetString(reader.GetOrdinal("FullNameEn"));
                if (!reader.IsDBNull(reader.GetOrdinal("NationalityId"))) _nationalityid = reader.GetInt64(reader.GetOrdinal("NationalityId"));
                if (!reader.IsDBNull(reader.GetOrdinal("JobTitle"))) _jobtitle = reader.GetString(reader.GetOrdinal("JobTitle"));
                if (!reader.IsDBNull(reader.GetOrdinal("IdType"))) _idtype = reader.GetInt64(reader.GetOrdinal("IdType"));
                if (!reader.IsDBNull(reader.GetOrdinal("CivilIdNumber"))) _civilidnumber = reader.GetString(reader.GetOrdinal("CivilIdNumber"));
                if (!reader.IsDBNull(reader.GetOrdinal("CivilIdExpiryDate"))) _civilidexpirydate = reader.GetDateTime(reader.GetOrdinal("CivilIdExpiryDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("PassportNumber"))) _passportnumber = reader.GetString(reader.GetOrdinal("PassportNumber"));
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
                if (!reader.IsDBNull(reader.GetOrdinal("FeeAmount"))) _feeamount = reader.GetDecimal(reader.GetOrdinal("FeeAmount"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsItFree"))) _isitfree = reader.GetBoolean(reader.GetOrdinal("IsItFree"));
                if (!reader.IsDBNull(reader.GetOrdinal("DiscountAmount"))) _discountamount = reader.GetDecimal(reader.GetOrdinal("DiscountAmount"));
                if (!reader.IsDBNull(reader.GetOrdinal("PayableAmount"))) _payableamount = reader.GetDecimal(reader.GetOrdinal("PayableAmount"));
                if (!reader.IsDBNull(reader.GetOrdinal("DiscountedByMasterUserId"))) _discountedbymasteruserid = reader.GetInt64(reader.GetOrdinal("DiscountedByMasterUserId"));
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
                if (!reader.IsDBNull(reader.GetOrdinal("RequestEmployeeID"))) _requestemployeeid = reader.GetInt64(reader.GetOrdinal("RequestEmployeeID"));
                if (!reader.IsDBNull(reader.GetOrdinal("RequestApplicationID"))) _requestapplicationid = reader.GetInt64(reader.GetOrdinal("RequestApplicationID"));
                if (!reader.IsDBNull(reader.GetOrdinal("FullName"))) _fullname = reader.GetString(reader.GetOrdinal("FullName"));
                if (!reader.IsDBNull(reader.GetOrdinal("FullNameEn"))) _fullnameen = reader.GetString(reader.GetOrdinal("FullNameEn"));
                if (!reader.IsDBNull(reader.GetOrdinal("NationalityId"))) _nationalityid = reader.GetInt64(reader.GetOrdinal("NationalityId"));
                if (!reader.IsDBNull(reader.GetOrdinal("JobTitle"))) _jobtitle = reader.GetString(reader.GetOrdinal("JobTitle"));
                if (!reader.IsDBNull(reader.GetOrdinal("IdType"))) _idtype = reader.GetInt64(reader.GetOrdinal("IdType"));
                if (!reader.IsDBNull(reader.GetOrdinal("CivilIdNumber"))) _civilidnumber = reader.GetString(reader.GetOrdinal("CivilIdNumber"));
                if (!reader.IsDBNull(reader.GetOrdinal("CivilIdExpiryDate"))) _civilidexpirydate = reader.GetDateTime(reader.GetOrdinal("CivilIdExpiryDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("PassportNumber"))) _passportnumber = reader.GetString(reader.GetOrdinal("PassportNumber"));
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
                if (!reader.IsDBNull(reader.GetOrdinal("FeeAmount"))) _feeamount = reader.GetDecimal(reader.GetOrdinal("FeeAmount"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsItFree"))) _isitfree = reader.GetBoolean(reader.GetOrdinal("IsItFree"));
                if (!reader.IsDBNull(reader.GetOrdinal("DiscountAmount"))) _discountamount = reader.GetDecimal(reader.GetOrdinal("DiscountAmount"));
                if (!reader.IsDBNull(reader.GetOrdinal("PayableAmount"))) _payableamount = reader.GetDecimal(reader.GetOrdinal("PayableAmount"));
                if (!reader.IsDBNull(reader.GetOrdinal("DiscountedByMasterUserId"))) _discountedbymasteruserid = reader.GetInt64(reader.GetOrdinal("DiscountedByMasterUserId"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsActive"))) _isactive = reader.GetBoolean(reader.GetOrdinal("IsActive"));
                if (!reader.IsDBNull(reader.GetOrdinal("TransID"))) this.BaseSecurityParam.transid = reader.GetString(reader.GetOrdinal("TransID"));
                if (!reader.IsDBNull(reader.GetOrdinal("CreatedByUserName"))) this.BaseSecurityParam.createdbyusername = reader.GetString(reader.GetOrdinal("CreatedByUserName"));
                if (!reader.IsDBNull(reader.GetOrdinal("CreatedDate"))) this.BaseSecurityParam.createddate = reader.GetDateTime(reader.GetOrdinal("CreatedDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("UpdatedByUserName"))) this.BaseSecurityParam.updatedbyusername = reader.GetString(reader.GetOrdinal("UpdatedByUserName"));
                if (!reader.IsDBNull(reader.GetOrdinal("UpdatedDate"))) this.BaseSecurityParam.updateddate = reader.GetDateTime(reader.GetOrdinal("UpdatedDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("IPAddress"))) this.BaseSecurityParam.ipaddress = reader.GetString(reader.GetOrdinal("IPAddress"));
                if (!reader.IsDBNull(reader.GetOrdinal("TS"))) this.BaseSecurityParam.ts = reader.GetInt64(reader.GetOrdinal("ts"));
                if (!reader.IsDBNull(reader.GetOrdinal("NationalityName"))) _nationalityname = reader.GetString(reader.GetOrdinal("NationalityName"));
                if (!reader.IsDBNull(reader.GetOrdinal("NationalityNameAr"))) _nationalitynamear = reader.GetString(reader.GetOrdinal("NationalityNameAr"));
                CurrentState = EntityState.Unchanged;
            }
        }

        #endregion

    }
}


