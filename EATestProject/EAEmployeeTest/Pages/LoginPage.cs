using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Threading;

namespace EAEmployeeTest.Pages
{
    class LoginPage
    {
        public LoginPage(IWebDriver driver)
        {

            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How= How.LinkText , Using = "Login")]
        public IWebElement  lnkLogin { get; set; }
        
        [FindsBy(How = How.Id, Using = "UserName")]
        public IWebElement txtUserName { get; set; }

        [FindsBy(How = How.Id, Using = "Password")]
        public IWebElement txtPassword { get; set; }

        [FindsBy(How = How.CssSelector, Using = "input.btn")]
        public IWebElement btnLogin { get; set; }
    }
}
