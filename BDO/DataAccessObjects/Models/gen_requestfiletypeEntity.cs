using System;
using System.Runtime.Serialization;
using System.Data;
using BDO.Core.Base;
using System.ComponentModel.DataAnnotations;


namespace BDO.Core.DataAccessObjects.Models
{
    [Serializable]
    [DataContract(Name = "gen_requestfiletypeEntity", Namespace = "http://www.KAF.com/types")]
    public partial class gen_requestfiletypeEntity : BaseEntity
    {
        #region Properties
    
        protected long ? _requestfiletypeid;
        protected string _requestfiletypename;
        protected string _requestfiletypenamear;
        protected string _expectedfiletypes;
        protected string _errormessageforrequired;
        protected string _errormessageforrequiredar;
        


        protected int ? _sortpriority;
        protected string _remarks;
        protected string _updateinfo;
        protected long ? _tranformactionid;
                
        
        [DataMember]
        public long ? requestfiletypeid
        {
            get { return _requestfiletypeid; }
            set { _requestfiletypeid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(150)]
        [Display(Name = "requestfiletypename", ResourceType = typeof(CLL.LLClasses.Models._gen_requestfiletype))]
        public string requestfiletypename
        {
            get { return _requestfiletypename; }
            set { _requestfiletypename = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(150)]
        [Display(Name = "requestfiletypenamear", ResourceType = typeof(CLL.LLClasses.Models._gen_requestfiletype))]
        public string requestfiletypenamear
        {
            get { return _requestfiletypenamear; }
            set { _requestfiletypenamear = value; this.OnChnaged(); }
        }

        [DataMember]
        [MaxLength(150)]
        [Display(Name = "expectedfiletypes", ResourceType = typeof(CLL.LLClasses.Models._gen_requestfiletype))]
        public string expectedfiletypes
        {
            get { return _expectedfiletypes; }
            set { _expectedfiletypes = value; this.OnChnaged(); }
        }

        [DataMember]
        [MaxLength(250)]
        [Display(Name = "errormessageforrequired", ResourceType = typeof(CLL.LLClasses.Models._gen_requestfiletype))]
        public string errormessageforrequired
        {
            get { return _errormessageforrequired; }
            set { _errormessageforrequired = value; this.OnChnaged(); }
        }

        [DataMember]
        [MaxLength(250)]
        [Display(Name = "errormessageforrequiredar", ResourceType = typeof(CLL.LLClasses.Models._gen_requestfiletype))]
        public string errormessageforrequiredar
        {
            get { return _errormessageforrequiredar; }
            set { _errormessageforrequiredar = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "sortpriority", ResourceType = typeof(CLL.LLClasses.Models._gen_requestfiletype))]
        public int ? sortpriority
        {
            get { return _sortpriority; }
            set { _sortpriority = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(550)]
        [Display(Name = "remarks", ResourceType = typeof(CLL.LLClasses.Models._gen_requestfiletype))]
        public string remarks
        {
            get { return _remarks; }
            set { _remarks = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(550)]
        [Display(Name = "updateinfo", ResourceType = typeof(CLL.LLClasses.Models._gen_requestfiletype))]
        public string updateinfo
        {
            get { return _updateinfo; }
            set { _updateinfo = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "tranformactionid", ResourceType = typeof(CLL.LLClasses.Models._gen_requestfiletype))]
        public long ? tranformactionid
        {
            get { return _tranformactionid; }
            set { _tranformactionid = value; this.OnChnaged(); }
        }
        
        
        #endregion
    
        #region Constructor
    
        public gen_requestfiletypeEntity():base()
        {
        }
        
        public gen_requestfiletypeEntity(IDataReader reader)
        {
            this.LoadFromReader(reader);
        }
        
         public gen_requestfiletypeEntity(IDataReader reader, bool IsListViewShow)
        {
            this.LoadFromReader(reader, IsListViewShow);
        }
        
      
        
        protected void LoadFromReader(IDataReader reader)
        {
            if (reader != null && !reader.IsClosed)
            {
                this.BaseSecurityParam = new SecurityCapsule();
                if (!reader.IsDBNull(reader.GetOrdinal("RequestFileTypeID"))) _requestfiletypeid = reader.GetInt64(reader.GetOrdinal("RequestFileTypeID"));
                if (!reader.IsDBNull(reader.GetOrdinal("RequestFileTypeName"))) _requestfiletypename = reader.GetString(reader.GetOrdinal("RequestFileTypeName"));
                if (!reader.IsDBNull(reader.GetOrdinal("RequestFileTypeNameAR"))) _requestfiletypenamear = reader.GetString(reader.GetOrdinal("RequestFileTypeNameAR"));
                if (!reader.IsDBNull(reader.GetOrdinal("ExpectedFileTypes"))) _expectedfiletypes = reader.GetString(reader.GetOrdinal("ExpectedFileTypes"));
                if (!reader.IsDBNull(reader.GetOrdinal("ErrorMessageForRequired"))) _errormessageforrequired = reader.GetString(reader.GetOrdinal("ErrorMessageForRequired"));
                if (!reader.IsDBNull(reader.GetOrdinal("ErrorMessageForRequiredAR"))) _errormessageforrequiredar = reader.GetString(reader.GetOrdinal("ErrorMessageForRequiredAR"));
                if (!reader.IsDBNull(reader.GetOrdinal("SortPriority"))) _sortpriority = reader.GetInt32(reader.GetOrdinal("SortPriority"));
                if (!reader.IsDBNull(reader.GetOrdinal("Remarks"))) _remarks = reader.GetString(reader.GetOrdinal("Remarks"));
                if (!reader.IsDBNull(reader.GetOrdinal("TransID"))) this.BaseSecurityParam.transid = reader.GetString(reader.GetOrdinal("TransID"));
                if (!reader.IsDBNull(reader.GetOrdinal("CreatedByUserName"))) this.BaseSecurityParam.createdbyusername = reader.GetString(reader.GetOrdinal("CreatedByUserName"));
                if (!reader.IsDBNull(reader.GetOrdinal("CreatedDate"))) this.BaseSecurityParam.createddate = reader.GetDateTime(reader.GetOrdinal("CreatedDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("UpdatedByUserName"))) this.BaseSecurityParam.updatedbyusername = reader.GetString(reader.GetOrdinal("UpdatedByUserName"));
                if (!reader.IsDBNull(reader.GetOrdinal("UpdatedDate"))) this.BaseSecurityParam.updateddate = reader.GetDateTime(reader.GetOrdinal("UpdatedDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("UpdateInfo"))) _updateinfo = reader.GetString(reader.GetOrdinal("UpdateInfo"));
                if (!reader.IsDBNull(reader.GetOrdinal("IPAddress"))) this.BaseSecurityParam.ipaddress = reader.GetString(reader.GetOrdinal("IPAddress"));
                if (!reader.IsDBNull(reader.GetOrdinal("TranFormActionID"))) _tranformactionid = reader.GetInt64(reader.GetOrdinal("TranFormActionID"));
                if (!reader.IsDBNull(reader.GetOrdinal("TS"))) this.BaseSecurityParam.ts = reader.GetInt64(reader.GetOrdinal("ts"));
                CurrentState = EntityState.Unchanged;
            }
        }


        protected void LoadFromReader(IDataReader reader, bool IsListViewShow)
        {
            if (reader != null && !reader.IsClosed)
            {
                this.BaseSecurityParam = new SecurityCapsule();
                if (!reader.IsDBNull(reader.GetOrdinal("RequestFileTypeID"))) _requestfiletypeid = reader.GetInt64(reader.GetOrdinal("RequestFileTypeID"));
                if (!reader.IsDBNull(reader.GetOrdinal("RequestFileTypeName"))) _requestfiletypename = reader.GetString(reader.GetOrdinal("RequestFileTypeName"));
                if (!reader.IsDBNull(reader.GetOrdinal("RequestFileTypeNameAR"))) _requestfiletypenamear = reader.GetString(reader.GetOrdinal("RequestFileTypeNameAR"));
                if (!reader.IsDBNull(reader.GetOrdinal("ExpectedFileTypes"))) _expectedfiletypes = reader.GetString(reader.GetOrdinal("ExpectedFileTypes"));
                if (!reader.IsDBNull(reader.GetOrdinal("ErrorMessageForRequired"))) _errormessageforrequired = reader.GetString(reader.GetOrdinal("ErrorMessageForRequired"));
                if (!reader.IsDBNull(reader.GetOrdinal("ErrorMessageForRequiredAR"))) _errormessageforrequiredar = reader.GetString(reader.GetOrdinal("ErrorMessageForRequiredAR"));
                if (!reader.IsDBNull(reader.GetOrdinal("SortPriority"))) _sortpriority = reader.GetInt32(reader.GetOrdinal("SortPriority"));
                if (!reader.IsDBNull(reader.GetOrdinal("Remarks"))) _remarks = reader.GetString(reader.GetOrdinal("Remarks"));
                if (!reader.IsDBNull(reader.GetOrdinal("TransID"))) this.BaseSecurityParam.transid = reader.GetString(reader.GetOrdinal("TransID"));
                if (!reader.IsDBNull(reader.GetOrdinal("CreatedByUserName"))) this.BaseSecurityParam.createdbyusername = reader.GetString(reader.GetOrdinal("CreatedByUserName"));
                if (!reader.IsDBNull(reader.GetOrdinal("CreatedDate"))) this.BaseSecurityParam.createddate = reader.GetDateTime(reader.GetOrdinal("CreatedDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("UpdatedByUserName"))) this.BaseSecurityParam.updatedbyusername = reader.GetString(reader.GetOrdinal("UpdatedByUserName"));
                if (!reader.IsDBNull(reader.GetOrdinal("UpdatedDate"))) this.BaseSecurityParam.updateddate = reader.GetDateTime(reader.GetOrdinal("UpdatedDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("UpdateInfo"))) _updateinfo = reader.GetString(reader.GetOrdinal("UpdateInfo"));
                if (!reader.IsDBNull(reader.GetOrdinal("IPAddress"))) this.BaseSecurityParam.ipaddress = reader.GetString(reader.GetOrdinal("IPAddress"));
                if (!reader.IsDBNull(reader.GetOrdinal("TranFormActionID"))) _tranformactionid = reader.GetInt64(reader.GetOrdinal("TranFormActionID"));
                if (!reader.IsDBNull(reader.GetOrdinal("TS"))) this.BaseSecurityParam.ts = reader.GetInt64(reader.GetOrdinal("ts"));
                CurrentState = EntityState.Unchanged;
            }
        }
        
        #endregion
        
        
            
    }
}
