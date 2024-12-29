using System;
using System.Runtime.Serialization;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace BDO.Core.DataAccessObjects.ReportEntity
{
    [Serializable]
    //[DataContract(Name = "rpt_vehicleinfo", Namespace = "http://www.KAF.com/types")]
    public partial class rpt_vehicleinfo
    {
        #region Properties
        [DataMember]
        public long? vehicleinfoid
        {
            get; set;
        }

        [DataMember]
        public long? requestvehicleid
        {
            get; set;
        }

        [DataMember]
        public string carnumberplate
        {
            get; set;
        }

        [DataMember]
        public string vehiclecategoryname
        {
            get; set;
        }
        [DataMember]
        public string vehiclecategorynamear
        {
            get; set;
        }

        [DataMember]
        public string vehiclebrandname
        {
            get; set;
        }
        [DataMember]
        public string vehiclebrandnamear
        {
            get; set;
        }

        [DataMember]
        public string vehiclemodelname
        {
            get; set;
        }
        [DataMember]
        public string vehiclemodelnamear
        {
            get; set;
        }

        [DataMember]
        public string vehiclecolorname
        {
            get; set;
        }
        [DataMember]
        public string vehiclecolornamear
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
        public DateTime? vehicleextentionenddate
        {
            get; set;
        }
        [DataMember]
        public string gatenamesstring
        {
            get; set;
        }
        [DataMember]
        public string gatenamesarabicstring
        {
            get; set;
        }

        [DataMember]
        public string timingnote
        {
            get; set;
        }
       
      
        public string approvedbysignature { get; set; }
        public string companyname { get; set; }
        public string companynamear { get; set; }

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

        public rpt_vehicleinfo() : base()
        {
        }

        #endregion
    }
}
