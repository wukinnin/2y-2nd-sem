using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        const int size = 10;
        int[] numbers = new int[size];
        int currentIndex;

        private void getValuesButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtInput.Text, out int value))
            {
                numbers[currentIndex] = value;
                currentIndex++;
                MessageBox.Show("Value " + value + " is added to the array.");
                txtInput.Clear();
            }
            else
            {
                MessageBox.Show("Please enter a valid value.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnViewArray_Click(object sender, EventArgs e)
        {
            string arrayContent = "Current Array Contents:\n";
            for (int i = 0; i < currentIndex; i++)
            {
                int arrayNum = numbers[i];
                arrayContent += arrayNum.ToString() + "\n";
            }
            MessageBox.Show(arrayContent, "Array Contents");
        }

        private void btnResetArray_Click(object sender, EventArgs e)
        {
            Array.Clear(numbers, 0, numbers.Length);
            currentIndex = 0;
            MessageBox.Show("Array cleared.");
        }

        // COMPUTATIONS

        private void btnComputeMean_Click(object sender, EventArgs e)
        {
            ComputeMean();
        }

        private void ComputeMean()
        {
            if (currentIndex > 0)
            {
                int sum = 0;
                for (int i = 0; i < currentIndex; i++)
                {
                    sum += numbers[i];
                }
                double mean = (double)sum / currentIndex;
                MessageBox.Show("Mean: " + mean, "Mean");
            }
            else
            {
                MessageBox.Show("No values.", "Empty Array");
            }
        }

        private void btnComputeMode_Click(object sender, EventArgs e)
        {
            ComputeMode();
        }

        private void ComputeMode()
        {
            if (currentIndex > 0)
            {
                Dictionary<int, int> frequencyMap = new Dictionary<int, int>();
                foreach (int value in numbers)
                {
                    if (value != 0)
                    {
                        if (frequencyMap.ContainsKey(value))
                        {
                            frequencyMap[value]++;
                        }
                        else
                        {
                            frequencyMap[value] = 1;
                        }
                    }
                }
                int maxFrequency = frequencyMap.Values.Max();
                List<int> modes = frequencyMap.Where(kv => kv.Value == maxFrequency).Select(kv => kv.Key).ToList();

                // display message

                string modeMessage;
                if (modes.Count == 1)
                {
                    modeMessage = $"Mode: {modes[0]}";
                }
                else
                {
                    modeMessage = "Modes: " + string.Join(", ", modes);
                }
                MessageBox.Show(modeMessage, "Mode");
            }
            else
            {
                MessageBox.Show("No values.", "Empty Array");
            }
        }

        private void btnComputeMedian_Click(object sender, EventArgs e)
        {
            ComputeMedian();
        }

        private void ComputeMedian()
        {
            if (currentIndex > 0)
            {
                Array.Sort(numbers, 0, currentIndex);

                double median;
                if (currentIndex % 2 == 0)
                {
                    int middleIndex1 = currentIndex / 2 - 1;
                    int middleIndex2 = currentIndex / 2;
                    median = (numbers[middleIndex1] + numbers[middleIndex2]) / 2.0;
                }
                else
                {
                    int middleIndex = currentIndex / 2;
                    median = numbers[middleIndex];
                }

                MessageBox.Show($"Median: {median}", "Median");
            }
            else
            {
                MessageBox.Show("No values.", "Empty Array");
            }
        }



    }
}
