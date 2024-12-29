using System;
using System.Runtime.Serialization;
using System.Data;
using BDO.Core.Base;
using System.ComponentModel.DataAnnotations;
using BDO.DataAccessObjects.ExtendedEntities;
using System.Collections.Generic;

namespace BDO.Core.DataAccessObjects.Models
{
    [Serializable]
    [DataContract(Name = "trangrvfrontlinesubmitdataExEntity", Namespace = "http://www.KAF.com/types")]
    public partial class trangrvfrontlinesubmitdataExEntity : trangrvfrontlinesubmitdataEntity
    {


        protected List<trangrvfrontlinesubmitdatafilesEntity> _attachmentbaselist;
       
        [DataMember]
        public List<trangrvfrontlinesubmitdatafilesEntity> attachmentbaselist
        {
            get { return _attachmentbaselist; }
            set { _attachmentbaselist = value; }
        }
     



        public trangrvfrontlinesubmitdataExEntity():base()
        {
        }
        

       

    }
}
