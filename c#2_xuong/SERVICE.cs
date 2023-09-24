using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_2_xuong
{
    internal class SERVICE
    {
        List<Bike> bikeList = new List<Bike>();
       
        internal void Dele()
        {
            Console.WriteLine("Nhập ID muốn xóa:");
            int IDc=Convert.ToInt32(Console.ReadLine());
            int x = bikeList.FindIndex(b => b.ID1 == IDc);
            bikeList.RemoveAt(x);
            //bikeList.RemoveAll(x => x.ID1 == IDc);
        }

        internal void Filee()
        {
            
            string path = @"C:\Users\GIGABYTE\Desktop\Xuonglv3\c#2_xuong\c#2_xuong\Bikee.txt";
            
            File.WriteAllText(path,"");
            foreach (Bike bike in bikeList)
            {
                   string id = bike.ID1.ToString();
                   string str = id + " | " + bike.Name1 + " | " + bike.HSX1 + "\n";
                   File.AppendAllText(path,str);
            }
            
            var fileRead=File.ReadAllLines(path);
            foreach (var line in fileRead) 
            {
                Console.WriteLine(line);
            }
            
        }
        internal void Inp()
        {
            string key;
            do
            {
                Bike bike = new Bike();

                bike.ID1 = GenerateID(1); // truyền step=1

                Console.WriteLine("Nhập Tên:");
                bike.Name1 = Console.ReadLine();

                Console.WriteLine("Nhập HSX:");
                bike.HSX1 = Console.ReadLine();

                if (checkID(bike.ID1))
                    bikeList.Add(bike);
                else Console.WriteLine("Đã có đối tượng mang ID này trong list");

                Console.WriteLine("Tiếp hay k?(y/n)");
                key = Console.ReadLine();
            
            }while (key.Equals("y"));
           }

        internal void Outp()
        {
            foreach (Bike bike in bikeList)
            {
                bike.inThongTin();
            }
            
        }
        private int GenerateID(int step)
        {
            if (bikeList.Count == 0)
                return step;
            else
                return bikeList[bikeList.Count-1].ID1 + step;
        }
        private bool checkID(int idforcheck)
        {
                int a = bikeList.FindIndex(x => x.ID1 == idforcheck);
                if (a == -1)
                    return true;
                else return false;     
           
        }
    }
}
