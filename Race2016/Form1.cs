using System;
using System.Windows;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Timers;
//using System.Windows.Controls;
//using System.Windows.Media:
//using System.Windows.Media.Animation;

namespace Race2016
{
    public partial class Form1 : Form, IShipping
    {
        private RadioButton rbChosenSovereign;
        Sapphire mySapphire = new Sapphire();
        Ruby myRuby = new Ruby();
        Emerald myEmerald =  new Emerald();
        Topaz myTopaz = new Topaz();

        int PathCounter = 0;
        int PiratePathCounter = 0;
        public Form1()
        {
            InitializeComponent();
            //Ship position 0
            string sapphiredata = mySapphire.ShipPath[PathCounter];
            string rubydata = myRuby.ShipPath[PathCounter];
            string emeralddata = myEmerald.ShipPath[PathCounter];
            string topazdata = myTopaz.ShipPath[PathCounter];
        }

        private void btnSetSail_Click(object sender, EventArgs e)
        {
            Random myrandom = new Random() ;
            do {
                SetSail(); }
            while
         (PathCounter < 49
         );
            pbBluebeard.Visible = true;
            pbRedCoat.Visible = true;
            pbYellowBelly.Visible = true;
            pbGreenThumb.Visible = true;
            do
            {
                FindTreasure();
            } while (PiratePathCounter < 13);

            //Trying out how to get the pictures to move diagonally first
            //Slow them down
            //Application.DoEvents();
            //System.Threading.Thread.Sleep(300);

            //this.pbBlue.Left = (this.pbBlue.Left - 10);
            //this.pbBlue.Top = (this.pbBlue.Top + 10);
            //this.pbRed.Left = (this.pbRed.Left - 10);
            //this.pbRed.Top = (this.pbRed.Top - 10);
            //this.pbGreen.Left = (this.pbGreen.Left + 10);
            //this.pbGreen.Top = (this.pbGreen.Top - 10);
            //this.pbYellow.Left = (this.pbYellow.Left + 10);
            //this.pbYellow.Top = (this.pbYellow.Top + 10);

        }
        public void SetSail()
        {
            Application.DoEvents();
            System.Threading.Thread.Sleep(150);
            //make a counter to count through the list
            string sapphiredata = mySapphire.ShipPath[PathCounter];
            string rubydata = myRuby.ShipPath[PathCounter];
            string emeralddata = myEmerald.ShipPath[PathCounter];
            string topazdata = myTopaz.ShipPath[PathCounter];
            //split the path into left and top  
            string[] moresapphiredata = sapphiredata.Split(',');
            string[] morerubydata = rubydata.Split(',');
         string[] moreemeralddata = emeralddata.Split(',');
            string[] moretopazdata = topazdata.Split(',');

            //attach to picturebox
            pbBlue.Left = Convert.ToInt16(moresapphiredata[0]);
            pbBlue.Top = Convert.ToInt16(moresapphiredata[1]);
            pbRed.Left = Convert.ToInt16(morerubydata[0]);
            pbRed.Top = Convert.ToInt16(morerubydata[1]);
            pbGreen.Left = Convert.ToInt16(moreemeralddata[0]);
            pbGreen.Top = Convert.ToInt16(moreemeralddata[1]);
            pbYellow.Left = Convert.ToInt16(moretopazdata[0]);
            pbYellow.Top = Convert.ToInt16(moretopazdata[1]);
            //count through path
            PathCounter += 1;
        }
        public void FindTreasure()
        {
            //do same with pirate path
            Application.DoEvents();
            System.Threading.Thread.Sleep(200);
            string Bluebeard = mySapphire.PiratePath[PiratePathCounter];
        string[] Bluebearddata = Bluebeard.Split(',');
            string RedCoat = myRuby.PiratePath[PiratePathCounter];
            string[] RedCoatdata = RedCoat.Split(',');
            string YellowBelly = myTopaz.PiratePath[PiratePathCounter];
            string[] YellowBellydata = YellowBelly.Split(',');
            string GreenThumb = myEmerald.PiratePath[PiratePathCounter];
            string[] GreenThumbdata = GreenThumb.Split(',');

            pbBluebeard.Left = Convert.ToInt16(Bluebearddata[0]);
            pbBluebeard.Top = Convert.ToInt16(Bluebearddata[1]);
            pbRedCoat.Left = Convert.ToInt16(RedCoatdata[0]);
            pbRedCoat.Top = Convert.ToInt16(RedCoatdata[1]);
            pbYellowBelly.Left = Convert.ToInt16(YellowBellydata[0]);
            pbYellowBelly.Top = Convert.ToInt16(YellowBellydata[1]);
            pbGreenThumb.Left = Convert.ToInt16(GreenThumbdata[0]);
            pbGreenThumb.Top = Convert.ToInt16(GreenThumbdata[1]);
            PiratePathCounter += 1;
                               }
        private void rbSovereigns_CheckedChanged (object sender, EventArgs e)
        {
            rbChosenSovereign = (RadioButton)sender;
            if (rbChosenSovereign.Checked == true)
                Factory.ChooseSovereign(rbChosenSovereign.Text);
        }
        //{//Moving in a spiral. Need more points to make it smoother
        //    Application.DoEvents();
        //    System.Threading.Thread.Sleep(500);
        //    pbBlue.Left = 1036;
        //    pbBlue.Top = 22;
        //    pbRed.Left = 1159;
        //    pbRed.Top = 552;
        //    pbGreen.Left = 174;
        //    pbGreen.Top = 649;
        //    pbYellow.Left = 48;
        //    pbYellow.Top = 164;
        //    Application.DoEvents();
        //    System.Threading.Thread.Sleep(1000);
        //    pbBlue.Left = 811;
        //    pbBlue.Top = 48;
        //    pbYellow.Left = 100;
        //    pbYellow.Top = 344;
        //    pbRed.Left = 1187;
        //    pbRed.Top = 552;
        //    pbGreen.Left = 390
        //    pbGreen.Top = 624;
        //    Application.DoEvents();
        //    System.Threading.Thread.Sleep(1000);
        //    pbBlue.Left = 562;
        //    pbBlue.Top = 78;
        //    pbYellow.Left = 187;
        //    pbYellow.Top = 511;
        //    pbRed.Left = 1051;
        //    pbRed.Top = 280;
        //    pbGreen.Left = 617;
        //    pbGreen.Top = 594;
        //    Application.DoEvents();
        //    System.Threading.Thread.Sleep(1000);
        //    pbBlue.Left = 358;
        //    pbBlue.Top = 132;
        //    pbYellow.Left = 339;
        //    pbYellow.Top = 624;
        //    pbRed.Left = 969;
        //    pbRed.Top = 164;
        //    pbGreen.Left = 791;
        //    pbGreen.Top = 552;
        //    Application.DoEvents();
        //    System.Threading.Thread.Sleep(1000);
        //    pbBlue.Left = 222;
        //    pbBlue.Top = 235;
        //    pbYellow.Left = 526;
        //    pbYellow.Top = 624;
        //    pbRed.Left = 842;
        //    pbRed.Top = 91;
        //    pbGreen.Left = 935;
        //    pbGreen.Top = 474;
        //    Application.DoEvents();
        //    System.Threading.Thread.Sleep(1000);
        //    pbBlue.Left = 209;
        //    pbBlue.Top = 384;
        //    pbYellow.Left = 721;
        //    pbYellow.Top = 594;
        //    pbRed.Left = 663;
        //    pbRed.Top = 67;
        //    pbGreen.Left = 969;
        //    pbGreen.Top = 344;
        //    Application.DoEvents();
        //    System.Threading.Thread.Sleep(1000);
        //    pbBlue.Left = 305;
        //    pbBlue.Top = 501;
        //    pbYellow.Left = 885;
        //    pbYellow.Top = 511;
        //    pbRed.Left = 488;
        //    pbRed.Top = 152;
        //    pbGreen.Left = 899;
        //    pbGreen.Top = 235;
        //    Application.DoEvents();
        //    System.Threading.Thread.Sleep(1000);
        //    pbBlue.Left = 526;
        //    pbBlue.Top = 511;
        //    pbYellow.Left = 935;
        //    pbYellow.Top = 384;
        //    pbRed.Left = 390;
        //    pbRed.Top = 247;
        //    pbGreen.Left = 769;
        //    pbGreen.Top = 153;
        //    Application.DoEvents();
        //    System.Threading.Thread.Sleep(1000);
        //    pbBlue.Left = 706;
        //    pbBlue.Top = 474;
        //    pbYellow.Left = 885;
        //    pbYellow.Top = 258;
        //    pbRed.Left = 358;
        //    pbRed.Top = 365;
        //    pbGreen.Left = 617;
        //    pbGreen.Top = 164;
        //    Application.DoEvents();
        //    System.Threading.Thread.Sleep(1000);
        //    pbBlue.Left = 811;
        //    pbBlue.Top = 384;
        //    pbYellow.Left = 757;
        //    pbYellow.Top = 201;
        //    pbRed.Left = 432;
        //    pbRed.Top = 450;
        //    pbGreen.Left = 500;
        //    pbGreen.Top = 281;

