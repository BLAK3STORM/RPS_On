namespace RPS_On_
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnRock = new System.Windows.Forms.Button();
            this.btnPaper = new System.Windows.Forms.Button();
            this.btnScissors = new System.Windows.Forms.Button();
            this.btnRestart = new System.Windows.Forms.Button();
            this.playerLabel = new System.Windows.Forms.Label();
            this.botLabel = new System.Windows.Forms.Label();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.countdown = new System.Windows.Forms.Label();
            this.roundLabel = new System.Windows.Forms.Label();
            this.countDownTimer = new System.Windows.Forms.Timer(this.components);
            this.picBot = new System.Windows.Forms.PictureBox();
            this.picPlayer = new System.Windows.Forms.PictureBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRock
            // 
            this.btnRock.BackColor = System.Drawing.Color.SlateGray;
            this.btnRock.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRock.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRock.ForeColor = System.Drawing.Color.Lavender;
            this.btnRock.Location = new System.Drawing.Point(24, 98);
            this.btnRock.Name = "btnRock";
            this.btnRock.Size = new System.Drawing.Size(106, 48);
            this.btnRock.TabIndex = 1;
            this.btnRock.Text = "Rock";
            this.btnRock.UseVisualStyleBackColor = false;
            this.btnRock.Click += new System.EventHandler(this.btnRock_Click);
            // 
            // btnPaper
            // 
            this.btnPaper.BackColor = System.Drawing.Color.DarkOrange;
            this.btnPaper.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPaper.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPaper.ForeColor = System.Drawing.Color.Lavender;
            this.btnPaper.Location = new System.Drawing.Point(24, 203);
            this.btnPaper.Name = "btnPaper";
            this.btnPaper.Size = new System.Drawing.Size(106, 48);
            this.btnPaper.TabIndex = 2;
            this.btnPaper.Text = "Paper";
            this.btnPaper.UseVisualStyleBackColor = false;
            this.btnPaper.Click += new System.EventHandler(this.btnPaper_Click);
            // 
            // btnScissors
            // 
            this.btnScissors.BackColor = System.Drawing.Color.Purple;
            this.btnScissors.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnScissors.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScissors.ForeColor = System.Drawing.Color.Lavender;
            this.btnScissors.Location = new System.Drawing.Point(24, 305);
            this.btnScissors.Name = "btnScissors";
            this.btnScissors.Size = new System.Drawing.Size(106, 48);
            this.btnScissors.TabIndex = 3;
            this.btnScissors.Text = "Scissors";
            this.btnScissors.UseVisualStyleBackColor = false;
            this.btnScissors.Click += new System.EventHandler(this.btnScissors_Click);
            // 
            // btnRestart
            // 
            this.btnRestart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(52)))), ((int)(((byte)(86)))));
            this.btnRestart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRestart.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestart.ForeColor = System.Drawing.Color.LimeGreen;
            this.btnRestart.Location = new System.Drawing.Point(719, 405);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(269, 74);
            this.btnRestart.TabIndex = 4;
            this.btnRestart.Text = "Restart";
            this.btnRestart.UseVisualStyleBackColor = false;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // playerLabel
            // 
            this.playerLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.playerLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.playerLabel.Font = new System.Drawing.Font("Segoe Script", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerLabel.ForeColor = System.Drawing.Color.Crimson;
            this.playerLabel.Location = new System.Drawing.Point(151, 45);
            this.playerLabel.Margin = new System.Windows.Forms.Padding(3);
            this.playerLabel.Name = "playerLabel";
            this.playerLabel.Size = new System.Drawing.Size(269, 40);
            this.playerLabel.TabIndex = 2;
            this.playerLabel.Text = "YOUR CHOICE";
            this.playerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // botLabel
            // 
            this.botLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.botLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.botLabel.Font = new System.Drawing.Font("Segoe Script", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botLabel.ForeColor = System.Drawing.Color.Crimson;
            this.botLabel.Location = new System.Drawing.Point(719, 45);
            this.botLabel.Margin = new System.Windows.Forms.Padding(3);
            this.botLabel.Name = "botLabel";
            this.botLabel.Size = new System.Drawing.Size(269, 40);
            this.botLabel.TabIndex = 2;
            this.botLabel.Text = "BOT\'S CHOICE";
            this.botLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // scoreLabel
            // 
            this.scoreLabel.BackColor = System.Drawing.SystemColors.MenuText;
            this.scoreLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.scoreLabel.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLabel.ForeColor = System.Drawing.Color.Lime;
            this.scoreLabel.Location = new System.Drawing.Point(426, 38);
            this.scoreLabel.Margin = new System.Windows.Forms.Padding(3);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(287, 48);
            this.scoreLabel.TabIndex = 2;
            this.scoreLabel.Text = "Player: 0 BOT: 0";
            this.scoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // countdown
            // 
            this.countdown.BackColor = System.Drawing.Color.Crimson;
            this.countdown.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.countdown.Font = new System.Drawing.Font("Impact", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countdown.ForeColor = System.Drawing.Color.Lavender;
            this.countdown.Location = new System.Drawing.Point(518, 218);
            this.countdown.Margin = new System.Windows.Forms.Padding(3);
            this.countdown.Name = "countdown";
            this.countdown.Size = new System.Drawing.Size(102, 48);
            this.countdown.TabIndex = 2;
            this.countdown.Text = "5\r\n";
            this.countdown.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // roundLabel
            // 
            this.roundLabel.BackColor = System.Drawing.Color.RoyalBlue;
            this.roundLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.roundLabel.Font = new System.Drawing.Font("MS UI Gothic", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundLabel.ForeColor = System.Drawing.Color.Gold;
            this.roundLabel.Location = new System.Drawing.Point(496, 356);
            this.roundLabel.Margin = new System.Windows.Forms.Padding(5);
            this.roundLabel.Name = "roundLabel";
            this.roundLabel.Size = new System.Drawing.Size(148, 46);
            this.roundLabel.TabIndex = 2;
            this.roundLabel.Text = "Rounds Left: 3";
            this.roundLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // countDownTimer
            // 
            this.countDownTimer.Interval = 1000;
            this.countDownTimer.Tick += new System.EventHandler(this.countDownTimerEvent);
            // 
            // picBot
            // 
            this.picBot.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picBot.Image = global::RPS_On_.Properties.Resources.questionmark;
            this.picBot.Location = new System.Drawing.Point(719, 98);
            this.picBot.Name = "picBot";
            this.picBot.Size = new System.Drawing.Size(269, 255);
            this.picBot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBot.TabIndex = 1;
            this.picBot.TabStop = false;
            // 
            // picPlayer
            // 
            this.picPlayer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picPlayer.Image = global::RPS_On_.Properties.Resources.questionmark;
            this.picPlayer.Location = new System.Drawing.Point(151, 98);
            this.picPlayer.Name = "picPlayer";
            this.picPlayer.Size = new System.Drawing.Size(269, 255);
            this.picPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPlayer.TabIndex = 1;
            this.picPlayer.TabStop = false;
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(52)))), ((int)(((byte)(86)))));
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStart.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.LawnGreen;
            this.btnStart.Location = new System.Drawing.Point(151, 405);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(269, 74);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start Game";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(505, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Scoreboard";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(491, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 31);
            this.label2.TabIndex = 4;
            this.label2.Text = "Time Left";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(1015, 504);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.roundLabel);
            this.Controls.Add(this.countdown);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.botLabel);
            this.Controls.Add(this.playerLabel);
            this.Controls.Add(this.picBot);
            this.Controls.Add(this.picPlayer);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnScissors);
            this.Controls.Add(this.btnPaper);
            this.Controls.Add(this.btnRock);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RPS On!";
            ((System.ComponentModel.ISupportInitialize)(this.picBot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRock;
        private System.Windows.Forms.Button btnPaper;
        private System.Windows.Forms.Button btnScissors;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.PictureBox picPlayer;
        private System.Windows.Forms.PictureBox picBot;
        private System.Windows.Forms.Label playerLabel;
        private System.Windows.Forms.Label botLabel;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Label countdown;
        private System.Windows.Forms.Label roundLabel;
        private System.Windows.Forms.Timer countDownTimer;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

