using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hometask10
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("\n///////////Test Dynamic Array////////////////////////////////\n");

            var NewTestDynamicArray = new TestDynamicArray();
            NewTestDynamicArray.TestTheDynamicArray();
            
            Console.WriteLine("\n///////////Test Queu////////////////////////////////\n");
            
            var newTestQueue = new TestDynamicQueue();
            newTestQueue.TestTheDynamicQueue();
            
            Console.WriteLine("\n///////////Test Stack////////////////////////////////\n");
            
            var newTestStack = new TestDynamicStack();
            newTestStack.TestTheDynamicStack();
            
            Console.ReadLine();
        }
    }
}
