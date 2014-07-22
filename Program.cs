using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1_1
{
    class Program
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Введите текст,например : 1*2*3*6");
            String text = Convert.ToString(Console.ReadLine());
            Char[] n = text.ToArray();

            String[] p = new String[n.Length];
            for (Int32 i = 0; i < n.Length; i++)
            {
                p[i] = Convert.ToString(n[i]);
            }
            Int32 perv;
            Int32 vtoroy;
            Int32 proiz = 0;
            String um = "*";

            for (Int32 i = 0; i < p.Length - 1; i++)
            {
                if (p[i].Equals(um))
                {
                    perv = Convert.ToInt32(p[i - 1]);
                    vtoroy = Convert.ToInt32(p[i + 1]);
                    proiz = perv * vtoroy;
                    p[i + 1] = Convert.ToString(proiz);
                }
            }


            Console.Write("Значение произведения = ");
            Console.Write(proiz);
            Console.ReadLine();
        }
    }
}
