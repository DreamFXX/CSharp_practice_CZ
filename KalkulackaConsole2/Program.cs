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
            string s1 = Console.ReadLine();

            Console.ReadKey();
        }
    }
}
