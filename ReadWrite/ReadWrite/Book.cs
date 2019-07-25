using System.IO;
using System.Linq.Expressions;

namespace ReadWrite
{
    public class Book
    {
        public string Materials { get; set; }

         public Book()
        {
            Materials = "";
        }

        public void Read()
        {
            StreamReader read = new StreamReader("book.txt");
            string line = "";
            while ((line=read.ReadLine())!= null)
            {
                Materials += line;
            }
        }
    }
}