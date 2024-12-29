using System;
using System.Collections.Generic;
using System.Text;

namespace BDO.Core.DataAccessObjects.ExtendedEntities
{
    public class ApplicationGlobalSettings
    {
        public string ApplicationRootUrl { get; set; }
        public string PassResetURL { get; set; }
        public string ApplicationID { get; set; }
        public string FeeOnlyPerson { get; set; }
        public string FeePersonWithVehicle { get; set; }
        public string FeePerWeek { get; set; }
        public string ApplicationFee { get; set; }
    }
}
