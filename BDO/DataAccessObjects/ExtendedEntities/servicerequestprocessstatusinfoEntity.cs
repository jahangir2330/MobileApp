using System;
using System.Runtime.Serialization;
using System.Data;
using BDO.Core.Base;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using BDO.Core.DataAccessObjects.CommonEntities;

namespace BDO.Core.DataAccessObjects.Models
{
    public partial class servicerequestprocessstatusinfoEntity
    {
        #region Properties
        protected DateTime? _requestdateto;
        protected string _servicear;
        protected string _serviceen;
        protected string _servicestatusar;
        protected string _servicestatusen;

        public List<servicerequestprocessstatusinfohistEntity> servicerequestprocessstatusinfohistList { get; set; }


        [DataMember]
        public DateTime? requestdateto
        {
            get { return _requestdateto; }
            set { _requestdateto = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "servicear", ResourceType = typeof(CLL.LLClasses.Models._gen_serviceinfo))]
        public string servicear
        {
            get { return _servicear; }
            set { _servicear = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "serviceen", ResourceType = typeof(CLL.LLClasses.Models._gen_serviceinfo))]
        public string serviceen
        {
            get { return _serviceen; }
            set { _serviceen = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "servicestatusar", ResourceType = typeof(CLL.LLClasses.Models._gen_servicestatus))]
        public string servicestatusar
        {
            get { return _servicestatusar; }
            set { _servicestatusar = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "servicestatusen", ResourceType = typeof(CLL.LLClasses.Models._gen_servicestatus))]
        public string servicestatusen
        {
            get { return _servicestatusen; }
            set { _servicestatusen = value; this.OnChnaged(); }
        }
        #endregion


        public servicerequestprocessstatusinfoEntity(IDataReader reader, bool states, int i, int ii)
        {
            this.LoadFromReader(reader, states, i, ii);
        }
        protected void LoadFromReader(IDataReader reader, bool IsListViewShow, int i, int ii)
        {
            if (reader != null && !reader.IsClosed)
            {
                this.BaseSecurityParam = new SecurityCapsule();
                if (!reader.IsDBNull(reader.GetOrdinal("ServiceStatusAR"))) _servicestatusar = reader.GetString(reader.GetOrdinal("ServiceStatusAR"));
                if (!reader.IsDBNull(reader.GetOrdinal("ServiceID"))) _serviceid = reader.GetInt64(reader.GetOrdinal("ServiceID"));
                if (!reader.IsDBNull(reader.GetOrdinal("ServiceRequestID"))) _servicerequestid = reader.GetInt64(reader.GetOrdinal("ServiceRequestID"));
            }
        }

    }

    public partial class DTservicerequestprocessstatusinfoEntity :DtParameters
    {
        public long? servicerequestid { get; set; }
        public long? serviceid { get; set; }
        public DateTime? requestdate { get; set; }
        public long? applicantcivilid { get; set; }
        public string applicantnote { get; set; }
        public long? servicestatusid { get; set; }
        public string servicestatuschangenote { get; set; }
        public string servicestatuschangedby { get; set; }
        public DateTime? servicestatuschangeddate { get; set; }
    }
}
