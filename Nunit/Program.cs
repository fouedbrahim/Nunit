using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nunit
{
    public class Program
    {
        
         static void Main() { } 
        public int Add(int a, int b)
        {
            int x = a + b; return x;
        }
        public int Subtract(int a, int b)
        {
            int x = a - b; return x;
        }
        public int Devide(int a, int b)
        {
            int x = a / b; return x;
        }
        public double SQRT(int a)
        {
            return Math.Sqrt(a);
        }
    }
    }
