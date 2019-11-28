using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Comment : IAppraise
    {

        public void Agree(User voter)
        {
            voter.HelpMony += 1;
        }

        public void Disagree(User voter)
        {
            voter.HelpMony -= 1;
        }
    }
}
