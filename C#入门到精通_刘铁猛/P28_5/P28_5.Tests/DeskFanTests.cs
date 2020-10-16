using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace P28_5.Tests
{
    [TestClass]
    public class DeskFanTests
    {
        [TestMethod]
        public void PowerLowerThanZero_OK()
        {
            var mock = new Mock<IPowerSupply>();
            mock.Setup(ps => ps.GetPower()).Returns(() => 0);

            // var fan = new DeskFan(new PowerSupplyLowerThanZero());
            var fan = new DeskFan(mock.Object);
            var expected = "Won't work.";
            var actual = fan.Work();
            Assert.AreEqual(expected, actual);


        }

        [TestMethod]
        public void PowerHigherThan200_Warning()
        {
            var mock = new Mock<IPowerSupply>();
            mock.Setup(ps => ps.GetPower()).Returns(() => 300);

            //  var fan = new DeskFan(new PowerSupplyHigherThan200());
            var fan = new DeskFan(mock.Object);
            var expected = "Warning!";
            var actual = fan.Work();
            Assert.AreEqual(expected, actual);
        }
    }

  // class PowerSupplyLowerThanZero : IPowerSupply
  // {
  //     public int GetPower()
  //     {
  //         return 0;
  //     }
  // }
  //
  // class PowerSupplyHigherThan200 : IPowerSupply
  // {
  //     public int GetPower()
  //     {
  //         return 300;
  //     }
  // }
}
