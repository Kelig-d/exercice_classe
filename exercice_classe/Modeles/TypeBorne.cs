using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace exercice_classe.Modeles
{
    public class TypeBorne
    {
        #region attributs
        private string _codeTypeBorne;
        private int _dureeRevision;
        private int _nbJoursEntreRevisions;
        private int _nbUnitesEntreRevisions;
        public static List<TypeBorne> CollClass = new List<TypeBorne>();

        #endregion

        #region getter/setter
        public string CodeTypeBorne { get => _codeTypeBorne; set => _codeTypeBorne = value; }
        public int DureeRevision { get => _dureeRevision; set => _dureeRevision = value; }
        public int NbJoursEntreRevisions { get => _nbJoursEntreRevisions; set => _nbJoursEntreRevisions = value; }
        public int NbUnitesEntreRevisions { get => _nbUnitesEntreRevisions; set => _nbUnitesEntreRevisions = value; }

        #endregion

        #region constructeur
        public TypeBorne(string codeTypeBorne, int duree,int nbjoursR,int nbunites)
        {
            CollClass.Add(this);
            _codeTypeBorne = codeTypeBorne;
            _nbJoursEntreRevisions = nbjoursR;
            _nbUnitesEntreRevisions = nbunites;
        }
        #endregion

        #region methodes
        public int GetDureeRevision()
        {
            return this.DureeRevision;
        }
        public int GetNbJoursEntreRevisions()
        {
            return this.NbJoursEntreRevisions;
        }
        public int GetNbUnitesEntreRevisions()
        {
            return this.NbUnitesEntreRevisions;
        }

        #endregion
    }
}
