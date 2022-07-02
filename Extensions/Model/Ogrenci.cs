using Extensions.Model.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extensions.Model
{
    internal class Ogrenci:ModelBase,IOgrenci
    {
        public string Sinifi { get; set; }
        public Veli Velisi { get; set; }

        public void Ekle()
        {
            Console.Write(Ad+ " isimli öğrenci Eklendi");
        }

        public List<Ogrenci> Getir()
        {
            Console.WriteLine("Öğrenciler getirildi");
            return new List<Ogrenci>();
        }

        public List<Ogrenci> Getir(string SubeKodu)
        {
            Console.WriteLine(SubeKodu +" bu sınıfa ait öğrenciler getirildi.");
            return new List<Ogrenci>();
        }

        public void Guncelle()
        {
            Console.Write("Öğrenci Güncelle");
        }

        public void Sil()
        {
            Console.Write("Öğrenci Silindi");
        }

     
    }
}
