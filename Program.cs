using System;
using System.Collections.Generic;

namespace lists
{
  class Program
  {
    static void Main(string[] args)
    {
      List<string> planetList = new List<string>() { "Mercury", "Mars" };
      planetList.Add("Jupiter");
      planetList.Add("Saturn");
      planetList.ForEach(planet => Console.WriteLine(planet));

      List<string> newPlanets = new List<string>() { "Uranus", "Neptune" };
      planetList.AddRange(newPlanets);
      Console.WriteLine("Planet List after adding last two planets");
      planetList.ForEach(planet => Console.WriteLine(planet));

      List<string> insertPlanets = new List<string>() { "Venus", "Earth" };
      planetList.InsertRange(1, insertPlanets);
      Console.WriteLine("Planet List after adding Earth and Venus");

      planetList.ForEach(planet => Console.WriteLine(planet));
      planetList.Add("Pluto");
      Console.WriteLine("Full planet list");
      planetList.ForEach(planet => Console.WriteLine(planet));

      List<string> rockyPlanets = planetList.GetRange(0, 4);
      Console.WriteLine("Rocky Planets");
      rockyPlanets.ForEach(planet => Console.WriteLine(planet));

      planetList.Remove("Pluto");
      Console.WriteLine("Planets without Pluto");
      planetList.ForEach(planet => Console.WriteLine(planet));
    }
  }
}
