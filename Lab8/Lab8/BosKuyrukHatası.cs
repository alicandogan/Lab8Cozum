using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab8
{
    class BosKuyrukHatası:Exception
    {
        public BosKuyrukHatası()
        {
            Console.WriteLine("Eleman içermeyen kuyrukta silme işlemi yapılamaz");
        }
    }
}
