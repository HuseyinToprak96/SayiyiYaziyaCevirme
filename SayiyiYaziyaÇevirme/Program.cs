using System;

namespace SayiyiYaziyaÇevirme
{
    class Program
    {
        public static string[] birlerDizisi = {"", "bir","iki","üç","dört","beş","altı","yedi","sekiz","dokuz"};
        public static string[] onlarDizisi = { "","on","yirmi","otuz","kırk","elli","altmış","yetmiş","seksen","doksan" };
        public static string[] degerler = { "","bin","milyon","milyar" };

        static void Main(string[] args)
        {
            while (true) {
            Console.Write("Çevrilcek Sayıyı giriniz:");
            int sayi=Convert.ToInt32(Console.ReadLine());
            string sayiString = sayi.ToString();
            int uzunluk = sayi.ToString().Length;
            int sayac = uzunluk;
            int x =-1;
                if (uzunluk % 3 ==0 )
                    x = 2;
                if (uzunluk % 3 == 1)
                    x = 0;
                if (uzunluk % 3 == 2)
                    x = 1;
            string yazi = "";
            for (int i = 0; i <sayac; i++)
            {
                int maxBasamak = uzunluk % 3;
                int maxIndis = uzunluk / 3;
                    if(int.Parse(sayiString[i].ToString())!=0)
                if (maxBasamak == 0)
                yazi+=Yuzler(int.Parse(sayiString[i].ToString()));
                if (maxBasamak == 2)
                yazi += Onlar(int.Parse(sayiString[i].ToString()));
                if(maxBasamak==1)
                yazi += Birler(int.Parse(sayiString[i].ToString()));
                uzunluk--;
                    if (int.Parse(sayiString[i].ToString()) == 0)
                        maxIndis = 0;
                if ( i%3== x)
                    yazi += degerler[maxIndis]+" ";
            }
            Console.WriteLine(yazi);
            }
        }
        public static string Birler(int sayi)
        {
            return birlerDizisi[sayi]+" ";
        }
        public static string Onlar(int sayi)
        {
            return onlarDizisi[sayi]+" ";
        }
        public static string Yuzler(int sayi)
        {
            string deger = "";
            if (sayi > 1)
                deger = Birler(sayi);
            return deger+" yüz ";
        }
    }
}
