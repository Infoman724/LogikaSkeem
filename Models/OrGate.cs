
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LogikaSkeem.Models
{
    /*public class OrGate
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        [ForeignKey("InputChannel1")]
        public int InputChannel1Id { get; set; }
        public bool InputChannel1State { get; set; }

        [ForeignKey("InputChannel2")]
        public int InputChannel2Id { get; set; }
        public bool InputChannel2State { get; set; }

        public bool OutputState { get; set; }

        public void CalculateOutput()
        {
            OutputState = InputChannel1State || InputChannel2State;
        }
    }*/
    public class OrGate : LogicGate
    {
        public OrGate(string name) : base(name, (input1, input2) => input1 || input2) { }
    }
}



