using System;
using System.Runtime.Serialization;
using System.Data;
using BDO.Core.Base;
using System.ComponentModel.DataAnnotations;


namespace BDO.Core.DataAccessObjects.Models
{
    [Serializable]
    [DataContract(Name = "tran_applicationreqforvehicledetlEntity", Namespace = "http://www.KAF.com/types")]
    public partial class tran_applicationreqforvehicledetlEntity : BaseEntity
    {
        #region Properties
    
        protected long ? _vehicleinfoid;
        protected long ? _requestvehicleid;
        protected string _carnumberplate;
        protected long ? _vehiclecategoryid;
        protected long ? _vehiclebrandid;
        protected long ? _vehiclemodelid;
        protected long ? _vehiclecolorid;
        protected string _vehicleregistrationnumber;
        protected string _vehicleregistrationimagepath;
        protected bool ? _isvehicleblocked;
        protected DateTime ? _vehicleblockstartdate;
        protected DateTime ? _vehicleblockenddate;
        protected long ? _vehicleblockedbyuserid;
        protected DateTime ? _vehicleextentionenddate;
        protected DateTime ? _vehicleextendat;
        protected long ? _vehicleextendbyuserid;
        protected bool ? _isactive;

        protected decimal? _feeamount;
        protected bool? _isitfree;
        protected decimal? _discountamount;
        protected long? _discountedbymasteruserid;
        protected decimal? _payableamount;

