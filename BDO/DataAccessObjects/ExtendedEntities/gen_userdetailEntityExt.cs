using System;
using System.Runtime.Serialization;
using System.Data;
using BDO.Core.Base;
using System.ComponentModel.DataAnnotations;


namespace BDO.Core.DataAccessObjects.Models
{
    public partial class gen_userdetailEntity
    {
        #region Image
        [DataMember]
        public string largesignatureimage { get; set; }
        [DataMember]
        public string thumbssignatureimage { get; set; }
        [DataMember]
        public string base64signatureimage { get; set; }
        [DataMember]
        public string dimention_base64signatureimage { get; set; }
        [DataMember]
        public int cropwidthsignatureimage { get; set; } = 500;     
        [DataMember]
        public int cropheightsignatureimage { get; set; } = 188;   

        #endregion



    }
}
