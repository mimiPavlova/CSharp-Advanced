namespace PokemonTrainer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command;
            Dictionary<string, Trainer> trainers = new Dictionary<string, Trainer>();
            while ((command=Console.ReadLine())!="Tournament")
            {
                string[] data = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string trainerName=data[0];
                string pokemonName=data[1];
                string element=data[2];
                int helth=int.Parse(data[3]);

                if (!trainers.ContainsKey(trainerName))
                {
                    trainers.Add(trainerName, new Trainer { Name=trainerName });

                }
                trainers[trainerName].Pokemons.Add(new Pokemon { Name=pokemonName, Element=element, Health=helth });


            }
            while ((command=Console.ReadLine())!="End")
            {
                string element = command;

                foreach (Trainer trainer in trainers.Values)
                {

                    if (trainer.Pokemons.Any(p => p.Element==element))
                    {
                        trainer.NumberOfBadges+=1;
                       
                    }
                    else
                    {
                        trainer.Pokemons.ForEach(p => p.Health-=10); 
                        trainer.RemoveDeadPokemons();
                    }

                }

            }
            foreach  (var trainer  in trainers.Values.OrderByDescending(t=>t.NumberOfBadges))
            {
                Console.WriteLine($"{trainer.Name} {trainer.NumberOfBadges} {trainer.Pokemons.Count}");
            }

        }
    }
}
