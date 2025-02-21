using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace finalproject
{
    internal class Validator
    {
        public string HashPassword(string password)
        {
            MD5 md5 = MD5.Create();
            byte[] bytes = md5.ComputeHash(Encoding.UTF8.GetBytes(password));
            StringBuilder builder = new StringBuilder();
            foreach (byte b in bytes)
            {
                builder.Append(b.ToString("x2"));
            }
            return builder.ToString();
        }
        public int cleantextUser(int userInput)
        {
            if (userInput.ToString().Trim() == "")
            {
                return 0;
            }
            else
            {
                return userInput;
            }
        }
        public String cleantextUser(String userInput) {

            userInput = Regex.Replace(userInput, "[^a-zA-Z0-9@._ ]",""); 
            userInput = userInput.Replace(" ", "_");
            return userInput;
        }
    }
}
