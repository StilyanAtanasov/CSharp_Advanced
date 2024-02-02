using _09._Pokemon_Trainer;

List<Trainer> trainers = new();

string command;
while ((command = Console.ReadLine()!) != "Tournament")
{
    string[] pokemonInfo = command.Split();

    string trainerName = pokemonInfo[0];
    string pokemonName = pokemonInfo[1];
    string pokemonElement = pokemonInfo[2];
    int pokemonHealth = int.Parse(pokemonInfo[3]);

    if (trainers.FirstOrDefault(t => t.Name == trainerName) == null)
    {
        Trainer trainer = new Trainer(trainerName);
        trainer.PokemonCollection.Add(new Pokemon(pokemonName, pokemonElement, pokemonHealth));
        trainers.Add(trainer);
    }
    else trainers.First(t => t.Name == trainerName).PokemonCollection.Add(new Pokemon(pokemonName, pokemonElement, pokemonHealth));
}

while ((command = Console.ReadLine()!) != "End")
{
    string element = command;

    foreach (Trainer trainer in trainers)
    {
        if (trainer.PokemonCollection.FirstOrDefault(p => p.Element == element) != null) trainer.BadgesCount++;
        else
        {
            for (int j = 0; j < trainer.PokemonCollection.Count; j++)
            {
                Pokemon pokemon = trainer.PokemonCollection[j];
                pokemon.Health -= 10;
                if (pokemon.Health <= 0)
                {
                    trainer.PokemonCollection.Remove(pokemon);
                    j--;
                }
            }
        }
    }
}

foreach (Trainer trainer in trainers.OrderByDescending(t => t.BadgesCount)) Console.WriteLine($"{trainer.Name} {trainer.BadgesCount} {trainer.PokemonCollection.Count}");