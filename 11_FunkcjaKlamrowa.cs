namespace Cw2
{
    internal class FunkcjaKlamrowa
    {
        public FunkcjaKlamrowa()
        {
            decimal x = DostanLiczbe("x:");
            decimal? wynik = null;
            if (x < 1)
            {
                if (x < -1)
                {
                    if (x < -2)
                    {
                        wynik = -1;
                    }
                    else
                    {
                        wynik = x + 1;
                    }
                }
                else
                {
                    wynik = 0;
                }
            }
            if(x > 1)
            {
                if (x > 2)
                {
                    wynik = 1;
                }
                else
                {
                    wynik = x - 1;
                }
            }
            Console.WriteLine($"wynik: {wynik}");
        }

        public static decimal DostanLiczbe(string tekst)
        {
            decimal result;
            string? input;
            do
            {
                Console.WriteLine(tekst);
                input = Console.ReadLine();
            } while (!decimal.TryParse(input, out result));
            return result;
        }
    }
}
