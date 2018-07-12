using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Army_Constractor.Models
{
    public class BaseUnit
    {
        public virtual int BaseUnitID { get; set; }
        public virtual string BaseUnitName { get; set; }
        public virtual int BaseUnitRank { get; set; }
        public virtual int BaseUnitAttBonus { get; set; }
        public virtual int BaseUnitDefBonus { get; set; }
        public virtual int BaseUnitAbsorb { get; set; }
        public virtual int BaseUnitArmorIgnore { get; set; }
        public virtual int BaseUnitMove { get; set; }
        public virtual int BaseUnitBraveryBonus { get; set; }
        public virtual string Description { get; set; }
    }
}