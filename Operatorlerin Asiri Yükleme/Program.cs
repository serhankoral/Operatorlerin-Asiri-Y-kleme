using System;

namespace Operatorlerin_Asiri_Yükleme
{
    class Program
    {
        static void Main(string[] args)
        {
            //Operatörlerin aşırı yüklenmesi aynı fonksiyonların aşırı yüklenmesi gibi
            //Şimdi bir fonksiyonu aşırı yükliyelim
            Console.WriteLine(MyClass.topla(5, 7));
            Console.WriteLine(MyClass.topla(5, 7, 13));
            //Operatörlerimiz +,- true, false gibi olanların aşırı yüklenmesi
            //Fonksiyon yazılırken operator kelimesi kullanılır
            MyClass myClass = new MyClass() { X = 5 };
            if(myClass)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");

            }
            //Bu aşırı yükleme nasıl kullanılır 
            //Mesela bir sql bağlantısı oluşturacan o zaman bağlantı var mı yok mu durum nedir onin için kullanılır
            //He diye bilirsin normal fonksiyon yazarak kullanılırmı kullanılır ama bağlantı class ı oluşturursun sonasında
            //bağlantı classından işlem class oluşturursun böylelikle daha az code ile işlem yaparsın 

        }
    }
    class MyClass
    {
        public static int topla(int a, int b)
        {
            return a + b;
        }
        public static int topla(int a, int b, int c)
        {
            return a + b + c;
        }
        public int X { get; set; }

        public static bool operator true(MyClass value)
        {
            if (value.X > 10)
            {
                return true;
            }
            return false;
        }
        public static bool operator false(MyClass value)
        {
            if (value.X < 10)
            {
                return true;
            }
            return false;
        }
    }
}
