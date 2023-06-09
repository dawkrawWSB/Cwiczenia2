namespace Cw2
{
    internal class PunktWObrebieKola
    {
        public PunktWObrebieKola()
        {
            double x = DostanLiczbe("Wprowadz liczbe x:");
            double y = DostanLiczbe("Wprowadz liczbe y:");
            double r = DostanLiczbe("Wprowadz promien(r):");

            x = Math.Sqrt(x); y = Math.Sqrt(y); r = Math.Sqrt(r);
            string odpowiedz = "Punkt nie lezy w obrebie kola o srodku O (0,0)";
            if(x+y <= r)
            {
                odpowiedz = "Punkt lezy w obrebie kola O(0,0) srodku";
            }
            Console.WriteLine(odpowiedz);
        }

        public static double DostanLiczbe(string tekst)
        {
            double result;
            string input;
            do
            {
                Console.WriteLine(tekst);
                input = Console.ReadLine();
            } while (!double.TryParse(input, out result));
            return result;
        }
    }
}
