using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization;
using System.Data;
using BDO.Core.Base;
using System.ComponentModel.DataAnnotations;
using BDO.Core.DataAccessObjects.CommonEntities;
using KAF.BusinessDataObjects;

namespace BDO.Core.DataAccessObjects.Models
{
    [Serializable]
    [DataContract(Name = "applicationwithemployeevm", Namespace = "http://www.KAF.com/types")]

    public partial class applicationwithemployeevm :BaseEntity
    {
        #region Properties
        public tran_applicationreqforempEntity application { get; set; }
        public tran_applicationreqforempdetlEntity employee { get; set; }
        public List<tran_applicationreqforempdetlEntity> employeelist { get; set; }
        //public List<gen_exchangedocumentEntity> exchangedocumentlist { get; set; }
        #endregion
        public applicationwithemployeevm()
        {
            application= new tran_applicationreqforempEntity();
            employee= new tran_applicationreqforempdetlEntity();
            employeelist= new List<tran_applicationreqforempdetlEntity>();
           // exchangedocumentlist = new List<gen_exchangedocumentEntity>();
        }
    }

}
