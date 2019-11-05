using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RNDVS2017_ConsoleApp
{
    class QuickSorting
    {
        static public int Partition(int[] arr, int left, int right)
        {
            int pivot;
            pivot = arr[left];
            while (true)
            {
                while (arr[left] < pivot)
                {
                    left++;
                }
                while (arr[right] > pivot)
                {
                    right--;
                }
                if (left < right)
                {
                    int temp = arr[right];
                    arr[right] = arr[left];
                    arr[left] = temp;
                }
                else
                {
                    return right;
                }
            }
        }

        static public void quickSort(int[] arr, int left, int right)
        {
            int pivot;
            if (left < right)
            {
                pivot = Partition(arr, left, right);
                if (pivot > 1)
                {
                    quickSort(arr, left, pivot - 1);
                }
                if (pivot + 1 < right)
                {
                    quickSort(arr, pivot + 1, right);
                }
            }
        }

        static public List<char> Sort(List<char> charList)
        {
            if (charList.Count <= 1)
                return charList;

            //int[] sortedList = new int[charList.Count];

            //Random ran = new Random();
            //int pointer = ran.Next(0, charList.Count - 1);

            //select a pivot from the list based on the random number.
            char pivot = charList[0];

            //Create two lists for each pivot.Left list will contain the lesser items and right list
            //will contain all the grater items then pivot
            List<char> leftList = new List<char>();
            List<char> rightList = new List<char>();

            foreach (var item in charList)
            {
                if (item < pivot)
                    leftList.Add(item);
                else if (item > pivot)
                    rightList.Add(item);
            }

            //Call the same method recursively unless we have one items left in each left and right
            //side
            var mergedSolution = Sort(leftList);
            mergedSolution.Add(pivot);
            mergedSolution.AddRange(Sort(rightList));

            return mergedSolution;
        }

        static public List<int> Sort1(List<int> charList)
        {
            if (charList.Count <= 1)
                return charList;

            //int[] sortedList = new int[charList.Count];

            //Random ran = new Random();
            //int pointer = ran.Next(0, charList.Count - 1);

            //select a pivot from the list based on the random number.
            int pivot = charList[0];

            //Create two lists for each pivot.Left list will contain the lesser items and right list
            //will contain all the grater items then pivot
            List<int> leftList = new List<int>();
            List<int> rightList = new List<int>();

            foreach (var item in charList)
            {
                if (item < pivot)
                    leftList.Add(item);
                else if (item > pivot)
                    rightList.Add(item);
            }

            //Call the same method recursively unless we have one items left in each left and right
            //side
            var mergedSolution = Sort1(leftList);
            mergedSolution.Add(pivot);
            mergedSolution.AddRange(Sort1(rightList));

            return mergedSolution;
        }

        public static List<int> Sort2(List<int> intList)
        {
            if (intList.Count <= 1)
                return intList;

            int Pivot = intList[0];

            List<int> Left = new List<int>();
            List<int> Right = new List<int>();

            foreach (int item in intList)
            {
                if (item < Pivot)
                    Left.Add(item);
                if (item > Pivot)
                    Right.Add(item);
            }

            var MergeList = Sort2(Left);
            MergeList.Add(Pivot);
            MergeList.AddRange(Sort2(Right));

            return MergeList;
        }

        public static string RemoveDuplicateChars(string key)
        {
            string inputCheck = string.Empty;
            string result = string.Empty;

            foreach (char item in key)
            {
                if (!inputCheck.Contains(item))
                {
                    inputCheck += item;
                    result += item;
                }
            }

            return result;
        }

        static int index1 = 0;
        static string inputCheck = string.Empty;
        static string result1 = string.Empty;
        public static string RemoveRecursiveDuplicateChars(string key)
        {
           
            char[] charArray = key.ToArray();

            if (index1 > charArray.Length - 1)
                return result1;

            //foreach (char item in key)
            //{
            if (!inputCheck.Contains(charArray[index1]))
            {
                inputCheck += charArray[index1];
                result1 += charArray[index1];
            }
            //}
            index1++;
            RemoveRecursiveDuplicateChars(key);

            return result1;
        }

        public static string ReverseString(string key)
        {
            string result = string.Empty;

            for (int i = key.Length - 1; i >= 0; i--)
            {
                result += key[i];
            }

            return result;
        }

        static int index = 0;
        static string result = string.Empty;

        public static string ReverseStringRecursive(string key)
        {
            index++;

            if (key.Length - index < 0)
                return result;

            //for (int i = key.Length - 1; i >= 0; i--)
            //{
            result += key[key.Length - index];
            ReverseStringRecursive(key);
            //}

            return result;
        }

        public static int CountNumberOfWords(string key)
        {
            int result = 0;

            if (key.Contains("  "))
                key.Replace("  ", " ");

            foreach (string item in key.Split(' '))
                result += 1;

            return result;
        }

        public static bool IsPalindrome(string key)
        {
            int Min = 0;
            int Max = key.Length - 1;

            while (true)
            {
                if (Min > Max)
                    return true;

                char minVal = key[Min];
                char maxVal = key[Max];

                if (minVal != maxVal)
                    return false;

                Min++;
                Max--;
            }
        }

        public static bool IsDuplicateChars(string key)
        {
            string inputCheck = string.Empty;
            bool IsDuplicateChar = false;

            foreach (char item in key)
            {
                if (!inputCheck.Contains(item))
                {
                    inputCheck += item;
                }

                if (inputCheck.ToLower() == key.ToLower())
                    IsDuplicateChar = false;
                else
                    IsDuplicateChar = true;
            }

            return IsDuplicateChar;
        }

        public static List<string> GetAllSubString(string key)
        {
            List<string> lstResult = new List<string>();

            for (int i = 1; i <= key.Length; i++)
            {
                for (int j = 0; j <= key.Length - i; j++)
                {
                    lstResult.Add(key.Substring(j, i));
                }
            }

            return lstResult;
        }

        public static List<int> BubleSorting(int[] key)
        {
            List<string> lstResult = new List<string>();

            for (int i = 0; i <= key.Length - 1; i++)
            {
                for (int j = i + 1; j <= key.Length - 1; j++)
                {
                    if (key[i] > key[j])
                    {
                        int temp = key[i];
                        key[i] = key[j];
                        key[j] = temp;
                    }

                }
            }

            return key.ToList();
        }

        //public static int getMissingNo(int[] a, int n)
        //{
        //    int total = (n + 1) * (n + 2) / 2;

        //    for (int i = 0; i < n; i++)
        //        total -= a[i];

        //    return total;
        //}

        public static int geMissingNo(int[] arr, int val)
        {
            int SummedVal = (val + 1) * (val + 2) / 2;

            for (int i = 0; i < val; i++)
                SummedVal -= arr[i];

            return SummedVal;
        }

        static int je = 0;
        public static void getPairsCount(int[] arr,int sum)
        {
            int count = 0;


            for (int i = 0; i < arr.Length; i++)
            {
                //for (int j = i + 1; j < arr.Length; j++)
                //{
                je = i + 1;
                    if ((arr[i] + arr[je]) == sum)
                        count++;

                getPairsCount(arr, sum);
                //}
            }

            Console.WriteLine("Count of pairs is " +
                                             count);
        }
    }
}
