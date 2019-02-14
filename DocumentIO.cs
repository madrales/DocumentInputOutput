using System;
using System.IO;

namespace DocumentIO
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Document" + " ");
                Console.ReadLine();
                Console.WriteLine("What is the name of the document?");
                name = Console.ReadLine();
                FileStream F = new FileStream(name + ".txt", FileMode.OpenorCreate, FileAccess.ReadWrite);
            } catch (System.IO.IOException) {
                Console.WriteLine("The file can not be opened or created.");
                System.Environment.Exit(1);
            }
                finally {
                Console.WriteLine("What information would you like to put into the document?");
                Console.ReadLine();
            }


        }
    }
}
