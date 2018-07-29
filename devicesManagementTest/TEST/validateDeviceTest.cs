using System;
using gestionDispositivos.Class;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace devicesManagementTest
{
    [TestClass]
    public class validateDeviceTest
    {

        [TestMethod]
        public void IpShouldBeCorrect()
        {
            string ip = "192.168.0.1";
            bool result = validateDevice.isRightFormatIpV4(ip);
            Assert.IsTrue(result, "IP: " + ip + " is incorrect.");
        }

        public static bool isNegativeOrZero(string text)
        {
            return !validateDevice.isEmpty(text) && Int32.Parse(text) <= 0;
        }

        [DataRow("prueba")]
        [TestMethod]
        public void textShouldNotBeEmpty(string text)
        {
            bool result = validateDevice.isEmpty(text);
            Assert.IsFalse(result, "Text is empty");
        }

        [DataRow("1")]
        [TestMethod]
        public void textShouldNotBeNegative(string text)
        {
            bool result = validateDevice.isNegativeOrZero(text);
            Assert.IsFalse(result, "Text is negative");
        }


        [DataRow("prueba", 6)]
        [DataRow("prueba", 20)]
        [TestMethod]
        public void textShouldNotBeLessThanValue(string text, int length)
        {
            bool result = validateDevice.isTooLong(text, length);

            Assert.IsFalse(result, "Text is too long");
        }


    }
}
