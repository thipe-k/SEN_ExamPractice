using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Diary_Management.Business_Logic
{
    public enum TitleTypes { SelectTitle = 99  ,Mr = 1, Mrs = 2, Miss = 3, Ms = 4, Dr = 10, Prof = 11 }
    public enum RolesTypes { Manager = 1, Secretary =  2, Developer = 10, DBA = 11, Designer = 12, Tester = 20 }
    /// <summary>
    /// Task : For single person
    /// Meeting : For atleat two people
    /// </summary>
    public enum ActivityType { Task = 1, Meeting = 2 }
    /// <summary>
    /// Team Meeting : For all team members
    /// Performance Evaluation: For team manager and one member
    /// AdHocMeeting : For atleat two people
    /// </summary>
    public enum MeetingType { TeamMeeting = 1, PerformanceEvaluation = 2, AdHocMeeting = 3 }

    public static class Utility
    {
        public static bool ConfirmIdentityNumber(string iDNumber, int gender, DateTime dob)
        {
            if (iDNumber.Length == 13)
            {
                if (iDNumber.Substring(0,6) == dob.ToShortDateString().Substring(2).Replace("/", ""))
                {
                    if (Convert.ToInt32(iDNumber.Substring(6, 4)) < 5000 && gender == 1 || Convert.ToInt32(iDNumber.Substring(6, 4)) >= 5000 && gender == 1)
                    {
                        return true;
                    }
                    return false;
                }
                return false;
            }
            return false;
        }
    }
}
