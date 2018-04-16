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
        List<Agent> _agents;
        int _agentsNumber;
        float _maxValue;
        float _meanValue;

        public Generation()
        {
            _agents = new List<Agent>();
            _maxValue = float.MinValue;
            _meanValue = 0f;
            _agentsNumber = 0;
        }

        public Generation(int count)
        {
            _agents = new List<Agent>();
            _maxValue = float.MinValue;
            _meanValue = 0f;
            _agentsNumber = count;
        }

        public List<Agent> Agents
        {
            get
            {
                return _agents;
            }
        }

        public float MaxValue
        {
            get
            {
                return _maxValue;
            }
        }

        public float MeanValue
        {
            get
            {
                return _meanValue;
            }
        }

        public IEnumerator<Agent> GetEnumerator()
        {
            return _agents.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public void SetMaxGenerationValue()
        {
            if (_agents != null && _agents.Count > 0)
            {
                _maxValue = _agents.Select(o => o.FunctionValue).Max();
            }
            else
            {
                throw new ApplicationException("Agents population should be greater than 0!");
            }
        }

        public void SetMeanGeerationValue()
        {
            if (_agents != null && _agents.Count > 0)
            {
                _meanValue = _agents.Select(o => o.FunctionValue).Average();
            }
            else
            {
                throw new ApplicationException("Agents population should be greater than 0!");
            }
        }
    }
}
