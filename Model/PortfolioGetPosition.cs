namespace Mfund.Model
{
    public class PortfolioGetPosition
    {
        public string exchange {  get; set; }   

        public int symboltoken { get; set; }    

        public string producttype { get; set; } 

        public string tradingsymbol { get; set; }
        public string symbolname { get; set; }  

        public string instrumenttype { get; set; }
        public int priceden { get; set; }
        public int pricenum { get; set; }   

        public int genden { get; set; } 

        public int gennum { get; set; } 

        public int precision { get; set; }  

        public int multiplier { get; set; } 

        public int boardlotsize { get; set; }   
        public int buyqty { get; set; } 

        public int sellqty { get; set; }    

        public decimal buyamount { get; set; }  

        public int sellamount { get; set; } 

        public string symbolgroup { get; set; } 

        public int strikeprice { get; set; }

        public string optiontype { get; set; }  

        public DateOnly expirydate { get; set; }

        public int lotsize { get; set; }

        public int cfbuyqty { get; set; }   

        public int cfsellqty { get; set; }  

        public int cfbuyamount { get; set; }    

        public int cfsellamount { get; set; }   

        public decimal buyavgprice { get; set; }    

        public int sellavgprice { get; set; }

        public decimal avgnetprice { get; set; }    

        public decimal netvalue { get; set; }   

        public int netqty {  get; set; }    

        public decimal totalbuyvalue { get; set; }  

        public int totalsellvalue { get; set; }
        public int cfbuyavgprice { get; set; }  

        public int cfsellavgprice { get; set; }

        public decimal totalbuyavgprice { get; set; }   

        public int totalsellavgprice { get; set; }
        public int netprice { get; set; }   

    }
}
