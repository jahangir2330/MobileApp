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
    [DataContract(Name = "applicationwithvehiclevm", Namespace = "http://www.KAF.com/types")]

    public partial class applicationwithvehiclevm : BaseEntity
    {
        #region Properties
        public tran_applicationreqforvehicleEntity application { get; set; }
        public tran_applicationreqforvehicledetlEntity vehicle { get; set; }
        public List<tran_applicationreqforvehicledetlEntity> vehiclelist { get; set; }
        #endregion
        public applicationwithvehiclevm()
        {
            application= new tran_applicationreqforvehicleEntity();
            vehicle = new tran_applicationreqforvehicledetlEntity();
            vehiclelist = new List<tran_applicationreqforvehicledetlEntity>();
        }
    }

}
