using System;
namespace screensaver
{
class Time{
        public static DateTime GetDateTime(){
            DateTime datetime = DateTime.Now;
            return datetime;
        }
        public static string Gettime(DateTime datetime){ 
            int inthour = GetHour(datetime);
            int intminute = GetMinute(datetime);
            int intsecond = GetSecond(datetime);
            string hour;
            string minute;
            string Second;
            
            if(inthour > 9){
                hour = inthour.ToString();
            }else{
                hour = "0" + inthour.ToString();
            }
            if(intminute > 9){
                minute = intminute.ToString();
            }else{
                minute = "0" + intminute.ToString();
            }
            if(intsecond > 9){
                Second = intsecond.ToString();
            }else{
                Second = "0" + intsecond.ToString();
            }

            string returnstring = hour + ":" + minute + ":" + Second;
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