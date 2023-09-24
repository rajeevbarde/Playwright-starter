using PWTests.Engine;

namespace PWTests.Pages
{
    public class InventoryPage :  BasePage
    {
        public InventoryPage(IPage page) : base(page) {}
        public async Task AddProduct()
        {
            ILocator addToCard = _page.Locator("[data-test=\"add-to-cart-sauce-labs-backpack\"]");
            await addToCard.ClickAsync();
        }
        public async Task clickCart()
        {
            ILocator viewCart = _page.Locator("a").Filter(new() { HasText = "1" });
            await viewCart.ClickAsync();
        }     
    }
}
