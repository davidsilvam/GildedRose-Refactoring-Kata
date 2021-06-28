namespace csharpcore{
    class ConjuredItem : ISpecialItem{
        private Item item;

        public ConjuredItem(Item item){
            this.item = item;
        }

        public void UpdateItem(){
            DecreaseSellInByDay();
            if(item.SellIn >= 0){
                DecreaseQualityByValue(2);
            }else{
                DecreaseQualityByValue(4);
            }
        }

        public void DecreaseSellInByDay(){
            this.item.SellIn -= 1;
        }

        public void DecreaseQualityByValue(int value){
            this.item.Quality -= value;
        }

    }
}