using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDemoVehicle.Model
{
    public class Wheel
    {
        #region 车轮质量
        /// <summary>
        /// 左前轮的质量
        /// </summary>
        private int fLeftWheelAxleMass = 0;
        /// <summary>
        /// 左前轮的质量
        /// </summary>
        public int FrontLeftWheelAxleMass
        {
            get
            {
                if (fLeftWheelAxleMass < 100)
                {
                    throw new Exception("左前轮质量过轻,请重新称重");
                }
                return fLeftWheelAxleMass;
            }
            set
            {
                fLeftWheelAxleMass = value;
            }
        }
        /// <summary>
        /// 右前轮的质量
        /// </summary>
        private int fRightWheelAxleMass;
        /// <summary>
        /// 右前轮的质量
        /// </summary>
        public int FrontRightWheelAxleMass
        {
            get
            {
                if (fRightWheelAxleMass < 100)
                {
                    throw new Exception("右前轮质量过轻,请重新称重");
                }
                return fRightWheelAxleMass;
            }
            set
            {
                fRightWheelAxleMass = value;
            }
        }
        /// <summary>
        /// 左后轮的质量
        /// </summary>
        private int rLeftWheelAxleMass = 0;
        /// <summary>
        /// 左后轮的质量
        /// </summary>
        public int RearLeftWheelAxleMass
        {
            get
            {
                if (rLeftWheelAxleMass < 100)
                {
                    throw new Exception("左后轮质量过轻,请重新称重");
                }
                return rLeftWheelAxleMass;
            }
            set { rLeftWheelAxleMass = value; }
        }
        /// <summary>
        /// 右后轮的质量
        /// </summary>
        private int rRightWheelAxleMass;
        /// <summary>
        /// 右后轮的质量
        /// </summary>
        public int RearRightWheelAxleMass
        {
            get
            {
                if (rRightWheelAxleMass < 100)
                {
                    throw new Exception("右后轮质量过轻,请重新称重");
                }
                return rRightWheelAxleMass;
            }
            set { rRightWheelAxleMass = value; }
        }
        /// <summary>
        /// 前轮轴重
        /// </summary>
        public int FrontWheelAxleMass
        {
            get { return fLeftWheelAxleMass + fRightWheelAxleMass; }
        }
        /// <summary>
        /// 后轮轴重
        /// </summary>
        public int RearWheelAxleMass
        {
            get { return rLeftWheelAxleMass + rRightWheelAxleMass; }
        }
        /// <summary>
        /// 整车轴重=四个轮重相加
        /// </summary>
        public int VehicleAxleWheel
        {
            get
            {
                return fRightWheelAxleMass + fLeftWheelAxleMass
                    + rRightWheelAxleMass + rLeftWheelAxleMass;
            }
        }
        #endregion

        #region 前束
        /// <summary>
        /// 左前轮前束
        /// </summary>
        public float LeftFrontWheelToeAngle { get; set; }
        /// <summary>
        /// 右前轮前束
        /// </summary>
        public float RightFrontWheelToeAngle { get; set; }
        /// <summary>
        /// 左后轮前束
        /// </summary>
        public float LeftRearWheelToeAngle { get; set; }
        /// <summary>
        /// 右后轮前束
        /// </summary>
        public float RightRearWheelToeAngle { get; set; }
        #endregion

        #region 外倾
        /// <summary>
        /// 左前轮外倾角
        /// </summary>
        public float LeftFrontWheelCamberAngle { get; set; }
        /// <summary>
        /// 右前轮外倾角
        /// </summary>
        public float RightFrontWheelCamberAngle { get; set; }
        /// <summary>
        /// 左后轮外倾角
        /// </summary>
        public float LeftRearWheelCamberAngle { get; set; }
        /// <summary>
        /// 右后轮外倾角
        /// </summary>
        public float RightRearWheelCamberAngle { get; set; }
        #endregion
    }
}
