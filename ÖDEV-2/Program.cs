namespace ÖDEV_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("HOW MAN NUMBERS YOU WANT TO SORT");
            byte numbers = byte.Parse(Console.ReadLine());

            Console.WriteLine("ENTER STARTİNG NUMBER");
            byte start = byte.Parse(Console.ReadLine());

            Console.WriteLine("enter ended number ");
            byte end = byte.Parse(Console.ReadLine());

            Random rnd = new Random();

            byte[] dizi_ismi = new byte[numbers];

            for (int i = 0; i < dizi_ismi.Length; i++)
            {
                dizi_ismi[i] = rnd.Next(start, end);

            }
            Array.Sort(dizi_ismi);
            for (int i = 0; i < dizi_ismi.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }

            Console.Write("Başlangıç sayısını girin: ");
            int baslangic = Convert.ToInt32(Console.ReadLine());

            Console.Write("Bitiş sayısını girin: ");
            int bitis = Convert.ToInt32(Console.ReadLine());

            Console.Write("Kaç adet sayı istiyorsunuz?: ");
            int adet = Convert.ToInt32(Console.ReadLine());

            if (baslangic >= bitis)
            {
                Console.WriteLine("Hata: Başlangıç sayısı, bitiş sayısından küçük olmalıdır.");
                return;
            }

            Random random = new Random();
            int[] randomSayilar = new int[adet];

            for (int i = 0; i < adet;)
            {
                int randomSayi = random.Next(baslangic, bitis + 1); // Belirtilen aralıkta random sayı üret
                int j;

                for (j = 0; j < i; j++)
                {
                    if (randomSayilar[j] == randomSayi)
                    {
                        break; // Tekrar eden bir sayı bulunduğunda döngüden çık
                    }
                }

                if (j == i) // Eğer döngü tamamlandıysa (j, i'ye eşitse), tekrar eden bir sayı yok demektir
                {
                    randomSayilar[i] = randomSayi;
                    i++; // Sadece benzersiz sayı eklediğimizde i değerini arttır
                }
            }

            Array.Sort(randomSayilar); // Sayıları sırala

            Console.WriteLine("\nÜretilen Random Sayılar (Sıralı):");
            for (int i = 0; i < adet; i++)
            {
                Console.Write($"{randomSayilar[i]} ");
            }
            
        }
    }
}
