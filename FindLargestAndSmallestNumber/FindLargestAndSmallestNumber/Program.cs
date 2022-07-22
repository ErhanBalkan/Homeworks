internal class Program
{
    static void EnBuyukSayiyiBul(int[] sayilar)
    {
        int enBuyukSayi = 0;
        
        for (int i = 0; i < sayilar.Length; i++)
        {
            if (sayilar[i] > enBuyukSayi)
            {
                enBuyukSayi = sayilar[i];
            }
        }
        Console.WriteLine("En büyük sayı: " + enBuyukSayi.ToString());

        Console.WriteLine("En küçük sayı: " + enKucukSayi.ToString());
    }
    static void Main(string[] args)
    {
        int[] sayilar = new int[5];
        sayilar[0] = 30;
        sayilar[1] = 20;
        sayilar[2] = 120;
        sayilar[3] = 50;
        sayilar[4] = 60;

        EnBuyukSayiyiBul(sayilar);
    }
}
