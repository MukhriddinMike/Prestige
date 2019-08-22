using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Prestige.Biz;

namespace Presige.BizTest
{
    [TestClass]
    public class ActorTest
    {
        [TestMethod]
        public void TestGetOccupatin()
        {
            // Arrange
            var currentActor = new Actor();
            var expected = "Actor";

            // Act
          
            string result = currentActor.GetOccupation();
            // Assert
            Assert.AreEqual(expected, result);
        }
    }
}
