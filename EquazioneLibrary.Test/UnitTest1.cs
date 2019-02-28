using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EquazioneLibrary.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            double a = 1;
            bool resultato = true;

            bool determinate = EquazioniLibrary.Equazione.IsDetermined(a);

            Assert.AreEqual(resultato, determinate);

        }

    }
}
