using System;
using System.Runtime.Serialization;
using System.Data;
using BDO.Core.Base;
using System.ComponentModel.DataAnnotations;


namespace BDO.Core.DataAccessObjects.Models
{
    [Serializable]
    [DataContract(Name = "tran_applicationreqforempnotesEntity", Namespace = "http://www.KAF.com/types")]
    public partial class tran_applicationreqforempnotesEntity : BaseEntity
    {
        #region Properties

        protected long? _requestapplicationnoteid;
        protected long? _requestapplicationid;
        protected long? _statusid;
        protected string _notetext;
        protected DateTime? _submittedtime;
        protected long? _masteruserid;
        protected string _updateinfo;
        protected long? _tranformactionid;


        [DataMember]
        public long? requestapplicationnoteid
        {
            get { return _requestapplicationnoteid; }
            set { _requestapplicationnoteid = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "requestapplicationid", ResourceType = typeof(CLL.LLClasses.Models._tran_applicationreqforempnotes))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses.Models._tran_applicationreqforemp), ErrorMessageResourceName = "requestapplicationidRequired")]
        public long? requestapplicationid
        {
            get { return _requestapplicationid; }
            set { _requestapplicationid = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "statusid", ResourceType = typeof(CLL.LLClasses.Models._tran_applicationreqforempnotes))]
        public long? statusid
        {
            get { return _statusid; }
            set { _statusid = value; this.OnChnaged(); }
        }

        [DataMember]
        [MaxLength(550)]
        [Display(Name = "notetext", ResourceType = typeof(CLL.LLClasses.Models._tran_applicationreqforempnotes))]
        public string notetext
        {
            get { return _notetext; }
            set { _notetext = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "submittedtime", ResourceType = typeof(CLL.LLClasses.Models._tran_applicationreqforempnotes))]
        public DateTime? submittedtime
        {
            get { return _submittedtime; }
            set { _submittedtime = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "masteruserid", ResourceType = typeof(CLL.LLClasses.Models._tran_applicationreqforempnotes))]
        public long? masteruserid
        {
            get { return _masteruserid; }
            set { _masteruserid = value; this.OnChnaged(); }
        }

        [DataMember]
        [MaxLength(550)]
        [Display(Name = "updateinfo", ResourceType = typeof(CLL.LLClasses.Models._tran_applicationreqforempnotes))]
        public string updateinfo
        {
            get { return _updateinfo; }
            set { _updateinfo = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "tranformactionid", ResourceType = typeof(CLL.LLClasses.Models._tran_applicationreqforempnotes))]
        public long? tranformactionid
        {
            get { return _tranformactionid; }
            set { _tranformactionid = value; this.OnChnaged(); }
        }


        #endregion

        #region Constructor

        public tran_applicationreqforempnotesEntity() : base()
        {
        }

        public tran_applicationreqforempnotesEntity(IDataReader reader)
        {
            this.LoadFromReader(reader);
        }

        public tran_applicationreqforempnotesEntity(IDataReader reader, bool IsListViewShow)
        {
            this.LoadFromReader(reader, IsListViewShow);
        }



        protected void LoadFromReader(IDataReader reader)
        {
            if (reader != null && !reader.IsClosed)
            {
                this.BaseSecurityParam = new SecurityCapsule();
                if (!reader.IsDBNull(reader.GetOrdinal("RequestApplicationNoteID"))) _requestapplicationnoteid = reader.GetInt64(reader.GetOrdinal("RequestApplicationNoteID"));
                if (!reader.IsDBNull(reader.GetOrdinal("RequestApplicationID"))) _requestapplicationid = reader.GetInt64(reader.GetOrdinal("RequestApplicationID"));
                if (!reader.IsDBNull(reader.GetOrdinal("StatusId"))) _statusid = reader.GetInt64(reader.GetOrdinal("StatusId"));
                if (!reader.IsDBNull(reader.GetOrdinal("NoteText"))) _notetext = reader.GetString(reader.GetOrdinal("NoteText"));
                if (!reader.IsDBNull(reader.GetOrdinal("SubmittedTime"))) _submittedtime = reader.GetDateTime(reader.GetOrdinal("SubmittedTime"));
                if (!reader.IsDBNull(reader.GetOrdinal("MasterUserId"))) _masteruserid = reader.GetInt64(reader.GetOrdinal("MasterUserId"));
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
                if (!reader.IsDBNull(reader.GetOrdinal("RequestApplicationNoteID"))) _requestapplicationnoteid = reader.GetInt64(reader.GetOrdinal("RequestApplicationNoteID"));
                if (!reader.IsDBNull(reader.GetOrdinal("RequestApplicationID"))) _requestapplicationid = reader.GetInt64(reader.GetOrdinal("RequestApplicationID"));
                if (!reader.IsDBNull(reader.GetOrdinal("StatusId"))) _statusid = reader.GetInt64(reader.GetOrdinal("StatusId"));
                if (!reader.IsDBNull(reader.GetOrdinal("NoteText"))) _notetext = reader.GetString(reader.GetOrdinal("NoteText"));
                if (!reader.IsDBNull(reader.GetOrdinal("SubmittedTime"))) _submittedtime = reader.GetDateTime(reader.GetOrdinal("SubmittedTime"));
                if (!reader.IsDBNull(reader.GetOrdinal("MasterUserId"))) _masteruserid = reader.GetInt64(reader.GetOrdinal("MasterUserId"));
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
