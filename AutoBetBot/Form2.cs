using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoBetBot
{
    public partial class DataTable : Form
    {


        public double bet;
        public double winnings;
        public double profit;
        public string results;




        public const string SAVESEPERATOR = ",";

        public string txtBet;
        public string txtWinnings;
        public string txtProfit;


        // this is to make sure that the table updates when it needs too.
        public int previouslines;


        public DataTable()
        {
            InitializeComponent();
        }

        private void DataTable_Load(object sender, EventArgs e)
        {
            var lines = File.ReadAllLines("C:\\ProgramData\\AutoBetter\\History.ID");
            // read each line from file
            foreach (var line in lines)
            {
                string[] contents; // initilises string
                contents = new string[5];  // declares the string
                contents = line.Split(new[] { SAVESEPERATOR }, System.StringSplitOptions.None); // splits all of the data into the strings so that it can be parsed


                DateTime D = DateTime.Parse(contents[0]);
                bet = double.Parse(contents[1]);
                winnings = double.Parse(contents[2]);
                profit = double.Parse(contents[3]);
                results = contents[4];

                txtBet = bet.ToString();
                txtProfit = profit.ToString();
                txtWinnings = winnings.ToString();




                // for loading the test data thing

                string[] contents2 = new string[]{
                D.ToString(),txtBet,txtWinnings,txtProfit,results.ToString()
                };
                string saveString2 = string.Join("                           ", contents2);

                LBData.Items.Add(saveString2);


            }
            TableUpdate.Enabled = true;
            previouslines = 0;
        }

        // this is for the window bar

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
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
        // resets the data
        private void BtnResetData_Click(object sender, EventArgs e)
        {
            DirectoryInfo dataDir = new DirectoryInfo("C:\\ProgramData\\AutoBetter\\"); // cleares all of the data files that are in the persistantdatapath.
            dataDir.Delete(true);
            Application.Restart();
        }


        public Font myFont;
        public Brush myBrush;

        private void LBData_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();

            int i = e.Index;



            string str = LBData.Items[i].ToString();
            string check = str.Substring(str.Length - 3);

            if (check == "Won")
            {
                myFont = e.Font;
                myBrush = Brushes.LightSeaGreen;
            }
            else
            {
                myFont = e.Font;
                myBrush = Brushes.IndianRed;

            }


            e.Graphics.DrawString(LBData.Items[i].ToString(), myFont, myBrush, e.Bounds, StringFormat.GenericDefault);
        }

        private void TableUpdate_Tick(object sender, EventArgs e)
        {
            var lines = File.ReadAllLines("C:\\ProgramData\\AutoBetter\\History.ID");
            
            // read each line from file

            if(lines.Length > previouslines)
            {
                foreach (var line in lines)
                {
                    string[] contents; // initilises string
                    contents = new string[5];  // declares the string
                    contents = line.Split(new[] { SAVESEPERATOR }, System.StringSplitOptions.None); // splits all of the data into the strings so that it can be parsed


                    DateTime D = DateTime.Parse(contents[0]);
                    bet = double.Parse(contents[1]);
                    winnings = double.Parse(contents[2]);
                    profit = double.Parse(contents[3]);
                    results = contents[4];

                    txtBet = bet.ToString();
                    txtProfit = profit.ToString();
                    txtWinnings = winnings.ToString();




                    // for loading the test data thing

                    string[] contents2 = new string[]{
                    D.ToString(),txtBet,txtWinnings,txtProfit,results.ToString()
                    };
                    string saveString2 = string.Join("                           ", contents2);

                    LBData.Items.Add(saveString2);


                    LBData.TopIndex = LBData.Items.Count - 1;

                    previouslines = lines.Length;

                }
            }

        }
    }
}
