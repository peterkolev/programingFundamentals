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
            //Console.Write("Centuries = ");
            int centuries = int.Parse(Console.ReadLine());
            int years = centuries * 100;
            int days = (int)(years * 365.2422);
            int hours = days * 24;
            int minutes = hours * 60;
            long seconds = (long)minutes * 60;
            long miliseconds = seconds * 1000;
            long microseconds = miliseconds * 1000;
            ulong nanoseconds = (ulong)microseconds * 1000;



            Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes = {seconds} seconds = {miliseconds} miliseconds = {microseconds} microseconds = {nanoseconds} nanoseconds");
        }
    }
}
