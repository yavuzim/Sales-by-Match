using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;


namespace ConsoleApp1
{
    class Program
    {
        public static int SockMerchant(int n, List<int> ar)
        {
            List<int> degerler = new List<int>();
            int sayac = 0, ortalama = 0, sonuc = 0, say = 0; ;
            for (int i = 0; i < ar.Count; i++)
            {
                if (!degerler.Contains(ar[i]))
                {
                    degerler.Add(ar[i]);
                    say = 0; sayac = 0;
                    while (sayac <= ar.Count)
                    {
                        if (sayac == ar.Count) break;
                        if (ar[i] == ar[sayac])
                            say++;
                        sayac++;
                    }
                    if (say % 2 == 0)
                    {
                        ortalama = say / 2;
                        sonuc += ortalama;
                    }
                    else
                    {
                        say--;
                        ortalama = say / 2;
                        sonuc += ortalama;
                    }
                }
            }
            return sonuc;
        }

        static void Main(string[] args)
        {
            int n = 0;
            while (n < 1 || n > 100)
            {
                Console.Write("Number : ");
                n = Convert.ToInt32(Console.ReadLine().Trim());
            }
            List<int> ar = new List<int>();
            while (ar.Count < 1 || ar.Count > 100)
            {
                Console.Write("Array : ");
                ar = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arTemp => Convert.ToInt32(arTemp)).ToList();
            }
            int result = SockMerchant(n, ar);
            Console.WriteLine("********************************");
            Console.WriteLine(" There are " + result + " even numbers");
            Console.Read();
        }
    }
}
