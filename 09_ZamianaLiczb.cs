namespace Cw2
{
    internal class ZamianaLiczb
    {
        public ZamianaLiczb()
        {
            decimal a = DostanLiczbe("Liczba a");
            decimal b = DostanLiczbe("Liczba b");
            decimal c = DostanLiczbe("Liczba c");

            a = a+ b + c;
            b = a - (b+c);
            c = a - (c+b);
            a = a - (b+c);
            Console.WriteLine($"Po dzialaniach: {a} {b} {c}");
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
