namespace WebApp.Models
{
    public class Portfolio :Base
    {
        public string SubTitle { get; set; }
        public string ProjectName { get; set; }
        public string PhotoUrl { get; set; }
        public string Description { get; set; }
        public string ClientName { get; set; }
        public int CategoryId { get; set; }
        public Category Category{ get; set; }
    }
}