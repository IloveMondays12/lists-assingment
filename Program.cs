using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists__lesson_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random generator = new Random();
           List <int> numRange = new List<int>();
            for (int i = 0; i < 25;)
            {
             numRange.Add[generator.Next(10,20)];
            }

        }
    }
}
