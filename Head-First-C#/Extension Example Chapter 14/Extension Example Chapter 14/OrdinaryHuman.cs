using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extension_Example_Chapter_14
{
    sealed class OrdinaryHuman
    {
        private int age;
        int weight;

        public OrdinaryHuman(int weight)
        {
            this.weight = weight;
        }

        public void GoToWork() { }
        public void PayBills() { }
    }
}
