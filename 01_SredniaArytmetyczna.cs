namespace Cw2
{
    internal class SredniaArytmetyczna
    {
        public SredniaArytmetyczna()
        {
            int liczbaLiczb = 3;
            decimal suma = 0;
            for (int i = 0; i < liczbaLiczb; i++)
            {
                decimal result;
                string? input;
                do
                {
                    Console.WriteLine($"Wpisz liczbe nr {i + 1}: ");
                    input = Console.ReadLine();
                } while (!decimal.TryParse(input, out result));
                suma += result;
            }
            Console.WriteLine($"Średnia arytmetyczna: {suma/liczbaLiczb:N2}");
        }
    }
}
