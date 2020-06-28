using System.Collections.Generic;

namespace FolderWatcher
{
    public interface IDataService
    {
        void AddEvent(Event model);
        List<Event> GetEvent(string inName);
    }
}
