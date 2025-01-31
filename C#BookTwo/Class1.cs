using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_BookTwo
{
    internal class Training
    {   
        public static void SelectionSort(int[] arr)
        {
            int n = arr.Length;

            for(int i = 0; i < n - 1; i++)
            {
                int minIndex = i;

                for(int j = i + 1; j < n; j++)
                {
                    if (arr[j] < arr[minIndex])
                    {
                        minIndex = j;
                    }
                }

                if(minIndex!=i)
                {
                    int temp = arr[i];
                    arr[i] = arr[minIndex];
                    arr[minIndex] = temp;
                }
            }
        }

        public static int BinarySearch(int[] arr, int target)
        {

            int left = 0;
            int right = arr.Length - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (arr[mid] == target)
                {
                    return mid;
                }

                if (arr[mid] < target)
                {
                    left = mid + 1;
                }
                else right = mid - 1;

            }

            return -1;
        }
    }
}
