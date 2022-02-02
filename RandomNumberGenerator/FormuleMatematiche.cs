using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomNumberGenerator
{
    public class FormuleMatematiche
    {
        public double rnd(int a, int b)
        {
            System.Random r = new System.Random();
            return a + r.NextDouble() * (b - a);
        }
    }
}
