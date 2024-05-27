namespace Mfund.Model
{
    public class OrderGetTradeBook
    {
        public string  exchange { get; set; }
        public string producttype { get; set; }
        public string tradingsymbol { get; set; }
        public string instrumenttype { get; set; }

        public string symbolgroup { get; set; }

        public string strikeprice { get; set; } 

        public string optiontype { get; set; }

        public DateTime expirydate {  get; set; }

        public int marketlot { get; set; }  

        public int precision { get; set; }  

        public int multiplier { get; set; }

        public decimal tradevalue { get; set; } 

        public string transactiontype {  get; set; }

        public decimal fillprice { get; set; }
        public int fillsize { get; set; }   

        public int orderid { get; set; }

        public int fillid { get; set; }

        public DateTime filltime { get; set; }

        public string uniqueorderid { get; set; }

    }
}
