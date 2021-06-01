using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDemoVehicleEnvTesting.Models
{
    public class EnvironmentModel
    {
        /// <summary>
        /// 环境温度
        /// ambient temperature
        /// </summary>
        public string AmbientTemp { get; set; }
        /// <summary>
        /// 大气压
        /// atmospheric pressure
        /// </summary>
        public string AtmosphericPressure { get; set; }
        /// <summary>
        /// 相对湿度
        /// humidity
        /// </summary>
        public string Humidity { get; set; }
    }
}
