namespace _09._Pokemon_Trainer;

public class Trainer
{
    public Trainer(string name) => Name = name;

    public string Name { get; set; }
    public ushort BadgesCount { get; set; }
    public List<Pokemon> PokemonCollection { get; set; } = new();
}