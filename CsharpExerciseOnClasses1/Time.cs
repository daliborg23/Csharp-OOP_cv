using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpExerciseOnClasses1 {
    public class Time {
        private int hour;
        private int minute;
        private int second;
        public Time(int hour, int minute, int second) {
            this.hour = hour;
            this.minute = minute;
            this.second = second;
        }
        public int getHour() { return hour; }
        public int getMinute() { return minute; }
        public int getSecond() { return second; }
        public void setHour(int hour) {  this.hour = hour; }
        public void setMinute(int minute) {  this.minute = minute; }
        public void setSecond(int second) {  this.second = second; }
        public void setTime(int hour, int minute, int second) {
            this.hour = hour;
            this.minute = minute;
            this.second = second;
        }
        public override string ToString() {
            DateTime dateTime = new DateTime(2023,4,17,hour,minute,second); // nevim jak udelat jen cas
            //return String.Format("{0:HH:mm:ss}", dateTime);
            return dateTime.ToString("HH:mm:ss");
        }
        public Time nextSecond() {
            this.second++;
            return this;
        }
        public Time previousSecond() {
            this.second--;
            return this;
        }
    }
}
