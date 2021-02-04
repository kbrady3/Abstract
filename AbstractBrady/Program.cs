//Big O: O(N)
/**************************************************************
* Name        : AbstractBrady
* Author      : Kabrina Brady
* Created     : 1/27/2021
* Course      : Data Structures
* Version     : 1.0
* OS          : Windows 10
* Copyright   : This is my own original work based on
*               specifications issued by our instructor
* Academic Honesty: I attest that this is my original work.
* I have not used unauthorized source code, either modified or 
* unmodified. I have not given other fellow student(s) access to
* my program.         
***************************************************************/

using AbstractBrady.Models;
using System;

namespace AbstractBrady
{
    class Program
    {
        static void Main(string[] args)
        {
            Bicycle b = new Bicycle(2, 2);

            Console.WriteLine(b.CycleDetails());
            Console.WriteLine(b.Ride());
            Console.WriteLine(b.Stop());
        }
    }
}
