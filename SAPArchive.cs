using System;
using System.IO;
using System.Collections.Generic;

namespace SAP
{
    
    public class SAPArchive
    {
        private long _currentIndex = 0;
        private Dictionary<string, SAPFile> _files;
        private FileStream _stream = null;

        public SAPArchive(string path)
        {
            _stream = File.Open(path, FileMode.OpenOrCreate);
        }

        public byte[] GetFileData(string file)
        {
            if (!_files.ContainsKey(file))
                throw new FileNotFoundException();
            
            byte[] data = new byte[sizeof(int)];
            _stream.Read(data, _files[file].Start, sizeof(int));
            data = new byte[BitConverter.ToInt32(data, 0)];
            _stream.Read(data, _files[file].Start + sizeof(int), data.Length);

            return data;
        }

        private void RecursivelyAddPath(string path)
        {
            foreach (string p in Directory.EnumerateFiles(path))
            {

            }
        }
    }
}
