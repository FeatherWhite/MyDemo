using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MyDemoVehicleEnvTesting.Util;
using System.IO;
using System.Net;
using System.Xml;
using System.Threading.Tasks;
using System.Reflection;
using System.Collections;
using System.Xml.Linq;
using System.Data;
using System.Runtime.InteropServices;
using System.Xml.Serialization;

namespace MyDemoVehicleEnvTesting.Service
{
    /// <summary>
    /// 烟台机动车排气检测监管平台
    /// </summary>
    public class YTInspectionStationWeb
    {
        //烟台机动车排气检测监管平台网址
        private string url;
        //接口标识
        private string interfaceID;
        public YTInspectionStationWeb(string url)
        {
            this.url = url;           
        }
        /// <summary>
        /// 测试用不要忘记注释掉
        /// </summary>
        public YTInspectionStationWeb()
        {
            
        }

        /// <summary>
        /// 向监管平台发送写入命令
        /// </summary>
        /// <param name="xmlDoc"></param>
        /// <returns></returns>
        public string Write(object[] args)
        {
            WebServiceHelper webSH = new WebServiceHelper();
            //调用监管平台的查询接口
            string methodName = "write";
            object resultObj = webSH.InvokeWebService(url, methodName, args);
            //服务器返回Url编码的Xml，对其解码
            string enCodeXml = (resultObj as string[])[0];
            string resultXml = WebUtility.UrlDecode(enCodeXml);
            return resultXml;
        }

        /// <summary>
        /// 向监管平台发送查询命令接收返回的结果
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public string Query(object[] args)
        {
            WebServiceHelper webSH = new WebServiceHelper();
            //调用监管平台的查询接口
            string methodName = "query";
            object resultObj = webSH.InvokeWebService(url,methodName,args);
            //服务器返回Url编码的Xml，对其解码
            string enCodeXml = (resultObj as string[])[0];
            string resultXml = WebUtility.UrlDecode(enCodeXml);
            return resultXml;
        }
        //#region 查询方法

        //#region 修改本地系统时间
        //[DllImport("Kernel32.dll")]
        //private extern static void GetSystemTime(ref SYSTEMTIME lpSystemTime);

        //[DllImport("Kernel32.dll")]
        //private extern static uint SetLocalTime(ref SYSTEMTIME lpSystemTime);

        //[StructLayout(LayoutKind.Sequential)]
        //private struct SYSTEMTIME
        //{
        //    public ushort wYear;
        //    public ushort wMonth;
        //    public ushort wDayOfWeek;
        //    public ushort wDay;
        //    public ushort wHour;
        //    public ushort wMinute;
        //    public ushort wSecond;
        //    public ushort wMilliseconds;
        //}

        ///// <summary>
        ///// 将本地时间服务器时间同步
        ///// </summary>
        ///// <param name="SqlServerTime">时间</param>
        //public uint SynchroTime()
        //{
        //    //服务器时间
        //    string[] xmlDoc = new string[1];
        //    interfaceID = "SJ001";
        //    xmlDoc[0] = CreateQCXmlDoc();
        //    string resXmlDoc = ReadXml(Query(xmlDoc));            
        //    DateTime ServerTime = Convert.ToDateTime(resXmlDoc);
        //    SYSTEMTIME st = new SYSTEMTIME();
        //    st.wYear = Convert.ToUInt16(ServerTime.Year);
        //    st.wMonth = Convert.ToUInt16(ServerTime.Month);
        //    st.wDay = Convert.ToUInt16(ServerTime.Day);
        //    st.wHour = Convert.ToUInt16(ServerTime.Hour);
        //    st.wMilliseconds = Convert.ToUInt16(ServerTime.Millisecond);
        //    st.wMinute = Convert.ToUInt16(ServerTime.Minute);
        //    st.wSecond = Convert.ToUInt16(ServerTime.Second);
            
