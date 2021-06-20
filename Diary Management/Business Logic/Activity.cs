using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Diary_Management.Business_Logic
{
    abstract class Activity : IActivity, IComparable
    {
        public DateTime Start { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime End { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IDiaryOwner Owner { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public List<IDiaryOwner> Participants { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Cancel()
        {
            throw new NotImplementedException();
        }

        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }

        public bool Schedule()
        {
            throw new NotImplementedException();
        }
    }
}
