using DataBase_01.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase_01
{
    interface IEszköz
    {
        DateTime dateid { get; set; }
        string marka { get; set; }
        string tipus { get; set; }
        string tartozek { get; set; }
        bool hordozhato { get; set; }
        bool repairNew { get; set; }
        string megjegyzes { get; set; }
    }
}
