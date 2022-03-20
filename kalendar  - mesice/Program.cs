using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kalendar____mesice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime cas = DateTime.Now;
            int cisloMesice = cas.Month;
            string[] poleMesicu = { "Leden", "Únor", "Březen", "Duben", "Květen", "Červen", "Červenec", "Srpen", "Září", "Říjen", "Listopad", "Prosinec" };
            Console.WriteLine($"Nyní je {poleMesicu[cisloMesice - 1]}, další měsíc je {poleMesicu[cisloMesice]}, minulý měsíc byl {poleMesicu[cisloMesice - 2]}.");
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("Napiš číslo měsice 1-12.");
            int Mesic = Convert.ToInt32(Console.ReadLine());
            int mesicMinus = Mesic - 1;
            int mesicPlus = Mesic + 1;
            if (Mesic >= 2 && Mesic <= 11)
            {
                Console.WriteLine($"Nyní je {poleMesicu[Mesic - 1]}, další měsíc je {poleMesicu[mesicPlus - 1]}, minulý měsíc byl {poleMesicu[mesicMinus - 1]}.");

            }
            else if (Mesic == 1)
            {
                Console.WriteLine($"Nyní je {poleMesicu[0]}, další měsíc je {poleMesicu[1]}, minulý měsíc byl {poleMesicu[11]}.");
            }
            else if (Mesic == 12)
            {
                Console.WriteLine($"Nyní je {poleMesicu[11]}, další měsíc je {poleMesicu[0]}, minulý měsíc byl {poleMesicu[10]}.");
            }
            Console.WriteLine("Chceš vypsat všechny měsíce? ANO/NE");
            string AnoNe = Console.ReadLine();
            if (AnoNe == "ANO")
            {
                foreach (string pole in poleMesicu)
                {
                    Console.WriteLine(pole);
                    Console.ReadLine();
                }
            }
            else if (AnoNe == "NE")
            {
                Console.WriteLine("Tak to nezapínej");
                Console.ReadLine();
                System.Environment.Exit(0);
            }
        }
    }
}

