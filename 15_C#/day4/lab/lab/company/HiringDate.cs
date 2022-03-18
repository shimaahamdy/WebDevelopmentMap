using System;

namespace company
{
    public struct HiringDate
    {
        public int year;
        public int month;
        public int day;

        public HiringDate(int _day,int _month, int _year)
        {
            year = _year;
            month = _month;
            day = _day;
        }
        public override string ToString()
        {
            return string.Format($"{day}/{month}/{year}");
        }

    }
}
