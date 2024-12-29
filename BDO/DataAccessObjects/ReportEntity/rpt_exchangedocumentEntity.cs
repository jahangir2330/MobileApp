using System;
using System.Runtime.Serialization;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace BDO.Core.DataAccessObjects.ReportEntity
{
    [Serializable]
    //[DataContract(Name = "rpt_exchangedocumentEntity", Namespace = "http://www.KAF.com/types")]
    public partial class rpt_exchangedocumentEntity
    {
        #region Properties

        //protected long? _exchangedocumentid;
        //protected string _exchangedocumenttitlear;
        //protected string _exchangedocumenttitleen;
        //protected string _exchangedocumentdescar;
        //protected string _exchangedocumentdescen;
        //protected string _filepath;
        //protected string _filetype;
        //protected string _fileextension;
        //protected string _actualfilename;
        //protected string _filename;
        //protected string _qrcode;
        //protected bool? _isactive;
        //protected long? _requestapplicationid;

        [DataMember]
        public long? exchangedocumentid
        {
            get; set;
        }

        [DataMember]
        public string exchangedocumenttitlear
        {
            get; set;
        }

        [DataMember]
        public string exchangedocumenttitleen
        {
            get; set;
        }

        [DataMember]
        public string exchangedocumentdescar
        {
            get; set;
        }

        [DataMember]
        public string exchangedocumentdescen
        {
            get; set;
        }

        [DataMember]
        public string filepath
        {
            get; set;
        }

        [DataMember]
        public string filetype
        {
            get; set;
        }

        [DataMember]
        public string fileextension
        {
            get; set;
        }

        [DataMember]
        [MaxLength(-1)]
        [Display(Name = "actualfilename", ResourceType = typeof(CLL.LLClasses.Models._exchangedocument))]
        public string actualfilename
        {
            get; set;
        }

        [DataMember]
        public string filename
        {
            get; set;
        }

        [DataMember]
        public string qrcode
        {
            get; set;
        }


        [DataMember]
        public long? requestapplicationid
        {
            get; set;
        }
        [DataMember]
        [Display(Name = "isactive", ResourceType = typeof(CLL.LLClasses.Models._gen_requester))]
        public bool? isactive
        {
            get; set;
        }


        #endregion

        #region Constructor

        public rpt_exchangedocumentEntity() : base()
        {
        }

        #endregion
    }
}
