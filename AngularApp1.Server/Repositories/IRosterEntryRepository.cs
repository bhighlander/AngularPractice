using AngularApp1.Server.Models;

namespace AngularApp1.Server.Repositories
{
    public interface IRosterEntryRepository
    {
        List<RosterEntry> GetAll();
        RosterEntry GetById(int id);
        void UpdateRosterEntry(RosterEntry rosterEntry);
        void DeleteRosterEntry(int id);
        void AddRosterEntry(RosterEntry rosterEntry);
    }
}
