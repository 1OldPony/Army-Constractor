using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Army_Constractor.Models
{
    public class UnitsInArmy
    {
        public virtual int UnitsInArmyID { get; set; }
        public virtual List<Unit> Units { get; set; }
    }
}