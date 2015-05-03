using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TMA.ResaTiama.Common.Model;

namespace TMA.ResaTiama.Core.Model
{
    public class Materiel : IMateriel
    {
        #region IMateriel Membres

        public string NumeroDeSerie
        {
            get { throw new NotImplementedException(); }
        }

        public string LibelleAffichage
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public DateTime DateAchat
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public DateTime DateRetrait
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public IMarque Marque
        {
            get { throw new NotImplementedException(); }
        }

        public string Modele
        {
            get { throw new NotImplementedException(); }
        }

        public bool EstFonctionnel
        {
            get { throw new NotImplementedException(); }
        }

        #endregion
    }
}
