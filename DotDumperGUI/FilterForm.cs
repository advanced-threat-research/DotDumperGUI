using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using DotDumperGUI.Handlers;
using DotDumperGUI.Models;
using static System.Environment;

namespace DotDumperGUI
{
    public partial class FilterForm : Form
    {
        private FormMain main;
        public FilterForm(FormMain main)
        {
            InitializeComponent();
            this.main = main;
            SetFilterToGui();
        }

        public void SetFilterToGui()
        {
            ChckFileRelatedEntriesOnly.Checked = main.Manager.Filter.EnforceFileRelation;
            ChckOriginatingCallsOnly.Checked = main.Manager.Filter.OriginatingCallMustComeFromSample;

            List<string> filterItems = new List<string>();

            foreach (string s in main.Manager.Filter.OriginatingSampleNames)
            {
                filterItems.Add("Originating Sample Name must include: \"" + s + "\"");
            }

            foreach (string s in main.Manager.Filter.OriginatingSampleNamesExcluded)
            {
                filterItems.Add("Originating Sample Name must exclude: \"" + s + "\"");
            }

            foreach (string s in main.Manager.Filter.OriginatingSampleHashes)
            {
                filterItems.Add("Originating Sample Hash must include: \"" + s + "\"");
            }

            foreach (string s in main.Manager.Filter.OriginatingSampleHashesExcluded)
            {
                filterItems.Add("Originating Sample Hash must exclude: \"" + s + "\"");
            }

            foreach (string s in main.Manager.Filter.ParentHashes)
            {
                filterItems.Add("Parent Hash must include: \"" + s + "\"");
            }

            foreach (string s in main.Manager.Filter.ParentHashesExcluded)
            {
                filterItems.Add("Parent Hash must exclude: \"" + s + "\"");
            }

            foreach (string s in main.Manager.Filter.ResourceNames)
            {
                filterItems.Add("Resource Names must include: \"" + s + "\"");
            }

            foreach (string s in main.Manager.Filter.ResourceNamesExcluded)
            {
                filterItems.Add("Resource Names must exclude: \"" + s + "\"");
            }

            foreach (string s in main.Manager.Filter.RelatedFilesHashes)
            {
                filterItems.Add("Related File Hash must include: \"" + s + "\"");
            }

            foreach (string s in main.Manager.Filter.RelatedFilesHashesExcluded)
            {
                filterItems.Add("Related File Hash must exclude: \"" + s + "\"");
            }

            foreach (string s in main.Manager.Filter.FunctionNames)
            {
                filterItems.Add("Function Name must include: \"" + s + "\"");
            }

            foreach (string s in main.Manager.Filter.FunctionNamesExcluded)
            {
                filterItems.Add("Function Name must exclude: \"" + s + "\"");
            }

            foreach (string s in main.Manager.Filter.ExcludedEntries)
            {
                filterItems.Add("Entries must exclude: \"" + s + "\"");
            }

            LstFilters.ClearSelected();
            LstFilters.Items.Clear();
            LstFilters.Items.AddRange(filterItems.ToArray());

            /*
             *  Originating Sample Name
                Originating Sample Hash
                Parent Hash
                Resource Name
                Related Files Hash
                Function Name
                Excluded Entry
            */
        }

        private string GetRemainingString(string input, string offset)
        {
            int index = offset.Length;
            string output = input.Substring(index);
            output = output.Substring(0, output.Length - 1);
            return output;
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            DeleteSelectedFilter();
        }

