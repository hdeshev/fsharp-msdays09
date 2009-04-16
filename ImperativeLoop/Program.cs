using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ImperativeLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            var from = new List<int>() { 1, 2, 3 };
            var to = new List<int>();
            for (int i = 0; i < from.Count; i++)
            {
                to.Add(from[i] * 2);
            }
        }
    }
}
