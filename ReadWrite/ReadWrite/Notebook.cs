using System.IO;

namespace ReadWrite
{
    public class Notebook
    {
        public string readMaterial { get; set; }
        public string writeMaterial { get; set; }

        public Notebook()
        {
            readMaterial = "";
            writeMaterial = "";
        }

        public void Read()
        {
            StreamReader read = new StreamReader("notebook.txt");
            string line = "";
            while ((line=read.ReadLine())!= null)
            {
                readMaterial += line;
            }
        }

        public void Write(string text)
        {
            StreamWriter w = new StreamWriter("notebook.txt");
            w.Write(text);
            w.Close();
        }
    }
}