        private void DeleteSelectedFilter()
        {
            if (LstFilters.SelectedItem == null)
            {
                MessageBox.Show("Cannot delete the selected filter, as there is none!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string item = LstFilters.SelectedItem.ToString();
            string toDelete = null;
            if (item.StartsWith("Originating Sample Name must include: \""))
            {
                toDelete = GetRemainingString(item, "Originating Sample Name must include: \"");
                main.Manager.Filter.OriginatingSampleNames.Remove(toDelete);
            }
            else if (item.StartsWith("Originating Sample Name must exclude: \""))
            {
                toDelete = GetRemainingString(item, "Originating Sample Name must exclude: \"");
                main.Manager.Filter.OriginatingSampleNamesExcluded.Remove(toDelete);
            }
            else if (item.StartsWith("Originating Sample Hash must include: \""))
            {
                toDelete = GetRemainingString(item, "Originating Sample Hash must include: \"");
                main.Manager.Filter.OriginatingSampleHashes.Remove(toDelete);
            }
            else if (item.StartsWith("Originating Sample Hash must exclude: \""))
            {
                toDelete = GetRemainingString(item, "Originating Sample Hash must exclude: \"");
                main.Manager.Filter.OriginatingSampleHashesExcluded.Remove(toDelete);
            }
            else if (item.StartsWith("Parent Hash must include: \""))
            {
                toDelete = GetRemainingString(item, "Parent Hash must include: \"");
                main.Manager.Filter.ParentHashes.Remove(toDelete);
            }
            else if (item.StartsWith("Parent Hash must exclude: \""))
            {
                toDelete = GetRemainingString(item, "Parent Hash must exclude: \"");
                main.Manager.Filter.ParentHashesExcluded.Remove(toDelete);
            }
            else if (item.StartsWith("Resource Names must include: \""))
            {
                toDelete = GetRemainingString(item, "Resource Names must include: \"");
                main.Manager.Filter.ResourceNames.Remove(toDelete);
            }
            else if (item.StartsWith("Resource Names must exclude: \""))
            {
                toDelete = GetRemainingString(item, "Resource Names must exclude: \"");
                main.Manager.Filter.ResourceNamesExcluded.Remove(toDelete);
            }
            else if (item.StartsWith("Related File Hash must include: \""))
            {
                toDelete = GetRemainingString(item, "Related File Hash must include: \"");
                main.Manager.Filter.RelatedFilesHashes.Remove(toDelete);
            }
            else if (item.StartsWith("Related File Hash must exclude: \""))
            {
                toDelete = GetRemainingString(item, "Related File Hash must exclude: \"");
                main.Manager.Filter.RelatedFilesHashesExcluded.Remove(toDelete);
            }
            else if (item.StartsWith("Function Name must include: \""))
            {
                toDelete = GetRemainingString(item, "Function Name must include: \"");
                main.Manager.Filter.FunctionNames.Remove(toDelete);
            }
            else if (item.StartsWith("Function Name must exclude: \""))
            {
                toDelete = GetRemainingString(item, "Function Name must exclude: \"");
                main.Manager.Filter.FunctionNamesExcluded.Remove(toDelete);
            }
            else if (item.StartsWith("Entries must exclude: \""))
            {
                toDelete = GetRemainingString(item, "Entries must exclude: \"");
                main.Manager.Filter.ExcludedEntries.Remove(toDelete);
            }


            if (toDelete != null)
            {
                main.SetStatus("Filter: removed \"" + item + "\"", false);
                main.SetFilters();
            }
            else
            {
                MessageBox.Show("No item has been deleted, as there was no matching value found in the filter!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void clearAllFiltersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            main.ClearFilters();
        }

        private void FilterForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            main.FilterFormInstance = new FilterForm(main);
        }

        private void openFiltersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                InitialDirectory = Environment.GetFolderPath(SpecialFolder.UserProfile),
                //InitialDirectory = @"C:\Users\John\Source\Repos\DotDumper\DotDumper\bin\Debug\6f93fd91f17130aabd5251e7bae3eeaa-cleaned_DotDumper_DotDumper",
                Title = "Select a DotDumperGUI filter",
                CheckFileExists = true,
                Multiselect = false,
                Filter = "All files (*.*)|*.*"
            };
            DialogResult result = openFileDialog.ShowDialog();

            if (result != DialogResult.OK)
            {
                main.SetStatus("Filter file opening cancelled!", false);
                return;
            }
            string filePath = openFileDialog.FileName;
            FileLoader traceLoader = new FileLoader();
            try
            {
                SearchFilter filter = traceLoader.LoadFilter(filePath);
                main.SetStatus("Successfully loaded the filter file from \"" + filePath + "\"!", false);
                main.Manager.Filter = filter;
                main.SetStatus("Successfully set the loaded filter!", false);
                main.SetFilters();
            }
            catch (Exception)
            {
                main.SetStatus("An error occured when attempting to load \"" + filePath + "\"!", true);
            }
        }

        private void addFiltersFromFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                //InitialDirectory = Application.StartupPath;
                InitialDirectory = @"C:\Users\John\Source\Repos\DotDumper\DotDumper\bin\Debug\6f93fd91f17130aabd5251e7bae3eeaa-cleaned_DotDumper_DotDumper",
                Title = "Select a DotDumperGUI filter to add to the current filter",
                CheckFileExists = true,
                Multiselect = false,
                Filter = "All files (*.*)|*.*"
            };
            DialogResult result = openFileDialog.ShowDialog();

