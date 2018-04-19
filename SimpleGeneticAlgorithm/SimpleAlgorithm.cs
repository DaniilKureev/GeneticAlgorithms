using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleGeneticAlgorithm
{
  public static class SimpleAlgorithm
  {
    public static int CalculateChromosomeLength(int precision, int lowerBound, int upperBound)
    {
      double itervalsNumber = (upperBound - lowerBound) * Math.Pow(10, precision);
      return (int)Math.Ceiling(Math.Log(itervalsNumber, 2));
    }
  }
}

