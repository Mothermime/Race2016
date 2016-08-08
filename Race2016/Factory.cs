using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Race2016
{
   public static class Factory
    {
        public static Sovereigns ChooseSovereign(int ID)
        {
            switch (ID)
            {
                case 0:
                    return new Esurience();

                case 1:
                    return new Cupidity();
                case 2:
                    return new Rapacity();
            }
            return new Esurience();
        }
        public static Shipping ChooseShip(int ShipID)
        {
            switch (ShipID)
            {
                case 0:
                    return new Sapphire();
                case 1:
                    return new Ruby();
                case 2:
                    return new Emerald();
                case 3:
                    return new Topaz();
            }
            return new Sapphire();
        }
    }
}
