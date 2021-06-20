using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Diary_Management.Business_Logic
{
    public interface IDiaryOwner
    {
         Diary Diary { get; set; }
    }
}