        //    return SetLocalTime(ref st);
        //}
        //#endregion
        ///// <summary>
        ///// 查询待检车辆列表
        ///// DJ001
        ///// </summary>
        ///// <returns></returns>
        //public List<object> GetTestList()
        //{
        //    QueryResultDJ001 dj001 = new QueryResultDJ001();
        //    string[] xmlDoc = new string[1];
        //    interfaceID = "DJ001";
        //    xmlDoc[0] = CreateQCXmlDoc();
        //    string resXmlDoc = Query(xmlDoc);
        //    return ReadXml(resXmlDoc,dj001) as List<object>;
        //}
        ///// <summary>
        ///// 查询下载车辆信息 
        ///// </summary>
        ///// <param name="paraObj">需要添加的信息</param>
        ///// <returns></returns>
        //public QueryResultDL003 GetVechileInfo(object paraObj)
        //{
        //    string[] xmlDoc = new string[1];
        //    interfaceID = "DL003";
        //    xmlDoc[0] = CreateQCXmlDoc(paraObj);
        //    string resXmlDoc = Query(xmlDoc);
        //    return ReadXml(resXmlDoc, paraObj) as QueryResultDL003;
        //    //return new QueryResultDL003();
        //}
        ///// <summary>
        ///// 获取检测限定值
        ///// </summary>
        ///// <returns></returns>
        //public QueryResultXZ001 GetLimitValue()
        //{
        //    QueryResultXZ001 qrXZ001 = new QueryResultXZ001();
        //    string[] xmlDoc = new string[1];
        //    interfaceID = "XZ001";
        //    xmlDoc[0] = CreateQCXmlDoc();
        //    string resXmlDoc = Query(xmlDoc);
        //    return ReadXml(resXmlDoc, qrXZ001) as QueryResultXZ001;
        //}
        //#endregion

        //#region 写入方法
        ///// <summary>
        ///// 判断是否可以开始检测
        ///// </summary>
        ///// <param name="ks001"></param>
        ///// <returns></returns>
        //public string StartTest(QueryRequestKS001 ks001)
        //{
        //    return SendData(ks001, "KS001");
        //}
        ///// <summary>
        ///// 发送数据
        ///// </summary>
        ///// <param name="vehispara"></param>
        ///// <param name="interfaceID">由调用者指定</param>
        //public string SendData(XElement vehispara,string interfaceID)
        //{
        //    string[] xmlDoc = new string[1];
        //    this.interfaceID = interfaceID;
        //    xmlDoc[0] = CreateWCXmlDoc(vehispara);
        //    string resXmlDoc = Write(xmlDoc);
        //    string message = ReadReturnStatusXml(resXmlDoc);
        //    return message;
        //}
        ///// <summary>
        ///// 发送数据
        ///// </summary>
        ///// <param name="vehispara"></param>
        ///// <param name="interfaceID">由调用者指定</param>
        //public string SendData(object vehispara, string interfaceID)
        //{
        //    string[] xmlDoc = new string[1];
        //    this.interfaceID = interfaceID;
        //    xmlDoc[0] = CreateWCXmlDoc(vehispara);
        //    string resXmlDoc = Write(xmlDoc);
        //    string message = ReadReturnStatusXml(resXmlDoc);
        //    return message;
        //}
        //#endregion

