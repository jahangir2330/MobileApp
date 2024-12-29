using System;
using System.Runtime.Serialization;
using System.Data;
using BDO.Core.Base;
using System.ComponentModel.DataAnnotations;


namespace BDO.Core.DataAccessObjects.Models
{
    public partial class gen_servicedetailinfoEntity 
    {
        protected string _strParam;
        [DataMember]
        public string strParam
        {
            get { return _strParam; }
            set { _strParam = value; this.OnChnaged(); }
        }

        protected Guid? _userid;
        [DataMember]
        public Guid? userid
        {
            get { return _userid; }
            set { _userid = value; this.OnChnaged(); }
        }
    }
}
