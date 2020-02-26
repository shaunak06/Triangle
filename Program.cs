using System;
using System.IO;

namespace Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            var total = 0;
            var lastLocation = 0;
            using(var sr = new StreamReader("../../../triangle.txt"))
            {
                while (!sr.EndOfStream)
                {
                    var line = sr.ReadLine();
                    var values = line?.Split(" ");

                    if (values == null || values.Length < 2) continue;
                    if (values?.Length == 2)
                        total += int.Parse(values[0]);
                    else
                    {
                        var child1 = int.Parse(values[lastLocation]);
                        var child2 = int.Parse(values[lastLocation + 1]);
                        if (child1 > child2)
                        {
                            total += child1;
                        }
                        else
                        {
                            total += child2;
                            lastLocation++;
                        }
                    }
                }
            }
            Console.WriteLine(total);
        } 
    }
}