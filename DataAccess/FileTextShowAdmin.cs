using System;
using System.IO;
using System.Collections;
using LibraryModels;

namespace DataAccess
{
    public class FileTextShowAdmin : DataInterface
    {
        public string FileName { get; set; }
        public FileTextShowAdmin(string FileName)
        {
            this.FileName = FileName;
            Stream FILE = File.Open(FileName, FileMode.OpenOrCreate);
            FILE.Close();
        }
        public void AddShow(show s)
        {
            try
            {
                using(StreamWriter SwTextFile = new StreamWriter(FileName, true))
                {
                    SwTextFile.WriteLine(s.convertToFileFormat());
                }
            }
            catch(IOException eIO)
            {
                throw new Exception("Eroare la deschiderea fisierului. Mesaj: "  + eIO.Message);
            }
            catch(Exception eGen)
            {
                throw new Exception("Eroare generica. Mesaj: " + eGen.Message);
            }
        }
        public ArrayList GetShows()
        {
            ArrayList Shows = new ArrayList();
            try
            {
                using(StreamReader Sr = new StreamReader(FileName))
                {
                    string line;
                    while ((line = Sr.ReadLine()) != null)
                    {
                        show showFromFile = new show(line);
                        Shows.Add(showFromFile);
                    }
                }
            }
            catch (IOException eIO)
            {
                throw new Exception("Eroare la deschiderea fisierului. Mesaj: " + eIO.Message);
            }
            catch (Exception eGen)
            {
                throw new Exception("Eroare generica. Mesaj: " + eGen.Message);
            }
            return Shows;
        }
        public show getShow(string name)
        {
            try
            {
                using (StreamReader Sr = new StreamReader(FileName))
                {
                    string line;
                    while ((line = Sr.ReadLine()) != null)
                    {
                        show showFromFile = new show(line);
                        if (showFromFile.name == name)
                            return showFromFile;
                    }
                }
            }
            catch (IOException eIO)
            {
                throw new Exception("Eroare la deschiderea fisierului. Mesaj: " + eIO.Message);
            }
            catch (Exception eGen)
            {
                throw new Exception("Eroare generica. Mesaj: " + eGen.Message);
            }
            return null;
        }
        public bool modifyShow(ArrayList modifiedshows)
        {
            File.Delete(FileName);
            Stream FILE = File.Open(FileName, FileMode.OpenOrCreate);
            FILE.Close();
            foreach (show s in modifiedshows)
                AddShow(s);
            return true;
        }

    }
}
