namespace LogickeOperatory5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pouze demonstrace logických operátorů -> && a ||");

            bool b = true;

            if (true)
                Console.WriteLine(); // Splní se, pokud je bool true

            if (true && true) // && Znamená, že musí být oba booly true (obě hodnoty).!
                Console.WriteLine("bool je true, druhý je také true"); // Splní se, pokud jsou oba booly true.
            

            if (true && false) // Splní se, pokud je jeden bool true a druhý false.
                Console.WriteLine(); // Nesplní se

            if (true || false) // Pokud je jedna z hodnot, je jedno jaká true. 
                Console.WriteLine(); // Splní se

            if (false || false)
                Console.WriteLine(); // Nesplní se

            if (true || false && true) 
                Console.WriteLine(); // Splní se

            if (true != false) 
                Console.WriteLine(); // Splní se (Prohodí naopak hodnoty, pokud tedy je true, je to jako false.)
            // Reverse the result, returns False if the result is true



            Console.ReadKey();
        }
    }
}