        [DataMember]
        public long ? vehicleinfoid
        {
            get { return _vehicleinfoid; }
            set { _vehicleinfoid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "requestvehicleid", ResourceType = typeof(CLL.LLClasses.Models._tran_applicationreqforvehicledetl))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._tran_applicationreqforvehicledetl), ErrorMessageResourceName = "requestvehicleidRequired")]
        public long ? requestvehicleid
        {
            get { return _requestvehicleid; }
            set { _requestvehicleid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(150)]
        [Display(Name = "carnumberplate", ResourceType = typeof(CLL.LLClasses.Models._tran_applicationreqforvehicledetl))]
        public string carnumberplate
        {
            get { return _carnumberplate; }
            set { _carnumberplate = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "vehiclecategoryid", ResourceType = typeof(CLL.LLClasses.Models._tran_applicationreqforvehicledetl))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._tran_applicationreqforvehicledetl), ErrorMessageResourceName = "vehiclecategoryidRequired")]
        public long ? vehiclecategoryid
        {
            get { return _vehiclecategoryid; }
            set { _vehiclecategoryid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "vehiclebrandid", ResourceType = typeof(CLL.LLClasses.Models._tran_applicationreqforvehicledetl))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._tran_applicationreqforvehicledetl), ErrorMessageResourceName = "vehiclebrandidRequired")]
        public long ? vehiclebrandid
        {
            get { return _vehiclebrandid; }
            set { _vehiclebrandid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "vehiclemodelid", ResourceType = typeof(CLL.LLClasses.Models._tran_applicationreqforvehicledetl))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._tran_applicationreqforvehicledetl), ErrorMessageResourceName = "vehiclemodelidRequired")]
        public long ? vehiclemodelid
        {
            get { return _vehiclemodelid; }
            set { _vehiclemodelid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "vehiclecolorid", ResourceType = typeof(CLL.LLClasses.Models._tran_applicationreqforvehicledetl))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._tran_applicationreqforvehicledetl), ErrorMessageResourceName = "vehiclecoloridRequired")]
        public long ? vehiclecolorid
        {
            get { return _vehiclecolorid; }
            set { _vehiclecolorid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(50)]
        [Display(Name = "vehicleregistrationnumber", ResourceType = typeof(CLL.LLClasses.Models._tran_applicationreqforvehicledetl))]
        public string vehicleregistrationnumber
        {
            get { return _vehicleregistrationnumber; }
            set { _vehicleregistrationnumber = value; this.OnChnaged(); }
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
        [Display(Name = "isvehicleblocked", ResourceType = typeof(CLL.LLClasses.Models._tran_applicationreqforvehicledetl))]
        public bool ? isvehicleblocked
        {
            get { return _isvehicleblocked; }
            set { _isvehicleblocked = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "vehicleblockstartdate", ResourceType = typeof(CLL.LLClasses.Models._tran_applicationreqforvehicledetl))]
        public DateTime ? vehicleblockstartdate
        {
            get { return _vehicleblockstartdate; }
            set { _vehicleblockstartdate = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "vehicleblockenddate", ResourceType = typeof(CLL.LLClasses.Models._tran_applicationreqforvehicledetl))]
        public DateTime ? vehicleblockenddate
        {
            get { return _vehicleblockenddate; }
            set { _vehicleblockenddate = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "vehicleblockedbyuserid", ResourceType = typeof(CLL.LLClasses.Models._tran_applicationreqforvehicledetl))]
        public long ? vehicleblockedbyuserid
        {
            get { return _vehicleblockedbyuserid; }
            set { _vehicleblockedbyuserid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "vehicleextentionenddate", ResourceType = typeof(CLL.LLClasses.Models._tran_applicationreqforvehicledetl))]
        public DateTime ? vehicleextentionenddate
        {
            get { return _vehicleextentionenddate; }
            set { _vehicleextentionenddate = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "vehicleextendat", ResourceType = typeof(CLL.LLClasses.Models._tran_applicationreqforvehicledetl))]
        public DateTime ? vehicleextendat
        {
            get { return _vehicleextendat; }
            set { _vehicleextendat = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "vehicleextendbyuserid", ResourceType = typeof(CLL.LLClasses.Models._tran_applicationreqforvehicledetl))]
        public long ? vehicleextendbyuserid
        {
            get { return _vehicleextendbyuserid; }
            set { _vehicleextendbyuserid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "isactive", ResourceType = typeof(CLL.LLClasses.Models._tran_applicationreqforvehicledetl))]
        public bool ? isactive
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

        public tran_applicationreqforvehicledetlEntity():base()
        {
        }
        
        public tran_applicationreqforvehicledetlEntity(IDataReader reader)
        {
            this.LoadFromReader(reader);
        }
        
         public tran_applicationreqforvehicledetlEntity(IDataReader reader, bool IsListViewShow)
        {
            this.LoadFromReader(reader, IsListViewShow);
        }
        
      
        
        protected void LoadFromReader(IDataReader reader)
        {
            if (reader != null && !reader.IsClosed)
            {
                this.BaseSecurityParam = new SecurityCapsule();
                if (!reader.IsDBNull(reader.GetOrdinal("VehicleInfoID"))) _vehicleinfoid = reader.GetInt64(reader.GetOrdinal("VehicleInfoID"));
                if (!reader.IsDBNull(reader.GetOrdinal("RequestVehicleID"))) _requestvehicleid = reader.GetInt64(reader.GetOrdinal("RequestVehicleID"));
                if (!reader.IsDBNull(reader.GetOrdinal("CarNumberPlate"))) _carnumberplate = reader.GetString(reader.GetOrdinal("CarNumberPlate"));
                if (!reader.IsDBNull(reader.GetOrdinal("VehicleCategoryId"))) _vehiclecategoryid = reader.GetInt64(reader.GetOrdinal("VehicleCategoryId"));
                if (!reader.IsDBNull(reader.GetOrdinal("VehicleBrandId"))) _vehiclebrandid = reader.GetInt64(reader.GetOrdinal("VehicleBrandId"));
                if (!reader.IsDBNull(reader.GetOrdinal("VehicleModelId"))) _vehiclemodelid = reader.GetInt64(reader.GetOrdinal("VehicleModelId"));
                if (!reader.IsDBNull(reader.GetOrdinal("VehicleColorId"))) _vehiclecolorid = reader.GetInt64(reader.GetOrdinal("VehicleColorId"));
                if (!reader.IsDBNull(reader.GetOrdinal("VehicleRegistrationNumber"))) _vehicleregistrationnumber = reader.GetString(reader.GetOrdinal("VehicleRegistrationNumber"));
                if (!reader.IsDBNull(reader.GetOrdinal("VehicleRegistrationImagePath"))) _vehicleregistrationimagepath = reader.GetString(reader.GetOrdinal("VehicleRegistrationImagePath"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsVehicleBlocked"))) _isvehicleblocked = reader.GetBoolean(reader.GetOrdinal("IsVehicleBlocked"));
                if (!reader.IsDBNull(reader.GetOrdinal("VehicleBlockStartDate"))) _vehicleblockstartdate = reader.GetDateTime(reader.GetOrdinal("VehicleBlockStartDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("VehicleBlockEndDate"))) _vehicleblockenddate = reader.GetDateTime(reader.GetOrdinal("VehicleBlockEndDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("VehicleBlockedByUserId"))) _vehicleblockedbyuserid = reader.GetInt64(reader.GetOrdinal("VehicleBlockedByUserId"));
                if (!reader.IsDBNull(reader.GetOrdinal("VehicleExtentionEndDate"))) _vehicleextentionenddate = reader.GetDateTime(reader.GetOrdinal("VehicleExtentionEndDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("VehicleExtendAt"))) _vehicleextendat = reader.GetDateTime(reader.GetOrdinal("VehicleExtendAt"));
                if (!reader.IsDBNull(reader.GetOrdinal("VehicleExtendByUserId"))) _vehicleextendbyuserid = reader.GetInt64(reader.GetOrdinal("VehicleExtendByUserId"));
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
                if (!reader.IsDBNull(reader.GetOrdinal("VehicleInfoID"))) _vehicleinfoid = reader.GetInt64(reader.GetOrdinal("VehicleInfoID"));
                if (!reader.IsDBNull(reader.GetOrdinal("RequestVehicleID"))) _requestvehicleid = reader.GetInt64(reader.GetOrdinal("RequestVehicleID"));
                if (!reader.IsDBNull(reader.GetOrdinal("CarNumberPlate"))) _carnumberplate = reader.GetString(reader.GetOrdinal("CarNumberPlate"));
                if (!reader.IsDBNull(reader.GetOrdinal("VehicleCategoryId"))) _vehiclecategoryid = reader.GetInt64(reader.GetOrdinal("VehicleCategoryId"));
                if (!reader.IsDBNull(reader.GetOrdinal("VehicleBrandId"))) _vehiclebrandid = reader.GetInt64(reader.GetOrdinal("VehicleBrandId"));
                if (!reader.IsDBNull(reader.GetOrdinal("VehicleModelId"))) _vehiclemodelid = reader.GetInt64(reader.GetOrdinal("VehicleModelId"));
                if (!reader.IsDBNull(reader.GetOrdinal("VehicleColorId"))) _vehiclecolorid = reader.GetInt64(reader.GetOrdinal("VehicleColorId"));
                if (!reader.IsDBNull(reader.GetOrdinal("VehicleRegistrationNumber"))) _vehicleregistrationnumber = reader.GetString(reader.GetOrdinal("VehicleRegistrationNumber"));
                if (!reader.IsDBNull(reader.GetOrdinal("VehicleRegistrationImagePath"))) _vehicleregistrationimagepath = reader.GetString(reader.GetOrdinal("VehicleRegistrationImagePath"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsVehicleBlocked"))) _isvehicleblocked = reader.GetBoolean(reader.GetOrdinal("IsVehicleBlocked"));
                if (!reader.IsDBNull(reader.GetOrdinal("VehicleBlockStartDate"))) _vehicleblockstartdate = reader.GetDateTime(reader.GetOrdinal("VehicleBlockStartDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("VehicleBlockEndDate"))) _vehicleblockenddate = reader.GetDateTime(reader.GetOrdinal("VehicleBlockEndDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("VehicleBlockedByUserId"))) _vehicleblockedbyuserid = reader.GetInt64(reader.GetOrdinal("VehicleBlockedByUserId"));
                if (!reader.IsDBNull(reader.GetOrdinal("VehicleExtentionEndDate"))) _vehicleextentionenddate = reader.GetDateTime(reader.GetOrdinal("VehicleExtentionEndDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("VehicleExtendAt"))) _vehicleextendat = reader.GetDateTime(reader.GetOrdinal("VehicleExtendAt"));
                if (!reader.IsDBNull(reader.GetOrdinal("VehicleExtendByUserId"))) _vehicleextendbyuserid = reader.GetInt64(reader.GetOrdinal("VehicleExtendByUserId"));
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
        
        #endregion
        
        
            
    }
}
