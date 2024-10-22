namespace KalkulackaConsole2
{
    internal class Program
    {
        // Vytvoř kalkulačku, která bude sčítat 2 čísla a pak je na konci vypíše sečtené.
        // Také se naučíme převádět číslo na textový řetězec.
        static void Main(string[] args)
        {
            Console.WriteLine("Professional calculator - by DreamFXX written in CSharp");
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Zadej první číslo které chceš sčítat:");
            string s = Console.ReadLine();

            Console.WriteLine("Zadej druhé číslo které chceš sčítat:");
            string s1 = Console.ReadLine(); // V konfiguraci projektu (Hlava v pruzkumniku reseni) lze zadat nullable možnost - disabled.)

            // Prevedeni zadanych hodnot na text
            int i1 = int.Parse(s);
            int i2 = int.Parse(s1);

            Console.WriteLine(i1 + i2); // Spatne, nebylo převedeno na čísla, dali se dohromady oba zadané hodnoty jako text.
            Console.WriteLine(int.Parse(s) + int.Parse(s1)); // Druha moznost zapisu.

            Console.ReadKey();
        }
    }
}
