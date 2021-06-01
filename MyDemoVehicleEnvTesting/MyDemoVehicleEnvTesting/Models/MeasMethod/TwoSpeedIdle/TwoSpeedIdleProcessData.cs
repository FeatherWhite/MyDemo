using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDemoVehicleEnvTesting.Models.MeasMethod.TwoSpeedIdle
{
    /// <summary>
    /// 双怠速法过程数据
    /// </summary>
    public class TwoSpeedIdleProcessData
    {
        /// <summary>
        /// 采样总点数 
        /// Total sampling points
        /// </summary>
        public string TotalSamplingPoints { get; set; }
        /// <summary>
        /// 采样时序 
        /// sampling timing
        /// </summary>
        public string SamplingTiming { get; set; }
        /// <summary>
        /// HC测量值 
        /// HC measured value
        /// </summary>
        public string HCMeasVal { get; set; }
        /// <summary>
        /// 转速 
        /// revolution speed
        /// </summary>
        public string RevSpeed { get; set; }
        /// <summary>
        /// CO测量值 
        /// CO measured value
        /// </summary>
        public string COMeasVal { get; set; }
        /// <summary>
        /// 过量空气系数 
        /// Excess air coefficient
        /// </summary>
        public string ExcAirCoeff { get; set; }
        /// <summary>
        /// 油温 
        /// oil temperature
        /// </summary>
        public string OilTemp { get; set; }
        /// <summary>
        /// CO2测量值 
        /// CO2 measured value
        /// </summary>
        public string CO2MeasVal { get; set; }
        /// <summary>
        /// O2测量值 
        /// O2 measured value
        /// </summary>
        public string O2MeasVal { get; set; }
        /// <summary>
        /// 环境温度 
        /// ambient temperature
        /// </summary>
        public string AmbientTemp { get; set; }
        /// <summary>
        /// 大气压
        /// </summary>
        public string AtmosphericPressure { get; set; }
        /// <summary>
        /// 相对湿度
        /// </summary>
        public string Humidity { get; set; }
        /// <summary>
        /// 全程时序 
        /// Whole time sequence
        /// </summary>
        public string WholeTimeSeq { get; set; }
        /// <summary>
        /// 检测时间 
        /// detection time
        /// </summary>
        public string DetTime { get; set; }
        /// <summary>
        /// 工况时间 
        /// Operating time
        /// </summary>
        public string OperaTime { get; set; }
    }
}
