using System;
namespace screensaver
{
class Time{
        public static DateTime GetDateTime(){
            DateTime datetime = DateTime.Now;
            return datetime;
        }
        public static string Gettime(DateTime datetime){
            int hour = GetHour(datetime);
            int minute = GetMinute(datetime);
            int milisecond = GetSecond(datetime);

            string returnstring = hour.ToString() + ":" + minute.ToString() + ":" + milisecond.ToString();
            return returnstring;
        }

        public static int GetHour(DateTime datetime){
            return datetime.Hour;
        }

        public static int GetMinute(DateTime datetime){
            return datetime.Minute;
        }

        public static int GetSecond(DateTime dateTime){
            return dateTime.Second;
        }

        public static int GetMilisecond(DateTime datetime){
            return datetime.Millisecond;
        }
    }
}