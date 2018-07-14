using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Army_Constractor.Models
{
    public class UnitsInArmy
    {
        public virtual int UnitsInArmyID { get; set; }
        public virtual int UnitID { get; set; }
        public virtual int ArmyID { get; set; }

        public virtual Unit Unit { get; set; }
        public virtual Army Army { get; set; }
    }
}