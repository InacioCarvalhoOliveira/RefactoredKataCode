using System.Collections.Generic;

namespace csharp
{
    public class GildedRose : QualityAnalysis
    {
         IList<Item> Items;
         public GildedRose(IList<Item> Items)
         {
             this.Items = Items;
         }

        public void UpdateQuality()
        {
            foreach (Item v in Items)
            {
                calcMeasureQuality(v);

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
                            calcQualityPoints(v);
                        }
                        
                        else
                        {
                            v.Quality = v.Quality - v.Quality;
                        }
                    }
                    else
                    {
                        if (v.Quality < 50)
                        {
                            v.Quality = v.Quality + 1;
                        }
                    }
                }
            }
        }
        // private void AvaliarQualidade(Item v)
        // {
        //      if (v.Name != agedBrieContext() && v.Name != backstageContext())
        //      {
        //          PontuarQualidade(v);
        //      }
        //      else
        //      {
        //          if (v.Quality < 50)
        //          {
        //              v.Quality = v.Quality + 1;
        //             if (v.Name == backstageContext())
        //              {
        //                  PontuarVenda(v);
        //              }
        //          }
        //      }
        // }

        // private static void PontuarVenda(Item v)
        // {
        //     if (v.SellIn < 11 || v.SellIn < 6)
        //     {
        //         if (v.Quality < 50)
        //         {
        //             v.Quality = v.Quality + 1;
        //         }
        //     }
        // }

        // private void PontuarQualidade(Item v)
        // {
        //     if (v.Quality > 0)
        //     {
        //         if (v.Name != sulfurasContext())
        //         {
        //             v.Quality = v.Quality - 1;
        //         }
        //     }
        // }

    }
}
