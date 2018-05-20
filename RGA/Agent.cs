using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RGA
{
  public class Agent
  {
    public List<float> Chromosome { get; set; }
    public float X { get; set; }
    public float Y { get; set; }
    public float SelectionProbality { get; set; }
  }
}
