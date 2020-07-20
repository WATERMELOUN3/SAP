namespace SAP
{
    public class SAPFile
    {
        public int Size { get; set; } = 0;
        public int Start { get; set; } = 0;
        public byte[] Data { get; private set; }
        public bool IsCompressed { get; set; }
        public bool IsEncrypted { get; set; }

        private byte flags = 0;

        public SAPFile()
        {

        }
    }
}