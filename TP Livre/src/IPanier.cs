using System.Collections.Generic;

namespace Fnac
{
    public interface IPanier
    {
        List<ILivre> Livres { get; set; }
        double Total { get; }
        string Affichage();
    }
}