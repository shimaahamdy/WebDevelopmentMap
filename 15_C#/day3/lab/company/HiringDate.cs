using System;

namespace company
{
    internal struct HiringDate
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

    }
}
