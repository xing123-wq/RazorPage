using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class EmailMessage:ISendMessage
    {
        public void send()
        {
            Console.WriteLine("发送一封Email");
        }
    }
}
