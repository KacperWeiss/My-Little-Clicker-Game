using Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KacperWeissHomework1
{
    public partial class Form1 : Form
    {
        City city = new City("City " + Prompt.ShowQuestion("How would you like to name your city?", "City name", "Default name, click to change"));

        /// <summary>
        /// Allows relocation of form while using borderstyle none
        /// </summary>
        /// <param name="m"></param>
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 0x84:
                    base.WndProc(ref m);
                    if ((int)m.Result == 0x1)
                        m.Result = (IntPtr)0x2;
                    return;
            }

            base.WndProc(ref m);
        }

        /// <summary>
        /// Constructor initializes labels with correct values, starts timer and creates player's city
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            labelCityName.Text = city.Name;
            timerGrowthTime.Enabled = true;

            labelWorkingPopulation.Text = city.GetGatherersPopulation();
            labelWoodQuantity.Text = city.GetResource(0);
            labelStoneQuantity.Text = city.GetResource(1);
            labelGoldQuantity.Text = city.GetResource(2);
            labelLumberMillUpgradeCost.Text = $"Upgrade cost:\nWood: {city.GetUpgradeCost(0).Wood}\nStone: {city.GetUpgradeCost(0).Stone} ";
            labelStoneMasonUpgradeCost.Text = $"Upgrade cost:\nWood: {city.GetUpgradeCost(1).Wood}\nStone: {city.GetUpgradeCost(1).Stone} ";
            labelGoldMineUpgradeCost.Text = $"Upgrade cost:\nWood: {city.GetUpgradeCost(2).Wood}\nStone: {city.GetUpgradeCost(2).Stone} ";
            labelHireWoodCutterCost.Text = $"Hiring cost:\n Gold: {city.GetUpgradeCost(0).Gold}";
            labelHireStoneGathererCost.Text = $"Hiring cost:\n Gold: {city.GetUpgradeCost(1).Gold}";
            labelHireGoldMinerCost.Text = $"Hiring cost:\n Gold: {city.GetUpgradeCost(2).Gold}";
            labelLevelOfLumberMill.Text = $"Workers: {city.GetWorkersNumber(0)}\nLevel: {city.GetBuildingLevel(0)}";
            labelLevelOfStoneMason.Text = $"Workers: {city.GetWorkersNumber(1)}\nLevel: {city.GetBuildingLevel(1)}";
            labelLevelOfGoldMine.Text = $"Workers: {city.GetWorkersNumber(2)}\nLevel: {city.GetBuildingLevel(2)}";
        }

        /// <summary>
        /// On click produces wood
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonAddWood_Click(object sender, EventArgs e)
        {
            city.AddResourceOnClick(0);
            labelWoodQuantity.Text = city.GetResource(0);
        }

        /// <summary>
        /// On click produces stone
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonAddStone_Click(object sender, EventArgs e)
        {
            city.AddResourceOnClick(1);
            labelStoneQuantity.Text = city.GetResource(1);
        }

        /// <summary>
        /// On click produces gold
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonAddGold_Click(object sender, EventArgs e)
        {
            city.AddResourceOnClick(2);
            labelGoldQuantity.Text = city.GetResource(2);
        }

        /// <summary>
        /// Every tick produces all types of resource
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TimerGrowthTime_Tick(object sender, EventArgs e)
        {
            city.AddResourcesOnTick();
            labelWoodQuantity.Text = city.GetResource(0);
            labelStoneQuantity.Text = city.GetResource(1);
            labelGoldQuantity.Text = city.GetResource(2);
        }

        /// <summary>
        /// Alows user to rename city
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LabelCityName_Click(object sender, EventArgs e)
        {
            city.Rename("City " + Prompt.ShowQuestion("How would you like to rename your city?", "City new name", city.Name));
            labelCityName.Text = city.Name;
        }

        /// <summary>
        /// Upgrades lumber mill
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonUpgradeLumberMill_Click(object sender, EventArgs e)
        {
            try
            {
                city.UpgradeBuilding(0);
                labelWoodQuantity.Text = city.GetResource(0);
                labelStoneQuantity.Text = city.GetResource(1);
                labelLumberMillUpgradeCost.Text = $"Upgrade cost:\nWood: {city.GetUpgradeCost(0).Wood}\nStone: {city.GetUpgradeCost(0).Stone} ";
                labelLevelOfLumberMill.Text = $"Workers: {city.GetWorkersNumber(0)}\nLevel: {city.GetBuildingLevel(0)}";
            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        /// <summary>
        /// Upgrades stone mason
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonUpgradeStoneMason_Click(object sender, EventArgs e)
        {
            try
            {
                city.UpgradeBuilding(1);
                labelWoodQuantity.Text = city.GetResource(0);
                labelStoneQuantity.Text = city.GetResource(1);
                labelStoneMasonUpgradeCost.Text = $"Upgrade cost:\nWood: {city.GetUpgradeCost(1).Wood}\nStone: {city.GetUpgradeCost(1).Stone} ";
                labelLevelOfStoneMason.Text = $"Workers: {city.GetWorkersNumber(1)}\nLevel: {city.GetBuildingLevel(1)}";
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        /// <summary>
        /// Updates gold mine
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonUpgradeGoldMine_Click(object sender, EventArgs e)
        {
            try
            {
                city.UpgradeBuilding(2);
                labelWoodQuantity.Text = city.GetResource(0);
                labelStoneQuantity.Text = city.GetResource(1);
                labelGoldMineUpgradeCost.Text = $"Upgrade cost:\nWood: {city.GetUpgradeCost(2).Wood}\nStone: {city.GetUpgradeCost(2).Stone} ";
                labelLevelOfGoldMine.Text = $"Workers: {city.GetWorkersNumber(2)}\nLevel: {city.GetBuildingLevel(2)}";
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        /// <summary>
        /// Hires more workers to lumber mill
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonHireWoodCutter_Click(object sender, EventArgs e)
        {
            try
            {
                city.HireResourceGatherer(0);
                labelWorkingPopulation.Text = city.GetGatherersPopulation();
                labelGoldQuantity.Text = city.GetResource(0);
                labelHireWoodCutterCost.Text = $"Hiring cost:\n Gold: {city.GetUpgradeCost(0).Gold}";
                labelLevelOfLumberMill.Text = $"Workers: {city.GetWorkersNumber(0)}\nLevel: {city.GetBuildingLevel(0)}";
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        /// <summary>
        /// Hires more workers to stone mason/quarry
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonHireStoneGatherer_Click(object sender, EventArgs e)
        {
            try
            {
                city.HireResourceGatherer(1);
                labelWorkingPopulation.Text = city.GetGatherersPopulation();
                labelGoldQuantity.Text = city.GetResource(1);
                labelHireStoneGathererCost.Text = $"Hiring cost:\n Gold: {city.GetUpgradeCost(1).Gold}";
                labelLevelOfStoneMason.Text = $"Workers: {city.GetWorkersNumber(1)}\nLevel: {city.GetBuildingLevel(1)}";
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        /// <summary>
        /// Hires more workers to gold mine
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonHireGoldMiner_Click(object sender, EventArgs e)
        {
            try
            {
                city.HireResourceGatherer(2);
                labelWorkingPopulation.Text = city.GetGatherersPopulation();
                labelGoldQuantity.Text = city.GetResource(2);
                labelHireGoldMinerCost.Text = $"Hiring cost:\n Gold: {city.GetUpgradeCost(2).Gold}";
                labelLevelOfGoldMine.Text = $"Workers: {city.GetWorkersNumber(2)}\nLevel: {city.GetBuildingLevel(2)}";
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        /// <summary>
        /// Shows instruction how to play
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonInstructionPopUp_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "There are 3 resources in game: Wood, Stone and Gold:\n" +
                "You will get resources over time, but also by clicking on buttons below each resource, which in turn" +
                "will allow you to upgrade your building, or hire more workers. You can get access to upgrading menu, by " +
                "clicking on building that is interesting for you."
                );
        }

        /// <summary>
        /// Closes the program
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PictureBoxExit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("GoodBye!");
            this.Close();
        }

        /// <summary>
        /// Shows upgrading panel for lumber mill
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PictureBoxLimberMill_Click(object sender, EventArgs e)
        {
            panelLumberMill.Visible = !panelLumberMill.Visible;
        }

        /// <summary>
        /// Shows upgrading panel for gold mine
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PictureBoxGoldMine_Click(object sender, EventArgs e)
        {
            panelGoldMine.Visible = !panelGoldMine.Visible;
        }

        /// <summary>
        /// Shows upgrading panel for stone mason
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PictureBoxStoneMason_Click(object sender, EventArgs e)
        {
            panelStoneMason.Visible = !panelStoneMason.Visible;
        }
    }
}
