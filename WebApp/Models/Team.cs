namespace WebApp.Models
{
    public class Team : Base
    {
        public string PhotoUrl { get; set; }

        public string Name { get; set; }

        public string Position { get; set; }
        public List<TeamNetwork> TeamNetwork { get; set; }
    }
}