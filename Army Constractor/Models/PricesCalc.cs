using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Army_Constractor.Models
{
    public partial class PricesCalc
    {
        private ArmyConstractorDB db = new ArmyConstractorDB();

        string ShieldPriceId { get; set; }
        public const string ShieldSessionKey = "ShieldId";

        public static PricesCalc GetShieldPrice(HttpContextBase context)
        {
            var shieldPrice = new PricesCalc();
            shieldPrice.ShieldPriceId = shieldPrice.GetPriceId(context);
            return shieldPrice;
        }

        public string GetPriceId(HttpContextBase context)
        {
            if (context.Session[ShieldSessionKey] == null)
            {
                if (!string.IsNullOrWhiteSpace(context.User.Identity.Name))
                {
                    context.Session[ShieldSessionKey] = context.User.Identity.Name;
                }
                else
                {
                    // Generate a new random GUID using System.Guid class
                    Guid tempCartId = Guid.NewGuid();
                    // Send tempCartId back to client as a cookie
                    context.Session[ShieldSessionKey] = tempCartId.ToString();
                }
            }
            return context.Session[ShieldSessionKey].ToString();
        }
        
        public List<Shield> GetShields()
        {
            return db.Shields.ToList();
        }


        public int? ShieldPrice()
        {
            int? ShieldDef = db.Shields
                                .Where(c => c.ShieldID.ToString() == ShieldPriceId)
                                .Select(c => (int?)c.ShieldDefBonus).Sum();
            int? price = ShieldDef * 5;
            return price ?? 0;
        }




    }

    
}
