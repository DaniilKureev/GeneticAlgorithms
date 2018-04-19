﻿using System;
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
        bits[n] =  Convert.ToBoolean(byte.Parse(normalString[i].ToString()));
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
  }
}
