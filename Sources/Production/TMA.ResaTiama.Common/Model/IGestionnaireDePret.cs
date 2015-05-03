
using System.Collections.Generic;


namespace TMA.ResaTiama.Common.Model
{
    public interface IGestionnaireDePret
    {
        IEnumerable<IPret> RecupererTousLesPrets();
        IEnumerable<IPret> RecupererLesPretsEnCours();
        IEnumerable<IPret> RecupererLesPretsNonPayes();
        IFacture FournirFacturePourLePret(IPret pret);
        IEnumerable<IPret> RecupererLesEmpruntPourLaPersonne(IPersonne personne);

        IEnumerable<IFacture> RecuperToutesLesFactures();
        IEnumerable<IFacture> RecupererLesFacturesPourLaPersonne(IPersonne personne);
        IEnumerable<IFacture> RecupererLaFacturePourLePret(IPret pret); 

        void CreerUnPret(IPret pret);
        void TerminerUnPret(IPret pret);
    }
}
