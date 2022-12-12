using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queues_125
{
    class Program
    {
        int FRONT, REAR, max = 5;
        int[] queues_array = new int[5];

        public Program()
        {
            /*initializing the values of the variables REAR and FRONT to -1 to idicate that
             *  the queues is initialy empty.*/
            FRONT = -1;
            REAR = -1;
        }
        public void insert(int element)
        {
            /*This statment checks for the overlow condition */
            if ((FRONT == 0 &&  REAR ==  max -1 ) || (FRONT == REAR +1))
            {
                Console.WriteLine("\nQueue overlow\n");
            }
        }
        static void Main(string[] args)
        {
        }
    }
}
