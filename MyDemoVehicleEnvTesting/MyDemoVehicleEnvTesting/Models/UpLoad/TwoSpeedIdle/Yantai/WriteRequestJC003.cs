using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDemoVehicleEnvTesting.Models.UpLoad.TwoSpeedIdle.Yantai
{
    /// <summary>
    /// 烟台双怠速法检测结果数据
    /// </summary>
    public class WriteRequestJC003
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
        /// 环境温度
        /// </summary>
        public string wd { get; set; }
        /// <summary>
        /// 大气压
        /// </summary>
        public string dqy { get; set; }
        /// <summary>
        /// 相对湿度
        /// </summary>
        public string xdsd { get; set; }
        /// <summary>
        /// 过量空气系数限值下限
        /// </summary>
        public string lambdadown { get; set; }
        /// <summary>
        /// 过量空气系数限值上限
        /// </summary>
        public string lambdaup { get; set; }
        /// <summary>
        /// 过量空气系数结果
        /// </summary>
        public string lambda { get; set; }
        /// <summary>
        /// 过量空气系数判定
        /// </summary>
        public string lambdajudge { get; set; }
        /// <summary>
        /// 低怠速CO限值
        /// </summary>
        public string lscolimit { get; set; }
        /// <summary>
        /// 低怠速CO结果
        /// </summary>
        public string lscoresult { get; set; }
        /// <summary>
        /// 低怠速CO判定
        /// </summary>
        public string lscojudge { get; set; }
        /// <summary>
        /// 低怠速HC限值
        /// </summary>
        public string lshclimit { get; set; }
        /// <summary>
        /// 低怠速HC结果
        /// </summary>
        public string lshcresult { get; set; }
        /// <summary>
        /// 低怠速HC判定
        /// (怠速HC判定结果)
        /// </summary>
        public string lshcjudge { get; set; }
        /// <summary>
        /// 怠速转速
        /// </summary>
        public string dszs { get; set; }
        /// <summary>
        /// 怠速机油温度
        /// </summary>
        public string ddsjywd { get; set; }
        /// <summary>
        /// 高怠速CO限值
        /// </summary>
        public string hscolimit { get; set; }
        /// <summary>
        /// 高怠速CO结果
        /// </summary>
        public string hscoresult { get; set; }
        /// <summary>
        /// 高怠速CO判定
        /// </summary>
        public string hscojudge { get; set; }
        /// <summary>
        /// 高怠速HC结果
        /// </summary>
        public string hshcresult { get; set; }
        /// <summary>
        /// 高怠速HC限值
        /// </summary>
        public string hshclimit { get; set; }
        /// <summary>
        /// 高怠速HC判定
        /// </summary>
        public string hshcjudge { get; set; }
        /// <summary>
        /// 高怠速转速
        /// </summary>
        public string gdszs { get; set; }
        /// <summary>
        /// 高怠速机油温度
        /// </summary>
        public string gdsjywd { get; set; }
        /// <summary>
        /// 怠速CO修正值(摩托车)
        /// </summary>
        public string lscoresultxz { get; set; }
        /// <summary>
        /// 怠速CO修约值(摩托车)
        /// </summary>
        public string lscoresultxy { get; set; }
        /// <summary>
        /// 怠速CO2结果值(摩托车)
        /// </summary>
        public string lsco2result { get; set; }
        /// <summary>
        /// 怠速CO2修约值(摩托车)
        /// </summary>
        public string lsco2resultxy { get; set; }
        /// <summary>
        /// 怠速HC修约值(摩托车)
        /// </summary>
        public string lshcresultxy { get; set; }
        /// <summary>
        /// 高怠速CO修正值(摩托车)
        /// </summary>
        public string hscoresultxz { get; set; }
        /// <summary>
        /// 高怠速 CO 修约值(摩托车)
        /// </summary>
        public string hscoresultxy { get; set; }
        /// <summary>
        /// 高怠速CO2结果值(摩托车)
        /// </summary>
        public string hsco2result { get; set; }
        /// <summary>
        /// 高怠速CO2修约值(摩托车)
        /// </summary>
        public string hsco2resultxy { get; set; }
        /// <summary>
        /// 高怠速HC修约值(摩托车)
        /// </summary>
        public string hshcresultxy { get; set; }
        /// <summary>
        /// 总判定结果
        /// 0不合格1合格
        /// </summary>
        public string result { get; set; }
    }
}
