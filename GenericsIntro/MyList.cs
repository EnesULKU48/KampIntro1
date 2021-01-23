using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T>
    {  // T  istediğim elemanın türü

        T[] items;

        //constructer - classı new lediğimde bu metot otomatik çalışır - kaçıncı elamandan başlayacak
        public MyList()
        {
            items = new T[0];         
        }

        public void Add(T item)
        {
            T[] tempArray = items; //geçici array  referansı emanet ettik
            items = new T[items.Length+1];
            for (int i = 0; i < tempArray.Length; i++) //for ile emanet ettiğimizi, new lenmiş arraye geri koyduk
            {
                items[i] = tempArray[i];
            }

            items[items.Length - 1] = item; //gönderdiğimiz elemanı son açılan yere koy
        }
    }
}
