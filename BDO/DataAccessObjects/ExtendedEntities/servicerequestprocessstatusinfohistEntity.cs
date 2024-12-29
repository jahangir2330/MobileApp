using System;
using System.Runtime.Serialization;
using System.Data;
using BDO.Core.Base;
using System.ComponentModel.DataAnnotations;


namespace BDO.Core.DataAccessObjects.Models
{
    public partial class servicerequestprocessstatusinfohistEntity 
    {
        #region Properties
    
        protected string _servicestatusar;
                
        [DataMember]
        public string servicestatusar
        {
            get { return _servicestatusar; }
            set { _servicestatusar = value; this.OnChnaged(); }
        }
        
        
        #endregion
    
        
        
        
            
    }
}
