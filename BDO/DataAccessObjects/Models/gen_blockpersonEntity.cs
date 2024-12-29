using System;
using System.Runtime.Serialization;
using System.Data;
using BDO.Core.Base;
using System.ComponentModel.DataAnnotations;


namespace BDO.Core.DataAccessObjects.Models
{
    [Serializable]
    [DataContract(Name = "gen_blockpersonEntity", Namespace = "http://www.KAF.com/types")]
    public partial class gen_blockpersonEntity : BaseEntity
    {
        #region Properties
    
        protected long ? _blockpersonid;
        protected string _blockpersonname;
        protected string _blockpersonnamear;
        protected string _civilidnumber;
        protected string _passportnumber;
        protected string _blockdescription;
        protected bool ? _isblocked;
        protected DateTime ? _blockstartdate;
        protected DateTime ? _blockenddate;
        protected long ? _blockedbyuserid;
        protected bool ? _isactive;
        protected string _updateinfo;
        protected long ? _tranformactionid;
                
        
        [DataMember]
        public long ? blockpersonid
        {
            get { return _blockpersonid; }
            set { _blockpersonid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(150)]
        [Display(Name = "blockpersonname", ResourceType = typeof(CLL.LLClasses.Models._gen_blockperson))]
        public string blockpersonname
        {
            get { return _blockpersonname; }
            set { _blockpersonname = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(150)]
        [Display(Name = "blockpersonnamear", ResourceType = typeof(CLL.LLClasses.Models._gen_blockperson))]
        public string blockpersonnamear
        {
            get { return _blockpersonnamear; }
            set { _blockpersonnamear = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(150)]
        [Display(Name = "civilidnumber", ResourceType = typeof(CLL.LLClasses.Models._gen_blockperson))]
        public string civilidnumber
        {
            get { return _civilidnumber; }
            set { _civilidnumber = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(150)]
        [Display(Name = "passportnumber", ResourceType = typeof(CLL.LLClasses.Models._gen_blockperson))]
        public string passportnumber
        {
            get { return _passportnumber; }
            set { _passportnumber = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(550)]
        [Display(Name = "blockdescription", ResourceType = typeof(CLL.LLClasses.Models._gen_blockperson))]
        public string blockdescription
        {
            get { return _blockdescription; }
            set { _blockdescription = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "isblocked", ResourceType = typeof(CLL.LLClasses.Models._gen_blockperson))]
        public bool ? isblocked
        {
            get { return _isblocked; }
            set { _isblocked = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "blockstartdate", ResourceType = typeof(CLL.LLClasses.Models._gen_blockperson))]
        [DataType(DataType.Date), DisplayFormat(DataFormatString = @"{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime ? blockstartdate
        {
            get { return _blockstartdate; }
            set { _blockstartdate = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "blockenddate", ResourceType = typeof(CLL.LLClasses.Models._gen_blockperson))]
        [DataType(DataType.Date), DisplayFormat(DataFormatString = @"{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime ? blockenddate
        {
            get { return _blockenddate; }
            set { _blockenddate = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "blockedbyuserid", ResourceType = typeof(CLL.LLClasses.Models._gen_blockperson))]
        public long ? blockedbyuserid
        {
            get { return _blockedbyuserid; }
            set { _blockedbyuserid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "isactive", ResourceType = typeof(CLL.LLClasses.Models._gen_blockperson))]
        public bool ? isactive
        {
            get { return _isactive; }
            set { _isactive = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(550)]
        [Display(Name = "updateinfo", ResourceType = typeof(CLL.LLClasses.Models._gen_blockperson))]
        public string updateinfo
        {
            get { return _updateinfo; }
            set { _updateinfo = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "tranformactionid", ResourceType = typeof(CLL.LLClasses.Models._gen_blockperson))]
        public long ? tranformactionid
        {
            get { return _tranformactionid; }
            set { _tranformactionid = value; this.OnChnaged(); }
        }
        
        
        #endregion
    
        #region Constructor
    
        public gen_blockpersonEntity():base()
        {
        }
        
        public gen_blockpersonEntity(IDataReader reader)
        {
            this.LoadFromReader(reader);
        }
        
         public gen_blockpersonEntity(IDataReader reader, bool IsListViewShow)
        {
            this.LoadFromReader(reader, IsListViewShow);
        }
        
      
        
        protected void LoadFromReader(IDataReader reader)
        {
            if (reader != null && !reader.IsClosed)
            {
                this.BaseSecurityParam = new SecurityCapsule();
                if (!reader.IsDBNull(reader.GetOrdinal("BlockPersonID"))) _blockpersonid = reader.GetInt64(reader.GetOrdinal("BlockPersonID"));
                if (!reader.IsDBNull(reader.GetOrdinal("BlockPersonName"))) _blockpersonname = reader.GetString(reader.GetOrdinal("BlockPersonName"));
                if (!reader.IsDBNull(reader.GetOrdinal("BlockPersonNameAR"))) _blockpersonnamear = reader.GetString(reader.GetOrdinal("BlockPersonNameAR"));
                if (!reader.IsDBNull(reader.GetOrdinal("CivilIdNumber"))) _civilidnumber = reader.GetString(reader.GetOrdinal("CivilIdNumber"));
                if (!reader.IsDBNull(reader.GetOrdinal("PassportNumber"))) _passportnumber = reader.GetString(reader.GetOrdinal("PassportNumber"));
                if (!reader.IsDBNull(reader.GetOrdinal("BlockDescription"))) _blockdescription = reader.GetString(reader.GetOrdinal("BlockDescription"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsBlocked"))) _isblocked = reader.GetBoolean(reader.GetOrdinal("IsBlocked"));
                if (!reader.IsDBNull(reader.GetOrdinal("BlockStartDate"))) _blockstartdate = reader.GetDateTime(reader.GetOrdinal("BlockStartDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("BlockEndDate"))) _blockenddate = reader.GetDateTime(reader.GetOrdinal("BlockEndDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("BlockedByUserId"))) _blockedbyuserid = reader.GetInt64(reader.GetOrdinal("BlockedByUserId"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsActive"))) _isactive = reader.GetBoolean(reader.GetOrdinal("IsActive"));
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
                if (!reader.IsDBNull(reader.GetOrdinal("BlockPersonID"))) _blockpersonid = reader.GetInt64(reader.GetOrdinal("BlockPersonID"));
                if (!reader.IsDBNull(reader.GetOrdinal("BlockPersonName"))) _blockpersonname = reader.GetString(reader.GetOrdinal("BlockPersonName"));
                if (!reader.IsDBNull(reader.GetOrdinal("BlockPersonNameAR"))) _blockpersonnamear = reader.GetString(reader.GetOrdinal("BlockPersonNameAR"));
                if (!reader.IsDBNull(reader.GetOrdinal("CivilIdNumber"))) _civilidnumber = reader.GetString(reader.GetOrdinal("CivilIdNumber"));
                if (!reader.IsDBNull(reader.GetOrdinal("PassportNumber"))) _passportnumber = reader.GetString(reader.GetOrdinal("PassportNumber"));
                if (!reader.IsDBNull(reader.GetOrdinal("BlockDescription"))) _blockdescription = reader.GetString(reader.GetOrdinal("BlockDescription"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsBlocked"))) _isblocked = reader.GetBoolean(reader.GetOrdinal("IsBlocked"));
                if (!reader.IsDBNull(reader.GetOrdinal("BlockStartDate"))) _blockstartdate = reader.GetDateTime(reader.GetOrdinal("BlockStartDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("BlockEndDate"))) _blockenddate = reader.GetDateTime(reader.GetOrdinal("BlockEndDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("BlockedByUserId"))) _blockedbyuserid = reader.GetInt64(reader.GetOrdinal("BlockedByUserId"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsActive"))) _isactive = reader.GetBoolean(reader.GetOrdinal("IsActive"));
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
