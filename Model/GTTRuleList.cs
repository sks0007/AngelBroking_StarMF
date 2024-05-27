namespace Mfund.Model
{
    public class GTTRuleList
    {
        public int clientid { get; set; }

        public DateTime createddate { get; set; }

        public string exchange { get; set; }

        public string producttype { get; set; }

        public string transactiontype { get; set; }

        public DateTime expirydate { get; set; }

        public int id { get; set; }

        public int qty { get; set; }

        public int price { get; set; }

        public string status { get; set; }

        public string symboltoken { get; set; }

        public string tradingsymbol { get; set; }

        public int triggerprice { get; set; }

        public DateTime updateddate { get; set; }
    }
}
