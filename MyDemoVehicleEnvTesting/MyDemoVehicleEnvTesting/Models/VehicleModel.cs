using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDemoVehicleEnvTesting.Models
{
    public class VehicleModel
    {
        /// <summary>
        /// 检验流水号 
        /// </summary>
        public string InspectionSerialNumber { get; set; }
        /// <summary>
        /// 检验次数
        /// </summary>
        public string TestTimes { get; set; }
    }
}
