namespace LogikaSkeem.Models
{
    // Класс LogicGate, представляющий логическое устройство
    public class LogicGate
    {
        // Свойство для имени устройства
        public string Name { get; set; }

        // Свойства для состояния входных каналов
        public bool InputChannel1State { get; set; }
        public bool InputChannel2State { get; set; }

        // Приватное свойство для состояния выхода
        public bool OutputState { get; private set; }

        private Func<bool, bool, bool> logicFunction; // Функция для логической операции

        // Конструктор класса LogicGate с параметрами name и logicFunction
        public LogicGate(string name, Func<bool, bool, bool> logicFunction)
        {
            Name = name;
            InputChannel1State = false; // По умолчанию устанавливаем входные значения в FALSE
            InputChannel2State = false;
            this.logicFunction = logicFunction;
            CalculateOutput(); // Рассчитываем начальное состояние выхода
        }

        // Метод для установки входных значений
        public void SetInput(bool input1, bool input2)
        {
            InputChannel1State = input1;
            InputChannel2State = input2;
            CalculateOutput();
        }

        // Приватный метод для расчета состояния выхода
        private void CalculateOutput()
        {
            OutputState = logicFunction(InputChannel1State, InputChannel2State);
        }
    }
}
