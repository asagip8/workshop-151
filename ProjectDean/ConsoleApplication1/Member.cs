﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Member
    {
        private long id;
        private string username;
        private string email;
        private string password;
        private bool isActive;
        private List<long> myFriends;
        private List<long> myThreads;
        private List<long> mySubForums;
        private List<long> myForums;
        private string _userName;
        private string _password;
        private double _seniority;
        private double _timeLoggedIn;
        private int numberOfMessagesLastYear;
        private ForumSystem forumSystem;

        public Member()
        {
            register();
            this.id = ForumSystem.idGen.generate();
            this.isActive = true;
            this.myForums = new List<long>();
            this.mySubForums = new List<long>();
            this.myThreads = new List<long>();
            this.myFriends = new List<long>();
        }

        public long ID
        {
            get { return this.id; }
        }

        private void register()
        {
            Console.WriteLine("Hi, please enter username");
            this.username = Console.ReadLine();
            while (fs.searchUername(username)) 
            {               //should be used through a DB. meanwhile we need to create a 
                Console.WriteLine("Username is taken. Please choose another one");
                this.username = Console.ReadLine();
            }
            Console.WriteLine("Please enter password");
            this.password = Console.ReadLine();
            Console.WriteLine("Please enter email");
            this.email = Console.ReadLine();
            while (email.Contains("@")){
                Console.WriteLine("Email should contain a @. Please retype another one");
                this.email = Console.ReadLine();
            }
        }
    }
}
