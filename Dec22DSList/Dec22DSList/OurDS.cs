using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dec22DSList
{
    public class OurDS
    {
        // System.Collections allow object type which means any value is assigned no fixed type
        static void ListArrayFuns()
        {
            ArrayList ar1 = new ArrayList(); ;
            ar1.Add("hello");
            ar1.Add("world");
            ar1.Add("friday");
            //  ar1.Remove("friday");//value
            //  ar1.RemoveAt(1);//index number
            //  ar1.Clear();//all values gone
            int cap1 = ar1.Capacity;
            string[] strArr = { "abc", "xyz" };
            ar1.AddRange(strArr);
            ar1.Insert(1, "All");//2 position is All
            int li = ar1.LastIndexOf("abc");
            bool b1 = ar1.IsFixedSize;
            bool b2 = ar1.IsReadOnly;
            // to display
            foreach (string onevalue in ar1) { Console.WriteLine(onevalue); }
        }
        static void TableHashFuns()
        {
            Hashtable ht1 = new Hashtable();
            ht1.Add(1000, "abc");//key,value
            ht1.Add(1, "xyz");
            ht1.Add(45, "world");
            // ht1.Remove(45);// remove is by key not value
            //  ht1.Clear();
            // access by key
            ICollection allKeys = ht1.Keys;
            foreach (var item in allKeys)
            {
                Console.WriteLine("key is " + item);
            }
            ICollection allValues = ht1.Values;
            foreach (string str in allValues) { Console.WriteLine("values are " + str); }
            // both in one object is dictonaryEntry is Special collection
            foreach (DictionaryEntry de in ht1)
            {
                Console.WriteLine("key is " + de.Key);
                Console.WriteLine("values " + de.Value);
            }
            //serach
            bool b1 = ht1.Contains(1);//  takes key 
            bool b2 = ht1.ContainsKey(45);
            bool b3 = ht1.ContainsValue("xyz");
            string[] strArr = { "abc", "xyz" };
            ht1.CopyTo(strArr, 1);// ft=rom hashtable to array values are copied 
            //key is used to search as indentity     
            // HashTable is Complex DS in non-sequence catogery

        }
        static void DoubleLL()
        {
            LinkedList<string> ll = new LinkedList<string>();
            ll.AddLast("amit");
            ll.AddLast("lina");
            ll.AddFirst("komal");
            ll.AddFirst("bindu");
            ll.AddBefore(ll.Last, "Julia");
            // display how they got added
            foreach (var v in ll)
            {
                Console.WriteLine(v);
            }
            // ll.CopyTo("string array",indexno) from LL values are copied to array         
            // remove
            // ll.RemoveFirst();
            // ll.RemoveLast();
            Console.WriteLine("trying to rmove xyz not part of LL");
            //   ll.Remove("xyz");// no exception is raised 
            bool b1 = ll.Contains("xyz");//search for values then check if condition
            if (b1.Equals(true)) { Console.WriteLine("Yes Xyz "); ll.Remove("xyz"); } else { Console.WriteLine("values is not LL"); }
            //  Console.WriteLine("done ");
            //  ll.Remove(ll.Last);
            //  ll.Remove(ll.First);

        }
        static void Main(string[] args)
        {
            // ListArrayFuns();
            DoubleLL();
            Console.ReadLine();

        }
    }
}

