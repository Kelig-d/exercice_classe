using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace exercice_classe.Modeles
{
    public class Station
    {
        #region attributs
        private int _idStation;
        private string _libelleEmplacement;
        private List<Borne> _lesBornes = new List<Borne>();
        public static List<Station> CollClass = new List<Station>();

        #endregion

        #region getter/setter
        public int IdStation { get => _idStation; set => _idStation = value; }
        public string LibelleEmplacement { get => _libelleEmplacement; set => _libelleEmplacement = value; }
        public List<Borne> LesBornes { get => _lesBornes; set => _lesBornes = value; }

        #endregion

        #region constructeur
        public Station(string libelle)
        {
            CollClass.Add(this);
            _idStation = CollClass.Count();
            _libelleEmplacement = libelle;
        }
        #endregion

        #region methodes
        public int GetId()
        {
            return this.IdStation;
        }

        public string GetLibelleEmplacement()
        {
            return this.LibelleEmplacement;
        }

        public Visite GetVisiteAFaire()
        {
            Visite result= new Visite();
            foreach(Visite visite in Visite.CollClass)
            {
                if(visite.LaStation == this)
                {
                    result = visite;
                }
            }
            return result;
        }
        #endregion
    }
}
