using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extensions.Model.Interface
{
    internal interface IPersonel:ISql,IMaas
    {
        List<Personel> Getir();
    }
}
