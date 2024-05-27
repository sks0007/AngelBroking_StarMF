namespace Mfund.Model
{
    public class PortfolioGetAllHoldings
    {
        public string tradingsymbol {  get; set; }  

        public string exchange {  get; set; }   

        public string isin { get; set; }    

        public string t1quantity { get; set; }

        public int realisedquantity { get; set; }   

        public int quantity { get; set; }   

        public int authorisedquantity { get; set; } 

        public string product {  get; set; }
        public string collateralquantity { get; set; }  

        public string collateraltype { get; set; }  

        public int haircut {  get; set; }

        public decimal averageprice {  get; set; }
        public decimal ltp { get; set; }

        public int symboltoken { get; set; }    

        public int close {  get; set; }

        public int profitandloss { get; set; }

        public decimal pnlpercentage { get; set; }

    }
}
