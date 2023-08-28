using System;

namespace BankaHesabiUygulamasi
{
    class BankaHesabi
    {
        private string hesapSahibi;
        private double bakiye;

        public BankaHesabi(string sahipAdi, double baslangicBakiye)
        {
            hesapSahibi = sahipAdi;
            bakiye = baslangicBakiye;
        }

        public void ParaYatir(double miktar)
        {
            if (miktar > 0)
                bakiye += miktar;
        }

        public void ParaCek(double miktar)
        {
            if (miktar > 0)
                bakiye -= miktar;
        }

        public double BakiyeSorgula()
        {
            return bakiye;
        }

        public string HesapSahibi
        {
            get { return hesapSahibi; }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hesap sahibinin adını girin: ");
            string hesapSahibiAdi = Console.ReadLine();

            Console.Write("Başlangıç bakiyesini girin: ");
            double baslangicBakiye;
            while (!double.TryParse(Console.ReadLine(), out baslangicBakiye))
            {
                Console.WriteLine("Geçersiz giriş! Lütfen bir sayı girin.");
            }

            BankaHesabi hesap = new BankaHesabi(hesapSahibiAdi, baslangicBakiye);

            Console.WriteLine($"Hesap Sahibi: {hesap.HesapSahibi}");
            Console.WriteLine($"Başlangıç Bakiyesi: {hesap.BakiyeSorgula()}");

            double yatirilanMiktar;
            do
            {
                Console.Write("Yatırmak istediğiniz miktarı girin: ");
            } while (!double.TryParse(Console.ReadLine(), out yatirilanMiktar));
            hesap.ParaYatir(yatirilanMiktar);
            Console.WriteLine($"Yeni Bakiye: {hesap.BakiyeSorgula()}");

            double cekilenMiktar;
            do
            {
                Console.Write("Çekmek istediğiniz miktarı girin: ");
            } while (!double.TryParse(Console.ReadLine(), out cekilenMiktar));
            hesap.ParaCek(cekilenMiktar);
            Console.WriteLine($"Yeni Bakiye: {hesap.BakiyeSorgula()}");
        }
    }
}
