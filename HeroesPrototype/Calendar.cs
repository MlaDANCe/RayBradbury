using System;
using System.Linq;

namespace HeroesPrototype
{
    public class Calendar
    {
        private int day = 0;
        
        public int Day
        {
            get
            {
                return this.day;
            }
            set
            {
                this.day = value;
            }
        }

        public int WeekDay
        {
            get { return this.Day % 7 + 1; }
        }

        public int Week
        {
            get { return this.Day / 7 % 4 + 1; }
        }

        public int Month 
        {
            get { return this.Day / 28 + 1; } 
        }
    }
}
