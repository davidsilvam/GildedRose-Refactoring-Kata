namespace csharpcore{
    class BrieItem : ISpecialItem{
        private Item item;

        public BrieItem(Item item){
            this.item = item;
        }

        public void UpdateItem(){
            DecreaseSellInByDay();
            if(item.SellIn >= 0){
                IncreaseQualityByValue(1);
            }else{
                IncreaseQualityByValue(2);
            }
        }

        public void DecreaseSellInByDay(){
            this.item.SellIn -= 1;
        }

        public void IncreaseQualityByValue(int value){
            this.item.Quality += value;
        }

    }
}