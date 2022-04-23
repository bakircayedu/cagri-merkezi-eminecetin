using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace veriYapıları
{
    public interface IQueue
    {
        void Insert(object o); //sona eleman ekkler
        object Remove();//kuyruğun önündeki elemanı siler
        object Peek();//kuyruğun önündeki elemanı geriye döndürür
        Boolean IsEmpty();//kuyruk boşsa true, doluysa false değeri döndürür

    }
}
