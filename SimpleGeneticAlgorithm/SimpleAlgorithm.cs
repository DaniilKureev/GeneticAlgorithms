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
      /*while (newPopulationSize < agentsCount)
      {
        int item = agentNumber.First(o => o > 0);
        item++;
        newPopulationSize = agentNumber.Sum();
      }*/

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

    public static void Crossover(Generation population, float probability)
    {
      int chromosomeLength = population.Agents.First().Chromosome.Count;
      int agentsCount = population.Agents.Count;
      List<Agent> newAgents = new List<Agent>();
      Random rand = new Random();

      for (int i = 0; i < agentsCount; i += 2)
      {
        var p = rand.NextDouble();
        if (p <= probability)
        {
          int k = rand.Next(0, chromosomeLength);
          Agent a = population.Agents[i];
          Agent b = i != agentsCount - 1 ? population.Agents[i + 1] : null;
          if (b != null)
          {
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
            newAgents.Add(newA);
            newAgents.Add(newB);
          }
          else
          {
            newAgents.Add(a);
          }
        }
        else
        {
          Agent a = population.Agents[i];
          Agent b = i != agentsCount - 1 ? population.Agents[i + 1] : null;
          if (b != null)
          {
            newAgents.Add(a);
            newAgents.Add(b);
          }
          else
          {
            newAgents.Add(a);
          }
        }
      }
      population = new Generation(newAgents);
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
        int position = rand.Next(0, agentsCount);
        population.Agents[agentNumber].Chromosome.Set(position, !population.Agents[agentNumber].Chromosome.Get(position));
      }
    }
  }
}
