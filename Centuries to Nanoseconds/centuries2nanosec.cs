using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centuries_to_Nanoseconds
{
    class centuries2nanosec
    {
        static void Main(string[] args)
        {
             byte centuries = byte.Parse(Console.ReadLine());
            int years = (int)(centuries * 100);
            int days = (int)(years * 365.2422);
            uint hours = (uint)(24 * days);
            ulong minutes = (ulong)(60 * hours);
            ulong seconds = (ulong)(60 * minutes);
            ulong milliseconds = (ulong)(1000 * seconds);
            decimal microseconds = (decimal)(1000 * milliseconds);
            decimal nanoseconds = (decimal)(1000 * microseconds);

            Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes = {seconds} seconds = {milliseconds} milliseconds = {microseconds} microseconds = {nanoseconds} nanoseconds");
        }
    }
}
