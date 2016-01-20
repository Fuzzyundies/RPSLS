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
            this.Rock = new System.Windows.Forms.Button();
            this.Paper = new System.Windows.Forms.Button();
            this.Scissors = new System.Windows.Forms.Button();
            this.Lizard = new System.Windows.Forms.Button();
            this.Spock = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Rock
            // 
            resources.ApplyResources(this.Rock, "Rock");
            this.Rock.Name = "Rock";
            this.Rock.Tag = "1";
            this.Rock.UseVisualStyleBackColor = true;
            this.Rock.Click += new System.EventHandler(this.GameButtonClick);
            // 
            // Paper
            // 
            resources.ApplyResources(this.Paper, "Paper");
            this.Paper.Name = "Paper";
            this.Paper.Tag = "2";
            this.Paper.UseVisualStyleBackColor = true;
            this.Paper.Click += new System.EventHandler(this.GameButtonClick);
            // 
            // Scissors
            // 
            resources.ApplyResources(this.Scissors, "Scissors");
            this.Scissors.Name = "Scissors";
            this.Scissors.Tag = "3";
            this.Scissors.UseVisualStyleBackColor = true;
            this.Scissors.Click += new System.EventHandler(this.GameButtonClick);
            // 
            // Lizard
            // 
            resources.ApplyResources(this.Lizard, "Lizard");
            this.Lizard.Name = "Lizard";
            this.Lizard.Tag = "4";
            this.Lizard.UseVisualStyleBackColor = true;
            this.Lizard.Click += new System.EventHandler(this.GameButtonClick);
            // 
            // Spock
            // 
            resources.ApplyResources(this.Spock, "Spock");
            this.Spock.Name = "Spock";
            this.Spock.Tag = "5";
            this.Spock.UseVisualStyleBackColor = true;
            this.Spock.Click += new System.EventHandler(this.GameButtonClick);
            // 
            // MainWindow
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Spock);
            this.Controls.Add(this.Lizard);
            this.Controls.Add(this.Scissors);
            this.Controls.Add(this.Paper);
            this.Controls.Add(this.Rock);
            this.Name = "MainWindow";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Rock;
        private System.Windows.Forms.Button Paper;
        private System.Windows.Forms.Button Scissors;
        private System.Windows.Forms.Button Lizard;
        private System.Windows.Forms.Button Spock;
    }
}

