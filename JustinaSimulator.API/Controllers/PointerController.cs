using JustinaSimulator.Application.UseCases.MovePointer;
using JustinaSimulator.Application.UseCases.Click;
using JustinaSimulator.Domain.Enums;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace JustinaSimulator.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PointerController : ControllerBase
{
    private readonly MovePointerHandler _moveHandler;
    private readonly ClickHandler _clickHandler;

    public PointerController(MovePointerHandler moveHandler, ClickHandler clickHandler)
    {
        _moveHandler = moveHandler;
        _clickHandler = clickHandler;
    }

    [HttpPost("move")]
    public async Task<IActionResult> MovePointer([FromBody] MovePointerCommand command)
    {
        await _moveHandler.HandleAsync(command);
        return Ok(new { Message = "Pointer moved", Target = command });
    }

    [HttpPost("click")]
    public async Task<IActionResult> Click([FromBody] ClickCommand command)
    {
        var status = await _clickHandler.HandleAsync(command);
        
        var message = status == SafetyStatus.Safe 
            ? "Operation Successful" 
            : "Critical Error: Operation out of safe zone";

        return Ok(new { Message = message, Status = status, Target = command });
    }

    [HttpGet("history")]
    public async Task<IActionResult> GetHistory([FromServices] ISimulationStateRepository repository)
    {
        var robot = await repository.GetRobotAsync();
        return Ok(robot.Trajectory);
    }
}
