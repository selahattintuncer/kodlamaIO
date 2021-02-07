using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T>
    {
        T[] items;
        public MyList()                                     // buna constructer denilir "ctor" tab tab ile otomatik yazılır. 
        {
            items = new T[0];
        }
        public void Add(T item) 
        {
            T[] tempArray = items;                          //tempArray geçici dizi demek. 
            items = new T[items.Length+1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }

            items[items.Length - 1] = item;

        }
    }

}
