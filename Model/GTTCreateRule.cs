namespace Mfund.Model
{
    public class GTTCreateRule
    {
        public string tradingsymbol { get; set; }
        public string symboltoken { get; set; }

        public string exchange { get; set; }

        public string transactiontype { get; set; }

        public string producttype { get; set; }

        public double price { get; set; }

        public int qty { get; set; }

        public double triggerprice { get; set; }

        public int disclosedqty { get; set; }

        public int timeperiod { get; set; }
    }
}