        #region "类内部使用的方法"
        /// <summary>
        /// 生成公用的Xml
        /// </summary>
        /// <param name="element"></param>
        /// <returns></returns>
        private string CreateXmlDoc(XElement element)
        {
            XElement root = new XElement("root", 
                new XElement("head",
                    new XElement("organ", "44040201"),
                    new XElement("jkxlh", "B58EDC74E6FC0DF878C88E403A9F4045"),
                    new XElement("jkid", "JC001"),
                    new XElement("sjc", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + ". " + DateTime.Now.Millisecond.ToString())
                ),
                element
            );
            string xmlDeclaration = "<?xml version=\"1.0\" encoding=\"GBK\"?>\n";
            string xmlDoc = xmlDeclaration + root.ToString();
            return xmlDoc;
        }
        /// <summary>
        /// 创建查询类XmlDoc
        /// </summary>
        /// <param name="element"></param>
        /// <returns></returns>
        private string CreateQCXmlDoc()
        {
            XElement vehispara = new XElement("vehispara","");
            return CreateXmlDoc(vehispara);
        }
        /// <summary>
        /// 创建查询类XmlDoc
        /// </summary>
        /// <param name="element"></param>
        /// <returns></returns>
        private string CreateQCXmlDoc(object paraObj)
        {
            XElement element = Obj2XEle(paraObj);
            return CreateXmlDoc(element);
        }
        /// <summary>
        /// 创建查询类XmlDoc
        /// QC = query class
        /// </summary>
        /// <param name="element"></param>
        /// <returns></returns>
        private string CreateQCXmlDoc(XElement element)
        {
            return CreateXmlDoc(element);
        }
        /// <summary>
        /// 创建一个写入类XmlDoc
        /// WC = Write Class
        /// </summary>
        /// <param name="paraObj"></param>
        /// <returns></returns>
        private string CreateWCXmlDoc(object paraObj)
        {
            XElement element = null;
            if (!(paraObj is IEnumerable<object>))
            {
                element = Obj2XEle(paraObj);
                XElement body = new XElement("body",
                        element
                );
                return CreateXmlDoc(body);
            }
            else
            {
                element = Obj2XEle(paraObj);
                return CreateXmlDoc(element);
            }
        }
        /// <summary>
        /// 创建一个写入类XmlDoc
        /// </summary>
        /// <param name="paraObj"></param>
        /// <returns></returns>
        private string CreateWCXmlDoc(XElement element)
        {
            XElement body = new XElement("body",
                    element
                );
            return CreateXmlDoc(body);
        }
        /// <summary>
        /// 将对象转为xml
        /// </summary>
        /// <param name="objPara"></param>
        public XElement Obj2XEle(object objPara)
        {
            XElement xmlEle;
            //当传入的对象不为集合且其中包含的集合属性没有insert标记时
            if (!(objPara is IEnumerable<object>))
            {
                xmlEle = Obj2XmlUseSerializer(objPara);
            }
            //当传入的对象为集合且其中包含的集合属性没有insert标记时
            else
            {
                xmlEle = new XElement("body");
                IEnumerable<object> objs = objPara as IEnumerable<object>;
                foreach (var obj in objs)
                {
                    XElement e = Obj2XmlUseSerializer(obj);
                    xmlEle.Add(e);
                }
            }
            //如果传入的对象中的属性没有insert标记
            //直接返回结果
            if (xmlEle.Elements("insert") == null)
            {
                System.Console.WriteLine("use serializer");
                return xmlEle;
            }
            //传入的对象中的属性有insert标记
            else
            {
                xmlEle = null;
                //传入的对象不为集合且其中包含的集合属性有insert标记时
                if (!(objPara is IEnumerable<object>))
                {
                    xmlEle = Obj2XmlUseReflection(objPara);
                }
                //传入的对象为集合且其中包含的集合属性有insert标记时
                else
                {
                    xmlEle = new XElement("body");
                    IEnumerable<object> objs = objPara as IEnumerable<object>;
                    foreach (var obj in objs)
                    {
                        XElement e = Obj2XmlUseReflection(obj);
                        xmlEle.Add(e);
                    }
                }
                return xmlEle;
            }
        }
        /// <summary>
        /// 使用序列化的方式将对象转为Xml
        /// </summary>
        /// <param name="objPara"></param>
        /// <returns></returns>
        public XElement Obj2XmlUseSerializer(object objPara)
        {
            XElement xmlEle;
            XmlSerializer xmlSerializer = new XmlSerializer(objPara.GetType());
            xmlSerializer = CreateOverrider(objPara);
            // Creates a stream whose backing store is memory. 
            using (MemoryStream xmlStream = new MemoryStream())
            {
                XmlAttributes attrs = new XmlAttributes();
                XmlSerializerNamespaces namespaces = new XmlSerializerNamespaces();
                //去除根节点名称空间
                namespaces.Add(string.Empty, string.Empty);
                xmlSerializer.Serialize(xmlStream, objPara, namespaces);

                xmlStream.Position = 0;
                xmlEle = XElement.Load(xmlStream);
            }
            return xmlEle;
        }

