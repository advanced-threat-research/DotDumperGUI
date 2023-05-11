using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using DotDumperGUI.Models;

namespace DotDumperGUI.Handlers
{
    public class TraceManager
    {
        public List<LogEntry> Entries { get; set; }
        public SearchFilter Filter { get; set; }
        public List<string> Log { get; set; }
        public string JsonPath { get; set; }

        public TraceManager()
        {
            this.Filter = new SearchFilter();
            this.Entries = new List<LogEntry>();
            this.Log = new List<string>();
            Log.Add("[" + DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss") + "] DotDumperGUI started");
            JsonPath = "";
        }

        public List<LogEntry> Restore()
        {
            return Entries;
        }

        public List<LogEntry> ApplyFilter(List<LogEntry> entries)
        {
            List<LogEntry> results = new List<LogEntry>();

            foreach (LogEntry entry in entries)
            {

                if (EntryMatchesFilter(entry))
                {
                    results.Add(entry);
                }
            }

            return results;
        }

        private bool EntryMatchesFilter(LogEntry entry)
        {
            //Ensure the entry has at least one related file, if the filter is set
            if (Filter.EnforceFileRelation && entry.RelatedFileHashes.Count == 0)
            {
                return false;
            }

            //Ensure the entry's most recent assembly call is coming from the sample (meaning not DotDumper nor the DotNet Framework), if the filter is set
            if (Filter.OriginatingCallMustComeFromSample && entry.AssemblyCallOrder.Count > 0 && entry.AssemblyCallOrder[0].Name.Equals("[DotDumper or DotNet Framework related assembly]", StringComparison.InvariantCultureIgnoreCase))
            {
                return false;
            }

            //Ensure the assembly name is within the list of names within the filter, if it is not empty
            if (Filter.OriginatingSampleNames.Count > 0)
            {
                if (ListContains(Filter.OriginatingSampleNames, entry.OriginatingAssemblyName) == false)
                {
                    return false;
                }
            }

            //Ensure the assembly name is not within the list of names within the filter, if it is not empty
            if (Filter.OriginatingSampleNamesExcluded.Count > 0)
            {
                if (ListContains(Filter.OriginatingSampleNamesExcluded, entry.OriginatingAssemblyName))
                {
                    return false;
                }
            }


            if (Filter.OriginatingSampleHashes.Count > 0)
            {
                if (ListContains(Filter.OriginatingSampleHashes, entry.OriginatingAssemblyHash) == false)
                {
                    return false;
                }
            }

            if (Filter.OriginatingSampleHashesExcluded.Count > 0)
            {
                if (ListContains(Filter.OriginatingSampleHashesExcluded, entry.OriginatingAssemblyHash))
                {
                    return false;
                }
            }

            if (Filter.ParentHashes.Count > 0)
            {
                if (ListContains(Filter.ParentHashes, entry.ParentAssemblyHash) == false)
                {
                    return false;
                }
            }

            if (Filter.ParentHashesExcluded.Count > 0)
            {
                if (ListContains(Filter.ParentHashesExcluded, entry.ParentAssemblyHash))
                {
                    return false;
                }
            }

            if (Filter.ResourceNames.Count > 0)
            {
                if (ListContains(Filter.ResourceNames, entry.OriginatingAssemblyResourceNames) == false)
                {
                    return false;
                }
            }

            if (Filter.ResourceNamesExcluded.Count > 0)
            {
                if (ListContains(Filter.ResourceNamesExcluded, entry.OriginatingAssemblyResourceNames))
                {
                    return false;
                }
            }

            if (Filter.RelatedFilesHashes.Count > 0)
            {
                if (ListContains(Filter.RelatedFilesHashes, entry.RelatedFileHashes) == false)
                {
                    return false;
                }
            }

            if (Filter.RelatedFilesHashesExcluded.Count > 0)
            {
                if (ListContains(Filter.RelatedFilesHashesExcluded, entry.RelatedFileHashes))
                {
                    return false;
                }
            }

            if (Filter.FunctionNames.Count > 0)
            {
                if (ListContains(Filter.FunctionNames, entry.FunctionName) == false)
                {
                    return false;
                }
            }

            if (Filter.FunctionNamesExcluded.Count > 0)
            {
                if (ListContains(Filter.FunctionNamesExcluded, entry.FunctionName))
                {
                    return false;
                }
            }

            if (Filter.ExcludedEntries.Count > 0)
            {
                if (ListContains(Filter.ExcludedEntries, entry.ToString()))
                {
                    return false;
                }
            }

            return true;
        }

