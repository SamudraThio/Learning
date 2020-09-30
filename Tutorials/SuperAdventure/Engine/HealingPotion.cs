using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class HealingPotion : Item
    {
        public int AmountToHeal { get; set; }

        public HealingPotion(int id, string name, string NamePlural, int amountToHeal) 
                      : base(id, name, NamePlural)
        {
            AmountToHeal = amountToHeal;
        }
    }
}
