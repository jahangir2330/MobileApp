using System;
using System.Runtime.Serialization;
using System.Data;
using BDO.Core.Base;
using System.ComponentModel.DataAnnotations;


namespace BDO.Core.DataAccessObjects.Models
{
    [Serializable]
    [DataContract(Name = "sahelservicerequestinfoEntity", Namespace = "http://www.KAF.com/types")]
    public partial class sahelservicerequestinfoEntity : BaseEntity
    {
        #region Properties
    
        protected long ? _serial;
        protected string _servicename;
        protected string _serviceurl;
        protected string _fromcivilid;
        protected DateTime ? _requestdate;
        protected string _requestjson;
                
        
        [DataMember]
        public long ? serial
        {
            get { return _serial; }
            set { _serial = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(150)]
        [Display(Name = "servicename", ResourceType = typeof(CLL.LLClasses.Models._sahelservicerequestinfo))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._sahelservicerequestinfo), ErrorMessageResourceName = "servicenameRequired")]
        public string servicename
        {
            get { return _servicename; }
            set { _servicename = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(150)]
        [Display(Name = "serviceurl", ResourceType = typeof(CLL.LLClasses.Models._sahelservicerequestinfo))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._sahelservicerequestinfo), ErrorMessageResourceName = "serviceurlRequired")]
        public string serviceurl
        {
            get { return _serviceurl; }
            set { _serviceurl = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(50)]
        [Display(Name = "fromcivilid", ResourceType = typeof(CLL.LLClasses.Models._sahelservicerequestinfo))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._sahelservicerequestinfo), ErrorMessageResourceName = "fromcivilidRequired")]
        public string fromcivilid
        {
            get { return _fromcivilid; }
            set { _fromcivilid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "requestdate", ResourceType = typeof(CLL.LLClasses.Models._sahelservicerequestinfo))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._sahelservicerequestinfo), ErrorMessageResourceName = "requestdateRequired")]
        public DateTime ? requestdate
        {
            get { return _requestdate; }
            set { _requestdate = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(-1)]
        [Display(Name = "requestjson", ResourceType = typeof(CLL.LLClasses.Models._sahelservicerequestinfo))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._sahelservicerequestinfo), ErrorMessageResourceName = "requestjsonRequired")]
        public string requestjson
        {
            get { return _requestjson; }
            set { _requestjson = value; this.OnChnaged(); }
        }
        
        
        #endregion
    
        #region Constructor
    
        public sahelservicerequestinfoEntity():base()
        {
        }
        
        public sahelservicerequestinfoEntity(IDataReader reader)
        {
            this.LoadFromReader(reader);
        }
        
         public sahelservicerequestinfoEntity(IDataReader reader, bool IsListViewShow)
        {
            this.LoadFromReader(reader, IsListViewShow);
        }
        
      
        
        protected void LoadFromReader(IDataReader reader)
        {
            if (reader != null && !reader.IsClosed)
            {
                this.BaseSecurityParam = new SecurityCapsule();
                if (!reader.IsDBNull(reader.GetOrdinal("Serial"))) _serial = reader.GetInt64(reader.GetOrdinal("Serial"));
                if (!reader.IsDBNull(reader.GetOrdinal("ServiceName"))) _servicename = reader.GetString(reader.GetOrdinal("ServiceName"));
                if (!reader.IsDBNull(reader.GetOrdinal("ServiceURL"))) _serviceurl = reader.GetString(reader.GetOrdinal("ServiceURL"));
                if (!reader.IsDBNull(reader.GetOrdinal("FromCivilID"))) _fromcivilid = reader.GetString(reader.GetOrdinal("FromCivilID"));
                if (!reader.IsDBNull(reader.GetOrdinal("RequestDate"))) _requestdate = reader.GetDateTime(reader.GetOrdinal("RequestDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("RequestJson"))) _requestjson = reader.GetString(reader.GetOrdinal("RequestJson"));
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
                if (!reader.IsDBNull(reader.GetOrdinal("Serial"))) _serial = reader.GetInt64(reader.GetOrdinal("Serial"));
                if (!reader.IsDBNull(reader.GetOrdinal("ServiceName"))) _servicename = reader.GetString(reader.GetOrdinal("ServiceName"));
                if (!reader.IsDBNull(reader.GetOrdinal("ServiceURL"))) _serviceurl = reader.GetString(reader.GetOrdinal("ServiceURL"));
                if (!reader.IsDBNull(reader.GetOrdinal("FromCivilID"))) _fromcivilid = reader.GetString(reader.GetOrdinal("FromCivilID"));
                if (!reader.IsDBNull(reader.GetOrdinal("RequestDate"))) _requestdate = reader.GetDateTime(reader.GetOrdinal("RequestDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("RequestJson"))) _requestjson = reader.GetString(reader.GetOrdinal("RequestJson"));
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
