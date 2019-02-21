using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitnes.Constants
{
    public static class UnintTypes
    {
        public static Dictionary<Guid, string> UnitTypes = new Dictionary<Guid, string>
        {
            { Guid.Parse("515EADBE-09C9-4913-A262-1EC52BD5976C"), "м" },
            { Guid.Parse("A1C6759F-B8E6-4F17-A3E4-27B667B32091"), "кг"},
            { Guid.Parse("6A0F3352-BCB6-47DC-AC22-87D0BF8287EE"), "мин"},
            { Guid.Parse("0796E814-0653-4D3C-BCCE-46D48FAE9D81"), "км/ч"}
        };
    }
}
