using Aufgabe_TV.Alternative;

namespace Aufgabe_TV
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("--- Test der Basis-Funktionalität ---");

            ClassTV1 tv = new ClassTV1();

            tv.GetInfo();    // Fernseher aus
            tv.TurnOn();     // Einschalten
            tv.RaiseVolume();
            tv.RaiseVolume();
            tv.GetInfo();    // Lautstärke=2
            tv.LowerVolume();
            tv.GetInfo();    // Lautstärke=1
            tv.TurnOff();
            tv.GetInfo();    // Fernseher aus



        }
    }
}
