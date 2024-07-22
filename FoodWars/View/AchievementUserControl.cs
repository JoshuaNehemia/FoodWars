using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodWars.View
{
    public partial class AchievementUserControl : UserControl
    {
        #region Data Members
        private BaseForm baseForm;
        private int pageIndex =0;
        #endregion

        #region Constructors
        public AchievementUserControl(BaseForm baseForm)
        {
            InitializeComponent();
            this.BaseForm = baseForm;
        }
        #endregion

        #region Properties
        private BaseForm BaseForm
        {
            get => baseForm;
            set
            {
                if (value == null) throw new Exception("No base form specified!");
                else this.baseForm = value;
            }
        }
        #endregion


        private void AchievementUserControl_Load(object sender, EventArgs e)
        {
            UpdateDisplay(pageIndex);
        }

        private void button_backToMainMenu_Click(object sender, EventArgs e)
        {
            SwitchPlayerUserControl switchPlayer = new SwitchPlayerUserControl(BaseForm);

            BaseForm.mainPanel.Controls.Remove(this);
            BaseForm.mainPanel.Controls.Add(switchPlayer);
            switchPlayer.Dock = DockStyle.Fill;
        }

        private void labelIndex_Click(object sender, EventArgs e)
        {

        }

        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            if ((pageIndex - 1) >= 0)
            {
                pageIndex--;
                UpdateDisplay(pageIndex);
            }
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if ((pageIndex + 1) < baseForm.Game.Player.ListAchievements.Count())
            {
                pageIndex++;

                UpdateDisplay(pageIndex);
            }
        }
        #region METHOD

        private void UpdateDisplay(int index)
        {
            labelPlayerName.Text = baseForm.Game.Player.Name;
            labelLevel.Text = "Level : " + baseForm.Game.Player.Level;
            labelTotalIncome.Text = "Total Income : " + baseForm.Game.Player.TotalIncome;
            panelImagePlayer.BackgroundImage = baseForm.Game.Player.Picture;
            panelImagePlayer.BackgroundImageLayout = ImageLayout.Stretch;
            labelAchievementName.Text = baseForm.Game.Player.ListAchievements[index].Name;
            if (baseForm.Game.Player.ListAchievements[index].Category == 0)
                labelCategory.Text = "Category : Level Achieved"; 
            if (baseForm.Game.Player.ListAchievements[index].Category == 1)
                labelCategory.Text = "Category : Total Income";
            if (baseForm.Game.Player.ListAchievements[index].Category == 2)
                labelCategory.Text = "Category : Customer Served";
            labelRequirement.Text = "Requirement : " + baseForm.Game.Player.ListAchievements[index].Requirement;
            labelIndex.Text = (index+1).ToString() + " / " + baseForm.Game.Player.ListAchievements.Count;
            pictureBox1.BackgroundImage = baseForm.Game.Player.ListAchievements[index].Picture;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;

        }


        #endregion



    }
}
