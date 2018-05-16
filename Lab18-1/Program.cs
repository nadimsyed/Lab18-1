using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab18_1
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            list.AddAtStart("Adam");
            list.AddAtStart("Adam");
            list.AddAtStart("Cat");
            list.AddAtStart("Mohammed");
            list.AddAtStart("Shaun");
            list.AddToEnd("Danny");
            list.AddToEnd("Jaide");

            //list.PrintAllNodes();
            //list.RemoveFromStart();
            //Console.WriteLine();
            //Console.WriteLine();
            //list.PrintAllNodes();
            //list.RemoveAllFromStart(list);
            //for (int i = 0; i < list.Count; i++)
            //{
            //    list.RemoveFromStart();
            //}
            Console.WriteLine();
            Console.WriteLine();
            list.PrintAllNodes();
            Console.WriteLine();
            Console.WriteLine();
            list.RemoveAllObjectO("Adam");
            list.PrintAllNodes();
        }
    }
}
