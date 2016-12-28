namespace Connect4AI
{
    public partial class Form1
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
            this.gamePanel = new System.Windows.Forms.Panel();
            this.infoLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.restartButton = new System.Windows.Forms.Button();
            this.c1label = new System.Windows.Forms.Label();
            this.c2label = new System.Windows.Forms.Label();
            this.c3label = new System.Windows.Forms.Label();
            this.c4label = new System.Windows.Forms.Label();
            this.c5label = new System.Windows.Forms.Label();
            this.c6label = new System.Windows.Forms.Label();
            this.c7label = new System.Windows.Forms.Label();
            this.gainLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gamePanel
            // 
            this.gamePanel.Location = new System.Drawing.Point(63, 44);
            this.gamePanel.Name = "gamePanel";
            this.gamePanel.Size = new System.Drawing.Size(700, 668);
            this.gamePanel.TabIndex = 0;
            this.gamePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.gamePanel_Paint);
            this.gamePanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gamePanel_MouseClick);
            // 
            // infoLabel
            // 
            this.infoLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.infoLabel.Font = new System.Drawing.Font("Tahoma", 12.5F);
            this.infoLabel.Location = new System.Drawing.Point(0, 0);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(830, 89);
            this.infoLabel.TabIndex = 4;
            this.infoLabel.Text = "Click a column to add a disk.";
            this.infoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 60F);
            this.label2.Location = new System.Drawing.Point(12, 708);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(700, 97);
            this.label2.TabIndex = 3;
            this.label2.Text = "Winner";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Visible = false;
            // 
            // restartButton
            // 
            this.restartButton.Font = new System.Drawing.Font("Tahoma", 12.5F);
            this.restartButton.Location = new System.Drawing.Point(663, 761);
            this.restartButton.Name = "restartButton";
            this.restartButton.Size = new System.Drawing.Size(100, 38);
            this.restartButton.TabIndex = 5;
            this.restartButton.Text = "Restart";
            this.restartButton.UseVisualStyleBackColor = true;
            this.restartButton.Click += new System.EventHandler(this.restartButton_Click);
            // 
            // c1label
            // 
            this.c1label.AutoSize = true;
            this.c1label.Font = new System.Drawing.Font("Tahoma", 12.5F);
            this.c1label.Location = new System.Drawing.Point(13, 708);
            this.c1label.Name = "c1label";
            this.c1label.Size = new System.Drawing.Size(79, 21);
            this.c1label.TabIndex = 6;
            this.c1label.Text = "Column 1";
            this.c1label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // c2label
            // 
            this.c2label.AutoSize = true;
            this.c2label.Font = new System.Drawing.Font("Tahoma", 12.5F);
            this.c2label.Location = new System.Drawing.Point(100, 708);
            this.c2label.Name = "c2label";
            this.c2label.Size = new System.Drawing.Size(79, 21);
            this.c2label.TabIndex = 7;
            this.c2label.Text = "Column 2";
            this.c2label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // c3label
            // 
            this.c3label.AutoSize = true;
            this.c3label.Font = new System.Drawing.Font("Tahoma", 12.5F);
            this.c3label.Location = new System.Drawing.Point(180, 715);
            this.c3label.Name = "c3label";
            this.c3label.Size = new System.Drawing.Size(79, 21);
            this.c3label.TabIndex = 8;
            this.c3label.Text = "Column 3";
            this.c3label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // c4label
            // 
            this.c4label.AutoSize = true;
            this.c4label.Font = new System.Drawing.Font("Tahoma", 12.5F);
            this.c4label.Location = new System.Drawing.Point(251, 708);
            this.c4label.Name = "c4label";
            this.c4label.Size = new System.Drawing.Size(79, 21);
            this.c4label.TabIndex = 9;
            this.c4label.Text = "Column 4";
            this.c4label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // c5label
            // 
            this.c5label.AutoSize = true;
            this.c5label.Font = new System.Drawing.Font("Tahoma", 12.5F);
            this.c5label.Location = new System.Drawing.Point(320, 715);
            this.c5label.Name = "c5label";
            this.c5label.Size = new System.Drawing.Size(79, 21);
            this.c5label.TabIndex = 10;
            this.c5label.Text = "Column 5";
            this.c5label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // c6label
            // 
            this.c6label.AutoSize = true;
            this.c6label.Font = new System.Drawing.Font("Tahoma", 12.5F);
            this.c6label.Location = new System.Drawing.Point(413, 708);
            this.c6label.Name = "c6label";
            this.c6label.Size = new System.Drawing.Size(79, 21);
            this.c6label.TabIndex = 11;
            this.c6label.Text = "Column 6";
            this.c6label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // c7label
            // 
            this.c7label.AutoSize = true;
            this.c7label.Font = new System.Drawing.Font("Tahoma", 12.5F);
            this.c7label.Location = new System.Drawing.Point(500, 715);
            this.c7label.Name = "c7label";
            this.c7label.Size = new System.Drawing.Size(79, 21);
            this.c7label.TabIndex = 12;
            this.c7label.Text = "Column 7";
            this.c7label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gainLabel
            // 
            this.gainLabel.AutoSize = true;
            this.gainLabel.Font = new System.Drawing.Font("Tahoma", 12.5F);
            this.gainLabel.Location = new System.Drawing.Point(12, 708);
            this.gainLabel.Name = "gainLabel";
            this.gainLabel.Size = new System.Drawing.Size(43, 21);
            this.gainLabel.TabIndex = 13;
            this.gainLabel.Text = "Gain";
            this.gainLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 811);
            this.Controls.Add(this.gainLabel);
            this.Controls.Add(this.c7label);
            this.Controls.Add(this.c6label);
            this.Controls.Add(this.c5label);
            this.Controls.Add(this.c4label);
            this.Controls.Add(this.c3label);
            this.Controls.Add(this.c2label);
            this.Controls.Add(this.c1label);
            this.Controls.Add(this.restartButton);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gamePanel);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Connect 4";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Panel gamePanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.Button restartButton;
        private System.Windows.Forms.Label c1label;
        private System.Windows.Forms.Label c2label;
        private System.Windows.Forms.Label c3label;
        private System.Windows.Forms.Label c4label;
        private System.Windows.Forms.Label c5label;
        private System.Windows.Forms.Label c6label;
        private System.Windows.Forms.Label c7label;
        private System.Windows.Forms.Label gainLabel;
    }
}

