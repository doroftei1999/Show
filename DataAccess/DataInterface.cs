using LibraryModels;
using System.Collections;

namespace DataAccess
{
    public interface DataInterface
    {
        void AddShow(show s);
        show getShow(string name);
        bool modifyShow(ArrayList modifiedshows);
        ArrayList GetShows();
    }
}
