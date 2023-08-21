using static System.Console;
using System;
using System.Runtime.CompilerServices;

namespace Hello
{
    class Program
    {
        private string name;
        private string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        static void Main(string[] args)
        {
            Program myObj = new Program();
            myObj.Name = "Shivendra Kumar";
            Console.WriteLine(myObj.Name);
            

        }
    }
}

