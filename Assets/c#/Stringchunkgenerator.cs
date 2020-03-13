namespace screensaver{
    using System;
    class Stringchunkgenerator{
        public static string GetCharacterString(){
            string characters = "qwertyuiopasdfghjklzxcvbnm0123456789";
            return characters;
        }

        public static string GetCharacterChunk(string characters, int numberofChars){
            int lengthofChars = characters.Length;
            string characterChunk = "";
            
            for (int c = 0; c < numberofChars; c++){
                int randomNum = Getrandomnumber(0, lengthofChars);
                characterChunk = characterChunk + characters[randomNum];
            }

            return characterChunk;
        }

        public static int Getrandomnumber(int min, int max){
            Random random = new Random();
            return random.Next(min, max);
        }
    }
}