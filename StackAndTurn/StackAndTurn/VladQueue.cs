using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndTurn
{
    class VladQueue <TElement>
    {
        public VladQueue()
        {
            queue = new TElement[8];
        }
        private int index;
        private int indexFirst;
        private TElement[] queue;
        public void Enqueue(TElement num)
        {
            if(queue.Length <= index)
            {
                Array.Copy(queue, 0, queue = new TElement[queue.Length * 2], 0, queue.Length / 2);
            }
            queue[index] = num;
            index++;
        }
        public TElement Dequeue()
        {
            if(index <= 1)
            {
                throw new IndexOutOfRangeException("Index < 0");
            }
            else if(index <= indexFirst * 2)
            {
                Array.Copy(queue, indexFirst, queue = new TElement[queue.Length / 2], 0, queue.Length);
                index -= indexFirst;
                indexFirst = 0;
            }
            TElement num = queue[indexFirst];
            queue[indexFirst] = default(TElement);
            indexFirst++;
            return num;
        }
    }
}
