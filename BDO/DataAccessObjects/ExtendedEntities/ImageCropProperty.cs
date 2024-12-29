using System;
using System.Collections.Generic;
using System.Text;

namespace BDO.Core.DataAccessObjects.ExtendedEntities
{
    public class ImageCropProperty
    {
        public string inputid { get; set; }
        public string labeltext { get; set; }
        public int cropwidth { get; set; }
        public int cropheight { get; set; }
        public int thumbimagemaxlength { get; set; }
        public bool isrequired { get; set; }
        //public string aspectratio { get; set; }
    }
}
