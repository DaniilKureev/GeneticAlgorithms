using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleGeneticAlgorithm
{
  public class Generation : IEnumerable<Agent>
  {
    List<Agent> agents;
    int agentsCount;
    float maxValue;
    float meanValue;
    int generationNumber;
    int precision;

    public Generation()
    {
      agents = new List<Agent>();
      maxValue = float.MinValue;
      meanValue = 0f;
      agentsCount = 0;
    }

    // find precision here
    public Generation(int count, int intervalLowerBound, int intervalUpperBound, int generationNumber)
    {
      agents = new List<Agent>();
      maxValue = float.MinValue;
      meanValue = 0f;
      agentsCount = count;
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
        maxValue = agents.Select(o => o.FunctionValue).Max();
      }
      else
      {
        throw new ApplicationException("Agents population should be greater than 0!");
      }
    }

    public void SetMeanGeerationValue()
    {
      if (agents != null && agents.Count > 0)
      {
        meanValue = agents.Select(o => o.FunctionValue).Average();
      }
      else
      {
        throw new ApplicationException("Agents population should be greater than 0!");
      }
    }
  }
}
