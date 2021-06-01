using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDemoVehicle.Model
{
    public class Lighting
    {
        #region 灯光
        /// <summary>
        /// 左灯远光发光强度
        /// </summary>
        public string LeftHighBeamIntensity { get; set; }
        /// <summary>
        /// 右灯远光发光强度
        /// </summary>
        public string RightHighBeamIntensity { get; set; }
        /// <summary>
        /// 左远光灯灯高
        /// </summary>
        public string HeightOfLeftHighBeam { get; set; }
        /// <summary>
        /// 右远光灯灯高
        /// </summary>
        public string HeightOfRightHighBeam { get; set; }
        /// <summary>
        /// 左远光灯水平偏移
        /// </summary>
        public string HShiftOfLeftHighBeam { get; set; }
        /// <summary>
        /// 右远光灯水平偏移
        /// </summary>
        public string HShiftOfRightHighBeam { get; set; }
        /// <summary>
        /// 左远光灯垂直偏移
        /// </summary>
        public string VShiftOfLeftHighBeam { get; set; }
        /// <summary>
        /// 右远光灯垂直偏移
        /// </summary>
        public string VShiftOfRightHighBeam { get; set; }
        /// <summary>
        /// 左近光灯高
        /// </summary>
        public string HeightOfLeftLowBeam { get; set; }
        /// <summary>
        /// 右近光灯高
        /// </summary>
        public string HeightOfRightLowBeam { get; set; }
        /// <summary>
        /// 左近光灯水平偏移
        /// </summary>
        public string HShiftOfLeftLowBeam { get; set; }
        /// <summary>
        /// 右近光灯水平偏移
        /// </summary>
        public string HShiftOfRightLowBeam { get; set; }
        /// <summary>
        /// 左远光灯垂直偏移
        /// </summary>
        public string VShiftOfLeftLowBeam { get; set; }
        /// <summary>
        /// 右远光灯垂直偏移
        /// </summary>
        public string VShiftOfRightLowBeam { get; set; }
        #endregion
    }
}
