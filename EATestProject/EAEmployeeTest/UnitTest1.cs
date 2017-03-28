using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;

using OpenQA.Selenium.Chrome;
using EAEmployeeTest.Pages;
using System.Threading;

namespace EAEmployeeTest
{
    [TestClass]
    public class UnitTest1
    {

        string url = "http://localhost:64429";

        private IWebDriver driver;
        [TestMethod]
        public void TestMethod1()
        {

            driver = new ChromeDriver();
            driver.Navigate().GoToUrl(url);

            Login();
        }


        public void Login()
        {

            LoginPage page = new LoginPage(driver);
            page.lnkLogin.Click();
            Thread.Sleep(1000);
            page.txtUserName.SendKeys("admin");
            page.txtPassword.SendKeys("password");
            page.btnLogin.Submit();
            //driver.FindElement(By.LinkText("Login")).Click();
            //driver.FindElement(By.Id("UserName")).SendKeys("admin");
            //driver.FindElement(By.Id("Password")).SendKeys("password");

            //driver.FindElement(By.CssSelector("input.btn")).Submit();
        }
    }
}
