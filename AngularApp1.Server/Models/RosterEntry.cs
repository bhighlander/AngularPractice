namespace AngularApp1.Server.Models
{
    public class RosterEntry
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Title { get; set; }
        public required string JobDescription { get; set; }
    }
}