        private bool ListContains(HashSet<string> list, string comparison)
        {
            foreach (string s in list)
            {
                if (comparison.Contains(s, StringComparison.InvariantCultureIgnoreCase))
                {
                    return true;
                }
            }
            return false;
        }

        private bool ListContains(HashSet<string> list, List<string> comparison)
        {
            foreach (string s in list)
            {
                foreach (string c in comparison)
                {
                    if (s.Contains(c, StringComparison.InvariantCultureIgnoreCase))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private bool ListContains(HashSet<string> list, Hash hash)
        {
            List<string> hashList = new List<string>();
            hashList.Add(hash.Md5);
            hashList.Add(hash.Sha1);
            hashList.Add(hash.Sha256);
            return ListContains(list, hashList);
        }

        private bool ListContains(HashSet<string> list, List<Hash> hashes)
        {
            List<string> hashList = new List<string>();
            foreach (Hash hash in hashes)
            {
                hashList.Add(hash.Md5);
                hashList.Add(hash.Sha1);
                hashList.Add(hash.Sha256);
            }
            return ListContains(list, hashList);
        }

        public void Merge(SearchFilter filter)
        {
            if (filter.EnforceFileRelation)
            {
                Filter.EnforceFileRelation = filter.EnforceFileRelation;
            }

            if (filter.OriginatingCallMustComeFromSample)
            {
                Filter.OriginatingCallMustComeFromSample = filter.OriginatingCallMustComeFromSample;
            }

            Filter.OriginatingSampleNames.UnionWith(filter.OriginatingSampleNames);
            Filter.OriginatingSampleNamesExcluded.UnionWith(filter.OriginatingSampleNamesExcluded);
            Filter.OriginatingSampleHashes.UnionWith(filter.OriginatingSampleHashes);
            Filter.OriginatingSampleHashesExcluded.UnionWith(filter.OriginatingSampleHashesExcluded);
            Filter.ParentHashes.UnionWith(filter.ParentHashes);
            Filter.ParentHashesExcluded.UnionWith(filter.ParentHashesExcluded);
            Filter.ResourceNames.UnionWith(filter.ResourceNames);
            Filter.ResourceNamesExcluded.UnionWith(filter.ResourceNamesExcluded);
            Filter.RelatedFilesHashes.UnionWith(filter.RelatedFilesHashes);
            Filter.RelatedFilesHashesExcluded.UnionWith(filter.RelatedFilesHashesExcluded);
            Filter.FunctionNames.UnionWith(filter.FunctionNames);
            Filter.FunctionNamesExcluded.UnionWith(filter.FunctionNamesExcluded);
            Filter.ExcludedEntries.UnionWith(filter.ExcludedEntries);
        }

        public string RebuildInjectedFile(List<LogEntry> input, int index)
        {
            List<byte> bytes = new List<byte>();
            LogEntry selectedEntry = input[index];

            for (int i = 0; (i + index) < input.Count; i++)
            {
                LogEntry temp = input[i + index];
                if (temp.FunctionName.Equals(selectedEntry.FunctionName, StringComparison.InvariantCultureIgnoreCase))
                {
                    if (temp.RelatedFileHashes.Count > 0)
                    {
                        string file = JsonPath + temp.RelatedFileHashes[0].Sha256;
                        byte[] fileBytes = File.ReadAllBytes(file);
                        bytes.AddRange(fileBytes);
                    }
                }
            }

            if (bytes.Count <= 0)
            {
                throw new Exception("No related files found in the selected traces!");
            }

            SHA256 sha256Alg = SHA256.Create();
            string outputSha256 = CalculateHash(sha256Alg, bytes.ToArray());
            File.WriteAllBytes(JsonPath + outputSha256, bytes.ToArray());
            return JsonPath + outputSha256;
        }

        /// <summary>
        /// This function calculates the hash of the given data, using the given hashing algorithm
        /// </summary>
        /// <param name="hashAlgorithm">The hashing algorithm to use</param>
        /// <param name="data">The data to hash</param>
        /// <returns>The hash of the data as a string, based on the given hash algorithm</returns>
        private string CalculateHash(HashAlgorithm hashAlgorithm, byte[] data)
        {
            string hash = "";

            if (data == null || hashAlgorithm == null)
            {
                return hash;
            }

            byte[] rawHash = hashAlgorithm.ComputeHash(data);

            for (int i = 0; i < rawHash.Length; i++)
            {
                hash += rawHash[i].ToString("x2");
            }

            return hash;
        }
    }
}