        /// <summary>
        /// 使用反射的方式将对象转为Xml
        /// </summary>
        /// <param name="objPara"></param>
        /// <returns></returns>
        public XElement Obj2XmlUseReflection(object objPara)
        {
            XElement vehispara = new XElement("vehispara");
            foreach (PropertyInfo p in objPara.GetType().GetProperties())
            {
                object attrValue = p.GetValue(objPara);
                if (p.PropertyType.Name != typeof(List<>).Name)
                {
                    if (attrValue != null)
                    {
                        if (p.Name != "Id")
                        {
                            XElement e = new XElement(p.Name, attrValue);
                            vehispara.Add(e);
                        }
                        else
                        {
                            vehispara.Add(new XAttribute(p.Name, attrValue));
                        }
                    }
                }
                else
                {
                    var list = p.GetValue(objPara) as IEnumerable<object>;
                    if (list != null)
                    {
                        foreach (var aa in list)
                        {
                            var dtype = aa.GetType();
                            foreach (var bb in dtype.GetProperties())
                            {
                                if (bb.GetValue(aa) != null)
                                {
                                    XElement e = new XElement(bb.Name, bb.GetValue(aa));
                                    vehispara.Add(e);
                                }
                            }
                        }
                    }
                }
            }
            return vehispara;
        }


