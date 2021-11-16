using System;

namespace soru2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m). 
            //Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. 
            //Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.
            Console.WriteLine("lütfen 2 adet pozitif tam sayi giriniz");
            int n=Int32.Parse(Console.ReadLine());
            int m=Int32.Parse(Console.ReadLine());
            Console.WriteLine("lütfen {0} adet tam sayi giriniz",n);
            int[] girilen=new int[n];
            for (int i = 0; i < n; i++)
            {
                
            girilen[i]=Int32.Parse(Console.ReadLine());
                
            }
            Console.WriteLine("girilen {0} adet sayidan, {1} ye esit olan veya tam bolunenler asagidadir",n,m);
            for (int i = 0; i < n; i++)
            {
            if(girilen[i]%m==0 || girilen[i]==m)    
            Console.WriteLine(girilen[i]);
                
            }
        }
    }
}
