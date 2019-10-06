namespace LivreClass{


public class Vehicule{
    private string marque;
    public string Marque { get{
        return marque;
        }
    }
    public Vehicule(string marque){
        this.marque = marque;
    }
}

public class Camion : Vehicule{
    public string chargement;
    public Camion(string marque, string chargement)
    : base(marque)
    {
        this.chargement = chargement;
    }
}

public class Dacia : Vehicule{
    public Dacia() 
    : base("Dacia"){

    }
}

}