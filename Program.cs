using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Tests
{
    class Program
    {
        static void Main(string[] args)
        {
            Test t = new Test();        
        }
    }

    class Test
    {
        readonly int i = 10;
        readonly List<int> intList = new List<int>() { 10,20,30};

        public Test()
        {
            intList = new List<int>() {30,40,50};
        }

        private void TestMethod()
        {
            //intList = new List<int>();
        }

    }
}
