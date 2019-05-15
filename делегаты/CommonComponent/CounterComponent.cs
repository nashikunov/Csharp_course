using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonComponent {
    public class CounterComponent {
        private int _counter;

        public event Action<int> CounterChanged;

        public void IncreaseCounter() {
            _counter++;
            CounterChanged?.Invoke(_counter);
        }
    }
}
