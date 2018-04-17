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
    Generation generation;

    public Form1()
    {
      InitializeComponent();
      ResultGroup.Enabled = false;
      StartPosition = FormStartPosition.CenterScreen;
    }

    private void StartButton_Click(object sender, EventArgs e)
    {
      int agentsCount;
      float mutationProbability;
      float crossProbabilty;
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
      if (!int.TryParse(AgentsNumberText.Text, out agentsCount))
      {
        CrossoverText.Focus();
        MessageBox.Show("Enter mutation probabilty", "Warning", MessageBoxButtons.OK);
        return;
      }
      ResultGroup.Enabled = true;
      try
      {
        generation = new Generation(agentsCount, Consts.LowerBound, Consts.UpperBound, 0);
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
      generation = null;
    }
  }
}
