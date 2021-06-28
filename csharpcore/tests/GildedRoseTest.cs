using Xunit;
using System.Collections.Generic;
using Xunit.Abstractions;//added to debug

using ApprovalTests;
using ApprovalTests.Reporters;

using System.Text;

namespace csharpcore
{
    [UseReporter(typeof(DiffReporter))]
    public class GildedRoseTest
    {
        private readonly ITestOutputHelper _output;

        public GildedRoseTest(ITestOutputHelper output)
        {
            _output = output;
        }

        [Fact]
        public void foo()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "foo", SellIn = 0, Quality = 0 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            //  _output.WriteLine("Debug");
            Assert.Equal("foo", Items[0].Name);
        }

        [Fact]
        public void NormalItemIncreaseAndDecrease()
        {
            IList<Item> Items = new List<Item> {
                new Item {
                    Name = "+5 Dexterity Vest",
                    SellIn = 10,
                    Quality = 20
                },
                new Item {
                    Name = "Elixir of the Mongoose",
                    SellIn = 5,
                    Quality = 7
                }
            };

            GildedRose app = new GildedRose(Items);

            var fakeoutput = new StringBuilder();

            for (var i = 0; i < 31; i++)
            {
                fakeoutput.Append("-------- day " + i + " --------" + "\n");
                for (var j = 0; j < Items.Count; j++)
                {
                    fakeoutput.Append(Items[j].Name + ", " + Items[j].SellIn + ", " + Items[j].Quality + "\n");
                }
                app.UpdateQuality();
            }

            Approvals.Verify(fakeoutput);
        }

        [Fact]
        public void AgedBrieItemIncreaseAndDecrease()
        {
            IList<Item> Items = new List<Item> {
                new Item {
                    Name = "Aged Brie",
                    SellIn = 2,
                    Quality = 0
                }
            };

            GildedRose app = new GildedRose(Items);

            var fakeoutput = new StringBuilder();

            for (var i = 0; i < 31; i++)
            {
                fakeoutput.Append("-------- day " + i + " --------" + "\n");
                for (var j = 0; j < Items.Count; j++)
                {
                    fakeoutput.Append(Items[j].Name + ", " + Items[j].SellIn + ", " + Items[j].Quality + "\n");
                }
                app.UpdateQuality();
            }

            Approvals.Verify(fakeoutput);
        }

        [Fact]
        public void SulfurasItemIncreaseAndDecrease()
        {
            IList<Item> Items = new List<Item> {
                new Item {
                    Name = "Sulfuras, Hand of Ragnaros",
                    SellIn = 0,
                    Quality = 80
                },
                new Item {
                    Name = "Sulfuras, Hand of Ragnaros",
                    SellIn = -1,
                    Quality = 80
                }
            };

            GildedRose app = new GildedRose(Items);

            var fakeoutput = new StringBuilder();

            for (var i = 0; i < 31; i++)
            {
                fakeoutput.Append("-------- day " + i + " --------" + "\n");
                for (var j = 0; j < Items.Count; j++)
                {
                    fakeoutput.Append(Items[j].Name + ", " + Items[j].SellIn + ", " + Items[j].Quality + "\n");
                }
                app.UpdateQuality();
            }

            Approvals.Verify(fakeoutput);
        }

        [Fact]
        public void BackstagePassesItemIncreaseAndDecrease()
        {
            IList<Item> Items = new List<Item> {
               new Item
                {
                    Name = "Backstage passes to a TAFKAL80ETC concert",
                    SellIn = 15,
                    Quality = 20
                },
                new Item
                {
                    Name = "Backstage passes to a TAFKAL80ETC concert",
                    SellIn = 10,
                    Quality = 49
                },
                new Item
                {
                    Name = "Backstage passes to a TAFKAL80ETC concert",
                    SellIn = 5,
                    Quality = 49
                }
            };

            GildedRose app = new GildedRose(Items);

            var fakeoutput = new StringBuilder();

            for (var i = 0; i < 31; i++)
            {
                fakeoutput.Append("-------- day " + i + " --------" + "\n");
                for (var j = 0; j < Items.Count; j++)
                {
                    fakeoutput.Append(Items[j].Name + ", " + Items[j].SellIn + ", " + Items[j].Quality + "\n");
                }
                app.UpdateQuality();
            }

            Approvals.Verify(fakeoutput);
        }

        [Fact]
        public void ConjuredItemIncreaseAndDecrease()
        {
            IList<Item> Items = new List<Item> {
               new Item {
                   Name = "Conjured Mana Cake",
                   SellIn = 3,
                   Quality = 6
                }
            };

            GildedRose app = new GildedRose(Items);

            var fakeoutput = new StringBuilder();

            for (var i = 0; i < 31; i++)
            {
                fakeoutput.Append("-------- day " + i + " --------" + "\n");
                for (var j = 0; j < Items.Count; j++)
                {
                    fakeoutput.Append(Items[j].Name + ", " + Items[j].SellIn + ", " + Items[j].Quality + "\n");
                }
                app.UpdateQuality();
            }

            Approvals.Verify(fakeoutput);
        }
    }
}