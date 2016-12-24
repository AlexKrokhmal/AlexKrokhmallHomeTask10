using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hometask10
{
    public class TestDynamicArray
    {
        public void TestTheDynamicArray()
        {
            var NewDynamicArray = new DynamicArray<int>(3, 13);
            Console.WriteLine("Capasity = {0}", NewDynamicArray.Capacity());
            Console.WriteLine("Size = {0}", NewDynamicArray.Size);
            NewDynamicArray.Print();
            NewDynamicArray.Add(1);
            NewDynamicArray.Print();
            NewDynamicArray.Add(2);
            NewDynamicArray.Print();
            Console.WriteLine("Capasity = {0}", NewDynamicArray.Capacity());
            Console.WriteLine("Size = {0}", NewDynamicArray.Size);
            NewDynamicArray.Add(3);
            NewDynamicArray.Print();
            NewDynamicArray.Add(4);
            NewDynamicArray.Print();
            NewDynamicArray.Insert(0, 7);
            NewDynamicArray.Print();
            Console.WriteLine("Capasity = {0}", NewDynamicArray.Capacity());
            Console.WriteLine("Size = {0}", NewDynamicArray.Size);
            Console.WriteLine(NewDynamicArray.Get(0));
            Console.WriteLine(NewDynamicArray.Get(1));
            Console.WriteLine(NewDynamicArray.Get(9));
            NewDynamicArray.Print();
            Console.WriteLine("Capasity = {0}", NewDynamicArray.Capacity());
            Console.WriteLine("Size = {0}", NewDynamicArray.Size);
            NewDynamicArray.Add(5);
            NewDynamicArray.Insert(0, 5);
            NewDynamicArray.Print();
            NewDynamicArray.Add(6);
            NewDynamicArray.Print();
            NewDynamicArray.Add(7);
            NewDynamicArray.Print();
            NewDynamicArray.Insert(0, 2);
            NewDynamicArray.Print();
            Console.WriteLine("Capasity = {0}", NewDynamicArray.Capacity());
            Console.WriteLine("Size = {0}", NewDynamicArray.Size);
            NewDynamicArray.Remove(10);
            NewDynamicArray.Print();
            Console.WriteLine("Capasity = {0}", NewDynamicArray.Capacity());
            Console.WriteLine("Size = {0}", NewDynamicArray.Size);
            NewDynamicArray.Remove(9);
            NewDynamicArray.Print();
            Console.WriteLine("Capasity = {0}", NewDynamicArray.Capacity());
            Console.WriteLine("Size = {0}", NewDynamicArray.Size);
            NewDynamicArray.Remove(0);
            NewDynamicArray.Print();
            NewDynamicArray.Remove(2);
            NewDynamicArray.Print();
            NewDynamicArray.Remove(2);
            NewDynamicArray.Print();
            Console.WriteLine("Capasity = {0}", NewDynamicArray.Capacity());
            Console.WriteLine("Size = {0}", NewDynamicArray.Size);
            NewDynamicArray.Remove(2);
            NewDynamicArray.Print();
            Console.WriteLine("Capasity = {0}", NewDynamicArray.Capacity());
            Console.WriteLine("Size = {0}", NewDynamicArray.Size);
            NewDynamicArray.Remove(2);
            NewDynamicArray.Print();
            Console.WriteLine("Capasity = {0}", NewDynamicArray.Capacity());
            Console.WriteLine("Size = {0}", NewDynamicArray.Size);
            NewDynamicArray.Insert(0, 2);
            NewDynamicArray.Print();
            NewDynamicArray.Add(9);
            NewDynamicArray.Print();
            NewDynamicArray.Insert(0, 2);
            NewDynamicArray.Print();
            NewDynamicArray.Add(8);
            NewDynamicArray.Print();
            NewDynamicArray.Remove(2);
            NewDynamicArray.Print();
            Console.WriteLine("Capasity = {0}", NewDynamicArray.Capacity());
            Console.WriteLine("Size = {0}", NewDynamicArray.Size);
            NewDynamicArray.Remove(2);
            NewDynamicArray.Print();
            Console.WriteLine("Capasity = {0}", NewDynamicArray.Capacity());
            Console.WriteLine("Size = {0}", NewDynamicArray.Size);

            NewDynamicArray.Add(-1);
            NewDynamicArray.Print();
            Console.WriteLine("Capasity = {0}", NewDynamicArray.Capacity());
            Console.WriteLine("Size = {0}", NewDynamicArray.Size);
            NewDynamicArray.Add(-1);
            NewDynamicArray.Print();
            Console.WriteLine("Capasity = {0}", NewDynamicArray.Capacity());
            Console.WriteLine("Size = {0}", NewDynamicArray.Size);
            NewDynamicArray.Add(-1);
            NewDynamicArray.Print();
            Console.WriteLine("Capasity = {0}", NewDynamicArray.Capacity());
            Console.WriteLine("Size = {0}", NewDynamicArray.Size);
            NewDynamicArray.Add(-1);
            NewDynamicArray.Print();
            Console.WriteLine("Capasity = {0}", NewDynamicArray.Capacity());
            Console.WriteLine("Size = {0}", NewDynamicArray.Size);
            NewDynamicArray.Add(-1);
            NewDynamicArray.Print();
            Console.WriteLine("Capasity = {0}", NewDynamicArray.Capacity());
            Console.WriteLine("Size = {0}", NewDynamicArray.Size);
            NewDynamicArray.Add(-1);
            NewDynamicArray.Print();
            Console.WriteLine("Capasity = {0}", NewDynamicArray.Capacity());
            Console.WriteLine("Size = {0}", NewDynamicArray.Size);

            NewDynamicArray.Add(-1);
            NewDynamicArray.Print();
            Console.WriteLine("Capasity = {0}", NewDynamicArray.Capacity());
            Console.WriteLine("Size = {0}", NewDynamicArray.Size);

            NewDynamicArray.Add(-1);
            NewDynamicArray.Print();
            Console.WriteLine("Capasity = {0}", NewDynamicArray.Capacity());
            Console.WriteLine("Size = {0}", NewDynamicArray.Size);

            NewDynamicArray.Remove(2);
            NewDynamicArray.Print();
            Console.WriteLine("Capasity = {0}", NewDynamicArray.Capacity());
            Console.WriteLine("Size = {0}", NewDynamicArray.Size);

            NewDynamicArray.Insert(-2, 2);
            NewDynamicArray.Print();
            Console.WriteLine("Capasity = {0}", NewDynamicArray.Capacity());
            Console.WriteLine("Size = {0}", NewDynamicArray.Size);

            NewDynamicArray.Insert(-2, 15);
            NewDynamicArray.Print();
            Console.WriteLine("Capasity = {0}", NewDynamicArray.Capacity());
            Console.WriteLine("Size = {0}", NewDynamicArray.Size);

            NewDynamicArray.Insert(-2, 9);
            NewDynamicArray.Print();
            Console.WriteLine("Capasity = {0}", NewDynamicArray.Capacity());
            Console.WriteLine("Size = {0}", NewDynamicArray.Size);
            
           
            




        }
    }
}
