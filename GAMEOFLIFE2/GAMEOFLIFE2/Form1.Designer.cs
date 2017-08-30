namespace GAMEOFLIFE2
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GridVisToolStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.headsUpVisibleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.neighborCountToolStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.runToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.randomizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fromTimeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fromCurrentSeedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fromNewSeedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusStripGenerations = new System.Windows.Forms.ToolStripStatusLabel();
            this.CellsLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.seedLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.newToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.openToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.PlayButton = new System.Windows.Forms.ToolStripButton();
            this.pauseButton = new System.Windows.Forms.ToolStripButton();
            this.nextButton = new System.Windows.Forms.ToolStripButton();
            this.color = new System.Windows.Forms.ColorDialog();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pauseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.gridVisibleContextItem = new System.Windows.Forms.ToolStripMenuItem();
            this.neighborCountContextItem = new System.Windows.Forms.ToolStripMenuItem();
            this.headsUpContextItem = new System.Windows.Forms.ToolStripMenuItem();
            this.graphicsPanel1 = new GAMEOFLIFE2.GraphicsPanel();
            this.UniverseSizeHeadUp = new System.Windows.Forms.Label();
            this.boundaryTypeHeadUp = new System.Windows.Forms.Label();
            this.cellCountHeadup = new System.Windows.Forms.Label();
            this.GenerationsHeadup = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.graphicsPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.runToolStripMenuItem,
            this.toolsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(664, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Enabled = false;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.GridVisToolStripItem,
            this.headsUpVisibleToolStripMenuItem,
            this.neighborCountToolStripItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // GridVisToolStripItem
            // 
            this.GridVisToolStripItem.Checked = true;
            this.GridVisToolStripItem.CheckOnClick = true;
            this.GridVisToolStripItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.GridVisToolStripItem.Name = "GridVisToolStripItem";
            this.GridVisToolStripItem.Size = new System.Drawing.Size(197, 22);
            this.GridVisToolStripItem.Text = "Grid Visible";
            this.GridVisToolStripItem.Click += new System.EventHandler(this.gridVisibleToolStripMenuItem_Click);
            // 
            // headsUpVisibleToolStripMenuItem
            // 
            this.headsUpVisibleToolStripMenuItem.Checked = true;
            this.headsUpVisibleToolStripMenuItem.CheckOnClick = true;
            this.headsUpVisibleToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.headsUpVisibleToolStripMenuItem.Name = "headsUpVisibleToolStripMenuItem";
            this.headsUpVisibleToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.headsUpVisibleToolStripMenuItem.Text = "Heads-Up Visible";
            this.headsUpVisibleToolStripMenuItem.Click += new System.EventHandler(this.headsUpVisibleToolStripMenuItem_Click);
            // 
            // neighborCountToolStripItem
            // 
            this.neighborCountToolStripItem.Checked = true;
            this.neighborCountToolStripItem.CheckOnClick = true;
            this.neighborCountToolStripItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.neighborCountToolStripItem.Name = "neighborCountToolStripItem";
            this.neighborCountToolStripItem.Size = new System.Drawing.Size(197, 22);
            this.neighborCountToolStripItem.Text = "Neighbor Count Visible";
            this.neighborCountToolStripItem.Click += new System.EventHandler(this.neighborCountVisibleToolStripMenuItem_Click);
            // 
            // runToolStripMenuItem
            // 
            this.runToolStripMenuItem.Enabled = false;
            this.runToolStripMenuItem.Name = "runToolStripMenuItem";
            this.runToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.runToolStripMenuItem.Text = "Run";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.randomizeToolStripMenuItem,
            this.optionsToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // randomizeToolStripMenuItem
            // 
            this.randomizeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fromTimeToolStripMenuItem,
            this.fromCurrentSeedToolStripMenuItem,
            this.fromNewSeedToolStripMenuItem});
            this.randomizeToolStripMenuItem.Name = "randomizeToolStripMenuItem";
            this.randomizeToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.randomizeToolStripMenuItem.Text = "Randomize";
            // 
            // fromTimeToolStripMenuItem
            // 
            this.fromTimeToolStripMenuItem.Name = "fromTimeToolStripMenuItem";
            this.fromTimeToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.fromTimeToolStripMenuItem.Text = "From Time";
            this.fromTimeToolStripMenuItem.Click += new System.EventHandler(this.fromTimeToolStripMenuItem_Click);
            // 
            // fromCurrentSeedToolStripMenuItem
            // 
            this.fromCurrentSeedToolStripMenuItem.Name = "fromCurrentSeedToolStripMenuItem";
            this.fromCurrentSeedToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.fromCurrentSeedToolStripMenuItem.Text = "From Current Seed";
            this.fromCurrentSeedToolStripMenuItem.Click += new System.EventHandler(this.fromCurrentSeedToolStripMenuItem_Click);
            // 
            // fromNewSeedToolStripMenuItem
            // 
            this.fromNewSeedToolStripMenuItem.Name = "fromNewSeedToolStripMenuItem";
            this.fromNewSeedToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.fromNewSeedToolStripMenuItem.Text = "From New Seed";
            this.fromNewSeedToolStripMenuItem.Click += new System.EventHandler(this.fromNewSeedToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.optionsToolStripMenuItem.Text = "Options";
            this.optionsToolStripMenuItem.Click += new System.EventHandler(this.optionsToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusStripGenerations,
            this.CellsLabel,
            this.seedLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 508);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(664, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusStripGenerations
            // 
            this.statusStripGenerations.Name = "statusStripGenerations";
            this.statusStripGenerations.Size = new System.Drawing.Size(82, 17);
            this.statusStripGenerations.Text = "Generations: 0";
            // 
            // CellsLabel
            // 
            this.CellsLabel.Name = "CellsLabel";
            this.CellsLabel.Size = new System.Drawing.Size(44, 17);
            this.CellsLabel.Text = "Cells: 0";
            // 
            // seedLabel
            // 
            this.seedLabel.Name = "seedLabel";
            this.seedLabel.Size = new System.Drawing.Size(38, 17);
            this.seedLabel.Text = "Seed: ";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripButton,
            this.openToolStripButton,
            this.saveToolStripButton,
            this.toolStripSeparator,
            this.toolStripSeparator1,
            this.PlayButton,
            this.pauseButton,
            this.nextButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(664, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // newToolStripButton
            // 
            this.newToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripButton.Image")));
            this.newToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripButton.Name = "newToolStripButton";
            this.newToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.newToolStripButton.Text = "&New";
            this.newToolStripButton.Click += new System.EventHandler(this.newToolStripButton_Click);
            // 
            // openToolStripButton
            // 
            this.openToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripButton.Image")));
            this.openToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripButton.Name = "openToolStripButton";
            this.openToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.openToolStripButton.Text = "&Open";
            this.openToolStripButton.Click += new System.EventHandler(this.openToolStripButton_Click);
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.saveToolStripButton.Text = "&Save";
            this.saveToolStripButton.Click += new System.EventHandler(this.saveToolStripButton_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // PlayButton
            // 
            this.PlayButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.PlayButton.Image = ((System.Drawing.Image)(resources.GetObject("PlayButton.Image")));
            this.PlayButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(23, 22);
            this.PlayButton.Text = "toolStripButton1";
            this.PlayButton.Click += new System.EventHandler(this.PlayButton_Click);
            // 
            // pauseButton
            // 
            this.pauseButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pauseButton.Image = ((System.Drawing.Image)(resources.GetObject("pauseButton.Image")));
            this.pauseButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pauseButton.Name = "pauseButton";
            this.pauseButton.Size = new System.Drawing.Size(23, 22);
            this.pauseButton.Text = "toolStripButton2";
            this.pauseButton.Click += new System.EventHandler(this.pauseButton_Click);
            // 
            // nextButton
            // 
            this.nextButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.nextButton.Image = ((System.Drawing.Image)(resources.GetObject("nextButton.Image")));
            this.nextButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(23, 22);
            this.nextButton.Text = "toolStripButton3";
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startToolStripMenuItem,
            this.pauseToolStripMenuItem,
            this.nextToolStripMenuItem,
            this.optionsToolStripMenuItem1});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(117, 92);
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.startToolStripMenuItem.Text = "Start";
            this.startToolStripMenuItem.Click += new System.EventHandler(this.startToolStripMenuItem_Click);
            // 
            // pauseToolStripMenuItem
            // 
            this.pauseToolStripMenuItem.Name = "pauseToolStripMenuItem";
            this.pauseToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.pauseToolStripMenuItem.Text = "Pause";
            this.pauseToolStripMenuItem.Click += new System.EventHandler(this.pauseToolStripMenuItem_Click);
            // 
            // nextToolStripMenuItem
            // 
            this.nextToolStripMenuItem.Name = "nextToolStripMenuItem";
            this.nextToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.nextToolStripMenuItem.Text = "Next";
            this.nextToolStripMenuItem.Click += new System.EventHandler(this.nextToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem1
            // 
            this.optionsToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gridVisibleContextItem,
            this.neighborCountContextItem,
            this.headsUpContextItem});
            this.optionsToolStripMenuItem1.Name = "optionsToolStripMenuItem1";
            this.optionsToolStripMenuItem1.Size = new System.Drawing.Size(116, 22);
            this.optionsToolStripMenuItem1.Text = "Options";
            // 
            // gridVisibleContextItem
            // 
            this.gridVisibleContextItem.Checked = true;
            this.gridVisibleContextItem.CheckOnClick = true;
            this.gridVisibleContextItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.gridVisibleContextItem.Name = "gridVisibleContextItem";
            this.gridVisibleContextItem.Size = new System.Drawing.Size(197, 22);
            this.gridVisibleContextItem.Text = "Grid Visible";
            this.gridVisibleContextItem.Click += new System.EventHandler(this.gridVisibleToolStripMenuItem1_Click);
            // 
            // neighborCountContextItem
            // 
            this.neighborCountContextItem.Checked = true;
            this.neighborCountContextItem.CheckOnClick = true;
            this.neighborCountContextItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.neighborCountContextItem.Name = "neighborCountContextItem";
            this.neighborCountContextItem.Size = new System.Drawing.Size(197, 22);
            this.neighborCountContextItem.Text = "Neighbor Count Visible";
            this.neighborCountContextItem.Click += new System.EventHandler(this.neighborCountVisibleToolStripMenuItem1_Click);
            // 
            // headsUpContextItem
            // 
            this.headsUpContextItem.Checked = true;
            this.headsUpContextItem.CheckOnClick = true;
            this.headsUpContextItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.headsUpContextItem.Name = "headsUpContextItem";
            this.headsUpContextItem.Size = new System.Drawing.Size(197, 22);
            this.headsUpContextItem.Text = "Heads-Up Visible";
            this.headsUpContextItem.Click += new System.EventHandler(this.headsUpVisibleToolStripMenuItem1_Click);
            // 
            // graphicsPanel1
            // 
            this.graphicsPanel1.BackColor = System.Drawing.SystemColors.Window;
            this.graphicsPanel1.ContextMenuStrip = this.contextMenuStrip2;
            this.graphicsPanel1.Controls.Add(this.UniverseSizeHeadUp);
            this.graphicsPanel1.Controls.Add(this.boundaryTypeHeadUp);
            this.graphicsPanel1.Controls.Add(this.cellCountHeadup);
            this.graphicsPanel1.Controls.Add(this.GenerationsHeadup);
            this.graphicsPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.graphicsPanel1.Location = new System.Drawing.Point(0, 49);
            this.graphicsPanel1.Name = "graphicsPanel1";
            this.graphicsPanel1.Size = new System.Drawing.Size(664, 459);
            this.graphicsPanel1.TabIndex = 3;
            this.graphicsPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.graphicsPanel1_Paint);
            this.graphicsPanel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.graphicsPanel1_MouseClick);
            // 
            // UniverseSizeHeadUp
            // 
            this.UniverseSizeHeadUp.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.UniverseSizeHeadUp.AutoSize = true;
            this.UniverseSizeHeadUp.BackColor = System.Drawing.Color.Transparent;
            this.UniverseSizeHeadUp.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UniverseSizeHeadUp.Location = new System.Drawing.Point(12, 421);
            this.UniverseSizeHeadUp.Name = "UniverseSizeHeadUp";
            this.UniverseSizeHeadUp.Size = new System.Drawing.Size(263, 15);
            this.UniverseSizeHeadUp.TabIndex = 3;
            this.UniverseSizeHeadUp.Text = "Universe Size: {Width = 20, Height = 20 }";
            // 
            // boundaryTypeHeadUp
            // 
            this.boundaryTypeHeadUp.AutoSize = true;
            this.boundaryTypeHeadUp.BackColor = System.Drawing.Color.Transparent;
            this.boundaryTypeHeadUp.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boundaryTypeHeadUp.Location = new System.Drawing.Point(13, 396);
            this.boundaryTypeHeadUp.Name = "boundaryTypeHeadUp";
            this.boundaryTypeHeadUp.Size = new System.Drawing.Size(147, 15);
            this.boundaryTypeHeadUp.TabIndex = 2;
            this.boundaryTypeHeadUp.Text = "Boundary Type: Finite";
            // 
            // cellCountHeadup
            // 
            this.cellCountHeadup.AutoSize = true;
            this.cellCountHeadup.BackColor = System.Drawing.Color.Transparent;
            this.cellCountHeadup.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cellCountHeadup.Location = new System.Drawing.Point(13, 369);
            this.cellCountHeadup.Name = "cellCountHeadup";
            this.cellCountHeadup.Size = new System.Drawing.Size(90, 15);
            this.cellCountHeadup.TabIndex = 1;
            this.cellCountHeadup.Text = "Cell Count: 0";
            // 
            // GenerationsHeadup
            // 
            this.GenerationsHeadup.AutoSize = true;
            this.GenerationsHeadup.BackColor = System.Drawing.Color.Transparent;
            this.GenerationsHeadup.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenerationsHeadup.ForeColor = System.Drawing.Color.Black;
            this.GenerationsHeadup.Location = new System.Drawing.Point(12, 344);
            this.GenerationsHeadup.Name = "GenerationsHeadup";
            this.GenerationsHeadup.Size = new System.Drawing.Size(102, 15);
            this.GenerationsHeadup.TabIndex = 0;
            this.GenerationsHeadup.Text = "Generations: 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 530);
            this.Controls.Add(this.graphicsPanel1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.contextMenuStrip2.ResumeLayout(false);
            this.graphicsPanel1.ResumeLayout(false);
            this.graphicsPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusStripGenerations;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton newToolStripButton;
        private System.Windows.Forms.ToolStripButton openToolStripButton;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private GraphicsPanel graphicsPanel1;
        private System.Windows.Forms.ToolStripButton PlayButton;
        private System.Windows.Forms.ToolStripButton pauseButton;
        private System.Windows.Forms.ToolStripButton nextButton;
        private System.Windows.Forms.ToolStripStatusLabel CellsLabel;
        private System.Windows.Forms.ColorDialog color;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem GridVisToolStripItem;
        private System.Windows.Forms.ToolStripMenuItem headsUpVisibleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem neighborCountToolStripItem;
        private System.Windows.Forms.ToolStripMenuItem runToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem randomizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fromTimeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fromCurrentSeedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fromNewSeedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pauseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem gridVisibleContextItem;
        private System.Windows.Forms.ToolStripMenuItem neighborCountContextItem;
        private System.Windows.Forms.Label UniverseSizeHeadUp;
        private System.Windows.Forms.Label boundaryTypeHeadUp;
        private System.Windows.Forms.Label cellCountHeadup;
        private System.Windows.Forms.Label GenerationsHeadup;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel seedLabel;
        private System.Windows.Forms.ToolStripMenuItem headsUpContextItem;
    }
}

