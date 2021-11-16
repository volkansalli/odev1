using System;

namespace soru3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n). 
            //Sonrasında kullanıcıdan n adet kelime girmesi isteyin. 
            //Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın
            Console.WriteLine("pozitif bir sayi girelim");
            int n=Int32.Parse(Console.ReadLine());
            Console.WriteLine("{0} adet kelime girelim",n);
            string[] girilen=new string[n];
            for(int i=0;i<n;i++)
            {
                girilen[i]=Console.ReadLine();
            }
            Console.WriteLine("girilen kelimeler sondan başa dogru");
            for(int i=n-1;i>=0;i--)
            {
                Console.WriteLine(girilen[i]);
            }

        }
    }
}
