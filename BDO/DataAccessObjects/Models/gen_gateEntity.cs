using System;
using System.Runtime.Serialization;
using System.Data;
using BDO.Core.Base;
using System.ComponentModel.DataAnnotations;


namespace BDO.Core.DataAccessObjects.Models
{
    [Serializable]
    [DataContract(Name = "gen_gateEntity", Namespace = "http://www.KAF.com/types")]
    public partial class gen_gateEntity : BaseEntity
    {
        #region Properties

        protected long? _gateid;
        protected string _gatename;
        protected string _gatenamear;
        protected string _gateshortname;
        protected string _gateshortnamear;
        protected string _gatenumber;
        protected string _cantonmentname;
        protected string _cantonmentnamear;
        protected string _gateinchargename;
        protected int? _sortpriority;
        protected bool? _isactive;
        protected string _remarks;
        protected string _updateinfo;
        protected long? _tranformactionid;


        [DataMember]
        public long? gateid
        {
            get { return _gateid; }
            set { _gateid = value; this.OnChnaged(); }
        }

        [DataMember]
        [MaxLength(250)]
        [RegularExpression(@"^[^\u0627-\u0649]+$", ErrorMessageResourceType = typeof(CLL.LLClasses._Common), ErrorMessageResourceName = "Unicodecharactersarenotallowed")]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._gen_gate), ErrorMessageResourceName = "gatenameRequired")]
        [Display(Name = "gatename", ResourceType = typeof(CLL.LLClasses.Models._gen_gate))]
        public string gatename
        {
            get { return _gatename; }
            set { _gatename = value; this.OnChnaged(); }
        }

        [DataMember]
        [MaxLength(250)]
        [Display(Name = "gatenamear", ResourceType = typeof(CLL.LLClasses.Models._gen_gate))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._gen_gate), ErrorMessageResourceName = "gatenamearRequired")]
        public string gatenamear
        {
            get { return _gatenamear; }
            set { _gatenamear = value; this.OnChnaged(); }
        }

        [DataMember]
        [MaxLength(150)]
        [Display(Name = "gateshortname", ResourceType = typeof(CLL.LLClasses.Models._gen_gate))]
        public string gateshortname
        {
            get { return _gateshortname; }
            set { _gateshortname = value; this.OnChnaged(); }
        }

        [DataMember]
        [MaxLength(150)]
        [Display(Name = "gateshortnamear", ResourceType = typeof(CLL.LLClasses.Models._gen_gate))]
        public string gateshortnamear
        {
            get { return _gateshortnamear; }
            set { _gateshortnamear = value; this.OnChnaged(); }
        }

        [DataMember]
        [MaxLength(150)]
        [Display(Name = "gatenumber", ResourceType = typeof(CLL.LLClasses.Models._gen_gate))]
        public string gatenumber
        {
            get { return _gatenumber; }
            set { _gatenumber = value; this.OnChnaged(); }
        }

        [DataMember]
        [MaxLength(150)]
        [Display(Name = "cantonmentname", ResourceType = typeof(CLL.LLClasses.Models._gen_gate))]
        public string cantonmentname
        {
            get { return _cantonmentname; }
            set { _cantonmentname = value; this.OnChnaged(); }
        }

        [DataMember]
        [MaxLength(150)]
        [Display(Name = "cantonmentnamear", ResourceType = typeof(CLL.LLClasses.Models._gen_gate))]
        public string cantonmentnamear
        {
            get { return _cantonmentnamear; }
            set { _cantonmentnamear = value; this.OnChnaged(); }
        }

        [DataMember]
        [MaxLength(150)]
        [Display(Name = "gateinchargename", ResourceType = typeof(CLL.LLClasses.Models._gen_gate))]
        public string gateinchargename
        {
            get { return _gateinchargename; }
            set { _gateinchargename = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "sortpriority", ResourceType = typeof(CLL.LLClasses.Models._gen_gate))]
        public int? sortpriority
        {
            get { return _sortpriority; }
            set { _sortpriority = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "isactive", ResourceType = typeof(CLL.LLClasses.Models._gen_gate))]
        public bool? isactive
        {
            get { return _isactive; }
            set { _isactive = value; this.OnChnaged(); }
        }

        [DataMember]
        [MaxLength(550)]
        [Display(Name = "remarks", ResourceType = typeof(CLL.LLClasses.Models._gen_gate))]
        public string remarks
        {
            get { return _remarks; }
            set { _remarks = value; this.OnChnaged(); }
        }

        [DataMember]
        [MaxLength(550)]
        [Display(Name = "updateinfo", ResourceType = typeof(CLL.LLClasses.Models._gen_gate))]
        public string updateinfo
        {
            get { return _updateinfo; }
            set { _updateinfo = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "tranformactionid", ResourceType = typeof(CLL.LLClasses.Models._gen_gate))]
        public long? tranformactionid
        {
            get { return _tranformactionid; }
            set { _tranformactionid = value; this.OnChnaged(); }
        }


        #endregion

        #region Constructor

        public gen_gateEntity() : base()
        {
        }

        public gen_gateEntity(IDataReader reader)
        {
            this.LoadFromReader(reader);
        }

        public gen_gateEntity(IDataReader reader, bool IsListViewShow)
        {
            this.LoadFromReader(reader, IsListViewShow);
        }



        protected void LoadFromReader(IDataReader reader)
        {
            if (reader != null && !reader.IsClosed)
            {
                this.BaseSecurityParam = new SecurityCapsule();
                if (!reader.IsDBNull(reader.GetOrdinal("GateID"))) _gateid = reader.GetInt64(reader.GetOrdinal("GateID"));
                if (!reader.IsDBNull(reader.GetOrdinal("GateName"))) _gatename = reader.GetString(reader.GetOrdinal("GateName"));
                if (!reader.IsDBNull(reader.GetOrdinal("GateNameAR"))) _gatenamear = reader.GetString(reader.GetOrdinal("GateNameAR"));
                if (!reader.IsDBNull(reader.GetOrdinal("GateShortName"))) _gateshortname = reader.GetString(reader.GetOrdinal("GateShortName"));
                if (!reader.IsDBNull(reader.GetOrdinal("GateShortNameAR"))) _gateshortnamear = reader.GetString(reader.GetOrdinal("GateShortNameAR"));
                if (!reader.IsDBNull(reader.GetOrdinal("GateNumber"))) _gatenumber = reader.GetString(reader.GetOrdinal("GateNumber"));
                if (!reader.IsDBNull(reader.GetOrdinal("CantonmentName"))) _cantonmentname = reader.GetString(reader.GetOrdinal("CantonmentName"));
                if (!reader.IsDBNull(reader.GetOrdinal("CantonmentNameAR"))) _cantonmentnamear = reader.GetString(reader.GetOrdinal("CantonmentNameAR"));
                if (!reader.IsDBNull(reader.GetOrdinal("GateInchargeName"))) _gateinchargename = reader.GetString(reader.GetOrdinal("GateInchargeName"));
                if (!reader.IsDBNull(reader.GetOrdinal("SortPriority"))) _sortpriority = reader.GetInt32(reader.GetOrdinal("SortPriority"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsActive"))) _isactive = reader.GetBoolean(reader.GetOrdinal("IsActive"));
                if (!reader.IsDBNull(reader.GetOrdinal("Remarks"))) _remarks = reader.GetString(reader.GetOrdinal("Remarks"));
                if (!reader.IsDBNull(reader.GetOrdinal("TransID"))) this.BaseSecurityParam.transid = reader.GetString(reader.GetOrdinal("TransID"));
                if (!reader.IsDBNull(reader.GetOrdinal("CreatedByUserName"))) this.BaseSecurityParam.createdbyusername = reader.GetString(reader.GetOrdinal("CreatedByUserName"));
                if (!reader.IsDBNull(reader.GetOrdinal("CreatedDate"))) this.BaseSecurityParam.createddate = reader.GetDateTime(reader.GetOrdinal("CreatedDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("UpdatedByUserName"))) this.BaseSecurityParam.updatedbyusername = reader.GetString(reader.GetOrdinal("UpdatedByUserName"));
                if (!reader.IsDBNull(reader.GetOrdinal("UpdatedDate"))) this.BaseSecurityParam.updateddate = reader.GetDateTime(reader.GetOrdinal("UpdatedDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("UpdateInfo"))) _updateinfo = reader.GetString(reader.GetOrdinal("UpdateInfo"));
                if (!reader.IsDBNull(reader.GetOrdinal("TranFormActionID"))) _tranformactionid = reader.GetInt64(reader.GetOrdinal("TranFormActionID"));
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
                if (!reader.IsDBNull(reader.GetOrdinal("GateID"))) _gateid = reader.GetInt64(reader.GetOrdinal("GateID"));
                if (!reader.IsDBNull(reader.GetOrdinal("GateName"))) _gatename = reader.GetString(reader.GetOrdinal("GateName"));
                if (!reader.IsDBNull(reader.GetOrdinal("GateNameAR"))) _gatenamear = reader.GetString(reader.GetOrdinal("GateNameAR"));
                if (!reader.IsDBNull(reader.GetOrdinal("GateShortName"))) _gateshortname = reader.GetString(reader.GetOrdinal("GateShortName"));
                if (!reader.IsDBNull(reader.GetOrdinal("GateShortNameAR"))) _gateshortnamear = reader.GetString(reader.GetOrdinal("GateShortNameAR"));
                if (!reader.IsDBNull(reader.GetOrdinal("GateNumber"))) _gatenumber = reader.GetString(reader.GetOrdinal("GateNumber"));
                if (!reader.IsDBNull(reader.GetOrdinal("CantonmentName"))) _cantonmentname = reader.GetString(reader.GetOrdinal("CantonmentName"));
                if (!reader.IsDBNull(reader.GetOrdinal("CantonmentNameAR"))) _cantonmentnamear = reader.GetString(reader.GetOrdinal("CantonmentNameAR"));
                if (!reader.IsDBNull(reader.GetOrdinal("GateInchargeName"))) _gateinchargename = reader.GetString(reader.GetOrdinal("GateInchargeName"));
                if (!reader.IsDBNull(reader.GetOrdinal("SortPriority"))) _sortpriority = reader.GetInt32(reader.GetOrdinal("SortPriority"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsActive"))) _isactive = reader.GetBoolean(reader.GetOrdinal("IsActive"));
                if (!reader.IsDBNull(reader.GetOrdinal("Remarks"))) _remarks = reader.GetString(reader.GetOrdinal("Remarks"));
                if (!reader.IsDBNull(reader.GetOrdinal("TransID"))) this.BaseSecurityParam.transid = reader.GetString(reader.GetOrdinal("TransID"));
                if (!reader.IsDBNull(reader.GetOrdinal("CreatedByUserName"))) this.BaseSecurityParam.createdbyusername = reader.GetString(reader.GetOrdinal("CreatedByUserName"));
                if (!reader.IsDBNull(reader.GetOrdinal("CreatedDate"))) this.BaseSecurityParam.createddate = reader.GetDateTime(reader.GetOrdinal("CreatedDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("UpdatedByUserName"))) this.BaseSecurityParam.updatedbyusername = reader.GetString(reader.GetOrdinal("UpdatedByUserName"));
                if (!reader.IsDBNull(reader.GetOrdinal("UpdatedDate"))) this.BaseSecurityParam.updateddate = reader.GetDateTime(reader.GetOrdinal("UpdatedDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("UpdateInfo"))) _updateinfo = reader.GetString(reader.GetOrdinal("UpdateInfo"));
                if (!reader.IsDBNull(reader.GetOrdinal("TranFormActionID"))) _tranformactionid = reader.GetInt64(reader.GetOrdinal("TranFormActionID"));
                if (!reader.IsDBNull(reader.GetOrdinal("IPAddress"))) this.BaseSecurityParam.ipaddress = reader.GetString(reader.GetOrdinal("IPAddress"));
                if (!reader.IsDBNull(reader.GetOrdinal("TS"))) this.BaseSecurityParam.ts = reader.GetInt64(reader.GetOrdinal("ts"));
                CurrentState = EntityState.Unchanged;
            }
        }

        #endregion



    }
}
