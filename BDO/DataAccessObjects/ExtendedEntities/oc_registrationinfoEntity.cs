using System;
using System.Runtime.Serialization;
using System.Data;
using BDO.Core.Base;
using System.ComponentModel.DataAnnotations;


namespace BDO.Core.DataAccessObjects.Models
{
    public partial class oc_registrationinfoEntity
    {
        protected DateTime? _registrationdatefrom;
        [DataMember]
        public DateTime? registrationdatefrom
        {
            get { return _registrationdatefrom; }
            set { _registrationdatefrom = value; this.OnChnaged(); }
        }

        protected DateTime? _registrationdateto;
        [DataMember]
        public DateTime? registrationdateto
        {
            get { return _registrationdateto; }
            set { _registrationdateto = value; this.OnChnaged(); }
        }

    }
}
