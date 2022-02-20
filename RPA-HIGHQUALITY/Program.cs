using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace RPA_HIGHQUALITY
{
    class Program
    {
        static void Main(string[] args)
        {

            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://canvas.unapec.edu.do/login/saml");
            driver.Manage().Window.Maximize();

          
            IWebElement ele = driver.FindElement(By.Name("loginfmt"));
             ele.SendKeys("e.grullon12@unapec.edu.do"); 

              
            IWebElement btnsearch = driver.FindElement(By.Id("idSIButton9"));
              btnsearch.Click();

            IWebElement dos = driver.FindElement(By.Name("passwd"));
            dos.SendKeys("8maidito59#");

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);

            IWebElement btn = driver.FindElement(By.XPath("/html/body/div/form[1]/div/div/div[2]/div[1]/div/div/div/div/div/div[3]/div/div[2]/div/div[4]/div[2]/div/div/div/div/input"));
            btn.Submit();

            IWebElement button = driver.FindElement(By.Id("idBtn_Back"));
            button.Click();

            IWebElement select = driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div/div[2]/div[1]/div/div/div[3]/div/div[3]/div/div[1]/a/span[1]"));
            select.Click();

            IWebElement Doc = driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div[2]/div[3]/div[1]/div/div[2]/div[5]/div[2]/div[1]/div[2]/ul/li[2]/div/div[1]/div[1]/span/a"));
            Doc.Click();

            IWebElement Download = driver.FindElement(By.XPath("//*[@id='content']/div[1]/span/a"));
            Download.Click();

           

            
        }
    }
}
