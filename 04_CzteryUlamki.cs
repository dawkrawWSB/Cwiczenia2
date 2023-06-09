namespace Cw2
{
    internal class CzteryUlamki
    {
        public CzteryUlamki()
        {
            int[] liczby = new int[4];
            string abcd = "abcd";
            for (int i = 0; i < 4; i++)
            {
                liczby[i] = DostanLiczbe($"Liczba {abcd[i]}:");
            }

            if (liczby[1] == 0 || liczby[3] == 0)
            {
                Console.WriteLine("Brak rozwiazania.");
                return;
            }

            if(liczby[1] == liczby[3])
            {
                Console.WriteLine($"X = {liczby[0] + liczby[2]}, Y = {liczby[1]}");
            }
            else
            {
                Console.WriteLine($"X = {(liczby[0] * liczby[3]) + (liczby[2] * liczby[1])}, Y = {liczby[1] * liczby[3]}");
            }
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
