using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace Race2016
{
    class Sapphire : Shipping, IShipping
    {



        public override List<string> ShipPath { get; set; }
        public override List<string> PiratePath { get; set; }
       

        public Sapphire()
        {
            Name = "Sapphire";
            PirateName = "Capt. Blubeard";
            ShipPath = SapphireSail();
            PiratePath = BlueBeard();

        }


     


        public List<string> SapphireSail()

        {
            List<string> ShipPath = new List<string>();

            ShipPath.Add("1217, 0");
            ShipPath.Add("1182,18");
            ShipPath.Add("1126,33");
            ShipPath.Add("1080,40");
            ShipPath.Add("1035,47");
            ShipPath.Add("992,40");
            ShipPath.Add("941,44");
            ShipPath.Add("895,45");
            ShipPath.Add("851,48");
            ShipPath.Add("806,49");
            ShipPath.Add("761,57");
            ShipPath.Add("716,53");
            ShipPath.Add("672,53");
            ShipPath.Add("626,57");
            ShipPath.Add("587,64");
            ShipPath.Add("544,75");
            ShipPath.Add("502,98");
            ShipPath.Add("458,122");
            ShipPath.Add("417,150");
            ShipPath.Add("384,187");
            ShipPath.Add("350,220");
            ShipPath.Add("331,266");
            ShipPath.Add("321,314");
            ShipPath.Add("310,365");
            ShipPath.Add("316,414");
            ShipPath.Add("324,463");
            ShipPath.Add("340,511");
            ShipPath.Add("357,556");
            ShipPath.Add("396,591");
            ShipPath.Add("438,619");
            ShipPath.Add("482,630");
            ShipPath.Add("526,630");
            ShipPath.Add("570,629");
            ShipPath.Add("616,639");
            ShipPath.Add("660,629");
            ShipPath.Add("704,626");
            ShipPath.Add("744,614");
            ShipPath.Add("780,597");
            ShipPath.Add("819,571");
            ShipPath.Add("859,545");
            ShipPath.Add("889,508");
            ShipPath.Add("903,463");
            ShipPath.Add("910,413");
            ShipPath.Add("903,365");
            ShipPath.Add("887,318");
            ShipPath.Add("855,274");
            ShipPath.Add("809,260");
            ShipPath.Add("765,275");
            ShipPath.Add("725,300");
            return ShipPath;


        }
        public List<string> BlueBeard()
        {
            List<string> PiratePath = new List<string>();
            PiratePath.Add("748,337");
            PiratePath.Add("756,360");
            PiratePath.Add("744,375");
            PiratePath.Add("729,368");
            PiratePath.Add("718,353");
            PiratePath.Add("703,338");
            PiratePath.Add("705,317");
            PiratePath.Add("716,300");
            PiratePath.Add("720,279");
            PiratePath.Add("705,261");
            PiratePath.Add("689,249");
            PiratePath.Add("672,243");
            PiratePath.Add("655,247");
            
            return PiratePath;
        }
        public void SetSail()
        {
            //string shipdata = ShipPath[PathCounter];
            ////split the path into left and top  
            //string[] moreshipdata = shipdata.Split(',');

            //attach to picturebox
            //pbBlue.Left = Convert.ToInt16(moreshipdata[0]);
            //pbBlue.Top = Convert.ToInt16(moreshipdata[1]);
            //count through path
            //PathCounter += 1;
        }
        public void FindTreasure()
        {
            //string piratedata = PiratePath[PiratePathCounter];
            //string[] morepiratedata = piratedata.Split(',');
        }

    }
}
