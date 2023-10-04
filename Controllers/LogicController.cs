// LogicController.cs
using LogikaSkeem.Models;
using Microsoft.AspNetCore.Mvc;

[Route("api/[controller]")]
[ApiController]
public class LogicController : ControllerBase
{
    [HttpPost("calculate")]
    public ActionResult<string> CalculateLogic([FromBody] LogicRequest request)
    {
        // Создайте экземпляры LogicGate, OrGate, AndGate, NotGate и выполните операции с ними
        // Используйте request для получения входных данных из фронтенда
        // Верните результаты операций в формате JSON
        // Например:

        var andGate = new AndGate("AND1");
        andGate.SetInput(request.Input1, request.Input2);

        var orGate = new OrGate("OR1");
        orGate.SetInput(request.Input3, request.Input4);

        var notGate = new NotGate("NOT1");
        notGate.SetInput(request.Input5, request.Input6);

        var result = new
        {
            AndOutput = andGate.OutputState,
            OrOutput = orGate.OutputState,
            NotOutput = notGate.OutputState
        };

        return Ok(result);
    }
}

public class LogicRequest
{
    public bool Input1 { get; set; }
    public bool Input2 { get; set; }
    public bool Input3 { get; set; }
    public bool Input4 { get; set; }
    public bool Input5 { get; set; }
    public bool Input6 { get; set; }
}
