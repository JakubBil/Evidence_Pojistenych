namespace Evidence_pojistenych
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Evidence pojištěných";
            Databaze databaze = new Databaze();
           


            bool pokracovat = true;
            while (pokracovat)
            {
                Console.WriteLine("-------------------");
                Console.WriteLine("Evidence pojištěnců");
                Console.WriteLine("-------------------");
                Console.WriteLine("Vyberte si akci:");
                Console.WriteLine("1 - Přidat nového pojištěnce");
                Console.WriteLine("2 - Výpis všech pojištěných");
                Console.WriteLine("3 - Vyhledání pojištěnce");
                Console.WriteLine("4 - Ukončení aplikace");
                Console.WriteLine();
                char akce = Console.ReadKey().KeyChar;
                Console.WriteLine();
                switch (akce)
                {
                    case '1':
                        databaze.PridaniPojistence();
                        break;

                    case '2':
                        databaze.VypisPojistenych();
                        break;
                    case '3':
                        databaze.HledaniPojistence();
                        break;
                    case '4':
                        Console.WriteLine("Ukončete aplikaci stistem libovolné klávesy.");
                        pokracovat = false;
                        break;
                    default:
                        Console.WriteLine("Neplatná akce, prosím, zadejte znovu.");
                        break;
                }
                
            }
            Console.ReadKey();
        }
    }
}