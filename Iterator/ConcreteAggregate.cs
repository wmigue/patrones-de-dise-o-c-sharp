using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    class ConcreteAggregate : IAggregate
    {
        private List<string> _lista = new List<string>();
        public ConcreteAggregate()
        {
            for (int i = 0; i < 10; i++)
            {
                _lista.Add("elemento " + (i+1));
            }
        }
        public IIterator createIterator()
        {
            return new ConcreteIterator1(_lista);
        }

    }
}
