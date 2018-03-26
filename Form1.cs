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
            
            string str = introducedNumbers.Text;

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == '1' || str[i] == '2'|| str[i] == '3'||
                    str[i] == '4'|| str[i] == '5'|| str[i] == '6'||
                    str[i] == '7'|| str[i] == '8'|| str[i] == '9'|| str[i] == '0')
                {
                    
                    int c = (int)Char.GetNumericValue(str[i]);

                    numbers.Add(c);
                }
            }
            
            
            for (int i = 0; i < numbers.Count; i++)
            {
                displaySort.Text += Convert.ToString(numbers[i]) + ",";
            }
            
            
        }

        public void BubbleSort(ref List<int> items)
        {
            
            bool swapped;
            do
            {
                swapped = false;
                for (int i = 1; i < items.Count; i++)
                {
                    if (items[i - 1].CompareTo(items[i]) > 0)
                    {
                        Swap(items, i - 1, i);
                        swapped = true;
                    }
                }
            }
            while (swapped != false);

        }
        void Swap(List<int> items, int left, int right)
        {
            if (left != right)
            {
                int temp = items[left];
                items[left] = items[right];
                items[right] = temp;
            }
        }

        
    }
}
