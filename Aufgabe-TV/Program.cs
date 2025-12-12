using Aufgabe_TV.Alternative;

namespace Aufgabe_TV
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("--- Test der Basis-Funktionalität ---");

            // Erzeugen eines TV-Objekts
            //  TV meinFernseher = new TV();

            ClassTV1 sony = new ClassTV1();

            Console.WriteLine(sony.IsOn());
            sony.TurnOn();
            Console.WriteLine(sony.IsOn());

            sony.TurnOff();
            Console.WriteLine(sony.IsOn());




            //meinFernseher.GetInfo();

            //Console.WriteLine($"Ist an? {meinFernseher.IsOn()}");

            //meinFernseher.TurnOn();

            //meinFernseher.GetInfo();

            //meinFernseher.RaiseVolume();

            //meinFernseher.RaiseVolume();

            //meinFernseher.LowerVolume();

            //meinFernseher.GetInfo();

            //meinFernseher.TurnOff(); 

            //meinFernseher.GetInfo();

            //meinFernseher.RaiseVolume();



        }
    }
}
