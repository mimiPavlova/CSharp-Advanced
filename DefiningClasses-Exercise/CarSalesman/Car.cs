using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSalesman
{
    public class Car
    {
        public string Model { get; set; }
        public Engine Engine { get; set; }
        public int? Weight { get; set; }
        public string Color { get; set; } = "n/a";

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(this.Model+":");
            sb.AppendLine("  "+this.Engine.Model+":");
            sb.AppendLine($"    Power: {Engine.Power}");


            if (Engine.Displacement.HasValue)
            {
                sb.AppendLine($"    Displacement: {this.Engine.Displacement}");
            }
            else
            {
                sb.AppendLine("    Displacement: n/a");
            }
            
            sb.AppendLine($"    Efficiency: {this.Engine.Efficiency}");

            if (this.Weight.HasValue)
            {
                sb.AppendLine($"  Weight: {this.Weight}");
            }
            else
            {
                sb.AppendLine("  Weight: n/a");
            }
            

            sb.AppendLine($"  Color: {this.Color}");

            return sb.ToString().Trim();

        } 
            
        

    }
}
