using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Race2016
{
    class Emerald : Shipping, IShipping
    {
        public void SetSail()
        { }
        public override List<string> ShipPath { get; set; }


        public override List<string> PiratePath { get; set; }
        public Emerald()
        {
            Name = "Emerald";
            PirateName = "Capt. GreenThumb";
            ShipPath = Emeraldsail();
           PiratePath = GreenThumbPath();
        }
        private List<string> Emeraldsail()

        {
            List<string> ShipPath = new List<string>();

            ShipPath.Add("0,676");
            ShipPath.Add("40,673");
            ShipPath.Add("85,672");
            ShipPath.Add("127,670");
            ShipPath.Add("172,666");
            ShipPath.Add("214,663");
            ShipPath.Add("259,666");
            ShipPath.Add("299,659");
            ShipPath.Add("340,670");
            ShipPath.Add("384,659");
            ShipPath.Add("422,670");
            ShipPath.Add("467,657");
            ShipPath.Add("509,666");
            ShipPath.Add("553,657");
            ShipPath.Add("595,663");
            ShipPath.Add("640,657");
            ShipPath.Add("680,663");
            ShipPath.Add("725,657");
            ShipPath.Add("771,651");
            ShipPath.Add("812,629");
            ShipPath.Add("855,614");
            ShipPath.Add("898,595");
            ShipPath.Add("931,566");
            ShipPath.Add("959,524");
            ShipPath.Add("982,480");
            ShipPath.Add("1002,435");
            ShipPath.Add("1006,385");
            ShipPath.Add("1014,335");
            ShipPath.Add("999,286");
            ShipPath.Add("973,238");
            ShipPath.Add("940,191");
            ShipPath.Add("903,157");
            ShipPath.Add("858,132");
            ShipPath.Add("812,114");
            ShipPath.Add("766,96");
            ShipPath.Add("721,86");
            ShipPath.Add("675,82");
            ShipPath.Add("629,98");
            ShipPath.Add("587,109");
            ShipPath.Add("544,120");
            ShipPath.Add("502,150");
            ShipPath.Add("468,197");
            ShipPath.Add("455,247");
            ShipPath.Add("452,296");
            ShipPath.Add("467,346");
            ShipPath.Add("502,385");
            ShipPath.Add("544,402");
            ShipPath.Add("587,413");
            ShipPath.Add("628,414");
            
            return ShipPath;
        }
        public List<string> GreenThumbPath()
        {
            List<string> PiratePath = new List<string>();
            PiratePath.Add("655,437");
            PiratePath.Add("667,450");
            PiratePath.Add("682,441");
            PiratePath.Add("689,419");
            PiratePath.Add("682,402");
            PiratePath.Add("672,385");
            PiratePath.Add("657,367");
            PiratePath.Add("649,349");
            PiratePath.Add("636,337");
            PiratePath.Add("627,323");
            PiratePath.Add("620,307");
            PiratePath.Add("618,289");
            PiratePath.Add("626,246");
           
            return PiratePath;
        }
        //public override void SetSail()
        //{
        //    //throw new NotImplementedException();
        //}
        public void FindTreasure()
        {
        }
    }
}
