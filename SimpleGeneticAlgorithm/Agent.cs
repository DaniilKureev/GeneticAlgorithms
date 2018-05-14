using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleGeneticAlgorithm
{
  public class Agent
  {
    float realY;
    float realX;
    int integerX;

    BitArray chromosome;

    int lowerIntevalBound;
    int upperIntervalBound;
    int intervalsCount;

    float selectionProbability;

    public Agent() { }

    public Agent(int xValue, int chromosomeLength, int intervalsCount, int lowerBound, int upperBound)
    {
      integerX = xValue;
      lowerIntevalBound = lowerBound;
      upperIntervalBound = upperBound;
      this.intervalsCount = intervalsCount;
      chromosome = SimpleAlgorithmHelper.ToBitArray(integerX, chromosomeLength);
      realX = SimpleAlgorithmHelper.ToRealValue(integerX, lowerIntevalBound, upperIntervalBound, intervalsCount);
      realY = SimpleAlgorithmHelper.SetFunctionValue(realX);
    }

    public Agent(float x, float y)
    {
      realX = x;
      realY = y;
    }

    public float Y
    {
      get { return realY; }
    }

    public float X
    {
      get { return realX; }
    }

    public BitArray Chromosome
    {
      get { return chromosome; }
    }

    public float SelectionProbability
    {
      get { return selectionProbability; }
    }

    public void SetSelectionProbability(float sumOfWholeValues)
    {
      if(sumOfWholeValues != 0)
      {
        selectionProbability = realY / sumOfWholeValues;
      }
    }
  }
}
