using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComponentInteraction
{
    public class ClickCounter
    {
        int _count = 0;
        public event ClickCounterCallback OnCounterChanged;


        public void IncreaseCounter()
        {
            _count++;
            OnCounterChanged?.Invoke(_count);
        }
    }
}
