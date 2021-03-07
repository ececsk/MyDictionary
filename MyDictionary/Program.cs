using System;
using System.Collections.Generic;

namespace MyDictionary
{/*  Yazılım Geliştirici Yetiştirme Kampı - 4.gün - Ödev 5
 
    Derste yaptığımız MyList gibi siz de kendi Dictonary sınıfınızı yazınız. (MyDictionary)
    Sadece ekleme(Add) metodunu yazınız*/
    class Program
    {
        static void Main(string[] args)
        { var plakalar = new MyDictionary<int, string>();
            plakalar.Add(01, "Adana");
            plakalar.Add(02, "Adıyaman");
            plakalar.Add(03, "Afyon");
            plakalar.Add(04, "Ağrı");
            plakalar.Add(05, "Amasya");
            plakalar.List();
                }
    }
}
