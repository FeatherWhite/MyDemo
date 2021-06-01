using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDemoVehicleEnvTesting.Models.UpLoad.TwoSpeedIdle.Yantai
{
    /// <summary>
    /// 烟台双怠速法检测过程数据
    /// </summary>
    public class WriteRequestGC003
    {
        /// <summary>
        /// 检验流水号
        /// </summary>
        public string jylsh { get; set; }
        /// <summary>
        /// 检验次数
        /// </summary>
        public string testtimes { get; set; }
        /// <summary>
        /// 采样总点数
        /// </summary>
        public string cyds { get; set; }
        /// <summary>
        /// 采样时序
        /// </summary>
        public string cysx { get; set; }
        /// <summary>
        /// HC测量值
        /// </summary>
        public string hcclz { get; set; }
        /// <summary>
        /// 转速
        /// </summary>
        public string zs { get; set; }
        /// <summary>
        /// CO测量值
        /// </summary>
        public string coclz { get; set; }
        /// <summary>
        /// 过量空气系数
        /// </summary>
        public string glkqxs { get; set; }
        /// <summary>
        /// 油温
        /// </summary>
        public string yw { get; set; }
        /// <summary>
        /// CO2测量值
        /// </summary>
        public string co2clz { get; set; }
        /// <summary>
        /// O2测量值
        /// </summary>
        public string o2clz { get; set; }
        /// <summary>
        /// 环境温度
        /// </summary>
        public string hjwd { get; set; }
        /// <summary>
        /// 大气压力
        /// </summary>
        public string dqyl { get; set; }
        /// <summary>
        /// 相对湿度
        /// </summary>
        public string xdsd { get; set; }
        /// <summary>
        /// 全程时序
        /// </summary>
        public string sjxl { get; set; }
        /// <summary>
        /// 检测时间
        /// </summary>
        public string jcsj { get; set; }
        /// <summary>
        /// 工况时间
        /// </summary>
        public string gksj { get; set; }
        /// <summary>
        /// 工况类型
        /// </summary>
        public string jczt { get; set; }
    }
}
