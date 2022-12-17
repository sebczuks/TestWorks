using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Media_Experten_Produkte
{
     class DabberProdukte
    {
        public int ProductID { get; set; }

        public string ProductName { get; set; }
        public string ProductProducer{ get; set; }
        public string ProductPreis { get; set; }
        public int ProduktBestand { get; set; }
        public string ProductTyp { get; set; }
        public int ProduktType { get; set; }



        public List<DabberProdukte> abberProdukte = new List<DabberProdukte>();

       
        // This Method will add values to DabberProdukteList
        public void AddValues(DabberProdukte DabbedProdukteList)
        {
            return;
        }

    }
}
