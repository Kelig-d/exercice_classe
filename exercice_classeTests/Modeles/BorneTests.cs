using Microsoft.VisualStudio.TestTools.UnitTesting;
using exercice_classe.Modeles;
using System;
using System.Collections.Generic;
using System.Text;

namespace exercice_classe.Modeles.Tests
{
    [TestClass()]
    public class BorneTests
    {
        [TestMethod()]
        public void GetDureeRevisionTest()
        {
            var type1 = new TypeBorne("fg12", 30, 14, 100);
            var b1 = new Borne(DateTime.Now, 0, type1);
            Assert.AreEqual(30, b1.GetDureeRevision());
        }

        [TestMethod()]
        public void EstARevisierTestUnite()
        {
            var type1 = new TypeBorne("fg12", 30, 14, 100);
            var b1 = new Borne(DateTime.Now, 110, type1);
            Assert.IsTrue(b1.EstARevisier());

        }
        [TestMethod()]
        public void EstARevisierTestTemps()
        {
            var type1 = new TypeBorne("fg12", 30, 14, 100);
            DateTime date = new DateTime(1992, 06, 14);
            var b1 = new Borne(date, 110, type1);
            Assert.IsTrue(b1.EstARevisier());

        }
    }
}