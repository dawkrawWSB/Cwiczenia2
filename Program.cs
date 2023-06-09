using Cw2;

List<Type> zadania = new List<Type> { typeof(SredniaArytmetyczna), typeof(PoleIObwodKola), typeof(KalkulatorBMI), typeof(CzteryUlamki), typeof(WiekszaLiczba), 
    typeof(CzyMozeBycTrojkatRownoboczny), typeof(PunktWObrebieKola), typeof(Kalkulator), typeof(ZamianaLiczb), typeof(OstatniaCyfra), typeof(FunkcjaKlamrowa) };

Type? zadanieWybrane = null;
do
{
    Console.WriteLine("Wybierz zadanie wpisujac numer i klikajac enter:");
    foreach (Type zadanie in zadania)
    {
        Console.WriteLine($"{zadania.IndexOf(zadanie)} - {zadanie.Name}");
    }
    string? input = Console.ReadLine();
    if (!string.IsNullOrWhiteSpace(input) && int.TryParse(input, out int result))
    {
        zadanieWybrane = zadania.ElementAtOrDefault(result);
    }
}while (zadanieWybrane == null);

Activator.CreateInstance(zadanieWybrane);

