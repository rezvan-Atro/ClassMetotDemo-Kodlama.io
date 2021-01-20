using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
           
            MusteriManager musteri = new MusteriManager();
            string a;
            int n;
            b:
            Console.WriteLine("Lütfen işlem seçiniz.");
            Console.WriteLine("1.Müşteri Kayıt \n 2.Müşteri Listeleme \n 3. Müşteri Silme");
            a = Console.ReadLine();

            if(a=="1")
            {
                Console.WriteLine("Müşteri kayıt sayfasına yönlendiriliyorsunuz...");
                Console.WriteLine("---------------------");
                Console.WriteLine("Eklemek istediğiniz kişi sayısını giriniz.");
                 n = Convert.ToInt32(Console.ReadLine());
                  musteri.Ekle(n);
                
            }
            else if(a=="2")
            {
                Console.WriteLine("Müşteri listeleme sayfasına yönlendiriliyorsunuz...");
                Console.WriteLine("---------------------");
                musteri.Listele();
            }
            else if(a=="3")
            {
                Console.WriteLine("Müşteri silme sayfasına yönlendiriliyorsunuz...");
                Console.WriteLine("---------------------");
                Console.WriteLine("Silmek istediğiniz müşterinin kimlik numarasını giriniz : ");
                musteri.Sil(Convert.ToInt32(Console.ReadLine()));
            }
            Console.WriteLine("\n 1) Çıkış 2)İşleme devam");
            int secim = Convert.ToInt32(Console.ReadLine());
            if(secim==2)
            {
                goto b;
            }
       
        }
    }
}