        /// <summary>
        ///  序列化后重写根名称
        /// </summary>
        /// <param name="objPara"></param>
        /// <returns></returns>
        public XmlSerializer CreateOverrider(object objPara)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(objPara.GetType());
            // Create an XmlAttributes to override the default root element.
            XmlAttributes attrs = new XmlAttributes();
            //Create an XmlRootAttribute and set its element name and namespace.
            XmlRootAttribute xmlRoot = new XmlRootAttribute();
            xmlRoot.ElementName = "vehispara";
            attrs.XmlRoot = xmlRoot;
            XmlAttributeOverrides xOver = new XmlAttributeOverrides();
            xOver.Add(objPara.GetType(), attrs);
            // Create the Serializer, and return it.
            XmlSerializer xSer = new XmlSerializer(objPara.GetType(), xOver);
            return xSer;
        }
        /// <summary>
        /// 将Xml转为对象
        /// </summary>
        private object Xml2Obj(string xmlDoc,object paraObj)
        {
            var fromXmlDoc = XElement.Parse(xmlDoc);
            var query = from body in fromXmlDoc.Elements()
                        where body.Name == "body"
                        select body;
            int count = query.Elements().Count();
            if (count == 1)
            {
                var vehicle = from v in query.Elements()
                              where v.Name == "vehispara"
                              select v;
                foreach (var e in vehicle.Elements())
                {
                    PropertyInfo prop = paraObj.GetType()
                        .GetProperty(e.Name.ToString());
                    if (prop != null)
                    {
                        prop.SetValue(paraObj, e.Value);
                    }
                }
                return paraObj;
            }
            else
            {
                List<object> vehicles = new List<object>();
                foreach (XElement veh in query.Elements())
                {
                    foreach (var e in veh.Elements())
                    {
                        PropertyInfo prop = paraObj.GetType()
                            .GetProperty(e.Name.ToString());
                        if (prop != null)
                        {
                            prop.SetValue(paraObj, e.Value);
                        }
                    }
                    vehicles.Add(paraObj);
                }
                return vehicles;
            }
        }
        /// <summary>
        /// 解析服务器返回的xml
        /// </summary>
        /// <param name="xmlDoc"></param>
        /// <param name="paraObj"></param>
        /// <returns></returns>
        private object ReadXml(string xmlDoc,object paraObj)
        {
            return Xml2Obj(xmlDoc, paraObj);
        }
        /// <summary>
        /// 解析只有一个返回值的xml
        /// </summary>
        /// <param name="xmlDoc"></param>
        /// <returns></returns>
        private string ReadXml(string xmlDoc)
        {
            var fromXmlDoc = XElement.Parse(xmlDoc);
            var query = from body in fromXmlDoc.Elements()
                        where body.Name == "body"
                        select body;

            var vehicle = from v in query.Elements()
                          where v.Name == "vehispara"
                          select v;
            var e = vehicle.Elements().FirstOrDefault();
            return e.Value;
        }
        /// <summary>
        /// 读取返回状态
        /// </summary>
        /// <returns></returns>
        private string ReadReturnStatusXml(string xmlDoc)
        {
            var fromXmlDoc = XElement.Parse(xmlDoc);
            var query = from head in fromXmlDoc.Elements()
                        where head.Name == "head"
                        select head;
            var status = from code in query.Elements()
                         where code.Name == "code"
                         select code.Value;
            if (status.FirstOrDefault() == "1")
            {
                return "1";
            }
            else
            {
                var message = from m in query.Elements()
                              where m.Name == "message"
                              select m.Value;
                return message.FirstOrDefault();
            }
        }
        #endregion
        #region 第一版
        ///// <summary>
        ///// 生成写入类XmlDoc
        ///// WC WriteClass缩写
        ///// </summary>
        ///// <param name="paraObj">平台要求上传的参数信息</param>
        ///// <returns></returns>
        //public string CreateWCXmlDoc(object paraObj)
        //{
        //    MemoryStream stream = CreateWCXmlDocStream(paraObj);
        //    return Encoding.UTF8.GetString(stream.ToArray());
        //}
        ///// <summary>
        ///// 生成查询类XmlDoc
        ///// QC QueryClass缩写
        ///// </summary>
        ///// <returns></returns>
        //public string CreateQCXmlDoc(object paraObj)
        //{
        //    MemoryStream stream = CreateQCXmlDocStream(paraObj);
        //    return Encoding.UTF8.GetString(stream.ToArray());
        //}
        //public string CreateQCXmlDoc()
        //{
        //    MemoryStream stream = CreateQCXmlDocStream(null);
        //    return Encoding.UTF8.GetString(stream.ToArray());
        //}
        ///// <summary>
        ///// 对检测平台返回的结果进行处理
        ///// </summary>
        ///// <param name="xmlDoc"></param>
        ///// <param name="paraObj">用于交换数据的对象</param>
        ///// <returns></returns>
        //public List<object> ReadXml(string xmlDoc, object paraObj)
        //{
        //    MemoryStream stream = new MemoryStream();
        //    byte[] bytes =
        //        Encoding.UTF8.GetBytes(xmlDoc);
        //    stream.Write(bytes, 0, bytes.Length);
        //    stream.Position = 0;
        //    //在这里写一个head的查询
        //    //查询成功或者失败
        //    var fromStream = XElement.Load(stream);
        //    var query = from body in fromStream.Elements()
        //                    //from vehicle in body.Elements()
        //                where body.Name == "body"
        //                select body;
        //    #region "使用hashtable"
        //    //List<Hashtable> vehicles = new List<Hashtable>();
        //    //foreach (XElement veh in query.Elements())
        //    //{
        //    //    //已测试
        //    //    Hashtable vehicle = new Hashtable();
        //    //    foreach (var e in veh.Elements())
        //    //    {
        //    //        vehicle.Add(e.Name, e.Value);
        //    //    }
        //    //    vehicles.Add(vehicle);
        //    //}
        //    //return vehicles;
        //    #endregion

        //    #region "使用反射"
        //    List<object> vehicles = new List<object>();
        //    foreach (XElement veh in query.Elements())
        //    {
        //        foreach (var e in veh.Elements())
        //        {
        //            PropertyInfo prop = paraObj.GetType()
        //                .GetProperty(e.Name.ToString());
        //            if (prop != null)
        //            {
        //                prop.SetValue(paraObj, e.Value);
        //            }
        //        }
        //        vehicles.Add(paraObj);
        //    }
        //    return vehicles;
        //    #endregion
        //}

