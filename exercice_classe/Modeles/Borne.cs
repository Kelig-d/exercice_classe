using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace exercice_classe.Modeles
{
    public class Borne
    {
        #region attributs
        private int _idBorne;
        private DateTime _dateDerniereRevision;
        private int _indiceCompteurUnites;
        private TypeBorne _leType;
        public static List<Borne> CollClass = new List<Borne>();

        #endregion

        #region getter/setter
        public int IdBorne { get => _idBorne; set => _idBorne = value; }
        public DateTime DateDerniereRevision { get => _dateDerniereRevision; set => _dateDerniereRevision = value; }
        public int IndiceCompteurUnites { get => _indiceCompteurUnites; set => _indiceCompteurUnites = value; }
        public TypeBorne LeType { get => _leType; set => _leType = value; }

        #endregion

        #region constructeur
        public Borne(DateTime date, int indice,TypeBorne leType)
        {
            CollClass.Add(this);
            _idBorne = CollClass.Count();
            _dateDerniereRevision = date;
            _indiceCompteurUnites = indice;
            _leType = leType;
        }

        #endregion

        #region methodes
        public int GetDureeRevision()
        {
            return this.LeType.DureeRevision;
        }

        public bool EstARevisier()
        {
            Borne borne = this;
            TypeBorne type = this.LeType;
            bool result = false;
            if(Convert.ToInt32(DateTime.Now - borne.DateDerniereRevision) > type.NbJoursEntreRevisions ||borne.IndiceCompteurUnites > type.NbUnitesEntreRevisions)
            {
                result = true;
            }
            return result;
        }
        #endregion
    }
}
