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
            var type1 = new TypeBorne("fg12", 30, 14, 100);
            var b1 = new Borne(DateTime.Now, 0,type1);
            var b2 = new Borne(DateTime.Now, 110, type1);
            List<Borne> lesBornes = new List<Borne>();
            lesBornes.Add(b1);
            lesBornes.Add(b2);
            var v1 = new Visite(station, lesBornes);
            Maintenance maintenance = new Maintenance();
            maintenance.Reviser();
        }

        [TestMethod()]
        public void AffecterVisiteTest()
        {
            var station = new Station("Stalingrad");
            var type1 = new TypeBorne("fg12", 30, 14, 100);
            var b1 = new Borne(DateTime.Now, 0, type1);
            var b2 = new Borne(DateTime.Now, 110, type1);
            List<Borne> lesBornes = new List<Borne>();
            lesBornes.Add(b1);
            lesBornes.Add(b2);
            var v1 = new Visite(station, lesBornes);
            Maintenance maintenance = new Maintenance();
            maintenance.AffecterVisite();
        }
    }
}