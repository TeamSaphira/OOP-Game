namespace TowerDeffence.GameObjects
{
    partial class InitialWindow
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
            this.labelTitleGame = new System.Windows.Forms.Label();
            this.startGame = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelPlayerName = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitleGame
            // 
            this.labelTitleGame.AutoSize = true;
            this.labelTitleGame.Font = new System.Drawing.Font("Old English Text MT", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitleGame.ForeColor = System.Drawing.Color.GhostWhite;
            this.labelTitleGame.Image = global::TowerDeffence.Properties.Resources.playField;
            this.labelTitleGame.Location = new System.Drawing.Point(8, 9);
            this.labelTitleGame.Name = "labelTitleGame";
            this.labelTitleGame.Size = new System.Drawing.Size(271, 42);
            this.labelTitleGame.TabIndex = 0;
            this.labelTitleGame.Text = "Saphira Defence";
            this.labelTitleGame.Click += new System.EventHandler(this.labelTitleGame_Click);
            // 
            // startGame
            // 
            this.startGame.Font = new System.Drawing.Font("Old English Text MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startGame.Location = new System.Drawing.Point(83, 214);
            this.startGame.Name = "startGame";
            this.startGame.Size = new System.Drawing.Size(129, 36);
            this.startGame.TabIndex = 1;
            this.startGame.Text = "Start Game";
            this.startGame.UseVisualStyleBackColor = true;
            this.startGame.Click += new System.EventHandler(this.startGame_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TowerDeffence.Properties.Resources.playField;
            this.pictureBox1.Location = new System.Drawing.Point(-4, -4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(297, 286);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // labelPlayerName
            // 
            this.labelPlayerName.Cursor = System.Windows.Forms.Cursors.SizeNESW;
            this.labelPlayerName.Location = new System.Drawing.Point(12, 118);
            this.labelPlayerName.Name = "labelPlayerName";
            this.labelPlayerName.Size = new System.Drawing.Size(65, 20);
            this.labelPlayerName.TabIndex = 3;
            this.labelPlayerName.Text = "Name: ";
            this.labelPlayerName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelPlayerName.Click += new System.EventHandler(this.labelPlayerName_Click);
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(83, 118);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(189, 20);
            this.name.TabIndex = 4;
            this.name.TextChanged += new System.EventHandler(this.name_TextChanged);
            // 
            // InitialWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.name);
            this.Controls.Add(this.labelPlayerName);
            this.Controls.Add(this.startGame);
            this.Controls.Add(this.labelTitleGame);
            this.Controls.Add(this.pictureBox1);
            this.Name = "InitialWindow";
            this.Text = "Spahira Defence";
            this.Load += new System.EventHandler(this.InitialWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitleGame;
        private System.Windows.Forms.Button startGame;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelPlayerName;
        private System.Windows.Forms.TextBox name;
    }
}