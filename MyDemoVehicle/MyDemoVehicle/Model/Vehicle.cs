using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDemoVehicle.Model
{
    public class Vehicle
    {
        /// <summary>
        /// 汽车品牌
        /// </summary>
        public string Brand { get; set; }
        /// <summary>
        /// 车型代号
        /// </summary>
        public string ModelCode { get; set; }
        /// <summary>
        /// 电机型号
        /// </summary>
        public string EngineModel { get; set; }
        /// <summary>
        /// vin码
        /// </summary>
        public string VinCode { get; set; }
        /// <summary>
        /// 电机号
        /// </summary>
        public string EngineNumber { get; set; }
        /// <summary>
        /// 车身颜色
        /// </summary>
        public string Color { get; set; }
        /// <summary>
        /// 执行标准
        /// </summary>
        public string ExeStandard { get; set; }
        /// <summary>
        /// 车型
        /// </summary>
        public string Model { get; set; }
        /// <summary>
        /// ABS型号
        /// </summary>
        public string ABSModel { get; set; }
        /// <summary>
        /// 燃油种类
        /// </summary>
        public string FuelType { get; set; }
        /// <summary>
        /// 驱动方式
        /// </summary>
        public string DriveType { get; set; }
        /// <summary>
        /// 检测编号
        /// </summary>
        public string TestNumber { get; set; }
        /// <summary>
        /// 车轮
        /// </summary>
        public Wheel Wheel { get; set; }
        /// <summary>
        /// 灯光
        /// </summary>
        public Lighting Lighting { get; set; }
        /// <summary>
        /// 声级
        /// </summary>
        public string SoundLevels { get; set; }
        /// <summary>
        /// 主销后倾角
        /// </summary>
        public float KingPinCasterAngle { get; set; }
    }
}
