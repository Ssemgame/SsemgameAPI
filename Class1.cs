using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SsemgameAPI
{
    public class Class1
    {
        public void send(string str)
        {
            Console.WriteLine(str);
        }
        public void write(string str)
        {
            Console.WriteLine(str);
        }
        public void convertInt(string cislo, int output)
        {
            if (int.TryParse(cislo, out output))
            {
            } else
            {
                Console.WriteLine("Something went wrong");
            }
        }
        public void getPaste(string output)
        {
            output = Console.ReadLine();
        }
    }
}
