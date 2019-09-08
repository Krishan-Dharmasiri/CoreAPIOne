using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace CoreAPIOne.Domain.Enums
{
    public class Enum
    {
        public enum EUnitOfMeasurement : byte
        {
            [Description("UN")]
            Unity=1,
            [Description("MG")]
            Milligram = 2,
            [Description("G")]
            Gram = 3,
            [Description("KG")]
            Kilogram = 4,
            [Description("L")]
            Liter = 5
        }
    }
}
