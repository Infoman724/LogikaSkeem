using LogikaSkeem.Models;

public class AndGate : LogicGate
{
    public AndGate(string name) : base(name, (input1, input2) => input1 && input2) { }
}