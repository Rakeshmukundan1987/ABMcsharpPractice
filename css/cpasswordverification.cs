using System;
using System.Text.RegularExpressions;


public class HelloWorld
{
    public static void Main(string[] args)
    {
        //Console.WriteLine ("Please enter password");
       functionValidationForPassword("Rak4dhan@.com");
    }
   public static bool  functionValidationForPassword(string Password){
            var hasNumber = new Regex(@"[0-9]+");
            var hasUpperChar = new Regex(@"[A-Z]+");
            var hasMiniMaxChars = new Regex(@".{8,15}");
            var hasLowerChar = new Regex(@"[a-z]+");
            var hasSymbols = new Regex(@"[!@#$%^&*()_+=\[{\]};:<>|./?,-]");
            
            
            if(!hasLowerChar.IsMatch(Password))
            {
                Console.WriteLine("Password should contain atleast one lowercase letter");
                return false;
            }
            else if (!hasUpperChar.IsMatch(Password))
            {
                Console.WriteLine("Password should contain atleast one Uppercase letter");
                return false;
            }
            else if (!hasMiniMaxChars.IsMatch(Password))
            {
                Console.WriteLine("Password should be  atleast 8 and lower than 15 ");
                return false;
            }
            else if (!hasNumber.IsMatch(Password))
            {
                Console.WriteLine("Password should be  atleast 8 and lower than 15 ");
                return false;
            }
             else if (!hasSymbols.IsMatch(Password)){
                Console.WriteLine("Password should contain special characters ");
                return false;
             }
             else  
             {
                Console.WriteLine("Password created successfully ");
                return true;
             }
            
    }
    
}