            if (result != DialogResult.OK)
            {
                main.SetStatus("Filter file opening cancelled!", false);
                return;
            }
            string filePath = openFileDialog.FileName;
            FileLoader traceLoader = new FileLoader();
            try
            {
                SearchFilter filter = traceLoader.LoadFilter(filePath);
                main.SetStatus("Successfully loaded the filter file from \"" + filePath + "\"!", false);
                main.Manager.Merge(filter);
                main.SetStatus("Successfully merged the filters!", false);
                main.SetFilters();
            }
            catch (Exception)
            {
                main.SetStatus("An error occured when attempting to load \"" + filePath + "\"!", true);
            }
        }

        private void saveFiltersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                InitialDirectory = Environment.GetFolderPath(SpecialFolder.UserProfile),
                Title = "Save the DotDumperGUI filter",
                AddExtension = true,
                Filter = "JSON files (*.json)|*.json",
                DefaultExt = ".json"
            };

            DialogResult result = saveFileDialog.ShowDialog();
            if (result != DialogResult.OK)
            {
                main.SetStatus("Filter saving cancelled!", false);
                return;
            }

            string filePath = saveFileDialog.FileName;

            string json = JsonSerializer.Serialize(main.Manager.Filter, typeof(SearchFilter));

            File.WriteAllText(filePath, json);
            main.SetStatus("Successfully saved the current filter selection to \"" + filePath + "\"!", false);

        }

        private void clearAllFiltersToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            main.ClearFilters();
        }

        private void BtnInclude_Click(object sender, EventArgs e)
        {
            AddFilter(false);
        }

        private void BtnExclude_Click(object sender, EventArgs e)
        {
            AddFilter(true);
        }

        private void AddFilter(bool toExclude)
        {
            if (CmbType.SelectedItem == null || string.IsNullOrEmpty(CmbType.SelectedItem.ToString()))
            {
                MessageBox.Show("No item has been selected to be included in the filters!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(TxtValue.Text))
            {
                MessageBox.Show("No (partial) value is given to filter with!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string comboValue = CmbType.SelectedItem.ToString();
            string value = TxtValue.Text;

            switch (comboValue)
            {
                case "Originating Sample Name":
                    if (toExclude)
                    {
                        main.Manager.Filter.OriginatingSampleNamesExcluded.Add(value);
                    }
                    else
                    {
                        main.Manager.Filter.OriginatingSampleNames.Add(value);
                    }
                    break;
                case "Originating Sample Hash":
                    if (toExclude)
                    {
                        main.Manager.Filter.OriginatingSampleHashesExcluded.Add(value);
                    }
                    else
                    {
                        main.Manager.Filter.OriginatingSampleHashes.Add(value);
                    }
                    break;
                case "Parent Hash":
                    if (toExclude)
                    {
                        main.Manager.Filter.ParentHashesExcluded.Add(value);
                    }
                    else
                    {
                        main.Manager.Filter.ParentHashes.Add(value);
                    }
                    break;
                case "Resource Name":
                    if (toExclude)
                    {
                        main.Manager.Filter.ResourceNamesExcluded.Add(value);
                    }
                    else
                    {
                        main.Manager.Filter.ResourceNames.Add(value);
                    }
                    break;
                case "Related Files Hash":
                    if (toExclude)
                    {
                        main.Manager.Filter.RelatedFilesHashesExcluded.Add(value);
                    }
                    else
                    {
                        main.Manager.Filter.RelatedFilesHashes.Add(value);
                    }
                    break;
                case "Function Name":
                    if (toExclude)
                    {
                        main.Manager.Filter.FunctionNamesExcluded.Add(value);
                    }
                    else
                    {
                        main.Manager.Filter.FunctionNames.Add(value);
                    }
                    break;
                case "Excluded Entry":
                    if (toExclude == false)
                    {
                        MessageBox.Show("The exclusion of an entry cannot be included!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        main.Manager.Filter.ExcludedEntries.Add(value);
                    }
                    break;
            }

            string action = "included";
            if (toExclude)
            {
                action = "excluded";
            }
            string message = "Filter: " + action + " \"" + value + "\" as \"" + comboValue + "\"";
            main.SetStatus(message, false);
            main.SetFilters();
        }

        private void ChckFileRelatedEntriesOnly_CheckedChanged(object sender, EventArgs e)
        {
            main.SetFilterEnforceFileRelation(ChckFileRelatedEntriesOnly.Checked);
        }

        private void ChckOriginatingCallsOnly_CheckedChanged(object sender, EventArgs e)
        {
            main.SetFilterOriginatingCallFromSample(ChckOriginatingCallsOnly.Checked);
        }

        private void deleteSelectedFilterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteSelectedFilter();
        }

        private void BtnDeleteAllFilters_Click(object sender, EventArgs e)
        {
            main.ClearFilters();
        }
    }
}
