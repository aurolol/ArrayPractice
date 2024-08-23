using System;

class Program
{
    public static void Main(string[] args)
    {
        int[] tamSayi = new int[10];

        for (int i = 0; i < tamSayi.Length; i++)  // Bu diziyi for döngüsü ile dolduruyoruz.
        {
            tamSayi[i] = (i +1) * 2;
        }

        foreach (int i in tamSayi)          // Foreach döngüsü ile ekrana yazdırıyoruz.
        {
            Console.WriteLine(i);
        }

        Console.Write("Lütfen 11. elamanı girer misiniz?");   
        int girilenDeger = Convert.ToInt32(Console.ReadLine());  // Kullanıcıdan 11. değeri alıyoruz

        Array.Resize(ref tamSayi, tamSayi.Length+1);
        tamSayi[tamSayi.Length - 1 ] = girilenDeger;

        

        Array.Sort(tamSayi);    // Sayılar dizisini küçükten büyüğe sıralıyoruz.
        Array.Reverse(tamSayi);  // Küçükten büyüğe sıraladığımız sayıları ters çevirip büyükten küçüğe sıralıyoruz.

        for (int i = 0; i< tamSayi.Length; i++)
        {

            Console.WriteLine(tamSayi[i]); 
        }
    }
}
  