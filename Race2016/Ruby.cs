using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Race2016
{
    class Ruby : Shipping, IShipping
    {
        public override List<string> PiratePath { get; set; }


        public override List<string> ShipPath { get; set;}
            
        
        public Ruby()
        {
            ShipPath = Rubysail();
            PiratePath = RedCoatPath();// PathCounter += 1;
        }
      
      

        private List<string> Rubysail()

        {
            List<string> ShipPath = new List<string>();

            ShipPath.Add("1217, 676");
            ShipPath.Add("1190,628");
            ShipPath.Add("1173, 578");
            ShipPath.Add("1162,529");
            ShipPath.Add("1154,480");
            ShipPath.Add("1145,435");
            ShipPath.Add("1130,385");
            ShipPath.Add("1117,337");
            ShipPath.Add("1106,291");
            ShipPath.Add("1093,241");
            ShipPath.Add("1065,197");
            ShipPath.Add("1043,147");
            ShipPath.Add("1017,103");
            ShipPath.Add("983,75");
            ShipPath.Add("941,57");
            ShipPath.Add("895,53");
            ShipPath.Add("849,33");
            ShipPath.Add("804,24");
            ShipPath.Add("760,18");
            ShipPath.Add("716,12");
            ShipPath.Add("674,18");
            ShipPath.Add("629,24");
            ShipPath.Add("585,30");
            ShipPath.Add("546,33");
            ShipPath.Add("500,43");
            ShipPath.Add("462,53");
            ShipPath.Add("420,75");
            ShipPath.Add("379,105");
            ShipPath.Add("340,131");
            ShipPath.Add("306,168");
            ShipPath.Add("289,216");
            ShipPath.Add("273,266");
            ShipPath.Add("259,318");
            ShipPath.Add("265,365");
            ShipPath.Add("273,414");
            ShipPath.Add("289,457");
            ShipPath.Add("324,497");
            ShipPath.Add("359,537");
            ShipPath.Add("401,566");
            ShipPath.Add("445,585");
            ShipPath.Add("490,591");
            ShipPath.Add("535,585");
            ShipPath.Add("580,591");
            ShipPath.Add("625,585");
            ShipPath.Add("671,567");
            ShipPath.Add("717,545");
            ShipPath.Add("767,515");
            ShipPath.Add("771,471");
            ShipPath.Add("733,453");
            return ShipPath;
        }

        public List<string> RedCoatPath()
        {
            List<string> PiratePath = new List<string>();
            PiratePath.Add("711,463");
            PiratePath.Add("721,447");
            PiratePath.Add("721,435");
            PiratePath.Add("727,413");
            PiratePath.Add("719,396");
            PiratePath.Add("703,386");
            PiratePath.Add("691,369");
            PiratePath.Add("679,354");
            PiratePath.Add("667,335");
            PiratePath.Add("655,318");
            PiratePath.Add("644,301");
            PiratePath.Add("639,277");
            PiratePath.Add("646,260");
            return PiratePath;
        }
        public  void SetSail()
        {
           
        }
        public void FindTreasure()
        {
        }
    }
}
