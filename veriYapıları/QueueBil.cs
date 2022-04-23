using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace veriYapıları
{
    public class QueueBil : IQueue
    {
        Node front; //kuyruğun başındaki elemanı tutacak
        Node rear; //kuyruğun sonundaki elemanı tutacak

        public QueueBil()
        {
            this.front = null;
            this.rear = null;
        }

        public void Insert(object o) //sona eleman ekler
        {
            Node eleman = new Node(o);
            if (front == null)
            {
                front = rear = eleman;
            }
            else
            {
                rear.next = eleman;
                rear = eleman;
            }
            

        }
        public void Insert(int data) //sona eleman ekler
        {
            Node eleman2 = new Node(data);
            if (front == null)
            {
                front = rear = eleman2;
            }
            else
            {
                rear.next = eleman2;
                rear = eleman2;
            }
            

        }

        public bool IsEmpty()//kuyruk boşsa true, doluysa false döndürür
        {
            return front == null || rear == null;
        }

        public object Peek()//kuyruğun önündeki elemanı geriye döndürür
        {
            throw new NotImplementedException();
        }

        public object Remove()//kuyruğun önündeki elemanı siler
        {
            if(front == null)
            {
                return -1;

            }
            else
            {
                object data = front.data;
                front = front.next;
                front = front.next;
                return data;
            }
        }
        public void print()
        {
            if (front == null)
                MessageBox.Show("Kuyruk boş");
            else
            {
                Node temp=front;
                //baş kısım
                while (temp != null)
                {
                    MessageBox.Show(temp.data + " ");
                    temp = temp.next;
                }
                //son kısım
            }
        }
    }
   
}
