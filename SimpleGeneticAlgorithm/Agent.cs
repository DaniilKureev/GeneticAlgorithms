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
    float y;
    float x;
    BitArray chromosome;
    float selectionProbability = 1f;

    public Agent() { }

    public Agent(float xValue, int precision)
    {
      chromosome = new BitArray(precision);
      x = xValue;
      SetFunctionValue();
    }

    public float FunctionValue
    {
      get { return y; }
    }

    private void SetFunctionValue()
    {
      y = (float)((x - 1) * Math.Cos(3 * x - 15));
    }
  }
}
