namespace Connect4AI
{
    partial class SelectPlayers
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
            this.onePlayerButton = new System.Windows.Forms.Button();
            this.twoPlayersButton = new System.Windows.Forms.Button();
            this.aiVsAiButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.hardButton = new System.Windows.Forms.Button();
            this.mediumButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // onePlayerButton
            // 
            this.onePlayerButton.Font = new System.Drawing.Font("Tahoma", 12.5F);
            this.onePlayerButton.Location = new System.Drawing.Point(12, 60);
            this.onePlayerButton.Name = "onePlayerButton";
            this.onePlayerButton.Size = new System.Drawing.Size(387, 44);
            this.onePlayerButton.TabIndex = 0;
            this.onePlayerButton.Text = "Easy";
            this.onePlayerButton.UseVisualStyleBackColor = true;
            this.onePlayerButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // twoPlayersButton
            // 
            this.twoPlayersButton.Font = new System.Drawing.Font("Tahoma", 12.5F);
            this.twoPlayersButton.Location = new System.Drawing.Point(12, 222);
            this.twoPlayersButton.Name = "twoPlayersButton";
            this.twoPlayersButton.Size = new System.Drawing.Size(390, 44);
            this.twoPlayersButton.TabIndex = 1;
            this.twoPlayersButton.Text = "Two Players";
            this.twoPlayersButton.UseVisualStyleBackColor = true;
            this.twoPlayersButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // aiVsAiButton
            // 
            this.aiVsAiButton.Font = new System.Drawing.Font("Tahoma", 12.5F);
            this.aiVsAiButton.Location = new System.Drawing.Point(12, 322);
            this.aiVsAiButton.Name = "aiVsAiButton";
            this.aiVsAiButton.Size = new System.Drawing.Size(390, 44);
            this.aiVsAiButton.TabIndex = 2;
            this.aiVsAiButton.Text = "AI Vs. AI";
            this.aiVsAiButton.UseVisualStyleBackColor = true;
            this.aiVsAiButton.Visible = false;
            this.aiVsAiButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Tahoma", 12.5F);
            this.exitButton.Location = new System.Drawing.Point(12, 272);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(390, 44);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12.5F);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(422, 41);
            this.label1.TabIndex = 5;
            this.label1.Text = "Welcome to Connect4!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hardButton
            // 
            this.hardButton.Font = new System.Drawing.Font("Tahoma", 12.5F);
            this.hardButton.Location = new System.Drawing.Point(12, 172);
            this.hardButton.Name = "hardButton";
            this.hardButton.Size = new System.Drawing.Size(387, 44);
            this.hardButton.TabIndex = 6;
            this.hardButton.Text = "Hard";
            this.hardButton.UseVisualStyleBackColor = true;
            this.hardButton.Click += new System.EventHandler(this.hardButton_Click);
            // 
            // mediumButton
            // 
            this.mediumButton.Font = new System.Drawing.Font("Tahoma", 12.5F);
            this.mediumButton.Location = new System.Drawing.Point(15, 114);
            this.mediumButton.Name = "mediumButton";
            this.mediumButton.Size = new System.Drawing.Size(387, 44);
            this.mediumButton.TabIndex = 7;
            this.mediumButton.Text = "Medium";
            this.mediumButton.UseVisualStyleBackColor = true;
            this.mediumButton.Click += new System.EventHandler(this.mediumButton_Click);
            // 
            // SelectPlayers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 322);
            this.Controls.Add(this.mediumButton);
            this.Controls.Add(this.hardButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.aiVsAiButton);
            this.Controls.Add(this.twoPlayersButton);
            this.Controls.Add(this.onePlayerButton);
            this.Name = "SelectPlayers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome to Connect4";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button onePlayerButton;
        private System.Windows.Forms.Button twoPlayersButton;
        private System.Windows.Forms.Button aiVsAiButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button hardButton;
        private System.Windows.Forms.Button mediumButton;
    }
}