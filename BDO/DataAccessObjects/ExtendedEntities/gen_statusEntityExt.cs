using System;
using System.Runtime.Serialization;
using System.Data;
using BDO.Core.Base;
using System.ComponentModel.DataAnnotations;


namespace BDO.Core.DataAccessObjects.Models
{

    public partial class gen_statusEntity
    {
        private string _rolename { get; set; }

        [DataMember]
        [MaxLength(150)]
        //[Display(Name = "statusname", ResourceType = typeof(CLL.LLClasses.Models._gen_status))]
        public string rolename
        {
            get { return _rolename; }
            set { _rolename = value; this.OnChnaged(); }
        }

        private long? _parentstatusid { get; set; }

        [DataMember]
        [MaxLength(150)]
        //@
        //[Display(Name = "statusname", ResourceType = typeof(CLL.LLClasses.Models._gen_status))]
        public long? parentstatusid
        {
            get { return _parentstatusid; }
            set { _parentstatusid = value; this.OnChnaged(); }
        }
    }
}
