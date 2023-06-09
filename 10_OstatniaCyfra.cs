namespace Cw2
{
    internal class OstatniaCyfra
    {
        public OstatniaCyfra()
        {
            int liczba = DostanLiczbe("Liczba:");
            if(liczba < 10 && liczba > -10)
            {
                Console.WriteLine($"Ostatnia cyfra to {liczba}");
                return;
            }
            Console.WriteLine($"Ostatnia cyfra to: {liczba % 10}");
        }
        public static int DostanLiczbe(string tekst)
        {
            int result;
            string? input;
            do
            {
                Console.WriteLine(tekst);
                input = Console.ReadLine();
            } while (!int.TryParse(input, out result));
            return result;
        }
    }
}
