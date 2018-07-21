using Army_Constractor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Army_Constractor.ViewModels
{
    public class ShieldsIndexModel
    {
        public List<Shield> Shields { get; set; }
        public int? Price { get; set; }
    }
}