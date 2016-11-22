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

        //Constructor
        public HealingPotion(int id, string name, string namePlural, int amountToHeal)  :  base(id, name, namePlural) //takes the parameters from the HealingPotion class and passes them to the constructor in the Item.cs
        { 
            AmountToHeal = amountToHeal; //send the unique parameter from this class
        }
    }
}
