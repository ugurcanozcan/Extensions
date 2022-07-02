using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extensions.Model.Interface
{
    internal interface IOgrenci : ISql
    {
        List<Ogrenci> Getir();
        List<Ogrenci> Getir(string SubeKodu);
    } 
}
