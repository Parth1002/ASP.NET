using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Security.Permissions;

namespace FileAccessLib
{
    public class Class1
    {

       [FileIOPermissionAttribute(SecurityAction.Assert, ViewAndModify =
    "c:\\file.txt")]

        public bool AccessFile(ref string FileText)
        {
            try
            {
                System.IO.FileStream fs = new
                System.IO.FileStream("C:\\file.txt",
                FileMode.OpenOrCreate, FileAccess.Write);
                StreamWriter w = new StreamWriter(fs);
                w.BaseStream.Seek(0, SeekOrigin.End);
                w.WriteLine("Here is the file's text.");
                w.Write("Here is more file text." +
                System.Environment.NewLine);
                w.WriteLine("And that's about it.");
                w.Flush();
                w.Close();
                fs = new System.IO.FileStream("C:\\file.txt",
                FileMode.Open, FileAccess.Read);
                StreamReader r = new StreamReader(fs);
                r.BaseStream.Seek(0, SeekOrigin.Begin);
                FileText = "";
                while (r.Peek() > -1)
                {
                    FileText += r.ReadLine() +
                    System.Environment.NewLine;
                }
                r.Close();
                return true;
            }
            catch //ex As Security.SecurityException
            {
                return false;
            }
        }
    }
}

