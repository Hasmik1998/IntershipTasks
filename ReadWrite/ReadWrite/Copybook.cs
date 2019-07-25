using System.IO;

namespace ReadWrite
{
    public class Copybook
    {
        public string readMaterial { get; set; }
        public string writeMaterial { get; set; }

        public Copybook()
        {
            readMaterial = "";
            writeMaterial = "";
        }

        public void Read()
        {
            StreamReader read = new StreamReader("copybook.txt");
            string line = "";
            while ((line=read.ReadLine())!= null)
            {
                readMaterial += line;
            }
        }

        public void Write(string text)
        {
            StreamWriter w = new StreamWriter("copybook.txt");
            w.Write(text);
            w.Close();
        }
    }
}