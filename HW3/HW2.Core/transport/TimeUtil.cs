using System;

namespace HW2.Core.transport
{
    internal static class TimeUtil
    {
        public static int ToInt(DateTime time)
        {
            return time.Hour * 60 + time.Minute;
        }

        public static int PlusOneDayToInt(DateTime time)
        {
            return ToInt(time) + 24 * 60;
        }
    }
}