using System;
using System.Collections.Generic;
using System.Text;

namespace pascal
{
    class Birthday
    {
        string name;
        int year, month, day;
        public Birthday(string name, int y, int m, int d)
        {
            this.name = name;
            year = y; month = m; day = d;
        }
        DateTime Date
        {
            get { return new DateTime(year, month, day); } 
        }
        public string Information
        {
            get
            {
                return name + " , birthdate " + day + ":" + month + ":" + year;
            }
        }
    }
}
