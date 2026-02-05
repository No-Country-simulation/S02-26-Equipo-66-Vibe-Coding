using JustinaSimulator.Application.UseCases.MovePointer;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace JustinaSimulator.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PointerController : ControllerBase
{
    private readonly MovePointerHandler _handler;

    public PointerController(MovePointerHandler handler)
    {
        _handler = handler;
    }

    [HttpPost("move")]
    public async Task<IActionResult> MovePointer([FromBody] MovePointerCommand command)
    {
        await _handler.HandleAsync(command);
        return Ok(new { Message = "Pointer moved", Target = command });
    }
}
