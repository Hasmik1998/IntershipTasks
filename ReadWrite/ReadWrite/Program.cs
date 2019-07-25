using System;
namespace ReadWrite
{
    
    class Program
    {
        
        static void Main(string[] args)
        {
            Book book = new Book();
            Journal journal = new Journal();
            Copybook copybook = new Copybook();
            Notebook notebook= new Notebook();
            Console.WriteLine("1- Read from Book 2-Read from Journal 3- Read from Copybook 4-Read from Notebook");
            int option1= Int32.Parse(Console.ReadLine());
            switch (option1)
            {
                case 1: 
                    book.Read();
                    break;
                case 2:  
                    journal.Read();
                    break;
                case 3:  
                    copybook.Read();
                    break;
                case 4:  
                    notebook.Read();
                    break;
                default: break;
            }

            Console.WriteLine("1- Write in Copybook 2- Write in Notebook");
            int option2 = Int32.Parse(Console.ReadLine());
            switch (option2)
            {
                case 1:
                    switch (option1)
                    {
                        case 1:
                            copybook.Write(book.Materials); 
                            break;
                        case 2:
                            copybook.Write(journal.Materials);
                            break;
                        case 3:
                            copybook.Write(copybook.readMaterial);
                            break;
                        case 4:
                            copybook.Write(notebook.readMaterial);
                            break;
                        default: break;
                    }
                    break;

                case 2:  
                    switch (option1)
                    {
                        case 1:
                            notebook.Write(book.Materials); 
                            break;
                        case 2:
                            notebook.Write(journal.Materials);
                            break;
                        case 3:
                            notebook.Write(copybook.readMaterial);
                            break;
                        case 4:
                            notebook.Write(notebook.readMaterial);
                            break;
                        default: break;
                    }
                    break;
                default: break;
            }
        }
    }
}