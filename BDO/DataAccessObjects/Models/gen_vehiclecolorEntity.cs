using System;
using System.Runtime.Serialization;
using System.Data;
using BDO.Core.Base;
using System.ComponentModel.DataAnnotations;


namespace BDO.Core.DataAccessObjects.Models
{
    [Serializable]
    [DataContract(Name = "gen_vehiclecolorEntity", Namespace = "http://www.KAF.com/types")]
    public partial class gen_vehiclecolorEntity : BaseEntity
    {
        #region Properties
    
        protected long ? _vehiclecolorid;
        protected string _vehiclecolorname;
        protected string _vehiclecolornamear;
        protected int ? _sortpriority;
        protected bool ? _isactive;
        protected string _remarks;
        protected long ? _tranformactionid;
        protected string _updateinfo;
                
        
        [DataMember]
        public long ? vehiclecolorid
        {
            get { return _vehiclecolorid; }
            set { _vehiclecolorid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(150)]
        [Display(Name = "vehiclecolorname", ResourceType = typeof(CLL.LLClasses.Models._gen_vehiclecolor))]
        [RegularExpression(@"^[^\u0627-\u0649]+$", ErrorMessageResourceType = typeof(CLL.LLClasses._Common), ErrorMessageResourceName = "Unicodecharactersarenotallowed")]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._gen_vehiclecolor), ErrorMessageResourceName = "vehiclecolornameRequired")]
        public string vehiclecolorname
        {
            get { return _vehiclecolorname; }
            set { _vehiclecolorname = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(150)]
        [Display(Name = "vehiclecolornamear", ResourceType = typeof(CLL.LLClasses.Models._gen_vehiclecolor))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._gen_vehiclecolor), ErrorMessageResourceName = "vehiclecolornameRequired")]
        public string vehiclecolornamear
        {
            get { return _vehiclecolornamear; }
            set { _vehiclecolornamear = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "sortpriority", ResourceType = typeof(CLL.LLClasses.Models._gen_vehiclecolor))]
        public int ? sortpriority
        {
            get { return _sortpriority; }
            set { _sortpriority = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "isactive", ResourceType = typeof(CLL.LLClasses.Models._gen_vehiclecolor))]
        public bool ? isactive
        {
            get { return _isactive; }
            set { _isactive = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(550)]
        [Display(Name = "remarks", ResourceType = typeof(CLL.LLClasses.Models._gen_vehiclecolor))]
        public string remarks
        {
            get { return _remarks; }
            set { _remarks = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "tranformactionid", ResourceType = typeof(CLL.LLClasses.Models._gen_vehiclecolor))]
        public long ? tranformactionid
        {
            get { return _tranformactionid; }
            set { _tranformactionid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(550)]
        [Display(Name = "updateinfo", ResourceType = typeof(CLL.LLClasses.Models._gen_vehiclecolor))]
        public string updateinfo
        {
            get { return _updateinfo; }
            set { _updateinfo = value; this.OnChnaged(); }
        }
        
        
        #endregion
    
        #region Constructor
    
        public gen_vehiclecolorEntity():base()
        {
        }
        
        public gen_vehiclecolorEntity(IDataReader reader)
        {
            this.LoadFromReader(reader);
        }
        
         public gen_vehiclecolorEntity(IDataReader reader, bool IsListViewShow)
        {
            this.LoadFromReader(reader, IsListViewShow);
        }
        
      
        
        protected void LoadFromReader(IDataReader reader)
        {
            if (reader != null && !reader.IsClosed)
            {
                this.BaseSecurityParam = new SecurityCapsule();
                if (!reader.IsDBNull(reader.GetOrdinal("VehicleColorID"))) _vehiclecolorid = reader.GetInt64(reader.GetOrdinal("VehicleColorID"));
                if (!reader.IsDBNull(reader.GetOrdinal("VehicleColorName"))) _vehiclecolorname = reader.GetString(reader.GetOrdinal("VehicleColorName"));
                if (!reader.IsDBNull(reader.GetOrdinal("VehicleColorNameAR"))) _vehiclecolornamear = reader.GetString(reader.GetOrdinal("VehicleColorNameAR"));
                if (!reader.IsDBNull(reader.GetOrdinal("SortPriority"))) _sortpriority = reader.GetInt32(reader.GetOrdinal("SortPriority"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsActive"))) _isactive = reader.GetBoolean(reader.GetOrdinal("IsActive"));
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
                CurrentState = EntityState.Unchanged;
            }
        }


        protected void LoadFromReader(IDataReader reader, bool IsListViewShow)
        {
            if (reader != null && !reader.IsClosed)
            {
                this.BaseSecurityParam = new SecurityCapsule();
                if (!reader.IsDBNull(reader.GetOrdinal("VehicleColorID"))) _vehiclecolorid = reader.GetInt64(reader.GetOrdinal("VehicleColorID"));
                if (!reader.IsDBNull(reader.GetOrdinal("VehicleColorName"))) _vehiclecolorname = reader.GetString(reader.GetOrdinal("VehicleColorName"));
                if (!reader.IsDBNull(reader.GetOrdinal("VehicleColorNameAR"))) _vehiclecolornamear = reader.GetString(reader.GetOrdinal("VehicleColorNameAR"));
                if (!reader.IsDBNull(reader.GetOrdinal("SortPriority"))) _sortpriority = reader.GetInt32(reader.GetOrdinal("SortPriority"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsActive"))) _isactive = reader.GetBoolean(reader.GetOrdinal("IsActive"));
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
                CurrentState = EntityState.Unchanged;
            }
        }
        
        #endregion
        
        
            
    }
}
