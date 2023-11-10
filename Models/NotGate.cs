using System.ComponentModel.DataAnnotations; // Импорт пространства имён для атрибутов валидации
using System.ComponentModel.DataAnnotations.Schema; // Импорт пространства имён для атрибутов базы данных

namespace LogikaSkeem.Models
{
    // Класс NotGate, наследующийся от LogicGate
    public class NotGate : LogicGate
    {
        // Конструктор класса NotGate с параметром name
        public NotGate(string name) : base(name, (input1, input2) => input1 != input2)
        {
            // Вызов конструктора базового класса LogicGate с передачей имени и лямбда-выражения для операции "НЕ" (NOT)
            // Выражение принимает два входных значения input1 и input2 и возвращает результат операции "НЕ" между ними
        }
    }
}
