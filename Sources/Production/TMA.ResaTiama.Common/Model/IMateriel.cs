using System;

namespace TMA.ResaTiama.Common.Model
{
    public interface IMateriel
    {
        string NumeroDeSerie { get; }
        string LibelleAffichage { get; set; }

        DateTime DateAchat { get; set; }
        DateTime DateRetrait { get; set; }
        IMarque Marque { get; }
        string Modele { get; }

        bool EstFonctionnel { get; }
    }
}
