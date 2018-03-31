using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SortWinForm
{
    public partial class SortWinForm : Form
    {
        public SortWinForm()
        {
            InitializeComponent();
        }

        private void buttonSort_Click(object sender, EventArgs e)
        {
            displaySort.Clear();
            List<int> numbers = new List<int>();

            string valueFromTextBox = introducedNumbers.Text;

            CheckingAndAdditionCharacters(numbers, valueFromTextBox);
            numbers = SelectionOfSorts(numbers);

            for (int i = 0; i < numbers.Count; i++)
            {
                displaySort.Text += Convert.ToString(numbers[i]) + " ";
            }
        }

        private List<int> SelectionOfSorts(List<int> numbers)
        {
            if (bubbleSort.Checked == true)
            {
                BubbleSort(ref numbers);
            }
            else if (SortByChoice.Checked == true)
            {

            }

            return numbers;
        }

        private static void CheckingAndAdditionCharacters(List<int> numbers, string valueFromTextBox)
        {
            for (int i = 0; i < valueFromTextBox.Length; i++)
            {
                if (IsNumeral(valueFromTextBox[i]))
                {
                    var addedElement = (int)Char.GetNumericValue(valueFromTextBox[i]);
                    numbers.Add(addedElement);
                }
            }
        }

        private static bool IsNumeral(char value)
        {
            var result = value == '1' || value == '2' || value == '3' ||
                    value == '4' || value == '5' || value == '6' ||
                    value == '7' || value == '8' || value == '9' || value == '0';
            return result;
        }

        public void BubbleSort(ref List<int> variables)
        {
            for (int k = 0; k < variables.Count - 1; k++)
                for (int i = 0; i < variables.Count - 1; i++)
                    if (variables[i] > variables[i+1])
                        Reshuffle(variables, i, i + 1);
        }
        void Reshuffle(List<int> variables, int left, int right)
        {
            if (left != right)
            {
                int timeVariable = variables[left];
                variables[left] = variables[right];
                variables[right] = timeVariable;
            }
        }
    }
}
