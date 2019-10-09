using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA191009iteraciok2
{
    //object x1 = 10; //long, ha > mint int.Max
    //object x2 = 10F;
    //object x3 = 10.0;
    //object x4 = "10";
    //object x5 = '1';
    class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            #region 2/7. feladat
            //for(int i = 0; i <= 30; i++)
            //{
            //    Console.WriteLine("{0, 2}^2 = {1, 3}", i, i * i);
            //}
            #endregion
            #region 2/8. feladat
            //for (int i = 0; i <= 30; i++)
            //{
            //    Console.WriteLine($"2^{i} = {Math.Pow(2, i)}");
            //}
            #endregion
            #region 2/9. feladat
            ////"rossz" megoldás:
            ////for (int i = 0; i <= 100; i++)
            ////{
            ////    if (i % 2 == 1) Console.WriteLine(i);
            ////}
            ////"jó" megoldás
            //for(int i = 1; i <= 100; i += 2)
            //{
            //    Console.WriteLine(i);
            //}
            #endregion
            #region 2/10. feladat
            //for(int i = 99; i > 0; i-= 2)
            //{
            //    Console.WriteLine(i);
            //}
            #endregion
            #region 2/11. feladat
            //for (int i = 0; i < 50; i++)
            //{
            //    Console.WriteLine("{0, 2}: {1, 3}", i + 1, 10 + i * 7);
            //}
            ///*
            // több
            // soros
            // komment
            // (vagy sorközi is lehet, de az egyébként csúnya)
            //*/
            //for(int i = 10; i < 360 /*10 + 50 * 7*/; i += 7)
            //{
            //    Console.WriteLine(i);
            //}
            #endregion
            #region 2/12. feladat
            //Console.Write("aˇ1: ");
            //int a = int.Parse(Console.ReadLine());
            //Console.Write("d:   ");
            //int d = int.Parse(Console.ReadLine());
            //for(int i = a; Math.Abs(i) < Math.Abs(a + 20 * d); i += d)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine("-------------");
            //for (int i = 0; i < 20; i++)
            //{
            //    Console.WriteLine(a + (i * d));
            //}
            #endregion
            #region 2/13. feladat
            //Console.Write("aˇ1: ");
            //int a1 = int.Parse(Console.ReadLine());
            //Console.Write("aˇ2: ");
            //int a2 = int.Parse(Console.ReadLine());

            //int d = a2 - a1;

            //for(int i = 10; i >= 1; i--)
            //    Console.WriteLine(a1 - i * d);

            //Console.ForegroundColor = ConsoleColor.Red;
            //Console.WriteLine(a1 + "\n" + a2);
            //Console.ForegroundColor = ConsoleColor.Gray;

            //for(int i = 1; i <= 10; i++)
            //    Console.WriteLine(a2 + i * d);
            #endregion
            #region 2/14. feladat
            //for (int i = -30; i <= 30; i++)
            //{
            //    Console.WriteLine($"{i}°C = {i * 1.8 + 32}°F");
            //}
            #endregion
            #region 2/15. feladat
            //for (int i = 12; i <= 99; i+= 3)
            //{
            //    Console.WriteLine(i);
            //}
            #endregion
            #region 2/16. feladat
            //Console.Write("szám: ");
            //int n = int.Parse(Console.ReadLine());
            //Console.WriteLine("szám osztói:");
            //if (n != 1) Console.WriteLine(1);
            //for (int i = 2; i <= n / 2; i++)
            //{
            //    if (n % i == 0) Console.WriteLine(i);
            //}
            //Console.WriteLine(n);
            #endregion
            #region 2/17. feladat
            //Console.Write("szám: ");
            //int n = int.Parse(Console.ReadLine());

            //int dbo = 0;
            //for (int i = 2; i <= n / 2; i++)
            //{
            //    if (n % i == 0) dbo++;
            //}

            //if (dbo == 0) Console.WriteLine("prím");
            //else
            //{
            //    Console.WriteLine("NEM prím");
            //    Console.Write("valódi osztója pl.: ");
            //    bool oszto = false;
            //    for (int i = 2; !oszto; i++)
            //    {
            //        if (n % i == 0)
            //        {
            //            Console.WriteLine(i);
            //            oszto = true;
            //        }
            //    }
            //}
            #endregion
            #region 2/18. feladat
            //Console.Write("egyik szám: ");
            //int a = int.Parse(Console.ReadLine());
            //Console.Write("másik szám: ");
            //int b = int.Parse(Console.ReadLine());

            //if (a % b == 0)
            //{
            //    Console.WriteLine($"lnko: {b}");
            //}
            //else if (b % a == 0)
            //{
            //    Console.WriteLine($"lnko: {a}");
            //}
            //else
            //{
            //    bool talalat = false;
            //    int lnko = -1;
            //    for (int i = a / 2; i >= 2 && !talalat ; i--)
            //    {
            //        if(a % i == 0)
            //        {
            //            if (b % i == 0)
            //            {
            //                talalat = true;
            //                lnko = i;
            //            }
            //        }
            //    }

            //    if (lnko != -1) Console.WriteLine($"a lnko az {lnko}");
            //    else Console.WriteLine("a lnko az 1");
            //}


            #endregion
            #region 2/19. feladat
            //for (int i = 100; i <= 999; i++)
            //{
            //    if(i / 100 == i % 10)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            //Console.WriteLine("---------");
            //int db = 0;
            //for (int i = 101; i <= 999; i+=10)
            //{
            //    Console.WriteLine(i);
            //    db++;
            //    if (db % 10 == 0) i++;
            //}

            #endregion
            #region 2/20. feladat
            int a1 = 1;
            int a2 = 1;
            Console.Write("1 1 "); //2 3 5 8 13 21
            for (int i = 0; i < 8; i++)
            {
                Console.Write($"{a1 + a2} ");

                int s = a1;
                a1 = a2;
                a2 += s;
            }

            #endregion
            Console.ReadKey();
        }
    }
}
