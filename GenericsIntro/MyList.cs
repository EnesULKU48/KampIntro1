using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T>
    {  // T  istediğim elemanın türü

        T[] items;

        //constructer   new lediğimde kaçıncı elamandan başlayacak
        public MyList()
        {
            items = new T[0];         
        }

        public void Add(T item)
        {
            T[] tempArray = items; //geçici array  referansı emanet ettik
            items = new T[items.Length+1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }

            items[items.Length - 1] = item;
        }
    }
}
