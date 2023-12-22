using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;
class tes1
{

}
struct s1 { }
enum s2 { }
namespace Dec22DSList
{
    internal class Program
    {
        static void FunsArray()
        {
            Array s;
            int temp;
            // Array ar;
            int[] arr = new int[] { 6, 45, 3, 22, 9 };
            Console.WriteLine("unsorted array is ");
            foreach (int i in arr) { Console.WriteLine("values is " + i); }
            // array has sort()
            // Array.Sort(ar1);// values automatically arrange in acs order a-z or 0-9
            Console.WriteLine("array ");
            Console.WriteLine("sorted array");
            //  foreach(var v in ar1) { //Console.WriteLine("values in sorted array {0} ",v);
            //iterative way of sorting
            for (int ar1 = 0; ar1 < arr.Length - 1; ar1++)
            {
                // need perform i +1 to array length
                for (int ar2 = ar1 + 1; ar2 < arr.Length; ar2++)
                {
                    // compare values with all next values
                    if (arr[ar1] > arr[ar2])//6> 45
                    {
                        temp = arr[ar1];//temp is 6
                        arr[ar1] = arr[ar2];// 45 is saved in ar1
                        arr[ar2] = temp;// ar2 6 in 2 place , 45 is 1st place
                    }
                    Console.WriteLine();
                    foreach (int num in arr) { Console.WriteLine(num); }
                }
            }
        }
        static void Main(string[] args)
        {
            FunsArray();
            Console.ReadLine();
        }
    }
}
