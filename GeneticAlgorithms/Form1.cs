using SimpleGeneticAlgorithm;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace GeneticAlgorithms
{
  // 6 Вариант
  public partial class Form1 : Form
  {
    List<Generation> history;
    static int iteration;

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
      iteration = 0;
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
      history = new List<Generation>();
      iteration = 0;
      if (Chart.Series.Count > 1)
      {
        Chart.Series.RemoveAt(1);
      }
      MeanLabel.Text = Consts.Mean;
      MaxLabel.Text = Consts.Max;
      IterationLabel.Text = Consts.Iteration;
      ResultGroup.Enabled = false;
      ParametersGroup.Enabled = true;
    }

    private void ProcessGeneticAlgortihm(int precision, int agentsCount, float mutationProbability, float crossProbabilty)
    {
      int chromosomeLength = SimpleAlgorithmHelper.CalculateChromosomeLength(precision, Consts.LowerBound, Consts.UpperBound);

      //First generation:
      int generationNumber = 0;
      Generation generation = new Generation(agentsCount, chromosomeLength, 0);
      generation.CreateFirstPoppulation();
      generation.CalculateParameters();
      //Add to history:
      history.Add(generation);
      //Parameters:
      int max = (int)(generation.MaxValue * 100);
      int mean = (int)(generation.MeanValue * 100);
      // Genetic algorithm:
      while (generationNumber <= Consts.MaxIterationValue && max != mean)
      {
        generationNumber++;
        Generation nextGeneration = SimpleAlgorithm.Reproduction(generation, agentsCount);
        nextGeneration = SimpleAlgorithm.Crossover(nextGeneration, crossProbabilty);
        SimpleAlgorithm.Mutation(nextGeneration, mutationProbability);
        nextGeneration.CalculateParameters();
        generation = SimpleAlgorithm.Merge(generation, nextGeneration, agentsCount);
        history.Add(generation);
        max = (int)(generation.MaxValue * 100);
        mean = (int)(generation.MeanValue * 100);
      }

      iteration = generationNumber;
      MeanLabel.Text = Consts.Mean + generation.MeanValue.ToString("G3");
      MaxLabel.Text = Consts.Max + generation.MaxValue.ToString("G3");
      IterationLabel.Text = Consts.Iteration + iteration.ToString();

      /********************* Chart *****************************/
      string seriesName2 = "Agents";
      Series mySeriesOfPoint2 = new Series(seriesName2);
      mySeriesOfPoint2.ChartType = SeriesChartType.Point;
      mySeriesOfPoint2.Color = Color.Red;
      mySeriesOfPoint2.ChartArea = "Math functions";
      foreach (var agent in generation)
      {
        DataPoint dp = new DataPoint(agent.X, agent.Y);
        mySeriesOfPoint2.Points.Add(dp);
      }
      Chart.Series.Add(mySeriesOfPoint2);
      /********************* Chart *****************************/
      ParametersGroup.Enabled = false;
    }

    private void Form1_Load(object sender, EventArgs e)
    {
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
      //Добавляем созданный набор точек в Chart
      Chart.Series.Add(mySeriesOfPoint);
    }

    private void StepBackButton_Click(object sender, EventArgs e)
    {
      if(iteration > 0)
      {
        iteration--;
        Generation generation = history[iteration];
        Chart.Series.RemoveAt(1);
        string seriesName2 = "Agents";
        Series mySeriesOfPoint2 = new Series(seriesName2);
        mySeriesOfPoint2.ChartType = SeriesChartType.Point;
        mySeriesOfPoint2.Color = Color.Red;
        mySeriesOfPoint2.ChartArea = "Math functions";
        foreach (var agent in generation)
        {
          DataPoint dp = new DataPoint(agent.X, agent.Y);
          mySeriesOfPoint2.Points.Add(dp);
        }
        Chart.Series.Add(mySeriesOfPoint2);
        MeanLabel.Text = Consts.Mean + generation.MeanValue.ToString("G3");
        MaxLabel.Text = Consts.Max + generation.MaxValue.ToString("G3");
        IterationLabel.Text = Consts.Iteration + iteration.ToString();
      }
    }

    private void StepUpButton_Click(object sender, EventArgs e)
    {
      if (iteration < history.Count - 1)
      {
        iteration++;
        Generation generation = history[iteration];
        Chart.Series.RemoveAt(1);
        string seriesName2 = "Agents";
        Series mySeriesOfPoint2 = new Series(seriesName2);
        mySeriesOfPoint2.ChartType = SeriesChartType.Point;
        mySeriesOfPoint2.Color = Color.Red;
        mySeriesOfPoint2.ChartArea = "Math functions";
        foreach (var agent in generation)
        {
          DataPoint dp = new DataPoint(agent.X, agent.Y);
          mySeriesOfPoint2.Points.Add(dp);
        }
        Chart.Series.Add(mySeriesOfPoint2);
        MeanLabel.Text = Consts.Mean + generation.MeanValue.ToString("G3");
        MaxLabel.Text = Consts.Max + generation.MaxValue.ToString("G3");
        IterationLabel.Text = Consts.Iteration + iteration.ToString();
      }
    }

    private void FirstButton_Click(object sender, EventArgs e)
    {
      iteration = 0;
      Generation generation = history[iteration];
      Chart.Series.RemoveAt(1);
      string seriesName2 = "Agents";
      Series mySeriesOfPoint2 = new Series(seriesName2);
      mySeriesOfPoint2.ChartType = SeriesChartType.Point;
      mySeriesOfPoint2.Color = Color.Red;
      mySeriesOfPoint2.ChartArea = "Math functions";
      foreach (var agent in generation)
      {
        DataPoint dp = new DataPoint(agent.X, agent.Y);
        mySeriesOfPoint2.Points.Add(dp);
      }
      Chart.Series.Add(mySeriesOfPoint2);
      MeanLabel.Text = Consts.Mean + generation.MeanValue.ToString("G3");
      MaxLabel.Text = Consts.Max + generation.MaxValue.ToString("G3");
      IterationLabel.Text = Consts.Iteration + iteration.ToString();
    }

    private void LastButton_Click(object sender, EventArgs e)
    {
      iteration = history.Count - 1;
      Generation generation = history[iteration];
      Chart.Series.RemoveAt(1);
      string seriesName2 = "Agents";
      Series mySeriesOfPoint2 = new Series(seriesName2);
      mySeriesOfPoint2.ChartType = SeriesChartType.Point;
      mySeriesOfPoint2.Color = Color.Red;
      mySeriesOfPoint2.ChartArea = "Math functions";
      foreach (var agent in generation)
      {
        DataPoint dp = new DataPoint(agent.X, agent.Y);
        mySeriesOfPoint2.Points.Add(dp);
      }
      Chart.Series.Add(mySeriesOfPoint2);
      MeanLabel.Text = Consts.Mean + generation.MeanValue.ToString("G3");
      MaxLabel.Text = Consts.Max + generation.MaxValue.ToString("G3");
      IterationLabel.Text = Consts.Iteration + iteration.ToString();
    }
  }
}
