using Extensions.Model;
using Extensions.Model.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extensions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ISql sql;
            Console.WriteLine("Eklemek istediğinizi seçiniz:");
            Console.WriteLine("1- Öğretmen, 2- Öğrenci, 3- Personel, 4- Veli");
            int secim = Convert.ToInt32(Console.ReadLine());
            if (secim == 1)
            {
                sql = new Ogretmen
                {
                    Ad = "Yüksel",
                    Soyad = "Falan",
                    Yas = 45,
                    Cinsiyet = "Erkek",
                    CreatedDate = DateTime.Now,
                    CreatedBy="Uğurcan Özcan"
                };
                sql.Ekle();
            }
            else
            {
                sql = new Ogrenci
                {
                    Ad = "Test",
                    Soyad = "Test",
                    CreatedBy = "Fatma",
                    CreatedDate = DateTime.Now,
                };
                sql.Ekle();
            }


            Console.ReadLine();
        }
    }
}
