
namespace TMA.ResaTiama.Common.Model
{
    public interface IPersonne
    {
        string Nom { get; }
        string Prenom { get; }
        string AdresseMail { get; }
        bool EstMembreCE { get; }
    }
}
