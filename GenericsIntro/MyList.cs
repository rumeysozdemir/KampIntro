using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{ // generikler calısacağım bi tip varsa add gibi add in içine elemanlar eklemek istiyorum fakat onun newlenme zorunluluğu var bir class newlendiğinde calısan bloğa constructor deniyor
    class MyList<T>
    
    {
        T[] items;
        //constructor ctor tab tab
        public MyList() //classı newlersek bu otomatik calışıyo newledim arrayi oluşturdum 0 elemanlı olarak verdim
        {
            items = new T[0]; //elimde 0 elemanlı dizim var
        }
        //metodun dışında yazdığım bir değişken direkt classın içinde olduğu için burdan da metoda erişebilirim diğer metodlarda erişebilir
        public void Add(T item)  //arka planda T string oluyor. programcs de string dedim
        {
            T[] tempArray = items; //geçici dizinin referansı itemsın referansı elemanları kaybolacak diye korkmuyorum newlediğimde geçiçi olarak emanet ettim ref nosunu başkasına tutturuyorum
            items = new T[items.Length + 1];  //eleman sayımı 1 arttırmam gerekiyor uzunluğunu yazıcam ve 1 eklicem mevcutta eleman sayın kaçsa onu 1 arttır dinamik yapmış oluyorum

            //şimdi diyelimki sana emanet ettiğim itemları bana geri versene
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i]; //emanet verdiğim değerleri sırasıyla kendi üzerime- itemsa geri alıyorum
            }

            items[items.Length - 1] = item;        //6 elemanlı ise index 6-1 5. indeks olur son kalan eklediğimizi nasıl yazarız
        }
        public int Length
        {    //eleman sayısını verir
            get { return items.Length; }
        }
        public T[] Items
        {
            get { return items; }  // elemanları okur
        }

    }

}
