using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib
{
    public class Product
    {
        public int Id { get; set; }
        public string NameProduct { get; set; }
        public string TypeProd { get; set; }
        public string SupplierProd { get; set; }
        public string QuantityProduct { get; set; }
        public double CostPriceProduct { get; set; }
        public DateTime DateDeliveryProduct { get; set; }
    }
}
