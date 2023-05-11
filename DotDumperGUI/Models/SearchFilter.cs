using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotDumperGUI.Models
{
    public class SearchFilter
    {
        public bool EnforceFileRelation { get; set; }
        public bool OriginatingCallMustComeFromSample { get; set; }
        public HashSet<string> OriginatingSampleNames { get; set; }
        public HashSet<string> OriginatingSampleNamesExcluded { get; set; }
        public HashSet<string> OriginatingSampleHashes { get; set; }
        public HashSet<string> OriginatingSampleHashesExcluded { get; set; }
        public HashSet<string> ParentHashes { get; set; }
        public HashSet<string> ParentHashesExcluded { get; set; }
        public HashSet<string> ResourceNames { get; set; }
        public HashSet<string> ResourceNamesExcluded { get; set; }
        public HashSet<string> RelatedFilesHashes { get; set; }
        public HashSet<string> RelatedFilesHashesExcluded { get; set; }
        public HashSet<string> FunctionNames { get; set; }
        public HashSet<string> FunctionNamesExcluded { get; set; }
        public HashSet<string> ExcludedEntries { get; set; }

        public SearchFilter()
        {
            EnforceFileRelation = false;
            OriginatingCallMustComeFromSample = false;
            OriginatingSampleNames = new HashSet<string>();
            OriginatingSampleNamesExcluded = new HashSet<string>();
            OriginatingSampleHashes = new HashSet<string>();
            OriginatingSampleHashesExcluded = new HashSet<string>();
            ParentHashes = new HashSet<string>();
            ParentHashesExcluded = new HashSet<string>();
            ResourceNames = new HashSet<string>();
            ResourceNamesExcluded = new HashSet<string>();
            RelatedFilesHashes = new HashSet<string>();
            RelatedFilesHashesExcluded = new HashSet<string>();
            FunctionNames = new HashSet<string>();
            FunctionNamesExcluded = new HashSet<string>();
            ExcludedEntries = new HashSet<string>();
        }
    }
}
