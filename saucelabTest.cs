using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.Playwright;
using Microsoft.Playwright.NUnit;
using NUnit.Framework;
using PWTests.Engine;
using PWTests.Pages;

namespace PlaywrightTests;

[Parallelizable(ParallelScope.Self)]
[TestFixture]
public class Tests : PageTest
{
    [Test]
    public async Task saucelabtest()
    {
        HomePage home = new HomePage(Page);
        InventoryPage inventory = new InventoryPage(Page);
        
        await home.VisitHome();
        await home.EnterCredential("standard_user", "secret_sauce");
        await home.PressLogin();
        
        await inventory.AddProduct();
        await inventory.clickCart();
        
        await Page.Locator("[data-test=\"checkout\"]").ClickAsync();
        await Expect(Page).ToHaveURLAsync(new Regex("checkout-step-one"));
    }
}