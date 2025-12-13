using System;
using System.Collections.Generic;
using System.Text;

namespace Aufgabe_TV.Alternative
{
    internal class ClassTV1
    {
        // private bool SwitchedOn { get; set; }
        //private volatile bool _switchedOn;



        //public bool IsSwitchedOn { get; private set; }
        //public void TurnOn() => IsSwitchedOn = true;
        //public void TurnOff() => IsSwitchedOn = false;

        //public bool IsOn() =>  IsSwitchedOn;

        private bool switchedOn;
        private int volume;
        private int volumeStep = 1;
        private string[] programs = { "ARD", "Sat1", "Pro7", "WDR", "ARTE" };
        private int currentProgram = 0;

        public void SetVolumeStep(int step)
        {
            if (step >= 1 && step <= 10)
            {
                volumeStep = step;
            }
        }
        public void RaiseVolume()
        {
            if (volume + volumeStep <= 100)
                volume += volumeStep;


        }
        public void LowerVolume()
        {
            if (volume - volumeStep >= 0)
                volume -= volumeStep;


        }
        public void TurnOn()
        {
            switchedOn = true;
            Console.WriteLine("Fernseher eingeschaltet");
        }

        public void TurnOff()
        {
            switchedOn = false;
            Console.WriteLine("Fernseher ausgeschaltet");
        }


        public bool IsOn()
        {
            return switchedOn;
        }

        public void GetInfo()
        {
            if (switchedOn)
                Console.WriteLine($"Fernseher an: Lautstärke = {volume}, Programm = {programs[currentProgram]}");
            else
                Console.WriteLine("Fernseher aus");
        }



        public void NextProgram()
        {
            currentProgram = (currentProgram + 1) % programs.Length;
        }

        public void PreviousProgram()
        {
            currentProgram = (currentProgram - 1 + programs.Length) % programs.Length;
        }

    
    }
}
