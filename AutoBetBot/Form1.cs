using System;
using System.IO;
using System.Drawing.Text;

namespace AutoBetBot
{
    public partial class AutoBetter : Form
    {
        public AutoBetter()
        {
            InitializeComponent();
        }

        // varibables
        // staticsitcs
        public double totalBetted;
        public double totalWinnings;
        public double TotalProfit;
        public double currentStreak;
        public double totalStreak;

        // Manual bettings variables
        public double bet;
        public double winnings;
        public double profit;
        public string results;


        //automatic betting varibales
        public int botSpeed;
        public double onWinInc;
        public double onLossDec;
        public double stopOnProf;
        public double stopOnLoss;

        public bool botToggled;

        public const string SAVESEPERATOR = ",";






        // for when the form loads
        private void AutoBetter_Load(object sender, EventArgs e)
        {
            try
            {

                // reads all of the data from file
                System.IO.Directory.CreateDirectory("C:\\ProgramData\\AutoBetter\\");
                var s = new System.IO.StreamReader("C:\\ProgramData\\AutoBetter\\Statistics.ID");
                totalBetted = double.Parse(s.ReadLine());
                totalWinnings = double.Parse(s.ReadLine());
                TotalProfit = double.Parse(s.ReadLine());
                currentStreak = double.Parse(s.ReadLine());
                totalStreak = double.Parse(s.ReadLine());
                bet = double.Parse(s.ReadLine());
                s.Close();


                var ABD = new System.IO.StreamReader("C:\\ProgramData\\AutoBetter\\AutoBetterData.ID");
                botSpeed = int.Parse(ABD.ReadLine());
                onWinInc = double.Parse(ABD.ReadLine());
                onLossDec = double.Parse(ABD.ReadLine());
                stopOnProf = double.Parse(ABD.ReadLine());
                stopOnLoss = double.Parse(ABD.ReadLine());
                ABD.Close();


                //updates all of the labes with the new data.

                TBTotalBetted.Text = totalBetted.ToString();
                TBTotalWinnings.Text = totalWinnings.ToString();
                TBTotalProfit.Text = TotalProfit.ToString();
                TBCurrentStreak.Text = currentStreak.ToString();
                TBTotalStreak.Text= totalStreak.ToString();
                TBBet.Text = bet.ToString();

                TBBetsPerSec.Text = botSpeed.ToString();
                TBOnWin.Text = onWinInc.ToString();
                TBonLoss.Text = onLossDec.ToString();
                TBstopOnLoss.Text = stopOnLoss.ToString();
                TBstopOnProfit.Text = stopOnProf.ToString();



                if (TotalProfit > 0)
                {
                    TBTotalProfit.ForeColor = Color.LightSeaGreen;
                }
                else if (TotalProfit < 0)
                {
                    TBTotalProfit.ForeColor = Color.IndianRed;

                }
                else
                {
                    TBTotalProfit.ForeColor = Color.White;
                }



            }
            catch (FileNotFoundException)
            {
                // if the files are not found it will result in this catch which would create all of the data and files.

                System.IO.Directory.CreateDirectory("C:\\ProgramData\\AutoBetter\\");
                var s = new System.IO.StreamWriter("C:\\ProgramData\\AutoBetter\\Statistics.ID");
                s.WriteLine("0"); // totalBetted
                s.WriteLine("0"); // totalWinnings
                s.WriteLine("0"); // TotalProfit
                s.WriteLine("0"); // currentStreak
                s.WriteLine("0"); // totalStreak
                s.WriteLine("10"); // bet
                s.Close();


                var ABD = new System.IO.StreamWriter("C:\\ProgramData\\AutoBetter\\AutoBetterData.ID");
                ABD.WriteLine("1"); // TBBetsPerSec
                ABD.WriteLine("1"); // TBOnWin
                ABD.WriteLine("1"); // TBonLoss
                ABD.WriteLine("100"); // TBstopOnLoss
                ABD.WriteLine("100"); // TBstopOnProfit
                ABD.Close();

                totalBetted = 0;
                totalWinnings = 0;
                TotalProfit = 0;
                currentStreak = 0;
                totalStreak = 0;
                bet = 10;

                botSpeed = 1;
                onWinInc = 1;
                onLossDec = 1;
                stopOnLoss = 100;
                stopOnProf = 100;

                TBTotalBetted.Text = totalBetted.ToString();
                TBTotalWinnings.Text = totalWinnings.ToString();
                TBTotalProfit.Text = TotalProfit.ToString();
                TBCurrentStreak.Text = currentStreak.ToString();
                TBTotalStreak.Text = totalStreak.ToString();
                TBBet.Text = bet.ToString();

                TBBetsPerSec.Text = botSpeed.ToString();
                TBOnWin.Text = onWinInc.ToString();
                TBonLoss.Text = onLossDec.ToString();
                TBstopOnLoss.Text = stopOnLoss.ToString();
                TBstopOnProfit.Text = stopOnProf.ToString();


                var h = new System.IO.StreamWriter("C:\\ProgramData\\AutoBetter\\History.ID");
                h.Close();

                MessageBox.Show("Looks like it's your First time using AutoBotBetter Tester. You've been given £inf to test shit out", "New User", MessageBoxButtons.OK);

            }
        }






