using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadacaha2
{
    class Program
    {
        static void Main(string[] args)
        {
            int status = 0;
            string rad= Console.ReadLine();
            foreach(var s in rad)
            {
                if (s>='0' && s<='9')
                {
                    if (status!=0&&status!=1)
                    {
                        status = 4;
                        break;
                    }
                    status = 1;
                }
                else if(s >= 'a' && s <= 'z')
                {
                    if (status != 0 && status != 2)
                    {
                        status = 4;
                        break;
                    }
                    status = 2;
                }
                else
                {
                    if (status != 0 && status != 3)
                    {
                        status = 4;
                        break;
                    }
                    status = 3;
                }
            }
            switch (status)
            {
                case 1:
                    Console.WriteLine("Chislo");
                    break;
                case 2:
                    Console.WriteLine("bykvu");
                    break;
                case 3:
                    Console.WriteLine("simvolu");
                    break;
                case 4:
                    Console.WriteLine("figna");
                    break;
            }
            Console.ReadKey();
        }
    }
}
