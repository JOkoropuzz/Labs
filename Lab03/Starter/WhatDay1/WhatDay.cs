using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;

namespace WhatDay1
{
    enum monthName
    {
        January, February, March, April, May, June, July, August, September, October, November, December
    }
    class WhatDay
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Please enter the year: ");
                int yearNum = int.Parse(Console.ReadLine());
                bool isLeapYear = (yearNum % 4 == 0) && (yearNum % 100 != 0 || yearNum % 400 == 0);
                int maxDayNum = isLeapYear ? 366 : 365;
                //if (isLeapYear == true) 
                //{
                //    Console.WriteLine($"{yearNum} IS a leap year");
                //}
                //else 
                //{
                //    Console.WriteLine($"{yearNum} is NOT a leap year");
                //}
                Console.Write($"Please enter a day number between 1 and {maxDayNum}: ");
                int dayNum = int.Parse(Console.ReadLine());
                int monthNum = 0;
                if (dayNum < 1 || dayNum > maxDayNum) 
                {
                    throw new ArgumentOutOfRangeException("Day out of range");
                }
                if (isLeapYear) 
                {
                    foreach (int daysInMonth in DaysInLeapMonths)
                    {
                        if (dayNum <= daysInMonth)
                        {
                            break;
                        }
                        else
                        {
                            dayNum -= daysInMonth;
                            monthNum++;
                        }
                    }
                }
                else
                {
                    foreach (int daysInMonth in DaysInMonths)
                    {
                        if (dayNum <= daysInMonth)
                        {
                            break;
                        }
                        else
                        {
                            dayNum -= daysInMonth;
                            monthNum++;
                        }
                    }
                }
                
                //if (dayNum <= 31)
                //{
                //    goto End;
                //}
                //else
                //{
                //    dayNum -= 31;
                //    monthNum++;
                //}

                //if (dayNum <= 28)
                //{
                //    goto End;
                //}
                //else
                //{
                //    dayNum -= 28;
                //    monthNum++;
                //}

                //if (dayNum <= 31)
                //{
                //    goto End;
                //}
                //else
                //{
                //    dayNum -= 31;
                //    monthNum++;
                //}

                //if (dayNum <= 30)
                //{
                //    goto End;
                //}
                //else
                //{
                //    dayNum -= 30;
                //    monthNum++;
                //}

                //if (dayNum <= 31)
                //{
                //    goto End;
                //}
                //else
                //{
                //    dayNum -= 31;
                //    monthNum++;
                //}


                //if (dayNum <= 30)
                //{
                //    goto End;
                //}
                //else
                //{
                //    dayNum -= 30;
                //    monthNum++;
                //}

                //if (dayNum <= 31)
                //{
                //    goto End;
                //}
                //else
                //{
                //    dayNum -= 31;
                //    monthNum++;
                //}

                //if (dayNum <= 31)
                //{
                //    goto End;
                //}
                //else
                //{
                //    dayNum -= 31;
                //    monthNum++;
                //}

                //if (dayNum <= 30)
                //{
                //    goto End;
                //}
                //else
                //{
                //    dayNum -= 30;
                //    monthNum++;
                //}

                //if (dayNum <= 31)
                //{
                //    goto End;
                //}
                //else
                //{
                //    dayNum -= 31;
                //    monthNum++;
                //}

                //if (dayNum <= 30)
                //{
                //    goto End;
                //}
                //else
                //{
                //    dayNum -= 30;
                //    monthNum++;
                //}

                //if (dayNum <= 31) { goto End; }
                //else
                //{
                //    dayNum -= 31;
                //    monthNum++;
                //}
                //End:

                monthName temp = (monthName)monthNum;
                string monthName = temp.ToString();

                //switch (monthNum)
                //{
                //    case 0:
                //        monthName = "January"; break;
                //    case 1:
                //        monthName = "February"; break;
                //    case 2:
                //        monthName = "March"; break;
                //    case 3:
                //        monthName = "April"; break;
                //    case 4:
                //        monthName = "May"; break;
                //    case 5:
                //        monthName = "June"; break;
                //    case 6:
                //        monthName = "July"; break;
                //    case 7:
                //        monthName = "August"; break;
                //    case 8:
                //        monthName = "September"; break;
                //    case 9:
                //        monthName = "October"; break;
                //    case 10:
                //        monthName = "November"; break;
                //    case 11:
                //        monthName = "December"; break;
                //    default:
                //        monthName = "Not done yet"; break;
                //}
                Console.WriteLine($"{dayNum} {monthName}");
            }
            catch (Exception caught)
            {
                Console.WriteLine(caught);
            }
        }
        static System.Collections.ICollection DaysInMonths = new int[12] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        static System.Collections.ICollection DaysInLeapMonths = new int[12] { 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
    }
}