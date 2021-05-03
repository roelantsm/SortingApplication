using SortingApplication.Models;
using SortingApplication.Models.Algorithms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SortingApplication
{
    partial class SortingAlgorithmTester
    {

        //private int swapped = 0;

        //void Swap(int index1, int index2, int[] array)
        //{
        //    int temp = array[index1];
        //    array[index1] = array[index2];
        //    array[index2] = temp;
        //    swapped++;
        //}

        //void QuickSort(int[] array)
        //{
        //    QuickSort(array, 0, array.Length - 1);
        //}

        //void QuickSort(int[] array, int Left, int Right)
        //{
        //    int L = Left;
        //    int R = Right;
        //    int pivotValue = array[(Left + Right) / 2];

        //    do
        //    {
        //        while (array[L] < pivotValue)
        //        {
        //            L++;
        //        }
        //        while (pivotValue < array[R])
        //        {
        //            R--;
        //        }

        //        if (L <= R)
        //        {
        //            Swap(L, R, array);
        //            L++;
        //            R--;
        //        }
        //    } while (L < R);

        //    if (Left < R)
        //    {
        //        QuickSort(array, Left, R);
        //    }
        //    if (L < Right)
        //    {
        //        QuickSort(array, L, Right);
        //    }
        //}

        //void ShakerSort(int[] array)
        //{
        //    bool swapped = true;
        //    while (swapped)
        //    {
        //        swapped = false;
        //        for (int i = 0; i < array.Length - 1; ++i)
        //        {
        //            if (array[i] > array[i + 1])
        //            {
        //                swapped = true;
        //                Swap(i, i + 1, array);
        //            }
        //        }

        //        if (!swapped) break;

        //        for (int i = array.Length - 2; i >= 0; --i)
        //        {
        //            if (array[i] > array[i + 1])
        //            {
        //                swapped = true;
        //                Swap(i, i + 1, array);
        //            }
        //        }
        //    }
        //}

        //void BubbleSort(int[] array)
        //{
        //    bool swapped = true;
        //    while (swapped)
        //    {
        //        swapped = false;
        //        for (int i = 0; i < array.Length - 1; ++i)
        //        {
        //            if (array[i] > array[i + 1])
        //            {
        //                swapped = true;
        //                Swap(i, i + 1, array);
        //            }
        //        }
        //    }
        //}


        // verplaatsen niet in tester klasse
        //void Sort(Algorithm algorithm, int[] array)
        //{
        //    algorithm.Sort(array);
        //}

        public void Test()
        {

            // kan beter met reflection
            var values = new List<Algorithm>();
            values.Add(new BubbleSortAlgorithm());
            values.Add(new QuickSortAlgorithm());
            values.Add(new ShakerSortAlgorithm());

            foreach (var algorithm in values)
            {
                algorithm.Swapped = 0;
                int[] array = { 88, 12, 55, 105, 48, 84, 66, 35, 57, 89, 74, 106, 200, 541, 1, 9, 7, 55, 405, 13 };
                algorithm.Sort(array);
                Console.WriteLine($"sorting done using {algorithm}, needed {algorithm.Swapped} swaps to sort the array");
            }

            Console.ReadKey();
        }
    }
}
