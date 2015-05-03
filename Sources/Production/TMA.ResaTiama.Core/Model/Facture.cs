using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TMA.ResaTiama.Common.Model;

namespace TMA.ResaTiama.Core.Model
{
    public class Facture : IFacture
    {
        #region IFacture Membres

        public IPret Pret
        {
            get { throw new NotImplementedException(); }
        }

        public int MontantEnCentimes
        {
            get { throw new NotImplementedException(); }
        }

        public MoyenPaiement? MoyenDePaiement
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

        public DateTime? DateDeReglement
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

        #endregion
    }
}
