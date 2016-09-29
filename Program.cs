using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListSlide34HW
{
    class Program
        {
            static void Main(string[] args)
            {
                // Create a list for true/false
                //decide is true/false
                //print out
                List<bool> boolList = new List<bool>() { true, false, false, true, false };

                // Go through each to decide true-false
                foreach (bool element in boolList)
                {
                    if (element == true)
                    {
                        Console.WriteLine("Better bring an umbrella");
                    }
                    else
                    {
                        Console.WriteLine("No rain today, enjoy the sunshine!");
                    }
                }
            }
        }
    }