using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Race2016
{
  public abstract class Shipping
    {
        public string Name { get; set; }
        public  int PathCounter { get; set; }
        public int PiratePathCounter { get; set; }
        public abstract List<string> ShipPath { get; set; }
        public abstract List<string> PiratePath { get; set; }
        public PictureBox MyPictureBox = null;
        public int Location = 0;
        public Random Randomizer;
        public int StartingPosition;
        
        //{
        //string shipdata = ShipPath[PathCounter];
        ////split the path into left and top  
        //string[] moreshipdata = shipdata.Split(',');

        ////attach to picturebox

        ////count through path
        //PathCounter += 1;
        // }
    }
    public interface IShipping
    {
        void SetSail();
        void FindTreasure();
    }  
    
}
