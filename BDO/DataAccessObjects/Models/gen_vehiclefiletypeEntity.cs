using System;
using System.Runtime.Serialization;
using System.Data;
using BDO.Core.Base;
using System.ComponentModel.DataAnnotations;


namespace BDO.Core.DataAccessObjects.Models
{
    [Serializable]
    [DataContract(Name = "gen_vehiclefiletypeEntity", Namespace = "http://www.KAF.com/types")]
    public partial class gen_vehiclefiletypeEntity : BaseEntity
    {
        #region Properties
    
        protected long ? _vehiclefiletypeid;
        protected string _vehiclefiletypename;
        protected string _vehiclefiletypenamear;
        protected string _expectedfiletypes;
        protected string _errormessageforrequired;
        protected string _errormessageforrequiredar;
        protected int ? _sortpriority;
        protected string _remarks;
        protected long ? _tranformactionid;
        protected string _updateinfo;
        protected bool ? _isactive;
                
        
        [DataMember]
        public long ? vehiclefiletypeid
        {
            get { return _vehiclefiletypeid; }
            set { _vehiclefiletypeid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(150)]
        [Display(Name = "vehiclefiletypename", ResourceType = typeof(CLL.LLClasses.Models._gen_vehiclefiletype))]
        public string vehiclefiletypename
        {
            get { return _vehiclefiletypename; }
            set { _vehiclefiletypename = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(150)]
        [Display(Name = "vehiclefiletypenamear", ResourceType = typeof(CLL.LLClasses.Models._gen_vehiclefiletype))]
        public string vehiclefiletypenamear
        {
            get { return _vehiclefiletypenamear; }
            set { _vehiclefiletypenamear = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(50)]
        [Display(Name = "expectedfiletypes", ResourceType = typeof(CLL.LLClasses.Models._gen_vehiclefiletype))]
        public string expectedfiletypes
        {
            get { return _expectedfiletypes; }
            set { _expectedfiletypes = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(250)]
        [Display(Name = "errormessageforrequired", ResourceType = typeof(CLL.LLClasses.Models._gen_vehiclefiletype))]
        public string errormessageforrequired
        {
            get { return _errormessageforrequired; }
            set { _errormessageforrequired = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(250)]
        [Display(Name = "errormessageforrequiredar", ResourceType = typeof(CLL.LLClasses.Models._gen_vehiclefiletype))]
        public string errormessageforrequiredar
        {
            get { return _errormessageforrequiredar; }
            set { _errormessageforrequiredar = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "sortpriority", ResourceType = typeof(CLL.LLClasses.Models._gen_vehiclefiletype))]
        public int ? sortpriority
        {
            get { return _sortpriority; }
            set { _sortpriority = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(550)]
        [Display(Name = "remarks", ResourceType = typeof(CLL.LLClasses.Models._gen_vehiclefiletype))]
        public string remarks
        {
            get { return _remarks; }
            set { _remarks = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "tranformactionid", ResourceType = typeof(CLL.LLClasses.Models._gen_vehiclefiletype))]
        public long ? tranformactionid
        {
            get { return _tranformactionid; }
            set { _tranformactionid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(550)]
        [Display(Name = "updateinfo", ResourceType = typeof(CLL.LLClasses.Models._gen_vehiclefiletype))]
        public string updateinfo
        {
            get { return _updateinfo; }
            set { _updateinfo = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "isactive", ResourceType = typeof(CLL.LLClasses.Models._gen_vehiclefiletype))]
        public bool ? isactive
        {
            get { return _isactive; }
            set { _isactive = value; this.OnChnaged(); }
        }
        
        
        #endregion
    
        #region Constructor
    
        public gen_vehiclefiletypeEntity():base()
        {
        }
        
        public gen_vehiclefiletypeEntity(IDataReader reader)
        {
            this.LoadFromReader(reader);
        }
        
         public gen_vehiclefiletypeEntity(IDataReader reader, bool IsListViewShow)
        {
            this.LoadFromReader(reader, IsListViewShow);
        }
        
      
        
        protected void LoadFromReader(IDataReader reader)
        {
            if (reader != null && !reader.IsClosed)
            {
                this.BaseSecurityParam = new SecurityCapsule();
                if (!reader.IsDBNull(reader.GetOrdinal("VehicleFileTypeID"))) _vehiclefiletypeid = reader.GetInt64(reader.GetOrdinal("VehicleFileTypeID"));
                if (!reader.IsDBNull(reader.GetOrdinal("VehicleFileTypeName"))) _vehiclefiletypename = reader.GetString(reader.GetOrdinal("VehicleFileTypeName"));
                if (!reader.IsDBNull(reader.GetOrdinal("VehicleFileTypeNameAR"))) _vehiclefiletypenamear = reader.GetString(reader.GetOrdinal("VehicleFileTypeNameAR"));
                if (!reader.IsDBNull(reader.GetOrdinal("ExpectedFileTypes"))) _expectedfiletypes = reader.GetString(reader.GetOrdinal("ExpectedFileTypes"));
                if (!reader.IsDBNull(reader.GetOrdinal("ErrorMessageForRequired"))) _errormessageforrequired = reader.GetString(reader.GetOrdinal("ErrorMessageForRequired"));
                if (!reader.IsDBNull(reader.GetOrdinal("ErrorMessageForRequiredAR"))) _errormessageforrequiredar = reader.GetString(reader.GetOrdinal("ErrorMessageForRequiredAR"));
                if (!reader.IsDBNull(reader.GetOrdinal("SortPriority"))) _sortpriority = reader.GetInt32(reader.GetOrdinal("SortPriority"));
                if (!reader.IsDBNull(reader.GetOrdinal("Remarks"))) _remarks = reader.GetString(reader.GetOrdinal("Remarks"));
                if (!reader.IsDBNull(reader.GetOrdinal("TranFormActionID"))) _tranformactionid = reader.GetInt64(reader.GetOrdinal("TranFormActionID"));
                if (!reader.IsDBNull(reader.GetOrdinal("TransID"))) this.BaseSecurityParam.transid = reader.GetString(reader.GetOrdinal("TransID"));
                if (!reader.IsDBNull(reader.GetOrdinal("CreatedByUserName"))) this.BaseSecurityParam.createdbyusername = reader.GetString(reader.GetOrdinal("CreatedByUserName"));
                if (!reader.IsDBNull(reader.GetOrdinal("CreatedDate"))) this.BaseSecurityParam.createddate = reader.GetDateTime(reader.GetOrdinal("CreatedDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("UpdatedByUserName"))) this.BaseSecurityParam.updatedbyusername = reader.GetString(reader.GetOrdinal("UpdatedByUserName"));
                if (!reader.IsDBNull(reader.GetOrdinal("UpdatedDate"))) this.BaseSecurityParam.updateddate = reader.GetDateTime(reader.GetOrdinal("UpdatedDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("UpdateInfo"))) _updateinfo = reader.GetString(reader.GetOrdinal("UpdateInfo"));
                if (!reader.IsDBNull(reader.GetOrdinal("IPAddress"))) this.BaseSecurityParam.ipaddress = reader.GetString(reader.GetOrdinal("IPAddress"));
                if (!reader.IsDBNull(reader.GetOrdinal("TS"))) this.BaseSecurityParam.ts = reader.GetInt64(reader.GetOrdinal("ts"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsActive"))) _isactive = reader.GetBoolean(reader.GetOrdinal("IsActive"));
                CurrentState = EntityState.Unchanged;
            }
        }


        protected void LoadFromReader(IDataReader reader, bool IsListViewShow)
        {
            if (reader != null && !reader.IsClosed)
            {
                this.BaseSecurityParam = new SecurityCapsule();
                if (!reader.IsDBNull(reader.GetOrdinal("VehicleFileTypeID"))) _vehiclefiletypeid = reader.GetInt64(reader.GetOrdinal("VehicleFileTypeID"));
                if (!reader.IsDBNull(reader.GetOrdinal("VehicleFileTypeName"))) _vehiclefiletypename = reader.GetString(reader.GetOrdinal("VehicleFileTypeName"));
                if (!reader.IsDBNull(reader.GetOrdinal("VehicleFileTypeNameAR"))) _vehiclefiletypenamear = reader.GetString(reader.GetOrdinal("VehicleFileTypeNameAR"));
                if (!reader.IsDBNull(reader.GetOrdinal("ExpectedFileTypes"))) _expectedfiletypes = reader.GetString(reader.GetOrdinal("ExpectedFileTypes"));
                if (!reader.IsDBNull(reader.GetOrdinal("ErrorMessageForRequired"))) _errormessageforrequired = reader.GetString(reader.GetOrdinal("ErrorMessageForRequired"));
                if (!reader.IsDBNull(reader.GetOrdinal("ErrorMessageForRequiredAR"))) _errormessageforrequiredar = reader.GetString(reader.GetOrdinal("ErrorMessageForRequiredAR"));
                if (!reader.IsDBNull(reader.GetOrdinal("SortPriority"))) _sortpriority = reader.GetInt32(reader.GetOrdinal("SortPriority"));
                if (!reader.IsDBNull(reader.GetOrdinal("Remarks"))) _remarks = reader.GetString(reader.GetOrdinal("Remarks"));
                if (!reader.IsDBNull(reader.GetOrdinal("TranFormActionID"))) _tranformactionid = reader.GetInt64(reader.GetOrdinal("TranFormActionID"));
                if (!reader.IsDBNull(reader.GetOrdinal("TransID"))) this.BaseSecurityParam.transid = reader.GetString(reader.GetOrdinal("TransID"));
                if (!reader.IsDBNull(reader.GetOrdinal("CreatedByUserName"))) this.BaseSecurityParam.createdbyusername = reader.GetString(reader.GetOrdinal("CreatedByUserName"));
                if (!reader.IsDBNull(reader.GetOrdinal("CreatedDate"))) this.BaseSecurityParam.createddate = reader.GetDateTime(reader.GetOrdinal("CreatedDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("UpdatedByUserName"))) this.BaseSecurityParam.updatedbyusername = reader.GetString(reader.GetOrdinal("UpdatedByUserName"));
                if (!reader.IsDBNull(reader.GetOrdinal("UpdatedDate"))) this.BaseSecurityParam.updateddate = reader.GetDateTime(reader.GetOrdinal("UpdatedDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("UpdateInfo"))) _updateinfo = reader.GetString(reader.GetOrdinal("UpdateInfo"));
                if (!reader.IsDBNull(reader.GetOrdinal("IPAddress"))) this.BaseSecurityParam.ipaddress = reader.GetString(reader.GetOrdinal("IPAddress"));
                if (!reader.IsDBNull(reader.GetOrdinal("TS"))) this.BaseSecurityParam.ts = reader.GetInt64(reader.GetOrdinal("ts"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsActive"))) _isactive = reader.GetBoolean(reader.GetOrdinal("IsActive"));
                CurrentState = EntityState.Unchanged;
            }
        }
        
        #endregion
        
        
            
    }
}
