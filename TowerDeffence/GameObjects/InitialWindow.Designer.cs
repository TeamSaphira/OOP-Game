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
            this.name = new System.Windows.Forms.TextBox();
            this.enterName = new System.Windows.Forms.Label();
            this.teamAutors = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelTitleGame
            // 
            this.labelTitleGame.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.labelTitleGame.Font = new System.Drawing.Font("Old English Text MT", 60.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitleGame.ForeColor = System.Drawing.Color.GhostWhite;
            this.labelTitleGame.Image = global::TowerDeffence.Properties.Resources.playField;
            this.labelTitleGame.Location = new System.Drawing.Point(110, 170);
            this.labelTitleGame.Name = "labelTitleGame";
            this.labelTitleGame.Size = new System.Drawing.Size(598, 121);
            this.labelTitleGame.TabIndex = 0;
            this.labelTitleGame.Text = "Saphira Defence";
            this.labelTitleGame.Click += new System.EventHandler(this.labelTitleGame_Click);
            // 
            // startGame
            // 
            this.startGame.Font = new System.Drawing.Font("Old English Text MT", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startGame.Location = new System.Drawing.Point(220, 489);
            this.startGame.Name = "startGame";
            this.startGame.Size = new System.Drawing.Size(363, 83);
            this.startGame.TabIndex = 1;
            this.startGame.Text = "Start Game";
            this.startGame.UseVisualStyleBackColor = true;
            this.startGame.Click += new System.EventHandler(this.startGame_Click);
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(335, 331);
            this.name.Multiline = true;
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(296, 46);
            this.name.TabIndex = 4;
            this.name.TextChanged += new System.EventHandler(this.name_TextChanged);
            // 
            // enterName
            // 
            this.enterName.Font = new System.Drawing.Font("Old English Text MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterName.Location = new System.Drawing.Point(150, 331);
            this.enterName.Name = "enterName";
            this.enterName.Size = new System.Drawing.Size(161, 46);
            this.enterName.TabIndex = 5;
            this.enterName.Text = "Enter your name: ";
            this.enterName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.enterName.Click += new System.EventHandler(this.label1_Click);
            // 
            // teamAutors
            // 
            this.teamAutors.AutoEllipsis = true;
            this.teamAutors.Font = new System.Drawing.Font("Old English Text MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamAutors.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.teamAutors.Image = global::TowerDeffence.Properties.Resources.playField;
            this.teamAutors.Location = new System.Drawing.Point(563, 133);
            this.teamAutors.Name = "teamAutors";
            this.teamAutors.Size = new System.Drawing.Size(210, 37);
            this.teamAutors.TabIndex = 6;
            this.teamAutors.Text = "Created by Saphira Team ";
            this.teamAutors.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // InitialWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TowerDeffence.Properties.Resources.playField;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.teamAutors);
            this.Controls.Add(this.enterName);
            this.Controls.Add(this.name);
            this.Controls.Add(this.startGame);
            this.Controls.Add(this.labelTitleGame);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InitialWindow";
            this.Text = "Spahira Defence";
            this.Load += new System.EventHandler(this.InitialWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitleGame;
        private System.Windows.Forms.Button startGame;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label enterName;
        private System.Windows.Forms.Label teamAutors;
    }
}