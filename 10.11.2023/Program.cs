
using System;
using System.Collections.Generic;



namespace DDD
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your password ");
            string password = Console.ReadLine();
            char[] charpassword = password.ToCharArray();
            int security = 0;


            if (charpassword.Length >= 8 && charpassword.Length <= 14)
            {
                Console.WriteLine("You password lenght is enough ");
                Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine("security = security + 20");
                security = security + 20;
                Console.ResetColor();
            }
            if (charpassword.Length < 8)
            {
                Console.WriteLine("You password lenght  not is enough ");
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("security = security -20");
                security = security - 20;
                Console.ResetColor();
            }
            if (charpassword.Length > 14)
            {
                Console.WriteLine("You password lenght  not is enough ");
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("security = security -20");
                security = security - 20;
                Console.ResetColor();
            }

            int count3 = 0;
            for (int i = 0; i < charpassword.Length; i++)
            {

                if (Char.IsUpper(charpassword[i]))
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    count3++;


                    Console.ResetColor();

                }
            }
            if (count3 > 0)
            {
                Console.WriteLine("You have upper case in the passowrd");
                Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine("security = security + 10");
                security = security + 10;
                Console.ResetColor();
            }

            else
            {
                Console.WriteLine("You don't have upper case in the passowrd");
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("security = security -10");
                security = security - 10;

                Console.ResetColor();
            }

            int count2 = 0;
            for (int i = 0; i < charpassword.Length; i++)
            {

                if (Char.IsLetterOrDigit(charpassword[i]))
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    count2++;


                    Console.ResetColor();

                }
            }
            if (count2 == charpassword.Length)
            {
                Console.WriteLine("You don't have have special character  in the passowrd");
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("security = security -10");
                security = security - 10;
                Console.ResetColor();
            }
            else
            {
                Console.WriteLine("You  have have special character  in the passowrd");
                Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine("security = security +10");
                security = security + 10;
                Console.ResetColor();
            }





            int count1 = 0;
            for (int i = 0; i < charpassword.Length; i++)
            {

                if (Char.IsNumber(charpassword[i]))
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    count1++;


                    Console.ResetColor();

                }
            }
            if (count1 > 0)
            {
                Console.WriteLine("You  have enogh numbers in the passowrd");
                Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine("security = security +10");
                security = security + 10;
                Console.ResetColor();
            }
            else if (count1 == 0)
            {
                Console.WriteLine("You don't have enough numbers in the passowrd");
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("security = security -10");
                security = security - 10;
                Console.ResetColor();
            }



            int countspace = 0;
            for (int i = 0; i < charpassword.Length; i++)
            {

                if (Char.IsWhiteSpace(charpassword[i]))
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    countspace++;


                    Console.ResetColor();

                }
            }
            if (countspace > 0)
            {
                Console.WriteLine("You don't have space in the password");
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("security = security -100");
                security = security - 100;
                Console.ResetColor();
            }
            else if (countspace == 0)
            {
                Console.WriteLine("You have space in the password");
                Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine("security = security +10");
                security = security + 10;
                Console.ResetColor();
            }
            Console.WriteLine(security);
            if (security == 60)
            {
                Console.WriteLine("your password is perfect");
            }
            else if (security < 60 && security > 40)
            {
                Console.WriteLine("your password is not that strong, so we suggest you change it");
            }
            else if (security < 40 && security > 20)
            {
                Console.WriteLine("you need to change your password");
            }
            else if (security < 20)
            {
                Console.WriteLine("You are kinda dumb");

            }


        }

    }


}







