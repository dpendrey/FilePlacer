using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FilePlacer
{
    public class FileCopies
    {
        public string Source, Destination;
        public bool IsMove;
        public bool IsComplete;
        public bool WasSuccess;
        public long BytesCopied, BytesToCopy;

        private static List<FileCopies> copies = new List<FileCopies>();
        public static int NumberFiles
        {
            get
            {
                int retVal;
                lock (copies)
                    retVal = copies.Count;
                return retVal;
            }
        }
        public static void AddFile(string Source, string Destination)
        {
            FileCopies copy = new FileCopies();
            copy.Source = Source;
            copy.Destination = Destination;

            lock (copies)
                copies.Add(copy);
        }

        public static void CopyAll()
        {
            FileCopies copy = getNextCopy();

            while (copy != null)
            {
                System.IO.File.Move(copy.Source, copy.Destination);
                copy = getNextCopy();
            }
        }
        private static FileCopies getNextCopy()
        {
            FileCopies retVal;

            lock (copies)
            {
                if (copies.Count == 0)
                    retVal = null;
                else
                {
                    int index = copies.Count - 1;
                    retVal = copies[index];
                    copies.RemoveAt(index);
                }
            }

            return retVal;
        }
    }
}
