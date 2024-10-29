using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubjects
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Yazdırma Komutları
            //Console.WriteLine("Merhaba Dünya");
            //Console.Write("Selam");

            //Console.WriteLine("*****Yemek Kategorileri*****");
            //Console.WriteLine();
            //Console.WriteLine("1-Çorbalar");
            //Console.WriteLine("2-Ana Yemekler");
            //Console.WriteLine("3-Soğuk Başlangıçlar");
            //Console.WriteLine("4-Salatalar");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("6-İçecekler");
            //Console.WriteLine();
            //Console.WriteLine("*****Yemek Kategorileri*****");

            #endregion

            #region StringDeğişkenler

            ////string
            ////Değişken_türü_değişken_adı;

            ////string name;
            ////name = "Hatice";
            ////Console.Write(name);

            //string customerName;
            //string custonerSurname;
            //string customerPhone;
            //string customerEmail, district, city;

            //customerName = "Ali";
            //custonerSurname = "Çınar";
            //customerPhone = "+90 500 400 30 20";
            //customerEmail = "deneme@gmail.com";
            //district = "Kadıköy";
            //city = "İstanbul";

            //Console.WriteLine("****Rezarvasyon Kartı****");
            //Console.WriteLine();
            //Console.WriteLine("-------------------------------------------");
            //Console.WriteLine("Müşteri: " + customerName+ " "  + custonerSurname);
            //Console.WriteLine("İletişim: " + customerPhone);
            //Console.WriteLine("E-mail Adresi: " + customerEmail);
            //Console.WriteLine("Adres: " + district + "/" + city);
            //Console.WriteLine("-------------------------------------------");

            //Console.WriteLine();


            //customerName = "Ayşegü";
            //custonerSurname = "Kaya";
            //customerPhone = "+90 400 300 80 70";
            //customerEmail = "test@gmail.com";
            //district = "Sapanca";
            //city = "Sakarya";

            //Console.WriteLine("-------------------------------------------");
            //Console.WriteLine("Müşteri: " + customerName + " " + custonerSurname);
            //Console.WriteLine("İletişim: " + customerPhone);
            //Console.WriteLine("E-mail Adresi: " + customerEmail);
            //Console.WriteLine("Adres: " + district + "/" + city);
            //Console.WriteLine("-------------------------------------------");




            #endregion

            #region IntDeğişkenleri

            //int

            //int number = 24;
            //Console.WriteLine(number);

            int hamburgerPrice = 300;
            int cokePrice = 35;
            int waterPrice = 10;
            int friesprice = 50;
            int pizzaPrice = 250;
            int lemonedePrice = 30;

            Console.WriteLine("**** Restoran Fiyatı ****");
            Console.WriteLine();
            Console.WriteLine("----Hamburger: " + hamburgerPrice + " TL ");
            Console.WriteLine("----Pizza: " + pizzaPrice + " TL ");
            Console.WriteLine("---Kola: " + cokePrice + "TL");
            Console.WriteLine("----Limonata: " + lemonedePrice + " TL ");
            Console.WriteLine("----Kızartma: " + friesprice + " TL ");
            Console.WriteLine("----Su: " + waterPrice  + " TL ");
            Console.WriteLine();
            Console.WriteLine("**** Restoran Fiyatı ****");
            Console.WriteLine();

            int hambergerCount;
            int cokeCount;
            int waterCount;
            int friesCount;
            int pizzaCount;
            int LemonadeCount;

            int totalhamburgerPrice;
            int totalcokePrice;
            int totalwaterPrice;
            int totalfriesprice;
            int totalpizzaPrice;
            int totallemonedePrice;
           

            hambergerCount = 3;
            cokeCount = 3;
            waterCount = 3;
            friesCount = 1;
            pizzaCount = 0;
            LemonadeCount = 0;

            totalhamburgerPrice = hambergerCount * hamburgerPrice;
            totalcokePrice = cokeCount * cokePrice; 
            totalwaterPrice = waterCount * waterPrice;
            totallemonedePrice = LemonadeCount * lemonedePrice;
            totalfriesprice= friesCount * friesprice;
            totalpizzaPrice= pizzaCount * pizzaPrice;
           
         


            Console.WriteLine("--------------------");
            Console.WriteLine("Hamburger Tutarı: " + totalhamburgerPrice + " TL ");
            Console.WriteLine("Pizza Tutarı: " + totalpizzaPrice + " TL ");

            Console.WriteLine("Kızartma Tutarı: " + totalfriesprice + " TL ");
            Console.WriteLine("Kola Tutarı: " + totalcokePrice + " TL");
            Console.WriteLine("Limonata Tutarı: " + totallemonedePrice + " TL ");
            Console.WriteLine("Su Tutarı: " + totalwaterPrice  + " TL ");
            Console.WriteLine();


            int totalPrice = totalhamburgerPrice + totalcokePrice + totalwaterPrice + totalfriesprice + totallemonedePrice + totalpizzaPrice;
            Console.WriteLine("Toplam Ödenecek Tutar: " + totalPrice + " TL ");

            #endregion




            Console.Read();

        }
    }
}




// Yazdırma Konuları
