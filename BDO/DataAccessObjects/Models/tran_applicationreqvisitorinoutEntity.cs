using System;
using System.Runtime.Serialization;
using System.Data;
using BDO.Core.Base;
using System.ComponentModel.DataAnnotations;


namespace BDO.Core.DataAccessObjects.Models
{
    [Serializable]
    [DataContract(Name = "tran_applicationreqvisitorinoutEntity", Namespace = "http://www.KAF.com/types")]
    public partial class tran_applicationreqvisitorinoutEntity : BaseEntity
    {
        #region Properties
    
        protected long ? _visitorinoutinfoid;
        protected long ? _requestvisitorgateinfoid;
        protected DateTime ? _intime;
        protected string _inbyusername;
        protected string _inbymacaddress;
        protected DateTime ? _outtime;
        protected string _outbyusername;
        protected string _outbymacaddress;
        protected long ? _duration;
        protected string _notetext;
        protected string _updateinfo;
        protected long ? _tranformactionid;
                
        
        [DataMember]
        public long ? visitorinoutinfoid
        {
            get { return _visitorinoutinfoid; }
            set { _visitorinoutinfoid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "requestvisitorgateinfoid", ResourceType = typeof(CLL.LLClasses.Models._tran_applicationreqvisitorinout))]
        public long ? requestvisitorgateinfoid
        {
            get { return _requestvisitorgateinfoid; }
            set { _requestvisitorgateinfoid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "intime", ResourceType = typeof(CLL.LLClasses.Models._tran_applicationreqvisitorinout))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._tran_applicationreqvisitorinout), ErrorMessageResourceName = "intimeRequired")]
        public DateTime ? intime
        {
            get { return _intime; }
            set { _intime = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(150)]
        [Display(Name = "inbyusername", ResourceType = typeof(CLL.LLClasses.Models._tran_applicationreqvisitorinout))]
        public string inbyusername
        {
            get { return _inbyusername; }
            set { _inbyusername = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(50)]
        [Display(Name = "inbymacaddress", ResourceType = typeof(CLL.LLClasses.Models._tran_applicationreqvisitorinout))]
        public string inbymacaddress
        {
            get { return _inbymacaddress; }
            set { _inbymacaddress = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "outtime", ResourceType = typeof(CLL.LLClasses.Models._tran_applicationreqvisitorinout))]
        public DateTime ? outtime
        {
            get { return _outtime; }
            set { _outtime = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(150)]
        [Display(Name = "outbyusername", ResourceType = typeof(CLL.LLClasses.Models._tran_applicationreqvisitorinout))]
        public string outbyusername
        {
            get { return _outbyusername; }
            set { _outbyusername = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(50)]
        [Display(Name = "outbymacaddress", ResourceType = typeof(CLL.LLClasses.Models._tran_applicationreqvisitorinout))]
        public string outbymacaddress
        {
            get { return _outbymacaddress; }
            set { _outbymacaddress = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "duration", ResourceType = typeof(CLL.LLClasses.Models._tran_applicationreqvisitorinout))]
        public long ? duration
        {
            get { return _duration; }
            set { _duration = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(550)]
        [Display(Name = "notetext", ResourceType = typeof(CLL.LLClasses.Models._tran_applicationreqvisitorinout))]
        public string notetext
        {
            get { return _notetext; }
            set { _notetext = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(550)]
        [Display(Name = "updateinfo", ResourceType = typeof(CLL.LLClasses.Models._tran_applicationreqvisitorinout))]
        public string updateinfo
        {
            get { return _updateinfo; }
            set { _updateinfo = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "tranformactionid", ResourceType = typeof(CLL.LLClasses.Models._tran_applicationreqvisitorinout))]
        public long ? tranformactionid
        {
            get { return _tranformactionid; }
            set { _tranformactionid = value; this.OnChnaged(); }
        }
        
        
        #endregion
    
        #region Constructor
    
        public tran_applicationreqvisitorinoutEntity():base()
        {
        }
        
        public tran_applicationreqvisitorinoutEntity(IDataReader reader)
        {
            this.LoadFromReader(reader);
        }
        
         public tran_applicationreqvisitorinoutEntity(IDataReader reader, bool IsListViewShow)
        {
            this.LoadFromReader(reader, IsListViewShow);
        }
        
      
        
        protected void LoadFromReader(IDataReader reader)
        {
            if (reader != null && !reader.IsClosed)
            {
                this.BaseSecurityParam = new SecurityCapsule();
                if (!reader.IsDBNull(reader.GetOrdinal("VisitorInOutInfoID"))) _visitorinoutinfoid = reader.GetInt64(reader.GetOrdinal("VisitorInOutInfoID"));
                if (!reader.IsDBNull(reader.GetOrdinal("RequestVisitorGateInfoID"))) _requestvisitorgateinfoid = reader.GetInt64(reader.GetOrdinal("RequestVisitorGateInfoID"));
                if (!reader.IsDBNull(reader.GetOrdinal("InTime"))) _intime = reader.GetDateTime(reader.GetOrdinal("InTime"));
                if (!reader.IsDBNull(reader.GetOrdinal("InByUserName"))) _inbyusername = reader.GetString(reader.GetOrdinal("InByUserName"));
                if (!reader.IsDBNull(reader.GetOrdinal("InByMacAddress"))) _inbymacaddress = reader.GetString(reader.GetOrdinal("InByMacAddress"));
                if (!reader.IsDBNull(reader.GetOrdinal("OutTime"))) _outtime = reader.GetDateTime(reader.GetOrdinal("OutTime"));
                if (!reader.IsDBNull(reader.GetOrdinal("OutByUserName"))) _outbyusername = reader.GetString(reader.GetOrdinal("OutByUserName"));
                if (!reader.IsDBNull(reader.GetOrdinal("OutByMacAddress"))) _outbymacaddress = reader.GetString(reader.GetOrdinal("OutByMacAddress"));
                if (!reader.IsDBNull(reader.GetOrdinal("Duration"))) _duration = reader.GetInt64(reader.GetOrdinal("Duration"));
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
                CurrentState = EntityState.Unchanged;
            }
        }


        protected void LoadFromReader(IDataReader reader, bool IsListViewShow)
        {
            if (reader != null && !reader.IsClosed)
            {
                this.BaseSecurityParam = new SecurityCapsule();
                if (!reader.IsDBNull(reader.GetOrdinal("VisitorInOutInfoID"))) _visitorinoutinfoid = reader.GetInt64(reader.GetOrdinal("VisitorInOutInfoID"));
                if (!reader.IsDBNull(reader.GetOrdinal("RequestVisitorGateInfoID"))) _requestvisitorgateinfoid = reader.GetInt64(reader.GetOrdinal("RequestVisitorGateInfoID"));
                if (!reader.IsDBNull(reader.GetOrdinal("InTime"))) _intime = reader.GetDateTime(reader.GetOrdinal("InTime"));
                if (!reader.IsDBNull(reader.GetOrdinal("InByUserName"))) _inbyusername = reader.GetString(reader.GetOrdinal("InByUserName"));
                if (!reader.IsDBNull(reader.GetOrdinal("InByMacAddress"))) _inbymacaddress = reader.GetString(reader.GetOrdinal("InByMacAddress"));
                if (!reader.IsDBNull(reader.GetOrdinal("OutTime"))) _outtime = reader.GetDateTime(reader.GetOrdinal("OutTime"));
                if (!reader.IsDBNull(reader.GetOrdinal("OutByUserName"))) _outbyusername = reader.GetString(reader.GetOrdinal("OutByUserName"));
                if (!reader.IsDBNull(reader.GetOrdinal("OutByMacAddress"))) _outbymacaddress = reader.GetString(reader.GetOrdinal("OutByMacAddress"));
                if (!reader.IsDBNull(reader.GetOrdinal("Duration"))) _duration = reader.GetInt64(reader.GetOrdinal("Duration"));
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
                CurrentState = EntityState.Unchanged;
            }
        }
        
        #endregion
        
        
            
    }
}
