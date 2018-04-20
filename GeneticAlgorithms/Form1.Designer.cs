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
      System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
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
      legend1.Name = "Legend1";
      this.Chart.Legends.Add(legend1);
      this.Chart.Location = new System.Drawing.Point(11, 11);
      this.Chart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.Chart.Name = "Chart";
      this.Chart.Size = new System.Drawing.Size(626, 422);
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
      this.ParametersGroup.Location = new System.Drawing.Point(651, 10);
      this.ParametersGroup.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.ParametersGroup.Name = "ParametersGroup";
      this.ParametersGroup.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.ParametersGroup.Size = new System.Drawing.Size(230, 273);
      this.ParametersGroup.TabIndex = 1;
      this.ParametersGroup.TabStop = false;
      this.ParametersGroup.Text = "Parameters";
      // 
      // AgentsNumberText
      // 
      this.AgentsNumberText.Location = new System.Drawing.Point(154, 172);
      this.AgentsNumberText.Name = "AgentsNumberText";
      this.AgentsNumberText.Size = new System.Drawing.Size(71, 29);
      this.AgentsNumberText.TabIndex = 8;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label4.Location = new System.Drawing.Point(7, 184);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(108, 17);
      this.label4.TabIndex = 7;
      this.label4.Text = "Agents number:";
      // 
      // PrecisionText
      // 
      this.PrecisionText.Location = new System.Drawing.Point(154, 126);
      this.PrecisionText.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.PrecisionText.Name = "PrecisionText";
      this.PrecisionText.Size = new System.Drawing.Size(72, 29);
      this.PrecisionText.TabIndex = 6;
      // 
      // MutationText
      // 
      this.MutationText.Location = new System.Drawing.Point(154, 80);
      this.MutationText.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.MutationText.Name = "MutationText";
      this.MutationText.Size = new System.Drawing.Size(72, 29);
      this.MutationText.TabIndex = 5;
      // 
      // CrossoverText
      // 
      this.CrossoverText.Location = new System.Drawing.Point(154, 35);
      this.CrossoverText.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.CrossoverText.Name = "CrossoverText";
      this.CrossoverText.Size = new System.Drawing.Size(72, 29);
      this.CrossoverText.TabIndex = 4;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label3.Location = new System.Drawing.Point(7, 138);
      this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(70, 17);
      this.label3.TabIndex = 3;
      this.label3.Text = "Precision:";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label2.Location = new System.Drawing.Point(7, 92);
      this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(132, 17);
      this.label2.TabIndex = 2;
      this.label2.Text = "Mutation probabilty:";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label1.Location = new System.Drawing.Point(7, 42);
      this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(145, 17);
      this.label1.TabIndex = 1;
      this.label1.Text = "Сrossover probability:";
      // 
      // StartButton
      // 
      this.StartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.StartButton.Location = new System.Drawing.Point(31, 219);
      this.StartButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.StartButton.Name = "StartButton";
      this.StartButton.Size = new System.Drawing.Size(176, 31);
      this.StartButton.TabIndex = 0;
      this.StartButton.Text = "Start";
      this.StartButton.UseVisualStyleBackColor = true;
      this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
      // 
      // ResultGroup
      // 
      this.ResultGroup.Controls.Add(this.ClearButton);
      this.ResultGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.ResultGroup.Location = new System.Drawing.Point(651, 288);
      this.ResultGroup.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.ResultGroup.Name = "ResultGroup";
      this.ResultGroup.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.ResultGroup.Size = new System.Drawing.Size(230, 194);
      this.ResultGroup.TabIndex = 2;
      this.ResultGroup.TabStop = false;
      this.ResultGroup.Text = "Result";
      // 
      // ClearButton
      // 
      this.ClearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.ClearButton.Location = new System.Drawing.Point(31, 149);
      this.ClearButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.ClearButton.Name = "ClearButton";
      this.ClearButton.Size = new System.Drawing.Size(176, 32);
      this.ClearButton.TabIndex = 0;
      this.ClearButton.Text = "Clear";
      this.ClearButton.UseVisualStyleBackColor = true;
      this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(890, 492);
      this.Controls.Add(this.ResultGroup);
      this.Controls.Add(this.ParametersGroup);
      this.Controls.Add(this.Chart);
      this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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

