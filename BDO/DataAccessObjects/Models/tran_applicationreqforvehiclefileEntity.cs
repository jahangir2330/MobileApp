using System;
using System.Runtime.Serialization;
using System.Data;
using BDO.Core.Base;
using System.ComponentModel.DataAnnotations;


namespace BDO.Core.DataAccessObjects.Models
{
    [Serializable]
    [DataContract(Name = "tran_applicationreqforvehiclefileEntity", Namespace = "http://www.KAF.com/types")]
    public partial class tran_applicationreqforvehiclefileEntity : BaseEntity
    {
        #region Properties
    
        protected long ? _vehiclefileid;
        protected long ? _requestvehicleid;
        protected long ? _vehiclefiletypeid;
        protected string _vehiclefilepath;
        protected bool ? _isactive;
        protected string _fileformattype;
        protected string _fileextension;
        protected string _actualfilename;
        protected string _remarks;
        protected long ? _tranformactionid;
        protected string _updateinfo;
                
        
        [DataMember]
        public long ? vehiclefileid
        {
            get { return _vehiclefileid; }
            set { _vehiclefileid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "requestvehicleid", ResourceType = typeof(CLL.LLClasses.Models._gen_vehiclefile))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._gen_vehiclefile), ErrorMessageResourceName = "requestvehicleidRequired")]
        public long ? requestvehicleid
        {
            get { return _requestvehicleid; }
            set { _requestvehicleid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "vehiclefiletypeid", ResourceType = typeof(CLL.LLClasses.Models._gen_vehiclefile))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._gen_vehiclefile), ErrorMessageResourceName = "vehiclefiletypeidRequired")]
        public long ? vehiclefiletypeid
        {
            get { return _vehiclefiletypeid; }
            set { _vehiclefiletypeid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(150)]
        [Display(Name = "vehiclefilepath", ResourceType = typeof(CLL.LLClasses.Models._gen_vehiclefile))]
        public string vehiclefilepath
        {
            get { return _vehiclefilepath; }
            set { _vehiclefilepath = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "isactive", ResourceType = typeof(CLL.LLClasses.Models._gen_vehiclefile))]
        public bool ? isactive
        {
            get { return _isactive; }
            set { _isactive = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(250)]
        [Display(Name = "fileformattype", ResourceType = typeof(CLL.LLClasses.Models._gen_vehiclefile))]
        public string fileformattype
        {
            get { return _fileformattype; }
            set { _fileformattype = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(250)]
        [Display(Name = "fileextension", ResourceType = typeof(CLL.LLClasses.Models._gen_vehiclefile))]
        public string fileextension
        {
            get { return _fileextension; }
            set { _fileextension = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(550)]
        [Display(Name = "actualfilename", ResourceType = typeof(CLL.LLClasses.Models._gen_vehiclefile))]
        public string actualfilename
        {
            get { return _actualfilename; }
            set { _actualfilename = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(550)]
        [Display(Name = "remarks", ResourceType = typeof(CLL.LLClasses.Models._gen_vehiclefile))]
        public string remarks
        {
            get { return _remarks; }
            set { _remarks = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "tranformactionid", ResourceType = typeof(CLL.LLClasses.Models._gen_vehiclefile))]
        public long ? tranformactionid
        {
            get { return _tranformactionid; }
            set { _tranformactionid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(550)]
        [Display(Name = "updateinfo", ResourceType = typeof(CLL.LLClasses.Models._gen_vehiclefile))]
        public string updateinfo
        {
            get { return _updateinfo; }
            set { _updateinfo = value; this.OnChnaged(); }
        }
        
        
        #endregion
    
        #region Constructor
    
        public tran_applicationreqforvehiclefileEntity():base()
        {
        }
        
        public tran_applicationreqforvehiclefileEntity(IDataReader reader)
        {
            this.LoadFromReader(reader);
        }
        
         public tran_applicationreqforvehiclefileEntity(IDataReader reader, bool IsListViewShow)
        {
            this.LoadFromReader(reader, IsListViewShow);
        }
        
      
        
        protected void LoadFromReader(IDataReader reader)
        {
            if (reader != null && !reader.IsClosed)
            {
                this.BaseSecurityParam = new SecurityCapsule();
                if (!reader.IsDBNull(reader.GetOrdinal("VehicleFileID"))) _vehiclefileid = reader.GetInt64(reader.GetOrdinal("VehicleFileID"));
                if (!reader.IsDBNull(reader.GetOrdinal("RequestVehicleID"))) _requestvehicleid = reader.GetInt64(reader.GetOrdinal("RequestVehicleID"));
                if (!reader.IsDBNull(reader.GetOrdinal("VehicleFileTypeID"))) _vehiclefiletypeid = reader.GetInt64(reader.GetOrdinal("VehicleFileTypeID"));
                if (!reader.IsDBNull(reader.GetOrdinal("VehicleFilePath"))) _vehiclefilepath = reader.GetString(reader.GetOrdinal("VehicleFilePath"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsActive"))) _isactive = reader.GetBoolean(reader.GetOrdinal("IsActive"));
                if (!reader.IsDBNull(reader.GetOrdinal("FileFormatType"))) _fileformattype = reader.GetString(reader.GetOrdinal("FileFormatType"));
                if (!reader.IsDBNull(reader.GetOrdinal("FileExtension"))) _fileextension = reader.GetString(reader.GetOrdinal("FileExtension"));
                if (!reader.IsDBNull(reader.GetOrdinal("ActualFileName"))) _actualfilename = reader.GetString(reader.GetOrdinal("ActualFileName"));
                if (!reader.IsDBNull(reader.GetOrdinal("Remarks"))) _remarks = reader.GetString(reader.GetOrdinal("Remarks"));
                if (!reader.IsDBNull(reader.GetOrdinal("TransID"))) this.BaseSecurityParam.transid = reader.GetString(reader.GetOrdinal("TransID"));
                if (!reader.IsDBNull(reader.GetOrdinal("TranFormActionID"))) _tranformactionid = reader.GetInt64(reader.GetOrdinal("TranFormActionID"));
                if (!reader.IsDBNull(reader.GetOrdinal("CreatedByUserName"))) this.BaseSecurityParam.createdbyusername = reader.GetString(reader.GetOrdinal("CreatedByUserName"));
                if (!reader.IsDBNull(reader.GetOrdinal("CreatedDate"))) this.BaseSecurityParam.createddate = reader.GetDateTime(reader.GetOrdinal("CreatedDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("UpdatedByUserName"))) this.BaseSecurityParam.updatedbyusername = reader.GetString(reader.GetOrdinal("UpdatedByUserName"));
                if (!reader.IsDBNull(reader.GetOrdinal("UpdatedDate"))) this.BaseSecurityParam.updateddate = reader.GetDateTime(reader.GetOrdinal("UpdatedDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("UpdateInfo"))) _updateinfo = reader.GetString(reader.GetOrdinal("UpdateInfo"));
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
                if (!reader.IsDBNull(reader.GetOrdinal("VehicleFileID"))) _vehiclefileid = reader.GetInt64(reader.GetOrdinal("VehicleFileID"));
                if (!reader.IsDBNull(reader.GetOrdinal("RequestVehicleID"))) _requestvehicleid = reader.GetInt64(reader.GetOrdinal("RequestVehicleID"));
                if (!reader.IsDBNull(reader.GetOrdinal("VehicleFileTypeID"))) _vehiclefiletypeid = reader.GetInt64(reader.GetOrdinal("VehicleFileTypeID"));
                if (!reader.IsDBNull(reader.GetOrdinal("VehicleFilePath"))) _vehiclefilepath = reader.GetString(reader.GetOrdinal("VehicleFilePath"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsActive"))) _isactive = reader.GetBoolean(reader.GetOrdinal("IsActive"));
                if (!reader.IsDBNull(reader.GetOrdinal("FileFormatType"))) _fileformattype = reader.GetString(reader.GetOrdinal("FileFormatType"));
                if (!reader.IsDBNull(reader.GetOrdinal("FileExtension"))) _fileextension = reader.GetString(reader.GetOrdinal("FileExtension"));
                if (!reader.IsDBNull(reader.GetOrdinal("ActualFileName"))) _actualfilename = reader.GetString(reader.GetOrdinal("ActualFileName"));
                if (!reader.IsDBNull(reader.GetOrdinal("Remarks"))) _remarks = reader.GetString(reader.GetOrdinal("Remarks"));
                if (!reader.IsDBNull(reader.GetOrdinal("TransID"))) this.BaseSecurityParam.transid = reader.GetString(reader.GetOrdinal("TransID"));
                if (!reader.IsDBNull(reader.GetOrdinal("TranFormActionID"))) _tranformactionid = reader.GetInt64(reader.GetOrdinal("TranFormActionID"));
                if (!reader.IsDBNull(reader.GetOrdinal("CreatedByUserName"))) this.BaseSecurityParam.createdbyusername = reader.GetString(reader.GetOrdinal("CreatedByUserName"));
                if (!reader.IsDBNull(reader.GetOrdinal("CreatedDate"))) this.BaseSecurityParam.createddate = reader.GetDateTime(reader.GetOrdinal("CreatedDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("UpdatedByUserName"))) this.BaseSecurityParam.updatedbyusername = reader.GetString(reader.GetOrdinal("UpdatedByUserName"));
                if (!reader.IsDBNull(reader.GetOrdinal("UpdatedDate"))) this.BaseSecurityParam.updateddate = reader.GetDateTime(reader.GetOrdinal("UpdatedDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("UpdateInfo"))) _updateinfo = reader.GetString(reader.GetOrdinal("UpdateInfo"));
                if (!reader.IsDBNull(reader.GetOrdinal("IPAddress"))) this.BaseSecurityParam.ipaddress = reader.GetString(reader.GetOrdinal("IPAddress"));
                if (!reader.IsDBNull(reader.GetOrdinal("TS"))) this.BaseSecurityParam.ts = reader.GetInt64(reader.GetOrdinal("ts"));
                CurrentState = EntityState.Unchanged;
            }
        }
        
        #endregion
        
        
            
    }
}
