using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Double Değişkenler

            // double değişkenleri ondalıklı sayılar için kullanılır.

            //double number;
            //number = 4.85;
            //Console.WriteLine(number);

            //Console.WriteLine("***** Fiyat Listesi *****");
            //Console.WriteLine();

            //double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;
            //applePrice = 14.45;
            //orangePrice = 20.95;
            //strawberryPrice = 45;
            //potatoPrice = 9.74;
            //tomatoPrice = 6.88;

            //Console.WriteLine("---- Elma Birim Fiyatı: " + applePrice + " TL ");
            //Console.WriteLine("---- Portakal Birim Fiyatı: " + orangePrice + " TL ");
            //Console.WriteLine("---- Çilek Birim Fiyatı: " + strawberryPrice + " TL ");
            //Console.WriteLine("---- Patates Birim Fiyatı: " + potatoPrice + " TL ");
            //Console.WriteLine("---- Domates Birim Fiyatı: " + tomatoPrice + " TL ");

            //double appleGram, orangeGram, strawberryGram, potatoGram, tomatoGram;

            //appleGram = 1.245;
            //orangeGram = 2.650;
            //strawberryGram = 0.750;
            //potatoGram = 4.859;
            //tomatoGram = 3.745;

            //Console.WriteLine();
            //Console.WriteLine();

            //double appleTotalPrice = appleGram * applePrice;
            //Console.WriteLine("Alınan Ürün: Elma - " + "Birim Fiyat: " + applePrice + " - Gramaj: " + appleGram + " - Toplam Tutar: " + appleTotalPrice);

            //double orangeTotalPrice = orangeGram * orangePrice;
            //Console.WriteLine("Alınan Ürün: Portakal - " + "Birim Fiyat: " + orangePrice + " - Gramaj: " + orangeGram + " - Toplam Tutar: " + orangeTotalPrice);

            //double strawberryTotalPrice = strawberryGram * strawberryPrice;
            //Console.WriteLine("Alınan Ürün: Çilek - " + "Birim Fiyat: " + strawberryPrice + " - Gramaj: " + strawberryGram + " - Toplam Tutar: " + strawberryTotalPrice);

            //double potatototalPrice = potatoGram * potatoPrice;
            //Console.WriteLine("Alınan Ürün: Patates - " + "Birim Fiyat: " + potatoPrice + " - Gramaj: " + potatoGram + " - Toplam Tutar: " + potatototalPrice);

            //double tomatoTotalPrice = tomatoGram * tomatoPrice;
            //Console.WriteLine("Alınan Ürün: Domates - " + "Birim Fiyat: " + tomatoPrice + " - Gramaj: " + tomatoGram + " - Toplam Tutar: " + tomatoTotalPrice);

            //Console.WriteLine();
            //double shoppingTotalprice= appleTotalPrice+ orangeTotalPrice+ strawberryTotalPrice + potatototalPrice+ tomatoTotalPrice;
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine("Alışveriş Toplam Tutar: " + shoppingTotalprice + " Tl ");

            #endregion

            #region Char Değişkeni
            //// char tek karakterlidir. char ' ' tek tırnakla atama yapılır.

            //char symbol;
            //symbol = 'a';
            //Console.WriteLine(symbol);



            #endregion

            #region klavyeden Veri Girişleri String Değişkenler;

            //Console.WriteLine("**** CSharp Hava Yolları Yolcu Bilgisi ****");
            //Console.WriteLine();
            //string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge, passengerIdentlNumber;

            //Console.Write("Yolcu Adı: ");
            //passengerName = Console.ReadLine();

            //Console.Write("Yolcu Soyadı: ");
            //passengerSurname= Console.ReadLine();

            //Console.Write("İlçe Bilgisi: ");
            //passengerDistrict= Console.ReadLine();

            //Console.Write("Şehir Bilgisi: ");
            //passengerCity= Console.ReadLine();

            //Console.Write("Yolcu Yaş: ");
            //passengerAge= Console.ReadLine();

            //Console.Write(" Yolcu TC Kimlik No: ");
            //passengerIdentlNumber= Console.ReadLine();

            //Console.WriteLine();

            //Console.WriteLine("----------------------");
            //Console.WriteLine("Yolcu Kimlik No: " + passengerIdentlNumber + "Yolcu Ad Soyad: " + passengerName + " " + passengerSurname + " " + passengerDistrict + "/" + passengerCity + " " + passengerAge);

            #endregion

            #region Klavyeden Tam Sayı Girişleri Ve Dönüşümler

            //int shoePrice, computerPrice, chairPrice, tvPrice;
            //shoePrice = 1000;
            //computerPrice = 20000;
            //chairPrice = 5000;
            //tvPrice = 12000;

            //int shoeCount, computerCount, chairCount, tvCount;

            //Console.Write("Lütfen aldığınız ayakkabı sayısını giriniz: ");
            //shoeCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız bilgisayar sayısını giriniz: ");
            //computerCount=int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız sandalye sayısını giriniz: ");
            //chairCount=int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız bilgisayar sayısını giriniz: ");
            //computerCount = int.Parse(Console.ReadLine());

            //int totalPrice= shoeCount*shoePrice+ computerCount*computerPrice + chairCount*computerPrice+ tvPrice*tvPrice;
            //Console.WriteLine();
            //Console.WriteLine("Toplam Ödemeniz Gereken Tutar: " + totalPrice);



            #endregion

            #region Klavyeden Ondaklı Sayı İşlemleri

            //double exam1, exam2, exam3, result;

            //Console.Write("Lütfen 1. Sınav Notunuzu Giriniz: ");
            //exam1=double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2.Sınav Notunuzu Giriniz: ");
            //exam2=double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 3. Sınav Notunuzu Giriniz: ");
            //exam3 =double.Parse(Console.ReadLine());

            //result = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine();
            //Console.Write("Sınav Ortalamanız: " + result);


            #endregion

            #region Klavyeden Karakter Girişleri

            //char gender;
            //Console.Write("Lütfen Cinsiyet Seçiniz: ");
            //gender=char.Parse(Console.ReadLine());

            //Console.Write("Seçtiğiniz Cinsiyet: " + gender);

            #endregion

            Console.Read();
        }
    }
}
