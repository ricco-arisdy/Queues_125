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
            /* if REAR is not at the last position, then element is added at it's proper place */
            queues_array[REAR] = element;
        }
        public void remove()
        {
            /*Checks wheather the queue is empty. */
            if (FRONT == -1)
            {
                Console.WriteLine("Queue underflow\n");
                return;
            }
            Console.WriteLine("\n The element deleted from the queue is: " + queues_array[FRONT] + "\n");
            
            /*Check if the queue has one element.*/
            if (FRONT == REAR)
            {
                FRONT = -1;
                REAR = -1;
            }
            else
            {
                /* if the element to be deleted is at the last position of the array, then the value
                 * of FRONT is set to 0 i.e to the first element of the array. */
                if (FRONT == max - 1)
                    FRONT = 0;
                else
                    /*FRONT is incremented by one if it is not the first element of array. */
                    FRONT = FRONT + 1;
            }
        }

        public void display()
        {
            int FRONT_position = FRONT;
            int REAR_position = REAR;
        }
        static void Main(string[] args)
        {
        }
    }
}
