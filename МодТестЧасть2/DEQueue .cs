using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace МодТестЧасть2
{
    public class Num<str>
    {
        public Num(str data)
        {
            Data = data;
        }
        public str Data { get; set; }
        public Num<str> Next { get; set; }
        public Num<str> Prev { get; set; }
    }

    public class DEQueue<str>
    {

        Num<str> first;
        Num<str> last;
        int count;

        public void pushBack(str data)
        {
            Num<str> node = new Num<str>(data);
            Num<str> temp = last;
            last = node;
            if (count == 0)
                first = last;
            else
            {
                temp.Next = last;
                last.Prev = temp;
            }
            count++;
        }

        public void pushFront(str data)
        {
            Num<str> node = new Num<str>(data);
            Num<str> temp = first;
            first = node;
            if (count == 0)
                last = first;
            else
            {
                temp.Prev = first;
                first.Next = temp;
            }
            count++;
        }

        public str front()
        {
            if (count != 0)
            {
                return first.Data;
            }
            else
                throw new InvalidOperationException();
        }
        public str back()
        {
            if (count != 0)
            {
                return last.Data;
            }
            else
                throw new InvalidOperationException();
        }
        public int size()
        {
            return count;
        }
        public void clear()
        {
            count = 0;
        }
        public str popFront()
        {
            if (count == 0)
                throw new InvalidOperationException();
            str output = first.Data;
            first = first.Next;
            count--;
            return output;
        }
        public str popBack()
        {
            if (count == 0)
                throw new InvalidOperationException();
            str output = last.Data;
            last = last.Prev;
            count--;
            return output;
        }


        public str[] toArray()
        {
            if (count == 0)
                throw new InvalidOperationException();
            str[] output = new str[count];
            Num<str> temp = first;
            for (int i = 0; i < count; i++)
            {
                output[i] = temp.Data;
                temp = temp.Next;
            }
            return output;
        }



    }
}
