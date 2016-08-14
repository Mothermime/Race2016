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
        private RadioButton rbChosenPirate;

        private Shipping[] Ship = new Shipping[4];
        private Shipping[] Pirate = new Shipping[4];
        private Random myRandom = new Random();

        public bool End = false;
        private int PathCounter = 0;
        private int PiratePathCounter = 0;
        private int Winner = 5;

        // private int shipsLand = 0;
        // private int piratesArrive = 0;

        public Form1()
        {
            InitializeComponent();
            Ship[0] = new Sapphire();
            Ship[1] = new Ruby();
            Ship[2] = new Emerald();
            Ship[3] = new Topaz();
            Ship[0].MyPictureBox = pbBlue;
            Ship[1].MyPictureBox = pbRed;
            Ship[2].MyPictureBox = pbGreen;
            Ship[3].MyPictureBox = pbYellow;
            Ship[0].PiratePb = pbBluebeard;
            Ship[1].PiratePb = pbRedCoat;
            Ship[2].PiratePb = pbGreenThumb;
            Ship[3].PiratePb = pbYellowBelly;
        }

        private void btnSetSail_Click(object sender, EventArgs e)
            {
            //get the button out of the way
            btnSetSail.Visible = false;

            //ALL MANNER OF TRYING TO GET IT TO WORK/STOP WORKING,  TESTING AND RETESTING

           // while (End == false)
           
           ////do
           // {
                SetSail();
            //} //while (Ship[0].HasArrived == false || Ship[1].HasArrived == false || Ship[2].HasArrived == false ||
               //      Ship[3].HasArrived == false || End == false);
            //(End == false)
            //do
            //{
            //    FindTreasure();

            //} //while (End == false);
            //while (Ship[0].HasArrived == false || Ship[1].HasArrived == false || Ship[2].HasArrived == false || Ship[3].HasArrived == false);
            //WinningPirate();
        }

        //Trying out how to get the pictures to move diagonally first
        //Slow them down
        //Application.DoEvents();


        public void SetSail()
        {//finally found the right place to put the while statement after lots of different locations
            while (End == false)
            {//for each ship
                for (int i = 0; i < 4; i++)
                {
                    //Make it run
                    Application.DoEvents();
                    //Slow down a bit
                    System.Threading.Thread.Sleep(10);
                    //split the path array for each ship into left [0] and top [1] points

                    string path = Ship[i].ShipPath[Ship[i].PathCounter];
                    string[] pathArray = path.Split(',');
                    Ship[i].MyPictureBox.Left = Convert.ToInt16(pathArray[0]);
                    Ship[i].MyPictureBox.Top = Convert.ToInt16(pathArray[1]);

                    if (Ship[i].PathCounter >= 48)
                    {
                        //keep looping through path until each ship has reached 49 steps
                        //Ship[i].PathCounter = 49;
                        Ship[i].HasFinished = true;
                        Ship[i].PiratePb.Visible = true;
                    }
                    if (Ship[i].HasFinished)
                    //when each ship finishes start the pirate along his path
                    {//same as ship activate, slow it down
                        Application.DoEvents();
                        System.Threading.Thread.Sleep(200);
                        string piratepath = Ship[i].PiratePath[Ship[i].PiratePathCounter];
                        string[] piratepathArray = piratepath.Split(',');
                        Ship[i].PiratePb.Left = Convert.ToInt16(piratepathArray[0]);
                        Ship[i].PiratePb.Top = Convert.ToInt16(piratepathArray[1]);
                        {
                            if (Ship[i].PiratePathCounter <= 10)
                            {//randomize pirates
                                Ship[i].PiratePathCounter += myRandom.Next(0, 2);
                            }
                            else if (Ship[i].PiratePathCounter >= 12)
                            {
                                //once the pirate reaches the treasure the race is over
                                End = true;
                                //add one to the ship[] number because arrays start with 0
                                Winner = i + 1;
                                //display winner on the top of the form
                                Text = Convert.ToString(Winner);
                                //show the winner and the button to return to the soveriegns
                                btnReturn.Visible = true;
                                tbWinner.Visible = true;
                                //put the appropriate name n the winning announcement
                                tbWinner.Text = Ship[i].PirateName + " " + "has found the treasure!";

                                //if (Ship[0].HasArrived == true && Ship[1].HasArrived == true &&
                                //    Ship[2].HasArrived == true && Ship[3].HasArrived == true)

                                //{
                                //    pbBattle.Visible = true;
                                //    Ship[i].PiratePb.Visible = false;

                                // Finish!!! but they won't stop

                            }//add one step each time it loops through
                        }
                        Ship[i].PiratePathCounter += 1;
                    }
                    else
                    {
                        //move the ship a random distance along the path
                        Ship[i].PathCounter += myRandom.Next(0, 2);
                    }
                }

                //make a counter to count through the list
                PathCounter += 1;
                // EndFight();
                SetSail();
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            //close the racing form down to return to backers
            this.Close();
            //Backers backers = new Backers();
            //backers.Show();
        }


        private static string WinningPirate()

        {
            int Pirate = 1;
            string Name = "";
            switch (Pirate)
            {

                case 1:
                   Name = " Capt. Bluebeard";
                    break;
                case 2:

                    Name = "Cmdr. Readcoat";
                    break;
                case 3:
                    Name = "Capt. Emerald";

                    break;
                case 4:
                    Name = "Cmdr. Topaz ";
                    break;
            }
            return Name;
        }

        public
           void FindTreasure()
        {
            do
            {
                for (int i = 0; i < 4; i++)
                {
                    Ship[i].PiratePb.Visible = true;
                    Application.DoEvents();
                    System.Threading.Thread.Sleep(100);
                    string piratepath = Ship[i].PiratePath[Ship[i].PiratePathCounter];
                    string[] piratepathArray = piratepath.Split(',');
                    Ship[i].PiratePb.Left = Convert.ToInt16(piratepathArray[0]);
                    Ship[i].PiratePb.Top = Convert.ToInt16(piratepathArray[1]);
                    if (Ship[i].PiratePathCounter <= 10)
                    {
                        Ship[i].PiratePathCounter += myRandom.Next(0,2);
                    }
                    else if (Ship[i].PiratePathCounter >= 12)
                    {
                        Ship[i].PiratePathCounter = 12;
                        End = true;
                        Ship[i].HasArrived = true;
                        Winner = i + 1;
                        Text = Convert.ToString(Winner);
                    }
                    Ship[i].PiratePathCounter += 1;
                    }
            } while (End == false);



            //switch (Name)
            //{

            //    case "Sapphire":
            //        // pbBluebeard.Visible = true;
            //        BluebeardTrack();
            //        //run method that makes pirate for that ship run
            //        break;
            //    case "Ruby":
            //        // pbRedCoat.Visible = true;
            //        RedCoatTrack();
            //        break;
            //    case "Emerald":

            //        //pbGreenThumb.Visible = true;
            //        GreenThumbTrack();
            //        break;
            //    case "Topaz":
            //        // pbYellowBelly.Visible = true;
            //        YellowBellyTrack();
            //        break;


            //};





        }




        public void BluebeardTrack()
        {
            Application.DoEvents();
            System.Threading.Thread.Sleep(200);
            string Bluebeard = Ship[0].PiratePath[PiratePathCounter];
            string[] Bluebearddata = Bluebeard.Split(',');
            pbBluebeard.Left = Convert.ToInt16(Bluebearddata[0]);
            pbBluebeard.Top = Convert.ToInt16(Bluebearddata[1]);
            
        }

        public void RedCoatTrack()
        {
            Application.DoEvents();
            System.Threading.Thread.Sleep(200);
            string RedCoat = Ship[1].PiratePath[PiratePathCounter];
            string[] RedCoatdata = RedCoat.Split(',');
            pbRedCoat.Left = Convert.ToInt16(RedCoatdata[0]);
            pbRedCoat.Top = Convert.ToInt16(RedCoatdata[1]);
            
        }

        public void GreenThumbTrack()
        {
            Application.DoEvents();
            System.Threading.Thread.Sleep(200);
            string GreenThumb = Ship[2].PiratePath[PiratePathCounter];
            string[] GreenThumbdata = GreenThumb.Split(',');
            pbGreenThumb.Left = Convert.ToInt16(GreenThumbdata[0]);
            pbGreenThumb.Top = Convert.ToInt16(GreenThumbdata[1]);
            
        }

        public void YellowBellyTrack()
        {
            Application.DoEvents();
            System.Threading.Thread.Sleep(200);
            string YellowBelly = Ship[3].PiratePath[PiratePathCounter];
            string[] YellowBellydata = YellowBelly.Split(',');
            pbYellowBelly.Left = Convert.ToInt16(YellowBellydata[0]);
            pbYellowBelly.Top = Convert.ToInt16(YellowBellydata[1]);
            
        }

        private void rbSovereigns_CheckedChanged(object sender, EventArgs e)
        {
            rbChosenSovereign = (RadioButton) sender;
            if (rbChosenSovereign.Checked == true)
                Factory.ChooseSovereign(rbChosenSovereign.Text);
        }

        private void rbPirates_CheckedChanged(object sender, EventArgs e)
        {
            rbChosenPirate = (RadioButton) sender;
            if (rbChosenPirate.Checked == true)
                Factory.ChooseShip(rbChosenPirate.Text);
        }

        public void TreasureFinder(int Winner)
        {
            for (int i = 0; i < 3; i++)
            {
                //    if (Winner == Backer[i])
            }

        }

        
    }
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
       

     

       

       

        
    
    
