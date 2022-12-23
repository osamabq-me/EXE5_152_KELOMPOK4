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
                try
                {
                    Console.WriteLine("\n*******Menu*******");
                    Console.WriteLine("1. Enter   Data");
                    Console.WriteLine("2. Delete  Data");
                    Console.WriteLine("3. Display Data");
                    Console.WriteLine("4. Exit");
                    Console.Write("\nEnter your choice: ");
                    ch = Convert.ToChar(Console.ReadLine());
                    Console.WriteLine();
                    switch (ch)
                    {
                        case '1':
                            Q.Enter();
                            break;
                        case '2':
                            Q.delete();
                            break;
                        case '3':
                            Q.display();
                            break;
                        case '4':
                            Console.WriteLine("\nThanks for using my program");
                            Thread.Sleep(2000);
                            return;
                        default:
                            Console.WriteLine("Invalid Option");
                            break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Check for the value entered.");
                }


            }
        }
    }
}
