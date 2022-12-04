using System;

namespace metotOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            string sayi="999";
            bool sonuc=int.TryParse(sayi,out int OutSayi);

            if (sonuc)
        {
            Console.WriteLine("Başarılı");
            Console.WriteLine(OutSayi);
        }

            else
                Console.WriteLine("Başarısız");  

            Metotlar instance =new Metotlar();
            instance.Topla(4,5,out int toplamsonucu);
            Console.WriteLine(toplamsonucu);
           
            int ifade =999;
            instance.EkranaYazdırr(Convert.ToString(ifade));
            instance.EkranaYazdırr(ifade);

        }
    }
    class Metotlar
    {        public void Topla(int a,int b, out int toplam)
        {
            toplam=a+b;
        }
        public void EkranaYazdırr(string veri2)
        {
            Console.WriteLine(veri2);
        }
        public void EkranaYazdırr(int veri2)
        {
            Console.WriteLine(veri2);
        }
        

    }        
    
}