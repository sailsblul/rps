namespace rps
{
    partial class rps
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
            this.grpWeapons = new System.Windows.Forms.GroupBox();
            this.radScissors = new System.Windows.Forms.RadioButton();
            this.radPaper = new System.Windows.Forms.RadioButton();
            this.radRock = new System.Windows.Forms.RadioButton();
            this.btnFight = new System.Windows.Forms.Button();
            this.imgPlayer = new System.Windows.Forms.PictureBox();
            this.imgCom = new System.Windows.Forms.PictureBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblWins = new System.Windows.Forms.Label();
            this.lblLosses = new System.Windows.Forms.Label();
            this.grpStats = new System.Windows.Forms.GroupBox();
            this.lblStreak = new System.Windows.Forms.Label();
            this.lblDraws = new System.Windows.Forms.Label();
            this.btnAgain = new System.Windows.Forms.Button();
            this.tmrAnimate = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.lblRocks = new System.Windows.Forms.Label();
            this.lblPapers = new System.Windows.Forms.Label();
            this.lblScissors = new System.Windows.Forms.Label();
            this.grpWeapons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCom)).BeginInit();
            this.grpStats.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpWeapons
            // 
            this.grpWeapons.Controls.Add(this.radScissors);
            this.grpWeapons.Controls.Add(this.radPaper);
            this.grpWeapons.Controls.Add(this.radRock);
            this.grpWeapons.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpWeapons.Location = new System.Drawing.Point(12, 418);
            this.grpWeapons.Name = "grpWeapons";
            this.grpWeapons.Size = new System.Drawing.Size(150, 110);
            this.grpWeapons.TabIndex = 0;
            this.grpWeapons.TabStop = false;
            this.grpWeapons.Text = "Choose your weapon";
            // 
            // radScissors
            // 
            this.radScissors.AutoSize = true;
            this.radScissors.Location = new System.Drawing.Point(7, 77);
            this.radScissors.Name = "radScissors";
            this.radScissors.Size = new System.Drawing.Size(73, 21);
            this.radScissors.TabIndex = 2;
            this.radScissors.TabStop = true;
            this.radScissors.Text = "Scissors";
            this.radScissors.UseVisualStyleBackColor = true;
            this.radScissors.CheckedChanged += new System.EventHandler(this.radScissors_CheckedChanged);
            // 
            // radPaper
            // 
            this.radPaper.AutoSize = true;
            this.radPaper.Location = new System.Drawing.Point(7, 54);
            this.radPaper.Name = "radPaper";
            this.radPaper.Size = new System.Drawing.Size(60, 21);
            this.radPaper.TabIndex = 1;
            this.radPaper.TabStop = true;
            this.radPaper.Text = "Paper";
            this.radPaper.UseVisualStyleBackColor = true;
            this.radPaper.CheckedChanged += new System.EventHandler(this.radPaper_CheckedChanged);
            // 
            // radRock
            // 
            this.radRock.AutoSize = true;
            this.radRock.Location = new System.Drawing.Point(7, 31);
            this.radRock.Name = "radRock";
            this.radRock.Size = new System.Drawing.Size(54, 21);
            this.radRock.TabIndex = 0;
            this.radRock.TabStop = true;
            this.radRock.Text = "Rock";
            this.radRock.UseVisualStyleBackColor = true;
            this.radRock.CheckedChanged += new System.EventHandler(this.radRock_CheckedChanged);
            // 
            // btnFight
            // 
            this.btnFight.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFight.Location = new System.Drawing.Point(168, 483);
            this.btnFight.Name = "btnFight";
            this.btnFight.Size = new System.Drawing.Size(150, 44);
            this.btnFight.TabIndex = 1;
            this.btnFight.Text = "Fight!";
            this.btnFight.UseVisualStyleBackColor = true;
            this.btnFight.Click += new System.EventHandler(this.btnFight_Click);
            // 
            // imgPlayer
            // 
            this.imgPlayer.Location = new System.Drawing.Point(12, 12);
            this.imgPlayer.Name = "imgPlayer";
            this.imgPlayer.Size = new System.Drawing.Size(399, 239);
            this.imgPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgPlayer.TabIndex = 2;
            this.imgPlayer.TabStop = false;
            // 
            // imgCom
            // 
            this.imgCom.Location = new System.Drawing.Point(448, 12);
            this.imgCom.Name = "imgCom";
            this.imgCom.Size = new System.Drawing.Size(399, 239);
            this.imgCom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgCom.TabIndex = 3;
            this.imgCom.TabStop = false;
            this.imgCom.Visible = false;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Swis721 Blk BT", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(372, 305);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(136, 42);
            this.lblResult.TabIndex = 4;
            this.lblResult.Text = "label1";
            this.lblResult.Visible = false;
            // 
            // lblWins
            // 
            this.lblWins.AutoSize = true;
            this.lblWins.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWins.Location = new System.Drawing.Point(6, 16);
            this.lblWins.Name = "lblWins";
            this.lblWins.Size = new System.Drawing.Size(50, 17);
            this.lblWins.TabIndex = 5;
            this.lblWins.Text = "Wins: 0";
            // 
            // lblLosses
            // 
            this.lblLosses.AutoSize = true;
            this.lblLosses.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLosses.Location = new System.Drawing.Point(6, 35);
            this.lblLosses.Name = "lblLosses";
            this.lblLosses.Size = new System.Drawing.Size(61, 17);
            this.lblLosses.TabIndex = 6;
            this.lblLosses.Text = "Losses: 0";
            // 
            // grpStats
            // 
            this.grpStats.Controls.Add(this.lblScissors);
            this.grpStats.Controls.Add(this.lblPapers);
            this.grpStats.Controls.Add(this.lblRocks);
            this.grpStats.Controls.Add(this.label1);
            this.grpStats.Controls.Add(this.lblStreak);
            this.grpStats.Controls.Add(this.lblDraws);
            this.grpStats.Controls.Add(this.lblWins);
            this.grpStats.Controls.Add(this.lblLosses);
            this.grpStats.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpStats.Location = new System.Drawing.Point(551, 416);
            this.grpStats.Name = "grpStats";
            this.grpStats.Size = new System.Drawing.Size(296, 111);
            this.grpStats.TabIndex = 7;
            this.grpStats.TabStop = false;
            this.grpStats.Text = "Stats";
            // 
            // lblStreak
            // 
            this.lblStreak.AutoSize = true;
            this.lblStreak.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblStreak.Location = new System.Drawing.Point(7, 79);
            this.lblStreak.Name = "lblStreak";
            this.lblStreak.Size = new System.Drawing.Size(74, 17);
            this.lblStreak.TabIndex = 8;
            this.lblStreak.Text = "Streak: N/A";
            // 
            // lblDraws
            // 
            this.lblDraws.AutoSize = true;
            this.lblDraws.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblDraws.Location = new System.Drawing.Point(7, 56);
            this.lblDraws.Name = "lblDraws";
            this.lblDraws.Size = new System.Drawing.Size(58, 17);
            this.lblDraws.TabIndex = 7;
            this.lblDraws.Text = "Draws: 0";
            // 
            // btnAgain
            // 
            this.btnAgain.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnAgain.Location = new System.Drawing.Point(168, 432);
            this.btnAgain.Name = "btnAgain";
            this.btnAgain.Size = new System.Drawing.Size(150, 46);
            this.btnAgain.TabIndex = 8;
            this.btnAgain.Text = "Again!";
            this.btnAgain.UseVisualStyleBackColor = true;
            this.btnAgain.Visible = false;
            this.btnAgain.Click += new System.EventHandler(this.btnAgain_Click);
            // 
            // tmrAnimate
            // 
            this.tmrAnimate.Interval = 16;
            this.tmrAnimate.Tick += new System.EventHandler(this.tmrAnimate_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label1.Location = new System.Drawing.Point(139, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Times chosen:";
            // 
            // lblRocks
            // 
            this.lblRocks.AutoSize = true;
            this.lblRocks.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblRocks.Location = new System.Drawing.Point(150, 35);
            this.lblRocks.Name = "lblRocks";
            this.lblRocks.Size = new System.Drawing.Size(50, 17);
            this.lblRocks.TabIndex = 10;
            this.lblRocks.Text = "Rock: 0";
            // 
            // lblPapers
            // 
            this.lblPapers.AutoSize = true;
            this.lblPapers.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblPapers.Location = new System.Drawing.Point(150, 58);
            this.lblPapers.Name = "lblPapers";
            this.lblPapers.Size = new System.Drawing.Size(56, 17);
            this.lblPapers.TabIndex = 11;
            this.lblPapers.Text = "Paper: 0";
            // 
            // lblScissors
            // 
            this.lblScissors.AutoSize = true;
            this.lblScissors.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblScissors.Location = new System.Drawing.Point(150, 81);
            this.lblScissors.Name = "lblScissors";
            this.lblScissors.Size = new System.Drawing.Size(69, 17);
            this.lblScissors.TabIndex = 12;
            this.lblScissors.Text = "Scissors: 0";
            // 
            // rps
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.ClientSize = new System.Drawing.Size(873, 540);
            this.Controls.Add(this.btnAgain);
            this.Controls.Add(this.grpStats);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.imgCom);
            this.Controls.Add(this.imgPlayer);
            this.Controls.Add(this.btnFight);
            this.Controls.Add(this.grpWeapons);
            this.Name = "rps";
            this.Text = "Rock Paper Scissors";
            this.grpWeapons.ResumeLayout(false);
            this.grpWeapons.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCom)).EndInit();
            this.grpStats.ResumeLayout(false);
            this.grpStats.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpWeapons;
        private System.Windows.Forms.RadioButton radScissors;
        private System.Windows.Forms.RadioButton radPaper;
        private System.Windows.Forms.RadioButton radRock;
        private System.Windows.Forms.Button btnFight;
        private System.Windows.Forms.PictureBox imgPlayer;
        private System.Windows.Forms.PictureBox imgCom;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblWins;
        private System.Windows.Forms.Label lblLosses;
        private System.Windows.Forms.GroupBox grpStats;
        private System.Windows.Forms.Label lblStreak;
        private System.Windows.Forms.Label lblDraws;
        private System.Windows.Forms.Button btnAgain;
        private System.Windows.Forms.Timer tmrAnimate;
        private System.Windows.Forms.Label lblScissors;
        private System.Windows.Forms.Label lblPapers;
        private System.Windows.Forms.Label lblRocks;
        private System.Windows.Forms.Label label1;
    }
}

