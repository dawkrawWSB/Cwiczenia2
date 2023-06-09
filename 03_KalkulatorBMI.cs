namespace Cw2
{
    internal class KalkulatorBMI
    {

        public KalkulatorBMI()
        {
            decimal waga = DostanLiczbe("Waga [KG]:");
            decimal wzrost = decimal.MaxValue;
            do
            {
                wzrost = DostanLiczbe("Wzrost [M]:");
            } while (wzrost > 2 || wzrost < 1);

            Console.WriteLine($"BMI: {waga / (wzrost * wzrost)}");
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
