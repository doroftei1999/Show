using System;
using System.Collections;
using LibraryModels;
using DataAccess;

namespace Show
{
    class Program
    {
        static void Main()
        {
            DataInterface file = StorageFactory.GetStorageAdministrator();
            ArrayList Shows;
            show BBT = new show("The Big Bang Theory;1; 12; 279; 8.1;false");
            show SOA = new show("Sons of anarchy;2; 7; 92; 8.5;false");
            file.AddShow(BBT);
            file.AddShow(SOA);
            Shows = file.GetShows();
            foreach (show a in Shows)
                Console.WriteLine(a.convertToString());
            Console.ReadKey();
        }
    }
}
