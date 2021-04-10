using System;
using System.IO;
using System.IO.Compression;
using Microsoft.Win32;

namespace Backup
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("TRABALHANDO EM BACKUP.................");
                ZipFile.CreateFromDirectory(@"C:\Users\Valfran\Desktop\a", @"C:\Users\Valfran\Desktop\result.zip");
                Console.WriteLine("BACKUP FINALIZADO.................");
            }
            catch(Exception ex) { Console.WriteLine("ERRO!\n\n"+ex); }

        }

       

    } //*******************
}
