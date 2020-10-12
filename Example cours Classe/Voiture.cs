using System;
using System.Collections.Generic;

namespace examples {
    public interface IVoiture
    {
        string Claxonner();
        string Clignotter();
        string Marque { get; set; }
    }
    public class Voiture : IVoiture {

        public Voiture(){
            Marque ="non donné";
        }
        public Voiture(string marque){
            Marque = marque;
        }

        public string Claxonner()
        {
            return "POUEEEEEEEEEEEET";
        }

        public string Clignotter()
        {
            return "clic clic";
        }


        public string Marque { get; set; }

        public List<IVoiture> Type { get; set; }
    }
}