using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleGeneticAlgorithm
{
  public static class SimpleAlgorithmHelper
  {
    public static int CalculateChromosomeLength(int precision, int lowerBound, int upperBound)
    {
      double itervalsNumber = (upperBound - lowerBound) * Math.Pow(10, precision);
      return (int)Math.Ceiling(Math.Log(itervalsNumber, 2));
    }

    public static BitArray ToBitArray(int x, int registersNumber) // registersNumber == chromosomeLenght
    {
      string s = Convert.ToString(x, 2);
      if (s.Length > registersNumber) throw new ArgumentException("Very huge number!");
      string normalString = s.PadLeft(registersNumber, '0');
      bool[] bits = new bool[registersNumber];
      int n = 0;
      for (int i = normalString.Length - 1; i >= 0; i--)
      {
        bits[n] = Convert.ToBoolean(byte.Parse(normalString[i].ToString()));
        n++;
      }
      return new BitArray(bits);
    }

    public static int FromBitArrayToInt32(BitArray bits)
    {
      if (bits.Length > 32) throw new ArgumentException("Must be at most 32 bits long");
      var result = new int[1];
      bits.CopyTo(result, 0);
      return result[0];
    }

    public static float ToRealValue(int x, int lowerBound, int upperBound, int intervalsCount)
    {
      if (intervalsCount < 1) throw new ArgumentException("Number of intervals shuld be positive!");
      return lowerBound + x * (upperBound - lowerBound) / (float)intervalsCount;
    }

    public static float SetFunctionValue(float realX)
    {
      return (float)((realX - 1) * Math.Cos(3 * realX - 15));
    }

    public static void CalculateParameters(this Generation generation)
    {
      generation.SetMaxGenerationValue();
      generation.SetMeanGenerationValue();
      generation.SetSumForGenerationValues();
    }

    public static Generation Reproduction(Generation originalPopulation, uint agentsCount)
    {
      List<int> agentNumber = new List<int>();
      List<Agent> agents = new List<Agent>();
      float minY = originalPopulation.Select(o => o.Y).Min();
      Generation tempGeneration = new Generation(originalPopulation.Agents.Select(o => new Agent(o.X, o.Y + Math.Abs(minY))));
      tempGeneration.SetSumForGenerationValues();

      foreach (var agent in tempGeneration)
      {
        agent.SetSelectionProbability(tempGeneration.ValuesSum);
        agentNumber.Add((int)Math.Round(agent.SelectionProbability * agentsCount));
      }

      var newPopulationSize = agentNumber.Sum();
      while (newPopulationSize < agentsCount)
      {
        int item = agentNumber.First(o => o > 0);
        item++;
        newPopulationSize = agentNumber.Sum();
      }

      for (int i = 0; i < agentsCount; i++)
      {
        int n = agentNumber[i];
        for(int j = 0; j < n; j++)
        {
          agents.Add(originalPopulation.Agents[i]);
        }
      }

      return new Generation(agents);
    }
  }
}

