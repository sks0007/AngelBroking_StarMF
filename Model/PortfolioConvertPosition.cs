namespace Mfund.Model
{
    public class PortfolioConvertPosition
    {
        public string exchange { get; set; }

        public int symboltoken { get; set; }

        public string producttype { get; set; }

        public string newproducttype { get; set; }

        public string tradingsymbol { get; set; }

        public string symbolname { get; set; }

        public string instrumenttype { get; set; }

        public int priceden { get; set; }

        public int pricenum { get; set; }   
        public int genden { get; set; } 

        public int gennum {  get; set; }    

        public int precision { get; set; }  

        public int multiplier { get; set; } 

        public int boardlotsize { get; set; }

        public  int buyqty { get; set; }    

        public int sellqty { get; set; }    

        public decimal buyamount { get; set; }  

        public int sellamount { get; set; } 

        public string transactiontype { get; set; } 

        public int quantity { get; set; }   

        public string type { get; set; }
    }
}
