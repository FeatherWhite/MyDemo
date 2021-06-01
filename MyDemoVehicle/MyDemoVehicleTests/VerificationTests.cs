using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyDemoVehicle.Utils;
using System;

namespace MyDemoVehicleTests
{
    [TestClass]
    public class VerificationTests
    {
        [TestMethod]
        public void IsFloatTest()
        {
            Assert.IsTrue(Verification.IsFloat("21312.234"));
            Assert.IsFalse(Verification.IsFloat("asd.123"));
            Assert.IsFalse(Verification.IsFloat("weew.werwe"));
            Assert.IsFalse(Verification.IsFloat("发.sdf"));
            Assert.IsFalse(Verification.IsFloat("1312.asd"));
        }
    }
}
