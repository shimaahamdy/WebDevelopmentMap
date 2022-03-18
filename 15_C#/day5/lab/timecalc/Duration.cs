
namespace timecalc
{
    internal class Duration
    {
        int hours;
        int minutes;
        int seconds;

        public Duration(int _hours, int _minutes,int _seconds)
        {
            hours = _hours;
            minutes = _minutes;
            seconds = _seconds;
        }
        public Duration(int _seconds)
        {
            hours = _seconds/(60*60);
            minutes = (_seconds % (60*60))/60;
            seconds = _seconds%60;
        }
        int Hours
        {
            get { return hours; }
            
        }

        int Minutes
        {
            get { return minutes; }
        }
        int Seconds
        {
            get { return seconds; }
        }
        public override string ToString()
        {
            return $"Hours: {Hours},Minutes: {Minutes},Seconds: {Seconds}";
        }
        public override bool Equals(object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }

            Duration d = (Duration)obj;
            return hours == d.Hours && minutes == d.Minutes && seconds == d.Seconds;
            
        }

        public static Duration operator + (Duration d1, Duration d2)
        {
            int h = (d1?.hours ?? 0) + (d2?.hours ?? 0);
            int m = (d1?.minutes ?? 0) + (d2?.minutes ??0);
            int s = (d1?.seconds?? 0) + (d2?.seconds ?? 0);
            return new Duration(h,m,s);
        }
        public static Duration operator +(Duration d1, int v2)
        {
             Duration d2 = new Duration(v2);
            int h = (d1?.hours ?? 0) + (d2?.hours ?? 0);
            int m = (d1?.minutes ?? 0) + (d2?.minutes ?? 0);
            int s = (d1?.seconds ?? 0 + d2?.seconds ?? 0);
            return new Duration(h, m, s);
        }
        public static Duration operator +(int v3, Duration d2)
        {
            Duration d1 = new Duration(v3);
            int h = (d1?.hours ?? 0) + (d2?.hours ?? 0);
            int m = (d1?.minutes ?? 0) + (d2?.minutes ?? 0);
            int s = (d1?.seconds ?? 0) + (d2?.seconds ?? 0);
            return new Duration(h, m, s);

        }

        public static Duration operator ++(Duration d)
        {
           
            return new Duration((d?.hours??0), (d?.minutes??0) + (1), (d?.seconds??0));

        }
        public static Duration operator --(Duration d)
        {

            return new Duration((d?.hours ?? 0), (d?.minutes ?? 0) - (1), (d?.seconds ?? 0));

        }

     
        public static bool operator > (Duration d1, Duration d2)
        {
            if (d1 == null || d2 == null) return false;

            if (d1.hours > d2.hours) return true;
            if (d1.hours == d2.hours)
                if (d1.minutes > d2.minutes) return true;
                else
                   if (d1.minutes == d2.minutes)
                    if (d1.seconds > d2.seconds) return true;

            return false;

        }
        public static bool operator <(Duration d1, Duration d2)
        {
            if (d1 == null || d2 == null) return false;
            
            if (d1.hours < d2.hours) return true;
            if(d1.hours == d2.hours)
                if (d1.minutes < d2.minutes) return true;
                else
                   if(d1.minutes == d2.minutes)
                        if(d1.seconds < d2.seconds)return true;
            
            return false;

        }
        public static bool operator <=(Duration d1, Duration d2)
        {
            if (d1 == null || d2 == null) return false;

            if (d1.hours <= d2.hours) return true;
            return false;

        }
        public static bool operator >=(Duration d1, Duration d2)
        {
            if (d1 == null || d2 == null) return false;

            if (d1.hours >= d2.hours) return true;
            return false;

        }
        public static implicit operator bool (Duration D)
        { 
            if (D == null) return false;
            if(D.hours == 0 && D.minutes==0 && D.seconds==0 ) return false;
            return true;
        }
        public static explicit operator DateTime (Duration D)
        {
            return new DateTime(D.hours,D.Minutes,D.Seconds);
        }



    }
}
