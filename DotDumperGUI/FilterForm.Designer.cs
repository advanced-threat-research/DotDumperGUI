
namespace DotDumperGUI
{
    partial class FilterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FilterForm));
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.BtnDeleteAllFilters = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.LstFilters = new System.Windows.Forms.ListBox();
            this.CntxtFilters = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteSelectedFilterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearAllFiltersToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ChckOriginatingCallsOnly = new System.Windows.Forms.CheckBox();
            this.ChckFileRelatedEntriesOnly = new System.Windows.Forms.CheckBox();
            this.CmbType = new System.Windows.Forms.ComboBox();
            this.BtnExclude = new System.Windows.Forms.Button();
            this.BtnInclude = new System.Windows.Forms.Button();
            this.TxtValue = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFiltersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addFiltersFromFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFiltersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteSelectedFilterToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.clearAllFiltersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox4.SuspendLayout();
            this.CntxtFilters.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.BtnDeleteAllFilters);
            this.groupBox4.Controls.Add(this.BtnDelete);
            this.groupBox4.Controls.Add(this.LstFilters);
            this.groupBox4.Location = new System.Drawing.Point(295, 27);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(698, 400);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Filters";
            // 
            // BtnDeleteAllFilters
            // 
            this.BtnDeleteAllFilters.Location = new System.Drawing.Point(514, 362);
            this.BtnDeleteAllFilters.Name = "BtnDeleteAllFilters";
            this.BtnDeleteAllFilters.Size = new System.Drawing.Size(97, 23);
            this.BtnDeleteAllFilters.TabIndex = 8;
            this.BtnDeleteAllFilters.Text = "Delete all filters";
            this.BtnDeleteAllFilters.UseVisualStyleBackColor = true;
            this.BtnDeleteAllFilters.Click += new System.EventHandler(this.BtnDeleteAllFilters_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(617, 362);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(75, 23);
            this.BtnDelete.TabIndex = 7;
            this.BtnDelete.Text = "Delete filter";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // LstFilters
            // 
            this.LstFilters.ContextMenuStrip = this.CntxtFilters;
            this.LstFilters.FormattingEnabled = true;
            this.LstFilters.HorizontalScrollbar = true;
            this.LstFilters.ItemHeight = 15;
            this.LstFilters.Location = new System.Drawing.Point(6, 22);
            this.LstFilters.Name = "LstFilters";
            this.LstFilters.Size = new System.Drawing.Size(686, 334);
            this.LstFilters.TabIndex = 6;
            // 
            // CntxtFilters
            // 
            this.CntxtFilters.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteSelectedFilterToolStripMenuItem,
            this.clearAllFiltersToolStripMenuItem1});
            this.CntxtFilters.Name = "CntxtFilters";
            this.CntxtFilters.Size = new System.Drawing.Size(181, 48);
            // 
            // deleteSelectedFilterToolStripMenuItem
            // 
            this.deleteSelectedFilterToolStripMenuItem.Name = "deleteSelectedFilterToolStripMenuItem";
            this.deleteSelectedFilterToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deleteSelectedFilterToolStripMenuItem.Text = "Delete selected filter";
            this.deleteSelectedFilterToolStripMenuItem.Click += new System.EventHandler(this.deleteSelectedFilterToolStripMenuItem_Click);
            // 
            // clearAllFiltersToolStripMenuItem1
            // 
            this.clearAllFiltersToolStripMenuItem1.Name = "clearAllFiltersToolStripMenuItem1";
            this.clearAllFiltersToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.clearAllFiltersToolStripMenuItem1.Text = "Clear all filters";
            this.clearAllFiltersToolStripMenuItem1.Click += new System.EventHandler(this.clearAllFiltersToolStripMenuItem1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ChckOriginatingCallsOnly);
            this.groupBox2.Controls.Add(this.ChckFileRelatedEntriesOnly);
            this.groupBox2.Controls.Add(this.CmbType);
            this.groupBox2.Controls.Add(this.BtnExclude);
            this.groupBox2.Controls.Add(this.BtnInclude);
            this.groupBox2.Controls.Add(this.TxtValue);
            this.groupBox2.Location = new System.Drawing.Point(12, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(277, 185);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filtering";
            // 
            // ChckOriginatingCallsOnly
            // 
            this.ChckOriginatingCallsOnly.AutoSize = true;
            this.ChckOriginatingCallsOnly.Location = new System.Drawing.Point(7, 152);
            this.ChckOriginatingCallsOnly.Name = "ChckOriginatingCallsOnly";
            this.ChckOriginatingCallsOnly.Size = new System.Drawing.Size(259, 19);
            this.ChckOriginatingCallsOnly.TabIndex = 7;
            this.ChckOriginatingCallsOnly.Text = "Only show calls originating from the sample";
            this.ChckOriginatingCallsOnly.UseVisualStyleBackColor = true;
            this.ChckOriginatingCallsOnly.CheckedChanged += new System.EventHandler(this.ChckOriginatingCallsOnly_CheckedChanged);
            // 
            // ChckFileRelatedEntriesOnly
            // 
            this.ChckFileRelatedEntriesOnly.AutoSize = true;
            this.ChckFileRelatedEntriesOnly.Location = new System.Drawing.Point(7, 126);
            this.ChckFileRelatedEntriesOnly.Name = "ChckFileRelatedEntriesOnly";
            this.ChckFileRelatedEntriesOnly.Size = new System.Drawing.Size(204, 19);
            this.ChckFileRelatedEntriesOnly.TabIndex = 6;
            this.ChckFileRelatedEntriesOnly.Text = "Only show file related hook traces";
            this.ChckFileRelatedEntriesOnly.UseVisualStyleBackColor = true;
            this.ChckFileRelatedEntriesOnly.CheckedChanged += new System.EventHandler(this.ChckFileRelatedEntriesOnly_CheckedChanged);
            // 
            // CmbType
            // 
            this.CmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbType.FormattingEnabled = true;
            this.CmbType.Items.AddRange(new object[] {
            "Originating Sample Name",
            "Originating Sample Hash",
            "Parent Hash",
            "Resource Name",
            "Related Files Hash",
            "Function Name",
            "Excluded Entry"});
            this.CmbType.Location = new System.Drawing.Point(7, 23);
            this.CmbType.Name = "CmbType";
            this.CmbType.Size = new System.Drawing.Size(264, 23);
            this.CmbType.TabIndex = 0;
            // 
            // BtnExclude
            // 
            this.BtnExclude.Location = new System.Drawing.Point(196, 82);
            this.BtnExclude.Name = "BtnExclude";
            this.BtnExclude.Size = new System.Drawing.Size(75, 23);
            this.BtnExclude.TabIndex = 3;
            this.BtnExclude.Text = "Exclude";
            this.BtnExclude.UseVisualStyleBackColor = true;
            this.BtnExclude.Click += new System.EventHandler(this.BtnExclude_Click);
            // 
            // BtnInclude
            // 
            this.BtnInclude.Location = new System.Drawing.Point(6, 82);
            this.BtnInclude.Name = "BtnInclude";
            this.BtnInclude.Size = new System.Drawing.Size(75, 23);
            this.BtnInclude.TabIndex = 2;
            this.BtnInclude.Text = "Include";
            this.BtnInclude.UseVisualStyleBackColor = true;
            this.BtnInclude.Click += new System.EventHandler(this.BtnInclude_Click);
            // 
            // TxtValue
            // 
            this.TxtValue.Location = new System.Drawing.Point(6, 53);
            this.TxtValue.Name = "TxtValue";
            this.TxtValue.PlaceholderText = "(Partial) filter value";
            this.TxtValue.Size = new System.Drawing.Size(265, 23);
            this.TxtValue.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1005, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFiltersToolStripMenuItem,
            this.addFiltersFromFileToolStripMenuItem,
            this.saveFiltersToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openFiltersToolStripMenuItem
            // 
            this.openFiltersToolStripMenuItem.Name = "openFiltersToolStripMenuItem";
            this.openFiltersToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openFiltersToolStripMenuItem.Size = new System.Drawing.Size(251, 22);
            this.openFiltersToolStripMenuItem.Text = "Open filters";
            this.openFiltersToolStripMenuItem.Click += new System.EventHandler(this.openFiltersToolStripMenuItem_Click);
            // 
            // addFiltersFromFileToolStripMenuItem
            // 
            this.addFiltersFromFileToolStripMenuItem.Name = "addFiltersFromFileToolStripMenuItem";
            this.addFiltersFromFileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.O)));
            this.addFiltersFromFileToolStripMenuItem.Size = new System.Drawing.Size(251, 22);
            this.addFiltersFromFileToolStripMenuItem.Text = "Add filters from file";
            this.addFiltersFromFileToolStripMenuItem.Click += new System.EventHandler(this.addFiltersFromFileToolStripMenuItem_Click);
            // 
            // saveFiltersToolStripMenuItem
            // 
            this.saveFiltersToolStripMenuItem.Name = "saveFiltersToolStripMenuItem";
            this.saveFiltersToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveFiltersToolStripMenuItem.Size = new System.Drawing.Size(251, 22);
            this.saveFiltersToolStripMenuItem.Text = "Save filters";
            this.saveFiltersToolStripMenuItem.Click += new System.EventHandler(this.saveFiltersToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteSelectedFilterToolStripMenuItem1,
            this.clearAllFiltersToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // deleteSelectedFilterToolStripMenuItem1
            // 
            this.deleteSelectedFilterToolStripMenuItem1.Name = "deleteSelectedFilterToolStripMenuItem1";
            this.deleteSelectedFilterToolStripMenuItem1.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.deleteSelectedFilterToolStripMenuItem1.Size = new System.Drawing.Size(204, 22);
            this.deleteSelectedFilterToolStripMenuItem1.Text = "Delete selected filter";
            // 
            // clearAllFiltersToolStripMenuItem
            // 
            this.clearAllFiltersToolStripMenuItem.Name = "clearAllFiltersToolStripMenuItem";
            this.clearAllFiltersToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.clearAllFiltersToolStripMenuItem.Text = "Clear all filters";
            this.clearAllFiltersToolStripMenuItem.Click += new System.EventHandler(this.clearAllFiltersToolStripMenuItem_Click);
            // 
            // FilterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 436);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FilterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Filters";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FilterForm_FormClosing);
            this.groupBox4.ResumeLayout(false);
            this.CntxtFilters.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListBox LstFilters;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox ChckOriginatingCallsOnly;
        private System.Windows.Forms.CheckBox ChckFileRelatedEntriesOnly;
        private System.Windows.Forms.ComboBox CmbType;
        private System.Windows.Forms.Button BtnExclude;
        private System.Windows.Forms.Button BtnInclude;
        private System.Windows.Forms.TextBox TxtValue;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFiltersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveFiltersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearAllFiltersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addFiltersFromFileToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip CntxtFilters;
        private System.Windows.Forms.ToolStripMenuItem clearAllFiltersToolStripMenuItem1;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.ToolStripMenuItem deleteSelectedFilterToolStripMenuItem;
        private System.Windows.Forms.Button BtnDeleteAllFilters;
        private System.Windows.Forms.ToolStripMenuItem deleteSelectedFilterToolStripMenuItem1;
    }
}