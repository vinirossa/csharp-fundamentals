using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Mathematics
{
    public class Algebra
    {

        public void FirstDegreeEquation(decimal? y = null,
                                       decimal? a = null,
                                       decimal? x = null,
                                       decimal? b = null)
        {
            var variables = new List<decimal?>() { y, a, x, b };
            var nulls = variables.Count(item => item == null);

            var y_ = (y == null) ? nameof(y) : y.ToString();
            var a_ = (a == null) ? nameof(a) : a.ToString();
            var x_ = (x == null) ? nameof(x) : x.ToString();
            var b_ = (b == null) ? nameof(b) : b.ToString();


            if (!AllEqual(variables))
            {
                Console.WriteLine("-- Formula --");
                Console.WriteLine("y = a.x + b");
                Console.WriteLine(String.Format("{0} = {1}.{2} + {3}", y_, a_, x_, b_));

                if (nulls == 1)
                {


                    if (y is null)
                    {
                        y = a * x + b;
                    }
                    else if (a is null)
                    {
                        a = (y - b) / x;
                    }
                    else if (x is null)
                    {
                        x = (y - b) / a;
                    }
                    else if (b is null)
                    {
                        b = -(a * x) + y;
                    }

                    Console.WriteLine("y = " + y);
                    Console.WriteLine("a = " + a);
                    Console.WriteLine("x = " + x);
                    Console.WriteLine("b = " + b);
                }
                else if (nulls > 1)
                    Console.WriteLine("Somente um valor pode não ser desconhecido.");
                else if (nulls == 0)
                    Console.WriteLine("Todos valores preenchidos!");
            }
            else
                Console.WriteLine("Não possível calcular, pois nenhum valor foi preenchido.");

        }
        public void SecondDegreeEquation() { }
        public void ThirdDegreeEquation() { }


        public bool AllEqual(List<decimal?> list)
        {
            var condition = list.All(item => item == list.First());
            return condition;
        }
    }
}