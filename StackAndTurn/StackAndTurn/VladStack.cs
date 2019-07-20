using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndTurn
{
    class VladStack<TElement>
    {
        public VladStack()
        {
            stack = new TElement[8];
        }
        private TElement[] stack;
        private int peak;
        public void Push(TElement num)
        {
            if(stack.Length <= peak)
            {
                Array.Copy(stack, 0, stack = new TElement[stack.Length * 2], 0, stack.Length/2);
            }
            stack[peak] = num;
            peak++;
        }
        public TElement Pop()
        {
            if (peak <= 0)
            {
                throw new IndexOutOfRangeException("Pick < 0");
            }
            else if(stack.Length > peak * 4)
            {
                Array.Copy(stack, 0, stack = new TElement[stack.Length / 2], 0, stack.Length/2);
            }
            peak--;
            var lustPeak = stack[peak];
            stack[peak] = default(TElement);
            return lustPeak;
        }
    }
}
