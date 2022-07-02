using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extensions.Model
{
    internal abstract class ModelBase
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int Yas { get; set; }
        public string Cinsiyet { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime ModifedDate { get; set; }
        public string ModifedBy { get; set; }
        public DateTime DeletedDate { get; set; }
        public string DeletedBy { get; set; }
    }
}
