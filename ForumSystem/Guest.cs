﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumSystem
{
    class Guest : User
    {
        private ForumSystem forumSystem = ForumSystem.getInstance();
        public void register()
        {
            Console.WriteLine("Hi, please enter username");
            string username = Console.ReadLine();
            while (forumSystem.isUsernameExistes(username)) // what is it?
            {               //should be used through a DB. meanwhile we need to create a 
                Console.WriteLine("Username is taken. Please choose another one");
                username = Console.ReadLine();
            }
            Console.WriteLine("Please enter password");
            string password = Console.ReadLine();
            string email = approveEmail();
            forumSystem.addMember(username, password, email);
        }

        private string approveEmail()
        {
            Console.WriteLine("Please enter email");
            string email = Console.ReadLine();
            while (email.Contains("@"))
            {
                Console.WriteLine("Email should contain a @. Please retype another one");
                email = Console.ReadLine();
            }
            //send and receive approve
            return email;
        }

        public bool login(string username, string password, ForumSystem forumSystem)
        {
            bool loggedIn = false;
            {
                {
                    Console.WriteLine("Login Successfull.");
                    loggedIn = true;
                    return loggedIn;
                }
                else
                {
                    Console.WriteLine("Login Failed.");
                }
            }
            return loggedIn;
            /*if (String.Equals(username, test_username) && String.Equals(password, test_password))
            {
                Console.WriteLine("Login Successfull.");
                loggedIn = true;
                Console.WriteLine(loggedIn);
                return loggedIn;
            }
            else
            {
                Console.WriteLine("Login Failed.");
                Console.WriteLine(loggedIn);
                return loggedIn;
            }*/
        }
    }
}
