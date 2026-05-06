using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm
{
    public class Homework
    {
        public void Main(string[] args)
        {
            var son = int.Parse(Console.ReadLine());
            Console.WriteLine(Task1(son));
        }
      
        public int Task1(int a)
        {
            return a * 5;
        }
    }
}
