using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateModifier
{
    public class DateModifier
    {
        public void DaysCounter(string startDate, string endDate)
        {
            DateTime StartDate = DateTime.Parse(startDate);
            DateTime EndDate = DateTime.Parse(endDate);
            TimeSpan diff = EndDate - StartDate;
            Console.WriteLine(Math.Abs(diff.Days));
        }
    }
}