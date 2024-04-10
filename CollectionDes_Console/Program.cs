using CollectionDes_Affaires;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionDes_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            MainDes main = new MainDes(5);

            Console.WriteLine("Main: {0} {1} {2} {3} {4}", 
                main.Des[0].Valeur, main.Des[1].Valeur, main.Des[2].Valeur, main.Des[3].Valeur, main.Des[4].Valeur);
            main.lancer();
            Console.WriteLine("Main: {0} {1} {2} {3} {4}",
                main.Des[0].Valeur, main.Des[1].Valeur, main.Des[2].Valeur, main.Des[3].Valeur, main.Des[4].Valeur);
            main.lancer();
            Console.WriteLine("Main: {0} {1} {2} {3} {4}",
                main.Des[0].Valeur, main.Des[1].Valeur, main.Des[2].Valeur, main.Des[3].Valeur, main.Des[4].Valeur);
            Console.ReadLine();
        }
    }
}
