using StackOdev.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackOdev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Yığının eleman sayısını giriniz: ");
            int elemanSayisi=Convert.ToInt32(Console.ReadLine());
            Yigin yiginOrnegi = new Yigin(elemanSayisi);
            for(int i= 0; i<elemanSayisi; i++)
            {
                Console.WriteLine("Sayı giriniz: ");
                int sayi=Convert.ToInt32(Console.ReadLine());
                yiginOrnegi.push(sayi);
            }

             Console.WriteLine("-----");
             yiginOrnegi.print();

            Console.WriteLine("-----");
            Console.WriteLine("Yığından çıkarmak istediğiniz sayıyı giriniz: ");
            int cıkarılacakdata = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("-----");
            yiginOrnegi.pop(cıkarılacakdata);
            yiginOrnegi.print();
            Console.WriteLine("-----");
            int a=Convert.ToInt32(Console.ReadLine());
            yiginOrnegi.pop(a);
            //Console.WriteLine("Yığının ilk elamanı ile son elemanının yer değiştirmiş hali: ");
           // yiginOrnegi.Degistir();
            yiginOrnegi.print();



            Console.ReadLine(); 
        }
    }
}
