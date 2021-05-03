using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingApplication.Models
{
    public abstract class Algorithm
    {
        public abstract void Sort(int[] array);
        public int Swapped = 0;

        public void Swap(int index1, int index2, int[] array)
        {
            int temp = array[index1];
            array[index1] = array[index2];
            array[index2] = temp;
            Swapped++;
        }
    }
}
