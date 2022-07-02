using Extensions.Model.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extensions.Model
{
    internal class Personel : ModelBase,IPersonel
    {
        public string Meslek { get; set; }
        public string TelefonNo { get; set; }

        void ISql.Ekle()
        {
            Console.WriteLine("Personel Eklendi");
        }

        List<Personel> IPersonel.Getir()
        {
            Console.WriteLine("Personel Getirdi");
            return new List<Personel>();

        }

        void IMaas.Gor()
        {
            throw new NotImplementedException();
        }

        void ISql.Guncelle()
        {
            Console.WriteLine("Personel Güncellendi");
        }

        void IMaas.Ode()
        {
            throw new NotImplementedException();
        }

        void ISql.Sil()
        {
            Console.WriteLine("Personel Silindi");
        }

        void IMaas.Sil()
        {
            throw new NotImplementedException();
        }

        void IMaas.ZamYap()
        {
            throw new NotImplementedException();
        }
    }
}
