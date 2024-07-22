namespace FoodWars.View
{
    partial class AchievementUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelPlayerName = new System.Windows.Forms.Label();
            this.panelImagePlayer = new System.Windows.Forms.Panel();
            this.button_backToMainMenu = new System.Windows.Forms.Button();
            this.labelLevel = new System.Windows.Forms.Label();
            this.labelTotalIncome = new System.Windows.Forms.Label();
            this.labelAchievementName = new System.Windows.Forms.Label();
            this.labelCategory = new System.Windows.Forms.Label();
            this.labelRequirement = new System.Windows.Forms.Label();
            this.buttonPrevious = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.labelIndex = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelPlayerName
            // 
            this.labelPlayerName.AutoSize = true;
            this.labelPlayerName.BackColor = System.Drawing.Color.Transparent;
            this.labelPlayerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.labelPlayerName.Location = new System.Drawing.Point(82, 325);
            this.labelPlayerName.Name = "labelPlayerName";
            this.labelPlayerName.Size = new System.Drawing.Size(214, 39);
            this.labelPlayerName.TabIndex = 0;
            this.labelPlayerName.Text = "Player Name";
            // 
            // panelImagePlayer
            // 
            this.panelImagePlayer.Location = new System.Drawing.Point(89, 111);
            this.panelImagePlayer.Name = "panelImagePlayer";
            this.panelImagePlayer.Size = new System.Drawing.Size(200, 200);
            this.panelImagePlayer.TabIndex = 1;
            // 
            // button_backToMainMenu
            // 
            this.button_backToMainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_backToMainMenu.Location = new System.Drawing.Point(89, 441);
            this.button_backToMainMenu.Name = "button_backToMainMenu";
            this.button_backToMainMenu.Size = new System.Drawing.Size(146, 34);
            this.button_backToMainMenu.TabIndex = 10;
            this.button_backToMainMenu.Text = "Back";
            this.button_backToMainMenu.UseVisualStyleBackColor = true;
            this.button_backToMainMenu.Click += new System.EventHandler(this.button_backToMainMenu_Click);
            // 
            // labelLevel
            // 
            this.labelLevel.AutoSize = true;
            this.labelLevel.BackColor = System.Drawing.Color.Transparent;
            this.labelLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.labelLevel.Location = new System.Drawing.Point(84, 373);
            this.labelLevel.Name = "labelLevel";
            this.labelLevel.Size = new System.Drawing.Size(75, 25);
            this.labelLevel.TabIndex = 11;
            this.labelLevel.Text = "Level : ";
            // 
            // labelTotalIncome
            // 
            this.labelTotalIncome.AutoSize = true;
            this.labelTotalIncome.BackColor = System.Drawing.Color.Transparent;
            this.labelTotalIncome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.labelTotalIncome.Location = new System.Drawing.Point(84, 407);
            this.labelTotalIncome.Name = "labelTotalIncome";
            this.labelTotalIncome.Size = new System.Drawing.Size(141, 25);
            this.labelTotalIncome.TabIndex = 12;
            this.labelTotalIncome.Text = "Total Income : ";
            // 
            // labelAchievementName
            // 
            this.labelAchievementName.AutoSize = true;
            this.labelAchievementName.BackColor = System.Drawing.Color.Transparent;
            this.labelAchievementName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.labelAchievementName.Location = new System.Drawing.Point(496, 111);
            this.labelAchievementName.Name = "labelAchievementName";
            this.labelAchievementName.Size = new System.Drawing.Size(183, 25);
            this.labelAchievementName.TabIndex = 38;
            this.labelAchievementName.Text = "Achievement Name";
            // 
            // labelCategory
            // 
            this.labelCategory.AutoSize = true;
            this.labelCategory.BackColor = System.Drawing.Color.Transparent;
            this.labelCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.labelCategory.Location = new System.Drawing.Point(496, 169);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(108, 25);
            this.labelCategory.TabIndex = 39;
            this.labelCategory.Text = "Category : ";
            // 
            // labelRequirement
            // 
            this.labelRequirement.AutoSize = true;
            this.labelRequirement.BackColor = System.Drawing.Color.Transparent;
            this.labelRequirement.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.labelRequirement.Location = new System.Drawing.Point(496, 222);
            this.labelRequirement.Name = "labelRequirement";
            this.labelRequirement.Size = new System.Drawing.Size(138, 25);
            this.labelRequirement.TabIndex = 40;
            this.labelRequirement.Text = "Requirement : ";
            // 
            // buttonPrevious
            // 
            this.buttonPrevious.Location = new System.Drawing.Point(670, 288);
            this.buttonPrevious.Name = "buttonPrevious";
            this.buttonPrevious.Size = new System.Drawing.Size(75, 23);
            this.buttonPrevious.TabIndex = 42;
            this.buttonPrevious.Text = "Previous";
            this.buttonPrevious.UseVisualStyleBackColor = true;
            this.buttonPrevious.Click += new System.EventHandler(this.buttonPrevious_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(769, 288);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(75, 23);
            this.buttonNext.TabIndex = 41;
            this.buttonNext.Text = "Next";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // labelIndex
            // 
            this.labelIndex.AutoSize = true;
            this.labelIndex.BackColor = System.Drawing.Color.Transparent;
            this.labelIndex.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.labelIndex.Location = new System.Drawing.Point(784, 260);
            this.labelIndex.Name = "labelIndex";
            this.labelIndex.Size = new System.Drawing.Size(60, 25);
            this.labelIndex.TabIndex = 43;
            this.labelIndex.Text = "Index";
            this.labelIndex.Click += new System.EventHandler(this.labelIndex_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(320, 111);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // AchievementUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FoodWars.Properties.Resources.Achievements__2_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.labelIndex);
            this.Controls.Add(this.buttonPrevious);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.labelRequirement);
            this.Controls.Add(this.labelCategory);
            this.Controls.Add(this.labelAchievementName);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelTotalIncome);
            this.Controls.Add(this.labelLevel);
            this.Controls.Add(this.button_backToMainMenu);
            this.Controls.Add(this.panelImagePlayer);
            this.Controls.Add(this.labelPlayerName);
            this.Name = "AchievementUserControl";
            this.Size = new System.Drawing.Size(944, 501);
            this.Load += new System.EventHandler(this.AchievementUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPlayerName;
        private System.Windows.Forms.Panel panelImagePlayer;
        private System.Windows.Forms.Button button_backToMainMenu;
        private System.Windows.Forms.Label labelLevel;
        private System.Windows.Forms.Label labelTotalIncome;
        private System.Windows.Forms.Label labelAchievementName;
        private System.Windows.Forms.Label labelCategory;
        private System.Windows.Forms.Label labelRequirement;
        private System.Windows.Forms.Button buttonPrevious;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Label labelIndex;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
