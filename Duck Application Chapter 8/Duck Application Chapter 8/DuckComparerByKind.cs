using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Duck_Application_Chapter_8
{
    class DuckComparerByKind : IComparer<Duck>
    {
        public int Compare(Duck x, Duck y)
        {
            if (x.Kind < y.Kind)
            {
                return -1;
            }
            if (x.Kind > y.Kind)
            {
                return 1;
            }
            else
            {
                return 0;
            }            
        }
    }
}