        ///// <summary>
        ///// 生成写入类XmlDoc将其放入内存中
        ///// </summary>
        //private MemoryStream CreateWCXmlDocStream(object paraObj)
        //{
        //    MemoryStream stream = new MemoryStream();
        //    XmlWriterSettings settings = new XmlWriterSettings()
        //    {
        //        //Indent缩进
        //        Indent = true,
        //        //Encoding = new UTF8Encoding(false),
        //        OmitXmlDeclaration = true
        //    };
        //    //settings.Encoding = Encoding.GetEncoding("GBK");
        //    // StringBuilder builder = new StringBuilder();
        //    string currentTime = "";
        //    using (XmlWriter writer = XmlWriter.Create(stream, settings))
        //    {

        //        writer.WriteStartElement("root");
        //        writer.WriteStartElement("head");
        //        writer.WriteElementString("organ", "44040201");
        //        writer.WriteElementString("jkxlh", "B58EDC74E6FC0DF878C88E403A9F4045");
        //        writer.WriteElementString("jkid", interfaceID);
        //        currentTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
        //        + ". " + DateTime.Now.Millisecond.ToString();
        //        writer.WriteElementString("sjc", currentTime);
        //        writer.WriteEndElement();
        //        writer.WriteStartElement("body");
        //        writer.WriteStartElement("vehispara");
        //        if (!object.Equals(paraObj, null))
        //        {
        //            foreach (PropertyInfo p in paraObj.GetType().GetProperties())
        //            {
        //                XElement e = new XElement(p.Name, p.GetValue(paraObj));
        //                e.WriteTo(writer);
        //            }
        //        }
        //        writer.WriteEndElement();
        //        #region "测试添加多辆车"
        //        //for (int i = 0; i < 10; i++)
        //        //{
        //        //    XElement vehispara = new XElement("vehispara");
        //        //    vehispara.Add(new XAttribute("id", i));
        //        //    if (!object.Equals(paraObj, null))
        //        //    {
        //        //        foreach (PropertyInfo p in paraObj.GetType().GetProperties())
        //        //        {
        //        //            vehispara.Add(new XElement(p.Name, p.GetValue(paraObj)));                           
        //        //        }
        //        //    }
        //        //    vehispara.WriteTo(writer);

        //        //}
        //        #endregion
        //        writer.WriteEndElement();
        //        writer.WriteEndElement();
        //        writer.WriteEndDocument();

        //        writer.Flush();
        //    }
        //    return stream;
        //}

        ///// <summary>
        ///// 生成查询类XmlDoc将其放入内存中
        ///// </summary>
        ///// <returns></returns>
        //private MemoryStream CreateQCXmlDocStream(object paraObj)
        //{
        //    MemoryStream stream = new MemoryStream();
        //    XmlWriterSettings settings = new XmlWriterSettings()
        //    {
        //        //Indent缩进
        //        Indent = true,
        //        //Encoding = new UTF8Encoding(false),
        //        OmitXmlDeclaration = true
        //    };
        //    //settings.Encoding = Encoding.GetEncoding("GBK");
        //    // StringBuilder builder = new StringBuilder();
        //    string currentTime = "";
        //    using (XmlWriter writer = XmlWriter.Create(stream, settings))
        //    {
        //        writer.WriteStartElement("root");
        //        writer.WriteStartElement("head");
        //        writer.WriteElementString("organ", "44040201");
        //        writer.WriteElementString("jkxlh", "B58EDC74E6FC0DF878C88E403A9F4045");
        //        writer.WriteElementString("jkid", interfaceID);
        //        currentTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
        //        + ". " + DateTime.Now.Millisecond.ToString();
        //        writer.WriteElementString("sjc", currentTime);
        //        writer.WriteEndElement();
        //        writer.WriteStartElement("vehispara");
        //        if (!object.Equals(paraObj, null))
        //        {
        //            foreach (PropertyInfo p in paraObj.GetType().GetProperties())
        //            {
        //                XElement e = new XElement(p.Name, p.GetValue(paraObj));
        //                e.WriteTo(writer);
        //            }
        //        }
        //        writer.WriteEndElement();
        //        writer.WriteEndElement();
        //        writer.WriteEndDocument();

        //        writer.Flush();
        //    }
        //    return stream;
        //}
        #endregion
    }
}
