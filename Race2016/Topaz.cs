using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Race2016
{
    class Topaz : Shipping, IShipping
    {
        public override List<string> ShipPath { get; set; }

        public override List<string> PiratePath { get; set; }

        public Topaz()
        {
            ShipPath = Topazsail();
            PiratePath = YellowBellyPath();
        }
        private List<string> Topazsail()

        {
            List<string> ShipPath = new List<string>();

            ShipPath.Add("0,0");
            ShipPath.Add("23,48");
            ShipPath.Add("38,95");
            ShipPath.Add("54,141");
            ShipPath.Add("71,191");
            ShipPath.Add("87,241");
            ShipPath.Add("104,291");
            ShipPath.Add("120,337");
            ShipPath.Add("136,385");
            ShipPath.Add("154,430");
            ShipPath.Add("172,477");
            ShipPath.Add("191,524");
            ShipPath.Add("223,556");
            ShipPath.Add("259,603");
            ShipPath.Add("299,625");
            ShipPath.Add("340,651");
            ShipPath.Add("378,663");
            ShipPath.Add("422,651");
            ShipPath.Add("476,643");
            ShipPath.Add("509,651");
            ShipPath.Add("553,657");
            ShipPath.Add("600,651");
            ShipPath.Add("644,657");
            ShipPath.Add("688,651");
            ShipPath.Add("729,639");
            ShipPath.Add("771,629");
            ShipPath.Add("812,614");
            ShipPath.Add("855,603");
            ShipPath.Add("896,576");
            ShipPath.Add("920,536");
            ShipPath.Add("941,491");
            ShipPath.Add("951,435");
            ShipPath.Add("941,385");
            ShipPath.Add("951,337");
            ShipPath.Add("930,291");
            ShipPath.Add("910,241");
            ShipPath.Add("882,203");
            ShipPath.Add("841,168");
            ShipPath.Add("801,131");
            ShipPath.Add("761,113");
            ShipPath.Add("716,109");
            ShipPath.Add("680,107");
            ShipPath.Add("638,113");
            ShipPath.Add("595,120");
            ShipPath.Add("560,131");
            ShipPath.Add("519,160");
            ShipPath.Add("496,191");
            ShipPath.Add("513,216");
            ShipPath.Add("544,241");
            return ShipPath;
        }
        public List<string> YellowBellyPath()
        {
            List<string> PiratePath = new List<string>();
            PiratePath.Add("553,264");
            PiratePath.Add("543,274");
            PiratePath.Add("533,289");
            PiratePath.Add("543,307");
            PiratePath.Add("560,314");
            PiratePath.Add("577,318");
            PiratePath.Add("589,304");
            PiratePath.Add("594,285");
            PiratePath.Add("600,266");
            PiratePath.Add("609,247");
            PiratePath.Add("611,228");
            PiratePath.Add("627,226");
            PiratePath.Add("635,241");
            return PiratePath;
        }
        public void SetSail()
        {
            throw new NotImplementedException();
        }
        public void FindTreasure()
            {
        }
    }
}
