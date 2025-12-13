using System;
using System.Collections.Generic;

namespace Aufgabe_TV.Professional;

public class TV
{
    // ========= Fields =========
    private bool _isSwitchedOn;
    private int _volume = 20;
    private int _volumeStep = 1;
    private int _currentProgramIndex = 0;

    // ========= Constants / Collections =========
    public IReadOnlyList<string> Programs { get; } =
        new List<string> { "ARD", "Sat1", "Pro7", "WDR", "ARTE" }.AsReadOnly();

    // ========= Properties =========
    public bool IsSwitchedOn
    {
        get => _isSwitchedOn;
        private set => _isSwitchedOn = value;
    }

    public int Volume
    {
        get => _volume;
        private set => _volume = Math.Clamp(value, 0, 100);
    }

    public int VolumeStep
    {
        get => _volumeStep;
        set => _volumeStep = Math.Clamp(value, 1, 10);
    }

    public string CurrentProgram => Programs[_currentProgramIndex];

    // ========= Events =========
    public event Action? SwitchedOn;
    public event Action? SwitchedOff;

    // ========= Methods =========
    public void TurnOn()
    {
        if (IsSwitchedOn) return;

        IsSwitchedOn = true;
        SwitchedOn?.Invoke();
    }

    public void TurnOff()
    {
        if (!IsSwitchedOn) return;

        IsSwitchedOn = false;
        SwitchedOff?.Invoke();
    }

    public void RaiseVolume()
    {
        if (!IsSwitchedOn) return;
        Volume += VolumeStep;
    }

    public void LowerVolume()
    {
        if (!IsSwitchedOn) return;
        Volume -= VolumeStep;
    }

    public void NextProgram()
    {
        if (!IsSwitchedOn) return;

        _currentProgramIndex =
            (_currentProgramIndex + 1) % Programs.Count;
    }

    public void PreviousProgram()
    {
        if (!IsSwitchedOn) return;

        _currentProgramIndex =
            (_currentProgramIndex - 1 + Programs.Count) % Programs.Count;
    }

    // ========= Info / Output =========
    public string GetInfo() =>
        IsSwitchedOn
            ? $"Fernseher an: Lautstärke = {Volume}, Programm = {CurrentProgram}"
            : "Fernseher aus";

    public override string ToString() => GetInfo();
}
