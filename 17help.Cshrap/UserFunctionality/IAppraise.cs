using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    interface IAppraise
    {
        void Agree(User voter);
        void Disagree(User voter);
    }
}
