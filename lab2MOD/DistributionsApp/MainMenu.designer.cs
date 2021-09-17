
namespace DistributionsApp
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.LabelA = new System.Windows.Forms.ToolStripLabel();
            this.InputBoxA = new System.Windows.Forms.ToolStripTextBox();
            this.LabelB = new System.Windows.Forms.ToolStripLabel();
            this.InputBoxB = new System.Windows.Forms.ToolStripTextBox();
            this.LabelM = new System.Windows.Forms.ToolStripLabel();
            this.InputBoxM = new System.Windows.Forms.ToolStripTextBox();
            this.LabelStd = new System.Windows.Forms.ToolStripLabel();
            this.InputBoxStd = new System.Windows.Forms.ToolStripTextBox();
            this.LabelN = new System.Windows.Forms.ToolStripLabel();
            this.InputBoxN = new System.Windows.Forms.ToolStripTextBox();
            this.ChartOfRandom = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.toolStrip3 = new System.Windows.Forms.ToolStrip();
            this.LabelMathExpectation = new System.Windows.Forms.ToolStripLabel();
            this.TextBoxMathExpectation = new System.Windows.Forms.ToolStripTextBox();
            this.LabelDispersion = new System.Windows.Forms.ToolStripLabel();
            this.TextBoxDispersion = new System.Windows.Forms.ToolStripTextBox();
            this.LabelStandardDeviation = new System.Windows.Forms.ToolStripLabel();
            this.TextBoxStandardDeviation = new System.Windows.Forms.ToolStripTextBox();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.ButtonUniformDistribution = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ButtonGaussDistribution = new System.Windows.Forms.ToolStripButton();
            this.LabelLambda = new System.Windows.Forms.ToolStripLabel();
            this.InputBoxLambda = new System.Windows.Forms.ToolStripTextBox();
            this.ButtonExponentialDistribution = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.LabelEta = new System.Windows.Forms.ToolStripLabel();
            this.InputBoxEta = new System.Windows.Forms.ToolStripTextBox();
            this.ButtonGammaDistribution = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.ButtonMinTriangleDistribution = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.ButtonMaxTriangleDistribution = new System.Windows.Forms.ToolStripButton();
            this.ButtonSimpsonDistribution = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChartOfRandom)).BeginInit();
            this.toolStrip3.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LabelA,
            this.InputBoxA,
            this.LabelB,
            this.InputBoxB,
            this.LabelM,
            this.InputBoxM,
            this.LabelStd,
            this.InputBoxStd,
            this.LabelLambda,
            this.InputBoxLambda,
            this.LabelEta,
            this.InputBoxEta,
            this.LabelN,
            this.InputBoxN});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1382, 27);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
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
            // LabelB
            // 
            this.LabelB.Name = "LabelB";
            this.LabelB.Size = new System.Drawing.Size(21, 24);
            this.LabelB.Text = "b:";
            // 
            // InputBoxB
            // 
            this.InputBoxB.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.InputBoxB.Name = "InputBoxB";
            this.InputBoxB.Size = new System.Drawing.Size(100, 27);
            this.InputBoxB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InputR_KeyPress);
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
            // LabelStd
            // 
            this.LabelStd.Name = "LabelStd";
            this.LabelStd.Size = new System.Drawing.Size(34, 24);
            this.LabelStd.Text = "Std:";
            // 
            // InputBoxStd
            // 
            this.InputBoxStd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.InputBoxStd.Name = "InputBoxStd";
            this.InputBoxStd.Size = new System.Drawing.Size(100, 27);
            this.InputBoxStd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InputBoxStd_KeyPress);
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
            this.ChartOfRandom.Size = new System.Drawing.Size(1382, 569);
            this.ChartOfRandom.TabIndex = 3;
            this.ChartOfRandom.Text = "ChartOfRandom";
            this.ChartOfRandom.Visible = false;
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
            this.toolStrip3.Location = new System.Drawing.Point(0, 27);
            this.toolStrip3.Name = "toolStrip3";
            this.toolStrip3.Size = new System.Drawing.Size(1382, 27);
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
            // toolStrip2
            // 
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ButtonUniformDistribution,
            this.toolStripSeparator1,
            this.ButtonGaussDistribution,
            this.toolStripSeparator2,
            this.ButtonExponentialDistribution,
            this.toolStripSeparator3,
            this.ButtonGammaDistribution,
            this.toolStripSeparator4,
            this.ButtonMinTriangleDistribution,
            this.toolStripSeparator5,
            this.ButtonMaxTriangleDistribution,
            this.toolStripSeparator6,
            this.ButtonSimpsonDistribution});
            this.toolStrip2.Location = new System.Drawing.Point(0, 54);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(1382, 27);
            this.toolStrip2.TabIndex = 7;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // ButtonUniformDistribution
            // 
            this.ButtonUniformDistribution.BackColor = System.Drawing.SystemColors.Control;
            this.ButtonUniformDistribution.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ButtonUniformDistribution.Image = ((System.Drawing.Image)(resources.GetObject("ButtonUniformDistribution.Image")));
            this.ButtonUniformDistribution.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ButtonUniformDistribution.Name = "ButtonUniformDistribution";
            this.ButtonUniformDistribution.Size = new System.Drawing.Size(168, 24);
            this.ButtonUniformDistribution.Text = "GetUniformDistribution";
            this.ButtonUniformDistribution.Click += new System.EventHandler(this.ButtonUniformDistribution_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // ButtonGaussDistribution
            // 
            this.ButtonGaussDistribution.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ButtonGaussDistribution.Image = ((System.Drawing.Image)(resources.GetObject("ButtonGaussDistribution.Image")));
            this.ButtonGaussDistribution.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ButtonGaussDistribution.Name = "ButtonGaussDistribution";
            this.ButtonGaussDistribution.Size = new System.Drawing.Size(152, 24);
            this.ButtonGaussDistribution.Text = "GetGaussDistribution";
            this.ButtonGaussDistribution.Click += new System.EventHandler(this.ButtonGaussDistribution_Click);
            // 
            // LabelLambda
            // 
            this.LabelLambda.Name = "LabelLambda";
            this.LabelLambda.Size = new System.Drawing.Size(16, 24);
            this.LabelLambda.Text = "λ";
            // 
            // InputBoxLambda
            // 
            this.InputBoxLambda.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.InputBoxLambda.Name = "InputBoxLambda";
            this.InputBoxLambda.Size = new System.Drawing.Size(100, 27);
            this.InputBoxLambda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InputBoxLambda_KeyPress);
            // 
            // ButtonExponentialDistribution
            // 
            this.ButtonExponentialDistribution.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ButtonExponentialDistribution.Image = ((System.Drawing.Image)(resources.GetObject("ButtonExponentialDistribution.Image")));
            this.ButtonExponentialDistribution.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ButtonExponentialDistribution.Name = "ButtonExponentialDistribution";
            this.ButtonExponentialDistribution.Size = new System.Drawing.Size(192, 24);
            this.ButtonExponentialDistribution.Text = "GetExponentialDistribution";
            this.ButtonExponentialDistribution.Click += new System.EventHandler(this.ButtonExponentialDistribution_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // LabelEta
            // 
            this.LabelEta.Name = "LabelEta";
            this.LabelEta.Size = new System.Drawing.Size(18, 24);
            this.LabelEta.Text = "η";
            // 
            // InputBoxEta
            // 
            this.InputBoxEta.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.InputBoxEta.Name = "InputBoxEta";
            this.InputBoxEta.Size = new System.Drawing.Size(100, 27);
            this.InputBoxEta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InputBoxEta_KeyPress);
            // 
            // ButtonGammaDistribution
            // 
            this.ButtonGammaDistribution.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ButtonGammaDistribution.Image = ((System.Drawing.Image)(resources.GetObject("ButtonGammaDistribution.Image")));
            this.ButtonGammaDistribution.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ButtonGammaDistribution.Name = "ButtonGammaDistribution";
            this.ButtonGammaDistribution.Size = new System.Drawing.Size(166, 24);
            this.ButtonGammaDistribution.Text = "GetGammaDistribution";
            this.ButtonGammaDistribution.Click += new System.EventHandler(this.ButtonGammaDistribution_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 27);
            // 
            // ButtonMinTriangleDistribution
            // 
            this.ButtonMinTriangleDistribution.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ButtonMinTriangleDistribution.Image = ((System.Drawing.Image)(resources.GetObject("ButtonMinTriangleDistribution.Image")));
            this.ButtonMinTriangleDistribution.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ButtonMinTriangleDistribution.Name = "ButtonMinTriangleDistribution";
            this.ButtonMinTriangleDistribution.Size = new System.Drawing.Size(192, 24);
            this.ButtonMinTriangleDistribution.Text = "GetMinTriangleDistribution";
            this.ButtonMinTriangleDistribution.Click += new System.EventHandler(this.ButtonMinTriangleDistribution_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 27);
            // 
            // ButtonMaxTriangleDistribution
            // 
            this.ButtonMaxTriangleDistribution.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ButtonMaxTriangleDistribution.Image = ((System.Drawing.Image)(resources.GetObject("ButtonMaxTriangleDistribution.Image")));
            this.ButtonMaxTriangleDistribution.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ButtonMaxTriangleDistribution.Name = "ButtonMaxTriangleDistribution";
            this.ButtonMaxTriangleDistribution.Size = new System.Drawing.Size(195, 24);
            this.ButtonMaxTriangleDistribution.Text = "GetMaxTriangleDistribution";
            this.ButtonMaxTriangleDistribution.Click += new System.EventHandler(this.ButtonMaxTriangleDistribution_Click);
            // 
            // ButtonSimpsonDistribution
            // 
            this.ButtonSimpsonDistribution.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ButtonSimpsonDistribution.Image = ((System.Drawing.Image)(resources.GetObject("ButtonSimpsonDistribution.Image")));
            this.ButtonSimpsonDistribution.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ButtonSimpsonDistribution.Name = "ButtonSimpsonDistribution";
            this.ButtonSimpsonDistribution.Size = new System.Drawing.Size(171, 24);
            this.ButtonSimpsonDistribution.Text = "GetSimpsonDistribution";
            this.ButtonSimpsonDistribution.Click += new System.EventHandler(this.ButtonSimpsonDistribution_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 27);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1382, 653);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.toolStrip3);
            this.Controls.Add(this.ChartOfRandom);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MainMenu";
            this.Text = "PseudoRandomApp";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChartOfRandom)).EndInit();
            this.toolStrip3.ResumeLayout(false);
            this.toolStrip3.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripLabel LabelA;
        private System.Windows.Forms.ToolStripTextBox InputBoxA;
        private System.Windows.Forms.ToolStripLabel LabelB;
        private System.Windows.Forms.ToolStripTextBox InputBoxB;
        private System.Windows.Forms.ToolStripLabel LabelM;
        private System.Windows.Forms.ToolStripTextBox InputBoxM;
        private System.Windows.Forms.ToolStripLabel LabelN;
        private System.Windows.Forms.ToolStripTextBox InputBoxN;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartOfRandom;
        private System.Windows.Forms.ToolStrip toolStrip3;
        private System.Windows.Forms.ToolStripLabel LabelMathExpectation;
        private System.Windows.Forms.ToolStripTextBox TextBoxMathExpectation;
        private System.Windows.Forms.ToolStripLabel LabelDispersion;
        private System.Windows.Forms.ToolStripTextBox TextBoxDispersion;
        private System.Windows.Forms.ToolStripLabel LabelStandardDeviation;
        private System.Windows.Forms.ToolStripTextBox TextBoxStandardDeviation;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton ButtonUniformDistribution;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton ButtonGaussDistribution;
        private System.Windows.Forms.ToolStripLabel LabelStd;
        private System.Windows.Forms.ToolStripTextBox InputBoxStd;
        private System.Windows.Forms.ToolStripLabel LabelLambda;
        private System.Windows.Forms.ToolStripTextBox InputBoxLambda;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton ButtonExponentialDistribution;
        private System.Windows.Forms.ToolStripLabel LabelEta;
        private System.Windows.Forms.ToolStripTextBox InputBoxEta;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton ButtonGammaDistribution;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton ButtonMinTriangleDistribution;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton ButtonMaxTriangleDistribution;
        private System.Windows.Forms.ToolStripButton ButtonSimpsonDistribution;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
    }
}

