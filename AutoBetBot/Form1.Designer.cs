namespace AutoBetBot
{
    partial class AutoBetter
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AutoBetter));
            this.WindowBar = new System.Windows.Forms.Panel();
            this.BtnDataOpen = new System.Windows.Forms.PictureBox();
            this.lblWindowBar = new System.Windows.Forms.Label();
            this.BtnExit = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnBet100 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnBet500 = new System.Windows.Forms.Button();
            this.BtnBet1000 = new System.Windows.Forms.Button();
            this.BtnBet5000 = new System.Windows.Forms.Button();
            this.TBBet = new System.Windows.Forms.TextBox();
            this.BtnBetHalf = new System.Windows.Forms.Button();
            this.BtnBetDouble = new System.Windows.Forms.Button();
            this.BtnBet = new System.Windows.Forms.Button();
            this.TBOnWin = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TBonLoss = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TBTotalBetted = new System.Windows.Forms.TextBox();
            this.TBTotalWinnings = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TBTotalProfit = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TBstopOnProfit = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.TBstopOnLoss = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.CBBotEnable = new System.Windows.Forms.CheckBox();
            this.Bot = new System.Windows.Forms.Timer(this.components);
            this.TBBetsPerSec = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.TBCurrentStreak = new System.Windows.Forms.TextBox();
            this.TBTotalStreak = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.WindowBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnDataOpen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnExit)).BeginInit();
            this.SuspendLayout();
            // 
            // WindowBar
            // 
            this.WindowBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(48)))));
            this.WindowBar.Controls.Add(this.BtnDataOpen);
            this.WindowBar.Controls.Add(this.lblWindowBar);
            this.WindowBar.Controls.Add(this.BtnExit);
            this.WindowBar.Location = new System.Drawing.Point(0, 0);
            this.WindowBar.Name = "WindowBar";
            this.WindowBar.Size = new System.Drawing.Size(800, 40);
            this.WindowBar.TabIndex = 0;
            this.WindowBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.WindowBar_MouseDown);
            this.WindowBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.WindowBar_MouseMove);
            this.WindowBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.WindowBar_MouseUp);
            // 
            // BtnDataOpen
            // 
            this.BtnDataOpen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnDataOpen.BackgroundImage")));
            this.BtnDataOpen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnDataOpen.Location = new System.Drawing.Point(713, 0);
            this.BtnDataOpen.Name = "BtnDataOpen";
            this.BtnDataOpen.Size = new System.Drawing.Size(39, 39);
            this.BtnDataOpen.TabIndex = 2;
            this.BtnDataOpen.TabStop = false;
            this.BtnDataOpen.Click += new System.EventHandler(this.BtnDataOpen_Click);
            // 
            // lblWindowBar
            // 
            this.lblWindowBar.AutoSize = true;
            this.lblWindowBar.Font = new System.Drawing.Font("Doppio One", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblWindowBar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblWindowBar.Location = new System.Drawing.Point(12, 9);
            this.lblWindowBar.Name = "lblWindowBar";
            this.lblWindowBar.Size = new System.Drawing.Size(189, 25);
            this.lblWindowBar.TabIndex = 1;
            this.lblWindowBar.Text = "AUTOBET - TENTY";
            this.lblWindowBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.WindowBar_MouseDown);
            this.lblWindowBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.WindowBar_MouseMove);
            this.lblWindowBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.WindowBar_MouseUp);
            // 
            // BtnExit
            // 
            this.BtnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnExit.BackgroundImage")));
            this.BtnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnExit.Location = new System.Drawing.Point(758, 1);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(39, 39);
            this.BtnExit.TabIndex = 0;
            this.BtnExit.TabStop = false;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Location = new System.Drawing.Point(376, -4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(5, 500);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Doppio One", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(86, 229);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "MANUAL BETTING";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Doppio One", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(387, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "AUTOMATIC BETTING";
            // 
            // BtnBet100
            // 
            this.BtnBet100.BackColor = System.Drawing.Color.DimGray;
            this.BtnBet100.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnBet100.Font = new System.Drawing.Font("Doppio One", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnBet100.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnBet100.Location = new System.Drawing.Point(6, 282);
            this.BtnBet100.Name = "BtnBet100";
            this.BtnBet100.Size = new System.Drawing.Size(86, 35);
            this.BtnBet100.TabIndex = 4;
            this.BtnBet100.Text = "+100";
            this.BtnBet100.UseVisualStyleBackColor = false;
            this.BtnBet100.Click += new System.EventHandler(this.BtnBet100_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Doppio One", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(6, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "PLACE BET";
            // 
            // BtnBet500
            // 
            this.BtnBet500.BackColor = System.Drawing.Color.DimGray;
            this.BtnBet500.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnBet500.Font = new System.Drawing.Font("Doppio One", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnBet500.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnBet500.Location = new System.Drawing.Point(98, 282);
            this.BtnBet500.Name = "BtnBet500";
            this.BtnBet500.Size = new System.Drawing.Size(86, 35);
            this.BtnBet500.TabIndex = 6;
            this.BtnBet500.Text = "+500";
            this.BtnBet500.UseVisualStyleBackColor = false;
            this.BtnBet500.Click += new System.EventHandler(this.BtnBet500_Click);
            // 
            // BtnBet1000
            // 
            this.BtnBet1000.BackColor = System.Drawing.Color.DimGray;
            this.BtnBet1000.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnBet1000.Font = new System.Drawing.Font("Doppio One", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnBet1000.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnBet1000.Location = new System.Drawing.Point(190, 282);
            this.BtnBet1000.Name = "BtnBet1000";
            this.BtnBet1000.Size = new System.Drawing.Size(86, 35);
            this.BtnBet1000.TabIndex = 7;
            this.BtnBet1000.Text = "+1000";
            this.BtnBet1000.UseVisualStyleBackColor = false;
            this.BtnBet1000.Click += new System.EventHandler(this.BtnBet1000_Click);
            // 
            // BtnBet5000
            // 
            this.BtnBet5000.BackColor = System.Drawing.Color.DimGray;
            this.BtnBet5000.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnBet5000.Font = new System.Drawing.Font("Doppio One", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnBet5000.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnBet5000.Location = new System.Drawing.Point(282, 282);
            this.BtnBet5000.Name = "BtnBet5000";
            this.BtnBet5000.Size = new System.Drawing.Size(86, 35);
            this.BtnBet5000.TabIndex = 8;
            this.BtnBet5000.Text = "+5000";
            this.BtnBet5000.UseVisualStyleBackColor = false;
            this.BtnBet5000.Click += new System.EventHandler(this.BtnBet5000_Click);
            // 
            // TBBet
            // 
            this.TBBet.BackColor = System.Drawing.Color.DimGray;
            this.TBBet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBBet.Font = new System.Drawing.Font("Doppio One", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TBBet.ForeColor = System.Drawing.SystemColors.Window;
            this.TBBet.Location = new System.Drawing.Point(8, 323);
            this.TBBet.Name = "TBBet";
            this.TBBet.Size = new System.Drawing.Size(360, 32);
            this.TBBet.TabIndex = 9;
            this.TBBet.Text = "0";
            this.TBBet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TBBet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBBet_KeyPress);
            // 
            // BtnBetHalf
            // 
            this.BtnBetHalf.BackColor = System.Drawing.Color.DimGray;
            this.BtnBetHalf.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnBetHalf.Font = new System.Drawing.Font("Doppio One", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnBetHalf.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnBetHalf.Location = new System.Drawing.Point(8, 359);
            this.BtnBetHalf.Name = "BtnBetHalf";
            this.BtnBetHalf.Size = new System.Drawing.Size(176, 35);
            this.BtnBetHalf.TabIndex = 10;
            this.BtnBetHalf.Text = "HALF BET";
            this.BtnBetHalf.UseVisualStyleBackColor = false;
            this.BtnBetHalf.Click += new System.EventHandler(this.BtnBetHalf_Click);
            // 
            // BtnBetDouble
            // 
            this.BtnBetDouble.BackColor = System.Drawing.Color.DimGray;
            this.BtnBetDouble.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnBetDouble.Font = new System.Drawing.Font("Doppio One", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnBetDouble.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnBetDouble.Location = new System.Drawing.Point(190, 359);
            this.BtnBetDouble.Name = "BtnBetDouble";
            this.BtnBetDouble.Size = new System.Drawing.Size(178, 35);
            this.BtnBetDouble.TabIndex = 11;
            this.BtnBetDouble.Text = "DOUBLE BET";
            this.BtnBetDouble.UseVisualStyleBackColor = false;
            this.BtnBetDouble.Click += new System.EventHandler(this.BtnBetDouble_Click);
            // 
            // BtnBet
            // 
            this.BtnBet.BackColor = System.Drawing.Color.DimGray;
            this.BtnBet.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnBet.Font = new System.Drawing.Font("Doppio One", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnBet.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnBet.Location = new System.Drawing.Point(8, 399);
            this.BtnBet.Name = "BtnBet";
            this.BtnBet.Size = new System.Drawing.Size(360, 44);
            this.BtnBet.TabIndex = 12;
            this.BtnBet.Text = "COINFLIP BET";
            this.BtnBet.UseVisualStyleBackColor = false;
            this.BtnBet.Click += new System.EventHandler(this.BtnBet_Click);
            // 
            // TBOnWin
            // 
            this.TBOnWin.BackColor = System.Drawing.Color.DimGray;
            this.TBOnWin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBOnWin.Font = new System.Drawing.Font("Doppio One", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TBOnWin.ForeColor = System.Drawing.SystemColors.Window;
            this.TBOnWin.Location = new System.Drawing.Point(392, 179);
            this.TBOnWin.Name = "TBOnWin";
            this.TBOnWin.Size = new System.Drawing.Size(401, 27);
            this.TBOnWin.TabIndex = 16;
            this.TBOnWin.Text = "0";
            this.TBOnWin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TBOnWin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBBet_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Doppio One", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(508, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(197, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "ON WIN INCREASE BY: ";
            // 
            // TBonLoss
            // 
            this.TBonLoss.BackColor = System.Drawing.Color.DimGray;
            this.TBonLoss.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBonLoss.Font = new System.Drawing.Font("Doppio One", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TBonLoss.ForeColor = System.Drawing.SystemColors.Window;
            this.TBonLoss.Location = new System.Drawing.Point(392, 237);
            this.TBonLoss.Name = "TBonLoss";
            this.TBonLoss.Size = new System.Drawing.Size(401, 27);
            this.TBonLoss.TabIndex = 18;
            this.TBonLoss.Text = "0";
            this.TBonLoss.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TBonLoss.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBBet_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Doppio One", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(492, 215);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(206, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "ON LOSS DECREASE BY: ";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel2.Location = new System.Drawing.Point(0, 223);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(378, 5);
            this.panel2.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Doppio One", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(119, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 25);
            this.label7.TabIndex = 19;
            this.label7.Text = "STATISTICS";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Doppio One", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(8, 75);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(139, 20);
            this.label8.TabIndex = 20;
            this.label8.Text = "TOTAL BETTED: ";
            // 
            // TBTotalBetted
            // 
            this.TBTotalBetted.BackColor = System.Drawing.Color.DimGray;
            this.TBTotalBetted.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBTotalBetted.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TBTotalBetted.Font = new System.Drawing.Font("Doppio One", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TBTotalBetted.ForeColor = System.Drawing.SystemColors.Window;
            this.TBTotalBetted.Location = new System.Drawing.Point(152, 72);
            this.TBTotalBetted.Name = "TBTotalBetted";
            this.TBTotalBetted.ReadOnly = true;
            this.TBTotalBetted.Size = new System.Drawing.Size(218, 27);
            this.TBTotalBetted.TabIndex = 21;
            this.TBTotalBetted.TabStop = false;
            this.TBTotalBetted.Text = "0";
            this.TBTotalBetted.WordWrap = false;
            // 
            // TBTotalWinnings
            // 
            this.TBTotalWinnings.BackColor = System.Drawing.Color.DimGray;
            this.TBTotalWinnings.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBTotalWinnings.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TBTotalWinnings.Font = new System.Drawing.Font("Doppio One", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TBTotalWinnings.ForeColor = System.Drawing.SystemColors.Window;
            this.TBTotalWinnings.Location = new System.Drawing.Point(152, 103);
            this.TBTotalWinnings.Name = "TBTotalWinnings";
            this.TBTotalWinnings.ReadOnly = true;
            this.TBTotalWinnings.Size = new System.Drawing.Size(218, 27);
            this.TBTotalWinnings.TabIndex = 23;
            this.TBTotalWinnings.TabStop = false;
            this.TBTotalWinnings.Text = "0";
            this.TBTotalWinnings.WordWrap = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Doppio One", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(9, 107);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(150, 17);
            this.label9.TabIndex = 22;
            this.label9.Text = "TOTAL WINNINGS: ";
            // 
            // TBTotalProfit
            // 
            this.TBTotalProfit.BackColor = System.Drawing.Color.DimGray;
            this.TBTotalProfit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBTotalProfit.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TBTotalProfit.Font = new System.Drawing.Font("Doppio One", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TBTotalProfit.ForeColor = System.Drawing.SystemColors.Window;
            this.TBTotalProfit.Location = new System.Drawing.Point(152, 135);
            this.TBTotalProfit.Name = "TBTotalProfit";
            this.TBTotalProfit.ReadOnly = true;
            this.TBTotalProfit.Size = new System.Drawing.Size(218, 27);
            this.TBTotalProfit.TabIndex = 25;
            this.TBTotalProfit.TabStop = false;
            this.TBTotalProfit.Text = "0";
            this.TBTotalProfit.WordWrap = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Doppio One", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(8, 138);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(136, 20);
            this.label10.TabIndex = 24;
            this.label10.Text = "TOTAL PROFIT: ";
            // 
            // TBstopOnProfit
            // 
            this.TBstopOnProfit.BackColor = System.Drawing.Color.DimGray;
            this.TBstopOnProfit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBstopOnProfit.Font = new System.Drawing.Font("Doppio One", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TBstopOnProfit.ForeColor = System.Drawing.SystemColors.Window;
            this.TBstopOnProfit.Location = new System.Drawing.Point(392, 295);
            this.TBstopOnProfit.Name = "TBstopOnProfit";
            this.TBstopOnProfit.Size = new System.Drawing.Size(401, 27);
            this.TBstopOnProfit.TabIndex = 27;
            this.TBstopOnProfit.Text = "0";
            this.TBstopOnProfit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TBstopOnProfit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBBet_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Doppio One", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(492, 272);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(214, 20);
            this.label11.TabIndex = 26;
            this.label11.Text = "STOP ON TOTAL PROFIT: ";
            // 
            // TBstopOnLoss
            // 
            this.TBstopOnLoss.BackColor = System.Drawing.Color.DimGray;
            this.TBstopOnLoss.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBstopOnLoss.Font = new System.Drawing.Font("Doppio One", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TBstopOnLoss.ForeColor = System.Drawing.SystemColors.Window;
            this.TBstopOnLoss.Location = new System.Drawing.Point(392, 352);
            this.TBstopOnLoss.Name = "TBstopOnLoss";
            this.TBstopOnLoss.Size = new System.Drawing.Size(401, 27);
            this.TBstopOnLoss.TabIndex = 29;
            this.TBstopOnLoss.Text = "0";
            this.TBstopOnLoss.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TBstopOnLoss.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBBet_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Doppio One", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label12.Location = new System.Drawing.Point(496, 329);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(190, 20);
            this.label12.TabIndex = 28;
            this.label12.Text = "STOP ON TOTAL LOSS:";
            // 
            // CBBotEnable
            // 
            this.CBBotEnable.AutoSize = true;
            this.CBBotEnable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CBBotEnable.Font = new System.Drawing.Font("Doppio One", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CBBotEnable.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.CBBotEnable.Location = new System.Drawing.Point(489, 385);
            this.CBBotEnable.Name = "CBBotEnable";
            this.CBBotEnable.Size = new System.Drawing.Size(209, 24);
            this.CBBotEnable.TabIndex = 30;
            this.CBBotEnable.Text = "TOGGLE AUTOBET BOT";
            this.CBBotEnable.UseVisualStyleBackColor = true;
            this.CBBotEnable.CheckedChanged += new System.EventHandler(this.CBBotEnable_CheckedChanged);
            // 
            // Bot
            // 
            this.Bot.Interval = 1000;
            this.Bot.Tick += new System.EventHandler(this.Bot_Tick);
            // 
            // TBBetsPerSec
            // 
            this.TBBetsPerSec.BackColor = System.Drawing.Color.DimGray;
            this.TBBetsPerSec.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBBetsPerSec.Font = new System.Drawing.Font("Doppio One", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TBBetsPerSec.ForeColor = System.Drawing.SystemColors.Window;
            this.TBBetsPerSec.Location = new System.Drawing.Point(392, 121);
            this.TBBetsPerSec.Name = "TBBetsPerSec";
            this.TBBetsPerSec.Size = new System.Drawing.Size(401, 27);
            this.TBBetsPerSec.TabIndex = 32;
            this.TBBetsPerSec.Text = "1";
            this.TBBetsPerSec.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TBBetsPerSec.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBBet_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Doppio One", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label13.Location = new System.Drawing.Point(511, 98);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(159, 20);
            this.label13.TabIndex = 31;
            this.label13.Text = "BETS PER SECOND";
            // 
            // TBCurrentStreak
            // 
            this.TBCurrentStreak.BackColor = System.Drawing.Color.DimGray;
            this.TBCurrentStreak.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBCurrentStreak.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TBCurrentStreak.Font = new System.Drawing.Font("Doppio One", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TBCurrentStreak.ForeColor = System.Drawing.SystemColors.Window;
            this.TBCurrentStreak.Location = new System.Drawing.Point(9, 192);
            this.TBCurrentStreak.Name = "TBCurrentStreak";
            this.TBCurrentStreak.ReadOnly = true;
            this.TBCurrentStreak.Size = new System.Drawing.Size(175, 27);
            this.TBCurrentStreak.TabIndex = 33;
            this.TBCurrentStreak.TabStop = false;
            this.TBCurrentStreak.Text = "0";
            this.TBCurrentStreak.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TBCurrentStreak.WordWrap = false;
            // 
            // TBTotalStreak
            // 
            this.TBTotalStreak.BackColor = System.Drawing.Color.DimGray;
            this.TBTotalStreak.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBTotalStreak.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TBTotalStreak.Font = new System.Drawing.Font("Doppio One", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TBTotalStreak.ForeColor = System.Drawing.SystemColors.Window;
            this.TBTotalStreak.Location = new System.Drawing.Point(190, 192);
            this.TBTotalStreak.Name = "TBTotalStreak";
            this.TBTotalStreak.ReadOnly = true;
            this.TBTotalStreak.Size = new System.Drawing.Size(180, 27);
            this.TBTotalStreak.TabIndex = 34;
            this.TBTotalStreak.TabStop = false;
            this.TBTotalStreak.Text = "0";
            this.TBTotalStreak.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TBTotalStreak.WordWrap = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Doppio One", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label14.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label14.Location = new System.Drawing.Point(20, 169);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(154, 20);
            this.label14.TabIndex = 35;
            this.label14.Text = "CURRENT STREAK";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Doppio One", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label15.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label15.Location = new System.Drawing.Point(223, 169);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(110, 20);
            this.label15.TabIndex = 36;
            this.label15.Text = "TOP STREAK";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Doppio One", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblError.ForeColor = System.Drawing.Color.IndianRed;
            this.lblError.Location = new System.Drawing.Point(392, 413);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 20);
            this.lblError.TabIndex = 37;
            // 
            // AutoBetter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.TBTotalStreak);
            this.Controls.Add(this.TBCurrentStreak);
            this.Controls.Add(this.TBBetsPerSec);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.CBBotEnable);
            this.Controls.Add(this.TBstopOnLoss);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.TBstopOnProfit);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.TBTotalProfit);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.TBTotalWinnings);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TBTotalBetted);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.TBonLoss);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TBOnWin);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BtnBet);
            this.Controls.Add(this.BtnBetDouble);
            this.Controls.Add(this.BtnBetHalf);
            this.Controls.Add(this.TBBet);
            this.Controls.Add(this.BtnBet5000);
            this.Controls.Add(this.BtnBet1000);
            this.Controls.Add(this.BtnBet500);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnBet100);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.WindowBar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AutoBetter";
            this.Text = "`";
            this.Load += new System.EventHandler(this.AutoBetter_Load);
            this.WindowBar.ResumeLayout(false);
            this.WindowBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnDataOpen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnExit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel WindowBar;
        private Label lblWindowBar;
        private PictureBox BtnExit;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private Button BtnBet100;
        private Label label3;
        private Button BtnBet500;
        private Button BtnBet1000;
        private Button BtnBet5000;
        private TextBox TBBet;
        private Button BtnBetHalf;
        private Button BtnBetDouble;
        private Button BtnBet;
        private TextBox TBOnWin;
        private Label label5;
        private TextBox TBonLoss;
        private Label label6;
        private Panel panel2;
        private Label label7;
        private Label label8;
        private TextBox TBTotalBetted;
        private TextBox TBTotalWinnings;
        private Label label9;
        private TextBox TBTotalProfit;
        private Label label10;
        private TextBox TBstopOnProfit;
        private Label label11;
        private TextBox TBstopOnLoss;
        private Label label12;
        private CheckBox CBBotEnable;
        private PictureBox BtnDataOpen;
        private System.Windows.Forms.Timer Bot;
        private TextBox TBBetsPerSec;
        private Label label13;
        private TextBox TBCurrentStreak;
        private TextBox TBTotalStreak;
        private Label label14;
        private Label label15;
        private Label lblError;
    }
}