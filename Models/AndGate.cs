using LogikaSkeem.Models; // Импорт пространства имён LogikaSkeem.Models

public class AndGate : LogicGate
{
    // Конструктор класса AndGate с параметром name
    public AndGate(string name) : base(name, (input1, input2) => input1 && input2)
    {
        // Вызов конструктора базового класса LogicGate с передачей имени и лямбда-выражения для операции "И" (AND)
        // Лямбда-выражение принимает два входных значения input1 и input2 и возвращает результат операции "И" между ними
    }
}
