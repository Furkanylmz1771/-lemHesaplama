using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İşlemHesaplama
{
    class Program
    {

        static double ortalama(int v, int f, out char h)
        {
            float ort = (float)Math.Floor((v + f) / 2.0f + 0.5f);

            if (ort > 84)
            {
                h = 'A';
            }
            else if (ort > 74)
            {
                h = 'B';
            }
            else if (ort > 64)
            {
                h = 'C';
            }
            else if (ort > 54)
            {
                h = 'D';
            }
            else
            {
                h = 'F';
            }

            return (ort);

        }


        static bool kokHesapla(double a, double b, double c, out double x1, out double x2)
        {
            double d;

            d = b * b - 4 * a * c;      // diskriminant hesap

            if (d >= 0)
            {
                x1 = (-b - Math.Sqrt(d)) / (2 * a);
                x2 = (-b - Math.Sqrt(d)) / (2 * a);

                return true;
            }
            else
            {
                x1 = 0; x2 = 0;
                return false;
            }


        }


        static void Main(string[] args)
        {
            int vize, final;
            char harf;

            Console.WriteLine("Vize notunuzu girin");
            vize = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Final notunuzu girin");
            final = Convert.ToInt32(Console.ReadLine());

            double ort = ortalama(vize, final, out harf);

            Console.WriteLine("Not ortalaması :{0}", ort);
            Console.WriteLine("Harf : {0}", harf);

            Console.ReadKey();



            bool sonuc;
            double x1, x2;

            sonuc = kokHesapla(6, 4, -2, out x1, out x2);

            if (sonuc == true)
            {
                Console.WriteLine("Birinci kök x1 = {0}", x1);
                {
                    Console.WriteLine("İkinci kök x1 = {0}", x2);
                }
            }
            else Console.WriteLine("Denklemin gerçek kçkü yok");

                Console.ReadKey();
            }
        }
    }

