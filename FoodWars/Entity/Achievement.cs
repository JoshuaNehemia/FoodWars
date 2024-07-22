using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace FoodWars.Entity
{
    [Serializable]
    public class Achievement
    {
        #region DATA MEMBER
        private Image picture;
        private int requirement;
        private string name;
        private int rank;
        private int category;
        #endregion
        #region CONSTRUCTORS
        public Achievement(int category, int input)
        {
            CreateAchievement(category, input);
        }
        #endregion
        #region

        public int Requirement
        {
            get => requirement;
            private set
            {
                if (value == 0)
                {
                    throw new Exception("Achievement must have a requirement and can't be zero");
                }
                else
                {
                    requirement = value;
                }
            }

        }
        public string Name
        {
            get => name;
            set
            {
                if (value == "")
                {

                    throw new Exception("Achievement must have a name and can't be empty");

                }
                else
                {

                    name = value;

                }


            }
        }

        public int Rank
        {
            get => rank;
            set
            {
                if (value >= 0)
                {

                    rank = value;

                }
                else
                {
                    value = 0;
                }
            }
        }

        public int Category { get => category; set => category = value; }
        public Image Picture { get => picture; set => picture = value; }
        #endregion
        #region METHOD
        // INT CATEGORY !!!!
        //Level = 0; Total Income = 1; Total Successs Customer = 2;
        //Membuat Achievement
        private void CreateAchievement(int category, int input)
        {

            int rank = RankAchievement(ListRequirement(category), input);
            if (rank != 0)
            {
                this.Category = category;
                this.Rank = rank;
                this.Name = GenerateName(category);
                this.Requirement = ListRequirement(category)[this.Rank - 1];
                this.Picture = PictureSelector(this.Rank);
            }
            else
            {
                //Achievement Not Generated
                return;
            }
        }
        private bool CheckAchievement(int category, int input)
        {
            int rank = RankAchievement(ListRequirement(category), input);
            return (rank != 0);

        }
        //Untuk menentukan rank berapa di achievement tersebut
        private int RankAchievement(List<int> requirement, int input)
        {
            int result = 0;

            for (int i = 0; i < requirement.Count(); i++)
            {
                if (requirement[i] <= input)
                {
                    result++;
                }
            }
            return result;
        }



        private List<int> ListRequirement(int category)
        {
            List<int> requirement;
            if (category == 0)
            {
                requirement = new List<int>() { 10, 50, 100, 200, 300, 500, 750, 1_000 };
            }
            else if (category == 1)
            {
                requirement = new List<int>() { 10000, 50000, 100000, 200000, 300000, 500000, 750000, 1000000 };
            }
            else
            {
                requirement = new List<int>() { 10, 50, 100, 200, 300, 500, 750, 1_000 };
            }
            return requirement;
        }


        private string GenerateName(int category)
        {
            string name = "";

            List<string> rankName = new List<string>() { "Plastic", "Wood", "Iron", "Bronze", "Silver", "Gold", "Platinum", "Diamond" };
            //GANTI INDEX
            name += rankName[(this.Rank - 1)] + " Rank ";

            if (category == 0)
            {
                name += " in Level";
            }
            else if (category == 1)
            {
                name += " in Total Income";
            }
            else
            {
                name += " in Customer Served";
            }
            return name;
        }
        private Image PictureSelector(int rank)
        {
            Image selectedImage = null;

            switch (rank)
            {
                case 1:
                    {
                        selectedImage = Properties.Resources.Plastic;

                        break;
                    }
                case 2:
                    {
                        selectedImage = Properties.Resources.Wood;
                        break;
                    }
                case 3:
                    {
                        selectedImage = Properties.Resources.Metal;
                        break;
                    }
                case 4:
                    {
                        selectedImage = Properties.Resources.Bronze;
                        break;
                    }
                case 5:
                    {
                        selectedImage = Properties.Resources.Silver;
                        break;
                    }
                case 6:
                    {
                        selectedImage = Properties.Resources.Gold;
                        break;
                    }
                case 7:
                    {
                        selectedImage = Properties.Resources.Platinum;
                        break;
                    }
                case 8:
                    {
                        selectedImage = Properties.Resources.Diamond;
                        break;
                    }
            }
            return selectedImage;
        }

        #endregion
    }
}
