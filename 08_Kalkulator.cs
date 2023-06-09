namespace Cw2
{
    internal class Kalkulator
    {
        public Kalkulator()
        {
            List<Type> dzialania = new List<Type> { typeof(Dodawanie), typeof(Odejmowanie), typeof(Mnozenie), typeof(Dzielenie) };
            decimal pierwsza = DostanLiczbe("Liczba pierwsza");
            decimal druga = DostanLiczbe("Liczba druga:");
            int liczbaDzialania = Convert.ToInt32(DostanLiczbe("Liczba dzialania (1-Dodawanie, 2-Odejmowanie, 3-Mnozenie, 4-Dzielenie") -1);
            if(liczbaDzialania < 0 || liczbaDzialania > dzialania.Count - 1)
            {
                Console.WriteLine("Dzialanie nie znalezine");
                return;
            }
            Type wybraneDzialanie = dzialania[liczbaDzialania];
            IDzialanieMatematyczne? dzialanie = Activator.CreateInstance(wybraneDzialanie) as IDzialanieMatematyczne;
            if(dzialanie == null)
            {
                Console.WriteLine("Cos zlego sie wydarzylo");
                return;
            }

            decimal? rezultat = dzialanie.Wykonaj(pierwsza, druga);
            if(rezultat == null)
            {
                return;
            }
            Console.WriteLine($"Wynik dzialania ({wybraneDzialanie.Name}): {rezultat}");
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

    interface IDzialanieMatematyczne
    {
        public decimal? Wykonaj(decimal pierwsza, decimal druga);
    }
    class Dodawanie : IDzialanieMatematyczne
    {
        public decimal? Wykonaj(decimal pierwsza, decimal druga) => pierwsza + druga;
    }

    class Odejmowanie : IDzialanieMatematyczne
    {
        public decimal? Wykonaj(decimal pierwsza, decimal druga) => pierwsza - druga;
    }

    class Mnozenie : IDzialanieMatematyczne
    {
        public decimal? Wykonaj(decimal pierwsza, decimal druga) => pierwsza * druga;
    }

    class Dzielenie : IDzialanieMatematyczne
    {
        public decimal? Wykonaj(decimal pierwsza, decimal druga)
        {
            if (druga == 0)
            {
                Console.WriteLine($"{pierwsza}/0");
                return null;
            }
            return pierwsza / druga;
        }
    }
}
