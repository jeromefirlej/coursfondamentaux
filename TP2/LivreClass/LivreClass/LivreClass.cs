using System.Globalization;

namespace LivreClass
{
    public interface ILivreClass
    {
        string[] PrintInfos();
    }

    public class LivreClass : ILivreClass
    {
        private string _auteur;
        private string _name;
        private string _description;
        private double _prix;

        public LivreClass(string name,
                            string auteur,
                            string description,
                            double prix)
        {
            this._auteur = auteur;
            this._name = name;
            this._description = description;
            this._prix = prix;
        }
        public string Name { get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        
        public string[] PrintInfos()
        {
            string[] infos = new string[4];
            infos[0] = $" Auteur : {this._auteur}";
            infos[1] = $" Description : {this._description}";
            infos[2] = $" Auteur : {this._name}";
            CultureInfo culture = 
                CultureInfo.CreateSpecificCulture("en-US");
            infos[3] = $"{this._prix.ToString("C", culture)}";
            return infos;
        }

    }
}
