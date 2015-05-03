using System;
using TMA.ResaTiama.Common.Model;

namespace TMA.ResaTiama.Core.Model
{
    public class Pret : IPret
    {
        #region IPret Membres

        public DateTime DateDebut
        {
            get { throw new NotImplementedException(); }
        }

        public DateTime DateFin
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

        public IMateriel MaterielEmprunte
        {
            get { throw new NotImplementedException(); }
        }

        public IPersonne Emprunteur
        {
            get { throw new NotImplementedException(); }
        }

        #endregion
    }
}
