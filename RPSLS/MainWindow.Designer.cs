namespace RPSLS
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.FlavorText = new System.Windows.Forms.Label();
            this.Player1 = new System.Windows.Forms.Label();
            this.Player2 = new System.Windows.Forms.Label();
            this.Player1WinCount = new System.Windows.Forms.Label();
            this.Player2WinCount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Player2Shoot = new System.Windows.Forms.PictureBox();
            this.Player1Shoot = new System.Windows.Forms.PictureBox();
            this.Spock = new System.Windows.Forms.Button();
            this.Lizard = new System.Windows.Forms.Button();
            this.Scissors = new System.Windows.Forms.Button();
            this.Paper = new System.Windows.Forms.Button();
            this.Rock = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Player2Shoot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player1Shoot)).BeginInit();
            this.SuspendLayout();
            // 
            // FlavorText
            // 
            resources.ApplyResources(this.FlavorText, "FlavorText");
            this.FlavorText.Name = "FlavorText";
            // 
            // Player1
            // 
            resources.ApplyResources(this.Player1, "Player1");
            this.Player1.Name = "Player1";
            // 
            // Player2
            // 
            resources.ApplyResources(this.Player2, "Player2");
            this.Player2.Name = "Player2";
            // 
            // Player1WinCount
            // 
            resources.ApplyResources(this.Player1WinCount, "Player1WinCount");
            this.Player1WinCount.Name = "Player1WinCount";
            // 
            // Player2WinCount
            // 
            resources.ApplyResources(this.Player2WinCount, "Player2WinCount");
            this.Player2WinCount.Name = "Player2WinCount";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // Player2Shoot
            // 
            resources.ApplyResources(this.Player2Shoot, "Player2Shoot");
            this.Player2Shoot.Name = "Player2Shoot";
            this.Player2Shoot.TabStop = false;
            // 
            // Player1Shoot
            // 
            resources.ApplyResources(this.Player1Shoot, "Player1Shoot");
            this.Player1Shoot.Name = "Player1Shoot";
            this.Player1Shoot.TabStop = false;
            // 
            // Spock
            // 
            this.Spock.BackgroundImage = global::RPSLS.ResourceRPSLS.Spock_32;
            resources.ApplyResources(this.Spock, "Spock");
            this.Spock.Name = "Spock";
            this.Spock.Tag = "5";
            this.Spock.UseVisualStyleBackColor = true;
            this.Spock.Click += new System.EventHandler(this.GameButtonClick);
            // 
            // Lizard
            // 
            this.Lizard.BackgroundImage = global::RPSLS.ResourceRPSLS.Lizard_32;
            resources.ApplyResources(this.Lizard, "Lizard");
            this.Lizard.Name = "Lizard";
            this.Lizard.Tag = "4";
            this.Lizard.UseVisualStyleBackColor = true;
            this.Lizard.Click += new System.EventHandler(this.GameButtonClick);
            // 
            // Scissors
            // 
            this.Scissors.BackgroundImage = global::RPSLS.ResourceRPSLS.Scissors_32;
            resources.ApplyResources(this.Scissors, "Scissors");
            this.Scissors.Name = "Scissors";
            this.Scissors.Tag = "3";
            this.Scissors.UseVisualStyleBackColor = true;
            this.Scissors.Click += new System.EventHandler(this.GameButtonClick);
            // 
            // Paper
            // 
            this.Paper.BackgroundImage = global::RPSLS.ResourceRPSLS.Paper_32;
            resources.ApplyResources(this.Paper, "Paper");
            this.Paper.Name = "Paper";
            this.Paper.Tag = "2";
            this.Paper.UseVisualStyleBackColor = true;
            this.Paper.Click += new System.EventHandler(this.GameButtonClick);
            // 
            // Rock
            // 
            this.Rock.BackgroundImage = global::RPSLS.ResourceRPSLS.Rock_32;
            resources.ApplyResources(this.Rock, "Rock");
            this.Rock.Name = "Rock";
            this.Rock.Tag = "1";
            this.Rock.UseVisualStyleBackColor = true;
            this.Rock.Click += new System.EventHandler(this.GameButtonClick);
            // 
            // MainWindow
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Player2Shoot);
            this.Controls.Add(this.Player1Shoot);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Player2WinCount);
            this.Controls.Add(this.Player1WinCount);
            this.Controls.Add(this.Player2);
            this.Controls.Add(this.Player1);
            this.Controls.Add(this.FlavorText);
            this.Controls.Add(this.Spock);
            this.Controls.Add(this.Lizard);
            this.Controls.Add(this.Scissors);
            this.Controls.Add(this.Paper);
            this.Controls.Add(this.Rock);
            this.Name = "MainWindow";
            ((System.ComponentModel.ISupportInitialize)(this.Player2Shoot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player1Shoot)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Rock;
        private System.Windows.Forms.Button Paper;
        private System.Windows.Forms.Button Scissors;
        private System.Windows.Forms.Button Lizard;
        private System.Windows.Forms.Button Spock;
        private System.Windows.Forms.Label FlavorText;
        private System.Windows.Forms.Label Player1;
        private System.Windows.Forms.Label Player2;
        private System.Windows.Forms.Label Player1WinCount;
        private System.Windows.Forms.Label Player2WinCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox Player1Shoot;
        private System.Windows.Forms.PictureBox Player2Shoot;
    }
}

