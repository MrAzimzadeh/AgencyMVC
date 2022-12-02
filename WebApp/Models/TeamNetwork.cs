namespace WebApp.Models
{
    public class TeamNetwork : Base
    {
        public string UserUrl { get; set; }
        public int TeamId { get; set; }
        public Team Team { get; set; }
        public int SocialNetworkId { get; set; }
        public SocialNetwork SocialNetwork { get; set; }
    }
}