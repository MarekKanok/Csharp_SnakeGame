namespace SnakeGame
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
            this.btnNewGame = new System.Windows.Forms.Button();
            this.btnSnap = new System.Windows.Forms.Button();
            this.btnLeaderBoard = new System.Windows.Forms.Button();
            this.txtScore = new System.Windows.Forms.Label();
            this.txtHighScore = new System.Windows.Forms.Label();
            this.pctBoxGameArea = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxGameArea)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNewGame
            // 
            this.btnNewGame.Location = new System.Drawing.Point(12, 12);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(117, 38);
            this.btnNewGame.TabIndex = 0;
            this.btnNewGame.Text = "New game";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.StartGame);
            // 
            // btnSnap
            // 
            this.btnSnap.Location = new System.Drawing.Point(307, 12);
            this.btnSnap.Name = "btnSnap";
            this.btnSnap.Size = new System.Drawing.Size(117, 38);
            this.btnSnap.TabIndex = 1;
            this.btnSnap.Text = "SnapShot";
            this.btnSnap.UseVisualStyleBackColor = true;
            this.btnSnap.Click += new System.EventHandler(this.takeSnapShot);
            // 
            // btnLeaderBoard
            // 
            this.btnLeaderBoard.Location = new System.Drawing.Point(159, 12);
            this.btnLeaderBoard.Name = "btnLeaderBoard";
            this.btnLeaderBoard.Size = new System.Drawing.Size(117, 38);
            this.btnLeaderBoard.TabIndex = 2;
            this.btnLeaderBoard.Text = "Leaderboard";
            this.btnLeaderBoard.UseVisualStyleBackColor = true;
            // 
            // txtScore
            // 
            this.txtScore.AutoSize = true;
            this.txtScore.Location = new System.Drawing.Point(9, 67);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(65, 13);
            this.txtScore.TabIndex = 3;
            this.txtScore.Text = "Score: 3000";
            // 
            // txtHighScore
            // 
            this.txtHighScore.AutoSize = true;
            this.txtHighScore.Location = new System.Drawing.Point(331, 67);
            this.txtHighScore.Name = "txtHighScore";
            this.txtHighScore.Size = new System.Drawing.Size(93, 13);
            this.txtHighScore.TabIndex = 4;
            this.txtHighScore.Text = "High Score:  3000";
            // 
            // pctBoxGameArea
            // 
            this.pctBoxGameArea.Location = new System.Drawing.Point(16, 83);
            this.pctBoxGameArea.Name = "pctBoxGameArea";
            this.pctBoxGameArea.Size = new System.Drawing.Size(408, 360);
            this.pctBoxGameArea.TabIndex = 5;
            this.pctBoxGameArea.TabStop = false;
            this.pctBoxGameArea.Paint += new System.Windows.Forms.PaintEventHandler(this.UpdatePictureBoxGraphics);
            // 
            // timer
            // 
            this.timer.Interval = 40;
            this.timer.Tick += new System.EventHandler(this.GameTimerEvent);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 457);
            this.Controls.Add(this.pctBoxGameArea);
            this.Controls.Add(this.txtHighScore);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.btnLeaderBoard);
            this.Controls.Add(this.btnSnap);
            this.Controls.Add(this.btnNewGame);
            this.Name = "Form1";
            this.Text = "Snake by Marek(Raven)Kanok";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxGameArea)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Button btnSnap;
        private System.Windows.Forms.Button btnLeaderBoard;
        private System.Windows.Forms.Label txtScore;
        private System.Windows.Forms.Label txtHighScore;
        private System.Windows.Forms.PictureBox pctBoxGameArea;
        private System.Windows.Forms.Timer timer;
    }
}

