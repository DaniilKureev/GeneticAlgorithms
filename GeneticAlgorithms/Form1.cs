﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using SimpleGeneticAlgorithm;

namespace GeneticAlgorithms
{
  // 6 Вариант
  public partial class Form1 : Form
  {

    List<Generation> history;

    public Form1()
    {
      InitializeComponent();
      ResultGroup.Enabled = false;
      StartPosition = FormStartPosition.CenterScreen;
      Chart.Dock = DockStyle.Fill;
      Chart.ChartAreas.Add(new ChartArea("Math functions"));
      CrossoverText.Text = "0.5";
      MutationText.Text = "0.01";
      PrecisionText.Text = "3";
      AgentsNumberText.Text = "100";
      history = new List<Generation>();
    }

    private void StartButton_Click(object sender, EventArgs e)
    {
      int precision;
      float mutationProbability;
      float crossProbabilty;
      int agentsNumber;
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
        MessageBox.Show("Enter precision", "Warning", MessageBoxButtons.OK);
        return;
      }
      if (!int.TryParse(AgentsNumberText.Text, out agentsNumber) && agentsNumber < 1)
      {
        CrossoverText.Focus();
        MessageBox.Show("Enter agents number", "Warning", MessageBoxButtons.OK);
        return;
      }
      ResultGroup.Enabled = true;
      try
      {
        ProcessGeneticAlgortihm(precision, agentsNumber, mutationProbability, crossProbabilty);
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

    private void ProcessGeneticAlgortihm(int precision, int agentsCount, float mutationProbability, float crossProbabilty)
    {
      int chromosomeLength = SimpleAlgorithmHelper.CalculateChromosomeLength(precision, Consts.LowerBound, Consts.UpperBound);
      
      //First generation:
      Generation generation = new Generation(agentsCount, chromosomeLength, 0);
      generation.CreateFirstPoppulation();
      generation.CalculateParameters();
      
      //Add to history:
      history.Add(generation);

      int generationNumber = 0;

      while (generationNumber <= Consts.MaxIterationValue && generation.MaxValue != generation.MeanValue)
      {
        generationNumber++;
        Generation nextGeneration = SimpleAlgorithm.Reproduction(generation, agentsCount);
        SimpleAlgorithm.Crossover(nextGeneration, crossProbabilty);
        SimpleAlgorithm.Mutation(nextGeneration, mutationProbability);
        nextGeneration.Agents.ForEach(agent => agent.CalculateParametersFromChromosome());
        nextGeneration.CalculateParameters();
        generation = nextGeneration;
        nextGeneration = null;
      }

      /********************* Chart *****************************/
      string seriesName = "(x - 1)Cos(3x - 15)";
      Chart.ChartAreas[0].AxisX.Minimum = Consts.LowerBound;
      Chart.ChartAreas[0].AxisX.Maximum = Consts.UpperBound;
      Chart.ChartAreas[0].AxisX.MajorGrid.Interval = 1;
      Series mySeriesOfPoint = new Series(seriesName);
      mySeriesOfPoint.ChartType = SeriesChartType.Line;
      mySeriesOfPoint.Color = Color.Blue;
      mySeriesOfPoint.ChartArea = "Math functions";
      for (float i = Consts.LowerBound; i <= Consts.UpperBound; i += 0.001f)
      {      
        mySeriesOfPoint.Points.AddXY(i, SimpleAlgorithmHelper.SetFunctionValue(i));
      }
      /*foreach(var agent in generation)
      {
        DataPoint dp = new DataPoint(agent.X, agent.Y);
        dp.MarkerStyle = MarkerStyle.Circle;
        //dp.IsValueShownAsLabel = true; //Показать значение в точке
        mySeriesOfPoint.Points.Add(dp);
      }*/

      //Добавляем созданный набор точек в Chart
      Chart.Series.Add(mySeriesOfPoint);
      /********************* Chart *****************************/
    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }
  }
}
