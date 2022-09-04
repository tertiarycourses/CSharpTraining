using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E004_DateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime timeNow = DateTime.Now;
            Console.WriteLine("DateTiem.Now: "+DateTime.Now);
            //show object date
            Console.WriteLine("g: "+ timeNow.ToString("d"));
            //show object time        
            Console.WriteLine("t: "+ timeNow.ToString("t"));
            //show object day 
            Console.WriteLine("Day: "+ timeNow.Day);

            // The following are the full set of formatting output
            //       https://msdn.microsoft.com/en-us/library/zdtaw1bw(v=vs.110).aspx 
            //       d: 6/15/2008
            //       D: Sunday, June 15, 2008
            //       f: Sunday, June 15, 2008 9:15 PM
            //       F: Sunday, June 15, 2008 9:15:07 PM
            //       g: 6/15/2008 9:15 PM
            //       G: 6/15/2008 9:15:07 PM
            //       m: June 15
            //       o: 2008-06-15T21:15:07.0000000
            //       R: Sun, 15 Jun 2008 21:15:07 GMT
            //       s: 2008-06-15T21:15:07
            //       t: 9:15 PM
            //       T: 9:15:07 PM
            //       u: 2008-06-15 21:15:07Z
            //       U: Monday, June 16, 2008 4:15:07 AM
            //       y: June, 2008
            //       
            //       'h:mm:ss.ff t': 9:15:07.00 P
            //       'd MMM yyyy': 15 Jun 2008
            //       'HH:mm:ss.f': 21:15:07.0
            //       'dd MMM HH:mm:ss': 15 Jun 21:15:07
            //       '\Mon\t\h\: M': Month: 6
            //       'HH:mm:ss.ffffzzz': 21:15:07.0000-07:00
        }
    }
}
