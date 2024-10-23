namespace UpgradedCalc4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome in my calculator!");

            int i1, i2;

            Console.WriteLine("Zadejte první číslo, se kterým chcete pracovat: ");
            i1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Zadejte druhé číslo, se kterým chcete pracovat: ");
            i2 = int.Parse(Console.ReadLine());


            Console.WriteLine("Nyní zadejte operaci, kterou chcete provést -> + sčítání, - odčítání, * násobení, / dělení.");
            string result = Console.ReadLine();

            // V konfiguraci projektu je volba nullable == disabled.!

            if (result == "+")
            {
                Console.WriteLine("Výsledek je: " + (i1 + i2));
            }

            // Else if - aby to nebylo zaměřeno pouze na všechny 4 pokusy.

            else if (result == "-")
            {
                Console.WriteLine("Výsledek je: " + (i1 - i2));
            }

            else if (result == "*")
            {
                Console.WriteLine("Výsledek je: " + (i1 * i2));
            }

            else if (result == "/")
            {
                if (i2 != 0) // Negace - pokud není nula.
                {
                    Console.WriteLine("Výsledek je: " + (i1 / i2));
                }

                else
                {
                    Console.WriteLine("Dělitel nesmí být 0!");
                }

            }

            else
            {
                Console.WriteLine("Nezadali jste ani jeden z požadovaných znaků.");
            }




            Console.ReadKey();
        }
    }
}
