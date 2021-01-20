using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager : Musteri
    {
        Musteri musteri = new Musteri();
        int a = 0;
        Musteri[] dizi=new Musteri[10];
        public void Ekle(int sayi)
        {
            for (int i = 0; i < sayi; i++)
            {
                a = sayi;
                Console.WriteLine("Müşteri adını giriniz : ");
                musteri.Adi = Console.ReadLine();
                Console.WriteLine("Müşterinin soyadını giriniz : ");
                musteri.Soyadi = Console.ReadLine();
                Console.WriteLine("Müşterinin kimlik numarasını giriniz : ");
                musteri.TC = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Müşterinin yaşını giriniz : ");
                musteri.Yasi = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Müşterinin telefon numarasını giriniz : ");
               musteri.TelefonNumarasi = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Müşteri Ekleme İşlemi Tamamlanmıştır... \n");
                dizi[i] = musteri;
            }

        }
        public void Listele()
        {
            for (int j=0;j<a;j++)
            {
                Console.WriteLine("Müşteri Numarası : " + dizi[j].Id);
                Console.WriteLine("Müşteri Adı ve Soyadı : " + dizi[j].Adi + " " + dizi[j].Soyadi);
                Console.WriteLine("Müşteri Kimlik Numarası : " + dizi[j].TC);
                Console.WriteLine("Müşteri Yaşı : " + dizi[j].Yasi);
                Console.WriteLine("Müşterinin Telefon Numarası : " + dizi[j].TelefonNumarasi);

            }
        }
        public void Sil(int Kimlik)
        {
            for (int i = 0; i <a; i++)
            {

                if(Kimlik==dizi[i].TC)
                {
                    Console.WriteLine("Müşteri bilgileri silinmiştir... \n");
                }
              
            }

        }
    }
}
