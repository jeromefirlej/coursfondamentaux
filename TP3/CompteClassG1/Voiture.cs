using System;

public class Voiture{
    private string Marque;

    public Voiture(string marque){
        this.Marque = marque;

    }
    public virtual string AppuyerKlaxon(){
        return "POUET";
    }
}

public class Tesla : Voiture {
    
    public string Klaxon { set; private get; }
    public Tesla(): base("Tesla"){

    }

    public override string AppuyerKlaxon(){
        return Klaxon;
    }
    
}