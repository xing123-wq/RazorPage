using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    internal class Teacher
    {
        static int score = 100;
        public string name;
        internal static void Teach(string name)
        {
         
            //Console.WriteLine($"{this.name}老师上{name}的课");
        }
        public Teacher(string name)
        {
            this.name = name;
        }
        public Teacher()
        {

        }
        //public string Name { get; set; }
    }
}
