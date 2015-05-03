using System;

namespace TMA.ResaTiama.Common.Model
{
    public interface IFacture
    {
        IPret Pret { get; }
        int MontantEnCentimes { get; }
        MoyenPaiement? MoyenDePaiement { get; set; }
        DateTime? DateDeReglement { get; set; }
    }
}
