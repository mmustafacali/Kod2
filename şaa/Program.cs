using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace şaa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write(" Yaşınızı giriniz: ");
            var k = Convert.ToInt32(Console.ReadLine());
            var y = 18;
            var l = 500;
            if (k >= 18) 
            {
                

                Console.Write("Diploma notunuzu giriniz: ");
                var x = Convert.ToInt32(Console.ReadLine());

                if (x>70)
                {

                    Console.WriteLine("başarılı bir şekilde sınava girebilirisiniz");
                    Console.Write("Sınavdan aldığınız notu girniz:");
                    var u = Convert.ToInt32(Console.ReadLine());
                    if (u<=500)
                    {
                        Console.WriteLine($"{u} sınav notunuz ile başarılı bir  yer tercih edebilirsiniz");
                    }
                    else
                    {
                        Console.WriteLine("sınav puanınız yetersiz.");
                    }
                }
                else
                {
                    Console.WriteLine("Sınava girmenize için ortalama notunuz yetersiz");
                }
            }
            else
            {
                Console.WriteLine($"{k}={y-k} sınava girmeniz için {y-k} yılınzı kaldı. ");
            }
            Console.ReadKey();

        }
    }
}
