using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortWinForm
{
    public class BubbleSort
    {
        List<int> NumbersBubbleSort;

        public BubbleSort()
        {
            
        }

        public void BubbleSort (ref List<int> numbersBubbleSort) 
        {
            bool swapped;
            do
            {
                swapped = false;
                for(int i = 1; i < NumbersBubbleSort.Count; i++)
                {
                    if(NumbersBubbleSort[i - 1].CompareTo(NumbersBubbleSort[i]) > 0)
                    {
                        Swap(NumbersBubbleSort, i-1, i);
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
