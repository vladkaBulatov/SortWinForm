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
                if (valueFromTextBox[i] == '1' || valueFromTextBox[i] == '2' || valueFromTextBox[i] == '3' ||
                    valueFromTextBox[i] == '4' || valueFromTextBox[i] == '5' || valueFromTextBox[i] == '6' ||
                    valueFromTextBox[i] == '7' || valueFromTextBox[i] == '8' || valueFromTextBox[i] == '9' || valueFromTextBox[i] == '0')
                {
                    var addedElement = (int)Char.GetNumericValue(valueFromTextBox[i]);
                    numbers.Add(addedElement);
                }
            }
        }

        public void BubbleSort(ref List<int> variables)
        {
            again:
            for (int i = 1; i < variables.Count; i++)
            {   
                if (variables[i-1] > variables[i])
                {
                    Reshuffle(variables, i - 1, i);
                    goto again;
                }
            }
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
