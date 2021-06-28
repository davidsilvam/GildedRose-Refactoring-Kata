using System.Collections.Generic;

namespace csharpcore
{
    public class GildedRose
    {
        public const int SMALLEST_QUALITY = 0;
        public const int BIGGEST_QUALITY = 50;
        public const int BIGGEST_QUALITY_SULFURA = 80;
        IList<Item> Items;
        public GildedRose(IList<Item> Items)
        {
            this.Items = Items;
        }

        public void UpdateQuality()
        {
            foreach (var item in Items) {
                new ItemsManager(item).SpecialItem(item).UpdateItem();
                if(item.Quality < SMALLEST_QUALITY){
                    item.Quality = SMALLEST_QUALITY;
                }else{
                    if(item.Name.Equals("Sulfuras, Hand of Ragnaros")){
                        item.Quality = BIGGEST_QUALITY_SULFURA;
                    }
                    else{
                        if(item.Quality > BIGGEST_QUALITY){
                            item.Quality = BIGGEST_QUALITY;
                        }
                    }
                }
            }
            // for (var i = 0; i < Items.Count; i++)
            // {   // Standart items. Not specials
            //     if (Items[i].Name != "Aged Brie" && Items[i].Name != "Backstage passes to a TAFKAL80ETC concert")
            //     {
            //         if (Items[i].Quality > 0)
            //         {
            //             if (Items[i].Name != "Sulfuras, Hand of Ragnaros")
            //             {
            //                 Items[i].Quality = Items[i].Quality - 1;//Normal decrement. Decrement by 1 per day
            //             }
            //         }
            //     }
            //     else//Special cases. if brie and backstage passes then quality incresses by day
            //     {
            //         if (Items[i].Quality < 50)//Item don't greater than 50
            //         {
            //             Items[i].Quality = Items[i].Quality + 1;//increment +1 by day

            //             if (Items[i].Name == "Backstage passes to a TAFKAL80ETC concert")//backstage special cases
            //             {
            //                 if (Items[i].SellIn < 11)
            //                 {
            //                     if (Items[i].Quality < 50)
            //                     {
            //                         Items[i].Quality = Items[i].Quality + 1;
            //                     }
            //                 }

            //                 if (Items[i].SellIn < 6)
            //                 {
            //                     if (Items[i].Quality < 50)
            //                     {
            //                         Items[i].Quality = Items[i].Quality + 1;
            //                     }
            //                 }
            //             }
            //         }
            //     }

            //     if (Items[i].Name != "Sulfuras, Hand of Ragnaros")//Decreaese day by 1
            //     {
            //         Items[i].SellIn = Items[i].SellIn - 1;
            //     }

            //     if (Items[i].SellIn < 0)//In case of ultra passed sell date
            //     {
            //         if (Items[i].Name != "Aged Brie")
            //         {
            //             if (Items[i].Name != "Backstage passes to a TAFKAL80ETC concert")
            //             {
            //                 if (Items[i].Quality > 0)
            //                 {
            //                     if (Items[i].Name != "Sulfuras, Hand of Ragnaros")
            //                     {//standart items decreases twice faster after sell date
            //                         Items[i].Quality = Items[i].Quality - 1;
            //                     }
            //                 }
            //             }
            //             else//If Backstage ultra passed of sell date quality is 0
            //             {
            //                 Items[i].Quality = Items[i].Quality - Items[i].Quality;
            //             }
            //         }
            //         else//Aged Brie increase twice faster after sell date
            //         {
            //             if (Items[i].Quality < 50)
            //             {
            //                 Items[i].Quality = Items[i].Quality + 1;
            //             }
            //         }
            //     }
            // }
        }
    }
}
