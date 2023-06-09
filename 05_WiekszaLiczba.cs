namespace Cw2
{
    internal class WiekszaLiczba
    {
        public WiekszaLiczba()
        {
            decimal pierwsza = DostanLiczbe("Liczba pierwsza: ");
            decimal druga = DostanLiczbe("Liczba druga: ");
            Console.WriteLine("Wieksza liczba to: " + (pierwsza > druga ? pierwsza : druga));
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
