using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace RNDVS2017_ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<string> lstLink = new LinkedList<string>();
            lstLink.AddLast("Mantu");
            lstLink.AddLast("Santu");
            lstLink.AddLast("Pappu");

            foreach (string str in lstLink)
            {
                Console.WriteLine(str);
            }

            lstLink.Remove(lstLink.First);
            lstLink.Remove("Pappu");
            lstLink.RemoveFirst();
            lstLink.RemoveLast();

            //lstLink.AddBefore(lstLink[1], "Manish");

            if (lstLink.Contains("Santu") == true)
            {

            }

            //int[] arr = { 1, 5, 7, -1 };
            //QuickSorting.getPairsCount(arr, 6);

            //int[] a = { 1, 2, 4 };
            //int miss = QuickSorting.geMissingNo(a,3);
            //Console.Write(miss);

            //string strValue = "Manianh";

            //string result = QuickSorting.RemoveRecursiveDuplicateChars(strValue);

            //int[] arr = { 67, 12, 95, 56, 85, 1, 100, 23, 60, 9 };
            //int n = 10, i;
            //Console.WriteLine("Quick Sort");
            //Console.Write("Initial array is: ");
            //for (i = 0; i < n; i++)
            //{
            //    Console.Write(arr[i] + " ");
            //}
            //QuickSorting.quickSort(arr, 0, 9);
            //Console.Write("\nSorted Array is: ");
            //for (i = 0; i < n; i++)
            //{
            //    Console.Write(arr[i] + " ");
            //}

            //char[] arrChar = { 'B', 'A', 'C', 'D', 'F', 'E', 'I' };

            //List<char> cList = QuickSorting.Sort(arrChar.ToList());

            //Console.Write("\nSorted Array is: ");
            //for (int i = 0; i < cList.Count - 1; i++)
            //{
            //    Console.Write(arr[i] + " ");
            //}

            //int[] arrInt = { 5, 3, 1, 66, 12, 15, 19 };

            //List<int> cList1 = QuickSorting.Sort2(arrInt.ToList());

            //Console.Write("\nSorted Array is: ");
            //for (int i = 0; i < cList1.Count ; i++)
            //{
            //    Console.Write(cList1[i] + " ");
            //}

            //Console.ReadLine();

            //string inputValue = "Csharpstar";

            //string result = QuickSorting.RemoveDuplicateChars(inputValue);

            //string result = QuickSorting.ReverseString(inputValue);

            //string result = QuickSorting.ReverseStringRecursive(inputValue);

            //bool result = QuickSorting.IsPalindrome("shdahs");

            //bool result = QuickSorting.IsDuplicateChars("shdgdyu");

            //List<string> lstResult = QuickSorting.GetAllSubString(inputValue);

            //List<int> lstResult = QuickSorting.BubleSorting(arr);

        }
    }
}
