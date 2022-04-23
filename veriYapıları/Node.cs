using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace veriYapıları
{
    public class Node
    {
       public int data;
        public Node next;
        public object o;

        public Node(int data)
        {

            this.data = data;
            this.next = null;
        }
        public Node (object o)
        {
            this.o = o;
            this.next = null;
        }
    }
}
