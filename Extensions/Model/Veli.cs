using Extensions.Model.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extensions.Model
{
    internal class Veli:ModelBase,IVeli
    {
        public string TelefonNo { get; set; }

        void ISql.Ekle()
        {
            Console.WriteLine("veli eklendi");
        }

        List<Veli> IVeli.Getir()
        {
            Console.WriteLine("veli getirdi");
            return new List<Veli>();
        }

        void ISql.Guncelle()
        {
            Console.WriteLine("veli güncellendi");
        }

        void ISql.Sil()
        {
            Console.WriteLine("veli silindi");
        }
    }
}
