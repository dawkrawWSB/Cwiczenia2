namespace Cw2
{
    internal class PoleIObwodKola
    {
        public PoleIObwodKola()
        {
            double result;
            string? input;
            do
            {
                Console.WriteLine($"Wpisz pole koła: ");
                input = Console.ReadLine();
            } while (!double.TryParse(input, out result));

            double r = Math.Sqrt(result / Math.PI);
            Console.WriteLine($"Obwód koła: {2 * Math.PI * r:N2}");
        }
    }
}