        //    Application.DoEvents();
        //    System.Threading.Thread.Sleep(1000);
        //    pbBlue.Left = 757;
        //    pbBlue.Top = 280;
        //    pbYellow.Left = 604;
        //    pbYellow.Top = 234;
        //    pbRed.Left = 562;
        //    pbRed.Top = 462;
        //    pbGreen.Left = 478;
        //    pbGreen.Top = 320;
        //    Application.DoEvents();
        //    System.Threading.Thread.Sleep(1000);
        //    pbBlue.Left = 650;
        //    pbBlue.Top = 290;
        //    pbYellow.Left = 562;
        //    pbYellow.Top = 290;
        //    pbRed.Left = 650;
        //    pbRed.Top = 387;
        //    pbGreen.Left = 562;
        //    pbGreen.Top = 387;


            //PathGeometry animationPath = new PathGeometry();
            //PathFigure pFigure = new PathFigure();
            //pFigure.StartPoint = new Point(10, 100);
            //PolyBezierSegment pBezierSegment = new PolyBezierSegment();
            //pBezierSegment.Points.Add(new Point(35, 0));
            //pBezierSegment.Points.Add(new Point(135, 0));
            //pBezierSegment.Points.Add(new Point(160, 100));
            //pBezierSegment.Points.Add(new Point(180, 190));
            //pBezierSegment.Points.Add(new Point(285, 200));
            //pBezierSegment.Points.Add(new Point(310, 100));
            //pFigure.Segments.Add(pBezierSegment);
            //animationPath.Figures.Add(pFigure);

        }

