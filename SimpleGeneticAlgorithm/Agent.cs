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
        float _yValue;
        float _xValue;
        BitArray _chromosome;

        public Agent() { }

        public Agent(float xValue, int precision)
        {
           _chromosome = new BitArray(precision);
            _xValue = xValue;
            SetFunctionValue();
        }

        public float FunctionValue
        {
            get
            {
                return _yValue;
            }
        }

        private void SetFunctionValue()
        {
            _yValue = (float)Math.Cos(_xValue);
        }
    }
}
