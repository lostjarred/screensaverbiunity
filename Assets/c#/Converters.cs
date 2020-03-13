
namespace screensaver{
    using System;
    using System.Text;
    class Converters{
        public static string convertStringBineary(string convertString){
            int lengthofstring = convertString.Length;
            string binearyString = "";
            for(int i = 0; i < lengthofstring; i ++){
                char stringChar = Convert.ToChar(convertString[i]);
                int charInt = convertCharInt(stringChar);
                binearyString = binearyString + convertIntBineary(charInt);
            }
            return binearyString;
        }
        public static int convertCharInt(char inputchar){
            Encoding ascii = Encoding.ASCII;
            byte[] charstringbyte = ascii.GetBytes(inputchar.ToString());
            return Convert.ToInt32(charstringbyte[0]);
        }

        public static string convertIntBineary(int inputint){
            return Convert.ToString(inputint, 2);
        }

        public static string convertIntHex(int inputint){
            return Convert.ToString(inputint, 16);
        }
    }
}