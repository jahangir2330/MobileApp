using System;
using System.Runtime.Serialization;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace BDO.Core.DataAccessObjects.ReportEntity
{
    [Serializable]
    //[DataContract(Name = "rpt_requestemployee", Namespace = "http://www.KAF.com/types")]
    public partial class rpt_visitor
    {
        #region Properties

       
        [DataMember]
        public long? requestvisitorid
        {
            get; set;
        }

        [DataMember]
        public string fullname
        {
            get; set;
        }

        [DataMember]
        public string fullnameen
        {
            get; set;
        }

        [DataMember]
        public long? nationalityid
        {
            get; set;
        }

        [DataMember]
        public string jobtitle
        {
            get; set;
        }

        [DataMember]
        public long? idtype
        {
            get; set;
        }

        [DataMember]
        public string civilidnumber
        {
            get; set;
        }

        [DataMember]
        public DateTime? civilidexpirydate
        {
            get; set;
        }

        [DataMember]
        public string passportnumber
        {
            get; set;
        }

        [DataMember]
        public string carnumberplate
        {
            get; set;
        }

        [DataMember]
        public string reason
        {
            get; set;
        }

        [DataMember]
        public string civilidimagepath
        {
            get; set;
        }

        [DataMember]
        public bool? isactive
        {
            get; set;
        }


        [DataMember]
        public DateTime? startdate
        {
            get; set;
        }

        [DataMember]
        public DateTime? enddate
        {
            get; set;
        }
        [DataMember]
        public DateTime? approveddate
        {
            get; set;
        }
        [DataMember]
        public DateTime? personextentionenddate
        {
            get; set;
        }
        [DataMember]
        [MaxLength(1550)]
        public string gatenamesstring
        {
            get; set;
        }
        [DataMember]
        [MaxLength(1550)]
        public string gatenamesarabicstring
        {
            get; set;
        }

        [DataMember]
        public string timingnote
        {
            get; set;
        }
        [DataMember]
        public long? approvedbymasteruserid { get; set; }
        [DataMember]
        public string approvedbyusername { get; set; }
        [DataMember]
        public string approvedbysignature { get; set; }
        public string nationalityname { get; set; }
        public string nationalitynamear { get; set; }
        public string qrcode { get; set; }

        [DataMember]
        public bool canenterafteroffice
        {
            get; set;
        }
        [DataMember]
        public string canenterafterofficetext
        {
            get; set;
        }
        [DataMember]
        public string canenterafterofficetextar
        {
            get; set;
        }
        [DataMember]
        public bool hastimingnote
        {
            get; set;
        }
        #endregion

        #region Constructor

        public rpt_visitor() : base()
        {
        }

        #endregion
    }
}
