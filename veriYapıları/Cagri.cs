using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace veriYapıları
{
    public class Cagri
    {
        public int CagriId { get; set; }
        public Musteri musteriTanimlayicisi { get; set; }
        public Musteri musteriTuru { get; set; }
        public MusteriTemsilcisi temsilciTanimlayicisi { get; set; }
        public string cagriNotu { get; set; }
        public DateTime baslangicZamani { get; set; }
        public DateTime bitisZamani { get; set; }
        public string cagriBilg { get; set; }

    }
}
