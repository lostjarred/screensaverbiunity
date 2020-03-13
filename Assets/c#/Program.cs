using System;

namespace screensaver
{
    
    class Program{
        static void Main(string[] args){
                string outputstring = "";
                for(int i = 0; i < 10; i++){
                    Console.WriteLine(Time.Gettime(Time.GetDateTime()));
                    outputstring = Converters.convertIntBineary(Time.GetHour(Time.GetDateTime())) + ":" + Converters.convertIntBineary(Time.GetMinute(Time.GetDateTime())) + ":" + Converters.convertIntBineary(Time.GetMilisecond(Time.GetDateTime()));
                    Console.WriteLine(outputstring);
                    
                    outputstring = Converters.convertIntHex(Time.GetHour(Time.GetDateTime())) + ":" + Converters.convertIntHex(Time.GetMinute(Time.GetDateTime())) + ":" + Converters.convertIntHex(Time.GetMilisecond(Time.GetDateTime()));
                    Console.WriteLine(outputstring);
                    
                    string stringchunk = Stringchunkgenerator.GetCharacterChunk(Stringchunkgenerator.GetCharacterString(), Stringchunkgenerator.Getrandomnumber(1, 9));
                    outputstring = Converters.convertStringBineary(stringchunk);
                    Console.WriteLine(outputstring);
                }
        }
    }
}
