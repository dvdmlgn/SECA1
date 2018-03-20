using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodInventory_v0._1
{
    public enum State
    {
        Inventory,
        ShoppingCart,
        Recipes,
        Settings
    }

    public static class StateMachine
    {
        public static State CurrentState { get; set; }


        public static void UpdateState(object sender, EventArgs e)
        {
            // switch not implymented yet, all case values are just placeholder at the moment.
            switch(sender.GetHashCode())
            {
                case 0011:
                    CurrentState = State.Inventory;
                    break;

                case 0012:
                    CurrentState = State.ShoppingCart;
                    break;

                case 0013:
                    CurrentState = State.Recipes;
                    break;

                case 0014:
                    CurrentState = State.Settings;
                    break;
            }
        }
    }
}
