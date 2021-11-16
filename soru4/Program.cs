using System;

namespace soru4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin. Cümledeki toplam kelime ve harf sayısını console'a yazdırın.

            Console.WriteLine("lütfen bir cümle giriniz");
            string girilen=Console.ReadLine();
            string[] cumle=girilen.Split(" ");
            Console.WriteLine("girilen cümle {0} adet kelime icerir",cumle.Length);
            string alfabe="ABCÇDEFGĞHIİJKLMNOÖQPRSŞTUÜVXWYZabcçdefghıijklmnoöqprsştuüvwxyz";
            int counter=0;
            for (int i = 0; i < girilen.Length; i++)
            {
                for(int j=0;j<alfabe.Length;j++)
                {
                if(girilen[i]==alfabe[j])
                counter++;
                }
            
            }
            Console.WriteLine("girilen cumledeki harf sayisi {0} kadardir",counter);
        }
    }
}
