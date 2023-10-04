using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LogikaSkeem.Models
{
    public class NotGate : LogicGate
    {
        public NotGate(string name) : base(name, (input1, input2) => input1 != input2) { }
    }

}
