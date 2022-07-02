using Extensions.Model.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extensions.Model
{
    internal class Ogretmen : ModelBase,IOgretmen
    {
        public string Brans { get; set; }
        public string TelefonNo { get; set; }

        void ISql.Ekle()
        {
            Console.WriteLine(Ad+ " isimli öğretmen eklendi");
        }

        List<Ogretmen> IOgretmen.Getir()
        {
            Console.WriteLine("öğretmen getirdi");
            return new List<Ogretmen>();
        }

        void IMaas.Gor()
        {
            throw new NotImplementedException();
        }

        void ISql.Guncelle()
        {
            Console.WriteLine("öğretmen güncellendi");
        }

        void IMaas.Ode()
        {
            throw new NotImplementedException();
        }

        void ISql.Sil()
        {
            Console.WriteLine("öğretmen silindi");
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
