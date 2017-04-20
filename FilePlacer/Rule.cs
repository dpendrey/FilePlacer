using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FilePlacer
{
    public class Rule
    {
        public string Name;
        public string ScanPath;
        public bool IncludeSubdirectories;
        public string DestinationPath;
        public string ScanPattern;
        public string DestinationPattern;
        public string[] StringsToSpace;

        private string[] scanParts;

        public int FilesScanned;
        public int DirectoriesScanned;
        public int FilesQueued;

        public void Scan()
        {
            FilesScanned = DirectoriesScanned = FilesQueued = 0;

            scanParts = ScanPattern.Split(new char[] { '*' }, StringSplitOptions.None);

            scanPath(ScanPath);
        }

        private void scanPath(string Path)
        {
            string[] files = System.IO.Directory.GetFiles(Path);

            for (int i = 0; i < files.Length; i++)
            {
                scanFile(files[i]);
                FilesScanned++;
            }

            if (IncludeSubdirectories)
            {
                string[] paths = System.IO.Directory.GetDirectories(Path);

                for (int i = 0; i < paths.Length; i++)
                    scanPath(paths[i]);
            }

            DirectoriesScanned++;
        }

        private void scanFile(string Filename)
        {
            string[] strVals = new string[10];
            int[] intVals = new int[10];
            string filename = System.IO.Path.GetFileName(Filename);
            int index = 0;

            if (filename == "Naruto+Shippuden+-+009+-+The+Jinchurikis+Tears-r834.1-r726-r41.mp4")
            {
            }

            for (int i = 0; i < scanParts.Length; i++)
            {
                // Text match portion
                if (i % 2 == 0)
                {
                    if (filename.Substring(index, scanParts[i].Length).ToUpper() != scanParts[i].ToUpper())
                        return;
                    index += scanParts[i].Length;
                }
                // Pattern match portion
                else
                {
                    int saveIndex;
                    int endIndex;
                    if (scanParts[i].StartsWith("NUM")
                        &&
                        int.TryParse(scanParts[i].Substring(3), out saveIndex))
                    {
                        endIndex = filename.IndexOf(scanParts[i + 1], index, StringComparison.OrdinalIgnoreCase);
                        if (endIndex == -1)
                            return;
                        if (!int.TryParse(filename.Substring(index, endIndex - index), out intVals[saveIndex]))
                            return;
                        index = endIndex;
                    }
                    else if (scanParts[i].StartsWith("STR")
                        &&
                        int.TryParse(scanParts[i].Substring(3), out saveIndex))
                    {
                        endIndex = filename.IndexOf(scanParts[i + 1], index, StringComparison.OrdinalIgnoreCase);
                        if (endIndex == -1)
                            return;
                        strVals[saveIndex] = filename.Substring(index, endIndex - index);
                        index = endIndex;
                    }
                    else
                        return;
                }
            }


            string dest = DestinationPattern;
            for (int i = 0; i < intVals.Length; i++)
            {
                dest = dest.Replace("*NUM" + i.ToString() + "*", intVals[i].ToString());
                dest = dest.Replace("*NUM" + i.ToString() + "#1*", intVals[i].ToString("0"));
                dest = dest.Replace("*NUM" + i.ToString() + "#2*", intVals[i].ToString("00"));
                dest = dest.Replace("*NUM" + i.ToString() + "#3*", intVals[i].ToString("000"));
                dest = dest.Replace("*NUM" + i.ToString() + "#4*", intVals[i].ToString("0000"));
                dest = dest.Replace("*NUM" + i.ToString() + "#5*", intVals[i].ToString("00000"));
            }
            for (int i = 0; i < strVals.Length; i++)
                dest = dest.Replace("*STR" + i.ToString() + "*", strVals[i]);
            for (int i = 0; i < StringsToSpace.Length; i++)
                dest = dest.Replace(StringsToSpace[i], " ");
            dest = System.IO.Path.Combine(DestinationPath, dest);


            if (Filename.ToUpper() != dest.ToUpper())
            {
                FileCopies.AddFile(Filename, dest);
                FilesQueued++;
            }
        }

        private static List<Rule> rules = new List<Rule>();
        public static void AddRule(Rule Rule)
        {
            lock (rules)
                rules.Add(Rule);
        }

        public static void ScanAll()
        {
            List<Rule> allRules;

            lock (rules)
                allRules = new List<Rule>(rules);

            foreach (Rule r in rules)
                r.Scan();
        }
    }
}
