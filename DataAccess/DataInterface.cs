using LibraryModels;
using System.Collections;

namespace DataAccess
{
    public interface DataInterface
    {
        void AddShow(show s);
        ArrayList GetShows();
    }
}
