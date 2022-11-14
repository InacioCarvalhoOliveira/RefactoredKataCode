namespace csharp
{
    public class ContextComments : Item
    {
        private string AgedBrie { get; set; }
        private string Backstage { get; set; }
        private string Sulfuras { get; set; }
       
        public ContextComments(){}
      
        public ContextComments(string agedBrie, string backstage, string sulfuras)
        {
            this.AgedBrie  = agedBrie;
            this.Backstage = backstage;
            this.Sulfuras = sulfuras;   
        }

        public string agedBrieContext()
        {
            AgedBrie = "Aged Brie";
            return AgedBrie;

            
        }
        public string backstageContext()
        {
            Backstage = "Backstage passes to a TAFKAL80ETC concert";
            return Backstage;
        }
        public string sulfurasContext()
        {
            Sulfuras = "ASulfuras, Hand of Ragnaros";
            return Sulfuras;
        }

        

    }
}