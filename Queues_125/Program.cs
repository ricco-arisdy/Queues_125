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
                return;
            }
            /*This following statment checks wheter the queue is empty, if the queue *
             * then the values of the REAR and FRONT variables is set to 0*/
            if (FRONT == -1)
            {
                FRONT = 0;
                REAR = 0;
            }
            else
            {
                /* if REAR is at the last position of the array, then the values of
                 REAR is set to 0 that corresponds to the frist position of the array.*/
                if (REAR == max - 1)
                    REAR = 0;
                else;
                /* if REAR is not at the last position, then its values is increented by one */
                REAR = REAR + 1;
            }
        }
        static void Main(string[] args)
        {
        }
    }
}
