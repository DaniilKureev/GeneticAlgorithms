using System;
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
        public Form1()
        {
            InitializeComponent();
            ResultGroup.Enabled = false;
            StartPosition = FormStartPosition.CenterScreen;
            Chart.ChartAreas.Add(new ChartArea("Math functions"));
            Chart.Dock = DockStyle.Fill;
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
            int chromosomeLength = SimpleAlgorithmHelper.CalculateChromosomeLength(precision, lowerBound, upperBound);
            Generation generation = new Generation(agentsCount, chromosomeLength, Consts.LowerBound, Consts.UpperBound, 0);
            generation.CreateFirstPoppulation();
            var agents = generation.ToList();
            Series mySeriesOfPoint = new Series("Cos(X)*(3-x)");
            mySeriesOfPoint.ChartType = SeriesChartType.Line;
            mySeriesOfPoint.ChartArea = "Math functions";
            for (float i = Consts.LowerBound; i <= Consts.UpperBound; i += 0.0001f)
            {
                mySeriesOfPoint.Points.AddXY(i, SimpleAlgorithmHelper.SetFunctionValue(i));
            }
            //Добавляем созданный набор точек в Chart
            Chart.Series.Add(mySeriesOfPoint);
        }
    }
}
