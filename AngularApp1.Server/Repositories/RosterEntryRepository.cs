using AngularApp1.Server.Models;

namespace AngularApp1.Server.Repositories
{
    public class RosterEntryRepository : IRosterEntryRepository
    {
        private static readonly List<RosterEntry> RosterEntries = new List<RosterEntry>
        {
            new RosterEntry { Id = 1, Name = "Bob", JobDescription = "Dev Wrangler", Title = "Manager"},
            new RosterEntry { Id = 2, Name = "Alice", JobDescription = "Code Guru", Title = "Senior Developer" },
            new RosterEntry { Id = 3, Name = "Charlie", JobDescription = "Bug Squasher", Title = "QA Engineer" },
            new RosterEntry { Id = 4, Name = "Dana", JobDescription = "UI/UX Specialist", Title = "Designer" },
            new RosterEntry { Id = 5, Name = "Eve", JobDescription = "Data Magician", Title = "Data Scientist" },
            new RosterEntry { Id = 6, Name = "Frank", JobDescription = "Infrastructure Architect", Title = "DevOps Engineer" }

        };
        public List<RosterEntry> GetAll()
        {
            return RosterEntries;
        }
        public void AddRosterEntry(RosterEntry rosterEntry)
        {
            throw new NotImplementedException();
        }

        public void DeleteRosterEntry(int id)
        {
            throw new NotImplementedException();
        }

        public RosterEntry GetById(int id)
        {
            var entry = RosterEntries.Find(entry => entry.Id == id);
            return entry;
        }

        public void UpdateRosterEntry(RosterEntry rosterEntry)
        {
            var entry = RosterEntries.Find(e => e.Id == rosterEntry.Id);
            if (entry != null)
            {
                entry.Name = rosterEntry.Name;
                entry.JobDescription = rosterEntry.JobDescription;
                entry.Title = rosterEntry.Title;
            }
        }

    }
}
