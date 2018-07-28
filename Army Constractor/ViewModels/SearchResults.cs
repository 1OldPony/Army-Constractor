using Army_Constractor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Army_Constractor.ViewModels
{
    public class SearchResults
    {
        public virtual List <Armor> Armors { get; set; }
        public virtual List<RecrutType> RecrutTypes { get; set; }
        public virtual List<MeleeWeapon> MeleeWeapons { get; set; }
        public virtual List<Mount> Mounts { get; set; }
        public virtual List<RangeWeapon> RangeWeapons { get; set; }
        public virtual List<Shield> Shields { get; set; }
        public virtual List<Unit> Units { get; set; }
    }
}