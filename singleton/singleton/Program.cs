// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsDemo
{
    public class Singleton
    {
        int i = 1;
        private Singleton() {
            Console.WriteLine(i);
            i++;
        }
        private static Singleton instance;
        public static Singleton GetInstance()
        {
            if (instance == null)
            {
                instance = new Singleton();
            }
            return instance;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {

            Singleton s1 = Singleton.GetInstance();
            Singleton s2 = Singleton.GetInstance();

            if (s1 == s2)
            {
                Console.WriteLine("Only one instance created ");
            }
            else
            {
                Console.WriteLine("Single ton fails , more than one Object can be created ");
            }
        }
    }
}
