using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EXE5_152_KELOMPOK4
{
    class Node
    {
        public string val;
        public Node next;
    }
    class queue
    {
        //OSAMAH = HEAD(FRONT) / AL_Mekhlafi = Tail(END)
        Node OSAMAH, AL_Mekhlafi;

        public queue()
        {
            OSAMAH = null;
            AL_Mekhlafi = null;
        }
        public void Enter()
        {
            string data;
            Node newnode = new Node();
            Console.WriteLine("\nEnter data:");
            data = Console.ReadLine();
            newnode.val = data;
            newnode.next = null;
            if (OSAMAH == null)
            {
                OSAMAH = newnode;
                AL_Mekhlafi = newnode;
                return;
            }
            AL_Mekhlafi.next = newnode;
            AL_Mekhlafi = newnode;
        }
        public void delete()
        {
            if (OSAMAH == null)
            {
                Console.WriteLine("\nQueue is empty");
                return;
            }
            Console.WriteLine("\n Data deleted is:  " + OSAMAH.val);
            OSAMAH = OSAMAH.next;
            if (OSAMAH == null)
                AL_Mekhlafi = null;
        }
        public void display()
        {
            if (OSAMAH == null)
            {
                Console.WriteLine("\nQueue is empty");
                return;
            }
            Node display;
            int count = 1;
            for (display = OSAMAH; display != null; display = display.next)
                Console.WriteLine("\nData number [" + (count++) + "] is :" + display.val);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            queue Q = new queue();
            char ch;
            while (true)
            {



            }
        }
    }
}
