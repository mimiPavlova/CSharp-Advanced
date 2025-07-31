using System.Text;

namespace CreaturesOfTheCode
{
    public class MythicalCreaturesHub
    {
        private List<Creature> _creatures;
        public List<Creature> Creatures => _creatures;
        public int Capacity { get; set; }
        public MythicalCreaturesHub(int capacity)
        {
            Capacity = capacity;
            _creatures = new List<Creature>();
        }
        public void AddCreature(Creature creature)
        {
            if (!_creatures.Any(c => c.Name.Equals(creature.Name, StringComparison.OrdinalIgnoreCase)&&creature!=null))
            {
                if (_creatures.Count<Capacity) 
                _creatures.Add(creature);
            }
        }
        public bool RemoveCreature(string name)
        {
            Creature creature = _creatures.FirstOrDefault(c => c.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
            if (creature!=null)
            {
                _creatures.Remove(creature);
                return true;
            }
            return false;
        }
        public Creature GetStrongestCreature()
        {
            return _creatures.OrderByDescending(c => c.Health).FirstOrDefault();
        }

        public string Details(string creatureName)
        {
            Creature creature = _creatures.FirstOrDefault(c => c.Name==creatureName);
            if (creature is null)
            {
                return $"Creature with the name {creatureName} not found.";
            }
            return creature.ToString();
        }
        public string GetAllCreatures()
        {
            var sorted = _creatures.OrderBy(c => c.Name);
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("Mythical Creatures:");
            foreach (var creature in sorted)
            {

                builder.AppendLine($"{creature.Name} -> {creature.Kind}");

            }
            return builder.ToString().Trim();
        }


    }


}
