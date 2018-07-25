using System;
using System.Linq;

namespace HoloalphabeticSentence
{
    public class HoloalphabeticSentence
    {
        // Write the logic to determine whether the input string is a HoloalphabeticSentence or not
        public static bool IsHoloalphabeticSentence(string input, string alphabets = "abcdefghijklmnopqrstuvwxyz")
        {
            if(input.ToLower().Where(c => alphabets.Contains(c)).Distinct().Count() == 26)
            {
                return true;
            }
            return false;
        }
    }
}
