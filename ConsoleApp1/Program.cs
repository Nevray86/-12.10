using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class EmployerTime
    {
        private int[] myArray = new int[7] { 0,0,0,0,0,0,0 };
      
        public int this[int index]
        {
            set { myArray[index] = value; }
            get { return myArray[index]; }
        }
       public void Print()
        {
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine(myArray[i]);
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var BobTime = new EmployerTime();
            BobTime.Print();
            BobTime[1] = 8;
            Console.WriteLine("--------------------");
            BobTime.Print();
            Console.ReadKey();
        }
    }
}
