using System.IO;
using System.Linq.Expressions;

namespace ReadWrite
{
    public class Journal
    {
        public string Materials { get; set; }

        public Journal()
        {
            Materials = "";
        }

        public void Read()
        {
            StreamReader read = new StreamReader("journal.txt");
            string line = "";
            while ((line=read.ReadLine())!= null)
            {
                Materials += line;
            }
        }
    }
}