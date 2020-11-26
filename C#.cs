using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace TestS
//{
//    class TestS
//    {
//        static void Main(string[] args)
//        {
//            double sum = 0.5, t, t1, t2, t3, p = 0.5 * 0.5;
//            double Pi,R,S;
//            int odd = 1, even = 2;
//            t = t1 = t2 = 1.0; t3 = 0.5;
//            while (t > 1e-10)
//            {
//                t1 = t1 * odd / even;
//                odd += 2; even += 2;
//                t2 = 1.0 / odd;
//                t3 = t3 * p;
//                t = t1 * t2 * t3;
//                sum += t;
//            }
//            Pi = sum * 6;
//            Console.Write("请输入半径：");
//            R = double.Parse(Console.ReadLine());
//            S = Pi * R * R;
//            Console.WriteLine("圆的面积={0:f2}", S);
//            Console.ReadKey();
//        }
//    }
//}

//namespace TestPi
//{
//    class TestPi
//    {
//        static void Main(string[] args)
//        {
//            double sum = 0.5, t, t1, t2, t3, p = 0.5 * 0.5;
//            int odd = 1, even = 2;
//            t = t1 = t2 = 1.0; t3 = 0.5;
//            do
//            {
//                t1 = t1 * odd / even;
//                odd += 2; even += 2;
//                t2 = 1.0 / odd;
//                t3 = t3 * p;
//                t = t1 * t2 * t3;
//                sum += t;
//            } while (t > 1e-10);
//            Console.WriteLine("\nPI = {0,10:f8}", sum * 6);
//            Console.Read();
//        }
//    }
//}

//namespace Test3_3
//{
//    enum MonthName
//    {
//        January, February, March, April, May, June, July, August, September, October, November, December
//    }
//    class WhatDay
//    {
//        static System.Collections.ICollection DaysInMonth1 = new int[12] { 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };//闰年
//        static System.Collections.ICollection DaysInMonth2 = new int[12] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };//平年
//        static void Main(string[] args)
//        {
//            try
//            {
//                Console.Write("Please inpit year:");
//                string line1 = Console.ReadLine();//输入年份
//                int yearNum = int.Parse(line1);
//                bool isLeapYear = yearNum % 4 == 0 && yearNum % 100 != 0 || yearNum % 400 == 0;//判断闰年
//                int maxDayNum = isLeapYear ? 366 : 365;
//                Console.Write("Please inpit a day number between 1 and maxDayNum:");
//                string line2 = Console.ReadLine();//输入天数
//                int dayNum = int.Parse(line2);
//                if (dayNum < 1 || dayNum > maxDayNum)
//                {
//                    throw new ArgumentOutOfRangeException("Day out of Range!");
//                }
//                int monthNum = 0;
//                //是闰年
//                if(isLeapYear)
//                {
//                    foreach (int daysInMonth1 in DaysInMonth1)
//                    {
//                        if (dayNum <= daysInMonth1)
//                        {
//                            break;
//                        }
//                        else
//                        {
//                            dayNum -= daysInMonth1;
//                            monthNum++;
//                        }
//                    }
//                }
//                    //不是闰年
//                else
//                {
//                    foreach (int daysInMonth2 in DaysInMonth2)
//                    {
//                        if (dayNum <= daysInMonth2)
//                        {
//                            break;
//                        }
//                        else
//                        {
//                            dayNum -= daysInMonth2;
//                            monthNum++;
//                        }
//                    }
//                }
//                MonthName temp = (MonthName)monthNum;
//                string monthName = Enum.Format(typeof(MonthName), temp, "g");
//                Console.WriteLine("{0},{1}", dayNum, monthName);
//                Console.Read();
//            }
//            catch (Exception caught)
//            {
//                Console.WriteLine(caught);
//            }
//        }
//    }
//}