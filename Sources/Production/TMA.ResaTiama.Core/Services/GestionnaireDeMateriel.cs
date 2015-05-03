using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TMA.ResaTiama.Common.Model;

namespace TMA.ResaTiama.Core.Services
{
    public class GestionnaireDeMateriel : IGestionnaireDeMateriel
    {
        private IEnumerable<IMateriel> _materiels;

        public GestionnaireDeMateriel()
        {
            _materiels = new List<IMateriel>();
        }


        #region IGestionnaireDeMateriel Membres

        public IEnumerable<IMateriel> RecupererEnsembleDesMateriels()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IMateriel> RecupererLesMaterielsDisponibles()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IMateriel> RecupererLesMaterielsEnCoursEmprunt()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IMateriel> RecupererLesMaterielsInactifs()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IMarque> RecupererLesMarques()
        {
            throw new NotImplementedException();
        }

        public void AjouterUnMateriel(IMateriel materiel)
        {
            throw new NotImplementedException();
        }

        public void ModifierUnMateriel(IMateriel materiel)
        {
            throw new NotImplementedException();
        }

        public void ActiverUnMateriel(IMateriel materiel)
        {
            throw new NotImplementedException();
        }

        public void DesactiverUnMateriel(IMateriel materiel)
        {
            throw new NotImplementedException();
        }

        public bool EmprunterUnMateriel(IMateriel materiel)
        {
            throw new NotImplementedException();
        }

        public bool RestituerUnMateriel(IMateriel materiel)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
