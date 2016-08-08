
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Race2016
{
   public abstract class Sovereigns
    {
        public string Name { get; set; }
        public int Gold { get; set; }
        public int AmountPromised { get; set; }
        public PictureBox MyPictureBox = null;
    }

    class Esurience : Sovereigns
    {
        public Esurience()
        {
            Name = "King Esurience";
            Gold = 50;
            AmountPromised = 0;
           
        }
    }
    class Cupidity : Sovereigns
    {
        public Cupidity()
        {
            Name = "Queen Cupidity";
            Gold = 50;
            AmountPromised = 0;

        }
    }
    class Rapacity : Sovereigns
    {
        public Rapacity()
        {
            Name = "King Rapcity";
            Gold = 50;
            AmountPromised = 0;

        }
    }
}
