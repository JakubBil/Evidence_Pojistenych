using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evidence_pojistenych
{
    internal class Databaze
    {
        List<Pojisteny> Pojistenci = new List<Pojisteny>();

        /// <summary>
        /// Přidá do databáze nového pojištěnce
        /// </summary>
        public void PridaniPojistence()
        {
            Console.WriteLine("--Přidáváte nového pojištěnce--");
            Console.WriteLine("Zadejte jméno: ");
            string jmeno = Console.ReadLine();
            Console.WriteLine("Zadejte příjmení: ");
            string prijmeni = Console.ReadLine();
            Console.WriteLine("Zadejte věk: ");
            int vek = int.Parse(Console.ReadLine());
            Console.WriteLine("Zadejte telefoní číslo: ");
            int telefoniCislo = int.Parse(Console.ReadLine());

            Pojistenci.Add(new Pojisteny(jmeno, prijmeni, vek, telefoniCislo));
            Console.WriteLine("\nData uložena. Pokračujte stiskem klávesy");
            Console.ReadKey();
            Console.Clear();
        }
        /// <summary>
        /// Vypíše všechny zadané pojištěnce
        /// </summary>
        public void VypisPojistenych()
        {
            Console.WriteLine("\nVypisujete všechny pojištěné:");
            foreach(Pojisteny pojisteny in Pojistenci)
            {
                Console.WriteLine(pojisteny);
            }
            Console.WriteLine("\nPokračujte libovolnou klávesou");
            Console.ReadKey();
            Console.Clear();

        }
        /// <summary>
        /// Podle zadaného jména a příjmení vyhledá pojištěnce
        /// </summary>
        public void HledaniPojistence()
        {
            bool shodaJmen = false; //bool pro shodu
            Console.WriteLine("Vyhledáváte pojištěnce:");
            Console.WriteLine("Zadejte jméno:");
            string hledaneJmeno = Console.ReadLine();
            Console.WriteLine("Zadejte příjmení:");
            string hledanePrijmeni = Console.ReadLine();

            // Hledání shody jmen
            foreach(Pojisteny pojisteny in Pojistenci)
            {
                if((hledaneJmeno.ToLower().Trim() == pojisteny.Jmeno.ToLower().Trim() ) && (hledanePrijmeni.ToLower().Trim() == pojisteny.Prijmeni.ToLower().Trim()))
                {
                    Console.WriteLine("Nalezen pojištěnec: {0} {1}, {2}, {3}", pojisteny.Jmeno, pojisteny.Prijmeni, pojisteny.Vek, pojisteny.TelefoniCislo);
                    shodaJmen = true;
                }
                
            }
            // Nenalezení shody
            if(!shodaJmen)
            {
                Console.WriteLine("Bohužel jsem nenašel žádnou shodu jmen.");
            }

        }
    }
}
