using System.Text.RegularExpressions;

namespace ByteBankAppTest
{
    public class Password
    {
        public static bool IsValidPassword(string passWord)
        {
            int validConditions = 0;

            if (string.IsNullOrEmpty(passWord)) return false;
            if (passWord.Length < 8 || passWord.Length >= 100) return false;


            foreach (char c in passWord)
            {
                if (c >= 'a' && c <= 'z')
                {
                    validConditions++;
                    break;
                }
            }
            foreach (char c in passWord)
            {
                if (c >= 'A' && c <= 'Z')
                {
                    validConditions++;
                    break;
                }
            }
            if (validConditions == 0) return false;
            foreach (char c in passWord)
            {
                if (c >= '0' && c <= '9')
                {
                    validConditions++;
                    break;
                }
            }
            if (validConditions == 1) return false;
            if (validConditions == 2)
            {
                char[] special = { '@', '#', '$', '%', '^', '&', '+', '=' }; // or whatever    
                if (passWord.IndexOfAny(special) == -1) return false;
            }
            return true;
        }


        public static bool IsValidPassword2(string passWord)
        {
            bool isPasswordValid = true;

            if (passWord.Length < 12)
                isPasswordValid = false;

            if (!Regex.IsMatch(passWord, "[A-Z]"))
                isPasswordValid = false;

            if (!Regex.IsMatch(passWord, "[a-z]"))
                isPasswordValid = false;

            if (!Regex.IsMatch(passWord, "[0-9]"))
                isPasswordValid = false;

            if (!Regex.IsMatch(passWord, "[^a-zA-Z0-9]"))
                isPasswordValid = false;

            return isPasswordValid;
        }
    }
}
