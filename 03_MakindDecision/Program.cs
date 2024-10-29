using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakindDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region If

            //Console.Write("Lütfen Şifreyi Giriniz: ");
            //string password;
            //password = Console.ReadLine();

            //if (password == "abcd")
            //{
            //    Console.WriteLine("Şifre doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Şifre yanlış");
            //}

            //string capital, country;
            //Console.Write("Başkenti Giriniz: ");
            //capital = Console.ReadLine();
            //Console.Write("Ülkeyi Giriniz: ");
            //country = Console.ReadLine();

            //if (capital == "ankara" & country == "türkiye")
            //{
            //    Console.Write("veriler doğrulandı");

            //}
            //else
            //{
            //    Console.Write("hatalı bilgi");
            //        }


            //int number;
            //Console.Write("Sayıyı Giriniz: ");
            //number=int.Parse(Console.ReadLine());
            //if(number==5)
            //{
            //    Console.WriteLine("sayı doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı hatalı");
            //}


            //int exam1, exam2, exam3, averange;
            //string result = "Hata!";

            //Console.Write("Sınav 1: ");
            //exam1 = int.Parse(Console.ReadLine());

            //Console.Write("Sınav 2: ");
            //exam2 = int.Parse(Console.ReadLine());

            //Console.Write("Sınav 3: ");
            //exam3 = int.Parse(Console.ReadLine());

            //averange = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine("Sınavların Ortalaması: " + averange);

            //if (averange > 0 & averange <= 50)
            //{
            //    result = "Sonuç vasat";
            //}
            //if (averange > 50 & averange <= 70)
            //{
            //    result = "Sonuç Orta";
            //}
            //if (averange > 70 & averange <=84)
            //{
            //    result = "Sonuç İyi";
            //}
            //if (averange>84)
            //{
            //    result = "Sonuç Çok İyi";
            //}
            //Console.WriteLine(result);


            //string city;
            //Console.Write("Lütfen şehir girişi  yapınız: ");
            //city= Console.ReadLine();

            //if(city=="adana"|  city=="ankara" | city=="bursa" | city=="trabzon")
            //{
            //    Console.WriteLine("şehir mevcut");

            //}
            //else
            //{
            //    Console.WriteLine("şehir mevcut değil");
            //}


            //Console.Write("Lütfen kullanıcı adını giriniz: ");
            //string username=Console.ReadLine();
            //if(username!="admin")
            //{
            //    Console.WriteLine("bu kullanıcı adı kabul edilemez");

            //}
            //else
            //{
            //    Console.WriteLine("Hoşgeldiniz");
            //}

            #endregion

            #region Mod işlemleri

            //int number;
            //number = 26;
            //int result = number % 5;
            //Console.WriteLine(result);

            //Console.Write("1. sayıyı giriniz: ");
            //int number1= int.Parse(Console.ReadLine());

            //Console.Write("2. sayıyı giriniz: ");
            //int number2= int.Parse(Console.ReadLine());

            //int result = number1 % number2;

            //Console.Write("1. sayının 2. sayıya bölümünden kalanı: " + result);

            //Console.Write("Lütfen sayıyı giriniz: ");
            //int number=int.Parse(Console.ReadLine());

            //if (number % 2 == 0)
            //{
            //    Console.Write("Sayı Çifttir");
            //}
            //else
            //{
            //    Console.Write("Sayı Tektir");
            //}

            //char team;
            //Console.Write("Lütfen takım sembolünü giriniz: ");
            //team= char.Parse(Console.ReadLine());

            //if(team == 'g' | team== 'G')
            //{
            //    Console.Write("Galataaray");
            //}
            //if(team=='f'| team=='F')
            //{
            //    Console.Write("Fenerbahçe");
            //}
            //if(team=='b'| team=='B')
            //{
            //    Console.Write("Beşiktaş");
            //}

            //Console.Read();


            #endregion

            #region örnek Proje uygulaması

            Console.WriteLine("***** C# Eğitim Kampı Restaron*****");
            Console.WriteLine();

            Console.WriteLine("1- Ana Yemekler");
            Console.WriteLine("2- Çorbalar");
            Console.WriteLine("3- Pizzalar");
            Console.WriteLine("4- içecekler");
            Console.WriteLine("5- Tatlılar");
            Console.WriteLine("-----------------");
            Console.WriteLine();


            string menuItem;
            Console.WriteLine();

            Console.Write("Lütfen detayını görmek istediğiniz menü seçin: ");
            menuItem = Console.ReadLine();

            if (menuItem == "1")
            {
                Console.WriteLine();
                Console.WriteLine("---------Ana Yemekler--------");
                Console.WriteLine();
                Console.WriteLine("1- Körü Soslu Tavuk");
                Console.WriteLine("2- Kızartma Tabağı");
                Console.WriteLine("3- Fasülye Pilavı");
                Console.WriteLine("4- Fırında Somon");
                Console.WriteLine("5- Patlıcan Musakka");
                Console.WriteLine("---------Ana Yemekler--------");
                Console.WriteLine();
            }
            if (menuItem == "2")
            {
                Console.WriteLine();
                Console.WriteLine("---------Çorbalar--------");
                Console.WriteLine();
                Console.WriteLine("1- Mercimek");
                Console.WriteLine("2- Ezogelin");
                Console.WriteLine("---------Çorbalar--------");
                Console.WriteLine();
            }

            if (menuItem == "3")
            {
                Console.WriteLine();
                Console.WriteLine("---------Pizzalar--------");
                Console.WriteLine();
                Console.WriteLine("1- Akdeniz Pizza");
                Console.WriteLine("2- Margaritha");
                Console.WriteLine("3- Tavuklu Pizza");
                Console.WriteLine("---------Pizzalar--------");
                Console.WriteLine();
            }
            if (menuItem == "4")
            {
                Console.WriteLine();
                Console.WriteLine("---------İçecekler--------");
                Console.WriteLine();
                Console.WriteLine("1- Kola ");
                Console.WriteLine("2- Ayran");
                Console.WriteLine("3- Su");
                Console.WriteLine("---------İçecekler--------");
                Console.WriteLine();
            }

            if (menuItem == "5")
            {
                Console.WriteLine();
                Console.WriteLine("---------Tatlılar--------");
                Console.WriteLine();
                Console.WriteLine("1- Triliçe ");
                Console.WriteLine("2- Kazandibi");
                Console.WriteLine("3- Sütlaç");
                Console.WriteLine("---------Tatlılar--------");
                Console.WriteLine();
            }

            Console.Read();

            #endregion

            #region Switch Case


            //Console.Write("Lütfen ay girişi yapınız: ");
            //int monthNumber= int.Parse(Console.ReadLine());

            //switch(monthNumber)
            //{
            //    case 1: Console.Write("Ocak"); break;
            //    case 2: Console.Write("Şubat"); break;
            //    case 3: Console.Write("Mart"); break;
            //    case 4: Console.Write("Nisan"); break;
            //    case 5: Console.Write("Mayıs"); break;
            //    case 6: Console.Write("Haziran"); break;
            //    case 7: Console.Write("Temmuz"); break;
            //    case 8: Console.Write("Ağustos"); break;
            //    case 9: Console.Write("Eylül"); break;
            //    case 10: Console.Write("Ekim"); break;
            //    case 11: Console.Write("Kasım"); break;
            //    case 12: Console.Write("Aralık"); break;
            //}

            //Console.Read();



            #endregion

            #region Switch Case Hesap Makinesi

            //int number1, number2, result;
            //char symbol;

            //Console.Write("1.Sayıyı Giriniz: ");
            //number1 = int.Parse(Console.ReadLine());

            //Console.Write("2.Sayıyı Giriniz: ");
            //number2 = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen yapmak istediğiniz işlemi giriniz: ");
            //symbol=char.Parse(Console.ReadLine());

            //switch (symbol)
            //{
            //    case '+':
            //        result = number1 + number2;
            //        Console.WriteLine("Toplam: " + result);
            //        break;

            //    case '-':
            //        result = number1 - number2;
            //        Console.Write("Fark: " + result);

            //        break;

            //    case '/':
            //        result = number1 / number2;
            //        Console.Write("Bölme: " + result);
            //        break;

            //    case '*':
            //        result = number1 * number2;
            //        Console.Write("Çarpım: " + result);
            //        break;

            //}
            //Console.Read();


            #endregion
        }
    }
}
