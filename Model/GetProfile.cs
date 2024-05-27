namespace Mfund.Model
{
    public class GetProfile
    {
        public string clientCode { get; set; }
        public string name { get; set; }
        public string email { get; set; }

        public string mobileno { get; set; }

        public List<string> exchanges { get; set; }

        public List<string> products { get; set; }
        public string lastlogintime { get; set; }

        public string brokerid { get; set; }
    }
}
