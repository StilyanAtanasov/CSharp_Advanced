using System.Text;

namespace SharkTaxonomy;
public class Classifier
{
    public Classifier(int capacity)
    {
        Capacity = capacity;
        Species = new();
    }

    public int Capacity { get; set; }
    public List<Shark> Species { get; set; }
    public int GetCount => Species.Count;

    /// <summary>Adds a Shark to the Species collection, if the Capacity allows it and there is not a Shark from the same Kind already added</summary>
    /// <param name="shark"></param>
    public void AddShark(Shark shark)
    {
        if (GetCount < Capacity && Species.FirstOrDefault(s => s.Kind == shark.Kind) == null) Species.Add(shark);
    }

    /// <summary>Attempts to find a Shark, within the Species collection, with Kind value, matching the given parameter</summary>
    /// <param name="kind"></param>
    /// <returns></returns>
    public bool RemoveShark(string kind) => Species.Remove(Species.FirstOrDefault(s => s.Kind == kind)!);

    /// <summary>Returns the ToString() value of the largest of all sharks, arranged by length.</summary>
    /// <returns></returns>
    public string GetLargestShark() => Species.OrderByDescending(s => s.Length).First().ToString();

    /// <summary>Returns the average length of the sharks added to the collection.</summary>
    /// <returns></returns>
    public double GetAverageLength() => Species.Average(s => s.Length);

    /// <summary>Returns a string in the following format: {count} sharks classified:\n{shark1}\n{shark2}\n{…}\n{sharkn}</summary>
    /// <returns></returns>
    public string Report()
    {
        StringBuilder sb = new();

        sb.AppendLine($"{GetCount} sharks classified:");
        foreach (Shark shark in Species)sb.AppendLine(shark.ToString());

        return sb.ToString().TrimEnd();
    }
}