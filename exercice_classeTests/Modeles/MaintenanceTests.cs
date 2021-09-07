using Microsoft.VisualStudio.TestTools.UnitTesting;
using exercice_classe.Modeles;
using System;
using System.Collections.Generic;
using System.Text;

namespace exercice_classe.Modeles.Tests
{
    [TestClass()]
    public class MaintenanceTests
    {
        [TestMethod()]
        public void ReviserTest()
        {
            var station = new Station("Stalingrad");
            var type1 = new TypeBorne("fg12", 14, 14, 14);
            var b1 = new Borne(DateTime.Now,0,)
        }

        [TestMethod()]
        public void AffecterVisiteTest()
        {
            Assert.Fail();
        }
    }
}