using System;
using System.Runtime.Serialization;
using System.Data;
using BDO.Core.Base;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace BDO.Core.DataAccessObjects.Models
{
    public partial class gen_companyEntity
    {
        protected List<gen_companyblockhistoryEntity> _blockhisthories;

        [DataMember]       
        public List<gen_companyblockhistoryEntity> blockhisthories
        {
            get { return _blockhisthories; }
            set { _blockhisthories = value; }
        }


    }
}
