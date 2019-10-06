using System;

namespace examples
{
    class Program
    {
public static string GetDisplayName(string firstname, string lastname){
    //return firstname + " "+ lastname;
    //return String.Concat(firstname," ", lastname);
    //return String.Format("{0} {1}",firstname, lastname);
    return $"{firstname} {lastname}";
}

public static string F(){
    return "lala";
}

    public bool EstPaire(int entier){
        if(entier%2 == 0){
            return true;
        }
        else
        {
            return false;
        }
    }

    public bool EstPaireSwitch(int entier){
        bool result;
        switch(entier){
            case 0:
                result = true;
                break;
            case 1:
                result = false;
                break;
            default:
                result = true;
                break;
        }
        return result;
    }

    public bool[] SontPaires(int[] entiers){
        bool[] results = new bool[entiers.Length];

        for(int i = 0;i < entiers.Length; i++ ){
            if(entiers[i]%2 == 0){
                results[i] = true;
            }
            else{
                results[i] = false;
            }
        }
        int j = 0;
        while(j < entiers.Length){
            if(entiers[j]%2 == 0){
                results[j] = true;
            }
            else{
                results[j] = false;
            }
            j++;
        }
        j = 0;
        foreach(int entier in entiers){
            if(entier%2 == 0){
                results[j] = true;
            }
            else{
                results[j] = false;
            }
            j++;
        }

        return results;
    }
        static void Main(string[] args)
        {
            int i = 0;

            int a = i++;
            Console.WriteLine(a); // a == 0
            Console.WriteLine(i); // i == 1

            i = 0;
            int b = ++i;
            Console.WriteLine(b); /* b == 1 */
            Console.WriteLine(i); // i ==1

            //Console.WriteLine(F());
            string displayName = GetDisplayName("Jérôme", "Firlej");
            Console.WriteLine(displayName);
/*


            float f = 2.1f;

              anneeEPSI B2 = anneeEPSI.B2;

              Book book = new Book();
              book.Price = 15;
              book.Title ="Game of Throne";

              int a = 1;
              int b = 1;

              Console.WriteLine(a == b); 
                Test test = new Test();
                test.Value = "1";

                Test test2 =new Test();
                test2.Value = "1";

                Console.WriteLine(test == test2);

                Test[] tests = new []{
                    new Test(),
                    new Test()
                };

                Test first = tests[0];
                tests[0] = new Test();











*/
                      }

public class Test{
    public string Value { get; set; }
}

        public struct Book{
            public int Price { get; set; }
            public string Title { get; set; }
        }
        enum anneeEPSI{
            B1 = 1,
            B2 = 2,
            B3,
            I4,
            I5
        }
    }
}
