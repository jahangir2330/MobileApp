using System;
using System.Runtime.Serialization;
using System.Data;
using BDO.Core.Base;
using System.ComponentModel.DataAnnotations;


namespace BDO.Core.DataAccessObjects.Models
{
    public partial class tran_applicationreqforvehiclegatemapEntity
    {
        #region Properties

        protected string _gatename;
        protected string _gatenamear;
        protected string _gateshortname;
        protected string _gateshortnamear;
        protected string _gatenumber;

        [DataMember]
        [MaxLength(250)]
        [Display(Name = "gatename", ResourceType = typeof(CLL.LLClasses.Models._gen_gate))]
        public string gatename
        {
            get { return _gatename; }
            set { _gatename = value; this.OnChnaged(); }
        }

        [DataMember]
        [MaxLength(250)]
        [Display(Name = "gatenamear", ResourceType = typeof(CLL.LLClasses.Models._gen_gate))]
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



        #endregion

        #region Constructor

        public tran_applicationreqforvehiclegatemapEntity(IDataReader reader, bool IsListViewShow, bool withrealtionaltable)
        {
            this.LoadFromReader(reader, IsListViewShow, withrealtionaltable);
        }

        protected void LoadFromReader(IDataReader reader, bool IsListViewShow, bool withrealtionaltable)
        {
            if (reader != null && !reader.IsClosed)
            {
                this.BaseSecurityParam = new SecurityCapsule();
                if (!reader.IsDBNull(reader.GetOrdinal("RequestVehicleGateInfoID"))) _requestvehiclegateinfoid = reader.GetInt64(reader.GetOrdinal("RequestVehicleGateInfoID"));
                if (!reader.IsDBNull(reader.GetOrdinal("RequestVehicleID"))) _requestvehicleid = reader.GetInt64(reader.GetOrdinal("RequestVehicleID"));
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

                if (!reader.IsDBNull(reader.GetOrdinal("GateName"))) _gatename = reader.GetString(reader.GetOrdinal("GateName"));
                if (!reader.IsDBNull(reader.GetOrdinal("GateNameAR"))) _gatenamear = reader.GetString(reader.GetOrdinal("GateNameAR"));
                if (!reader.IsDBNull(reader.GetOrdinal("GateShortName"))) _gateshortname = reader.GetString(reader.GetOrdinal("GateShortName"));
                if (!reader.IsDBNull(reader.GetOrdinal("GateShortNameAR"))) _gateshortnamear = reader.GetString(reader.GetOrdinal("GateShortNameAR"));
                if (!reader.IsDBNull(reader.GetOrdinal("GateNumber"))) _gatenumber = reader.GetString(reader.GetOrdinal("GateNumber"));

                CurrentState = EntityState.Unchanged;
            }
        }

        #endregion



    }
}
