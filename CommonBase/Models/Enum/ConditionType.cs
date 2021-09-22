using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonBase.Models.Enum
{
    public enum ConditionType
    {
        PieceDiscountRelative, // Rabatt ab einer bestimmten Stückzahl
        PieceDiscountAbsolute, // Abzug ab einer bestimmten Stückzahl
        ValueDiscountRelative, // Rabatt ab einem bestimmten Bestellwert
        ValueDiscountAbsolute, // Abzug ab einem bestimmten Bestellwert
    }
}
