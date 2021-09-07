using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace exercice_classe.Modeles
{
    class Technicien
    {
        #region attributs
        private int _matricule;
        private string _prenom;
        private string _nom;
        public static List<Technicien> CollClass = new List<Technicien>();


        #endregion

        #region getter/setter
        public int Matricule { get => _matricule; set => _matricule = value; }
        public string Prenom { get => _prenom; set => _prenom = value; }
        public string Nom { get => _nom; set => _nom = value; }

        #endregion

        #region constructeur
        public Technicien(string nom, string prenom)
        {
            CollClass.Add(this);
            _matricule = CollClass.Count();
            _nom = nom;
            _prenom = prenom;
        }
        #endregion

        #region methodes

        #endregion
    }
}
