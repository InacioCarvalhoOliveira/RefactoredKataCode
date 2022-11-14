using System.Collections.Generic;

namespace csharp
{
    public class GildedRose : ContextComments
    {
        public IList<Item> Items;
         public GildedRose(IList<Item> Items)
         {
             this.Items = Items;
         }


        public void UpdateQuality()
        {
            foreach (Item v in Items)
            {
                if (v.Name != agedBrieContext() && v.Name != backstageContext())
                {

                    if (v.Quality > 0)
                    {
                        MeasureQuality(v);
                    }
                }
                else
                {
                    if (v.Quality < 50)
                    {
                        v.Quality = v.Quality + 1;
                        if (v.Name == backstageContext())
                        {
                            if (v.SellIn < 11 || v.SellIn < 6)
                            {
                                SellPoints(v);
                            }                  
                        }
                    }
                }
                if (v.Name != sulfurasContext())
                {
                    v.SellIn = v.SellIn - 1;
                }
                
                if (v.SellIn < 0)
                {                   
                    if (v.Name != agedBrieContext() && v.Name != backstageContext() )
                    {                        
                        if (v.Quality > 0)
                        {
                            if (v.Quality > 0)
                            {
                                MeasureQuality(v);
                            }
                        }
                        else
                        {
                            v.Quality = v.Quality - v.Quality;
                        }
                    }
                    else
                    {
                        SellPoints(v);
                    }
                }
            }
        }

        private void SellPoints(Item v)
        {       
            
            if (v.Quality < 50)
            {
                v.Quality = v.Quality + 1;
            }
            
            
        }

        private void MeasureQuality(Item v)
        {
            
            if (v.Name != sulfurasContext())
            {
                v.Quality = v.Quality - 1;
            }
            
        }
    }
}