        //for the window bar

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        Point lastPoint;
        bool mousedown;
        private void WindowBar_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y); // records the position of the mouse.
            mousedown = true;
        }

        private void WindowBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (mousedown)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void WindowBar_MouseUp(object sender, MouseEventArgs e)
        {
            mousedown = false;

        }


        private void BtnDataOpen_Click(object sender, EventArgs e)
        {

            if(Application.OpenForms.Count > 1)
            {
                MessageBox.Show("Looks like you already have this open twat", "Form insance already open");

            }
            else
            {
                DataTable dt = new DataTable();
                dt.Show();

            }


        }
        // makes sure that you can only input numbers into the text boxes
        private void TBBet_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar); // makes sure that only numbers can be inputted

        }

        // Maunaul Betting


        private void BtnBet100_Click(object sender, EventArgs e)
        {
            bet += 100;
            TBBet.Text = bet.ToString();
        }

        private void BtnBet500_Click(object sender, EventArgs e)
        {
            bet += 500;
            TBBet.Text = bet.ToString();
        }

        private void BtnBet1000_Click(object sender, EventArgs e)
        {
            bet += 1000;
            TBBet.Text = bet.ToString();
        }

        private void BtnBet5000_Click(object sender, EventArgs e)
        {
            bet += 5000;
            TBBet.Text = bet.ToString();
        }

        private void BtnBetHalf_Click(object sender, EventArgs e)
        {
            if (bet >= 2)
            {

                bet /= 2;
                int test = (int)bet;
                bet = test;


            }
            TBBet.Text = bet.ToString();


        }

        private void BtnBetDouble_Click(object sender, EventArgs e)
        {

            bet *= 2;
            TBBet.Text = bet.ToString();
        }

        private void BtnBet_Click(object sender, EventArgs e)
        {

            if (TBBet.Text == "0")
            {
                TBBet.Text = "1";
            }
            bet = double.Parse(TBBet.Text);

            Random rd = new Random();



            int win = rd.Next(0, 2);
            if (win == 0)
            {
                results = "lost";
                winnings = -bet;
                profit = -bet;
                totalBetted += bet;
                TotalProfit = totalWinnings - totalBetted;
            }
            else
            {
                results = "Won";
                winnings = bet * 2;
                profit = winnings - bet;
                totalBetted += bet;
                totalWinnings += winnings;
                TotalProfit = totalWinnings - totalBetted;


            }
            streaks(win);
            TBTotalBetted.Text = totalBetted.ToString();
            TBTotalWinnings.Text = totalWinnings.ToString();
            TBTotalProfit.Text = TotalProfit.ToString();

            if(TotalProfit > 0)
            {
                TBTotalProfit.ForeColor = Color.LightSeaGreen;
            }
            else if(TotalProfit < 0){
                TBTotalProfit.ForeColor = Color.IndianRed;

            }
            else
            {
                TBTotalProfit.ForeColor = Color.White;
            }



            ManualSave();
            historySave();
        }


        // auto better bot




        private void streaks(int win)
        {

            if (win == 0)
            {
                currentStreak = 0;
                TBCurrentStreak.Text = currentStreak.ToString();
                TBTotalStreak.Text = totalStreak.ToString();
            }
            else
            {
                currentStreak++;

                if (currentStreak > totalStreak)
                {
                    totalStreak = currentStreak;
                }

                TBCurrentStreak.Text = currentStreak.ToString();
                TBTotalStreak.Text = totalStreak.ToString();
            }
        }


        private void ManualSave()
        {
            var s = new System.IO.StreamWriter("C:\\ProgramData\\AutoBetter\\Statistics.ID");
            s.WriteLine(totalBetted.ToString()); // totalBetted
            s.WriteLine(totalWinnings.ToString()); // totalWinnings
            s.WriteLine(TotalProfit.ToString()); // TotalProfit
            s.WriteLine(currentStreak.ToString()); // currentStreak
            s.WriteLine(totalStreak.ToString()); // totalStreak
            s.WriteLine(bet.ToString()); // bet
            s.Close();
        }

        public void AutoSave()
        {
            var ADB = new System.IO.StreamWriter("C:\\ProgramData\\AutoBetter\\AutoBetterData.ID");
            ADB.WriteLine(botSpeed.ToString()); // botSpeed
            ADB.WriteLine(onWinInc.ToString()); // onWinInc
            ADB.WriteLine(onLossDec.ToString()); // onLossDec
            ADB.WriteLine(stopOnLoss.ToString()); // stopOnLoss
            ADB.WriteLine(stopOnProf.ToString()); // stopOnProf
            ADB.Close();
        }



        private void historySave()
        {
            DateTime dateTime = DateTime.Now;


            string[] contents = new string[]{
                dateTime.ToString(),bet.ToString(),winnings.ToString(),profit.ToString(),results.ToString()
            };
            string saveString = string.Join(SAVESEPERATOR, contents);

            File.AppendAllText("C:\\ProgramData\\AutoBetter\\History.ID", saveString + Environment.NewLine);

        }


        private void CBBotEnable_CheckedChanged(object sender, EventArgs e)
        {
            if(CBBotEnable.Checked == true)
            {
                botSpeed = int.Parse(TBBetsPerSec.Text);
                onWinInc = double.Parse(TBOnWin.Text);
                onLossDec = double.Parse(TBonLoss.Text);
                stopOnLoss = double.Parse(TBstopOnLoss.Text);
                stopOnProf = double.Parse(TBstopOnProfit.Text);

                if(botSpeed > 250)
                {
                    botSpeed = 250;
                    TBBetsPerSec.Text = botSpeed.ToString();
                }
                Bot.Interval = 1000 / botSpeed;

                Bot.Enabled = true;
                lblError.Text = "";


            }
            else
            {
                Bot.Enabled=false;

            }
        }


        public void betChange(int win)
        {
            if (win == 0)
            {
                // lost
                bet -= onLossDec;
            }
            else
            {
                //won
                bet += onWinInc;
            }
            
            TBBet.Text = bet.ToString();

            if(TotalProfit <= -stopOnLoss)
            {
                Bot.Enabled = false;
                CBBotEnable.Checked = false;
                lblError.Text = "LOOKS LIKE YOU'VE REACHED THE LOSS LIMIT!";

            }
            if (TotalProfit >= stopOnProf)
            {
                Bot.Enabled = false;
                CBBotEnable.Checked = false;
                lblError.Text = "LOOKS LIKE YOU'VE REACHED THE PROFIT LIMIT!";


            }



        }

        private void Bot_Tick(object sender, EventArgs e)
        {
            botSpeed = int.Parse(TBBetsPerSec.Text);
            onWinInc = double.Parse(TBOnWin.Text);
            onLossDec = double.Parse(TBonLoss.Text);
            stopOnLoss = double.Parse(TBstopOnLoss.Text);
            stopOnProf = double.Parse(TBstopOnProfit.Text);

            if (TBBet.Text == "0")
            {
                TBBet.Text = "1";
            }
            bet = double.Parse(TBBet.Text);

            Random rd = new Random();



            int win = rd.Next(0, 2);
            if (win == 0)
            {
                results = "lost";
                winnings = -bet;
                profit = -bet;
                totalBetted += bet;
                TotalProfit = totalWinnings - totalBetted;
            }
            else
            {
                results = "Won";
                winnings = bet * 2;
                profit = winnings - bet;
                totalBetted += bet;
                totalWinnings += winnings;
                TotalProfit = totalWinnings - totalBetted;


            }
            streaks(win);
            TBTotalBetted.Text = totalBetted.ToString();
            TBTotalWinnings.Text = totalWinnings.ToString();
            TBTotalProfit.Text = TotalProfit.ToString();

            if (TotalProfit > 0)
            {
                TBTotalProfit.ForeColor = Color.LightSeaGreen;
            }
            else if (TotalProfit < 0)
            {
                TBTotalProfit.ForeColor = Color.IndianRed;

            }
            else
            {
                TBTotalProfit.ForeColor = Color.White;
            }



            ManualSave();
            AutoSave();
            betChange(win);
            historySave();




        }
    }
}