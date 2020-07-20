# SAP
Sukiyaki Archiving Protocol (just a flex name, it ain't much, but it's honest work)

## Protocol
The file first contains a header, which contains all files infos.
Then files binaries are added one after the other, they may be encrypted or compressed.

The header is a list of file with their properties, they are one after the other, and looks like this:
* File name size (Int32)
* File name (string)
* Flags byte (byte)
    * Compressed (gzip)
    * Encrypted (todo)
    * todo...
* File address (Int32), 0 is end of header
* File size (Int32), in bytes of course