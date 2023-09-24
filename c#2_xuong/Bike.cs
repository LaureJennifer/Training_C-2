using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_2_xuong
{
    internal class Bike
    {
        private int ID;
        private string Name;
        private string HSX;
        public Bike()
        {
            
        }
        public Bike(int iD, string name, string hSX)
        {
            ID1 = iD;
            Name1 = name;
            HSX1 = hSX;
        }

        public int ID1 { get => ID; set => ID = value; }
        public string Name1 { get => Name; set => Name = value; }
        public string HSX1 { get => HSX; set => HSX = value; }

        public void inThongTin()
        {
            Console.WriteLine($"{ID1} | {Name1} | {HSX1}");
        }
    }
}
