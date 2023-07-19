using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace StackOdev.Properties
{
    internal class Yigin
    {
        int index;
        int boyut;
        int[] veriler;
        int Veriler_Length;
        int[] cıkanVeriler;
        int[] AraElemanlar;
      

        public Yigin(int eleman_sayisi)
        {
            this.boyut = eleman_sayisi;
            this.index = -1;
            Veriler_Length = eleman_sayisi;
            veriler = new int[eleman_sayisi];
            cıkanVeriler= new int[eleman_sayisi];
            AraElemanlar= new int[eleman_sayisi];   

        }

        public void push(int data)
        {
            // yığın doluysa
            if(this.index==this.boyut-1)
            {
                Console.WriteLine("Stack Dolu");
            }

            else
            {
                this.index++;
                veriler[this.index] = data; 
            }
        }

        public void pop(int cıkarılacak_data) 
        {
            // stack boşsa
            if (this.index == -1)
            {
                Console.WriteLine("Stack Boş");
              
            }

            else
            {
                int i = -1;
                while (cıkarılacak_data != veriler[this.index])
                {
                    i++;
                    cıkanVeriler[i] = peek();

                    this.index--;

                    if (this.index == -1)
                    {
                        Console.WriteLine("Aradığınız eleman yığında bulunamadı.");
                        break;
                    }
                }
                if (this.index != -1)
                {
                    this.index--;
                }


                for (int j = i; j > -1; j--)
                {
                    push(cıkanVeriler[j]);
                }

            }
        }
        
       

        public int peek()
        {
            return veriler[this.index]; 
        }


        public void Degistir()
        {

            if (this.index == (boyut - 2))
            {
                Veriler_Length--;

            }

            int sonEleman=peek();
            this.index--;
            int a = 0;

           


            for ( a = 0; a<((Veriler_Length)-2); a++)
            {
                AraElemanlar[a]=peek();
                this.index--;
            }

            int ilkEleman=peek();
            this.index--;


            push(sonEleman);
            for (int b = (a-1); b > -1; b--)
            {
                push(AraElemanlar[b]);
            }
            push(ilkEleman);


        }

        public void print()
        {
            if (this.index == -1)
            {
                Console.WriteLine("Stack Boş");
            }
            else
            {
                for (int i = this.index; i > -1; i--)
                {
                    Console.WriteLine(this.veriler[i]);
                }
            }

        }

    }
}
