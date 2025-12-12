namespace AufgabeTV;

internal class mTV
{
    private bool _switchedOn;
    private int _volume;
    private int _volumeStep = 1;
    private string[] _programs = ["ARD", "Sat1", "Pro7", "WDR", "ARTE"];
    private int _currentProgram;

    public void RaiseVolume()
    {
        if (!IsOn())
        {
            return;
        }
        //if (_volume + _volumeStep > 100) {
        //    return;
        //}
        _volume = Math.Min(_volume + _volumeStep, 100);
    }
    public void LowerVolume()
    {
        if (!IsOn())
        {
            return;
        }
        //if (_volume - _volumeStep < 0) {
        //    return;
        //}
        _volume = Math.Max(_volume - _volumeStep, 0);
    }
    public void TurnOn()
    {
        if (IsOn())
        {
            return;
        }
        _switchedOn = true;
    }
    public void TurnOff()
    {
        if (!IsOn())
        {
            return;
        }
        _switchedOn = false;
    }
    public bool IsOn()
    {
        return _switchedOn;
    }
    public void PrintInfo()
    {
        if (IsOn())
        {
            Console.WriteLine($"Fernseher an: Lautstärke = {_volume}, Programm = {_programs[_currentProgram]}");
        }
        else
        {
            Console.WriteLine("Fernseher aus");
        }
    }
    public void SetVolumeStep(int step)
    {
        if (step < 1 || step > 10)
        {
            Console.WriteLine("Ungültiger Wert, nur 1-10 erlaubt.");
            return;
        }
        _volumeStep = step;
    }
    public void RaiseProgram()
    {
        if (!IsOn())
        {
            return;
        }
        _currentProgram = (_currentProgram + 1) % _programs.Length;
    }
    public void LowerProgram()
    {
        if (!IsOn())
        {
            return;
        }
        _currentProgram = (_currentProgram - 1) % _programs.Length;
    }
}
