using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;
using DotDumperGUI.Models;
using System.IO;

namespace DotDumperGUI.Handlers
{
    public class FileLoader
    {

        public FileLoader()
        {
        }

        public List<LogEntry> LoadEntries(string filePath)
        {
            try
            {
                string json = File.ReadAllText(filePath);
                List<LogEntry> entries = (List<LogEntry>)JsonSerializer.Deserialize(json, typeof(List<LogEntry>));
                foreach (LogEntry entry in entries)
                {
                    if (entry.FunctionName.Contains("DotDumper.Hooks.InteropFunctions"))
                    {
                        entry.FunctionName = entry.FunctionName.Replace("DotDumper.Hooks.InteropFunctions", "InteropFunctions");
                    }
                }
                return entries;
            }
            catch (Exception)
            {
                throw new IOException("Error while loading the traces! Are you sure you selected a DotDumper JSON trace output?");
            }

        }

        public SearchFilter LoadFilter(string filePath)
        {
            try
            {
                string json = File.ReadAllText(filePath);
                SearchFilter filter = (SearchFilter)JsonSerializer.Deserialize(json, typeof(SearchFilter));
                return filter;
            }
            catch (Exception)
            {
                throw new IOException("Error while loading the filter! Are you sure you selected a DotDumperGUI filter?");
            }
        }
    }
}
