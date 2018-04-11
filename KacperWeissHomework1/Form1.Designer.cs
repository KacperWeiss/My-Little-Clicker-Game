namespace KacperWeissHomework1
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.labelWoodQuantity = new System.Windows.Forms.Label();
            this.labelStoneQuantity = new System.Windows.Forms.Label();
            this.labelGoldQuantity = new System.Windows.Forms.Label();
            this.buttonAddWood = new System.Windows.Forms.Button();
            this.buttonAddGold = new System.Windows.Forms.Button();
            this.buttonAddStone = new System.Windows.Forms.Button();
            this.timerGrowthTime = new System.Windows.Forms.Timer(this.components);
            this.labelCityName = new System.Windows.Forms.Label();
            this.pictureBoxPopulation = new System.Windows.Forms.PictureBox();
            this.pictureBoxWood = new System.Windows.Forms.PictureBox();
            this.pictureBoxStone = new System.Windows.Forms.PictureBox();
            this.labelWorkingPopulation = new System.Windows.Forms.Label();
            this.pictureBoxStoneMason = new System.Windows.Forms.PictureBox();
            this.buttonUpgradeLumberMill = new System.Windows.Forms.Button();
            this.buttonUpgradeStoneMason = new System.Windows.Forms.Button();
            this.buttonUpgradeGoldMine = new System.Windows.Forms.Button();
            this.buttonHireWoodCutter = new System.Windows.Forms.Button();
            this.buttonHireStoneGatherer = new System.Windows.Forms.Button();
            this.buttonHireGoldMiner = new System.Windows.Forms.Button();
            this.labelLumberMillUpgradeCost = new System.Windows.Forms.Label();
            this.labelStoneMasonUpgradeCost = new System.Windows.Forms.Label();
            this.labelGoldMineUpgradeCost = new System.Windows.Forms.Label();
            this.labelHireGoldMinerCost = new System.Windows.Forms.Label();
            this.labelHireStoneGathererCost = new System.Windows.Forms.Label();
            this.labelHireWoodCutterCost = new System.Windows.Forms.Label();
            this.labelLevelOfLumberMill = new System.Windows.Forms.Label();
            this.panelLumberMill = new System.Windows.Forms.Panel();
            this.panelStoneMason = new System.Windows.Forms.Panel();
            this.labelLevelOfStoneMason = new System.Windows.Forms.Label();
            this.panelGoldMine = new System.Windows.Forms.Panel();
            this.labelLevelOfGoldMine = new System.Windows.Forms.Label();
            this.buttonInstructionPopUp = new System.Windows.Forms.Button();
            this.pictureBoxGold = new System.Windows.Forms.PictureBox();
            this.pictureBoxExit = new System.Windows.Forms.PictureBox();
            this.pictureBoxLimberMill = new System.Windows.Forms.PictureBox();
            this.pictureBoxGoldMine = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPopulation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWood)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStoneMason)).BeginInit();
            this.panelLumberMill.SuspendLayout();
            this.panelStoneMason.SuspendLayout();
            this.panelGoldMine.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLimberMill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGoldMine)).BeginInit();
            this.SuspendLayout();
            // 
            // labelWoodQuantity
            // 
            this.labelWoodQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelWoodQuantity.AutoSize = true;
            this.labelWoodQuantity.BackColor = System.Drawing.Color.Transparent;
            this.labelWoodQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelWoodQuantity.Location = new System.Drawing.Point(555, 9);
            this.labelWoodQuantity.Name = "labelWoodQuantity";
            this.labelWoodQuantity.Size = new System.Drawing.Size(134, 31);
            this.labelWoodQuantity.TabIndex = 1;
            this.labelWoodQuantity.Text = "10000000";
            // 
            // labelStoneQuantity
            // 
            this.labelStoneQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelStoneQuantity.AutoSize = true;
            this.labelStoneQuantity.BackColor = System.Drawing.Color.Transparent;
            this.labelStoneQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelStoneQuantity.Location = new System.Drawing.Point(738, 9);
            this.labelStoneQuantity.Name = "labelStoneQuantity";
            this.labelStoneQuantity.Size = new System.Drawing.Size(134, 31);
            this.labelStoneQuantity.TabIndex = 3;
            this.labelStoneQuantity.Text = "10000000";
            // 
            // labelGoldQuantity
            // 
            this.labelGoldQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelGoldQuantity.AutoSize = true;
            this.labelGoldQuantity.BackColor = System.Drawing.Color.Transparent;
            this.labelGoldQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelGoldQuantity.Location = new System.Drawing.Point(921, 9);
            this.labelGoldQuantity.Name = "labelGoldQuantity";
            this.labelGoldQuantity.Size = new System.Drawing.Size(134, 31);
            this.labelGoldQuantity.TabIndex = 5;
            this.labelGoldQuantity.Text = "10000000";
            // 
            // buttonAddWood
            // 
            this.buttonAddWood.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddWood.Location = new System.Drawing.Point(511, 49);
            this.buttonAddWood.Name = "buttonAddWood";
            this.buttonAddWood.Size = new System.Drawing.Size(178, 23);
            this.buttonAddWood.TabIndex = 6;
            this.buttonAddWood.Text = "Add Wood";
            this.buttonAddWood.UseVisualStyleBackColor = true;
            this.buttonAddWood.Click += new System.EventHandler(this.ButtonAddWood_Click);
            // 
            // buttonAddGold
            // 
            this.buttonAddGold.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddGold.Location = new System.Drawing.Point(878, 49);
            this.buttonAddGold.Name = "buttonAddGold";
            this.buttonAddGold.Size = new System.Drawing.Size(177, 23);
            this.buttonAddGold.TabIndex = 7;
            this.buttonAddGold.Text = "Add Gold";
            this.buttonAddGold.UseVisualStyleBackColor = true;
            this.buttonAddGold.Click += new System.EventHandler(this.ButtonAddGold_Click);
            // 
            // buttonAddStone
            // 
            this.buttonAddStone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddStone.Location = new System.Drawing.Point(695, 49);
            this.buttonAddStone.Name = "buttonAddStone";
            this.buttonAddStone.Size = new System.Drawing.Size(177, 23);
            this.buttonAddStone.TabIndex = 8;
            this.buttonAddStone.Text = "Add Stone";
            this.buttonAddStone.UseVisualStyleBackColor = true;
            this.buttonAddStone.Click += new System.EventHandler(this.ButtonAddStone_Click);
            // 
            // timerGrowthTime
            // 
            this.timerGrowthTime.Interval = 1000;
            this.timerGrowthTime.Tick += new System.EventHandler(this.TimerGrowthTime_Tick);
            // 
            // labelCityName
            // 
            this.labelCityName.AutoSize = true;
            this.labelCityName.BackColor = System.Drawing.Color.Silver;
            this.labelCityName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelCityName.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCityName.Location = new System.Drawing.Point(11, 9);
            this.labelCityName.Name = "labelCityName";
            this.labelCityName.Size = new System.Drawing.Size(457, 44);
            this.labelCityName.TabIndex = 11;
            this.labelCityName.Text = "City - Chosen name goes here";
            this.labelCityName.Click += new System.EventHandler(this.LabelCityName_Click);
            // 
            // pictureBoxPopulation
            // 
            this.pictureBoxPopulation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxPopulation.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxPopulation.Image = global::KacperWeissHomework1.Properties.Resources.person;
            this.pictureBoxPopulation.Location = new System.Drawing.Point(1069, 9);
            this.pictureBoxPopulation.Name = "pictureBoxPopulation";
            this.pictureBoxPopulation.Size = new System.Drawing.Size(31, 31);
            this.pictureBoxPopulation.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPopulation.TabIndex = 12;
            this.pictureBoxPopulation.TabStop = false;
            // 
            // pictureBoxWood
            // 
            this.pictureBoxWood.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxWood.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxWood.Image = global::KacperWeissHomework1.Properties.Resources.woodPile;
            this.pictureBoxWood.Location = new System.Drawing.Point(511, 9);
            this.pictureBoxWood.Name = "pictureBoxWood";
            this.pictureBoxWood.Size = new System.Drawing.Size(31, 31);
            this.pictureBoxWood.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxWood.TabIndex = 9;
            this.pictureBoxWood.TabStop = false;
            // 
            // pictureBoxStone
            // 
            this.pictureBoxStone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxStone.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxStone.Image = global::KacperWeissHomework1.Properties.Resources.stonePile;
            this.pictureBoxStone.Location = new System.Drawing.Point(695, 10);
            this.pictureBoxStone.Name = "pictureBoxStone";
            this.pictureBoxStone.Size = new System.Drawing.Size(31, 31);
            this.pictureBoxStone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxStone.TabIndex = 2;
            this.pictureBoxStone.TabStop = false;
            // 
            // labelWorkingPopulation
            // 
            this.labelWorkingPopulation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelWorkingPopulation.AutoSize = true;
            this.labelWorkingPopulation.BackColor = System.Drawing.Color.Transparent;
            this.labelWorkingPopulation.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelWorkingPopulation.Location = new System.Drawing.Point(1107, 9);
            this.labelWorkingPopulation.Name = "labelWorkingPopulation";
            this.labelWorkingPopulation.Size = new System.Drawing.Size(89, 31);
            this.labelWorkingPopulation.TabIndex = 13;
            this.labelWorkingPopulation.Text = "10000";
            // 
            // pictureBoxStoneMason
            // 
            this.pictureBoxStoneMason.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxStoneMason.Location = new System.Drawing.Point(955, 524);
            this.pictureBoxStoneMason.Name = "pictureBoxStoneMason";
            this.pictureBoxStoneMason.Size = new System.Drawing.Size(209, 129);
            this.pictureBoxStoneMason.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxStoneMason.TabIndex = 15;
            this.pictureBoxStoneMason.TabStop = false;
            this.pictureBoxStoneMason.Click += new System.EventHandler(this.PictureBoxStoneMason_Click);
            // 
            // buttonUpgradeLumberMill
            // 
            this.buttonUpgradeLumberMill.Location = new System.Drawing.Point(3, 62);
            this.buttonUpgradeLumberMill.Name = "buttonUpgradeLumberMill";
            this.buttonUpgradeLumberMill.Size = new System.Drawing.Size(93, 23);
            this.buttonUpgradeLumberMill.TabIndex = 17;
            this.buttonUpgradeLumberMill.Text = "Level Up";
            this.buttonUpgradeLumberMill.UseVisualStyleBackColor = true;
            this.buttonUpgradeLumberMill.Click += new System.EventHandler(this.ButtonUpgradeLumberMill_Click);
            // 
            // buttonUpgradeStoneMason
            // 
            this.buttonUpgradeStoneMason.Location = new System.Drawing.Point(3, 62);
            this.buttonUpgradeStoneMason.Name = "buttonUpgradeStoneMason";
            this.buttonUpgradeStoneMason.Size = new System.Drawing.Size(93, 23);
            this.buttonUpgradeStoneMason.TabIndex = 18;
            this.buttonUpgradeStoneMason.Text = "Level Up";
            this.buttonUpgradeStoneMason.UseVisualStyleBackColor = true;
            this.buttonUpgradeStoneMason.Click += new System.EventHandler(this.ButtonUpgradeStoneMason_Click);
            // 
            // buttonUpgradeGoldMine
            // 
            this.buttonUpgradeGoldMine.Location = new System.Drawing.Point(3, 62);
            this.buttonUpgradeGoldMine.Name = "buttonUpgradeGoldMine";
            this.buttonUpgradeGoldMine.Size = new System.Drawing.Size(93, 23);
            this.buttonUpgradeGoldMine.TabIndex = 19;
            this.buttonUpgradeGoldMine.Text = "Level Up";
            this.buttonUpgradeGoldMine.UseVisualStyleBackColor = true;
            this.buttonUpgradeGoldMine.Click += new System.EventHandler(this.ButtonUpgradeGoldMine_Click);
            // 
            // buttonHireWoodCutter
            // 
            this.buttonHireWoodCutter.Location = new System.Drawing.Point(102, 62);
            this.buttonHireWoodCutter.Name = "buttonHireWoodCutter";
            this.buttonHireWoodCutter.Size = new System.Drawing.Size(93, 23);
            this.buttonHireWoodCutter.TabIndex = 20;
            this.buttonHireWoodCutter.Text = "Hire worker";
            this.buttonHireWoodCutter.UseVisualStyleBackColor = true;
            this.buttonHireWoodCutter.Click += new System.EventHandler(this.ButtonHireWoodCutter_Click);
            // 
            // buttonHireStoneGatherer
            // 
            this.buttonHireStoneGatherer.Location = new System.Drawing.Point(102, 62);
            this.buttonHireStoneGatherer.Name = "buttonHireStoneGatherer";
            this.buttonHireStoneGatherer.Size = new System.Drawing.Size(93, 23);
            this.buttonHireStoneGatherer.TabIndex = 21;
            this.buttonHireStoneGatherer.Text = "Hire worker";
            this.buttonHireStoneGatherer.UseVisualStyleBackColor = true;
            this.buttonHireStoneGatherer.Click += new System.EventHandler(this.ButtonHireStoneGatherer_Click);
            // 
            // buttonHireGoldMiner
            // 
            this.buttonHireGoldMiner.Location = new System.Drawing.Point(102, 62);
            this.buttonHireGoldMiner.Name = "buttonHireGoldMiner";
            this.buttonHireGoldMiner.Size = new System.Drawing.Size(93, 23);
            this.buttonHireGoldMiner.TabIndex = 22;
            this.buttonHireGoldMiner.Text = "Hire worker";
            this.buttonHireGoldMiner.UseVisualStyleBackColor = true;
            this.buttonHireGoldMiner.Click += new System.EventHandler(this.ButtonHireGoldMiner_Click);
            // 
            // labelLumberMillUpgradeCost
            // 
            this.labelLumberMillUpgradeCost.AutoSize = true;
            this.labelLumberMillUpgradeCost.BackColor = System.Drawing.SystemColors.Info;
            this.labelLumberMillUpgradeCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelLumberMillUpgradeCost.Location = new System.Drawing.Point(3, 4);
            this.labelLumberMillUpgradeCost.Name = "labelLumberMillUpgradeCost";
            this.labelLumberMillUpgradeCost.Size = new System.Drawing.Size(93, 16);
            this.labelLumberMillUpgradeCost.TabIndex = 23;
            this.labelLumberMillUpgradeCost.Text = "Upgrade cost:";
            // 
            // labelStoneMasonUpgradeCost
            // 
            this.labelStoneMasonUpgradeCost.AutoSize = true;
            this.labelStoneMasonUpgradeCost.BackColor = System.Drawing.SystemColors.Info;
            this.labelStoneMasonUpgradeCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelStoneMasonUpgradeCost.Location = new System.Drawing.Point(3, 4);
            this.labelStoneMasonUpgradeCost.Name = "labelStoneMasonUpgradeCost";
            this.labelStoneMasonUpgradeCost.Size = new System.Drawing.Size(93, 16);
            this.labelStoneMasonUpgradeCost.TabIndex = 24;
            this.labelStoneMasonUpgradeCost.Text = "Upgrade cost:";
            // 
            // labelGoldMineUpgradeCost
            // 
            this.labelGoldMineUpgradeCost.AutoSize = true;
            this.labelGoldMineUpgradeCost.BackColor = System.Drawing.SystemColors.Info;
            this.labelGoldMineUpgradeCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelGoldMineUpgradeCost.Location = new System.Drawing.Point(3, 4);
            this.labelGoldMineUpgradeCost.Name = "labelGoldMineUpgradeCost";
            this.labelGoldMineUpgradeCost.Size = new System.Drawing.Size(93, 16);
            this.labelGoldMineUpgradeCost.TabIndex = 25;
            this.labelGoldMineUpgradeCost.Text = "Upgrade cost:";
            // 
            // labelHireGoldMinerCost
            // 
            this.labelHireGoldMinerCost.AutoSize = true;
            this.labelHireGoldMinerCost.BackColor = System.Drawing.SystemColors.Info;
            this.labelHireGoldMinerCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelHireGoldMinerCost.Location = new System.Drawing.Point(102, 4);
            this.labelHireGoldMinerCost.Name = "labelHireGoldMinerCost";
            this.labelHireGoldMinerCost.Size = new System.Drawing.Size(74, 16);
            this.labelHireGoldMinerCost.TabIndex = 26;
            this.labelHireGoldMinerCost.Text = "Hiring cost:";
            // 
            // labelHireStoneGathererCost
            // 
            this.labelHireStoneGathererCost.AutoSize = true;
            this.labelHireStoneGathererCost.BackColor = System.Drawing.SystemColors.Info;
            this.labelHireStoneGathererCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelHireStoneGathererCost.Location = new System.Drawing.Point(102, 4);
            this.labelHireStoneGathererCost.Name = "labelHireStoneGathererCost";
            this.labelHireStoneGathererCost.Size = new System.Drawing.Size(74, 16);
            this.labelHireStoneGathererCost.TabIndex = 27;
            this.labelHireStoneGathererCost.Text = "Hiring cost:";
            // 
            // labelHireWoodCutterCost
            // 
            this.labelHireWoodCutterCost.AutoSize = true;
            this.labelHireWoodCutterCost.BackColor = System.Drawing.SystemColors.Info;
            this.labelHireWoodCutterCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelHireWoodCutterCost.Location = new System.Drawing.Point(102, 4);
            this.labelHireWoodCutterCost.Name = "labelHireWoodCutterCost";
            this.labelHireWoodCutterCost.Size = new System.Drawing.Size(74, 16);
            this.labelHireWoodCutterCost.TabIndex = 28;
            this.labelHireWoodCutterCost.Text = "Hiring cost:";
            // 
            // labelLevelOfLumberMill
            // 
            this.labelLevelOfLumberMill.AutoSize = true;
            this.labelLevelOfLumberMill.BackColor = System.Drawing.Color.Silver;
            this.labelLevelOfLumberMill.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelLevelOfLumberMill.Location = new System.Drawing.Point(170, 590);
            this.labelLevelOfLumberMill.Name = "labelLevelOfLumberMill";
            this.labelLevelOfLumberMill.Size = new System.Drawing.Size(47, 16);
            this.labelLevelOfLumberMill.TabIndex = 30;
            this.labelLevelOfLumberMill.Text = "Level: ";
            // 
            // panelLumberMill
            // 
            this.panelLumberMill.BackColor = System.Drawing.SystemColors.Info;
            this.panelLumberMill.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelLumberMill.Controls.Add(this.labelHireWoodCutterCost);
            this.panelLumberMill.Controls.Add(this.labelLumberMillUpgradeCost);
            this.panelLumberMill.Controls.Add(this.buttonHireWoodCutter);
            this.panelLumberMill.Controls.Add(this.buttonUpgradeLumberMill);
            this.panelLumberMill.Location = new System.Drawing.Point(364, 382);
            this.panelLumberMill.Name = "panelLumberMill";
            this.panelLumberMill.Size = new System.Drawing.Size(200, 90);
            this.panelLumberMill.TabIndex = 30;
            this.panelLumberMill.Visible = false;
            // 
            // panelStoneMason
            // 
            this.panelStoneMason.BackColor = System.Drawing.SystemColors.Info;
            this.panelStoneMason.Controls.Add(this.labelHireStoneGathererCost);
            this.panelStoneMason.Controls.Add(this.labelStoneMasonUpgradeCost);
            this.panelStoneMason.Controls.Add(this.buttonHireStoneGatherer);
            this.panelStoneMason.Controls.Add(this.buttonUpgradeStoneMason);
            this.panelStoneMason.Location = new System.Drawing.Point(1011, 444);
            this.panelStoneMason.Name = "panelStoneMason";
            this.panelStoneMason.Size = new System.Drawing.Size(200, 90);
            this.panelStoneMason.TabIndex = 31;
            this.panelStoneMason.Visible = false;
            // 
            // labelLevelOfStoneMason
            // 
            this.labelLevelOfStoneMason.AutoSize = true;
            this.labelLevelOfStoneMason.BackColor = System.Drawing.Color.Silver;
            this.labelLevelOfStoneMason.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelLevelOfStoneMason.Location = new System.Drawing.Point(952, 637);
            this.labelLevelOfStoneMason.Name = "labelLevelOfStoneMason";
            this.labelLevelOfStoneMason.Size = new System.Drawing.Size(47, 16);
            this.labelLevelOfStoneMason.TabIndex = 30;
            this.labelLevelOfStoneMason.Text = "Level: ";
            // 
            // panelGoldMine
            // 
            this.panelGoldMine.BackColor = System.Drawing.SystemColors.Info;
            this.panelGoldMine.Controls.Add(this.labelHireGoldMinerCost);
            this.panelGoldMine.Controls.Add(this.labelGoldMineUpgradeCost);
            this.panelGoldMine.Controls.Add(this.buttonHireGoldMiner);
            this.panelGoldMine.Controls.Add(this.buttonUpgradeGoldMine);
            this.panelGoldMine.Location = new System.Drawing.Point(695, 345);
            this.panelGoldMine.Name = "panelGoldMine";
            this.panelGoldMine.Size = new System.Drawing.Size(200, 90);
            this.panelGoldMine.TabIndex = 32;
            this.panelGoldMine.Visible = false;
            // 
            // labelLevelOfGoldMine
            // 
            this.labelLevelOfGoldMine.AutoSize = true;
            this.labelLevelOfGoldMine.BackColor = System.Drawing.Color.Silver;
            this.labelLevelOfGoldMine.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelLevelOfGoldMine.Location = new System.Drawing.Point(642, 549);
            this.labelLevelOfGoldMine.Name = "labelLevelOfGoldMine";
            this.labelLevelOfGoldMine.Size = new System.Drawing.Size(47, 16);
            this.labelLevelOfGoldMine.TabIndex = 30;
            this.labelLevelOfGoldMine.Text = "Level: ";
            // 
            // buttonInstructionPopUp
            // 
            this.buttonInstructionPopUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonInstructionPopUp.BackColor = System.Drawing.Color.Red;
            this.buttonInstructionPopUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonInstructionPopUp.ForeColor = System.Drawing.Color.White;
            this.buttonInstructionPopUp.Location = new System.Drawing.Point(1193, 685);
            this.buttonInstructionPopUp.Name = "buttonInstructionPopUp";
            this.buttonInstructionPopUp.Size = new System.Drawing.Size(75, 23);
            this.buttonInstructionPopUp.TabIndex = 33;
            this.buttonInstructionPopUp.Text = "Instruction";
            this.buttonInstructionPopUp.UseVisualStyleBackColor = false;
            this.buttonInstructionPopUp.Click += new System.EventHandler(this.ButtonInstructionPopUp_Click);
            // 
            // pictureBoxGold
            // 
            this.pictureBoxGold.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxGold.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxGold.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxGold.Image")));
            this.pictureBoxGold.Location = new System.Drawing.Point(878, 9);
            this.pictureBoxGold.Name = "pictureBoxGold";
            this.pictureBoxGold.Size = new System.Drawing.Size(31, 31);
            this.pictureBoxGold.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxGold.TabIndex = 34;
            this.pictureBoxGold.TabStop = false;
            // 
            // pictureBoxExit
            // 
            this.pictureBoxExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxExit.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxExit.Image = global::KacperWeissHomework1.Properties.Resources.exitDoor;
            this.pictureBoxExit.Location = new System.Drawing.Point(1218, 12);
            this.pictureBoxExit.Name = "pictureBoxExit";
            this.pictureBoxExit.Size = new System.Drawing.Size(50, 50);
            this.pictureBoxExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxExit.TabIndex = 35;
            this.pictureBoxExit.TabStop = false;
            this.pictureBoxExit.Click += new System.EventHandler(this.PictureBoxExit_Click);
            // 
            // pictureBoxLimberMill
            // 
            this.pictureBoxLimberMill.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxLimberMill.Location = new System.Drawing.Point(133, 402);
            this.pictureBoxLimberMill.Name = "pictureBoxLimberMill";
            this.pictureBoxLimberMill.Size = new System.Drawing.Size(287, 204);
            this.pictureBoxLimberMill.TabIndex = 36;
            this.pictureBoxLimberMill.TabStop = false;
            this.pictureBoxLimberMill.Click += new System.EventHandler(this.PictureBoxLimberMill_Click);
            // 
            // pictureBoxGoldMine
            // 
            this.pictureBoxGoldMine.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxGoldMine.Location = new System.Drawing.Point(603, 402);
            this.pictureBoxGoldMine.Name = "pictureBoxGoldMine";
            this.pictureBoxGoldMine.Size = new System.Drawing.Size(246, 178);
            this.pictureBoxGoldMine.TabIndex = 37;
            this.pictureBoxGoldMine.TabStop = false;
            this.pictureBoxGoldMine.Click += new System.EventHandler(this.PictureBoxGoldMine_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.labelLevelOfStoneMason);
            this.Controls.Add(this.labelLevelOfGoldMine);
            this.Controls.Add(this.labelLevelOfLumberMill);
            this.Controls.Add(this.pictureBoxExit);
            this.Controls.Add(this.pictureBoxGold);
            this.Controls.Add(this.buttonInstructionPopUp);
            this.Controls.Add(this.panelGoldMine);
            this.Controls.Add(this.panelStoneMason);
            this.Controls.Add(this.panelLumberMill);
            this.Controls.Add(this.labelWorkingPopulation);
            this.Controls.Add(this.pictureBoxPopulation);
            this.Controls.Add(this.labelCityName);
            this.Controls.Add(this.pictureBoxWood);
            this.Controls.Add(this.buttonAddStone);
            this.Controls.Add(this.buttonAddGold);
            this.Controls.Add(this.buttonAddWood);
            this.Controls.Add(this.labelGoldQuantity);
            this.Controls.Add(this.labelStoneQuantity);
            this.Controls.Add(this.pictureBoxStone);
            this.Controls.Add(this.labelWoodQuantity);
            this.Controls.Add(this.pictureBoxLimberMill);
            this.Controls.Add(this.pictureBoxGoldMine);
            this.Controls.Add(this.pictureBoxStoneMason);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Clicker Game";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPopulation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWood)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStoneMason)).EndInit();
            this.panelLumberMill.ResumeLayout(false);
            this.panelLumberMill.PerformLayout();
            this.panelStoneMason.ResumeLayout(false);
            this.panelStoneMason.PerformLayout();
            this.panelGoldMine.ResumeLayout(false);
            this.panelGoldMine.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLimberMill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGoldMine)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelWoodQuantity;
        private System.Windows.Forms.PictureBox pictureBoxStone;
        private System.Windows.Forms.Label labelStoneQuantity;
        private System.Windows.Forms.Label labelGoldQuantity;
        private System.Windows.Forms.Button buttonAddWood;
        private System.Windows.Forms.Button buttonAddGold;
        private System.Windows.Forms.Button buttonAddStone;
        private System.Windows.Forms.PictureBox pictureBoxWood;
        private System.Windows.Forms.Timer timerGrowthTime;
        private System.Windows.Forms.Label labelCityName;
        private System.Windows.Forms.PictureBox pictureBoxPopulation;
        private System.Windows.Forms.Label labelWorkingPopulation;
        private System.Windows.Forms.PictureBox pictureBoxStoneMason;
        private System.Windows.Forms.Button buttonUpgradeLumberMill;
        private System.Windows.Forms.Button buttonUpgradeStoneMason;
        private System.Windows.Forms.Button buttonUpgradeGoldMine;
        private System.Windows.Forms.Button buttonHireWoodCutter;
        private System.Windows.Forms.Button buttonHireStoneGatherer;
        private System.Windows.Forms.Button buttonHireGoldMiner;
        private System.Windows.Forms.Label labelLumberMillUpgradeCost;
        private System.Windows.Forms.Label labelStoneMasonUpgradeCost;
        private System.Windows.Forms.Label labelGoldMineUpgradeCost;
        private System.Windows.Forms.Label labelHireGoldMinerCost;
        private System.Windows.Forms.Label labelHireStoneGathererCost;
        private System.Windows.Forms.Label labelHireWoodCutterCost;
        private System.Windows.Forms.Label labelLevelOfLumberMill;
        private System.Windows.Forms.Panel panelLumberMill;
        private System.Windows.Forms.Panel panelStoneMason;
        private System.Windows.Forms.Label labelLevelOfStoneMason;
        private System.Windows.Forms.Panel panelGoldMine;
        private System.Windows.Forms.Label labelLevelOfGoldMine;
        private System.Windows.Forms.Button buttonInstructionPopUp;
        private System.Windows.Forms.PictureBox pictureBoxGold;
        private System.Windows.Forms.PictureBox pictureBoxExit;
        private System.Windows.Forms.PictureBox pictureBoxLimberMill;
        private System.Windows.Forms.PictureBox pictureBoxGoldMine;
    }
}

