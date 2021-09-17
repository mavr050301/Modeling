
namespace PseudoRandomApp
{
    partial class MainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ToolStrip toolStrip1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.LabelA = new System.Windows.Forms.ToolStripLabel();
            this.InputBoxA = new System.Windows.Forms.ToolStripTextBox();
            this.LabelR = new System.Windows.Forms.ToolStripLabel();
            this.InputBoxR = new System.Windows.Forms.ToolStripTextBox();
            this.LabelM = new System.Windows.Forms.ToolStripLabel();
            this.InputBoxM = new System.Windows.Forms.ToolStripTextBox();
            this.LabelN = new System.Windows.Forms.ToolStripLabel();
            this.InputBoxN = new System.Windows.Forms.ToolStripTextBox();
            this.RandomizeButton = new System.Windows.Forms.ToolStripButton();
            this.ChartOfRandom = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.LabelPeriod = new System.Windows.Forms.ToolStripLabel();
            this.TextBoxPeriod = new System.Windows.Forms.ToolStripTextBox();
            this.LabelAperiodInterval = new System.Windows.Forms.ToolStripLabel();
            this.TextBoxApInterval = new System.Windows.Forms.ToolStripTextBox();
            this.toolStrip3 = new System.Windows.Forms.ToolStrip();
            this.LabelMathExpectation = new System.Windows.Forms.ToolStripLabel();
            this.TextBoxMathExpectation = new System.Windows.Forms.ToolStripTextBox();
            this.LabelDispersion = new System.Windows.Forms.ToolStripLabel();
            this.TextBoxDispersion = new System.Windows.Forms.ToolStripTextBox();
            this.LabelStandardDeviation = new System.Windows.Forms.ToolStripLabel();
            this.TextBoxStandardDeviation = new System.Windows.Forms.ToolStripTextBox();
            toolStrip1 = new System.Windows.Forms.ToolStrip();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChartOfRandom)).BeginInit();
            this.toolStrip2.SuspendLayout();
            this.toolStrip3.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.BackColor = System.Drawing.SystemColors.Control;
            toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LabelA,
            this.InputBoxA,
            this.LabelR,
            this.InputBoxR,
            this.LabelM,
            this.InputBoxM,
            this.LabelN,
            this.InputBoxN,
            this.RandomizeButton});
            toolStrip1.Location = new System.Drawing.Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new System.Drawing.Size(882, 27);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // LabelA
            // 
            this.LabelA.Name = "LabelA";
            this.LabelA.Size = new System.Drawing.Size(20, 24);
            this.LabelA.Text = "a:";
            // 
            // InputBoxA
            // 
            this.InputBoxA.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.InputBoxA.Name = "InputBoxA";
            this.InputBoxA.Size = new System.Drawing.Size(100, 27);
            this.InputBoxA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InputBoxA_KeyPress);
            // 
            // LabelR
            // 
            this.LabelR.Name = "LabelR";
            this.LabelR.Size = new System.Drawing.Size(21, 24);
            this.LabelR.Text = "R:";
            // 
            // InputBoxR
            // 
            this.InputBoxR.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.InputBoxR.Name = "InputBoxR";
            this.InputBoxR.Size = new System.Drawing.Size(100, 27);
            this.InputBoxR.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InputR_KeyPress);
            // 
            // LabelM
            // 
            this.LabelM.Name = "LabelM";
            this.LabelM.Size = new System.Drawing.Size(25, 24);
            this.LabelM.Text = "m:";
            // 
            // InputBoxM
            // 
            this.InputBoxM.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.InputBoxM.Name = "InputBoxM";
            this.InputBoxM.Size = new System.Drawing.Size(100, 27);
            this.InputBoxM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InputM_KeyPress);
            // 
            // LabelN
            // 
            this.LabelN.Name = "LabelN";
            this.LabelN.Size = new System.Drawing.Size(23, 24);
            this.LabelN.Text = "N:";
            // 
            // InputBoxN
            // 
            this.InputBoxN.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.InputBoxN.Name = "InputBoxN";
            this.InputBoxN.Size = new System.Drawing.Size(100, 27);
            this.InputBoxN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InputN_KeyPress);
            // 
            // RandomizeButton
            // 
            this.RandomizeButton.BackColor = System.Drawing.Color.Orange;
            this.RandomizeButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.RandomizeButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.RandomizeButton.Image = ((System.Drawing.Image)(resources.GetObject("RandomizeButton.Image")));
            this.RandomizeButton.ImageTransparentColor = System.Drawing.Color.MediumSlateBlue;
            this.RandomizeButton.Name = "RandomizeButton";
            this.RandomizeButton.Size = new System.Drawing.Size(88, 24);
            this.RandomizeButton.Text = "Randomize";
            this.RandomizeButton.Click += new System.EventHandler(this.RandomizeButton_Click);
            // 
            // ChartOfRandom
            // 
            this.ChartOfRandom.BackColor = System.Drawing.SystemColors.Control;
            this.ChartOfRandom.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.DashDot;
            chartArea1.Name = "ChartArea1";
            this.ChartOfRandom.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.ChartOfRandom.Legends.Add(legend1);
            this.ChartOfRandom.Location = new System.Drawing.Point(0, 84);
            this.ChartOfRandom.Name = "ChartOfRandom";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "RandomSeries";
            this.ChartOfRandom.Series.Add(series1);
            this.ChartOfRandom.Size = new System.Drawing.Size(870, 427);
            this.ChartOfRandom.TabIndex = 3;
            this.ChartOfRandom.Text = "ChartOfRandom";
            this.ChartOfRandom.Visible = false;
            // 
            // toolStrip2
            // 
            this.toolStrip2.BackColor = System.Drawing.SystemColors.Control;
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LabelPeriod,
            this.TextBoxPeriod,
            this.LabelAperiodInterval,
            this.TextBoxApInterval});
            this.toolStrip2.Location = new System.Drawing.Point(0, 27);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(882, 27);
            this.toolStrip2.TabIndex = 5;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // LabelPeriod
            // 
            this.LabelPeriod.Name = "LabelPeriod";
            this.LabelPeriod.Size = new System.Drawing.Size(54, 24);
            this.LabelPeriod.Text = "Period:";
            // 
            // TextBoxPeriod
            // 
            this.TextBoxPeriod.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxPeriod.Name = "TextBoxPeriod";
            this.TextBoxPeriod.ReadOnly = true;
            this.TextBoxPeriod.Size = new System.Drawing.Size(100, 27);
            // 
            // LabelAperiodInterval
            // 
            this.LabelAperiodInterval.Name = "LabelAperiodInterval";
            this.LabelAperiodInterval.Size = new System.Drawing.Size(112, 24);
            this.LabelAperiodInterval.Text = "AperiodInterval";
            // 
            // TextBoxApInterval
            // 
            this.TextBoxApInterval.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxApInterval.Name = "TextBoxApInterval";
            this.TextBoxApInterval.ReadOnly = true;
            this.TextBoxApInterval.Size = new System.Drawing.Size(100, 27);
            // 
            // toolStrip3
            // 
            this.toolStrip3.BackColor = System.Drawing.SystemColors.Control;
            this.toolStrip3.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LabelMathExpectation,
            this.TextBoxMathExpectation,
            this.LabelDispersion,
            this.TextBoxDispersion,
            this.LabelStandardDeviation,
            this.TextBoxStandardDeviation});
            this.toolStrip3.Location = new System.Drawing.Point(0, 54);
            this.toolStrip3.Name = "toolStrip3";
            this.toolStrip3.Size = new System.Drawing.Size(882, 27);
            this.toolStrip3.TabIndex = 6;
            this.toolStrip3.Text = "toolStrip3";
            // 
            // LabelMathExpectation
            // 
            this.LabelMathExpectation.Name = "LabelMathExpectation";
            this.LabelMathExpectation.Size = new System.Drawing.Size(128, 24);
            this.LabelMathExpectation.Text = "Math Expectation:";
            // 
            // TextBoxMathExpectation
            // 
            this.TextBoxMathExpectation.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxMathExpectation.Name = "TextBoxMathExpectation";
            this.TextBoxMathExpectation.ReadOnly = true;
            this.TextBoxMathExpectation.Size = new System.Drawing.Size(100, 27);
            // 
            // LabelDispersion
            // 
            this.LabelDispersion.Name = "LabelDispersion";
            this.LabelDispersion.Size = new System.Drawing.Size(82, 24);
            this.LabelDispersion.Text = "Dispersion:";
            // 
            // TextBoxDispersion
            // 
            this.TextBoxDispersion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxDispersion.Name = "TextBoxDispersion";
            this.TextBoxDispersion.ReadOnly = true;
            this.TextBoxDispersion.Size = new System.Drawing.Size(100, 27);
            // 
            // LabelStandardDeviation
            // 
            this.LabelStandardDeviation.Name = "LabelStandardDeviation";
            this.LabelStandardDeviation.Size = new System.Drawing.Size(140, 24);
            this.LabelStandardDeviation.Text = "Standard Deviation:";
            // 
            // TextBoxStandardDeviation
            // 
            this.TextBoxStandardDeviation.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxStandardDeviation.Name = "TextBoxStandardDeviation";
            this.TextBoxStandardDeviation.ReadOnly = true;
            this.TextBoxStandardDeviation.Size = new System.Drawing.Size(100, 27);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 553);
            this.Controls.Add(this.toolStrip3);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.ChartOfRandom);
            this.Controls.Add(toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MainMenu";
            this.Text = "PseudoRandomApp";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChartOfRandom)).EndInit();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.toolStrip3.ResumeLayout(false);
            this.toolStrip3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripLabel LabelA;
        private System.Windows.Forms.ToolStripTextBox InputBoxA;
        private System.Windows.Forms.ToolStripLabel LabelR;
        private System.Windows.Forms.ToolStripTextBox InputBoxR;
        private System.Windows.Forms.ToolStripLabel LabelM;
        private System.Windows.Forms.ToolStripTextBox InputBoxM;
        private System.Windows.Forms.ToolStripLabel LabelN;
        private System.Windows.Forms.ToolStripTextBox InputBoxN;
        private System.Windows.Forms.ToolStripButton RandomizeButton;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartOfRandom;
        private System.Windows.Forms.ToolStripLabel LabelPeriod;
        private System.Windows.Forms.ToolStripTextBox TextBoxPeriod;
        private System.Windows.Forms.ToolStripLabel LabelAperiodInterval;
        private System.Windows.Forms.ToolStripTextBox TextBoxApInterval;
        private System.Windows.Forms.ToolStrip toolStrip3;
        private System.Windows.Forms.ToolStripLabel LabelMathExpectation;
        private System.Windows.Forms.ToolStripTextBox TextBoxMathExpectation;
        private System.Windows.Forms.ToolStripLabel LabelDispersion;
        private System.Windows.Forms.ToolStripTextBox TextBoxDispersion;
        private System.Windows.Forms.ToolStripLabel LabelStandardDeviation;
        private System.Windows.Forms.ToolStripTextBox TextBoxStandardDeviation;
        private System.Windows.Forms.ToolStrip toolStrip2;
    }
}