        //private void bluesail()

        //{
          // List<string> ShipPath = new List<string>();

            //ShipPath.Add("1217, 0""1126,33" );
            //ShipPath.Add("1122,18"):
            //string[] anotherpath = ShipPath[0].Split(',');
            //int Left = Convert.ToInt32(anotherpath[0]);
            //int top = Convert.ToInt32(anotherpath[1]);


            //int ShipLastMoveCount = 0;
            //int DiceRoll = 5;

            //for (int i = ShipLastMoveCount; i < DiceRoll; i++)
            //{
            //    string[] path = ShipPath[i].Split(',');
            //    int Lefta = Convert.ToInt32(path[0]);
            //    int topa = Convert.ToInt32(path[1]);


            //    pbGreen.Left = Lefta;
            //    pbGreen.Top = topa;
            //    Application.DoEvents();
            //    System.Threading.Thread.Sleep(1000);


           // }

            //ShipLastMoveCount += ShipLastMoveCount + DiceRoll;

            //{
    //        Application.DoEvents();
    //        System.Threading.Thread.Sleep(300);
    //        pbBlue.Left = 1128;
    //        pbBlue.Top = 12;
    //        Application.DoEvents();
    //        System.Threading.Thread.Sleep(300);
    //        pbBlue.Left = 1036;
    //        pbBlue.Top = 22;
    //        Application.DoEvents();
    //        System.Threading.Thread.Sleep(300);
    //        pbBlue.Left = 918;
    //        pbBlue.Top = 35;
    //        Application.DoEvents();
    //        System.Threading.Thread.Sleep(300);
    //        pbBlue.Left = 811;
    //        pbBlue.Top = 48;
    //        Application.DoEvents();
    //        System.Threading.Thread.Sleep(300);
    //        pbBlue.Left = 685;
    //        pbBlue.Top = 61;
    //        Application.DoEvents();
    //        System.Threading.Thread.Sleep(300);
    //        pbBlue.Left = 570;
    //        pbBlue.Top = 78;
    //        Application.DoEvents();
    //        System.Threading.Thread.Sleep(300);
    //        pbBlue.Left = 452;
    //        pbBlue.Top = 101;

    //        Application.DoEvents();
    //        System.Threading.Thread.Sleep(300);
    //        pbBlue.Left = 358;
    //        pbBlue.Top = 132;
    //        Application.DoEvents();

    //        System.Threading.Thread.Sleep(300);
    //        pbBlue.Left = 222;
    //        pbBlue.Top = 235;
    //        Application.DoEvents();
    //        System.Threading.Thread.Sleep(300);
    //        pbBlue.Left = 209;
    //        pbBlue.Top = 384;
    //        Application.DoEvents();
    //        System.Threading.Thread.Sleep(300);
    //        pbBlue.Left = 305;
    //        pbBlue.Top = 501;
    //        Application.DoEvents();
    //        System.Threading.Thread.Sleep(300);
    //        pbBlue.Left = 526;
    //        pbBlue.Top = 511;
    //        Application.DoEvents();
    //        System.Threading.Thread.Sleep(300);
    //        pbBlue.Left = 706;
    //        pbBlue.Top = 474;
    //        Application.DoEvents();
    //        System.Threading.Thread.Sleep(300);
    //        pbBlue.Left = 809;
    //        pbBlue.Top = 384;
    //        Application.DoEvents();
    //        System.Threading.Thread.Sleep(300);
    //        pbBlue.Left = 757;
    //        pbBlue.Top = 280;
    //        Application.DoEvents();
    //        System.Threading.Thread.Sleep(300);
    //        pbBlue.Left = 650;
    //        pbBlue.Top = 290;

    //    }
    

    //private void pbYellow_Click(object sender, EventArgs e)
    //{

    //}

    //private void pbGreen_Click(object sender, EventArgs e)
    //{

    //}

    //private void Form1_Load(object sender, EventArgs e)
    //{

    //}

    //    private void button2_Click(object sender, EventArgs e)
    //    {
    //        bluesail();
    //    }

     

       

       

        
    }
    
