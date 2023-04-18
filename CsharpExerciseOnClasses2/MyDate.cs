using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CsharpExerciseOnClasses2 {
    public class MyDate {
        private int year;
        private int month;
        private int day;
        private static string[] strMonths = new string[] { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Nov", "Dec" }; // 0-11
        private static string[] strDays = new string[] {"Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" }; // 0-6
        private static int[] daysInMonths = new int[] {31,28,31,30,31,30,31,31,30,31,30,31};
        public static bool isLeapYear(int year) {
            return (year % 4 == 0 && year % 100 != 0) || year % 400 == 0; // A year is a leap year if it is divisible by 4 but not by 100, or it is divisible by 400.
        }
        public static bool isValidDate(int year,int month, int day) {
            //if (month >= 1 && month <= 12)
            //    if (day >= 1 && day <= 31) // zalezi na mesici //  && day <= daysInMonths[month-1] pokud unor bude mit 30 ?
            //        return true;
            bool prestupny;
            if (year >= 1 && year <= 9999)
                if (month == 1 || month > 2) {
                    if (day > daysInMonths[month - 1]) {
                        //to check if the date is out of range     
                        return false;
                    }
                } else if (month == 2) {
                    prestupny = isLeapYear(year);
                    if ((prestupny == false) && (day >= 29)) return false;
                    else {
                        if ((prestupny == true) && (day > 29)) {
                            Console.WriteLine("Invalid date format!");
                            return false;
                        }
                    }
                } else {
                    Console.WriteLine("Invalid date format! 2");
                    return false;
                }
            return true;
        }
        public int getDayOfWeek(int year, int month, int day) {
            int[] t = new int[] { 0, 3, 2, 5, 0, 3, 5, 1, 4, 6, 2, 4 };
            if (month < 3) {
                year -= 1;
            }
            return (year + year / 4 - year / 100 + year / 400 + t[month - 1] + day) % 7;
        }
        public MyDate(int year, int month, int day) {
            isLeapYear(year);
            //isValidDate(year, month, day);
            setDate(year, month, day);
        }
        public void setDate(int year, int month, int day) {
            if (isValidDate(year, month, day)) {
                this.year = year;
                this.month = month;
                this.day = day;
            } else {
                Console.WriteLine("Zadano nespravne datum.");
            }
            //try {
            //    this.year = year;
            //    this.month = month;
            //    this.day = day;
            //}
            //catch (ArgumentOutOfRangeException e) {
            //    Console.WriteLine("Invalid year, month, or day!");
            //    throw;
            //}
        }
        public int getYear() { return year; }
        public int getMonth() { return month; }
        public int getDay() { return day; }
        public void setYear(int year) {
            if (year > 0 && year < 10000) {
                this.year = year;
            } else {
                Console.WriteLine("Spatny rok.");
            }
        }
        public void setMonth(int month) {
            if (month > 0 && month < 13) {
                this.month = month;
            } else {
                Console.WriteLine("Spatny mesic.");
            }
        }
        public void setDay(int day) {
            // muze byt zadany den podle mesice a roku?
            // jestli je mesic 2, tak se ptat na prestupnost, jestli je prestupny tak dnymax+1 jinak dny max, pak vnorena podminka, je zadanyden poslednim
            int dayMax = daysInMonths[this.month - 1];
            if (isLeapYear(year) && month == 2) {
                dayMax += 1;
            }
            if (day > 0 && day <= dayMax) {
                this.day = day;
            } else {
                Console.WriteLine("Spatny den.");
                this.day = 1;
            }
        }
        public override string ToString() {
            return $"{strDays[getDayOfWeek(year, month, day)]} {day} {strMonths[month-1]} {year}"; // "xxxday d mmm yyyy", e.g., "Tuesday 14 Feb 2012". // den mesic rok
        }
        public MyDate nextDay() {
            int day = this.getDay();
            this.setDay(day + 1);
            return this;
        }
        public MyDate nextMonth() {
            int month = this.getMonth();
            this.setMonth(month + 1);
            return this;
        }
        public MyDate nextYear() {
            int year = this.getYear();
            this.setYear(year + 1);
            return this;
        }
        public MyDate previousDay() {
            int day = this.getDay();
            this.setDay(day-1);
            return this;
            //return new MyDate(year, month, day + 1); // ?? poradil naseptavac hh
        }
        public MyDate previousMonth() {
            int month = this.getMonth();
            this.setMonth(month-1);
            return this;
        }
        public MyDate previousYear() {
            int year = this.getYear();
            this.setYear(year-1);
            return this;
        }
    }
}
