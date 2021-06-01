using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.Reflection;
using System.Xml.Linq;
using System.IO;

namespace XmlHelper
{
    public class XmlUtils
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        /// <summary>
        /// 将对象转为xml
        /// </summary>
        /// <param name="objPara"></param>
        public XElement Obj2Xml(object objPara)
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
        ///  Return an XmlSerializer to override the root serialization.
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
        /// 获取属性中的标记的值
        /// 测试失败
        /// </summary>
        /// <param name="objPara"></param>
        /// <returns></returns>
        //     public string IsUseObj2XmlReflection(object objPara)
        //     {
        //       string res = null;
        //       Type type = objPara.GetType();
        //       object attrubuteArray = type.GetCustomAttribute(typeof(XmlElementAttribute),true);
        //       if (attrubuteArray != null)
        //       {           
        //         XmlElementAttribute attr = attrubuteArray as XmlElementAttribute;
        //         res = attr.ElementName;
        //         System.Console.WriteLine("进去了");
        //       }
        //       return res;
        //     }
    }
}
