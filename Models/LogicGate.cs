namespace LogikaSkeem.Models
{
    public class LogicGate
    {
        public string Name { get; set; }
        public bool InputChannel1State { get; set; }
        public bool InputChannel2State { get; set; }
        public bool OutputState { get; private set; }

        private Func<bool, bool, bool> logicFunction;

        public LogicGate(string name, Func<bool, bool, bool> logicFunction)
        {
            Name = name;
            InputChannel1State = false; // По умолчанию устанавливаем входные значения в FALSE
            InputChannel2State = false;
            this.logicFunction = logicFunction;
            CalculateOutput(); // Рассчитываем начальное состояние выхода
        }

        public void SetInput(bool input1, bool input2)
        {
            InputChannel1State = input1;
            InputChannel2State = input2;
            CalculateOutput();
        }

        private void CalculateOutput()
        {
            OutputState = logicFunction(InputChannel1State, InputChannel2State);
        }
    }
}
