using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;
using DotDumperGUI.Handlers;
using DotDumperGUI.Models;
using static System.Environment;

namespace DotDumperGUI
{
    public partial class FormMain : Form
    {
        public TraceManager Manager { get; set; }
        public bool FiltersEnabled { get; set; }
        public FileLoader Loader { get; set; }
        public FilterForm FilterFormInstance { get; set; }
        public FormMain()
        {
            InitializeComponent();
            Manager = new TraceManager();
            FiltersEnabled = false;
            Loader = new FileLoader();
            FilterFormInstance = new FilterForm(this);
        }

        #region GUI element related
        private void OpenTraceLogToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                InitialDirectory = GetFolderPath(SpecialFolder.UserProfile),
                Title = "Select a DotDumper trace",
                CheckFileExists = true,
                Multiselect = false, //for now
                Filter = "JSON (*.json)|*.json"
            };
            DialogResult result = openFileDialog.ShowDialog();

            if (result != DialogResult.OK)
            {
                SetStatus("File opening cancelled!", false);
                return;
            }
            string filePath = openFileDialog.FileName;
            try
            {
                Manager.Entries = Loader.LoadEntries(filePath);
                Manager.JsonPath = Path.GetDirectoryName(filePath) + "\\";
                SetTraceList(Manager.Entries);
                FileInfo fileInfo = new FileInfo(filePath);
                SetStatus("Successfully loaded " + Manager.Entries.Count + " hook traces from \"" + filePath + "\" (" + (fileInfo.Length / 1024) + " kilobytes)", false);
            }
            catch (Exception)
            {
                SetStatus("An error occured when attempting to load \"" + filePath + "\"!", true);
            }
        }

        private void SaveCurrentTraceSelectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                InitialDirectory = Environment.GetFolderPath(SpecialFolder.UserProfile),
                Title = "Save the filtered hook traces",
                AddExtension = true,
                Filter = "JSON files (*.json)|*.json",
                DefaultExt = ".json"
            };

            DialogResult result = saveFileDialog.ShowDialog();
            if (result != DialogResult.OK)
            {
                SetStatus("Hook trace saving cancelled!", false);
                return;
            }

            string filePath = saveFileDialog.FileName;

            List<LogEntry> entries = new List<LogEntry>();

            foreach (LogEntry entry in LstTraces.Items)
            {
                entries.Add(entry);
            }

            string json = JsonSerializer.Serialize(entries, typeof(List<LogEntry>));

            File.WriteAllText(filePath, json);
            SetStatus("Successfully saved the current trace selection to \"" + filePath + "\", containing " + entries.Count, false);
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm about = new AboutForm();
            about.ShowDialog();
        }

        private void copySelectedResourceNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CopySelectedResource();
        }

        private void copySelectedFunctionArgumentValueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CopySelectedFunctionArgumentValue();
        }

        private void copySelectedCallOrderAssemblyNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CopyCallOrderName();
        }

        private void copySelectedCallOrderHashToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CopyCallOrderHash();
        }

        private void copySelectedRelatedFileMD5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string value = null;
            if (DataGridViewRelatedFiles.SelectedCells.Count > 0)
            {
                int index = DataGridViewRelatedFiles.SelectedCells[0].RowIndex;
                value = Convert.ToString(DataGridViewRelatedFiles.Rows[index].Cells[0].Value);
            }
            string listName = "related files";
            SetValue(value, listName);
        }

        private void copySelectedRelatedFileSHA1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string value = null;
            if (DataGridViewRelatedFiles.SelectedCells.Count > 0)
            {
                int index = DataGridViewRelatedFiles.SelectedCells[0].RowIndex;
                value = Convert.ToString(DataGridViewRelatedFiles.Rows[index].Cells[1].Value);
            }
            string listName = "related files";
            SetValue(value, listName);
        }

        private void copySelectedRelatedFileSHA256ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string value = null;
            if (DataGridViewRelatedFiles.SelectedCells.Count > 0)
            {
                int index = DataGridViewRelatedFiles.SelectedCells[0].RowIndex;
                value = Convert.ToString(DataGridViewRelatedFiles.Rows[index].Cells[2].Value);
            }
            string listName = "related files";
            SetValue(value, listName);
        }

        private void clearFiltersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearFilters();
        }

        private void onlyShowCallsOriginatingFromTheSampleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetFilterOriginatingCallFromSample(onlyShowCallsOriginatingFromTheSampleToolStripMenuItem.Checked);
        }

        private void onlyShowFileRelatedHookTracesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetFilterEnforceFileRelation(onlyShowFileRelatedHookTracesToolStripMenuItem.Checked);
        }

        private void excludeSelectedItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (LstTraces.SelectedItem == null)
            {
                SetStatus("No hook trace selected to exclude!", true);
                return;
            }
            LogEntry selectedEntry = (LogEntry)LstTraces.SelectedItem;
            ExcludeLogEntry(selectedEntry);
        }

        private void CntxtResourceNamesCopy_Click(object sender, EventArgs e)
        {
            CopySelectedResource();
        }

        private void CntxtFunctionArgumentsCopyValue_Click(object sender, EventArgs e)
        {
            CopySelectedFunctionArgumentValue();
        }

        private void CntxtCallOrderCopyName_Click(object sender, EventArgs e)
        {
            CopyCallOrderName();
        }

        private void CntxtCallOrderCopyHash_Click(object sender, EventArgs e)
        {
            CopyCallOrderHash();
        }

        private void CntxtRelatedFilesMd5_Click(object sender, EventArgs e)
        {
            string value = null;
            if (DataGridViewRelatedFiles.SelectedCells.Count > 0)
            {
                int index = DataGridViewRelatedFiles.SelectedCells[0].RowIndex;
                value = Convert.ToString(DataGridViewRelatedFiles.Rows[index].Cells[0].Value);
            }
            string listName = "related files";
            SetValue(value, listName);
        }

        private void CntxtRelatedFilesSha1_Click(object sender, EventArgs e)
        {
            string value = null;
            if (DataGridViewRelatedFiles.SelectedCells.Count > 0)
            {
                int index = DataGridViewRelatedFiles.SelectedCells[0].RowIndex;
                value = Convert.ToString(DataGridViewRelatedFiles.Rows[index].Cells[1].Value);
            }
            string listName = "related files";
            SetValue(value, listName);
        }

        private void CntxtRelatedFilesSha256_Click(object sender, EventArgs e)
        {
            string value = null;
            if (DataGridViewRelatedFiles.SelectedCells.Count > 0)
            {
                int index = DataGridViewRelatedFiles.SelectedCells[0].RowIndex;
                value = Convert.ToString(DataGridViewRelatedFiles.Rows[index].Cells[2].Value);
            }
            string listName = "related files";
            SetValue(value, listName);
        }

        private void filtersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FilterFormInstance.Show();
            FilterFormInstance.Activate();
        }

        private void showAllFiltersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FilterFormInstance.Show();
            FilterFormInstance.Activate();
        }

        private void excludeSelectedFunctionNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (LstTraces.SelectedItem == null)
            {
                SetStatus("No hook trace selected to exclude!", true);
                return;
            }
            LogEntry selectedEntry = (LogEntry)LstTraces.SelectedItem;
            string functionName = selectedEntry.FunctionName;
            Manager.Filter.FunctionNamesExcluded.Add(functionName);
            SetStatus("Filter: excluded the following function name: \"" + functionName + "\"", false);
            SetFilters();
        }

        private void onlyShowHookTracesOriginatingFromThisAssemblyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (LstTraces.SelectedItem == null)
            {
                SetStatus("No hook trace selected to exclude!", true);
                return;
            }
            LogEntry entry = (LogEntry)LstTraces.SelectedItem;
            Manager.Filter.OriginatingSampleHashes.Add(entry.OriginatingAssemblyHash.Sha256);
            SetStatus("Filter: included the following originating sample hash: \"" + entry.OriginatingAssemblyHash.Sha256 + "\"", false);
            SetFilters();
        }

        private void excludeHookTracesOriginatingFromThisAssemblyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (LstTraces.SelectedItem == null)
            {
                SetStatus("No hook trace selected to exclude!", true);
                return;
            }
            LogEntry entry = (LogEntry)LstTraces.SelectedItem;
            Manager.Filter.OriginatingSampleHashesExcluded.Add(entry.OriginatingAssemblyHash.Sha256);
            SetStatus("Filter: excluded the following originating sample hash: \"" + entry.OriginatingAssemblyHash.Sha256 + "\"", false);
            SetFilters();
        }

        private void onlyShowHookTracesWithThisParentHashToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (LstTraces.SelectedItem == null)
            {
                SetStatus("No hook trace selected to exclude!", true);
                return;
            }
            LogEntry entry = (LogEntry)LstTraces.SelectedItem;
            Manager.Filter.ParentHashes.Add(entry.ParentAssemblyHash);
            SetStatus("Filter: included the following parent hash: \"" + entry.ParentAssemblyHash + "\"", false);
            SetFilters();
        }

        private void excludeHookTracesWithThisParentHashToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (LstTraces.SelectedItem == null)
            {
                SetStatus("No hook trace selected to exclude!", true);
                return;
            }
            LogEntry entry = (LogEntry)LstTraces.SelectedItem;
            Manager.Filter.ParentHashesExcluded.Add(entry.ParentAssemblyHash);
            SetStatus("Filter: excluded the following parent hash: \"" + entry.ParentAssemblyHash + "\"", false);
            SetFilters();
        }

        private void showActivityLogsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetStatus("Opened the log", false);
            LogForm logForm = new LogForm(Manager.Log);
            logForm.ShowDialog();
        }

        private void LstTraces_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LstTraces.SelectedItem == null)
            {
                SetStatus("No hook trace is present, so none can be selected!", true);
            }
            LogEntry entry = (LogEntry)LstTraces.SelectedItem;
            ShowTraceDetails(entry);
        }

        private void rebuildInjectedExecutableFromHereToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RebuildInjectedExecutable();
        }

        private void rebuildInjectedExecutableFromTheSelectedTraceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RebuildInjectedExecutable();
        }
        #endregion

        #region Main GUI functions
        public void ShowTraceDetails(LogEntry entry)
        {
            LstStackTrace.Items.Clear();
            if (entry.StackTrace != null)
            {
                LstStackTrace.Items.AddRange(entry.StackTrace.ToArray());
            }

            DataGridViewFunctionArguments.ClearSelection();
            DataGridViewFunctionArguments.Rows.Clear();

            DataGridViewFunctionArguments.ColumnCount = 3;
            DataGridViewFunctionArguments.Columns[0].Name = "Type";
            DataGridViewFunctionArguments.Columns[1].Name = "Name";
            DataGridViewFunctionArguments.Columns[2].Name = "Value";

            if (entry.FunctionArguments != null)
            {
                foreach (Argument argument in entry.FunctionArguments)
                {
                    string[] row = { argument.Type, argument.Name, argument.Value };
                    DataGridViewFunctionArguments.Rows.Add(row);
                }

                string[] returnValue = { entry.ReturnValue.Type, entry.ReturnValue.Name, entry.ReturnValue.Value };
                int rowIndex = DataGridViewFunctionArguments.Rows.Add(returnValue);
                //Give the return value a different colour
                DataGridViewFunctionArguments.Rows[rowIndex].DefaultCellStyle.BackColor = Color.Black;
                DataGridViewFunctionArguments.Rows[rowIndex].DefaultCellStyle.ForeColor = Color.White;
            }

            DataGridViewFunctionArguments.ClearSelection();

            if (entry.OriginatingAssemblyName != null && String.IsNullOrWhiteSpace(entry.OriginatingAssemblyName) == false)
            {
                TxtOriginatingName.Text = entry.OriginatingAssemblyName;
            }
            else
            {
                TxtOriginatingName.Text = "[none]";
            }

            if (entry.OriginatingAssemblyVersion != null && String.IsNullOrWhiteSpace(entry.OriginatingAssemblyVersion) == false)
            {
                TxtOriginatingVersion.Text = entry.OriginatingAssemblyVersion;
            }
            else
            {
                TxtOriginatingVersion.Text = "[none]";
            }

            if (entry.OriginatingAssemblyHash != null && entry.OriginatingAssemblyHash.TypeRef != null && String.IsNullOrWhiteSpace(entry.OriginatingAssemblyHash.TypeRef) == false)
            {
                TxtOriginatingTypeRefHash.Text = entry.OriginatingAssemblyHash.TypeRef;
            }
            else
            {
                TxtOriginatingTypeRefHash.Text = "[none]";
            }

            if (entry.OriginatingAssemblyHash != null && entry.OriginatingAssemblyHash.ImportHash != null && String.IsNullOrWhiteSpace(entry.OriginatingAssemblyHash.ImportHash) == false)
            {
                TxtOriginatingImportHash.Text = entry.OriginatingAssemblyHash.ImportHash;
            }
            else
            {
                TxtOriginatingImportHash.Text = "[none]";
            }

            if (entry.OriginatingAssemblyHash != null && entry.OriginatingAssemblyHash.Sha256 != null && String.IsNullOrWhiteSpace(entry.OriginatingAssemblyHash.Sha256) == false)
            {
                TxtOriginatingSha256.Text = entry.OriginatingAssemblyHash.Sha256;
            }
            else
            {
                TxtOriginatingSha256.Text = "[none]";
            }

            if (entry.ParentAssemblyHash != null && String.IsNullOrWhiteSpace(entry.ParentAssemblyHash) == false)
            {
                TxtOriginatingParentSha256.Text = entry.ParentAssemblyHash;
            }
            else
            {
                TxtOriginatingParentSha256.Text = "[none]";
            }

            if (entry.FunctionName != null && String.IsNullOrWhiteSpace(entry.FunctionName) == false)
            {
                GroupTrace.Text = "Selected trace: " + entry.FunctionName;
            }
            else
            {
                GroupTrace.Text = "Selected trace: [no function name available]";
            }


            DataGridViewRelatedFiles.ClearSelection();
            DataGridViewRelatedFiles.Rows.Clear();

            DataGridViewRelatedFiles.ColumnCount = 5;
            DataGridViewRelatedFiles.Columns[0].Name = "MD-5";
            DataGridViewRelatedFiles.Columns[1].Name = "SHA-1";
            DataGridViewRelatedFiles.Columns[2].Name = "SHA-256";
            DataGridViewRelatedFiles.Columns[3].Name = "TypeRefHash";
            DataGridViewRelatedFiles.Columns[4].Name = "ImportHash";

            if (entry.RelatedFileHashes != null)
            {
                foreach (Hash hash in entry.RelatedFileHashes)
                {
                    string typeRef = hash.TypeRef;
                    if (String.IsNullOrWhiteSpace(typeRef))
                    {
                        typeRef = "[none]";
                    }

                    string importHash = hash.ImportHash;
                    if (String.IsNullOrWhiteSpace(importHash))
                    {
                        importHash = "[none]";
                    }
                    string[] row = { hash.Md5, hash.Sha1, hash.Sha256, typeRef, importHash };
                    DataGridViewRelatedFiles.Rows.Add(row);
                }
            }


            DataGridViewRelatedFiles.ClearSelection();

            DataGridViewCallOrder.ClearSelection();
            DataGridViewCallOrder.Rows.Clear();
            DataGridViewCallOrder.ColumnCount = 2;
            DataGridViewCallOrder.Columns[0].Name = "Assembly name";
            DataGridViewCallOrder.Columns[1].Name = "SHA-256";

            if (entry.AssemblyCallOrder != null)
            {
                foreach (AssemblyObject assemblyObject in entry.AssemblyCallOrder)
                {
                    string[] row = { assemblyObject.Name, assemblyObject.Hash };
                    DataGridViewCallOrder.Rows.Add(row);
                }
            }

            DataGridViewCallOrder.ClearSelection();

            LstResourceNames.Items.Clear();

            if (entry.OriginatingAssemblyResourceNames != null)
            {
                LstResourceNames.Items.AddRange(entry.OriginatingAssemblyResourceNames.ToArray());
            }

            SetStatus("Selected \"" + entry.ToString() + "\"!", false);
        }

        public void CopySelectedResource()
        {
            string value = LstResourceNames.SelectedItem as string;
            string listName = "resource name";
            SetValue(value, listName);
        }

        public void CopySelectedFunctionArgumentValue()
        {
            string value = null;
            if (DataGridViewFunctionArguments.SelectedCells.Count > 0)
            {
                int index = DataGridViewFunctionArguments.SelectedCells[0].RowIndex;
                value = Convert.ToString(DataGridViewFunctionArguments.Rows[index].Cells[2].Value);
            }
            string listName = "function argument";
            SetValue(value, listName);
        }

        public void SetValue(string value, string listName)
        {
            if (string.IsNullOrEmpty(value) == false)
            {
                Clipboard.SetText(value);
                SetStatus("Copied \"" + value + "\" to the clipboard!", false);
            }
            else
            {
                SetStatus("Can't copy the value from the " + listName + " list, as it is empty or there is no selected item!", true);
            }
        }

        public void CopyCallOrderName()
        {
            string value = null;
            if (DataGridViewCallOrder.SelectedCells.Count > 0)
            {
                int index = DataGridViewCallOrder.SelectedCells[0].RowIndex;
                value = Convert.ToString(DataGridViewCallOrder.Rows[index].Cells[0].Value);
            }
            string listName = "call order";
            SetValue(value, listName);
        }

        public void CopyCallOrderHash()
        {
            string value = null;
            if (DataGridViewCallOrder.SelectedCells.Count > 0)
            {
                int index = DataGridViewCallOrder.SelectedCells[0].RowIndex;
                value = Convert.ToString(DataGridViewCallOrder.Rows[index].Cells[1].Value);
            }
            string listName = "call order";
            SetValue(value, listName);
        }

        public void SetTraceList(List<LogEntry> entries)
        {
            LstTraces.Items.Clear();
            LstTraces.Items.AddRange(entries.ToArray());
        }

        public void SetFilters()
        {
            List<LogEntry> filteredEntries = Manager.ApplyFilter(Manager.Entries);
            SetTraceList(filteredEntries);
            SetStatus("Filter: applied all filters!", false);
            onlyShowFileRelatedHookTracesToolStripMenuItem.Checked = Manager.Filter.EnforceFileRelation;
            onlyShowCallsOriginatingFromTheSampleToolStripMenuItem.Checked = Manager.Filter.OriginatingCallMustComeFromSample;
            FilterFormInstance.SetFilterToGui();
        }

        public void ClearFilters()
        {
            DialogResult result = MessageBox.Show("Are you sure you want to clear all filters?", "Filter clearing confirmation request", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Manager.Filter = new SearchFilter();
                SetTraceList(Manager.Entries);
                SetStatus("Filter: cleared all filters!", false);
                onlyShowFileRelatedHookTracesToolStripMenuItem.Checked = false;
                onlyShowCallsOriginatingFromTheSampleToolStripMenuItem.Checked = false;
                FilterFormInstance.SetFilterToGui();
            }
            else
            {
                SetStatus("Filter clearing confirmation request denied", false);
            }
        }

        public void ExcludeLogEntry(LogEntry entry)
        {
            Manager.Filter.ExcludedEntries.Add(entry.ToString());
            SetStatus("Filter: excluded \"" + entry.ToString() + "\"", false);
            SetFilters();
        }

        public void SetStatus(string status, bool messageBox)
        {
            StatusLabel.Text = status;
            status = "[" + DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss") + "] " + status;
            Manager.Log.Add(status);

            if (messageBox)
            {
                MessageBox.Show(status, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void SetFilterOriginatingCallFromSample(bool value)
        {
            SetStatus("Filter: hook traces must come from the sample has been set to \"" + value + "\", previously equal to \"" + Manager.Filter.OriginatingCallMustComeFromSample + "\"", false);
            Manager.Filter.OriginatingCallMustComeFromSample = value;
            SetFilters();
        }

        public void SetFilterEnforceFileRelation(bool value)
        {
            SetStatus("Filter: file relationship enforcement has been set to \"" + value + "\", previously equal to \"" + Manager.Filter.EnforceFileRelation + "\"", false);
            Manager.Filter.EnforceFileRelation = value;
            SetFilters();
        }

        public void RebuildInjectedExecutable()
        {
            if (LstTraces.SelectedItem == null || LstTraces.SelectedIndex < 0)
            {
                SetStatus("No hook trace selected to rebuild the injected executable from!", true);
                return;
            }

            List<LogEntry> entries = new List<LogEntry>();
            foreach (LogEntry entry in LstTraces.Items)
            {
                entries.Add(entry);
            }
            try
            {
                string path = Manager.RebuildInjectedFile(entries, LstTraces.SelectedIndex);
                string message = "Saved the rebuilt file to \"" + path + "\"!";
                SetStatus(message, false);
                MessageBox.Show(message, "Rebuilt executable saved");
            } catch (Exception ex)
            {
                SetStatus(ex.Message, true); 
            }
            
        }
        #endregion
    }
}
