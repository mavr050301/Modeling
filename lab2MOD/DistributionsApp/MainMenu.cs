using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DistributionsApp
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();//asdasda
        }

        private void InputBoxA_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidateInputDouble(e);
        }

        private void InputR_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidateInputDouble(e);
        }

        

        private void InputM_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidateInputDouble(e);
        }

        private void InputBoxStd_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidateInputDouble(e);
        }

        private void InputBoxLambda_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidateInputDouble(e);
        }

        private void InputBoxEta_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidateInputInt(e);
        }

        private void InputN_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidateInputInt(e);
        }
        
        private void ValidateInputDouble(KeyPressEventArgs e)
        {
            char inputDigit = e.KeyChar;
            if (!Char.IsDigit(inputDigit) && inputDigit != 44 && inputDigit != 8 && inputDigit != 45)
            {
                e.Handled = true;
            }
        }

        private void ValidateInputInt(KeyPressEventArgs e)
        {
            char inputDigit = e.KeyChar;
            if (!Char.IsDigit(inputDigit) && inputDigit != 8)
            {
                e.Handled = true;
            }
        }

        private void RandomizeButton_Click(object sender, EventArgs e)
        {
            /*if (!uint.TryParse(InputBoxA.Text, out uint a))
            {
                ShowInputError(LabelA, InputBoxA);
                return;
            }

            if (!uint.TryParse(InputBoxB.Text, out uint r))
            {
                ShowInputError(LabelB, InputBoxB);
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

            ChartOfRandom.Visible = false;
            randomList = new List<double>();
            numberRList = new List<ulong>();
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
            AddPointsToChart(arrayofPoints, numberAtPoint);*/
        }  

        private void ShowInputError(ToolStripLabel label, ToolStripTextBox textBox)
        {
            MessageBox.Show($"Invalid number: {Environment.NewLine}{label.Text} {textBox.Text}", "InputError", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void MakeChartDataY(List<double> randomList, double[] arrayofPoints, int[] numberAtPoint)
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

        private void ButtonUniformDistribution_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(InputBoxA.Text, out double a))
            {
                ShowInputError(LabelA, InputBoxA);
                return;
            }

            if (!double.TryParse(InputBoxB.Text, out double b))
            {
                ShowInputError(LabelB, InputBoxB);
                return;
            }

            if (!uint.TryParse(InputBoxN.Text, out uint n))
            {
                ShowInputError(LabelN, InputBoxN);
                return;
            }

            if (a >= b)
            {
                MessageBox.Show("a cannot be more or equal than b", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (b == 0 || n == 0)
            {
                MessageBox.Show("Input Parameters cannot be equal zero", "InputError", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var randomList = new List<double>();
            var random = new Random();
            for (int i = 0; i < n; i++)
            {
                randomList.Add(random.NextDouble());
            }

            randomList = randomList.Select(x => a + (b - a) * x).ToList();
            int[] numberAtPoint = new int[20];
            double[] arrayofPoints = new double[21];
            MakeIntervals(arrayofPoints, a, b);
            MakeChartDataY(randomList, arrayofPoints, numberAtPoint);
            ChartOfRandom.Series["RandomSeries"].Points.Clear();
            AddPointsToChart(arrayofPoints,numberAtPoint);
            TextBoxMathExpectation.Text = GetMathExpectation(randomList).ToString();
            TextBoxDispersion.Text = GetDispersion(randomList).ToString();
            TextBoxStandardDeviation.Text = GetStandardDeviation(randomList).ToString();
        }

        private void MakeIntervals(double[] arrayofPoints, double a, double b)
        {
            arrayofPoints[0] = a;
            double delta = (b - a) / 20d;
            for (int i = 1; i < arrayofPoints.Length; i++)
            {
                arrayofPoints[i] = arrayofPoints[i - 1] + delta;
            }
        }

        private void ButtonGaussDistribution_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(InputBoxM.Text, out double m))
            {
                ShowInputError(LabelM, InputBoxM);
                return;
            }

            if (!double.TryParse(InputBoxStd.Text, out double std))
            {
                ShowInputError(LabelStd, InputBoxStd);
                return;
            }

            if (!uint.TryParse(InputBoxN.Text, out uint n))
            {
                ShowInputError(LabelN, InputBoxN);
                return;
            }

            var randomList = new List<double>();
            var random = new Random();
            for(int i = 0; i < n; i++)
            {
                double sum = 0.0;
                for(int j = 0; j < 6; j++)
                {
                    sum += random.NextDouble();
                }

                randomList.Add(m + std * (Math.Sqrt(2)) * (sum - 3));
            }

            int[] numberAtPoint = new int[20];
            double[] arrayofPoints = new double[21];
            MakeIntervals(arrayofPoints,randomList.Min(),randomList.Max());
            MakeChartDataY(randomList, arrayofPoints, numberAtPoint);
            ChartOfRandom.Series["RandomSeries"].Points.Clear();
            AddPointsToChart(arrayofPoints, numberAtPoint);
            TextBoxMathExpectation.Text = GetMathExpectation(randomList).ToString();
            TextBoxDispersion.Text = GetDispersion(randomList).ToString();
            TextBoxStandardDeviation.Text = GetStandardDeviation(randomList).ToString();
        }

        private void ButtonExponentialDistribution_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(InputBoxLambda.Text, out double lambda))
            {
                ShowInputError(LabelLambda, InputBoxLambda);
                return;
            }

            if (!uint.TryParse(InputBoxN.Text, out uint n))
            {
                ShowInputError(LabelN, InputBoxN);
                return;
            }

            if (lambda == 0d)
            {
                MessageBox.Show("Lambda must be less or equal zero", "InputError", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var randomList = new List<double>();
            var random = new Random();
            for (int i = 0; i < n; i++)
            {
                randomList.Add(random.NextDouble());
            }

            randomList = randomList.Select(x => (-1d / lambda) * Math.Log(x)).ToList();
            int[] numberAtPoint = new int[20];
            double[] arrayofPoints = new double[21];
            MakeIntervals(arrayofPoints, randomList.Min(), randomList.Max());
            MakeChartDataY(randomList, arrayofPoints, numberAtPoint);
            ChartOfRandom.Series["RandomSeries"].Points.Clear();
            AddPointsToChart(arrayofPoints, numberAtPoint);
            TextBoxMathExpectation.Text = GetMathExpectation(randomList).ToString();
            TextBoxDispersion.Text = GetDispersion(randomList).ToString();
            TextBoxStandardDeviation.Text = GetStandardDeviation(randomList).ToString();
        }

        private void ButtonGammaDistribution_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(InputBoxLambda.Text, out double lambda))
            {
                ShowInputError(LabelLambda, InputBoxLambda);
                return;
            }

            if (!uint.TryParse(InputBoxEta.Text, out uint eta))
            {
                ShowInputError(LabelEta, InputBoxEta);
                return;
            }

            if (!uint.TryParse(InputBoxN.Text, out uint n))
            {
                ShowInputError(LabelN, InputBoxN);
                return;
            }

            if (lambda == 0d)
            {
                MessageBox.Show("Lambda must be less or equal zero", "InputError", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var randomList = new List<double>();
            var random = new Random();
            for (int i = 0; i < n; i++)
            {
                double mul = 1.0;
                for (int j = 0; j < eta; j++)
                {
                    mul *= random.NextDouble();
                }

                randomList.Add((-1d / lambda) * Math.Log(mul));
            }
            int[] numberAtPoint = new int[20];
            double[] arrayofPoints = new double[21];
            MakeIntervals(arrayofPoints, randomList.Min(), randomList.Max());
            MakeChartDataY(randomList, arrayofPoints, numberAtPoint);
            ChartOfRandom.Series["RandomSeries"].Points.Clear();
            AddPointsToChart(arrayofPoints, numberAtPoint);
            TextBoxMathExpectation.Text = GetMathExpectation(randomList).ToString();
            TextBoxDispersion.Text = GetDispersion(randomList).ToString();
            TextBoxStandardDeviation.Text = GetStandardDeviation(randomList).ToString();
        }

        private void ButtonMinTriangleDistribution_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(InputBoxA.Text, out double a))
            {
                ShowInputError(LabelA, InputBoxA);
                return;
            }

            if (!double.TryParse(InputBoxB.Text, out double b))
            {
                ShowInputError(LabelB, InputBoxB);
                return;
            }

            if (!uint.TryParse(InputBoxN.Text, out uint n))
            {
                ShowInputError(LabelN, InputBoxN);
                return;
            }

            if (a >= b)
            {
                MessageBox.Show("a cannot be more or equal than b", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (b == 0 || n == 0)
            {
                MessageBox.Show("Input Parameters cannot be equal zero", "InputError", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var randomList = new List<double>();
            var minMaxList = new List<double>() { 0d, 0d};
            var random = new Random();
            for (int i = 0; i < n; i++)
            {
                minMaxList[0] = random.NextDouble();
                minMaxList[1] = random.NextDouble();
                randomList.Add(a + (b - a) * minMaxList.Min());
            }

            int[] numberAtPoint = new int[20];
            double[] arrayofPoints = new double[21];
            MakeIntervals(arrayofPoints, a, b);
            MakeChartDataY(randomList, arrayofPoints, numberAtPoint);
            ChartOfRandom.Series["RandomSeries"].Points.Clear();
            AddPointsToChart(arrayofPoints, numberAtPoint);
            TextBoxMathExpectation.Text = GetMathExpectation(randomList).ToString();
            TextBoxDispersion.Text = GetDispersion(randomList).ToString();
            TextBoxStandardDeviation.Text = GetStandardDeviation(randomList).ToString();
        }

        private void ButtonMaxTriangleDistribution_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(InputBoxA.Text, out double a))
            {
                ShowInputError(LabelA, InputBoxA);
                return;
            }

            if (!double.TryParse(InputBoxB.Text, out double b))
            {
                ShowInputError(LabelB, InputBoxB);
                return;
            }

            if (!uint.TryParse(InputBoxN.Text, out uint n))
            {
                ShowInputError(LabelN, InputBoxN);
                return;
            }

            if (a >= b)
            {
                MessageBox.Show("a cannot be more or equal than b", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (b == 0 || n == 0)
            {
                MessageBox.Show("Input Parameters cannot be equal zero", "InputError", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var randomList = new List<double>();
            var minMaxList = new List<double>() { 0d, 0d };
            var random = new Random();
            for (int i = 0; i < n; i++)
            {
                minMaxList[0] = random.NextDouble();
                minMaxList[1] = random.NextDouble();
                randomList.Add(a + (b - a) * minMaxList.Max());
            }

            int[] numberAtPoint = new int[20];
            double[] arrayofPoints = new double[21];
            MakeIntervals(arrayofPoints, a, b);
            MakeChartDataY(randomList, arrayofPoints, numberAtPoint);
            ChartOfRandom.Series["RandomSeries"].Points.Clear();
            AddPointsToChart(arrayofPoints, numberAtPoint);
            TextBoxMathExpectation.Text = GetMathExpectation(randomList).ToString();
            TextBoxDispersion.Text = GetDispersion(randomList).ToString();
            TextBoxStandardDeviation.Text = GetStandardDeviation(randomList).ToString();
        }

        private void ButtonSimpsonDistribution_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(InputBoxA.Text, out double a))
            {
                ShowInputError(LabelA, InputBoxA);
                return;
            }

            if (!double.TryParse(InputBoxB.Text, out double b))
            {
                ShowInputError(LabelB, InputBoxB);
                return;
            }

            if (!uint.TryParse(InputBoxN.Text, out uint n))
            {
                ShowInputError(LabelN, InputBoxN);
                return;
            }

            if (a >= b)
            {
                MessageBox.Show("a cannot be more or equal than b", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (b == 0 || n == 0)
            {
                MessageBox.Show("Input Parameters cannot be equal zero", "InputError", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var randomList = new List<double>();
            var randomListY = new List<double>();
            var randomListZ = new List<double>();
            var random = new Random();
            for (int i = 0; i < n; i++)
            {
                randomListY.Add(random.NextDouble());
                randomListZ.Add(random.NextDouble());
            }

            randomListY = randomListY.Select(x => a / 2 + (b / 2 - a / 2) * x).ToList();
            randomListZ = randomListZ.Select(x => a / 2 + (b / 2 - a / 2) * x).ToList();
            randomList = randomListY.Zip(randomListZ, (x, y) => x + y).ToList();
            int[] numberAtPoint = new int[20];
            double[] arrayofPoints = new double[21];
            MakeIntervals(arrayofPoints, a, b);
            MakeChartDataY(randomList, arrayofPoints, numberAtPoint);
            ChartOfRandom.Series["RandomSeries"].Points.Clear();
            AddPointsToChart(arrayofPoints, numberAtPoint);
            TextBoxMathExpectation.Text = GetMathExpectation(randomList).ToString();
            TextBoxDispersion.Text = GetDispersion(randomList).ToString();
            TextBoxStandardDeviation.Text = GetStandardDeviation(randomList).ToString();
        }
    }
}
