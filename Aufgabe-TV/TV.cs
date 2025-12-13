using System;

// Teilaufgabe 2: Basis-Implementierung der Klasse TV
public class TV
{
    // Attribute (Felder) - private für Datenkapselung
    private bool switchedOn;
    private int volume;

    // Konstruktor, um Standardwerte zu setzen
    public TV()
    {
        switchedOn = false; 
        // Initial ist der Fernseher aus
        volume = 50;       
        // Initial ist die Lautstärke auf 50 (wird später auf 0-100 beschränkt)
        Console.WriteLine("Neuer Fernseher erstellt.");
    }

    // Operationen (Methoden)

    public void TurnOn()
    {
        if (!switchedOn)
        {
            switchedOn = true;
            Console.WriteLine("Der Fernseher wird eingeschaltet.");
        }
    }

    public void TurnOff()
    {
        if (switchedOn)
        {
            switchedOn = false;
            Console.WriteLine("Der Fernseher wird ausgeschaltet.");
        }
    }

    public bool IsOn()
    {
        return switchedOn;
    }

    public void RaiseVolume()
    {
        if (switchedOn)
        {
            volume++;
            Console.WriteLine($"Lautstärke erhöht auf {volume}");
        }
        else
        {
            Console.WriteLine("Der Fernseher ist aus und kann nicht lauter gestellt werden.");
        }
    }

    public void LowerVolume()
    {
        if (switchedOn)
        {
            volume--;
            Console.WriteLine($"Lautstärke reduziert auf {volume}");
        }
        else
        {
            Console.WriteLine("Der Fernseher ist aus und kann nicht leiser gestellt werden.");
        }
    }

    public void GetInfo()
    {
        string status = switchedOn ? "an" : "aus";
        Console.WriteLine($"Fernseher {status}: Lautstärke={volume}");
    }
}

