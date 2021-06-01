using System;
using System.Collections.Generic;
using System.Xml.Serialization;
namespace XmlHelper 
{
  // [XmlRoot("vehispara")]
  public class Company 
  {
    [XmlAttribute]
    public string Id { get; set; }
    /// <summary>
    /// 公司名称
    /// </summary>
    /// <value></value>
    public string Name { get; set; }
    /// <summary>
    /// 成立日期
    /// </summary>
    public string DateOfEstablishment { get; set; }
    // [XmlArray("a")]
    // [XmlArrayItem()]
    [XmlElement("insert")]
    // [XmlIgnore]
    public List<Employee> Employees { get; set; }
    /// <summary>
    /// 占地面积
    /// </summary>
    public string LandArea { get; set; }
  }
}