using System;
using System.Collections.Generic;
using System.Text;

namespace exercice_classe.Modeles
{
    class Visite
    {
        #region attributs
        private char _etat;
        private int _dureeTotale;
        private Station _laStation;
        private List<Borne> _lesBornes = new List<Borne>();
        public static List<Visite> CollClass = new List<Visite>();


        #endregion

        #region getter/setter
        public char Etat { get => _etat; set => _etat = value; }
        public int DureeTotale { get => _dureeTotale; set => _dureeTotale = value; }
        public Station LaStation { get => _laStation; set => _laStation = value; }

        #endregion

        #region constructeur
        public Visite(char etat, int duree,Station station)
        {
            CollClass.Add(this);
            _etat = etat;
            _dureeTotale = duree;
            _laStation = station;
        }
        #endregion

        #region methodes

        #endregion
    }
}
