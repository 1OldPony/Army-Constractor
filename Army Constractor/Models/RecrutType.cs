using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Army_Constractor.Models
{
    public class RecrutType
    {
        public virtual int RecrutTypeID { get; set; }
        public virtual string RecrutTypeName { get; set; }
        public virtual int RecrutTypeRank { get; set; }
        public virtual int RecrutTypeAttBonus { get; set; }
        public virtual int RecrutTypeDefBonus { get; set; }
        public virtual int RecrutTypeAbsorb { get; set; }
        public virtual int RecrutTypeArmorIgnore { get; set; }
        public virtual int RecrutTypeMove { get; set; }
        public virtual int RecrutTypeBraveryBonus { get; set; }
        public virtual string Description { get; set; }
    }
}