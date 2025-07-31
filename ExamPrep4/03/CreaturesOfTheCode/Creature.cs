using System.Text;

namespace CreaturesOfTheCode
{
    public class Creature
    {
      public string Name {  get; set; }
        public string Kind {  get; set; }
        public int Health {  get; set; }
        private List<string> abilities;
        public List<string> Abilities=>abilities;

        public Creature(string name, string kind, int health,  string abilities)
        {
            Name=name;
            Kind=kind;
            Health=health;
            this.abilities=abilities.Split(", ").ToList();        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{Name} ({Kind}) has {Health} HP");
            sb.AppendLine($"Abilities: {string.Join(", ", abilities)}");
            return sb.ToString().Trim();
        }

    }
}
