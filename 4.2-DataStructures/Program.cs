using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._2_DataStructures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] OneD = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int[,] TwoD = new int[,] { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 6, 7 }, { 7, 8 } };
            int[] OneDPt2 = new int[10];
            for (int i = 0; i < OneDPt2.Length; i++)
            {
                OneDPt2[i] = i;
            }
            int[,] TwoDPt2 = new int[8,8];
            TwoDPt2[0, 0] = 0;
            TwoDPt2[1, 0] = 1;
            //  TwoDPt2[8, 8] = 2;
            int[,,] ThreeD = new int[3,3,5];
            ThreeD[0, 0, 0] = 0;

            List<string> names = new List<string>();
            names.Add("Bob");
            names.Add("Bill");
            names.Add("Betty");
            names.Add("Bob");



            
            Queue<int> line = new Queue<int>();
            line.Enqueue(0);
            line.Enqueue(1);
            line.Enqueue(2);
            Console.WriteLine(line.Peek());
            Console.WriteLine(line.Dequeue());
            Console.WriteLine(line.Peek());

            Stack<string> pileOfThings = new Stack<string>();
            pileOfThings.Push("one");
            pileOfThings.Push("two");
            pileOfThings.Push("three");
            Console.WriteLine(pileOfThings.Peek());
            Console.WriteLine(pileOfThings.Pop());
            Console.WriteLine(pileOfThings.Peek());

        }
    }
}
