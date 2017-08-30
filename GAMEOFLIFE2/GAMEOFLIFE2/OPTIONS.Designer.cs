namespace GAMEOFLIFE2
{
    partial class OPTIONS
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
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.timerInterval = new System.Windows.Forms.NumericUpDown();
            this.widthChanger = new System.Windows.Forms.NumericUpDown();
            this.heightChanger = new System.Windows.Forms.NumericUpDown();
            this.timer = new System.Windows.Forms.Label();
            this.width = new System.Windows.Forms.Label();
            this.height = new System.Windows.Forms.Label();
            this.GeneralTab = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.gridColorDialog = new System.Windows.Forms.Button();
            this.backgroundColorDialog = new System.Windows.Forms.Button();
            this.liveCellDialog = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.timerInterval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.widthChanger)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heightChanger)).BeginInit();
            this.GeneralTab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // okButton
            // 
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Location = new System.Drawing.Point(54, 192);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(94, 62);
            this.okButton.TabIndex = 0;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(262, 192);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(87, 62);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "CANCEL";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // timerInterval
            // 
            this.timerInterval.Location = new System.Drawing.Point(192, 22);
            this.timerInterval.Name = "timerInterval";
            this.timerInterval.Size = new System.Drawing.Size(120, 20);
            this.timerInterval.TabIndex = 2;
            this.timerInterval.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // widthChanger
            // 
            this.widthChanger.Location = new System.Drawing.Point(192, 66);
            this.widthChanger.Name = "widthChanger";
            this.widthChanger.Size = new System.Drawing.Size(120, 20);
            this.widthChanger.TabIndex = 3;
            this.widthChanger.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // heightChanger
            // 
            this.heightChanger.Location = new System.Drawing.Point(192, 112);
            this.heightChanger.Name = "heightChanger";
            this.heightChanger.Size = new System.Drawing.Size(120, 20);
            this.heightChanger.TabIndex = 4;
            this.heightChanger.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // timer
            // 
            this.timer.AutoSize = true;
            this.timer.Location = new System.Drawing.Point(6, 24);
            this.timer.Name = "timer";
            this.timer.Size = new System.Drawing.Size(142, 13);
            this.timer.TabIndex = 5;
            this.timer.Text = "Timer Interval in Milliseconds";
            // 
            // width
            // 
            this.width.AutoSize = true;
            this.width.Location = new System.Drawing.Point(9, 68);
            this.width.Name = "width";
            this.width.Size = new System.Drawing.Size(128, 13);
            this.width.TabIndex = 6;
            this.width.Text = "Width of Universe in Cells";
            // 
            // height
            // 
            this.height.AutoSize = true;
            this.height.Location = new System.Drawing.Point(9, 119);
            this.height.Name = "height";
            this.height.Size = new System.Drawing.Size(131, 13);
            this.height.TabIndex = 7;
            this.height.Text = "Height of Universe in Cells";
            // 
            // GeneralTab
            // 
            this.GeneralTab.Controls.Add(this.tabPage1);
            this.GeneralTab.Controls.Add(this.tabPage2);
            this.GeneralTab.Location = new System.Drawing.Point(15, 12);
            this.GeneralTab.Name = "GeneralTab";
            this.GeneralTab.SelectedIndex = 0;
            this.GeneralTab.Size = new System.Drawing.Size(507, 311);
            this.GeneralTab.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.timer);
            this.tabPage1.Controls.Add(this.cancelButton);
            this.tabPage1.Controls.Add(this.timerInterval);
            this.tabPage1.Controls.Add(this.okButton);
            this.tabPage1.Controls.Add(this.width);
            this.tabPage1.Controls.Add(this.heightChanger);
            this.tabPage1.Controls.Add(this.height);
            this.tabPage1.Controls.Add(this.widthChanger);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(499, 285);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.gridColorDialog);
            this.tabPage2.Controls.Add(this.backgroundColorDialog);
            this.tabPage2.Controls.Add(this.liveCellDialog);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(499, 285);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // gridColorDialog
            // 
            this.gridColorDialog.BackColor = System.Drawing.Color.Black;
            this.gridColorDialog.Location = new System.Drawing.Point(33, 16);
            this.gridColorDialog.Name = "gridColorDialog";
            this.gridColorDialog.Size = new System.Drawing.Size(54, 33);
            this.gridColorDialog.TabIndex = 10;
            this.gridColorDialog.UseVisualStyleBackColor = false;
            this.gridColorDialog.Click += new System.EventHandler(this.gridColorDialog_Click);
            // 
            // backgroundColorDialog
            // 
            this.backgroundColorDialog.BackColor = System.Drawing.Color.White;
            this.backgroundColorDialog.Location = new System.Drawing.Point(33, 74);
            this.backgroundColorDialog.Name = "backgroundColorDialog";
            this.backgroundColorDialog.Size = new System.Drawing.Size(54, 33);
            this.backgroundColorDialog.TabIndex = 9;
            this.backgroundColorDialog.UseVisualStyleBackColor = false;
            // 
            // liveCellDialog
            // 
            this.liveCellDialog.BackColor = System.Drawing.Color.Gray;
            this.liveCellDialog.Location = new System.Drawing.Point(33, 128);
            this.liveCellDialog.Name = "liveCellDialog";
            this.liveCellDialog.Size = new System.Drawing.Size(54, 33);
            this.liveCellDialog.TabIndex = 7;
            this.liveCellDialog.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(114, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Live Cell Color";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(114, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Background Color";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Grid Color";
            // 
            // OPTIONS
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(561, 690);
            this.Controls.Add(this.GeneralTab);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OPTIONS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OPTIONS";
            ((System.ComponentModel.ISupportInitialize)(this.timerInterval)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.widthChanger)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heightChanger)).EndInit();
            this.GeneralTab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.NumericUpDown timerInterval;
        private System.Windows.Forms.NumericUpDown widthChanger;
        private System.Windows.Forms.NumericUpDown heightChanger;
        private System.Windows.Forms.Label timer;
        private System.Windows.Forms.Label width;
        private System.Windows.Forms.Label height;
        private System.Windows.Forms.TabControl GeneralTab;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button gridColorDialog;
        private System.Windows.Forms.Button backgroundColorDialog;
        private System.Windows.Forms.Button liveCellDialog;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}