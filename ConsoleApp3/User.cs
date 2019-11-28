using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    sealed internal class User:Entity
    {
        internal User(string inviter)
        {

        }
        public User()
        {

        }
        internal int HelpMony { get; set; }
        internal int credit { get; set; }
        private int _reward;
        public int Reward
        {
            get
            {
                return _reward;
            }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("奖赏不能为负数!");
                }
                else
                {
                    _reward = value;
                }



            }
        }
        public string _name;
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (value == "admin")
                {
                    _name = "系统管理员";
                }
                else
                {
                    Console.WriteLine("不是系统管理员");
                }
            }
        }
        private string Password { get; set; }
        public User Invitedby { get; set; }
        public string Grade { get; set; }//等级属性
        internal void elevaterank(string label, int integral)
        {

        }
        //提升等级的方法
        static void Register()
        {

        }
        static void Login()
        {

        }
        internal void ChangePasword(string data)
        {



        }

    }
}
