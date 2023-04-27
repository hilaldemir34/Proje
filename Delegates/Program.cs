using System;

namespace Delegates
{
    public delegate void MyDelegate();//void olan ve herhangi bir parametresi olmayan metodlara elçilik yapmak için kullanılan operasyon
    public delegate void MyDelegate2(string text);
    public delegate int MyDelegate3(int sayi1, int sayi2);
    public class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            //customerManager.SendMessage();
            //customerManager.ShowAlert();
            MyDelegate myDelegate = customerManager.SendMessage;
            myDelegate += customerManager.ShowAlert;
            myDelegate -= customerManager.SendMessage;
            MyDelegate2 myDelegate2 = customerManager.SendMessage;
            myDelegate2 += customerManager.ShowAlert;
            Matematik matematik = new Matematik();

            MyDelegate3 myDelegate3 = matematik.Topla;
            myDelegate3 += matematik.Carp;
            var sonuc = myDelegate3(2, 3);
            Console.WriteLine(sonuc);

            myDelegate2("Hello");
            myDelegate();
            Console.ReadLine();
        }
    }
    public class CustomerManager
    {
        public void SendMessage()
        {
            Console.WriteLine("Hello");
        }
        public void ShowAlert()
        {
            Console.WriteLine("Be careful!");
        }
        public void SendMessage(string message)
        {
            Console.WriteLine(message);
        }
        public void ShowAlert(string alert)
        {
            Console.WriteLine(alert);
        }
    }
    public class Matematik
    {
        public int Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }
        public int Carp(int sayi1, int sayi2)
        {
            return sayi1 * sayi2;
        }
    }
}
