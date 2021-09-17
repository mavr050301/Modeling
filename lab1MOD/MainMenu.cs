using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace PseudoRandomApp
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void InputBoxA_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidateInput(e);
        }

        private void InputR_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidateInput(e);
        }

        

        private void InputM_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidateInput(e);
        }
        
        private void InputN_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidateInput(e);
        }
        
        private void ValidateInput(KeyPressEventArgs e)
        {
            char inputDigit = e.KeyChar;
            if (!Char.IsDigit(inputDigit) && inputDigit != 8)
            {
                e.Handled = true;
            }
        }

        private void RandomizeButton_Click(object sender, EventArgs e)
        {
            if (!uint.TryParse(InputBoxA.Text, out uint a))
            {
                ShowInputError(LabelA, InputBoxA);
                return;
            }

            if (!uint.TryParse(InputBoxR.Text, out uint r))
            {
                ShowInputError(LabelR, InputBoxR);
                return;
            }

            if (!uint.TryParse(InputBoxM.Text, out uint m))
            {
                ShowInputError(LabelM, InputBoxM);
                return;
            }

            if (!uint.TryParse(InputBoxN.Text, out uint n))
            {
                ShowInputError(LabelN, InputBoxN);
                return;
            }

            if(a == 0 || r == 0 || m == 0 || n == 0)
            {
                MessageBox.Show("Input Parameters cannot be equal zero", "InputError", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (n <= m)
            {
                MessageBox.Show("N cannot be less or equal than m", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (m <= a)
            {
                MessageBox.Show("A cannot be more or equal M", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ChartOfRandom.Visible = false;
            var randomList = new List<double>();
            var numberRList = new List<ulong>();
            numberRList.Add(r);
            Random(randomList, numberRList,a,m,n);
            int[] numberAtPoint = new int[20];
            double[] arrayofPoints = new double[21];
            arrayofPoints[0] = 0.0;
            for(int i = 1; i < arrayofPoints.Length; i++)
            {
                arrayofPoints[i] = arrayofPoints[i - 1] + 0.05D;
            }
            int index = FindIndexForPeriod(numberRList);
            int period = numberRList.Count - 1 - index;
            TextBoxPeriod.Text = period.ToString();
            TextBoxApInterval.Text = FindAperiodIndex(numberRList, period).ToString();
            TextBoxMathExpectation.Text = GetMathExpectation(randomList).ToString();
            TextBoxDispersion.Text = GetDispersion(randomList).ToString();
            TextBoxStandardDeviation.Text = GetStandardDeviation(randomList).ToString();
            MakeChartDataY(randomList, arrayofPoints, numberAtPoint, index);
            ChartOfRandom.Series["RandomSeries"].Points.Clear();
            AddPointsToChart(arrayofPoints, numberAtPoint);
        }  

        private void ShowInputError(ToolStripLabel label, ToolStripTextBox textBox)
        {
            MessageBox.Show($"Invalid number: {Environment.NewLine}{label.Text} {textBox.Text}", "InputError", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Random(List<double> randomList, List<ulong> numberRList, uint a,uint m, uint n)
        {
            try
            {
                for (int i = 0; i < n; i++)
                {
                    numberRList.Add(a * numberRList.Last() % m);
                    randomList.Add((double)numberRList.Last() / m);
                }

                numberRList.RemoveAt(0);
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"MemoryError", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int FindIndexForPeriod(List<ulong> numberRList)
        {
            for (int i = numberRList.Count - 2; ; i--)
            {
                if (numberRList[i] == numberRList[numberRList.Count - 1])
                {
                    return i;
                }
            }
        }

        private int FindAperiodIndex(List<ulong> numberRList, int period)
        {
            for (int i = 0; i < numberRList.Count; i++)
            {
                if (numberRList[i] == numberRList[i + period])
                {
                    return i + period;
                }
            }

            return -1;
        }

        private void MakeChartDataY(List<double> randomList,double[] arrayofPoints,int[] numberAtPoint, int index)
        {
            for (int i = 0; i < randomList.Count; i++)
            {
                for (int j = 0; j < arrayofPoints.Length - 1; j++)
                {
                    if (randomList[i] >= arrayofPoints[j] && randomList[i] <= arrayofPoints[j + 1])
                    {
                        numberAtPoint[j] += 1;
                        break;
                    }
                }
            }
        }

        private void AddPointsToChart(double[] arrayofPoints, int[] numberAtPoint)
        {
            for (int i = 0; i < numberAtPoint.Length; i++)
            {
                ChartOfRandom.Series["RandomSeries"].Points.AddXY(arrayofPoints[i], numberAtPoint[i]);
            }

            ChartOfRandom.Visible = true;
        }

        private double GetMathExpectation(List<double> randomList)
        {
            return randomList.Average();
        }

        private double GetDispersion(List<double> randomList)
        {
            double m = GetMathExpectation(randomList);
            return randomList.Sum(x => (x - m) * (x - m)) / (randomList.Count - 1);
        }

        double GetStandardDeviation(List<double> randomList)
        {
            return Math.Sqrt(GetDispersion(randomList));
        }
    }
}
