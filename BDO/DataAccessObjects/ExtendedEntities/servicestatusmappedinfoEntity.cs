using System;
using System.Runtime.Serialization;
using System.Data;
using BDO.Core.Base;
using System.ComponentModel.DataAnnotations;


namespace BDO.Core.DataAccessObjects.Models
{
    public partial class servicestatusmappedinfoEntity
    {

        [DataMember]
        public bool? isExt { get; set; }

        protected string _ServiceAR;

        [DataMember]
        public string ServiceAR
        {
            get { return _ServiceAR; }
            set { _ServiceAR = value; this.OnChnaged(); }
        }

    }
}
