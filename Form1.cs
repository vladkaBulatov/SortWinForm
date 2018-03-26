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
            //List<int> numbersBubbleSort = new List<int> { 5, 6, 8, 12, 20, 50, 1, 3 };
            List<int> numbersBubbleSort = new List<int>();
            
            string str = null;

            for (int i = 0; i < str.Length; i++)
            {
                str = introducedNumbers.Text;
                if (str[i] == '1' || str[i] == '2'|| str[i] == '3'||
                    str[i] == '4'|| str[i] == '5'|| str[i] == '6'||
                    str[i] == '7'|| str[i] == '8'|| str[i] == '9'|| str[i] == '0')
                {
                    numbersBubbleSort.Add(str[i]);
                }
            }
            
            //BubbleSort(ref numbersBubbleSort);
            for (int i = 0; i < numbersBubbleSort.Count; i++)
            {
                displaySort.Text += Convert.ToString(numbersBubbleSort[i]) + ",";
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
