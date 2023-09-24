using PWTests.Engine;

namespace PWTests.Pages
{
    public class HomePage : BasePage
    {
        public HomePage(IPage page) : base(page) { }
        public async Task VisitHome()
        {
            await _page.GotoAsync("https://www.saucedemo.com/");
        }
        public async Task EnterCredential(string user,string pass)
        {
            ILocator userNameTextBox = _page.Locator("[data-test=\"username\"]");
            ILocator passwordTextBox = _page.Locator("[data-test=\"password\"]");

            await userNameTextBox.ClickAsync();
            await userNameTextBox.FillAsync(user);

            await passwordTextBox.ClickAsync();
            await passwordTextBox.FillAsync(pass);
        }
        public async Task PressLogin()
        {
            ILocator loginButton = _page.Locator("[data-test=\"login-button\"]");
            await loginButton.ClickAsync();
        }
    }
}
