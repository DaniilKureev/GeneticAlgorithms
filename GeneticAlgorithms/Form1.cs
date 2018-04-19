using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimpleGeneticAlgorithm;

namespace GeneticAlgorithms
{
  // 6 Вариант
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
      ResultGroup.Enabled = false;
      StartPosition = FormStartPosition.CenterScreen;
    }

    private void StartButton_Click(object sender, EventArgs e)
    {
      int precision;
      float mutationProbability;
      float crossProbabilty;
      uint agentsNumber;
      if (!float.TryParse(CrossoverText.Text, out crossProbabilty))
      {
        CrossoverText.Focus();
        MessageBox.Show("Enter crossover probabilty", "Warning", MessageBoxButtons.OK);
        return;
      }
      if (!float.TryParse(MutationText.Text, out mutationProbability))
      {
        CrossoverText.Focus();
        MessageBox.Show("Enter mutation probabilty", "Warning", MessageBoxButtons.OK);
        return;
      }
      if (!int.TryParse(PrecisionText.Text, out precision) && precision < 0)
      {
        CrossoverText.Focus();
        MessageBox.Show("Enter mutation probabilty", "Warning", MessageBoxButtons.OK);
        return;
      }
      if (!uint.TryParse(AgentsNumberText.Text, out agentsNumber) && agentsNumber < 1)
      {
        CrossoverText.Focus();
        MessageBox.Show("Enter mutation probabilty", "Warning", MessageBoxButtons.OK);
        return;
      }
      ResultGroup.Enabled = true;
      try
      {
        ProcessGeneticAlgortihm(precision, agentsNumber, mutationProbability, crossProbabilty, Consts.MaxIterationValue, Consts.LowerBound, Consts.UpperBound);
      }
      catch (ApplicationException ex)
      {
        MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK);
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message, "Fatal error! =(", MessageBoxButtons.OK);
      }
    }

    private void ClearButton_Click(object sender, EventArgs e)
    {

    }
    private void ProcessGeneticAlgortihm(int precision, uint agentsCount, float mutationProbability, float crossProbabilty, int maxIterationValue, int lowerBound, int upperBound)
    {
      int chromosomeLength = SimpleAlgorithm.CalculateChromosomeLength(precision, lowerBound, upperBound);
      //int scalesCount = (int)Math.Pow(2, chromosomeLength);

      Generation generation = new Generation(agentsCount, chromosomeLength, 0);
      generation.CreateFirstPoppulation();
    }
  }
}
