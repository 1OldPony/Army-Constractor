using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Army_Constractor.Models
{
    public class Army
    {
        public virtual int ArmyID { get; set; }
        public virtual string ArmyName { get; set; }
        public virtual string Description { get; set; }

        public virtual List<UnitsInArmy> UnitsInArmies { get; set; }
    }
}