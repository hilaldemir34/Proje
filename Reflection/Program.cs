using System;
using System.Reflection;

namespace Reflection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DortIslem dortIslem = new DortIslem(2, 3);
            //dortIslem.Topla(3, 5);
            //dortIslem.Topla2();
            var type = typeof(DortIslem);
            var instance = Activator.CreateInstance(type, 6, 7);

            MethodInfo methodInfo = instance.GetType().GetMethod("Topla2");
            Console.WriteLine(methodInfo.Invoke(instance, null));
            var methods = type.GetMethods();
            foreach (var method in methods) 
            {
                Console.WriteLine( "{0}",method.Name );
                foreach (var info in method.GetParameters())
                {
                    Console.WriteLine("0",info.Name);
                }
                foreach (var attribute in method.GetCustomAttributes())
                {
                    Console.WriteLine("0",attribute.GetType().Name);
                }
            
            }
            Console.ReadLine();
        }
        public class DortIslem
        {
            int _sayi1;
            int _sayi2;

            public DortIslem(int sayi1, int sayi2)
            {
                _sayi1 = sayi1;
                _sayi2 = sayi2;
            }
            public DortIslem()
            {

            }

            public int Topla(int sayi1, int sayi2)
            {
                return sayi1 + sayi2;
            }
            public int Carp(int sayi1, int sayi2)
            {
                return sayi1 * sayi2;
            }
            public int Topla2()
            {
                return _sayi1 + _sayi2;
            }
            public int Carp2()
            {
                return _sayi1 * _sayi2;
            }
        }
    }
}
