namespace csharpcore{
    class BackstagePassesItem : ISpecialItem{
        private Item item;

        public BackstagePassesItem(Item item){
            this.item = item;
        }

        public void UpdateItem(){
            DecreaseSellInByDay();

            if(item.SellIn >= 10){
                IncreaseQualityByValue(1);
            }
            else if(item.SellIn >= 5){
                IncreaseQualityByValue(2);
            }
            else if(item.SellIn >= 0){
                IncreaseQualityByValue(3);
            }
            else{
                QualityToValue(0);
            }
        }

        public void QualityToValue(int value){
            this.item.Quality = value;
        }

        public void DecreaseSellInByDay(){
            this.item.SellIn -= 1;
        }

        public void IncreaseQualityByValue(int value){
            this.item.Quality += value;
        }

    }
}