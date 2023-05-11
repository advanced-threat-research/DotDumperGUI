
namespace DotDumperGUI
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenTraceLogToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveCurrentTraceSelectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filtersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.copySelectedFunctionArgumentValueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.copySelectedRelatedFileMD5ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copySelectedRelatedFileSHA1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copySelectedRelatedFileSHA256ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.copySelectedResourceNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.copySelectedCallOrderAssemblyNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copySelectedCallOrderHashToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showActivityLogsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.GroupTrace = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.LstResourceNames = new System.Windows.Forms.ListBox();
            this.CntxtResourceNames = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CntxtResourceNamesCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DataGridViewCallOrder = new System.Windows.Forms.DataGridView();
            this.CntxtCallOrder = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CntxtCallOrderCopyName = new System.Windows.Forms.ToolStripMenuItem();
            this.CntxtCallOrderCopyHash = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.DataGridViewRelatedFiles = new System.Windows.Forms.DataGridView();
            this.CntxtRelatedFiles = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CntxtRelatedFilesMd5 = new System.Windows.Forms.ToolStripMenuItem();
            this.CntxtRelatedFilesSha1 = new System.Windows.Forms.ToolStripMenuItem();
            this.CntxtRelatedFilesSha256 = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.LstStackTrace = new System.Windows.Forms.ListBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.DataGridViewFunctionArguments = new System.Windows.Forms.DataGridView();
            this.CntxtFunctionArguments = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CntxtFunctionArgumentsCopyValue = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.TxtOriginatingSha256 = new System.Windows.Forms.TextBox();
            this.TxtOriginatingImportHash = new System.Windows.Forms.TextBox();
            this.TxtOriginatingTypeRefHash = new System.Windows.Forms.TextBox();
            this.TxtOriginatingParentSha256 = new System.Windows.Forms.TextBox();
            this.TxtOriginatingVersion = new System.Windows.Forms.TextBox();
            this.TxtOriginatingName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.LstTraces = new System.Windows.Forms.ListBox();
            this.CntxtTraces = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showAllFiltersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearFiltersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.excludeSelectedFunctionNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excludeSelectedItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.onlyShowFileRelatedHookTracesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.onlyShowCallsOriginatingFromTheSampleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.onlyShowHookTracesOriginatingFromThisAssemblyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excludeHookTracesOriginatingFromThisAssemblyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.onlyShowHookTracesWithThisParentHashToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excludeHookTracesWithThisParentHashToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.rebuildInjectedExecutableFromHereToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StatusStrip = new System.Windows.Forms.StatusStrip();
            this.StatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.rebuildInjectedExecutableFromTheSelectedTraceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.GroupTrace.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.CntxtResourceNames.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewCallOrder)).BeginInit();
            this.CntxtCallOrder.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewRelatedFiles)).BeginInit();
            this.CntxtRelatedFiles.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewFunctionArguments)).BeginInit();
            this.CntxtFunctionArguments.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.CntxtTraces.SuspendLayout();
            this.StatusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem,
            this.EditToolStripMenuItem,
            this.HelpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1345, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenTraceLogToolStripMenuItem1,
            this.SaveCurrentTraceSelectionToolStripMenuItem});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.FileToolStripMenuItem.Text = "File";
            // 
            // OpenTraceLogToolStripMenuItem1
            // 
            this.OpenTraceLogToolStripMenuItem1.Name = "OpenTraceLogToolStripMenuItem1";
            this.OpenTraceLogToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.OpenTraceLogToolStripMenuItem1.Size = new System.Drawing.Size(242, 22);
            this.OpenTraceLogToolStripMenuItem1.Text = "Open hook trace log";
            this.OpenTraceLogToolStripMenuItem1.Click += new System.EventHandler(this.OpenTraceLogToolStripMenuItem1_Click);
            // 
            // SaveCurrentTraceSelectionToolStripMenuItem
            // 
            this.SaveCurrentTraceSelectionToolStripMenuItem.Name = "SaveCurrentTraceSelectionToolStripMenuItem";
            this.SaveCurrentTraceSelectionToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.SaveCurrentTraceSelectionToolStripMenuItem.Size = new System.Drawing.Size(242, 22);
            this.SaveCurrentTraceSelectionToolStripMenuItem.Text = "Save filtered hook traces";
            this.SaveCurrentTraceSelectionToolStripMenuItem.Click += new System.EventHandler(this.SaveCurrentTraceSelectionToolStripMenuItem_Click);
            // 
            // EditToolStripMenuItem
            // 
            this.EditToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filtersToolStripMenuItem,
            this.toolStripSeparator4,
            this.copySelectedFunctionArgumentValueToolStripMenuItem,
            this.toolStripSeparator1,
            this.copySelectedRelatedFileMD5ToolStripMenuItem,
            this.copySelectedRelatedFileSHA1ToolStripMenuItem,
            this.copySelectedRelatedFileSHA256ToolStripMenuItem,
            this.toolStripSeparator2,
            this.copySelectedResourceNameToolStripMenuItem,
            this.toolStripSeparator3,
            this.copySelectedCallOrderAssemblyNameToolStripMenuItem,
            this.copySelectedCallOrderHashToolStripMenuItem,
            this.toolStripSeparator9,
            this.rebuildInjectedExecutableFromTheSelectedTraceToolStripMenuItem});
            this.EditToolStripMenuItem.Name = "EditToolStripMenuItem";
            this.EditToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.EditToolStripMenuItem.Text = "Edit";
            // 
            // filtersToolStripMenuItem
            // 
            this.filtersToolStripMenuItem.Name = "filtersToolStripMenuItem";
            this.filtersToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.filtersToolStripMenuItem.Size = new System.Drawing.Size(343, 22);
            this.filtersToolStripMenuItem.Text = "Filters";
            this.filtersToolStripMenuItem.Click += new System.EventHandler(this.filtersToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(340, 6);
            // 
            // copySelectedFunctionArgumentValueToolStripMenuItem
            // 
            this.copySelectedFunctionArgumentValueToolStripMenuItem.Name = "copySelectedFunctionArgumentValueToolStripMenuItem";
            this.copySelectedFunctionArgumentValueToolStripMenuItem.Size = new System.Drawing.Size(343, 22);
            this.copySelectedFunctionArgumentValueToolStripMenuItem.Text = "Copy selected function argument value";
            this.copySelectedFunctionArgumentValueToolStripMenuItem.Click += new System.EventHandler(this.copySelectedFunctionArgumentValueToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(340, 6);
            // 
            // copySelectedRelatedFileMD5ToolStripMenuItem
            // 
            this.copySelectedRelatedFileMD5ToolStripMenuItem.Name = "copySelectedRelatedFileMD5ToolStripMenuItem";
            this.copySelectedRelatedFileMD5ToolStripMenuItem.Size = new System.Drawing.Size(343, 22);
            this.copySelectedRelatedFileMD5ToolStripMenuItem.Text = "Copy selected related file MD-5";
            this.copySelectedRelatedFileMD5ToolStripMenuItem.Click += new System.EventHandler(this.copySelectedRelatedFileMD5ToolStripMenuItem_Click);
            // 
            // copySelectedRelatedFileSHA1ToolStripMenuItem
            // 
            this.copySelectedRelatedFileSHA1ToolStripMenuItem.Name = "copySelectedRelatedFileSHA1ToolStripMenuItem";
            this.copySelectedRelatedFileSHA1ToolStripMenuItem.Size = new System.Drawing.Size(343, 22);
            this.copySelectedRelatedFileSHA1ToolStripMenuItem.Text = "Copy selected related file SHA-1";
            this.copySelectedRelatedFileSHA1ToolStripMenuItem.Click += new System.EventHandler(this.copySelectedRelatedFileSHA1ToolStripMenuItem_Click);
            // 
            // copySelectedRelatedFileSHA256ToolStripMenuItem
            // 
            this.copySelectedRelatedFileSHA256ToolStripMenuItem.Name = "copySelectedRelatedFileSHA256ToolStripMenuItem";
            this.copySelectedRelatedFileSHA256ToolStripMenuItem.Size = new System.Drawing.Size(343, 22);
            this.copySelectedRelatedFileSHA256ToolStripMenuItem.Text = "Copy selected related file SHA-256";
            this.copySelectedRelatedFileSHA256ToolStripMenuItem.Click += new System.EventHandler(this.copySelectedRelatedFileSHA256ToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(340, 6);
            // 
            // copySelectedResourceNameToolStripMenuItem
            // 
            this.copySelectedResourceNameToolStripMenuItem.Name = "copySelectedResourceNameToolStripMenuItem";
            this.copySelectedResourceNameToolStripMenuItem.Size = new System.Drawing.Size(343, 22);
            this.copySelectedResourceNameToolStripMenuItem.Text = "Copy selected resource name";
            this.copySelectedResourceNameToolStripMenuItem.Click += new System.EventHandler(this.copySelectedResourceNameToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(340, 6);
            // 
            // copySelectedCallOrderAssemblyNameToolStripMenuItem
            // 
            this.copySelectedCallOrderAssemblyNameToolStripMenuItem.Name = "copySelectedCallOrderAssemblyNameToolStripMenuItem";
            this.copySelectedCallOrderAssemblyNameToolStripMenuItem.Size = new System.Drawing.Size(343, 22);
            this.copySelectedCallOrderAssemblyNameToolStripMenuItem.Text = "Copy selected call order assembly name";
            this.copySelectedCallOrderAssemblyNameToolStripMenuItem.Click += new System.EventHandler(this.copySelectedCallOrderAssemblyNameToolStripMenuItem_Click);
            // 
            // copySelectedCallOrderHashToolStripMenuItem
            // 
            this.copySelectedCallOrderHashToolStripMenuItem.Name = "copySelectedCallOrderHashToolStripMenuItem";
            this.copySelectedCallOrderHashToolStripMenuItem.Size = new System.Drawing.Size(343, 22);
            this.copySelectedCallOrderHashToolStripMenuItem.Text = "Copy selected call order hash";
            this.copySelectedCallOrderHashToolStripMenuItem.Click += new System.EventHandler(this.copySelectedCallOrderHashToolStripMenuItem_Click);
            // 
            // HelpToolStripMenuItem
            // 
            this.HelpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showActivityLogsToolStripMenuItem,
            this.AboutToolStripMenuItem});
            this.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem";
            this.HelpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.HelpToolStripMenuItem.Text = "Help";
            // 
            // showActivityLogsToolStripMenuItem
            // 
            this.showActivityLogsToolStripMenuItem.Name = "showActivityLogsToolStripMenuItem";
            this.showActivityLogsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.showActivityLogsToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.showActivityLogsToolStripMenuItem.Text = "Show activity logs";
            this.showActivityLogsToolStripMenuItem.Click += new System.EventHandler(this.showActivityLogsToolStripMenuItem_Click);
            // 
            // AboutToolStripMenuItem
            // 
            this.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
            this.AboutToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.AboutToolStripMenuItem.Text = "About";
            this.AboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.GroupTrace);
            this.groupBox1.Controls.Add(this.groupBox9);
            this.groupBox1.Location = new System.Drawing.Point(13, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1320, 837);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // GroupTrace
            // 
            this.GroupTrace.Controls.Add(this.groupBox4);
            this.GroupTrace.Controls.Add(this.groupBox2);
            this.GroupTrace.Controls.Add(this.groupBox3);
            this.GroupTrace.Controls.Add(this.groupBox7);
            this.GroupTrace.Controls.Add(this.groupBox6);
            this.GroupTrace.Controls.Add(this.groupBox5);
            this.GroupTrace.Location = new System.Drawing.Point(10, 272);
            this.GroupTrace.Name = "GroupTrace";
            this.GroupTrace.Size = new System.Drawing.Size(1304, 559);
            this.GroupTrace.TabIndex = 9;
            this.GroupTrace.TabStop = false;
            this.GroupTrace.Text = "Selected trace";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.LstResourceNames);
            this.groupBox4.Location = new System.Drawing.Point(848, 196);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(450, 170);
            this.groupBox4.TabIndex = 16;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Resource names";
            // 
            // LstResourceNames
            // 
            this.LstResourceNames.ContextMenuStrip = this.CntxtResourceNames;
            this.LstResourceNames.FormattingEnabled = true;
            this.LstResourceNames.ItemHeight = 15;
            this.LstResourceNames.Location = new System.Drawing.Point(6, 22);
            this.LstResourceNames.Name = "LstResourceNames";
            this.LstResourceNames.Size = new System.Drawing.Size(438, 139);
            this.LstResourceNames.TabIndex = 17;
            // 
            // CntxtResourceNames
            // 
            this.CntxtResourceNames.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CntxtResourceNamesCopy});
            this.CntxtResourceNames.Name = "CntxtResourceNames";
            this.CntxtResourceNames.Size = new System.Drawing.Size(103, 26);
            // 
            // CntxtResourceNamesCopy
            // 
            this.CntxtResourceNamesCopy.Name = "CntxtResourceNamesCopy";
            this.CntxtResourceNamesCopy.Size = new System.Drawing.Size(102, 22);
            this.CntxtResourceNamesCopy.Text = "Copy";
            this.CntxtResourceNamesCopy.Click += new System.EventHandler(this.CntxtResourceNamesCopy_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DataGridViewCallOrder);
            this.groupBox2.Location = new System.Drawing.Point(848, 37);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(450, 153);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Call order";
            // 
            // DataGridViewCallOrder
            // 
            this.DataGridViewCallOrder.AllowUserToAddRows = false;
            this.DataGridViewCallOrder.AllowUserToDeleteRows = false;
            this.DataGridViewCallOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridViewCallOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewCallOrder.ContextMenuStrip = this.CntxtCallOrder;
            this.DataGridViewCallOrder.Location = new System.Drawing.Point(6, 22);
            this.DataGridViewCallOrder.MultiSelect = false;
            this.DataGridViewCallOrder.Name = "DataGridViewCallOrder";
            this.DataGridViewCallOrder.ReadOnly = true;
            this.DataGridViewCallOrder.RowTemplate.Height = 25;
            this.DataGridViewCallOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.DataGridViewCallOrder.Size = new System.Drawing.Size(438, 121);
            this.DataGridViewCallOrder.TabIndex = 14;
            // 
            // CntxtCallOrder
            // 
            this.CntxtCallOrder.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CntxtCallOrderCopyName,
            this.CntxtCallOrderCopyHash});
            this.CntxtCallOrder.Name = "CntxtCallOrder";
            this.CntxtCallOrder.Size = new System.Drawing.Size(188, 48);
            // 
            // CntxtCallOrderCopyName
            // 
            this.CntxtCallOrderCopyName.Name = "CntxtCallOrderCopyName";
            this.CntxtCallOrderCopyName.Size = new System.Drawing.Size(187, 22);
            this.CntxtCallOrderCopyName.Text = "Copy assembly name";
            this.CntxtCallOrderCopyName.Click += new System.EventHandler(this.CntxtCallOrderCopyName_Click);
            // 
            // CntxtCallOrderCopyHash
            // 
            this.CntxtCallOrderCopyHash.Name = "CntxtCallOrderCopyHash";
            this.CntxtCallOrderCopyHash.Size = new System.Drawing.Size(187, 22);
            this.CntxtCallOrderCopyHash.Text = "Copy hash";
            this.CntxtCallOrderCopyHash.Click += new System.EventHandler(this.CntxtCallOrderCopyHash_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.DataGridViewRelatedFiles);
            this.groupBox3.Location = new System.Drawing.Point(6, 241);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(826, 125);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Related files";
            // 
            // DataGridViewRelatedFiles
            // 
            this.DataGridViewRelatedFiles.AllowUserToAddRows = false;
            this.DataGridViewRelatedFiles.AllowUserToDeleteRows = false;
            this.DataGridViewRelatedFiles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridViewRelatedFiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewRelatedFiles.ContextMenuStrip = this.CntxtRelatedFiles;
            this.DataGridViewRelatedFiles.Location = new System.Drawing.Point(6, 22);
            this.DataGridViewRelatedFiles.MultiSelect = false;
            this.DataGridViewRelatedFiles.Name = "DataGridViewRelatedFiles";
            this.DataGridViewRelatedFiles.ReadOnly = true;
            this.DataGridViewRelatedFiles.RowTemplate.Height = 25;
            this.DataGridViewRelatedFiles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.DataGridViewRelatedFiles.Size = new System.Drawing.Size(814, 95);
            this.DataGridViewRelatedFiles.TabIndex = 14;
            // 
            // CntxtRelatedFiles
            // 
            this.CntxtRelatedFiles.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CntxtRelatedFilesMd5,
            this.CntxtRelatedFilesSha1,
            this.CntxtRelatedFilesSha256});
            this.CntxtRelatedFiles.Name = "CntxtRelatedFiles";
            this.CntxtRelatedFiles.Size = new System.Drawing.Size(152, 70);
            // 
            // CntxtRelatedFilesMd5
            // 
            this.CntxtRelatedFilesMd5.Name = "CntxtRelatedFilesMd5";
            this.CntxtRelatedFilesMd5.Size = new System.Drawing.Size(151, 22);
            this.CntxtRelatedFilesMd5.Text = "Copy MD-5";
            this.CntxtRelatedFilesMd5.Click += new System.EventHandler(this.CntxtRelatedFilesMd5_Click);
            // 
            // CntxtRelatedFilesSha1
            // 
            this.CntxtRelatedFilesSha1.Name = "CntxtRelatedFilesSha1";
            this.CntxtRelatedFilesSha1.Size = new System.Drawing.Size(151, 22);
            this.CntxtRelatedFilesSha1.Text = "Copy SHA-1";
            this.CntxtRelatedFilesSha1.Click += new System.EventHandler(this.CntxtRelatedFilesSha1_Click);
            // 
            // CntxtRelatedFilesSha256
            // 
            this.CntxtRelatedFilesSha256.Name = "CntxtRelatedFilesSha256";
            this.CntxtRelatedFilesSha256.Size = new System.Drawing.Size(151, 22);
            this.CntxtRelatedFilesSha256.Text = "Copy SHA-256";
            this.CntxtRelatedFilesSha256.Click += new System.EventHandler(this.CntxtRelatedFilesSha256_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.LstStackTrace);
            this.groupBox7.Location = new System.Drawing.Point(6, 372);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(1292, 181);
            this.groupBox7.TabIndex = 4;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Stack trace information";
            // 
            // LstStackTrace
            // 
            this.LstStackTrace.FormattingEnabled = true;
            this.LstStackTrace.HorizontalScrollbar = true;
            this.LstStackTrace.ItemHeight = 15;
            this.LstStackTrace.Location = new System.Drawing.Point(6, 19);
            this.LstStackTrace.Name = "LstStackTrace";
            this.LstStackTrace.Size = new System.Drawing.Size(1280, 154);
            this.LstStackTrace.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.DataGridViewFunctionArguments);
            this.groupBox6.Location = new System.Drawing.Point(382, 37);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(450, 197);
            this.groupBox6.TabIndex = 3;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Function arguments";
            // 
            // DataGridViewFunctionArguments
            // 
            this.DataGridViewFunctionArguments.AllowUserToAddRows = false;
            this.DataGridViewFunctionArguments.AllowUserToDeleteRows = false;
            this.DataGridViewFunctionArguments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridViewFunctionArguments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewFunctionArguments.ContextMenuStrip = this.CntxtFunctionArguments;
            this.DataGridViewFunctionArguments.Location = new System.Drawing.Point(6, 22);
            this.DataGridViewFunctionArguments.MultiSelect = false;
            this.DataGridViewFunctionArguments.Name = "DataGridViewFunctionArguments";
            this.DataGridViewFunctionArguments.ReadOnly = true;
            this.DataGridViewFunctionArguments.RowTemplate.Height = 25;
            this.DataGridViewFunctionArguments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.DataGridViewFunctionArguments.Size = new System.Drawing.Size(438, 165);
            this.DataGridViewFunctionArguments.TabIndex = 14;
            // 
            // CntxtFunctionArguments
            // 
            this.CntxtFunctionArguments.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CntxtFunctionArgumentsCopyValue});
            this.CntxtFunctionArguments.Name = "CntxtFunctionArguments";
            this.CntxtFunctionArguments.Size = new System.Drawing.Size(134, 26);
            // 
            // CntxtFunctionArgumentsCopyValue
            // 
            this.CntxtFunctionArgumentsCopyValue.Name = "CntxtFunctionArgumentsCopyValue";
            this.CntxtFunctionArgumentsCopyValue.Size = new System.Drawing.Size(133, 22);
            this.CntxtFunctionArgumentsCopyValue.Text = "Copy value";
            this.CntxtFunctionArgumentsCopyValue.Click += new System.EventHandler(this.CntxtFunctionArgumentsCopyValue_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.TxtOriginatingSha256);
            this.groupBox5.Controls.Add(this.TxtOriginatingImportHash);
            this.groupBox5.Controls.Add(this.TxtOriginatingTypeRefHash);
            this.groupBox5.Controls.Add(this.TxtOriginatingParentSha256);
            this.groupBox5.Controls.Add(this.TxtOriginatingVersion);
            this.groupBox5.Controls.Add(this.TxtOriginatingName);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Location = new System.Drawing.Point(6, 37);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(370, 197);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Originating assembly information";
            // 
            // TxtOriginatingSha256
            // 
            this.TxtOriginatingSha256.Location = new System.Drawing.Point(109, 135);
            this.TxtOriginatingSha256.Name = "TxtOriginatingSha256";
            this.TxtOriginatingSha256.ReadOnly = true;
            this.TxtOriginatingSha256.Size = new System.Drawing.Size(255, 23);
            this.TxtOriginatingSha256.TabIndex = 7;
            // 
            // TxtOriginatingImportHash
            // 
            this.TxtOriginatingImportHash.Location = new System.Drawing.Point(109, 106);
            this.TxtOriginatingImportHash.Name = "TxtOriginatingImportHash";
            this.TxtOriginatingImportHash.ReadOnly = true;
            this.TxtOriginatingImportHash.Size = new System.Drawing.Size(255, 23);
            this.TxtOriginatingImportHash.TabIndex = 8;
            // 
            // TxtOriginatingTypeRefHash
            // 
            this.TxtOriginatingTypeRefHash.Location = new System.Drawing.Point(109, 77);
            this.TxtOriginatingTypeRefHash.Name = "TxtOriginatingTypeRefHash";
            this.TxtOriginatingTypeRefHash.ReadOnly = true;
            this.TxtOriginatingTypeRefHash.Size = new System.Drawing.Size(255, 23);
            this.TxtOriginatingTypeRefHash.TabIndex = 9;
            // 
            // TxtOriginatingParentSha256
            // 
            this.TxtOriginatingParentSha256.Location = new System.Drawing.Point(109, 164);
            this.TxtOriginatingParentSha256.Name = "TxtOriginatingParentSha256";
            this.TxtOriginatingParentSha256.ReadOnly = true;
            this.TxtOriginatingParentSha256.Size = new System.Drawing.Size(255, 23);
            this.TxtOriginatingParentSha256.TabIndex = 6;
            // 
            // TxtOriginatingVersion
            // 
            this.TxtOriginatingVersion.Location = new System.Drawing.Point(109, 48);
            this.TxtOriginatingVersion.Name = "TxtOriginatingVersion";
            this.TxtOriginatingVersion.ReadOnly = true;
            this.TxtOriginatingVersion.Size = new System.Drawing.Size(255, 23);
            this.TxtOriginatingVersion.TabIndex = 10;
            // 
            // TxtOriginatingName
            // 
            this.TxtOriginatingName.Location = new System.Drawing.Point(109, 19);
            this.TxtOriginatingName.Name = "TxtOriginatingName";
            this.TxtOriginatingName.ReadOnly = true;
            this.TxtOriginatingName.Size = new System.Drawing.Size(255, 23);
            this.TxtOriginatingName.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 167);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 15);
            this.label7.TabIndex = 10;
            this.label7.Text = "Parent SHA-256:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "SHA-256:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 15);
            this.label6.TabIndex = 7;
            this.label6.Text = "Version:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "ImportHash:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "TypeRefHash:";
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.LstTraces);
            this.groupBox9.Location = new System.Drawing.Point(6, 12);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(1308, 259);
            this.groupBox9.TabIndex = 8;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Hook Traces";
            // 
            // LstTraces
            // 
            this.LstTraces.ContextMenuStrip = this.CntxtTraces;
            this.LstTraces.FormattingEnabled = true;
            this.LstTraces.HorizontalScrollbar = true;
            this.LstTraces.ItemHeight = 15;
            this.LstTraces.Location = new System.Drawing.Point(4, 22);
            this.LstTraces.Name = "LstTraces";
            this.LstTraces.Size = new System.Drawing.Size(1301, 229);
            this.LstTraces.TabIndex = 1;
            this.LstTraces.SelectedIndexChanged += new System.EventHandler(this.LstTraces_SelectedIndexChanged);
            // 
            // CntxtTraces
            // 
            this.CntxtTraces.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showAllFiltersToolStripMenuItem,
            this.clearFiltersToolStripMenuItem,
            this.toolStripSeparator10,
            this.excludeSelectedFunctionNameToolStripMenuItem,
            this.excludeSelectedItemToolStripMenuItem,
            this.toolStripSeparator6,
            this.onlyShowFileRelatedHookTracesToolStripMenuItem,
            this.onlyShowCallsOriginatingFromTheSampleToolStripMenuItem,
            this.toolStripSeparator8,
            this.onlyShowHookTracesOriginatingFromThisAssemblyToolStripMenuItem,
            this.excludeHookTracesOriginatingFromThisAssemblyToolStripMenuItem,
            this.toolStripSeparator7,
            this.onlyShowHookTracesWithThisParentHashToolStripMenuItem,
            this.excludeHookTracesWithThisParentHashToolStripMenuItem,
            this.toolStripSeparator5,
            this.rebuildInjectedExecutableFromHereToolStripMenuItem});
            this.CntxtTraces.Name = "CntxtTraces";
            this.CntxtTraces.Size = new System.Drawing.Size(359, 276);
            // 
            // showAllFiltersToolStripMenuItem
            // 
            this.showAllFiltersToolStripMenuItem.Name = "showAllFiltersToolStripMenuItem";
            this.showAllFiltersToolStripMenuItem.Size = new System.Drawing.Size(358, 22);
            this.showAllFiltersToolStripMenuItem.Text = "Show all filters";
            this.showAllFiltersToolStripMenuItem.Click += new System.EventHandler(this.showAllFiltersToolStripMenuItem_Click);
            // 
            // clearFiltersToolStripMenuItem
            // 
            this.clearFiltersToolStripMenuItem.Name = "clearFiltersToolStripMenuItem";
            this.clearFiltersToolStripMenuItem.Size = new System.Drawing.Size(358, 22);
            this.clearFiltersToolStripMenuItem.Text = "Clear filters";
            this.clearFiltersToolStripMenuItem.Click += new System.EventHandler(this.clearFiltersToolStripMenuItem_Click);
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            this.toolStripSeparator10.Size = new System.Drawing.Size(355, 6);
            // 
            // excludeSelectedFunctionNameToolStripMenuItem
            // 
            this.excludeSelectedFunctionNameToolStripMenuItem.Name = "excludeSelectedFunctionNameToolStripMenuItem";
            this.excludeSelectedFunctionNameToolStripMenuItem.Size = new System.Drawing.Size(358, 22);
            this.excludeSelectedFunctionNameToolStripMenuItem.Text = "Exclude selected function name";
            this.excludeSelectedFunctionNameToolStripMenuItem.Click += new System.EventHandler(this.excludeSelectedFunctionNameToolStripMenuItem_Click);
            // 
            // excludeSelectedItemToolStripMenuItem
            // 
            this.excludeSelectedItemToolStripMenuItem.Name = "excludeSelectedItemToolStripMenuItem";
            this.excludeSelectedItemToolStripMenuItem.Size = new System.Drawing.Size(358, 22);
            this.excludeSelectedItemToolStripMenuItem.Text = "Exclude selected item";
            this.excludeSelectedItemToolStripMenuItem.Click += new System.EventHandler(this.excludeSelectedItemToolStripMenuItem_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(355, 6);
            // 
            // onlyShowFileRelatedHookTracesToolStripMenuItem
            // 
            this.onlyShowFileRelatedHookTracesToolStripMenuItem.CheckOnClick = true;
            this.onlyShowFileRelatedHookTracesToolStripMenuItem.Name = "onlyShowFileRelatedHookTracesToolStripMenuItem";
            this.onlyShowFileRelatedHookTracesToolStripMenuItem.Size = new System.Drawing.Size(358, 22);
            this.onlyShowFileRelatedHookTracesToolStripMenuItem.Text = "Only show file related hook traces";
            this.onlyShowFileRelatedHookTracesToolStripMenuItem.Click += new System.EventHandler(this.onlyShowFileRelatedHookTracesToolStripMenuItem_Click);
            // 
            // onlyShowCallsOriginatingFromTheSampleToolStripMenuItem
            // 
            this.onlyShowCallsOriginatingFromTheSampleToolStripMenuItem.CheckOnClick = true;
            this.onlyShowCallsOriginatingFromTheSampleToolStripMenuItem.Name = "onlyShowCallsOriginatingFromTheSampleToolStripMenuItem";
            this.onlyShowCallsOriginatingFromTheSampleToolStripMenuItem.Size = new System.Drawing.Size(358, 22);
            this.onlyShowCallsOriginatingFromTheSampleToolStripMenuItem.Text = "Only show calls originating from the sample";
            this.onlyShowCallsOriginatingFromTheSampleToolStripMenuItem.Click += new System.EventHandler(this.onlyShowCallsOriginatingFromTheSampleToolStripMenuItem_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(355, 6);
            // 
            // onlyShowHookTracesOriginatingFromThisAssemblyToolStripMenuItem
            // 
            this.onlyShowHookTracesOriginatingFromThisAssemblyToolStripMenuItem.Name = "onlyShowHookTracesOriginatingFromThisAssemblyToolStripMenuItem";
            this.onlyShowHookTracesOriginatingFromThisAssemblyToolStripMenuItem.Size = new System.Drawing.Size(358, 22);
            this.onlyShowHookTracesOriginatingFromThisAssemblyToolStripMenuItem.Text = "Only show hook traces originating from this assembly";
            this.onlyShowHookTracesOriginatingFromThisAssemblyToolStripMenuItem.Click += new System.EventHandler(this.onlyShowHookTracesOriginatingFromThisAssemblyToolStripMenuItem_Click);
            // 
            // excludeHookTracesOriginatingFromThisAssemblyToolStripMenuItem
            // 
            this.excludeHookTracesOriginatingFromThisAssemblyToolStripMenuItem.Name = "excludeHookTracesOriginatingFromThisAssemblyToolStripMenuItem";
            this.excludeHookTracesOriginatingFromThisAssemblyToolStripMenuItem.Size = new System.Drawing.Size(358, 22);
            this.excludeHookTracesOriginatingFromThisAssemblyToolStripMenuItem.Text = "Exclude hook traces originating from this assembly";
            this.excludeHookTracesOriginatingFromThisAssemblyToolStripMenuItem.Click += new System.EventHandler(this.excludeHookTracesOriginatingFromThisAssemblyToolStripMenuItem_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(355, 6);
            // 
            // onlyShowHookTracesWithThisParentHashToolStripMenuItem
            // 
            this.onlyShowHookTracesWithThisParentHashToolStripMenuItem.Name = "onlyShowHookTracesWithThisParentHashToolStripMenuItem";
            this.onlyShowHookTracesWithThisParentHashToolStripMenuItem.Size = new System.Drawing.Size(358, 22);
            this.onlyShowHookTracesWithThisParentHashToolStripMenuItem.Text = "Only show hook traces with this parent hash";
            this.onlyShowHookTracesWithThisParentHashToolStripMenuItem.Click += new System.EventHandler(this.onlyShowHookTracesWithThisParentHashToolStripMenuItem_Click);
            // 
            // excludeHookTracesWithThisParentHashToolStripMenuItem
            // 
            this.excludeHookTracesWithThisParentHashToolStripMenuItem.Name = "excludeHookTracesWithThisParentHashToolStripMenuItem";
            this.excludeHookTracesWithThisParentHashToolStripMenuItem.Size = new System.Drawing.Size(358, 22);
            this.excludeHookTracesWithThisParentHashToolStripMenuItem.Text = "Exclude hook traces with this parent hash";
            this.excludeHookTracesWithThisParentHashToolStripMenuItem.Click += new System.EventHandler(this.excludeHookTracesWithThisParentHashToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(355, 6);
            // 
            // rebuildInjectedExecutableFromHereToolStripMenuItem
            // 
            this.rebuildInjectedExecutableFromHereToolStripMenuItem.Name = "rebuildInjectedExecutableFromHereToolStripMenuItem";
            this.rebuildInjectedExecutableFromHereToolStripMenuItem.Size = new System.Drawing.Size(358, 22);
            this.rebuildInjectedExecutableFromHereToolStripMenuItem.Text = "Rebuild injected executable from here";
            this.rebuildInjectedExecutableFromHereToolStripMenuItem.Click += new System.EventHandler(this.rebuildInjectedExecutableFromHereToolStripMenuItem_Click);
            // 
            // StatusStrip
            // 
            this.StatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusLabel});
            this.StatusStrip.Location = new System.Drawing.Point(0, 868);
            this.StatusStrip.Name = "StatusStrip";
            this.StatusStrip.Size = new System.Drawing.Size(1345, 22);
            this.StatusStrip.TabIndex = 4;
            this.StatusStrip.Text = "statusStrip1";
            // 
            // StatusLabel
            // 
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(39, 17);
            this.StatusLabel.Text = "Ready";
            // 
            // rebuildInjectedExecutableFromTheSelectedTraceToolStripMenuItem
            // 
            this.rebuildInjectedExecutableFromTheSelectedTraceToolStripMenuItem.Name = "rebuildInjectedExecutableFromTheSelectedTraceToolStripMenuItem";
            this.rebuildInjectedExecutableFromTheSelectedTraceToolStripMenuItem.Size = new System.Drawing.Size(343, 22);
            this.rebuildInjectedExecutableFromTheSelectedTraceToolStripMenuItem.Text = "Rebuild injected executable from the selected trace";
            this.rebuildInjectedExecutableFromTheSelectedTraceToolStripMenuItem.Click += new System.EventHandler(this.rebuildInjectedExecutableFromTheSelectedTraceToolStripMenuItem_Click);
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(340, 6);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1345, 890);
            this.Controls.Add(this.StatusStrip);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DotDumperGUI by Libra";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.GroupTrace.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.CntxtResourceNames.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewCallOrder)).EndInit();
            this.CntxtCallOrder.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewRelatedFiles)).EndInit();
            this.CntxtRelatedFiles.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewFunctionArguments)).EndInit();
            this.CntxtFunctionArguments.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.CntxtTraces.ResumeLayout(false);
            this.StatusStrip.ResumeLayout(false);
            this.StatusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenTraceLogToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem SaveCurrentTraceSelectionToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.ListBox LstTraces;
        private System.Windows.Forms.ToolStripMenuItem HelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutToolStripMenuItem;
        private System.Windows.Forms.GroupBox GroupTrace;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView DataGridViewRelatedFiles;
        private System.Windows.Forms.TextBox TxtOriginatingParentSha256;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.ListBox LstStackTrace;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.DataGridView DataGridViewFunctionArguments;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox TxtOriginatingSha256;
        private System.Windows.Forms.TextBox TxtOriginatingImportHash;
        private System.Windows.Forms.TextBox TxtOriginatingTypeRefHash;
        private System.Windows.Forms.TextBox TxtOriginatingVersion;
        private System.Windows.Forms.TextBox TxtOriginatingName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView DataGridViewCallOrder;
        private System.Windows.Forms.ListBox LstResourceNames;
        private System.Windows.Forms.ToolStripMenuItem EditToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copySelectedFunctionArgumentValueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copySelectedRelatedFileMD5ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copySelectedRelatedFileSHA1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copySelectedRelatedFileSHA256ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copySelectedResourceNameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copySelectedCallOrderAssemblyNameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copySelectedCallOrderHashToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ContextMenuStrip CntxtFunctionArguments;
        private System.Windows.Forms.ToolStripMenuItem CntxtFunctionArgumentsCopyValue;
        private System.Windows.Forms.ContextMenuStrip CntxtCallOrder;
        private System.Windows.Forms.ToolStripMenuItem CntxtCallOrderCopyName;
        private System.Windows.Forms.ToolStripMenuItem CntxtCallOrderCopyHash;
        private System.Windows.Forms.ContextMenuStrip CntxtResourceNames;
        private System.Windows.Forms.ToolStripMenuItem CntxtResourceNamesCopy;
        private System.Windows.Forms.ContextMenuStrip CntxtRelatedFiles;
        private System.Windows.Forms.ToolStripMenuItem CntxtRelatedFilesMd5;
        private System.Windows.Forms.ToolStripMenuItem CntxtRelatedFilesSha1;
        private System.Windows.Forms.ToolStripMenuItem CntxtRelatedFilesSha256;
        private System.Windows.Forms.StatusStrip StatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabel;
        private System.Windows.Forms.ToolStripMenuItem filtersToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ContextMenuStrip CntxtTraces;
        private System.Windows.Forms.ToolStripMenuItem clearFiltersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excludeSelectedFunctionNameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excludeSelectedItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem onlyShowFileRelatedHookTracesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem onlyShowCallsOriginatingFromTheSampleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem onlyShowHookTracesOriginatingFromThisAssemblyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excludeHookTracesOriginatingFromThisAssemblyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem onlyShowHookTracesWithThisParentHashToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excludeHookTracesWithThisParentHashToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem showActivityLogsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showAllFiltersToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
        private System.Windows.Forms.ToolStripMenuItem rebuildInjectedExecutableFromHereToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripMenuItem rebuildInjectedExecutableFromTheSelectedTraceToolStripMenuItem;
    }
}

