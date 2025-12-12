namespace Aufgabe_TV
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("--- Test der Basis-Funktionalität ---");

            // Erzeugen eines TV-Objekts
            TV meinFernseher = new TV();

            // Testen aller Funktionalitäten
            meinFernseher.GetInfo(); // Info im ausgeschalteten Zustand
            Console.WriteLine($"Ist an? {meinFernseher.IsOn()}");

            meinFernseher.TurnOn(); // Einschalten
            meinFernseher.GetInfo();

            meinFernseher.RaiseVolume(); // Lautstärke erhöhen
            meinFernseher.RaiseVolume();

            meinFernseher.LowerVolume(); // Lautstärke reduzieren
            meinFernseher.GetInfo();

            meinFernseher.TurnOff(); // Ausschalten
            meinFernseher.GetInfo();

            meinFernseher.RaiseVolume(); // Versuch, Lautstärke im ausgeschalteten Zustand zu ändern

            // Hier würde die Main-Methode normalerweise mit den folgenden Erweiterungen fortfahren.
        }
    }
}
