using Microsoft.AspNetCore.Mvc;
using TVApi.Models;

namespace TVApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TVController : ControllerBase
{
    private static TV _tv = new TV();
    // یک instance جهانی تلویزیون

    [HttpGet("info")]
    public IActionResult GetInfo()
    {
        return Ok(new { info = _tv.GetInfo() });
    }

    [HttpPost("on")]
    public IActionResult TurnOn()
    {
        _tv.TurnOn();
        return Ok(new { info = _tv.GetInfo() });
    }

    [HttpPost("off")]
    public IActionResult TurnOff()
    {
        _tv.TurnOff();
        return Ok(new { info = _tv.GetInfo() });
    }

    [HttpPost("volume/up")]
    public IActionResult RaiseVolume()
    {
        _tv.RaiseVolume();
        return Ok(new { info = _tv.GetInfo() });
    }

    [HttpPost("volume/down")]
    public IActionResult LowerVolume()
    {
        _tv.LowerVolume();
        return Ok(new { info = _tv.GetInfo() });
    }

    [HttpPost("volume/step/{step}")]
    public IActionResult SetVolumeStep(int step)
    {
        _tv.SetVolumeStep(step);
        return Ok(new { info = _tv.GetInfo() });
    }

    [HttpPost("program/next")]
    public IActionResult NextProgram()
    {
        _tv.RaiseProgram();
        return Ok(new { info = _tv.GetInfo() });
    }

    [HttpPost("program/previous")]
    public IActionResult PreviousProgram()
    {
        _tv.LowerProgram();
        return Ok(new { info = _tv.GetInfo() });
    }
}
