namespace Game_Calculator
{
    partial class CalculatorForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabController = new System.Windows.Forms.TabControl();
            this.factorioTab = new System.Windows.Forms.TabPage();
            this.gbEnergy = new System.Windows.Forms.GroupBox();
            this.gbSolar = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSolarDemand = new System.Windows.Forms.MaskedTextBox();
            this.lblSolarDemand = new System.Windows.Forms.Label();
            this.solarDemandScr = new System.Windows.Forms.HScrollBar();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblSolarDemandResult = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.tabController.SuspendLayout();
            this.factorioTab.SuspendLayout();
            this.gbEnergy.SuspendLayout();
            this.gbSolar.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(673, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // tabController
            // 
            this.tabController.Controls.Add(this.factorioTab);
            this.tabController.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabController.Location = new System.Drawing.Point(0, 24);
            this.tabController.Name = "tabController";
            this.tabController.SelectedIndex = 0;
            this.tabController.Size = new System.Drawing.Size(673, 465);
            this.tabController.TabIndex = 0;
            // 
            // factorioTab
            // 
            this.factorioTab.Controls.Add(this.gbEnergy);
            this.factorioTab.Location = new System.Drawing.Point(4, 22);
            this.factorioTab.Name = "factorioTab";
            this.factorioTab.Padding = new System.Windows.Forms.Padding(3);
            this.factorioTab.Size = new System.Drawing.Size(665, 439);
            this.factorioTab.TabIndex = 0;
            this.factorioTab.Text = "Factorio";
            this.factorioTab.UseVisualStyleBackColor = true;
            // 
            // gbEnergy
            // 
            this.gbEnergy.Controls.Add(this.gbSolar);
            this.gbEnergy.Location = new System.Drawing.Point(8, 6);
            this.gbEnergy.Name = "gbEnergy";
            this.gbEnergy.Size = new System.Drawing.Size(651, 322);
            this.gbEnergy.TabIndex = 1;
            this.gbEnergy.TabStop = false;
            this.gbEnergy.Text = "Energy";
            // 
            // gbSolar
            // 
            this.gbSolar.Controls.Add(this.lblSolarDemandResult);
            this.gbSolar.Controls.Add(this.label1);
            this.gbSolar.Controls.Add(this.txtSolarDemand);
            this.gbSolar.Controls.Add(this.lblSolarDemand);
            this.gbSolar.Controls.Add(this.solarDemandScr);
            this.gbSolar.Location = new System.Drawing.Point(3, 16);
            this.gbSolar.Name = "gbSolar";
            this.gbSolar.Size = new System.Drawing.Size(451, 194);
            this.gbSolar.TabIndex = 0;
            this.gbSolar.TabStop = false;
            this.gbSolar.Text = "Solar energy";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(265, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "kW";
            // 
            // txtSolarDemand
            // 
            this.txtSolarDemand.Location = new System.Drawing.Point(199, 22);
            this.txtSolarDemand.Name = "txtSolarDemand";
            this.txtSolarDemand.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtSolarDemand.Size = new System.Drawing.Size(60, 20);
            this.txtSolarDemand.TabIndex = 3;
            this.txtSolarDemand.TextChanged += new System.EventHandler(this.txtSolarDemand_TextChanged);
            // 
            // lblSolarDemand
            // 
            this.lblSolarDemand.AutoSize = true;
            this.lblSolarDemand.Location = new System.Drawing.Point(6, 26);
            this.lblSolarDemand.Name = "lblSolarDemand";
            this.lblSolarDemand.Size = new System.Drawing.Size(50, 13);
            this.lblSolarDemand.TabIndex = 2;
            this.lblSolarDemand.Text = "Demand:";
            // 
            // solarDemandScr
            // 
            this.solarDemandScr.Location = new System.Drawing.Point(86, 22);
            this.solarDemandScr.Name = "solarDemandScr";
            this.solarDemandScr.Size = new System.Drawing.Size(80, 17);
            this.solarDemandScr.TabIndex = 1;
            this.solarDemandScr.ValueChanged += new System.EventHandler(this.solarDemandScr_ValueChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(673, 465);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblSolarDemandResult
            // 
            this.lblSolarDemandResult.AutoSize = true;
            this.lblSolarDemandResult.Location = new System.Drawing.Point(6, 88);
            this.lblSolarDemandResult.Name = "lblSolarDemandResult";
            this.lblSolarDemandResult.Size = new System.Drawing.Size(35, 13);
            this.lblSolarDemandResult.TabIndex = 1;
            this.lblSolarDemandResult.Text = "label2";
            // 
            // CalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 489);
            this.Controls.Add(this.tabController);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "CalculatorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game Calculator";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabController.ResumeLayout(false);
            this.factorioTab.ResumeLayout(false);
            this.gbEnergy.ResumeLayout(false);
            this.gbSolar.ResumeLayout(false);
            this.gbSolar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.TabControl tabController;
        private System.Windows.Forms.TabPage factorioTab;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox gbEnergy;
        private System.Windows.Forms.GroupBox gbSolar;
        private System.Windows.Forms.MaskedTextBox txtSolarDemand;
        private System.Windows.Forms.Label lblSolarDemand;
        private System.Windows.Forms.HScrollBar solarDemandScr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSolarDemandResult;
    }
}