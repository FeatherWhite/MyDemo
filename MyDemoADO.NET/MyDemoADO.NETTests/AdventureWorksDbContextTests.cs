using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyDemoADO.NET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDemoADO.NET.Tests
{
    [TestClass()]
    public class AdventureWorksDbContextTests
    {
        MyDBContext myDBContext = new AdventureWorksDbContext();
        [TestMethod()]
        public void ConnectTest()
        {
            myDBContext.Connect();
        }
        [TestMethod()]
        public void SelectRowsTest()
        {
            myDBContext.SelectRows();
        }

        [TestMethod()]
        public void InsertRowsTest()
        {
            myDBContext.InsertRows();
        }
    }
}