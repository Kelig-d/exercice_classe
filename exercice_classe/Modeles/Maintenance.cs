using System;
using System.Collections.Generic;
using System.Text;

namespace exercice_classe.Modeles
{
    public class Maintenance
    {
        #region attributs
        private List<Station> lesStations = Station.CollClass;
        private List<Technicien> lesTechniciens = Technicien.CollClass;
        private List<Visite> lesVisites = new List<Visite>();

        #endregion

        #region getter/setter
        public List<Station> LesStations { get => lesStations; set => lesStations = value; }
        public List<Technicien> LesTechniciens { get => lesTechniciens; set => lesTechniciens = value; }
        public List<Visite> LesVisites { get => lesVisites; set => lesVisites = value; }
        #endregion

        #region constructeur

        #endregion

        #region methodes
        public void Reviser()
        {
            foreach(Visite visite in Visite.CollClass)
            {
                lesVisites.Add(visite);
            }
        }

        public void AffecterVisite()
        {
            foreach (Visite laVisite in lesVisites)
            {
                int heures = Int32.MaxValue;
                Technicien leTechnicien = new Technicien();
                foreach (Technicien technicien in lesTechniciens)
                {
                    if (technicien.GetTempsOccupe() < heures)
                    {
                        heures = technicien.GetTempsOccupe();
                        leTechnicien = technicien;
                    }
                }
                leTechnicien.AffecterVisite(laVisite);
            }
        }
        #endregion
    }
}
