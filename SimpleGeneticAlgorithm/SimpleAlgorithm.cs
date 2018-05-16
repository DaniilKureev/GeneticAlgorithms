using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleGeneticAlgorithm
{
  public static class SimpleAlgorithm
  {
    public static Generation Reproduction(Generation originalPopulation, int agentsCount)
    {
      List<int> agentNumber = new List<int>();
      List<Agent> agents = new List<Agent>();
      float minY = originalPopulation.Select(o => o.Y).Min();
      Generation tempGeneration = new Generation(originalPopulation.Agents.Select(o => new Agent(o.X, o.Y + (minY < 0 ? Math.Abs(minY) : 0))));
      tempGeneration.CalculateParameters();

      foreach (var agent in tempGeneration)
      {
        agent.SetSelectionProbability(tempGeneration.ValuesSum);
        agentNumber.Add((int)Math.Round(agent.SelectionProbability * agentsCount));
      }

      var newPopulationSize = agentNumber.Sum();

      for (int i = 0; i < agentsCount; i++)
      {
        int n = agentNumber[i];
        for (int j = 0; j < n; j++)
        {
          agents.Add(originalPopulation.Agents[i]);
        }
      }

      return new Generation(agents);
    }

    public static Generation Crossover(Generation population, float probability)
    {
      int chromosomeLength = population.Agents.First().Chromosome.Count;
      int agentsCount = population.Agents.Count;
      List<Agent> parents = new List<Agent>(population.Agents);
      List<Agent> newAgents = new List<Agent>();
      Random rand = new Random();

      while(parents.Count > 1)
      {
        var p = rand.NextDouble();
        int firstParent = 0;
        int secondParent = rand.Next(1, parents.Count);
        Agent a = parents[firstParent];
        Agent b = parents[secondParent];
        if (p <= probability)
        {
          int k = rand.Next(0, chromosomeLength);
          BitArray first = new BitArray(chromosomeLength);
          BitArray second = new BitArray(chromosomeLength);
          for (int n = 0; n < chromosomeLength; n++)
          {
            if (n < k)
            {
              first.Set(n, a.Chromosome.Get(n));
              second.Set(n, b.Chromosome.Get(n));
            }
            else
            {
              first.Set(n, b.Chromosome.Get(n));
              second.Set(n, a.Chromosome.Get(n));
            }
          }
          Agent newA = new Agent(first);
          Agent newB = new Agent(second);
          newA.CalculateParametersFromChromosome();
          newB.CalculateParametersFromChromosome();
          newAgents.Add(newA);
          newAgents.Add(newB);
        }
        else
        {
          newAgents.Add(a);
          newAgents.Add(b);
        }
        parents.RemoveAt(secondParent);
        parents.RemoveAt(firstParent);
      }

      if (parents.Count == 1) newAgents.Add(parents.First());

      return new Generation(newAgents);
    }

    public static void Mutation(Generation population, float probability)
    {
      int chromosomeLength = population.Agents.First().Chromosome.Count;
      int agentsCount = population.Agents.Count;
      Random rand = new Random();
      var p = rand.NextDouble();
      if (p <= probability)
      {
        int agentNumber = rand.Next(0, agentsCount);
        int position = rand.Next(0, chromosomeLength);
        population.Agents[agentNumber].Chromosome.Set(position, !population.Agents[agentNumber].Chromosome.Get(position));
      }
    }

    public static Generation Merge(Generation one, Generation two, int agentsCount)
    {
      List<Agent> wholeAgents = new List<Agent>(one.Agents);
      wholeAgents.AddRange(two.Agents);
      wholeAgents.Sort(delegate (Agent a1, Agent a2) { return a2.Y.CompareTo(a1.Y); });
      Generation res = new Generation(wholeAgents.Take(agentsCount));
      res.CalculateParameters();
      return res;
    }
  }
}
