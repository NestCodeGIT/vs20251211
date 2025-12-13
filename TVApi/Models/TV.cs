namespace TVApi.Models;

public class TV
{
    private bool _switchedOn;
    private int _volume;
    private int _volumeStep = 1;
    private string[] _programs = new[] { "ARD", "Sat1", "Pro7", "WDR", "ARTE" };
    private int _currentProgram;

    public void RaiseVolume()
    {
        if (!_switchedOn) return;
        _volume = Math.Min(_volume + _volumeStep, 100);
    }

    public void LowerVolume()
    {
        if (!_switchedOn) return;
        _volume = Math.Max(_volume - _volumeStep, 0);
    }

    public void TurnOn()
    {
        _switchedOn = true;
    }

    public void TurnOff()
    {
        _switchedOn = false;
    }

    public bool IsOn() => _switchedOn;

    public string GetInfo()
    {
        if (_switchedOn)
            return $"Fernseher an: Lautstärke = {_volume}, Programm = {_programs[_currentProgram]}";
        else
            return "Fernseher aus";
    }

    public void SetVolumeStep(int step)
    {
        if (step >= 1 && step <= 10)
            _volumeStep = step;
    }

    public void RaiseProgram()
    {
        if (!_switchedOn) return;
        _currentProgram = (_currentProgram + 1) % _programs.Length;
    }

    public void LowerProgram()
    {
        if (!_switchedOn) return;
        _currentProgram = (_currentProgram - 1 + _programs.Length) % _programs.Length;
    }
}
