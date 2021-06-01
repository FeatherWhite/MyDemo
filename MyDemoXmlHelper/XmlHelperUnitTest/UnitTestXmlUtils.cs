using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Xml.Linq;
using System.Collections.Generic;
using XmlHelper;

namespace XmlHelperUnitTest
{
  [TestClass]
  public class UnitTestXmlUtils
  {
    List<Company> companies = new List<Company>();
    Company company = new Company();
    Company companyDiShang = new Company();
    Company companyTianShang = new Company();
    List<Employee> employees = new List<Employee>();
    XmlUtils xmlUtils = new XmlUtils();
    [TestInitialize]
    public void InitializeModel()
    {      
      company = new Company()
      {
        Id = "1",
        DateOfEstablishment = DateTime.Now.ToString("mm-dd HH:mm:ss"),
        // Employees = new List<Employee>(),
        LandArea = "1万平方米"
      };

      companyDiShang = new Company()
      {
        Name = "地上",
        DateOfEstablishment = DateTime.Now.ToString("mm-dd HH:mm:ss"),
        // Employees = new List<Employee>(),
        LandArea = "2万平方米"
      };
      companyTianShang = new Company()
      {
        Id = "2",
        Name = "天上",
        DateOfEstablishment = DateTime.Now.ToString("MM-dd HH:mm:ss"),
        // Employees = new List<Employee>(),
        LandArea = "3万平方米"
      };
      companies.Add(company);
      companies.Add(companyDiShang);
      companies.Add(companyTianShang);
      
      Employee employeeZhangSan = new Employee(){
          employee_code = 1,
          name = "张三",
      };
      Employee employeeLiSi = new Employee(){
          employee_code = 2,
          name = "李四",
      };
      employees.Add(employeeZhangSan);
      employees.Add(employeeLiSi);
    }
    [TestMethod]
    public void TestObj2Xml()
    {
      XElement xElement = xmlUtils.Obj2Xml(company);
      Console.WriteLine(xElement.ToString());
    }    
    /// <summary>
    /// 传入一个集合对象
    /// </summary>
    [TestMethod]
    public void TestObj2XmlArray()
    {     
      XElement xElement = xmlUtils.Obj2Xml(companies);
      Console.WriteLine(xElement.ToString());
    }
    /// <summary>
    /// 传入一个对象,对象中包含集合
    /// </summary>
    [TestMethod]
    public void TestObj2XmlSubArray()
    {
      company.Employees = employees;
      XElement xElement = xmlUtils.Obj2Xml(company);
      Console.WriteLine(xElement.ToString());
    }
    // /// <summary>
    // /// 找出一个指定节点
    // /// </summary>
    // [TestMethod]
    // public void TestSelectOne()
    // {
    //   company.Employees = employees;
    //   XElement xElement = xmlUtils.Obj2Xml(company);
    //   XElement xInsert = xElement.Element("insert");
    //   Assert.IsNotNull(xInsert);
    //   companyDiShang.Employees = employees;
    //   companyTianShang.Employees = employees;
    //   XElement xElements = xmlUtils.Obj2Xml(companies);
    //   var xInserts = xElements.Elements("insert");
    //   Assert.IsNotNull(xInserts);
    // }
    // /// <summary>
    // /// 找出多个指定节点
    // /// </summary>
    // [TestMethod]
    // public void TestSelectMany()
    // {
    //   company.Employees = employees;
    //   XElement xElement = xmlUtils.Obj2Xml(company);
    //   // XElement query = from insert in xElement
    // }
    
    /// <summary>
    /// 传入一个集合,集合中的每个对象还包含集合
    /// </summary>
    [TestMethod]
    public void TestObj2XmlArrayCArrays()
    {
      company.Employees = employees;
      companyDiShang.Employees = employees;
      companyTianShang.Employees = employees;
      XElement xElement = xmlUtils.Obj2Xml(companies);
      Console.WriteLine(xElement.ToString());
    }
  }
}
