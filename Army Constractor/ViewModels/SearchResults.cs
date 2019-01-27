using Army_Constractor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Army_Constractor.ViewModels
{
    public class SearchResults
    {
        public List<Armor> Armors { get; set; }
        public List<RecrutType> RecrutTypes { get; set; }
        public List<MeleeWeapon> MeleeWeapons { get; set; }
        public List<Mount> Mounts { get; set; }
        public List<RangeWeapon> RangeWeapons { get; set; }
        public List<Shield> Shields { get; set; }
        public List<Unit> Units { get; set; }
    }
}