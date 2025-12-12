using System;
using System.Collections.Generic;
using System.Text;

namespace Aufgabe_TV.Alternative
{
    internal class ClassTV1
    {
        // private bool SwitchedOn { get; set; }
        //private volatile bool _switchedOn;

        

        public bool IsSwitchedOn { get; private set; }
        public void TurnOn() => IsSwitchedOn = true;
        public void TurnOff() => IsSwitchedOn = false;

        public bool IsOn() =>  IsSwitchedOn;
      



    }
}
