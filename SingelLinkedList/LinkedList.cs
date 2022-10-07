using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class LinkedList
    {
        Node firstint = null;
        Node lastint = null;
        int count = 0;
      

        public void addlast(Node newNode)
        {
            if (firstint == null)
            {
                firstint = newNode;
                lastint = newNode;
            }
            else
            {
                lastint.next = newNode;
                lastint = newNode;
            }
            count++;
        }
        public void addfirst(Node newNode)
        {
            if (firstint == null)
            {
                firstint = newNode;
            }
            else
            {
                firstint.next = newNode;
                firstint = newNode;
            }
            count++;
        }


        public void deletelast()
        {
            if (firstint == null)
            {
                Console.WriteLine("false");
            }
            else
            {
                if (firstint != lastint)
                {
                    firstint = firstint.next;
                }

                else
                {
                    firstint = lastint = null;
                }
                count--;
            }
        }
        

        public int size()
        { return count; }

        public void GetNode(int argData, int data)
        {
            if (argData == data)
            {
                return;
            }
            else
            {
                Console.WriteLine("null");
            }
        }
    }
}
