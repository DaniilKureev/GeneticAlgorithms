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
    float selectionProbability;

    public Agent() { }

    public Agent(int xValue, int chromosomeLength)
    {
      integerX = xValue;
      chromosome = SimpleAlgorithmHelper.ToBitArray(integerX, chromosomeLength);
      realX = SimpleAlgorithmHelper.ToRealValue(integerX, Consts.LowerBound, Consts.UpperBound, (int)Math.Pow(2, chromosomeLength) - 1);
      realY = SimpleAlgorithmHelper.SetFunctionValue(realX);
    }

    public Agent(float x, float y)
    {
      realX = x;
      realY = y;
    }

    public Agent(BitArray chrom)
    {
      if (chrom == null) throw new NullReferenceException();
      chromosome = chrom;
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
      get
      {
        return chromosome;
      }
      set
      {
        chromosome = value;
      }
    }

    public float SelectionProbability
    {
      get
      {
        return selectionProbability;
      }
    }

    public void SetSelectionProbability(float sumOfWholeValues)
    {
      if(sumOfWholeValues != 0)
      {
        selectionProbability = realY / sumOfWholeValues;
      }
    }

    public void CalculateParametersFromChromosome()
    {
      if (chromosome == null) throw new NullReferenceException();

      integerX = SimpleAlgorithmHelper.FromBitArrayToInt32(chromosome);
      realX = SimpleAlgorithmHelper.ToRealValue(integerX, Consts.LowerBound, Consts.UpperBound, (int)Math.Pow(2, chromosome.Count) - 1);
      realY = SimpleAlgorithmHelper.SetFunctionValue(realX);
    }
  }
}
