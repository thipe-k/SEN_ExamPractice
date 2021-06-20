using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Diary_Management.Business_Logic.CustomExceptions
{
    class NotComparableException : Exception
    {
        public NotComparableException() : base("Objects not comparable")
        {
        }
    }
}
