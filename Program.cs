using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (var n in Enumerable.Range(0, 100)) Console.Write(n);   //Rangeメソッド(Enumerableクラス,Enumerableメソッドの一つ)　 
            Console.WriteLine("");
        }
    }
}
