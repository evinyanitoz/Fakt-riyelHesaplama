namespace FaktöriyelHesaplama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("KAÇ FAKTÖRİYEL");
            int sayi = Convert.ToInt32(Console.ReadLine());
            int toplam = 1;

            for (int i = 1; i <= sayi; i++)
            {

                toplam *= i;  
            }

            Console.WriteLine(toplam);

        }

    }
}
