using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Diary_Management.Business_Logic
{
    interface IActivity
    {
        DateTime Start { get; set; }
        DateTime End { get; set; }

        IDiaryOwner Owner { get; set; }
        List<IDiaryOwner> Participants { get; set; }

        void Cancel();
        bool Schedule();
    }
}
