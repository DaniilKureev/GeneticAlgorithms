namespace RGAlgorithm
{
  partial class Form2
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
      this.ChartGroupBox = new System.Windows.Forms.GroupBox();
      this.Chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
      this.ChartGroupBox.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.Chart)).BeginInit();
      this.SuspendLayout();
      // 
      // ChartGroupBox
      // 
      this.ChartGroupBox.Controls.Add(this.Chart);
      this.ChartGroupBox.Location = new System.Drawing.Point(39, 27);
      this.ChartGroupBox.Name = "ChartGroupBox";
      this.ChartGroupBox.Size = new System.Drawing.Size(1038, 517);
      this.ChartGroupBox.TabIndex = 0;
      this.ChartGroupBox.TabStop = false;
      this.ChartGroupBox.Text = "Chart";
      // 
      // Chart
      // 
      chartArea1.Name = "ChartArea1";
      this.Chart.ChartAreas.Add(chartArea1);
      legend1.Name = "Legend1";
      this.Chart.Legends.Add(legend1);
      this.Chart.Location = new System.Drawing.Point(7, 22);
      this.Chart.Name = "Chart";
      this.Chart.Size = new System.Drawing.Size(300, 300);
      this.Chart.TabIndex = 0;
      this.Chart.Text = "chart1";
      // 
      // Form2
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1128, 576);
      this.Controls.Add(this.ChartGroupBox);
      this.Name = "Form2";
      this.Text = "RGA";
      this.ChartGroupBox.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.Chart)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.GroupBox ChartGroupBox;
    private System.Windows.Forms.DataVisualization.Charting.Chart Chart;
  }
}

