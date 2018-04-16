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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ParametersGroup = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.StartButton = new System.Windows.Forms.Button();
            this.ResultGroup = new System.Windows.Forms.GroupBox();
            this.ClearButton = new System.Windows.Forms.Button();
            this.CrossoverText = new System.Windows.Forms.TextBox();
            this.MutationText = new System.Windows.Forms.TextBox();
            this.AgentsNumberText = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.ParametersGroup.SuspendLayout();
            this.ResultGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea7.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea7);
            legend7.Name = "Legend1";
            this.chart1.Legends.Add(legend7);
            this.chart1.Location = new System.Drawing.Point(12, 12);
            this.chart1.Name = "chart1";
            series7.ChartArea = "ChartArea1";
            series7.Legend = "Legend1";
            series7.Name = "Series1";
            this.chart1.Series.Add(series7);
            this.chart1.Size = new System.Drawing.Size(835, 519);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // ParametersGroup
            // 
            this.ParametersGroup.Controls.Add(this.AgentsNumberText);
            this.ParametersGroup.Controls.Add(this.MutationText);
            this.ParametersGroup.Controls.Add(this.CrossoverText);
            this.ParametersGroup.Controls.Add(this.label3);
            this.ParametersGroup.Controls.Add(this.label2);
            this.ParametersGroup.Controls.Add(this.label1);
            this.ParametersGroup.Controls.Add(this.StartButton);
            this.ParametersGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ParametersGroup.Location = new System.Drawing.Point(868, 12);
            this.ParametersGroup.Name = "ParametersGroup";
            this.ParametersGroup.Size = new System.Drawing.Size(307, 336);
            this.ParametersGroup.TabIndex = 1;
            this.ParametersGroup.TabStop = false;
            this.ParametersGroup.Text = "Parameters";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(9, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Number of agents:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(9, 119);
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
            this.ResultGroup.Name = "ResultGroup";
            this.ResultGroup.Size = new System.Drawing.Size(307, 239);
            this.ResultGroup.TabIndex = 2;
            this.ResultGroup.TabStop = false;
            this.ResultGroup.Text = "Result";
            // 
            // ClearButton
            // 
            this.ClearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClearButton.Location = new System.Drawing.Point(41, 183);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(235, 39);
            this.ClearButton.TabIndex = 0;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // CrossoverText
            // 
            this.CrossoverText.Location = new System.Drawing.Point(206, 43);
            this.CrossoverText.Name = "CrossoverText";
            this.CrossoverText.Size = new System.Drawing.Size(95, 34);
            this.CrossoverText.TabIndex = 4;
            // 
            // MutationText
            // 
            this.MutationText.Location = new System.Drawing.Point(206, 113);
            this.MutationText.Name = "MutationText";
            this.MutationText.Size = new System.Drawing.Size(95, 34);
            this.MutationText.TabIndex = 5;
            // 
            // AgentsNumberText
            // 
            this.AgentsNumberText.Location = new System.Drawing.Point(206, 185);
            this.AgentsNumberText.Name = "AgentsNumberText";
            this.AgentsNumberText.Size = new System.Drawing.Size(95, 34);
            this.AgentsNumberText.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1187, 605);
            this.Controls.Add(this.ResultGroup);
            this.Controls.Add(this.ParametersGroup);
            this.Controls.Add(this.chart1);
            this.Name = "Form1";
            this.Text = "Genetic algorithm";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ParametersGroup.ResumeLayout(false);
            this.ParametersGroup.PerformLayout();
            this.ResultGroup.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.GroupBox ParametersGroup;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.GroupBox ResultGroup;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.TextBox AgentsNumberText;
        private System.Windows.Forms.TextBox MutationText;
        private System.Windows.Forms.TextBox CrossoverText;
    }
}

