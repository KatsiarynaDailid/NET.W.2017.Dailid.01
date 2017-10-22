using System.Linq;

namespace Library
{
    public static class Sort
    {

        /// <summary>
        /// Quick Sort method is an implementation of sorting algorithm, that place the elements of an array in order.
        /// </summary>
        /// <param name="array">Int array that needs to be sort</param>
        public static void QuickSort(int[] array)
        {
            if (Verify(array))
            {
                QuickSort(array, 0, array.Length - 1);
            }
        }

        /// <summary>
        /// Merge Sort method is an implementation of comparison-based sorting algorithm, that place the elements of an array in order.
        /// </summary>
        /// <param name="array">Int array that needs to be sort</param>
        public static void MergeSort(int[] array)
        {
            if (Verify(array))
            {
                MergeSortRecursive(array);
            }
        }
        private static void QuickSort(int[] array, int left, int right)
        {
            if (left >= right)
            {
                return;
            }

            int pivot = right;
            //separator for two subarrays
            int separator = left;

            for (int j = left; j <= right; j++)
            {
                if (array[j] < array[pivot])
                {
                    Swap(array, separator, j);
                    separator++;
                }
            }

            //put pivot between left and right subarrays
            Swap(array, separator, right);

            //recursion
            QuickSort(array, left, separator - 1);
            QuickSort(array, separator + 1, right);
        }

        private static int[] MergeSortRecursive(int[] array)
        {
            if (array.Length == 1)
                return array;
            int mid_point = array.Length / 2;

            return Merge(array, MergeSortRecursive(array.Take(mid_point).ToArray()), MergeSortRecursive(array.Skip(mid_point).ToArray()));
        }

        private static int[] Merge(int[] array, int[] firstArray, int[] secondArray)
        {
            int a = 0, b = 0;
            int[] resultaArray = new int[firstArray.Length + secondArray.Length];
            for (int i = 0; i < firstArray.Length + secondArray.Length; i++)
            {
                if (b < secondArray.Length && a < firstArray.Length)
                {
                    if (firstArray[a] > secondArray[b])
                        resultaArray[i] = secondArray[b++];
                    else
                        resultaArray[i] = firstArray[a++];
                }
                else
                {
                    if (b < secondArray.Length)
                        resultaArray[i] = secondArray[b++];
                    else
                        resultaArray[i] = firstArray[a++];
                }
            }

            for(int i = 0; i < resultaArray.Length; i++)
            {
                array[i] = resultaArray[i]; 
            }

            return array;
        }

        private static bool Verify(int[] array)
        {
            if (array.Length == 1)
            {
                return false;
            }

            if (array == null)
            {
                throw new System.ArgumentException("Parameter cannot be null", "array");
            }

            return true;
        }

        //i remember that you've told us not to use array in Swap. I've tried but it didn't work for me :(
        private static void Swap(int[] array, int i, int j)
        {
            var temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }


    }
}
