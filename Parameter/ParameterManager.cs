using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parameter
{
    internal class ParameterManager<T>
    {
        T[] items;
        public ParameterManager()
        {
            items = new T[0];
        }

        public void Add(T item) 
        {
            T[] tempArrayy = items;
            items = new T[tempArrayy.Length+1];
        }
    }
}
