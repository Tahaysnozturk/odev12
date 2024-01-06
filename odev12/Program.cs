using System;

namespace or202
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] B = new int[5];
            int a = 0, say = 0, toplam = 0;

            foreach (int al in B)
            {
                Console.Write(a + ". Elemanı Gir: ");
                B[a] = Int32.Parse(Console.ReadLine());

                if (B[a] % 10 == 0)
                {
                    say++;
                    toplam += B[a]; // Sadece son rakamı sıfır olan sayıların toplamını hesapla
                }

                a++;
            }

            double ortalama = say > 0 ? (double)toplam / say : 0; // Sıfır bölme hatasını engellemek için kontrol

            Console.WriteLine("Son Rakamı Sıfır Olan Sayı Adedi: " + say);
            Console.WriteLine("Son Rakamı Sıfır Olan Sayıların Toplamı: " + toplam);
            Console.WriteLine("Son Rakamı Sıfır Olan Sayıların Ortalaması: " + ortalama);

            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
}
