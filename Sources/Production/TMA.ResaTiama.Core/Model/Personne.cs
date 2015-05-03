using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using TMA.ResaTiama.Common.Model;

namespace TMA.ResaTiama.Core.Model
{
    public class Personne : IPersonne
    {
        #region IPersonne Membres

        public string Nom
        {
            get { throw new NotImplementedException(); }
        }

        public string Prenom
        {
            get { throw new NotImplementedException(); }
        }

        public string AdresseMail
        {
            get { throw new NotImplementedException(); }
        }

        public bool EstMembreCE
        {
            get { throw new NotImplementedException(); }
        }

        #endregion
    }
}
