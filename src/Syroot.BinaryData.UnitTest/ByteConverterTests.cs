using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OatmealDome.BinaryData.UnitTest
{
    [TestClass]
    public class ByteConverterTests
    {
        // ---- METHODS (PUBLIC) ---------------------------------------------------------------------------------------

        [TestMethod]
        public void DetectSystemEndianness()
        {
            if (BitConverter.IsLittleEndian)
            {
                Assert.AreEqual(ByteConverter.System.ByteOrder, ByteOrder.LittleEndian);
            }
            else
            {
                Assert.AreEqual(ByteConverter.System.ByteOrder, ByteOrder.BigEndian);
            }
        }
    }
}
