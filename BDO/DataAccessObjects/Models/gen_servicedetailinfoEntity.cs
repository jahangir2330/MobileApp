using System;
using System.Runtime.Serialization;
using System.Data;
using BDO.Core.Base;
using System.ComponentModel.DataAnnotations;


namespace BDO.Core.DataAccessObjects.Models
{
    [Serializable]
    [DataContract(Name = "gen_servicedetailinfoEntity", Namespace = "http://www.KAF.com/types")]
    public partial class gen_servicedetailinfoEntity : BaseEntity
    {
        #region Properties
    
        protected long ? _servicedetailid;
        protected long ? _serviceid;
        protected string _titleen;
        protected string _titlear;
        protected string _descriptionen;
        protected string _descriptionar;
        protected string _getdataby;
        protected string _serviceurl;
        protected string _username;
        protected string _password;
        protected string _intcode;
        protected bool ? _isoffline;
        protected bool ? _istested;
        protected DateTime ? _testdate;
        protected string _testby;
        protected bool ? _isactive;
                
        
        [DataMember]
        public long ? servicedetailid
        {
            get { return _servicedetailid; }
            set { _servicedetailid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "serviceid", ResourceType = typeof(CLL.LLClasses.Models._gen_servicedetailinfo))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._gen_servicedetailinfo), ErrorMessageResourceName = "serviceidRequired")]
        public long ? serviceid
        {
            get { return _serviceid; }
            set { _serviceid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(150)]
        [Display(Name = "titleen", ResourceType = typeof(CLL.LLClasses.Models._gen_servicedetailinfo))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._gen_servicedetailinfo), ErrorMessageResourceName = "titleenRequired")]
        public string titleen
        {
            get { return _titleen; }
            set { _titleen = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(250)]
        [Display(Name = "titlear", ResourceType = typeof(CLL.LLClasses.Models._gen_servicedetailinfo))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._gen_servicedetailinfo), ErrorMessageResourceName = "titlearRequired")]
        public string titlear
        {
            get { return _titlear; }
            set { _titlear = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(350)]
        [Display(Name = "descriptionen", ResourceType = typeof(CLL.LLClasses.Models._gen_servicedetailinfo))]
        public string descriptionen
        {
            get { return _descriptionen; }
            set { _descriptionen = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(350)]
        [Display(Name = "descriptionar", ResourceType = typeof(CLL.LLClasses.Models._gen_servicedetailinfo))]
        public string descriptionar
        {
            get { return _descriptionar; }
            set { _descriptionar = value; this.OnChnaged(); }
        }

        [DataMember]
        [MaxLength(350)]
        //[Display(Name = "getdataby", ResourceType = typeof(CLL.LLClasses.Models._gen_servicedetailinfo))]
        public string getdataby
        {
            get { return _getdataby; }
            set { _getdataby = value; this.OnChnaged(); }
        }

        [DataMember]
        [MaxLength(350)]
        [Display(Name = "serviceurl", ResourceType = typeof(CLL.LLClasses.Models._gen_servicedetailinfo))]
        public string serviceurl
        {
            get { return _serviceurl; }
            set { _serviceurl = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(20)]
        [Display(Name = "username", ResourceType = typeof(CLL.LLClasses.Models._gen_servicedetailinfo))]
        public string username
        {
            get { return _username; }
            set { _username = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(20)]
        [Display(Name = "password", ResourceType = typeof(CLL.LLClasses.Models._gen_servicedetailinfo))]
        public string password
        {
            get { return _password; }
            set { _password = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(50)]
        [Display(Name = "intcode", ResourceType = typeof(CLL.LLClasses.Models._gen_servicedetailinfo))]
        public string intcode
        {
            get { return _intcode; }
            set { _intcode = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "isoffline", ResourceType = typeof(CLL.LLClasses.Models._gen_servicedetailinfo))]
        public bool ? isoffline
        {
            get { return _isoffline; }
            set { _isoffline = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "istested", ResourceType = typeof(CLL.LLClasses.Models._gen_servicedetailinfo))]
        public bool ? istested
        {
            get { return _istested; }
            set { _istested = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "testdate", ResourceType = typeof(CLL.LLClasses.Models._gen_servicedetailinfo))]
        public DateTime ? testdate
        {
            get { return _testdate; }
            set { _testdate = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(256)]
        [Display(Name = "testby", ResourceType = typeof(CLL.LLClasses.Models._gen_servicedetailinfo))]
        public string testby
        {
            get { return _testby; }
            set { _testby = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "isactive", ResourceType = typeof(CLL.LLClasses.Models._gen_servicedetailinfo))]
        public bool ? isactive
        {
            get { return _isactive; }
            set { _isactive = value; this.OnChnaged(); }
        }
        
        
        #endregion
    
        #region Constructor
    
        public gen_servicedetailinfoEntity():base()
        {
        }
        
        public gen_servicedetailinfoEntity(IDataReader reader)
        {
            this.LoadFromReader(reader);
        }
        
         public gen_servicedetailinfoEntity(IDataReader reader, bool IsListViewShow)
        {
            this.LoadFromReader(reader, IsListViewShow);
        }
        
      
        
        protected void LoadFromReader(IDataReader reader)
        {
            if (reader != null && !reader.IsClosed)
            {
                this.BaseSecurityParam = new SecurityCapsule();
                if (!reader.IsDBNull(reader.GetOrdinal("ServiceDetailID"))) _servicedetailid = reader.GetInt64(reader.GetOrdinal("ServiceDetailID"));
                if (!reader.IsDBNull(reader.GetOrdinal("ServiceID"))) _serviceid = reader.GetInt64(reader.GetOrdinal("ServiceID"));
                if (!reader.IsDBNull(reader.GetOrdinal("TitleEN"))) _titleen = reader.GetString(reader.GetOrdinal("TitleEN"));
                if (!reader.IsDBNull(reader.GetOrdinal("TitleAR"))) _titlear = reader.GetString(reader.GetOrdinal("TitleAR"));
                if (!reader.IsDBNull(reader.GetOrdinal("DescriptionEN"))) _descriptionen = reader.GetString(reader.GetOrdinal("DescriptionEN"));
                if (!reader.IsDBNull(reader.GetOrdinal("DescriptionAR"))) _descriptionar = reader.GetString(reader.GetOrdinal("DescriptionAR"));
                if (!reader.IsDBNull(reader.GetOrdinal("ServiceURL"))) _serviceurl = reader.GetString(reader.GetOrdinal("ServiceURL"));
                if (!reader.IsDBNull(reader.GetOrdinal("UserName"))) _username = reader.GetString(reader.GetOrdinal("UserName"));
                if (!reader.IsDBNull(reader.GetOrdinal("Password"))) _password = reader.GetString(reader.GetOrdinal("Password"));
                if (!reader.IsDBNull(reader.GetOrdinal("IntCode"))) _intcode = reader.GetString(reader.GetOrdinal("IntCode"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsOffline"))) _isoffline = reader.GetBoolean(reader.GetOrdinal("IsOffline"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsTested"))) _istested = reader.GetBoolean(reader.GetOrdinal("IsTested"));
                if (!reader.IsDBNull(reader.GetOrdinal("TestDate"))) _testdate = reader.GetDateTime(reader.GetOrdinal("TestDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("TestBy"))) _testby = reader.GetString(reader.GetOrdinal("TestBy"));
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
                if (!reader.IsDBNull(reader.GetOrdinal("ServiceDetailID"))) _servicedetailid = reader.GetInt64(reader.GetOrdinal("ServiceDetailID"));
                if (!reader.IsDBNull(reader.GetOrdinal("ServiceID"))) _serviceid = reader.GetInt64(reader.GetOrdinal("ServiceID"));
                if (!reader.IsDBNull(reader.GetOrdinal("TitleEN"))) _titleen = reader.GetString(reader.GetOrdinal("TitleEN"));
                if (!reader.IsDBNull(reader.GetOrdinal("TitleAR"))) _titlear = reader.GetString(reader.GetOrdinal("TitleAR"));
                if (!reader.IsDBNull(reader.GetOrdinal("DescriptionEN"))) _descriptionen = reader.GetString(reader.GetOrdinal("DescriptionEN"));
                if (!reader.IsDBNull(reader.GetOrdinal("DescriptionAR"))) _descriptionar = reader.GetString(reader.GetOrdinal("DescriptionAR"));
                if (!reader.IsDBNull(reader.GetOrdinal("ServiceURL"))) _serviceurl = reader.GetString(reader.GetOrdinal("ServiceURL"));
                if (!reader.IsDBNull(reader.GetOrdinal("UserName"))) _username = reader.GetString(reader.GetOrdinal("UserName"));
                if (!reader.IsDBNull(reader.GetOrdinal("Password"))) _password = reader.GetString(reader.GetOrdinal("Password"));
                if (!reader.IsDBNull(reader.GetOrdinal("IntCode"))) _intcode = reader.GetString(reader.GetOrdinal("IntCode"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsOffline"))) _isoffline = reader.GetBoolean(reader.GetOrdinal("IsOffline"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsTested"))) _istested = reader.GetBoolean(reader.GetOrdinal("IsTested"));
                if (!reader.IsDBNull(reader.GetOrdinal("TestDate"))) _testdate = reader.GetDateTime(reader.GetOrdinal("TestDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("TestBy"))) _testby = reader.GetString(reader.GetOrdinal("TestBy"));
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
