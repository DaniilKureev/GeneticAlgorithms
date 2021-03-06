﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace SimpleGeneticAlgorithm
{
  public class Generation : IEnumerable<Agent>
  {
    List<Agent> agents;
    int chromosomeLength;
    int agentsCount;
    float maxValue;
    float meanValue;
    float valuesSum;
    int generationNumber;

    public Generation()
    {
      agents = new List<Agent>();
    }

    public Generation(IEnumerable<Agent> newAgents)
    {
      if (newAgents == null) throw new NullReferenceException();
      agents = new List<Agent>(newAgents);
      agentsCount = agents.Count;
    }

    public Generation(int agentsCount, int chromosomeLength, int generationNumber)
    {
      agents = new List<Agent>();
      this.agentsCount = agentsCount;
      this.chromosomeLength = chromosomeLength;
      this.generationNumber = generationNumber;
    }

    public List<Agent> Agents
    {
      get { return agents; }
    }

    public float MaxValue
    {
      get { return maxValue; }
    }

    public float MeanValue
    {
      get { return meanValue; }
    }

    public float ValuesSum
    {
      get { return valuesSum; }
    }

    public IEnumerator<Agent> GetEnumerator()
    {
      return agents.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
      return this.GetEnumerator();
    }

    public void SetMaxGenerationValue()
    {
      if (agents != null && agents.Count > 0)
      {
        maxValue = agents.Select(o => o.Y).Max();
      }
      else
      {
        throw new ApplicationException("Agents population should be greater than 0!");
      }
    }

    public void SetMeanGenerationValue()
    {
      if (agents != null && agents.Count > 0)
      {
        meanValue = agents.Select(o => o.Y).Average();

      }
      else
      {
        throw new ApplicationException("Agents population should be greater than 0!");
      }
    }
    public void SetSumForGenerationValues()
    {
      if (agents != null && agents.Count > 0)
      {
        valuesSum = agents.Select(o => o.Y).Sum();
      }
      else
      {
        throw new ApplicationException("Agents population should be greater than 0!");
      }
    }

    public void CreateFirstPoppulation()
    {
      if (generationNumber == 0)
      {
        int scalesCount = (int)Math.Pow(2, chromosomeLength);
        int intervalsCount = scalesCount - 1; // and it's max scale value
        for (uint i = 0; i < agentsCount; i++)
        {
          int x = (int)(0 + (intervalsCount - 0.0) * i / (agentsCount - 1));
          agents.Add(new Agent(x, chromosomeLength));
        }
      }
    }

    public void CalculateParameters()
    {
      if (agents == null) throw new NullReferenceException();

      SetMaxGenerationValue();
      SetMeanGenerationValue();
      SetSumForGenerationValues();
    }
  }
}
