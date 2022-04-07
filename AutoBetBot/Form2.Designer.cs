namespace AutoBetBot
{
    partial class DataTable
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataTable));
            this.WindowBar = new System.Windows.Forms.Panel();
            this.BtnResetData = new System.Windows.Forms.Button();
            this.lblWindowBar = new System.Windows.Forms.Label();
            this.BtnExit = new System.Windows.Forms.PictureBox();
            this.LBData = new System.Windows.Forms.ListBox();
            this.TableUpdate = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.WindowBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnExit)).BeginInit();
            this.SuspendLayout();
            // 
            // WindowBar
            // 
            this.WindowBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(48)))));
            this.WindowBar.Controls.Add(this.BtnResetData);
            this.WindowBar.Controls.Add(this.lblWindowBar);
            this.WindowBar.Controls.Add(this.BtnExit);
            this.WindowBar.Location = new System.Drawing.Point(0, 0);
            this.WindowBar.Name = "WindowBar";
            this.WindowBar.Size = new System.Drawing.Size(800, 40);
            this.WindowBar.TabIndex = 20;
            this.WindowBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.WindowBar_MouseDown);
            this.WindowBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.WindowBar_MouseMove);
            this.WindowBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.WindowBar_MouseUp);
            // 
            // BtnResetData
            // 
            this.BtnResetData.BackColor = System.Drawing.Color.IndianRed;
            this.BtnResetData.FlatAppearance.BorderSize = 2;
            this.BtnResetData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnResetData.Font = new System.Drawing.Font("Doppio One", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnResetData.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnResetData.Location = new System.Drawing.Point(605, 3);
            this.BtnResetData.Name = "BtnResetData";
            this.BtnResetData.Size = new System.Drawing.Size(147, 34);
            this.BtnResetData.TabIndex = 2;
            this.BtnResetData.Text = "RESET DATA";
            this.BtnResetData.UseVisualStyleBackColor = false;
            this.BtnResetData.Click += new System.EventHandler(this.BtnResetData_Click);
            // 
            // lblWindowBar
            // 
            this.lblWindowBar.AutoSize = true;
            this.lblWindowBar.Font = new System.Drawing.Font("Doppio One", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblWindowBar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblWindowBar.Location = new System.Drawing.Point(12, 9);
            this.lblWindowBar.Name = "lblWindowBar";
            this.lblWindowBar.Size = new System.Drawing.Size(317, 25);
            this.lblWindowBar.TabIndex = 1;
            this.lblWindowBar.Text = "AUTOBET - TENTY - DataSheet";
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
            // LBData
            // 
            this.LBData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LBData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LBData.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.LBData.Font = new System.Drawing.Font("Doppio One", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LBData.ForeColor = System.Drawing.SystemColors.Menu;
            this.LBData.FormattingEnabled = true;
            this.LBData.ItemHeight = 16;
            this.LBData.Location = new System.Drawing.Point(12, 76);
            this.LBData.Name = "LBData";
            this.LBData.Size = new System.Drawing.Size(776, 352);
            this.LBData.TabIndex = 21;
            this.LBData.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.LBData_DrawItem);
            // 
            // TableUpdate
            // 
            this.TableUpdate.Tick += new System.EventHandler(this.TableUpdate_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Doppio One", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(106, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "TIME";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Doppio One", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(234, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 17);
            this.label2.TabIndex = 22;
            this.label2.Text = "INITIAL BET";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Doppio One", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(335, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 17);
            this.label3.TabIndex = 23;
            this.label3.Text = "WINNINGS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Doppio One", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(429, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 17);
            this.label4.TabIndex = 24;
            this.label4.Text = "PROFIT";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Doppio One", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(509, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 17);
            this.label5.TabIndex = 25;
            this.label5.Text = "OUTCOME";
            // 
            // DataTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LBData);
            this.Controls.Add(this.WindowBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DataTable";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.DataTable_Load);
            this.WindowBar.ResumeLayout(false);
            this.WindowBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnExit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel WindowBar;
        private Label lblWindowBar;
        private PictureBox BtnExit;
        private ListBox LBData;
        private Button BtnResetData;
        private System.Windows.Forms.Timer TableUpdate;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}