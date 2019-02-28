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
        [TestMethod]
        public void TestMethod3()
        {
            double a = 0;
            bool resultato = false;
            bool determinate = EquazioniLibrary.Equazione.IsDetermined(a);
            Assert.AreEqual(resultato, determinate);
        }

        [TestMethod]
        public void TestMethod2()
        {
            double a = 1;
            bool resultato = false;

            bool determinate = EquazioniLibrary.Equazione.IsInconsisted(a);

            Assert.AreEqual(resultato, determinate);

        }

        [TestMethod]
        public void TestMethod4()
        {
            double a = 0;
            bool resultato = true;

            bool determinate = EquazioniLibrary.Equazione.IsInconsisted(a);

            Assert.AreEqual(resultato, determinate);

        }





    }
}
