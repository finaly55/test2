using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Add_4_3_Retourne7()
        {
            ConsoleApp2.Utile util = new ConsoleApp2.Utile();

            int x = 3;
            int y = 4;
            Assert.AreEqual(7, util.Add(x, y), "La valeur doit être égale à 7");
        }

        [TestMethod]
        public void Add_4_3_Retourne8()
        {
            ConsoleApp2.Utile util = new ConsoleApp2.Utile();

            int x = 3;
            int y = 4;
            Assert.AreEqual(8, util.Add(x, y), "La valeur doit être égale à 7");
        }
    }
}