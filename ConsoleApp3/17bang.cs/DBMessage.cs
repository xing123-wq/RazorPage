using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class DBMessage:ISendMessage
    {
        public void send()
        {
            Console.WriteLine("存入数据库");
        }
    }
}
