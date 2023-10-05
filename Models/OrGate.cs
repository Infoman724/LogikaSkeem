
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LogikaSkeem.Models
{
    
    public class OrGate : LogicGate
    {
        public OrGate(string name) : base(name, (input1, input2) => input1 || input2) { }
    }
}



