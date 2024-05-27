namespace Mfund.Model
{
    public class OrderGetOrderBook
    {
        public string variety { get; set; }

        public string ordertype { get; set; }

        public string producttype { get; set; }

        public string duration { get; set; }

        public string price { get; set; }

        public string triggerprice { get; set; }

        public string quantity { get; set; }

        public string disclosedquantity { get; set; }

        public string squareoff { get; set; }

        public string stoploss { get; set; }

        public string trailingstoploss { get; set; }

        public string tradingsymbol { get; set; }

        public string transactiontype { get; set; }

        public string exchange { get; set; }

        public string symboltoken { get; set; }

        public string instrumenttype { get; set; }

        public int strikeprice { get; set; }

        public string optiontype { get; set; }

        public DateTime expirydate { get; set; }

        public string lostsize { get; set; }

        public string cancelsize { get; set; }

        public int averageprice { get; set; }

        public string filledshares { get; set; }

        public string unfilledshares { get; set; }

        public int orderid { get; set; }

        public string text { get; set; }

        public string status { get; set; }

        public string orderstatus { get; set; }

        public DateTime updatetime { get; set; }

        public string exchtime { get; set; }

        public string exchorderupdatetime { get; set; }

        public string fillid { get; set; }

        public string filltime { get; set; }
    }
}
