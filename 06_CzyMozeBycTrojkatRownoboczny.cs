namespace Cw2
{
    internal class CzyMozeBycTrojkatRownoboczny
    {
        public CzyMozeBycTrojkatRownoboczny()
        {
            decimal[] liczby = new decimal[3];
            for (int i = 0; i < 3; i++)
            {
                liczby[i] = DostanLiczbe($"Bok nr {i + 1}:");
            }

            for( int i = 0;i < 3;i++)
            {
                if (i == 0) continue;

                if (liczby[i] != liczby[i - 1])
                {
                    Console.WriteLine("Trojkat nie moze byc rownoboczny");
                    return;
                }
            }
            Console.WriteLine("Trojkat moze byc rownoboczny");
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
