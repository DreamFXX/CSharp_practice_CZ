namespace IntroductionCSharp1
{
    internal class Program

        // Deklarace a práce s proměnnými, jednotlivými typy
    {
        static void Main(string[] args)
        {
            // Proměnná je vždy nějakého typu
            // Proměnná se nějak jmenuje
            // Níže - celé číslo, slova a věty, znak, desetinné číslo, destinné číslo které se nebude užívat jako dlouhé tedy celé ale usekne se.. využívá se třeba ve hrách.
            // Níže - boolean -> hodnota pravda / nepravda
            int i = 152;
            string s = "Hello, World!";
            char c = 'm';
            double d = 144.88454546464648441311255555659843164964614666316164161d; //Na konci se píše "d"
            float f = 120.4f; // Na konci se píše velké F, float je vždy kratší kvuli jednodussi praci se pouziva misto doublu
            bool b = true;



            Console.WriteLine(s);

            Console.ReadKey();
        }
    }
}
