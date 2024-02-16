using System;

namespace mot_de_passe_generateur
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int password_length = my_tools.Ask_number_positif_not_null("Password's length : ");
            int number_password = my_tools.Ask_number_positif_not_null("How many password's numbers do you want ?");

            int user_choose = my_tools.Ask_number_between("You want a password with : \n" +
                "1 - Only the lowercase characters \n" +
                "2 - Only the lowercase and uppercase characters \n" +
                "3 - Only characters and numbers \n" +
                "4 - Or characters, numbers and special characters", 1, 4);

           for (int i = 1; i <= number_password; i++) 
            {
                string pass = my_tools.password_creation(password_length, user_choose);

                Console.WriteLine("Your "+i+"-password is : " + pass);
            }
            

        }
    }
}