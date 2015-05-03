using System.Collections.Generic;

namespace TMA.ResaTiama.Common.Model
{
    public interface IGestionnaireDeMateriel
    {
        IEnumerable<IMateriel> RecupererEnsembleDesMateriels();
        IEnumerable<IMateriel> RecupererLesMaterielsDisponibles();
        IEnumerable<IMateriel> RecupererLesMaterielsEnCoursEmprunt();
        IEnumerable<IMateriel> RecupererLesMaterielsInactifs();
        IEnumerable<IMarque> RecupererLesMarques();

        void AjouterUnMateriel(IMateriel materiel);
        void ModifierUnMateriel(IMateriel materiel);

        void ActiverUnMateriel(IMateriel materiel);
        void DesactiverUnMateriel(IMateriel materiel);

        bool EmprunterUnMateriel(IMateriel materiel);
        bool RestituerUnMateriel(IMateriel materiel);

    }
}
