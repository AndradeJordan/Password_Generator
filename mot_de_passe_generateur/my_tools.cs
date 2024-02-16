using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mot_de_passe_generateur
{
    public static class my_tools
    {
        public static int Ask_number_positif_not_null(string question)
        {
            int result = Ask_number_between(question, 0, int.MaxValue);
            return result;
        }
        public static int Ask_number_between(string question, int min, int max)
        {
            int result = Ask_number(question);
            if ((result < min) || (result > max))
            {
                Console.WriteLine("Sorry the number must to be between " + min + " and " + max);
                return Ask_number_between(question, min, max);
            }
            else
            {
                return result;
            }
        }
        public static int Ask_number(string question)
        {
            int number = 0;
            while (number == 0)
            {
                Console.WriteLine(question);
                string number_string = Console.ReadLine();
                try
                {
                    number = int.Parse(number_string);
                }
                catch
                {
                    Console.WriteLine("You need to enter an integer !");
                    number = 0;
                }
            }
            return number;
        }

        public static string password_creation(int lenght, int user_choose)
        {
            string password = "";
            string lower_case = "abcdefghijklmnopqrstuvwxyz";
            string upper_case = lower_case.ToUpper();
            string number_case = "1234567890";
            string caractere = "&!:;,$^*@%£§/.";

            string world_caractere;

            if (user_choose == 1)
            {
                world_caractere = lower_case ;
            }
            else if (user_choose == 2) 
            {
                world_caractere = lower_case +  upper_case ;
            }
            else if (user_choose == 3)
            {
                world_caractere = lower_case + number_case + upper_case ;
            }
            else
            {
                world_caractere = lower_case + number_case + upper_case + caractere;
            }

            int lenght_world_caractere = world_caractere.Length;
            Random random = new Random();
            while (lenght > 0)
            {
                char c = world_caractere[random.Next(0, lenght_world_caractere)];
                password += c;
                lenght -= 1;
            }

            return password;
        }
    }
}
