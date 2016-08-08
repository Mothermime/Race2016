using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Race2016
{
   public static class Factory
    {
        public static int BackerNumber;
        public static Sovereigns ChooseSovereign(string ID)
        {
            switch (ID)
            {
                case "King Esurience":
                    BackerNumber = 0;
                    return new Esurience();

                case "Queen Cupidity":
                    BackerNumber = 1;
                    return new Cupidity();
                case "King Rapacity":
                    BackerNumber = 2;
                    return new Rapacity();
            }
            return new Esurience();
        }
        public static int  ShipNumber;
        public static Shipping ChooseShip(string ShipID)
        {
            switch (ShipID)
            {
                case "Sapphire":
                    ShipNumber = 0;
                    return new Sapphire();
                case "Ruby":
                    ShipNumber = 1;
                    return new Ruby();
                case "Emerald":
                    ShipNumber = 2;
                    return new Emerald();
                case "Topaz":
                    ShipNumber = 3;
                    return new Topaz();
            }
            return new Sapphire();
        }
    }
}
