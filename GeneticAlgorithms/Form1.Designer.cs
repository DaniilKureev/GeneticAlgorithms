namespace GeneticAlgorithms
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.Chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ParametersGroup = new System.Windows.Forms.GroupBox();
            this.AgentsNumberText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.PrecisionText = new System.Windows.Forms.TextBox();
            this.MutationText = new System.Windows.Forms.TextBox();
            this.CrossoverText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.StartButton = new System.Windows.Forms.Button();
            this.ResultGroup = new System.Windows.Forms.GroupBox();
            this.ClearButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Chart)).BeginInit();
            this.ParametersGroup.SuspendLayout();
            this.ResultGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // Chart
            // 
            chartArea1.Name = "ChartArea1";
            this.Chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.Chart.Legends.Add(legend1);
            this.Chart.Location = new System.Drawing.Point(12, 12);
            this.Chart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Chart.Name = "Chart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.Chart.Series.Add(series1);
            this.Chart.Size = new System.Drawing.Size(835, 519);
            this.Chart.TabIndex = 0;
            this.Chart.Text = "Chart";
            // 
            // ParametersGroup
            // 
            this.ParametersGroup.Controls.Add(this.AgentsNumberText);
            this.ParametersGroup.Controls.Add(this.label4);
            this.ParametersGroup.Controls.Add(this.PrecisionText);
            this.ParametersGroup.Controls.Add(this.MutationText);
            this.ParametersGroup.Controls.Add(this.CrossoverText);
            this.ParametersGroup.Controls.Add(this.label3);
            this.ParametersGroup.Controls.Add(this.label2);
            this.ParametersGroup.Controls.Add(this.label1);
            this.ParametersGroup.Controls.Add(this.StartButton);
            this.ParametersGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ParametersGroup.Location = new System.Drawing.Point(868, 12);
            this.ParametersGroup.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ParametersGroup.Name = "ParametersGroup";
            this.ParametersGroup.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ParametersGroup.Size = new System.Drawing.Size(307, 336);
            this.ParametersGroup.TabIndex = 1;
            this.ParametersGroup.TabStop = false;
            this.ParametersGroup.Text = "Parameters";
            // 
            // AgentsNumberText
            // 
            this.AgentsNumberText.Location = new System.Drawing.Point(205, 212);
            this.AgentsNumberText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AgentsNumberText.Name = "AgentsNumberText";
            this.AgentsNumberText.Size = new System.Drawing.Size(93, 34);
            this.AgentsNumberText.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(9, 226);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Agents number:";
            // 
            // PrecisionText
            // 
            this.PrecisionText.Location = new System.Drawing.Point(205, 155);
            this.PrecisionText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PrecisionText.Name = "PrecisionText";
            this.PrecisionText.Size = new System.Drawing.Size(95, 34);
            this.PrecisionText.TabIndex = 6;
            // 
            // MutationText
            // 
            this.MutationText.Location = new System.Drawing.Point(205, 98);
            this.MutationText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MutationText.Name = "MutationText";
            this.MutationText.Size = new System.Drawing.Size(95, 34);
            this.MutationText.TabIndex = 5;
            // 
            // CrossoverText
            // 
            this.CrossoverText.Location = new System.Drawing.Point(205, 43);
            this.CrossoverText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CrossoverText.Name = "CrossoverText";
            this.CrossoverText.Size = new System.Drawing.Size(95, 34);
            this.CrossoverText.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(9, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Precision:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(9, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mutation probabilty:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(9, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Сrossover probability:";
            // 
            // StartButton
            // 
            this.StartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartButton.Location = new System.Drawing.Point(41, 270);
            this.StartButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(235, 38);
            this.StartButton.TabIndex = 0;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // ResultGroup
            // 
            this.ResultGroup.Controls.Add(this.ClearButton);
            this.ResultGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResultGroup.Location = new System.Drawing.Point(868, 354);
            this.ResultGroup.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ResultGroup.Name = "ResultGroup";
            this.ResultGroup.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ResultGroup.Size = new System.Drawing.Size(307, 239);
            this.ResultGroup.TabIndex = 2;
            this.ResultGroup.TabStop = false;
            this.ResultGroup.Text = "Result";
            // 
            // ClearButton
            // 
            this.ClearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClearButton.Location = new System.Drawing.Point(41, 183);
            this.ClearButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(235, 39);
            this.ClearButton.TabIndex = 0;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1187, 606);
            this.Controls.Add(this.ResultGroup);
            this.Controls.Add(this.ParametersGroup);
            this.Controls.Add(this.Chart);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Genetic algorithm";
            ((System.ComponentModel.ISupportInitialize)(this.Chart)).EndInit();
            this.ParametersGroup.ResumeLayout(false);
            this.ParametersGroup.PerformLayout();
            this.ResultGroup.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart Chart;
        private System.Windows.Forms.GroupBox ParametersGroup;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.GroupBox ResultGroup;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.TextBox PrecisionText;
        private System.Windows.Forms.TextBox MutationText;
        private System.Windows.Forms.TextBox CrossoverText;
    private System.Windows.Forms.TextBox AgentsNumberText;
    private System.Windows.Forms.Label label4;
  }
}

