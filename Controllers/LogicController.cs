using LogikaSkeem.Models;
using Microsoft.AspNetCore.Mvc;


[Route("api/[controller]")]
[ApiController]
public class LogicController : ControllerBase
{
    [HttpPost("calculate")]
    public ActionResult<string> CalculateLogic([FromBody] LogicRequest request)
    {
        // Создайте экземпляры LogicGate и выполните операции с ними,
        // учитывая динамические операторы и входные данные
        // Используйте request для получения входных данных из фронтенда

        var result = CalculateExpression(request);

        return Ok(result);
    }

    private bool CalculateExpression(LogicRequest request)
    {
        bool result = request.Input1; // Начальное значение результата

        var operators = new List<string>
        {
            request.Operator1,
            request.Operator2,
            request.Operator3,
            request.Operator4,
            request.Operator5
        };

        var inputs = new List<bool>
        {
            request.Input2,
            request.Input3,
            request.Input4,
            request.Input5,
            request.Input6
        };

        // Затем обрабатываем остальные операторы и входные данные динамически, начиная с индекса 1
        for (int i = 0; i < inputs.Count; i++)
        {
            if (operators.Count > i)
            {
                if (operators[i] == "AND")
                {
                    var andGate = new AndGate($"AND{i + 1}");
                    andGate.SetInput(result, inputs[i]);
                    result = andGate.OutputState;
                }
                else if (operators[i] == "OR")
                {
                    var orGate = new OrGate($"OR{i + 1}");
                    orGate.SetInput(result, inputs[i]);
                    result = orGate.OutputState;
                }
                else if (operators[i] == "NOT")
                {
                    var notGate = new NotGate($"NOT{i + 1}");
                    notGate.SetInput(inputs[i], !inputs[i]);
                    result = notGate.OutputState;
                }
            }
        }

        return result;
    }
}
