using System;

namespace TMA.ResaTiama.Common.Model
{
    public interface IPret
    {
        DateTime DateDebut { get; }
        DateTime DateFin { get; set; }

        IMateriel MaterielEmprunte { get; }

        IPersonne Emprunteur { get; }
    }
}
