using System.Collections;
using System.Collections.Generic;

namespace csharpcore{
    class ItemsManager{
        private Dictionary<string, ISpecialItem> LIST_ITEMS = new Dictionary<string, ISpecialItem>();
        private string BRIE  = "Aged Brie";
        private string BACKSTAGE_PASSES  = "Backstage passes to a TAFKAL80ETC concert";
        private string SULFURA  = "Sulfuras, Hand of Ragnaros";
        private string CONJURED  = "Conjured Mana Cake";

        public ItemsManager(Item item){
            LIST_ITEMS.Add(BRIE, new BrieItem(item));
            LIST_ITEMS.Add(BACKSTAGE_PASSES, new BackstagePassesItem(item));
            LIST_ITEMS.Add(SULFURA, new SulfuraItem(item));
            LIST_ITEMS.Add(CONJURED, new ConjuredItem(item));
        }

        public ISpecialItem SpecialItem(Item item) {
            if (IsNormalItem(item)) {
                return new NormalItem(item);
            }
            return LIST_ITEMS[item.Name];
        }

        public bool IsNormalItem(Item item){
            return !LIST_ITEMS.ContainsKey(item.Name);
        }

    }
}
