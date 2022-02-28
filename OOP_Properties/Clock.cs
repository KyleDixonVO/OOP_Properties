using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Properties
{
    class Clock
    {
        private int _month = 2;
        private int _year = 2022;
        private int _day = 28;
        private bool _isLeapYear;
        private bool _isFebruary;
        private bool _hasThirtyDays;
        private int _second = 0;
        private int _minute;
        private int _hour;

        public bool HasThirtyDays
        {
            get => _hasThirtyDays;
            set
            {
                if (Month == 4 || Month == 6 || Month == 9 || Month == 11)
                {
                    _hasThirtyDays = true;
                }
                else
                {
                    _hasThirtyDays = false;
                }
            }
        }

        public bool IsFebruary
        {
            get => _isFebruary;
            set
            {
                if (Month == 2)
                {
                    _isFebruary = true;
                }
                else
                {
                    _isFebruary = false;
                }
            }
        }

        public bool IsLeapYear
        {
            get => _isLeapYear;
            set
            {
                bool test;
                int input = Year / 4;
                int outValue;
                test = int.TryParse(input.ToString(), out outValue);
                if (test == true)
                {
                    _isLeapYear = true;
                }
                else
                {
                    _isLeapYear = false;
                }
            }
        }

        public int Second
        {
            get => _second;
            set
            {
                if ((value >=0) && (value <= 60))
                {
                    _second = value;
                }
            }
        }

        public int Minute
        {
            get => _minute;
            set
            {
                if ((value >=0) && (value <= 60))
                {
                    _minute = value;
                }
            }
        }

        public int Hour
        {
            get => _hour;
            set
            {
                if ((value >= 0) && (value <= 24))
                {
                    _hour = value;
                }
            }
        }

        public int Month
        {
            get => _month;
            set
            {
                if ((value >= 1) && (value <= 12))
                {
                    _month = value;
                }
            }
        }

        public int Day
        {
            get => _day;
            set
            {
                if ((value >= 1) && (value <= 31) && !IsFebruary && !HasThirtyDays)
                {
                    _day = value;
                }
                else if ((value >=1) && (value <= 30) && !IsFebruary)
                {
                    _day = value;
                }
                else if((value >= 1) && (value <= 28) && (!IsLeapYear))
                {
                    _day = value;
                }
            }
        }

        public int Year
        {
            get => _year;
            set
            {
                if ((value >= 2022) && (value < int.MaxValue))
                {
                    _year = value;
                }
            }
        }

        public void SetTimeAndDate()
        {
            SetYear();
            SetMonth();
            SetDay();
            SetHour();
            SetMinute();
            SetSecond();
            Console.WriteLine("Date: " + Month + "/" + Day + "/" + Year + " Time: " + Hour + ":" + Minute + ":4" + Second);
            Console.ReadKey(true);
        }

        public void SetYear()
        {
            string input;
            bool isInt;
            Console.WriteLine();
            Console.WriteLine("Please input current year.");
            input = Console.ReadLine();
            isInt = int.TryParse(input, out int resultYear);
            if (isInt == true)
            {
                Year = resultYear;
            }
            else
            {
                Console.WriteLine("Please enter an integer");
                Console.ReadKey(true);
                SetYear();
            }
        }

        public void SetMonth()
        {
            string input;
            bool isInt;
            Console.WriteLine();
            Console.WriteLine("Please input current month. (1 - 12)");
            input = Console.ReadLine();
            isInt = int.TryParse(input, out int resultMonth);
            if (isInt == true)
            {
                Month = resultMonth;
            }
            else
            {
                Console.WriteLine("Please enter an integer");
                Console.ReadKey(true);
                SetMonth();
            }
        }

        public void SetDay()
        {
            string input;
            bool isInt;
            Console.WriteLine();
            Console.WriteLine("Please input current day.");
            input = Console.ReadLine();
            isInt = int.TryParse(input, out int resultDay);
            if (isInt == true)
            {
                Day = resultDay;
            }
            else
            {
                Console.WriteLine("Please enter an integer");
                Console.ReadKey(true);
                SetDay();
            }
        }

        public void SetHour()
        {
            string input;
            bool isInt;
            Console.WriteLine();
            Console.WriteLine("Please set current hour (0 - 24).");
            input = Console.ReadLine();
            isInt = int.TryParse(input, out int resultHour);
            if (isInt == true)
            {
                Hour = resultHour;
            }
            else
            {
                Console.WriteLine("Please enter an integer");
                Console.ReadKey(true);
                SetHour();
            }
        }

        public void SetMinute()
        {
            string input;
            bool isInt;
            Console.WriteLine();
            Console.WriteLine("Please input current minute.");
            input = Console.ReadLine();
            isInt = int.TryParse(input, out int resultMinute);
            if (isInt == true)
            {
                Minute = resultMinute;
            }
            else
            {
                Console.WriteLine("Please enter an integer");
                Console.ReadKey(true);
                SetMinute();
            }
        }

        public void SetSecond()
        {
            string input;
            bool isInt;
            Console.WriteLine();
            Console.WriteLine("Please input current second. Set to zero if unsure");
            input = Console.ReadLine();
            isInt = int.TryParse(input, out int resultSecond);
            if (isInt == true)
            {
                Second = resultSecond;
            }
            else
            {
                Console.WriteLine("Please enter an integer");
                Console.ReadKey(true);
                SetSecond();
            }
        }


    }
}
