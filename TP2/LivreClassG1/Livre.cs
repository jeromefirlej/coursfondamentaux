namespace LivreClass{
    using System.Globalization;

    public interface IBook
    {
        string Afficher();
    }

    public class Novel : Book {

        public string Description { get; set; }
        public Novel(string title, string author, string description) : base(title, author, 12m){
            this.Description = description;
        }

        public override string Afficher(){
            return base.Afficher() + "\n" + this.Description;
        }
    }

    public class Book : IBook{
        private string title;
        public string Titles{
            get{ return title; }
        }
        private string Author;
        public string Authors{
            get{ return Author; }
        }
        private decimal Price;
        public decimal Prices{
            get{ return Price; }
        }
        public Book(string titles , string authors , decimal prices ){
            this.title=titles;
            this.Author=authors;
            this.Price=prices;
        }
       public virtual string Afficher(){
            string saut="\n";
            CultureInfo culture = CultureInfo.CreateSpecificCulture("en-US");
            return "le tire est:"+title+saut+"l'auteur est :"+Author+saut+"le prix vaut :"+Price.ToString("C", culture);
        }
    }
    
}