using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XML_DataReading.Models
{
    public class Product
    {
        public string UrunID { get; set; }

        public string UrunAdi { get; set; }

        public string Kod { get; set; }

        public string Fiyat { get; set; }

        public string ListFiyat { get; set; }

        public string KdvOran { get; set; }

        public string Marka { get; set; }

        public string Aciklama { get; set; }

        public string ImageName { get; set; }

        public string Kategori { get; set; }

        public string Renk { get; set; }

        public string Stoklar { get; set; }

    }
}
