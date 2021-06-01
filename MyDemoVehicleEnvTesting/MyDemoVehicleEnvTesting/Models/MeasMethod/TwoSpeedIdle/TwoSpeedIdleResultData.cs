using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDemoVehicleEnvTesting.Models.MeasMethod.TwoSpeedIdle
{
    /// <summary>
    /// 双怠速法结果数据
    /// </summary>
    public class TwoSpeedIdleResultData
    {
        /// <summary>
        /// 过量空气系数限值下限
        /// Excess air coefficient Lower limit
        /// </summary>
        public string ExcAirCoeffLowerLimit { get; set; }
        /// <summary>
        /// 过量空气系数限值上限
        /// Excess air coefficient Upper limit
        /// </summary>
        public string ExcAirCoeffUpperLimit { get; set; }
        /// <summary>
        /// 过量空气系数检测结果
        /// Excess air coefficient Result
        /// </summary>
        public string ExcAirCoeffResult { get; set; }
        /// <summary>
        /// 过量空气系数判定结果
        /// Excess air coefficient judgement value
        /// </summary>
        public string ExcAirCoeffJudgVal { get; set; }
        /// <summary>
        /// 低怠速CO限值
        /// low-idle CO limit value
        /// </summary>
        public string LowIdleCOLimitVal { get; set; }
        /// <summary>
        /// 低怠速CO检测结果
        /// low-idle CO result
        /// </summary>
        public string LowIdleCOResult { get; set; }
        /// <summary>
        /// 低怠速CO判定
        /// low-idle CO judgment value
        /// </summary>
        public string LowIdleCOJudgVal { get; set; }
        /// <summary>
        /// 低怠速HC限值
        /// low-idle HC limit value
        /// </summary>
        public string LowIdleHCLimitVal { get; set; }
        /// <summary>
        /// 低怠速HC结果
        /// low-idle HC result
        /// </summary>
        public string LowIdleHCResult { get; set; }
        /// <summary>
        /// 低怠速HC判定
        /// low-idle HC judgment value
        /// </summary>
        public string LowIdleHCJudgVal { get; set; }
        /// <summary>
        /// 怠速转速
        /// Idle Speed
        /// </summary>
        public string IdleSpeed { get; set; }
        /// <summary>
        /// 怠速机油温度
        /// idle oil temperature
        /// </summary>
        public string IdleOilTemp { get; set; }
        /// <summary>
        /// 高怠速CO限值
        /// high-idle CO limit value
        /// </summary>
        public string HighIdleCOLimitVal { get; set; }
        /// <summary>
        /// 高怠速CO检测结果
        /// high-idle CO result
        /// </summary>
        public string HighIdleCOResult { get; set; }
        /// <summary>
        /// 高怠速CO判定
        /// high-idle CO judgment value
        /// </summary>
        public string HighIdleCOJudgVal { get; set; }
        /// <summary>
        /// 高怠速HC限值
        /// high-idle HC limit value
        /// </summary>
        public string HighIdleHCLimitVal { get; set; }
        /// <summary>
        /// 高怠速HC检测结果
        /// high-idle HC result
        /// </summary>
        public string HighIdleHCResult { get; set; }
        /// <summary>
        /// 高怠速HC判定
        /// high-idle HC judgment value
        /// </summary>
        public string HighIdleHCJudgVal { get; set; }
        /// <summary>
        /// 高怠速转速
        /// high Idle Speed
        /// </summary>
        public string HighIdleSpeed { get; set; }
        /// <summary>
        /// 高怠速机油温度
        /// high idle oil temperature
        /// </summary>
        public string HighIdleOilTemp { get; set; }
        /// <summary>
        /// 怠速CO修正值
        /// </summary>
        public string IdleCOCorrectedVal { get; set; }
        /// <summary>
        /// 怠速CO修约值
        /// idle CO rounding off numerical values
        /// </summary>
        public string IdleCORoundingOffNumerVal { get; set; }
        /// <summary>
        /// 怠速CO2结果值
        /// 28.idle CO2 Result
        /// </summary>
        public string IdleCO2Result { get; set; }
        /// <summary>
        /// 怠速CO2修约值
        /// idle CO2 rounding off numerical values
        /// </summary>
        public string IdleCO2RoundingOffNumerVal { get; set; }
        /// <summary>
        /// 怠速HC修约值
        /// idle HC rounding off numerical values
        /// </summary>
        public string IdleHCRoundingOffNumerVal { get; set; }
        /// <summary>
        /// 高怠速CO修正值
        /// high-idle CO Corrected value
        /// </summary>
        public string HighIdleCOCorrectedVal { get; set; }
        /// <summary>
        /// 高怠速CO修约值 
        /// high-idle CO rounding off numerical values
        /// </summary>
        public string HighIdleCORoundingOffNumerVal { get; set; }
        /// <summary>
        /// 高怠速CO2结果值 
        /// high-idle CO2 Result
        /// </summary>
        public string HighIdleCO2Result { get; set; }
        /// <summary>
        /// 高怠速CO2 修约值 
        /// high-idle CO2 rounding off numerical values
        /// </summary>
        public string HighIdleCO2RoundingOffNumerVal { get; set; }
        /// <summary>
        /// 高怠速HC修约值 
        /// high-idle HC rounding off numerical values
        /// </summary>
        public string HighIdleHCRoundingOffNumerVal { get; set; }
        /// <summary>
        /// 总判定结果
        /// </summary>
        public string Result { get; set; }
        /// <summary>
        /// 双怠速法开始测试时间
        /// </summary>
        public DateTime StartTime { get; set; }
        /// <summary>
        /// 双怠速法结束测试时间
        /// </summary>
        public DateTime EndTime { get; set; }
    }
}
