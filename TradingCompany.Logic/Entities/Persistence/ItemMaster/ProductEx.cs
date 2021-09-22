using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradingCompany.Logic.Entities.Persistence.ItemMaster
{
    partial class Product
    {
        public override string ToString()
        {
            return $"{Number}-{Name}-{Price}";
        }
    }
}
