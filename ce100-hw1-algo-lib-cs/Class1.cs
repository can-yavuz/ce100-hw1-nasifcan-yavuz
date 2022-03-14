/**
  * @file CE100-HW1-Lib.c
  * @author NASIF CAN YAVUZ
  * @date 14 March 2022
  *
  * @brief <b> HW-1 Functions </b>
  *
  * HW-1 Sample Lib Functions
  *
  * @see http://bilgisayar.mmf.erdogan.edu.tr/en/
  *
  */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ce100_hw1_algo_lib_cs
{
    public class Class1
    {
        /**
*
*	  @name   Insertion Sort (ce100_InsertionSort)
*
*	  @brief Insertion Sort Function
*
*	  The Insertion Sort function is a function that sorts the mixed numbers in the system from smallest to largest.
*
*	  @param  [in] mass.Lenght [\b int]  cur of Insertion Sort Function
*
*	  @retval [\b int] Function Insertion Sort
*/

        public static void InsSort(int[] mass)
        {
            for (int i = 1; i < mass.Length; i++)
            {
                int cur = mass[i];
                int j = i;
                while (j > 0 && cur < mass[j - 1])
                {
                    mass[j] = mass[j - 1];
                    j--;
                }
                mass[j] = cur;
            }
        }


        /**
*
*	  @name   Selection Sort (ce100_SelectionSort)
*
*	  @brief Selection Sort Function
*
*	  The selection sort algorithm sorts an array by repeatedly finding the minimum element
*	  from unsorted part and putting it at the beginning.
*
*	  @param  [in] numArray [\b int]  arrayLength of Selection Sort Function
*
*	  @retval [\b int] Function Selection Sort
*/

        public static int[] SortArray(int[] numArray, int arrayLength)
        {
            int tempVar, smallestVal;
            for (int i = 0; i < arrayLength - 1; i++)
            {
                smallestVal = i;
                for (int j = i + 1; j < arrayLength; j++)
                {
                    if (numArray[j] < numArray[smallestVal])
                    {
                        smallestVal = j;
                    }
                }
                tempVar = numArray[smallestVal];
                numArray[smallestVal] = numArray[i];
                numArray[i] = tempVar;
            }
            return numArray;
        }

        /**
*
*	  @name   Recursive Power (ce100_RECURSIVE-POWER)
*
*	  @brief Recursive Power Function
*
*	  Recursive Power is a function that uses the first number entered as the base and the second number as the exponent.
*
*	  @param  [in] x [\b int]  y of Recursive Power Function
*
*	  @retval [\b int] Function Recursive Power
*/
        public static int CalcuOfPower(int x, int y)
        {
            if (y == 0)
                return 1;
            else
                return x * CalcuOfPower(x, y - 1);
        }
        /**
*
*	  @name   Naive Power (ce100_Naivepower)
*
*	  @brief Naive Power Function
*
*	  Naive Power is a function that uses the first number entered as the base and the second number as the exponent.
*
*	  @param  [in] x [\b int]  y of Naive Power Function
*
*	  @retval [\b int] Function Naive Power
*/

        public static int Naivepower(int x, int y)
        {
            int pow = 1;

            for (int i = 1; i <= y; i++)
            {
                pow = pow * x;
            }

            return pow;
        }


        /**
*
*	  @name   Binary Search Recursive (ce100_BinarySearchRecursive)
*
*	  @brief Binary Search Recursive Function
*
*	  It is a function that shows the index of the entered key.
*
*	  @param  [in] inputArray, min [\b int]  max, key of Binary Search Recursive Function
*
*	  @retval [\b int] Function Binary Search Recursive
*/

        public static int BinarySearchRecursive(int[] inputArray, int min, int max, int key)
        {


            int mid = min + (max - min) / 2;

            if (key == inputArray[mid])
            {
                return mid;
            }
            else if (key < inputArray[mid])
            {
                return BinarySearchRecursive(inputArray, min, mid - 1, key);
            }
            else
            {
                return BinarySearchRecursive(inputArray, mid + 1, max, key);
            }

        }


        /**
*
*	  @name   Binary Search Iterative (ce100_BinarySearchIterative)
*
*	  @brief Binary Search Iterative Function
*
*	  It is a function that finds the order of the numbers in a regular array.
*
*	  @param  [in] inputArray [\b int]  key of Binary Search Iterative Function
*
*	  @retval [\b int] Function Binary Search Iterative
*/

        public static int BinarySearchIterative(int[] inputArray, int key)
        {
            int min = 0;
            int max = inputArray.Length - 1;
            while (min <= max)
            {
                int mid = (min + max) / 2;
                if (key == inputArray[mid])
                {
                    return mid;
                }
                else if (key < inputArray[mid])
                {
                    max = mid - 1;
                }
                else
                {
                    min = mid + 1;
                }
            }
            return -1;
        }

        /**
        *
        *	  @name   Merge Sort (ce100_Merge_Sort)
        *
        *	  @brief Merge Sort Function
        *
        *	  It is a function that is used to sort the array of mixed numbers from smallest to largest..
        *	  
        *
        *	  @param  [in] array.Lenght [\b int]  midpoint of Merge Sort Function 
        *
        *	  @retval [\b int] function Merge Sort */

        public static int[] mergeSort(int[] array)
        {
            int[] left;
            int[] right;
            int[] result = new int[array.Length];
            //As this is a recursive algorithm, we need to have a base case to 
            //avoid an infinite recursion and therfore a stackoverflow
            if (array.Length <= 1)
                return array;
            // The exact midpoint of our array  
            int midPoint = array.Length / 2;
            //Will represent our 'left' array
            left = new int[midPoint];

            //if array has an even number of elements, the left and right array will have the same number of 
            //elements
            if (array.Length % 2 == 0)
                right = new int[midPoint];
            //if array has an odd number of elements, the right array will have one more element than left
            else
                right = new int[midPoint + 1];
            //populate left array
            for (int i = 0; i < midPoint; i++)
                left[i] = array[i];
            //populate right array   
            int x = 0;
            //We start our index from the midpoint, as we have already populated the left array from 0 to 

            for (int i = midPoint; i < array.Length; i++)
            {
                right[x] = array[i];
                x++;
            }
            //Recursively sort the left array
            left = mergeSort(left);
            //Recursively sort the right array
            right = mergeSort(right);
            //Merge our two sorted arrays
            result = merge(left, right);
            return result;
        }

        //This method will be responsible for combining our two sorted arrays into one giant array
        public static int[] merge(int[] left, int[] right)
        {
            int resultLength = right.Length + left.Length;
            int[] result = new int[resultLength];
            //
            int indexLeft = 0, indexRight = 0, indexResult = 0;
            //while either array still has an element
            while (indexLeft < left.Length || indexRight < right.Length)
            {
                //if both arrays have elements  
                if (indexLeft < left.Length && indexRight < right.Length)
                {
                    //If item on left array is less than item on right array, add that item to the result array 
                    if (left[indexLeft] <= right[indexRight])
                    {
                        result[indexResult] = left[indexLeft];
                        indexLeft++;
                        indexResult++;
                    }
                    // else the item in the right array wll be added to the results array
                    else
                    {
                        result[indexResult] = right[indexRight];
                        indexRight++;
                        indexResult++;
                    }
                }
                //if only the left array still has elements, add all its items to the results array
                else if (indexLeft < left.Length)
                {
                    result[indexResult] = left[indexLeft];
                    indexLeft++;
                    indexResult++;
                }
                //if only the right array still has elements, add all its items to the results array
                else if (indexRight < right.Length)
                {
                    result[indexResult] = right[indexRight];
                    indexRight++;
                    indexResult++;
                }
            }
            return result;
        }

    }
}
    

