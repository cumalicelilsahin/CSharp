using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            #region DoubleDeğişkeni
            //double elmaFiyat;
            //double elmaGram;
            //elmaFiyat = 1.75;
            //elmaGram = 1.245;
            //double borc = elmaGram * elmaFiyat;
            //Console.WriteLine("Elmanın Kilosu: " + elmaFiyat + " TL "+"Sizin Aldığınız: "+ elmaGram+" kilo");
            //Console.WriteLine("Borcunuz: " + borc + " TL");
            #endregion

            #region CharDeğişkeni

            //char symbol = 'a';
            //Console.WriteLine(symbol);

            #endregion

            #region VeriGirişiAlma

            //Console.WriteLine("Merhaba Dünyalı");

            //string personName, personAcmısın, personNeden;

            //Console.Write("İsmin Nedir: ");
            //personName = Console.ReadLine();

            //Console.Write("Uzun Yoldan Geldin Aç mısın: ");
            //personAcmısın = Console.ReadLine();

            //Console.Write(personName + " Nasıl Geldin Buraya: ");
            //personNeden = Console.ReadLine();

            #endregion

            #region KlavyedenSayıGirişiVeDönüşümler

            //int yas;

            //Console.Write("Kaç Yaşındasın");
            //yas = int.Parse(Console.ReadLine());
            //Console.WriteLine("5 yıl sonra " + (yas+5) + " yaşında olucaksınız");


            #endregion

            #region KlavyedenDoubleİşlemleri

            //Console.Write("Elma ağırlığı ne kadar geldi: ");
            //double elmaKilo = double.Parse(Console.ReadLine());
            //Console.WriteLine("Elmanın kg fiyatı ne kadar: ");
            //double elmaFiyat = double.Parse(Console.ReadLine());

            //double borc;
            //Console.WriteLine("Toplam Borç: " + (borc = elmaKilo * elmaFiyat) + " TL ") ;

            #endregion

            #region KlavyedenCharGirişi

            //char basHarf;
            //Console.Write("İsminizin ilk harfini yazınız: ");
            //basHarf = char.Parse(Console.ReadLine());

            //Console.WriteLine("İsminizin baş harfi: " + basHarf);

            #endregion


            Console.Read();

        }
    }
}
