using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Engin";
            musteri1.Soyadi = "Demiroğ";
            musteri1.TcNo = "1234985857";

            //Gerçek Müşteri - Tüzel Müşteri (bunlar birbirinin yerine asla kullanılamaz)
            //SOLID (Yazılım Geliştirme Prensipleri)

            //Kodlama.io

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.VergiNo = "74937262783";
            musteri2.MusteriNo = "68463";
            musteri2.SirketAdi = "Kodlama.io";


            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(musteri1);
            customerManager.Add(musteri2);



        }
    }
}
