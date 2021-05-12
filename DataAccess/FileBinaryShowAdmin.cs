using System;
using System.Collections;
using LibraryModels;

namespace DataAccess
{
    public class FileBinaryShowAdmin : DataInterface
    {
        string NumeFisier { get; set; }
        public FileBinaryShowAdmin(string numeFisiser)
        {
            this.NumeFisier = NumeFisier;
        }

        public void AddShow(show s)
        {
            throw new Exception("Optiunea AddShow nu este implementata");
        }

        public ArrayList GetShows()
        {
            throw new Exception("Optiunea GetShows nu este implementata");
        }
    }
}
