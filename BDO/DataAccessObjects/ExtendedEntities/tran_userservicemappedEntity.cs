using System;
using System.Runtime.Serialization;
using System.Data;
using BDO.Core.Base;
using System.ComponentModel.DataAnnotations;


namespace BDO.Core.DataAccessObjects.Models
{
    public partial class tran_userservicemappedEntity
    {

        [DataMember]
        public bool? isExt { get; set; }

        protected long ? _masteruserid;
                
        [DataMember]
        public long ? masteruserid
        {
            get { return _masteruserid; }
            set { _masteruserid = value; this.OnChnaged(); }
        }

        protected string _username;

        [DataMember]
        public string username
        {
            get { return _username; }
            set { _username = value; this.OnChnaged(); }
        }
        protected string _rolename;

        [DataMember]
        public string rolename
        {
            get { return _rolename; }
            set { _rolename = value; this.OnChnaged(); }
        }
    }
}
