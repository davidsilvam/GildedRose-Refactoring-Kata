namespace csharpcore{
    class NormalItem : ISpecialItem{
        private Item item;

        public NormalItem(Item item){
            this.item = item;
        }

        public void UpdateItem(){
            DecreaseSellInByDay();
            if(item.SellIn >= 0){
                DecreaseQualityByValue(1);
            }else{
                DecreaseQualityByValue(2);
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