// 1 Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n).
// Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin.
// Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın.
using System;

namespace odev_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("lütfen bir sayı giriniz");
            n=Convert.ToInt16(Console.ReadLine());
            int[] girilen=new int [n];
            Console.WriteLine("lütfen {0} adet sayi giriniz",n);
            for(int i=0;i<n;i++)
            {
            girilen[i]=Convert.ToInt16(Console.ReadLine());
            }

            Console.WriteLine("girilen sayılardan çift olanlar asagidadir");
            for (int i = 0; i < n; i++)
            {
                if(girilen[i]%2==0)
                Console.WriteLine(girilen[i].ciftmi());
            }
///////////////////// 1. Sorunun Sonu ////////////////////////////////////////
           
           
           



        }
    }
    public static class Extensions
    {
    public static int ciftmi(this int a)
    {
        if(a%2==0)
        return a;
        else return 0;
    }
    }

}
