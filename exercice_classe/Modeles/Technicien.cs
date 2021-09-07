using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace exercice_classe.Modeles
{
    public class Technicien
    {
        #region attributs
        private int _matricule;
        private string _prenom;
        private string _nom;
        private List<Visite> _lesVisites = new List<Visite>();
        public static List<Technicien> CollClass = new List<Technicien>();


        #endregion

        #region getter/setter
        public int Matricule { get => _matricule; set => _matricule = value; }
        public string Prenom { get => _prenom; set => _prenom = value; }
        public string Nom { get => _nom; set => _nom = value; }
        public List<Visite> LesVisites { get => _lesVisites; set => _lesVisites = value; }

        #endregion

        #region constructeur
        public Technicien(string nom, string prenom)
        {
            CollClass.Add(this);
            _matricule = CollClass.Count();
            _nom = nom;
            _prenom = prenom;
        }

        public Technicien()
        {
        }
        #endregion

        #region methodes
        public int GetTempsOccupe()
        {
            int result = 0;
            foreach(Visite visite in LesVisites)
            {
                result += visite.DureeTotale;
            }
            return result;
        }
        public void AffecterVisite(Visite visite)
        {
            LesVisites.Add(visite);
        }
        public List<Visite> GetLesVisite()
        {
            return this.LesVisites;
        }
        #endregion
    }
}
