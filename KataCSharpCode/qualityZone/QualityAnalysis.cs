using System.Collections.Generic;

namespace csharp
{
    public class QualityAnalysis: ContextComments
    {
         

        private string MeasureQuality { get; set; }
        private string SellPoints { get; set; }
        private string QualityPoints { get; set; }

        private List<Item> items = new List<Item>();

        // public List<Item> OptionsList
        // {
        //     get { return Items; }
        //     set { Items = value; }
        // }
        //public  IList<Item>Items { get; set; }

        // IList<Item> Items;
        //  public QualityAnalysis(List<Item> Items)
        //  {
        //      this.Items = Items;
        //  }
        
        public  QualityAnalysis(){}
        public QualityAnalysis(string measureQuality, string sellPoints, string qualityPoints)
        {            
            this.MeasureQuality = measureQuality;
            this.SellPoints = sellPoints;
            this.QualityPoints = qualityPoints; 
        }

        

        public void calcMeasureQuality(Item value)
        {
            foreach(Item v in items)
             if (v.Name != agedBrieContext() && v.Name != backstageContext())
             {
                 calcQualityPoints(value);
             }
             else
             {
                 if (v.Quality < 50)
                 {
                     v.Quality = v.Quality + 1;
                    if (v.Name == backstageContext())
                     {
                         calcSellPoints(value);
                     }
                 }
             }
        }

        public void calcSellPoints(Item value)
        {
            foreach(Item v in items)
            if (v.SellIn < 11 || v.SellIn < 6)
            {
                if (v.Quality < 50)
                {
                    v.Quality = v.Quality + 1;
                }
            }
        }

        public void calcQualityPoints(Item value)
        {
            foreach(Item v in items)
            if (v.Quality > 0)
            {
                if (v.Name != sulfurasContext())
                {
                    v.Quality = v.Quality - 1;
                }
            }
        }
           
        
        
        
    }
}