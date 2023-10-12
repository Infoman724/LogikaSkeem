namespace LogikaSkeem.Models
{
    // Класс LogicRequest, представляющий модель данных для запроса логических операций
    public class LogicRequest
    {
        // Свойства для входных данных
        public bool Input1 { get; set; }
        public bool Input2 { get; set; }
        public bool Input3 { get; set; }
        public bool Input4 { get; set; }
        public bool Input5 { get; set; }
        public bool Input6 { get; set; }

        // Свойства для операторов
        public string Operator1 { get; set; }
        public string Operator2 { get; set; }
        public string Operator3 { get; set; }
        public string Operator4 { get; set; }
        public string Operator5 { get; set; }
    }
}
