using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrayexlistex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList hardwareList = new ArrayList();
            hardwareList.Add("CD");
            hardwareList.Add("Printer");
            hardwareList.Add("KeyBoard");
            hardwareList.Add("Mouse");
            hardwareList.Add("Network Card");
            Console.WriteLine("Intial Hardware List");

            for (int i = 0; i < hardwareList.Count; i++)
            {
                Console.WriteLine(hardwareList[i]);
            }
            Console.WriteLine("Enter item to search & update");
            string searchItem = Console.ReadLine();
            int index = hardwareList.IndexOf(searchItem);
            if (index == -1)
            {
                Console.WriteLine($"No Such item {searchItem} exist in hardware list");
            }
            else
            {
                Console.WriteLine("Enter update item");
                hardwareList[index] = Console.ReadLine();
                Console.WriteLine("Update Hardware List is as follows!!!");
                for (int i = 0; i < hardwareList.Count; i++)
                {
                    Console.WriteLine(hardwareList[i]);
                }
            }
        }
    }
}
     